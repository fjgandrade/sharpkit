// ==UserScript==
// @name          IE Emulator
// @namespace     http://dean.edwards.name/weblog/2005/03/ie-emulator
// @description	  Pretend to be Internet Explorer
// @include       http://www.example.com/
// ==/UserScript==


// IE Emulator version 1.0.1 (2005-08-18)
// Copyright 2005, Dean Edwards
// This software is licensed under the CC-GNU LGPL
// Web: http://creativecommons.org/licenses/LGPL/2.1/

function EnableIEEmulator(win)
{
	win = win || window;
	if (win["IEEmulatorEnabled"])
		return;
	win["IEEmulatorEnabled"] = true;

//Possible prefixes ActiveX strings for DOM DOcument
win.ARR_ACTIVEX = ["MSXML4.DOMDocument", "MSXML3.DOMDocument", "MSXML2.DOMDocument", "MSXML.DOMDocument", "Microsoft.XmlDom"];

//When the proper prefix is found, store it here
win.STR_ACTIVEX = "";

var isIE = navigator.userAgent.toLowerCase().indexOf("msie") > -1;
var isMoz = document.implementation && document.implementation.createDocument;
var isWebkit = navigator.userAgent.indexOf("WebKit") > -1; //navigator.vendor == "Apple Computer, Inc.";

if (isMoz || isWebkit)
{
	win.Debug = { writeln: function(s) { } };
	if (isWebkit)
	{	
		win.Event.prototype.__defineGetter__("originalTarget", function() { return this.target; });
	}
	win.isChildOf = function isChildOf(c, p)
	{
		try
		{
			if (c == null || p == null || c.document == null || p.document == null)
				return false;
			while (c != null)
			{
				c = c.parentNode;
				if (c == p)
					return true;
			}
			return false;
		}
		catch (e)
		{
		}
	}
//-----------------------------------------------------------------
// Factory jsXML
//-----------------------------------------------------------------
// Author(s)
//  Nicholas C. Zakas (NCZ), 1/30/02
//
// Description
//  This factory will serve as the entry point for other XML-related
//  implementations.
//
// Parameters
//  (none)
//-----------------------------------------------------------------
function jsXML() { }

//-----------------------------------------------------------------
// Function jsXML.createDocument()
//-----------------------------------------------------------------
// Author(s)
//  Nicholas C. Zakas (NCZ), 1/30/02
//
// Description
//  This function creates a XML Document according to which browser
//  is being used.
//
// Parameters
//  strNamespaceURI (String) - the namespace for this document (optional).
//  strRootTagName (String) - the tag name for the documentElement (optional).
//
// Returns
//  The XML Document object that was created.
//-----------------------------------------------------------------
jsXML.createDOMDocument = function(strNamespaceURI, strRootTagName) {

    //variable for the created DOM Document
    var objDOM = null;
    
    //determine if this is a standards-compliant browser like Mozilla
    if (isMoz || isWebkit) 
    {
        //create the DOM Document the standards way
        objDOM = document.implementation.createDocument(strNamespaceURI, strRootTagName, null);    
    
        //add the event listener for the load event
        objDOM.addEventListener("load", _Document_onload, false);

    } 
    else if (isIE) 
    {
    
        //create the DOM Document the IE way
        objDOM = new ActiveXObject(STR_ACTIVEX);

        //if there is a root tag name, we need to preload the DOM
        if (strRootTagName) {
       
            //If there is both a namespace and root tag name, then
            //create an artifical namespace reference and load the XML.  
            if (strNamespaceURI) {
                objDOM.loadXML("<a0:" + strRootTagName + " xmlns:a0=\"" + strNamespaceURI + "\" />");
            } else {
                objDOM.loadXML("<" + strRootTagName + "/>");        
            }
        
        }
    }
    
    //return the object
    return objDOM;
}

//-----------------------------------------------------------------
// Functon _Node_getXML()
//-----------------------------------------------------------------
// Author(s)
//  Nicholas C. Zakas (NCZ), 2/23/02
//
// Description
//  This is the attribute getter for the .xml attribute.
//
// Parameters
//  (none)
//
// Returns
//  A string with the XML of the Node calling this function.
//-----------------------------------------------------------------
function _Node_getXML() {
    
    //create a new XMLSerializer
    var objXMLSerializer = new XMLSerializer;
    
    //get the XML string
    var strXML = objXMLSerializer.serializeToString(this);
    
    //return the XML string
    return strXML;
}


//-----------------------------------------------------------------
// Function _Document_load()
//-----------------------------------------------------------------
// Author(s)
//  Nicholas C. Zakas (NCZ), 2/24/02
//
// Description
//  This function replaces the native load() method to allow for
//  readyState changes.
//
// Parameters
//  strURL (String) - The XML file to load.
//
// Returns
//  (nothing)
//-----------------------------------------------------------------
function _Document_load(strURL) {

    //set the parseError to 0
    this.parseError = 0;

    //change the readyState
    changeReadyState(this, 1);
    
    //watch for errors
    try {
        //call the original load method
        this.__load__(strURL);
        
    } catch (objException) {
    
        //set the parseError attribute
        this.parseError = -9999999;
        
        //change the readystate
        changeReadyState(this, 4);

    } // End: try...catch
}

//-----------------------------------------------------------------
// Function _Document_onload()
//-----------------------------------------------------------------
// Author(s)
//  Nicholas C. Zakas (NCZ), 2/24/02
//
// Description
//  This function is the event handler for the load event.
//
// Parameters
//  (none)
//
// Returns
//  (nothing)
//-----------------------------------------------------------------
function _Document_onload() {

    //handle the onload event
    handleOnLoad(this);
}

//-----------------------------------------------------------------
// Function handleOnLoad()
//-----------------------------------------------------------------
// Author(s)
//  Nicholas C. Zakas (NCZ), 2/24/02
//
// Description
//  This function handles the load event on the Document object.
//
// Parameters
//  objDOMDocument (Document) - the DOM Document object that has been loaded.
//
// Returns
//  (nothing)
//-----------------------------------------------------------------
function handleOnLoad(objDOMDocument) {
    //check for a parsing error
    if (!objDOMDocument.documentElement || objDOMDocument.documentElement.tagName == "parsererror")
        objDOMDocument.parseError = -9999999;

    //change the readyState
    changeReadyState(objDOMDocument, 4);
}

//-----------------------------------------------------------------
// Function changeReadyState()
//-----------------------------------------------------------------
// Author(s)
//  Nicholas C. Zakas (NCZ), 2/24/02
//
// Description
//  This function changes the readyState of a Document to the desired
//  state and runs any event handler the user has assigned.
//
// Parameters
//  objDOMDocument (Document) - the DOM Document object that has been loaded.
//  iReadyState (int) - the readyState to set the DOM Document to.
//
// Returns
//  (nothing)
//-----------------------------------------------------------------
function changeReadyState(objDOMDocument, iReadyState) {

    //change the readyState
    objDOMDocument.readyState = iReadyState;
    
    //if there is an onreadystatechange event handler, run it
    if (objDOMDocument.onreadystatechange != null && typeof objDOMDocument.onreadystatechange == "function")
        objDOMDocument.onreadystatechange();
}



    //add the loadXML() method to the Document class
win.Document.prototype.loadXML = function(strXML)
{
    
        //change the readystate
        changeReadyState(this, 1);

        //create a DOMParser
        var objDOMParser = new DOMParser();
        
        //create new document from string
        var objDoc = objDOMParser.parseFromString(strXML, "text/xml");
        
        //make sure to remove all nodes from the document
		while (this.hasChildNodes())
			this.removeChild(this.lastChild);
            
        //add the nodes from the new document
        for (var i=0; i < objDoc.childNodes.length; i++) {
            
            //import the node
            var objImportedNode = this.importNode(objDoc.childNodes[i], true);
            
            //append the child to the current document
            this.appendChild(objImportedNode);
        
        } //End: for
        
        //we can't fire the onload event, so we fake it
        handleOnLoad(this);
        
    } //End: function
    
    //add the getter for the .xml attribute
    win.Node.prototype.__defineGetter__("xml", _Node_getXML);
    
    //add the readystate attribute for a Document
    win.Document.prototype.readyState = "0";
    
    //save a reference to the original load() method
    win.Document.prototype.__load__ = Document.prototype.load;

    //create our own load() method
    win.Document.prototype.load = _Document_load;
    
    //add the onreadystatechange attribute
    win.Document.prototype.onreadystatechange = null;
    
    //add the parseError attribute
    win.Document.prototype.parseError = 0;


    //emulate contains on FireFox (http://www.quirksmode.org/blog/archives/2006/01/contains_for_mo.html)
    if (window.Node && Node.prototype && !Node.prototype.contains) {
    	Node.prototype.contains = function(arg) {
    		return !!(this.compareDocumentPosition(arg) & 16)
    	}
    }
    
} //End: if



if (isMoz || isWebkit)
	(function()
	{
		// ------------------------------------------------------------------
		//  explorer emulation for firefox
		// ------------------------------------------------------------------

		// originally part of: http://dean.edwards.name/moz-behaviors/
		// thanks to Erik Arvidsson (http://webfx.eae.net/dhtml/ieemu/)

		/* note: in my comments where i say support/mimic a property:
		support = exactly the same as internet explorer
		mimic = close enough
		*/
		if (isMoz && !isWebkit)
		{
			win.Window.prototype.__defineGetter__("screenTop", function()
			{
				return this.screenY;
			});
			win.Window.prototype.__defineGetter__("screenLeft", function()
			{
				return this.screenX;
			});
		}


		win.HTMLElement.prototype.__defineGetter__("document", function()
		{
			return this.ownerDocument;
		});


		function getBaseName()
		{
			var t = this.nodeName;
			var idx = t.indexOf(':');
			if (idx == -1)
				return t;
			return t.substring(idx + 1);
		}

		win.HTMLElement.prototype.__defineGetter__("baseName", getBaseName);
		win.Element.prototype.__defineGetter__("baseName", getBaseName);
		win.Attr.prototype.__defineGetter__("baseName", getBaseName);

		// return a node of type ELEMENT_NODE
		win.getElementNode = function getElementNode($node)
		{
			while ($node && $node.nodeType != Node.ELEMENT_NODE)
			{
				$node = $node.parentNode;
			}
			return $node;
		};

		// For sniffers
		// ------------
		/*navigator.__defineGetter__("appName", function()
		{
		return "Microsoft Internet Explorer";
		});
		var $appVersion = navigator.appVersion;
		navigator.__defineGetter__("appVersion", function()
		{
		return $appVersion + " (compatible; MSIE 6.0;)";
		});
		var $userAgent = navigator.userAgent;
		navigator.__defineGetter__("userAgent", function()
		{
		return $userAgent + " (compatible; MSIE 6.0;)";
		});*/

		// mimic ActiveXObject (XMLHTTP only)
		win.ActiveXObject = XMLHttpRequest;
		// CSSStyleDeclaration
		// -------------------
		// support microsoft's styleFloat
		//styleFloat property DOESN'T WORK IN CHROME - getter and setter aren't invoked!!!!
		win.CSSStyleDeclaration.prototype.__defineGetter__("styleFloat", function()
		{
			return this.cssFloat;
		});
		win.CSSStyleDeclaration.prototype.__defineSetter__("styleFloat", function($value)
		{
			this.cssFloat = $value;
		});
		// mimic microsoft's pixel representations of left/top/width/height
		// the getters only work for values that are already pixels
		win.CSSStyleDeclaration.prototype.__defineGetter__("pixelLeft", function()
		{
			return parseInt(this.left) || 0;
		});
		win.CSSStyleDeclaration.prototype.__defineSetter__("pixelLeft", function($value)
		{
			this.left = $value + "px";
		});
		win.CSSStyleDeclaration.prototype.__defineGetter__("pixelHeight", function()
		{
			return parseInt(this.height) || 0;
		});
		win.CSSStyleDeclaration.prototype.__defineSetter__("pixelHeight", function($value)
		{
			this.height = $value + "px";
		});
		win.CSSStyleDeclaration.prototype.__defineGetter__("pixelTop", function()
		{
			return parseInt(this.top) || 0;
		});
		win.CSSStyleDeclaration.prototype.__defineSetter__("pixelTop", function($value)
		{
			this.top = $value + "px";
		});
		win.CSSStyleDeclaration.prototype.__defineGetter__("pixelWidth", function()
		{
			return parseInt(this.width) || 0;
		});
		win.CSSStyleDeclaration.prototype.__defineSetter__("pixelWidth", function($value)
		{
			this.width = $value + "px";
		});
		//		// for older versions of gecko we need to use getPropertyValue() to
		//		// access css properties returned by getComputedStyle().
		//		// we don't want this so we fix it.
		//		try
		//		{
		//			var $computedStyle = getComputedStyle(this, null);
		//			// the next line will throw an error for some versions of mozilla
		//			var $test = $computedStyle.display;
		//		} catch ($ignore)
		//		{
		//			// the previous line will throw an error for some versions of mozilla
		//		} finally
		//		{
		//			if (!$test)
		//			{
		//				// the above code didn't work so we need to fix CSSStyleDeclaration
		//				var $UPPER_CASE = /[A-Z]/g;
		//				function _dashLowerCase($match) { return "-" + $match.toLowerCase() };
		//				function _cssName($propertyName) { return $propertyName.replace($UPPER_CASE, _dashLowerCase) };
		//				function _assignStyleGetter($propertyName)
		//				{
		//					var $cssName = _cssName($propertyName);
		//					CSSStyleDeclaration.prototype.__defineGetter__($propertyName, function()
		//					{
		//						return this.getPropertyValue($cssName);
		//					});
		//				};
		//				for (var $propertyName in this.style)
		//				{
		//					if (typeof this.style[$propertyName] == "string")
		//					{
		//						_assignStyleGetter($propertyName);
		//					}
		//				}
		//			}
		//		}
		//		// XML Support
		// -----------
		function selectNodes($document, $queryString, $contextNode)
		{
			var $result = $document.evaluate($queryString, $contextNode, $document.createNSResolver($document.documentElement),
        XPathResult.ORDERED_NODE_SNAPSHOT_TYPE, null);
			var $nodeList = [];
			for (i = 0; i < $result.snapshotLength; i++)
			{
				$nodeList[i] = $result.snapshotItem(i);
			}
			return $nodeList;
		};
		function selectSingleNode($document, $queryString, $contextNode)
		{
			return selectNodes($document, $queryString + "[1]", $contextNode)[0];
		};
		win.Document.prototype.__defineGetter__("xml", function()
		{
			return (new XMLSerializer).serializeToString(this);
		});
		win.XMLDocument.prototype.selectNodes = function($queryString)
		{
			return selectNodes(this, $queryString, this);
		};
		win.XMLDocument.prototype.selectSingleNode = function($queryString)
		{
			return selectSingleNode(this, $queryString, null);
		};
		win.Element.prototype.selectNodes = function($queryString)
		{
			return (this.ownerDocument.selectNodes) ?
        selectNodes(this.ownerDocument, $queryString, this) : null;
		};
		win.Element.prototype.selectSingleNode = function($queryString)
		{
			return (this.ownerDocument.selectSingleNode) ?
        selectSingleNode(this.ownerDocument, $queryString, this) : null;
		};
		win.Element.prototype.__defineGetter__("text", function()
		{
			return this.textContent;
		});
		// HTMLDocument
		// ------------
		// support microsoft's "all" property
		win.HTMLDocument.prototype.__defineGetter__("all", function()
		{
			return this.getElementsByTagName("*");
		});
		// support microsoft's "scripts" property
		win.HTMLDocument.prototype.__defineGetter__("scripts", function()
		{
			return this.getElementsByTagName("script");
		});
		// mimic the "createEventObject" method for the document object
		win.HTMLDocument.prototype.createEventObject = function(ee)
		{
			if (ee != null)
			{
				if (!isWebkit && (ee.type == "keydown" || ee.type == "keyup" || ee.type == "keypress"))
				{
					var e = document.createEvent("KeyboardEvent");
					e.initKeyEvent(ee.type, ee.bubbles, ee.cancelable, ee.viewArg, ee.ctrlKey, ee.altKey, ee.shiftKey, ee.metaKey, ee.keyCode, ee.charCode);
					if (ee.$preventedDefault || ee.returnValue != null)
					{
						e.preventDefault();
					}
					return e;
				}//initKeyEvent and initEvent doesn't work in chrome
				else if (isWebkit || ee.type == "mousemove" || ee.type == "mousedown" || ee.type == "mouseup" || ee.type == "click" || ee.type == "dblclick")
				{
					var e = document.createEvent("MouseEvents");
					e.initMouseEvent(ee.type, ee.bubbles, ee.cancelable, ee.viewArg, ee.detail, ee.screenX, ee.screenY, ee.clientX, ee.clientY, ee.ctrlKey, ee.altKey, ee.shiftKey, ee.metaKey, ee.button, ee.relatedTarget);
					if (ee.$preventedDefault || ee.returnValue != null)
					{
						e.preventDefault();
					}
					return e;
				}
				else
				{
					throw new Error("createEventObject not implemented in FireFox for eventType: " + ee.type);
				}
			}
			return document.createEvent("Events");
		};
		// HTMLElement
		// -----------
		// mimic microsoft's "all" property
		//HTMLElement.prototype.__defineGetter__("all", function() {
		//	return this.getElementsByTagName("*");
		//});
		// support "parentElement"
		function get_Children()
		{
			var ret = [];
			var t = this.firstChild;
			while (t != null)
			{
				if (t.nodeType == 1)
					ret.push(t);
				t = t.nextSibling;
			}
			return ret;
		}

		win.Element.prototype.__defineGetter__("children", get_Children);
		win.HTMLElement.prototype.__defineGetter__("children", get_Children);

		// support "parentElement"
		win.HTMLElement.prototype.__defineGetter__("parentElement", function()
		{
			return (this.parentNode == this.ownerDocument) ? null : getElementNode(this.parentNode);
		});


		// support "uniqueID"
		win.HTMLElement.prototype.__defineGetter__("uniqueID", function()
		{
			// a global counter is stored privately as a property of this getter function.
			// initialise the counter
			if (!arguments.callee.count) arguments.callee.count = 0;
			// create the id and increment the counter
			var $uniqueID = "moz_id" + arguments.callee.count++;
			// creating a unique id, creates a global reference
			win[$uniqueID] = this;
			// we don't want to increment next time, so redefine the getter
			this.__defineGetter__("uniqueID", function() { return $uniqueID });
			return $uniqueID;
		});
		// mimic microsoft's "currentStyle"
		win.HTMLElement.prototype.__defineGetter__("currentStyle", function()
		{
			return this.document.defaultView.getComputedStyle(this, null); //changed by dan-el
			//return getComputedStyle(this, null);
		});
		// mimic microsoft's "runtimeStyle"
		win.HTMLElement.prototype.__defineGetter__("runtimeStyle", function()
		{
			//# this doesn't work yet (https://bugzilla.mozilla.org/show_bug.cgi?id=45424)
			//#	return this.ownerDocument.defaultView.getOverrideStyle(this, null);
			return this.style;
		});
		// support "innerText"
		win.HTMLElement.prototype.__defineGetter__("innerText", function()
		{
			return this.textContent;
		});
		win.HTMLElement.prototype.__defineSetter__("innerText", function($value)
		{
			this.textContent = $value;
		});
		win.DocumentFragment.prototype.__defineGetter__("innerText", function()
		{
			return this.textContent;
		});
		win.DocumentFragment.prototype.__defineSetter__("innerText", function($value)
		{
			this.textContent = $value;
		});
		//		// mimic the "createEventObject" method - there is no createEventObject on HtmlElement
		//		HTMLElement.prototype.createEventObject = function(e)
		//		{
		//			if (e != null)
		//			{
		//				if (e.type == "keypress" || e.type == "keydown")
		//				{
		//					debugger;
		//					var ee = this.ownerDocument.createEvent("KeyEvents");
		//					ee.initKeyEvent(e.type, true, true, null, e.ctrlKey, e.altKey, e.shiftKey, e.metaKey, e.keyCode, e.charCode);
		//					return ee;
		//				}
		//			}
		//			return this.ownerDocument.createEvent();
		//		};
		// mimic the "fireEvent" method
		win.HTMLElement.prototype.fireEvent = function($name, $event)
		{
			if (!$event)
			{
				$event = this.ownerDocument.createEventObject();
				$event.initEvent($name.slice(2), false, false); //otherise inited event get erased (bubbled turns to false), TODO: find how to know if event is initialized
			}
			this.dispatchEvent($event);
			// not sure that this should be here??
			if (typeof (this[$name]) == "function")
				this[$name]();
			else if (this.getAttribute($name))
				eval(this.getAttribute($name));
		};
		// support the "contains" method
		win.HTMLElement.prototype.contains = function($element)
		{
			return Boolean($element == this || ($element && this.contains($element.parentElement)));
		};
		// support the "removeNode" method
		win.HTMLElement.prototype.removeNode = function(bChildren)
		{
			if (bChildren)
			{
				return this.parentNode.removeChild(this);
			}
			else
			{
				var child = this.firstChild;
				while (child != null)
				{
					var next = child.nextSibling;
					this.parentNode.insertBefore(child, this);
					child = next;
				}
				return this.parentNode.removeChild(this);
			}
		};
		win.HTMLElement.prototype.insertAdjacentText = function($where, $text)
		{
			if ($where == "beforeEnd" && this.lastChild != null && this.lastChild.nodeType == 3)
			{
				this.lastChild.data += $text;
			}
			else
			{
				return this.insertAdjacentElement($where, this.document.createTextNode($text));
			}
		};
		//		HTMLElement.prototype.insertAdjacentHTML = function($where, $html)
		//		{
		//			var fragment = this.document.createDocumentFragment();
		//			fragment.innerHTML = $html;
		//			this.insertAdjacentElement(fragment);
		//		};

		// support the "insertAdjacentElement" method
		win.HTMLElement.prototype.insertAdjacentElement = function($where, $element)
		{
			switch ($where.toLowerCase())
			{
				case "beforebegin":
					this.parentNode.insertBefore($element, this);
					break;
				case "beforeend":
					this.appendChild($element);
					break;
				case "afterbegin":
					this.insertBefore($element, this.firstChild);
					break;
				case "afterend":
					if (this.nextSibling) this.parentNode.insertBefore($element, this.nextSibling);
					else this.parentNode.appendChild($element);
					break;
				default:
					throw "Invalid Argument";
			}
		};


		win.HTMLElement.prototype.setCapture = function(containerCapture)
		{
			//attach to document's events 
		}

		win.HTMLElement.prototype.releaseCapture = function()
		{
		}

		// Events
		// ------
		function globaliseEventObject($event)
		{
			win.event = $event;
		};
		// mimic the "attachEvent" method
		win.attachEvent =
win.HTMLDocument.prototype.attachEvent =
win.HTMLElement.prototype.attachEvent = function($name, $handler, $capture)
{
	$capture = $capture || false;
	if ($name == "onpropertychange")
	{
		return mozOnChange_register(this, $handler);
	}
	if ($name == 'onmouseenter')
	{
		this.addEventListener($name.slice(2), $handler, $capture);
		var $originalHandler = $handler;
		var $origianlName = $name;
		$name = 'onmouseover';
		$handler = function(e)
		{
			//if (e.relatedTarget != e.currentTarget) return;
			//if (e.originalTarget != e.currentTarget) return;
			if (isChildOf(e.relatedTarget, e.currentTarget)) return;
			var clonedEvent = { type: "mouseenter", target: e.target }
			$originalHandler(clonedEvent);
		}
	}
	else if ($name == 'onmouseleave')
	{
		this.addEventListener($name.slice(2), $handler, $capture);
		var $originalHandler = $handler;
		var $origianlName = $name;
		$name = 'onmouseout';
		$handler = function(e)
		{
			//if (e.relatedTarget != e.currentTarget) return;
			//if (e.originalTarget != e.currentTarget) return;
			if (isChildOf(e.relatedTarget, e.currentTarget)) return;
			var clonedEvent = { type: "mouseleave", target: e.target }
			$originalHandler(clonedEvent);
		}
	}

	//	if (isWebkit)
	//	{
	//		$oHandler = $handler;
	//		$handler = function(e) { e.returnValue = undefined; return $oHandler(e); };
	//	}

	this.addEventListener($name.slice(2), globaliseEventObject, true);
	this.addEventListener($name.slice(2), $handler, $capture);
};
		// mimic the "removeEvent" method
		win.detachEvent =
win.HTMLDocument.prototype.detachEvent =
win.HTMLElement.prototype.detachEvent = function($name, $handler)
{
	if ($name == "onpropertychange")
	{
		return mozOnChange_unregister(this, $handler);
	}
	if ($handler._wrapperEventName)
		$name = $handler._wrapperEventName;
	if ($handler._wrapper)
		$handler = $handler._wrapper;

	this.removeEventListener($name.slice(2), globaliseEventObject, true);
	this.removeEventListener($name.slice(2), $handler, false);
};
		win.HTMLDocument.prototype.__defineGetter__("parentWindow", function()
		{
			return this.defaultView;
		});
		// support microsoft's proprietary event properties
		win.Event.prototype.__defineGetter__("srcElement", function()
		{
			return getElementNode(this.target);
		});
		win.Event.prototype.__defineGetter__("fromElement", function()
		{
			return (this.type == "mouseover") ? this.relatedTarget : (this.type == "mouseout") ? this.srcElement : null;
		});
		win.Event.prototype.__defineGetter__("toElement", function()
		{
			return (this.type == "mouseout") ? this.relatedTarget : (this.type == "mouseover") ? this.srcElement : null;
		});
		// convert w3c button id's to microsoft's
		win.Event.prototype.__defineGetter__("button", function()
		{
			return (this.which == 1) ? 1 : (this.which == 2) ? 4 : 2;
		});
		// mimic "returnValue" (default is "true") - this doesn't work in webkit (dan-el) returnValue is an attribut with a default value true
		win.Event.prototype.__defineGetter__("returnValue", function()
		{
			return this._returnValue;
		});
		win.Event.prototype.__defineSetter__("returnValue", function($value)
		{
			if (this.cancelable)
			{
				if ($value)
				{
					this._returnValue = $value;
				}
				else
				{
					// this can't be undone!
					this.preventDefault();
					this.$preventedDefault = true;
					this._returnValue = $value;
				}
			}
		});
		// mozilla already supports the read-only "cancelBubble"
		//  so we only need to define the setter
		win.Event.prototype.__defineSetter__("cancelBubble", function($value)
		{
			// this can't be undone!
			if ($value) this.stopPropagation();
		});
		win.Event.prototype.__defineGetter__("offsetX", function()
		{
			return this.layerX;
		});
		win.Event.prototype.__defineGetter__("offsetY", function()
		{
			return this.layerY;
		});

		function mozOnChange_unregister(obj, handler)
		{
			if (typeof (obj._changeHandlers) == "undefined")
				return;
			for (var i = 0; i < obj._changeHandlers.length; i++)
			{
				if (obj._changeHandlers[i] == handler)
				{
					obj._changeHandlers[i] = null;
				}
			}
		}
		function mozOnChange_register(obj, handler)
		{
			if (typeof (obj._changeHandlers) == "undefined")
			{
				obj._changeHandlers = [];
				obj.addEventListener("keypress", mozOnChange_keyEvent, false);
			}
			obj._changeHandlers.push(handler);
		}
		function mozOnChange_keyEvent(e)
		{
			this._valueBefore = this.value;
			if (this._changeHandler)
				win.clearTimeout(this._changeHandler);
			var t = this;
			this._changeHandler = win.setTimeout(function(e) { mozOnChange_delayed.call(t, e) }, 0);
		}
		function mozOnChange_delayed(e)
		{
			this._changeHandler = 0;
			var v = this.value;
			var vb = this._valueBefore;
			this._valueBefore = v;
			if (vb != v)
			{
				var pce = document.createEvent("HTMLEvents");
				pce.initEvent("propertychange", true, false);
				pce.propertyName = "value";
				for (var i = 0; i < this._changeHandlers.length; i++)
				{
					if (this._changeHandlers[i] != null)
						this._changeHandlers[i].call(this, pce, false);
				}
			}
		}
		// and that's it!
		// thanks mozilla for being such a developer's playground :D
		//******************************************
		//TextRange compatability: by dan-el
		//Html
		//TODO: RegExp.prototype.__defineGetter__("lastIndex
	})();
}

EnableIEEmulator(window);