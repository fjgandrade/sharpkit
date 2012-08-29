﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.CodeDom.Compiler;

namespace SharpKit.ExtJs4.Generator
{
    class CodeModelExporter
    {
        public CodeModelExporter()
        {
            ExportXmlDoc = true;
            ExportXmlDocRemarks = true;
        }
        public Assembly Assembly { get; set; }
        HashSet<string> keywords = new HashSet<string>
        {
            "new",
            "namespace","using",
            "object",
            "delegate", "event", "class", "struct", "interface",
            "is",
            "switch",
            "true", "false",
            "params","lock","checked","fixed","private", "protected", "public", "internal", "static",
            "return", "override","virtual", "sealed","string","this", "base",
            "ref", "out"
        };

        #region Write

        private void Write( string s, params object[] args )
        {
            Writer.Write( s, args );
        }
        private void Write( string s )
        {
            Writer.Write( s );
        }
        private void WriteLine()
        {
            Writer.WriteLine();
        }
        private void WriteLine( string s, params object[] args )
        {
            Writer.WriteLine( s, args );
        }
        private void WriteLine( string s )
        {
            Writer.WriteLine( s );
        }
        private void BeginBlock()
        {
            WriteLine( "{" );
            Writer.Indent++;
        }
        private void EndBlock()
        {
            Writer.Indent--;
            WriteLine( "}" );
        }
        void WriteComma()
        {
            Write( ", " );
        }

        #endregion

        //string Class(Class ce, bool fullName)
        //{
        //    var s = Class(ce);
        //    if (fullName && ce.Namespace.IsNotNullOrEmpty())
        //        s = ce.Namespace + "." + s;
        //    return s;
        //}
        Class ContextClass;
        string Class( Class ce, Class context = null )
        {
            if ( context == null )
                context = ContextClass;
            string name = null;
            if ( ce.GenericArguments.Count > 0 )
                name = ce.Name.Substring( 0, ce.Name.IndexOf( "`" ) ) + ce.GenericArguments.StringConcat( t => Class( t ), "<", ", ", ">" );
            else
                name = ce.Name;
            if ( ce.Namespace.IsNotNullOrEmpty() )
            {
                if ( context != null && !context.Namespace.StartsWith( ce.Namespace ) )
                    name = ce.Namespace + "." + name;
                else if ( Assembly != null && this.Assembly.AllClasses.Count( t => t.Name == name ) > 1 )
                    name = ce.Namespace + "." + name;
            }
            return name;
        }
        string Identifier( string s )
        {
            if ( keywords.Contains( s ) )
                return "@" + s;
            s = s.Replace( " ", "_" ).Replace( "(", "_" ).Replace( ")", "_" ).Replace( "-", "_" );
            return s;
        }


        public void Export()
        {
            ExportHeader();
            Export( Assembly.Classes );
            //asm.Classes.ForEach(Export);
        }
        public void Export( List<Class> list )
        {
            list.GroupBy( t => t.Namespace ).ForEach( t => this.Namespace( t.Key, () => t.ForEach( ce =>
            {
                this.WriteLine( "#region {0}", ce.Name );
                this.Export( ce );
                this.WriteLine( "#endregion" );
            } ) ) );
            //asm.Classes.ForEach(Export);
        }

        public void ExportHeader()
        {
            WriteLine( "//***************************************************" );
            WriteLine( "//* This file was generated by tool" );
            WriteLine( "//* SharpKit" );
            WriteLine( "//* At: {0}", DateTime.Now );
            WriteLine( "//***************************************************" );
            Assembly.Usings.ForEach( t => WriteLine( "using {0};", t ) );
        }
        public void Export( Class ce )
        {
            ContextClass = ce;
            ExportXmlDoc2( ce );
            ce.Attributes.ForEach( Export );
            Write( "public {0}partial {1} {2}", ce.IsNew.If( "new " ), ce.IsInterface.If( "interface", "class" ), Identifier( ce.Name ) );
            var bases = new List<Class>();
            if ( ce.BaseClass != null )
                bases.Add( ce.BaseClass );
            bases.AddRange( ce.Interfaces );
            if ( bases.Count > 0 )
            {
                Write( " : " );
                bases.ForEachJoin( t => Write( "{0}", Class( t ) ), WriteComma );
            }
            WriteLine();
            BeginBlock();
            ce.Members.ForEach( Export );
            ce.SubClasses.ForEach( Export );
            EndBlock();
            ContextClass = null;
        }
        private void Export( Method me )
        {
            ExportXmlDoc2( me );
            me.Attributes.ForEach( Export );
            if ( me.IsConstructor )
            {
                Write( "public {0}(", Identifier( me.DeclaringClass.Name ) );
                me.Parameters.ForEachJoin( Export, WriteComma );
                Write( ")" );
                //if ( me.DeclaringClass.BaseClass != null )
                //{
                //    var baseCtors = me.DeclaringClass.BaseClass.Members.OfType<Method>().Where( t => t.IsConstructor ).ToList();
                //    if ( baseCtors.Count > 0 && baseCtors.Where( t => t.Parameters.Count == 0 ).FirstOrDefault() == null )
                //    {
                //        Write( " : base(" );
                //        baseCtors.First().Parameters.ForEachJoin( p => Write( "null" ), WriteComma );
                //        Write( ")" );
                //    }
                //}
                WriteLine( "{}" );
            }
            else
            {
                ExportVisibility( me );
                Write( "{0}{1}{2}{3}{4}{5} {6}(", me.IsStatic.If( "static " ), me.IsVirtual.If( "virtual " ), me.IsOverride.If( "override " ), me.IsNew.If( "new " ), me.Type == null ? "void" : Class( me.Type ), me.ReturnsArray.If( "[]" ), Identifier( me.Name ) );
                me.Parameters.ForEachJoin( Export, WriteComma );
                Write( ")" );
                if ( me.DeclaringClass.IsInterface )
                {
                    WriteLine( ";" );
                }
                else
                {
                    Write( "{" );
                    if ( me.Type != null && me.Type.Name != "void" )
                    {
                        if ( me.Type.Name == "bool" )
                            Write( "return false;" );
                        else
                            Write( "return null;", Class( me.Type ) );
                    }
                    WriteLine( "}" );
                }
            }
        }


        private void Export( Parameter prm )
        {
            Write( "{0}{1}{2} {3}", prm.IsParams.IfTrue( "params " ), Class( prm.Type ), prm.IsParams.IfTrue( "[]" ), Identifier( prm.Name ) );
            if ( prm.IsOptional )
            {
                if ( prm.Type.Name == "bool" )
                    Write( "=false" );
                else
                    Write( "=null" );
            }
        }

        void Export( Element el )
        {
            if ( el is Method )
                Export( ( Method ) el );
            else if ( el is Property )
                Export( ( Property ) el );
            else if ( el is Class )
                Export( ( Class ) el );
            else if ( el is Event )
                Export( ( Event ) el );
            else if ( el is Field )
                Export( ( Field ) el );
            else
                throw new Exception();
        }

        private void Export( Field pe )
        {
            ExportXmlDoc2( pe );
            pe.Attributes.ForEach( Export );
            Write( "public {0}{1}{2}{3}{4} {5}", pe.IsStatic.If( "static " ), pe.IsVirtual.If( "virtual " ), pe.IsOverride.If( "override " ), pe.IsNew.If( "new " ), Class( pe.Type ), Identifier( pe.Name ) );
            if ( pe.Initializer.IsNotNullOrEmpty() )
                Write( "={0}", pe.Initializer );
            WriteLine( ";" );
        }
        private void Export( Property pe )
        {
            ExportXmlDoc2( pe );
            pe.Attributes.ForEach( Export );
            ExportVisibility( pe );
            WriteLine( "{0}{1}{2}{3}{4} {5}{{get;set;}}", pe.IsStatic.If( "static " ), pe.IsVirtual.If( "virtual " ), pe.IsOverride.If( "override " ), pe.IsNew.If( "new " ), Class( pe.Type ), Identifier( pe.Name ) );
        }

        private void ExportVisibility( Element el )
        {
            if ( !( el is Class ) )
            {
                var ce = el.DeclaringClass;
                if ( !ce.IsInterface )
                {
                    if ( el.IsProtected )
                    {
                        Write( "protected " );
                    }
                    else if ( el.IsPrivate )
                    {
                        Write( "private " );
                    }
                    else
                    {
                        Write( "public " );
                    }
                }
            }
        }

        private void Export( Event pe )
        {
            ExportXmlDoc2( pe );
            pe.Attributes.ForEach( Export );
            ExportVisibility( pe );
            WriteLine( "event {0}{1}{2}{3}{4} {5};", pe.IsStatic.If( "static " ), pe.IsVirtual.If( "virtual " ), pe.IsOverride.If( "override " ), pe.IsNew.If( "new " ), Class( pe.Type ), Identifier( pe.Name ) );
        }


        private void Namespace( string ns, Action action )
        {
            if ( ns.IsNotNullOrEmpty() )
            {
                WriteLine( "namespace {0}", ns );
                BeginBlock();
            }
            action();
            if ( ns.IsNotNullOrEmpty() )
            {
                EndBlock();
            }
        }
        #region XmlDoc


        public bool ExportXmlDoc { get; set; }
        public bool ExportXmlDocRemarks { get; set; }

        void WriteXmlDoc( string ss )
        {
            if ( string.IsNullOrEmpty( ss ) )
                return;
            ss.Split( new string[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries ).ForEach( t =>
            {
                var s = t.Trim();
                if ( s.IsNotNullOrEmpty() )
                    WriteLine( "/// " + s );
            } );

        }
        void ExportXmlDoc2( Element me )
        {
            if ( ExportXmlDoc )
            {
                if ( me is Class )
                {
                    var c = me as Class;
                    if ( c.BaseClass != null )
                    {
                        this.WriteLine( "/// <inheritdocs />" );
                    }
                }
                if ( me.Summary != null )
                {
                    WriteLine( "/// <summary>" );
                    WriteXmlDoc( me.Summary );
                    WriteLine( "/// </summary>" );
                }
                if ( me is Method )
                {
                    if ( ( me as Method ).ParametersDocs != null )
                        this.WriteXmlDoc( ( me as Method ).ParametersDocs );
                    if ( ( me as Method ).ReturnsDocs != null )
                    {
                        WriteLine( "/// <returns>" );
                        this.WriteXmlDoc( ( me as Method ).ReturnsDocs );
                        WriteLine( "/// </returns>" );
                    }
                }
                if ( ExportXmlDocRemarks && me.Remarks != null )
                {
                    //WriteLine("/// <remarks>");
                    WriteXmlDoc( me.Remarks );
                    //WriteLine("/// </remarks>");
                }
            }
        }

        #endregion
        void Export( Attribute att )
        {
            Write( "[{0}", att.Name );
            if ( att.Parameters.Count > 0 || att.NamedParamters.Count > 0 )
            {
                Write( "(" );
                att.Parameters.ForEachJoin( Write, WriteComma );
                if ( att.Parameters.Count > 0 && att.NamedParamters.Count > 0 )
                    Write( ", " );
                att.NamedParamters.ForEachJoin( t => Write( "{0}={1}", t.Key, t.Value ), WriteComma );
                Write( ")" );
            }
            WriteLine( "]" );
        }

        public IndentedTextWriter Writer { get; set; }

    }
}