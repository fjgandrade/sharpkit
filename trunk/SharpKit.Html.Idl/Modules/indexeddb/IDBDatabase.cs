
/****************************************************************************************************

  This file was auto generated with the tool 'WebIDLParser' at Fri, 27 Jul 2012 03:44:27 GMT
  Author of the tool: Sebastian Loncar, http://loncar.de

  Content was generated from IDL file: http://trac.webkit.org/browser/trunk/Source/WebCore/Modules/indexeddb/IDBDatabase.idl

  PLEASE DO *NOT* MODIFY THIS FILE! This file will be overridden next generation. If you need changes:
  - All classes marked as 'partial'. Use the custom.cs in the root folder, to extend the classes.
  - or regenerate the project with the newest IDL files.
  - or modifiy the WebIDLParser tool itself.

*****************************************************************************************************

  This library is free software: you can redistribute it and/or modify
  it under the terms of the GNU General Public License as published by
  the Free Software Foundation, either version 3 of the License, or
  (at your option) any later version.

  This library is distributed in the hope that it will be useful,
  but WITHOUT ANY WARRANTY; without even the implied warranty of
  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
  GNU General Public License for more details.

  You should have received a copy of the GNU General Public License
  along with this program.  If not, see <http://www.gnu.org/licenses/>.

*****************************************************************************************************/

using System;

namespace SharpKit.Html.storage
{

using SharpKit.JavaScript;
using SharpKit.Html.storage;
using SharpKit.Html.threads;
using SharpKit.Html.audio;
using SharpKit.Html.webaudio;
using SharpKit.Html.svg;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true)]
public partial class IDBDatabase
{
	public  JsString name {get; set; }
	public  JsString version {get; set; }
	public  DOMStringList objectStoreNames {get; set; }
	public  EventListener onabort {get; set; }
	public  EventListener<ErrorEvent> onerror {get; set; }
	public  EventListener onversionchange {get; set; }
	public  IDBObjectStore createObjectStore(string name) { return default(IDBObjectStore); }
	public  IDBObjectStore createObjectStore(string name, object options) { return default(IDBObjectStore); }
	public  void deleteObjectStore(string name) {}
	public  IDBVersionChangeRequest setVersion(string version) { return default(IDBVersionChangeRequest); }
	public  IDBTransaction transaction(DOMStringList storeNames, string mode) { return default(IDBTransaction); }
	public  IDBTransaction transaction(string[] storeNames, string mode) { return default(IDBTransaction); }
	public  IDBTransaction transaction(DOMStringList storeNames, int mode) { return default(IDBTransaction); }
	public  IDBTransaction transaction(string[] storeNames, int mode) { return default(IDBTransaction); }
	public  void close() {}
	public  void addEventListener(string type, EventListener listener) {}
	public  void addEventListener(string type, EventListener listener, bool useCapture) {}
	public  void removeEventListener(string type, EventListener listener) {}
	public  void removeEventListener(string type, EventListener listener, bool useCapture) {}
	public  bool dispatchEvent(DOMEvent evt) { return default(bool); }
}

}