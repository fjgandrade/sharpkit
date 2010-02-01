using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpKit.HtmlModel
{
	/// <summary>
	/// Represents a fragment of a document
	/// </summary>
	public class HtmlDocumentFragment : HtmlElement
	{
		internal HtmlDocumentFragment()
		{
			nodeType = 11;
		}
	}
}
