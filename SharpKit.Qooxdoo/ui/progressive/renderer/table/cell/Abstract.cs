// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.progressive.renderer.table.cell
{
    /// <summary>
	/// <para>Cell Renderer for Progressive&#8217;s Table.</para>
	/// <para>Many of the methods in this class accept a parameter called cellInfo.  This
	/// parameter is an object with the following members:</para>
	/// 
	/// 
	/// state
	/// 
	/// 
	/// The <see cref="qx.ui.progressive.State"/> object pertaining to this rendering
	/// session.
	/// 
	/// 
	/// rowDiv
	/// 
	/// 
	/// The "div" DOM element of the row in which this cell is to be added.
	/// 
	/// 
	/// element
	/// 
	/// 
	/// The entire element object returned by the data model.
	/// 
	/// 
	/// dataIndex
	/// 
	/// 
	/// The index into the data element provided by the data model.
	/// Effectively, this is the column number.
	/// 
	/// 
	/// cellData
	/// 
	/// 
	/// The data from the data model, to be rendered.  This the specific column
	/// data for the column being rendered, and is a shorthand for
	/// element.data[element.dataIndex].
	/// 
	/// 
	/// height Input/Output parameter!
	/// 
	/// 
	/// On input to a cell renderer, this contains the height, as determined to
	/// date, for the current row.  The first column being rendered will
	/// receive a height of zero.  Upon return, it may leave the height at
	/// zero, meaning that it will accept any minimum height, or may specify a
	/// minimum height by setting this member.  Subsequent column cell renderers
	/// will receive the maximum height specified by any previous cell
	/// renderer.  Upon completion of calling each of the cell renderers for a
	/// row, the row height will be set to the value found in this member.
	/// 
	/// 
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.progressive.renderer.table.cell.Abstract", OmitOptionalParameters = true, Export = false)]
    public abstract partial class Abstract : qx.core.Object
    {
		#region Methods

		public Abstract() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Given the provided cell information, generate the HTML for this
		/// cell.</para>
		/// </summary>
		/// <param name="cellInfo">See qx.ui.progressive.renderer.table.cell.Abstract class description for details</param>
		/// <returns>The HTML required to create this cell.</returns>
		[JsMethod(Name = "render")]
		public string Render(object cellInfo) { throw new NotImplementedException(); }

		#endregion Methods
    }
}