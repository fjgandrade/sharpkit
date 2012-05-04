//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace YUI_
{
    /// <summary>
    /// Extension that provides core autocomplete logic (but no UI implementation) for a
    /// text input field or textarea.
    /// The `AutoCompleteBase` class provides events and attributes that abstract away
    /// core autocomplete logic and configuration, but does not provide a widget
    /// implementation or suggestion UI. For a prepackaged autocomplete widget, see
    /// `AutoCompleteList`.
    /// This extension cannot be instantiated directly, since it doesn't provide an
    /// actual implementation. It's intended to be mixed into a `Y.Base`-based class or
    /// widget.
    /// `Y.Widget`-based example:
    /// YUI().use('autocomplete-base', 'widget', function (Y) {
    /// var MyAC = Y.Base.create('myAC', Y.Widget, [Y.AutoCompleteBase], {
    /// // Custom prototype methods and properties.
    /// }, {
    /// // Custom static methods and properties.
    /// });
    /// // Custom implementation code.
    /// });
    /// `Y.Base`-based example:
    /// YUI().use('autocomplete-base', function (Y) {
    /// var MyAC = Y.Base.create('myAC', Y.Base, [Y.AutoCompleteBase], {
    /// initializer: function () {
    /// this._bindUIACBase();
    /// this._syncUIACBase();
    /// },
    /// // Custom prototype methods and properties.
    /// }, {
    /// // Custom static methods and properties.
    /// });
    /// // Custom implementation code.
    /// });
    /// </summary>
    public partial class AutoCompleteBase
    {
        /// <summary>
        /// Updates the current `source` based on the new `sourceType` to ensure that
        /// the two attributes don't get out of sync when they're changed separately.
        /// </summary>
        protected void _afterSourceTypeChange(EventFacade e){}
        /// <summary>
        /// Handles change events for the `value` attribute.
        /// </summary>
        protected void _afterValueChange(EventFacade e){}
        /// <summary>
        /// Runs before AutoCompleteBase's `_createObjectSource()` method and augments
        /// it to support additional object-based source types.
        /// </summary>
        protected void _beforeCreateObjectSource(object source){}
        /// <summary>
        /// Attaches event listeners and behaviors.
        /// </summary>
        protected void _bindUIACBase(){}
        /// <summary>
        /// Creates a DataSource-like object that simply returns the specified array as
        /// a response. See the `source` attribute for more details.
        /// </summary>
        protected object _createArraySource(YUI_.Array source){return null;}
        /// <summary>
        /// Creates a DataSource-like object that passes the query to a custom-defined
        /// function, which is expected to call the provided callback with an array of
        /// results. See the `source` attribute for more details.
        /// </summary>
        protected object _createFunctionSource(JsAction source){return null;}
        /// <summary>
        /// Creates a DataSource-like object that uses `Y.io` as a source. See the
        /// `source` attribute for more details.
        /// </summary>
        protected object _createIOSource(object source){return null;}
        /// <summary>
        /// Creates a DataSource-like object that uses the specified JSONPRequest
        /// instance as a source. See the `source` attribute for more details.
        /// </summary>
        protected object _createJSONPSource(object source){return null;}
        /// <summary>
        /// Creates a DataSource-like object that looks up queries as properties on the
        /// specified object, and returns the found value (if any) as a response. See
        /// the `source` attribute for more details.
        /// </summary>
        protected object _createObjectSource(object source){return null;}
        /// <summary>
        /// Creates a DataSource-like object that uses the specified `<select>` node as
        /// a source.
        /// </summary>
        protected object _createSelectSource(Node source){return null;}
        /// <summary>
        /// Creates a DataSource-like object that calls the specified  URL or executes
        /// the specified YQL query for results. If the string starts with "select ",
        /// "use ", or "set " (case-insensitive), it's assumed to be a YQL query;
        /// otherwise, it's assumed to be a URL (which may be absolute or relative).
        /// URLs containing a "{callback}" placeholder are assumed to be JSONP URLs; all
        /// others will use XHR. See the `source` attribute for more details.
        /// </summary>
        protected object _createStringSource(object source){return null;}
        /// <summary>
        /// Creates a DataSource-like object that uses the specified YQL query string to
        /// create a YQL-based source. See the `source` attribute for details. If no
        /// `resultListLocator` is defined, this method will set a best-guess locator
        /// that might work for many typical YQL queries.
        /// </summary>
        protected object _createYQLSource(object source){return null;}
        /// <summary>
        /// Default resultListLocator used when a string-based YQL source is set and the
        /// implementer hasn't already specified one.
        /// </summary>
        protected YUI_.Array _defaultYQLLocator(object response){return null;}
        /// <summary>
        /// Default `clear` event handler. Sets the `results` attribute to an empty
        /// array and `query` to null.
        /// </summary>
        protected void _defClearFn(){}
        /// <summary>
        /// Default `query` event handler. Sets the `query` attribute and sends a
        /// request to the source if one is configured.
        /// </summary>
        protected void _defQueryFn(EventFacade e){}
        /// <summary>
        /// Default `results` event handler. Sets the `results` attribute to the latest
        /// results.
        /// </summary>
        protected void _defResultsFn(EventFacade e){}
        /// <summary>
        /// Returns `true` if _value_ is either a function or `null`.
        /// </summary>
        protected void _functionValidator(object value){}
        /// <summary>
        /// Faster and safer alternative to `Y.Object.getValue()`. Doesn't bother
        /// casting the path to an array (since we already know it's an array) and
        /// doesn't throw an error if a value in the middle of the object hierarchy is
        /// neither `undefined` nor an object.
        /// </summary>
        protected object _getObjectValue(object obj, YUI_.Array path){return null;}
        /// <summary>
        /// Returns a formatted XHR URL based on the specified base _url_, _query_, and
        /// the current _requestTemplate_ if any.
        /// </summary>
        protected object _getXHRUrl(object url, object request){return null;}
        /// <summary>
        /// URL formatter passed to `JSONPRequest` instances.
        /// </summary>
        protected object _jsonpFormatter(object url, object proxy, object query){return null;}
        /// <summary>
        /// Handles `blur` events on the input node.
        /// </summary>
        protected void _onInputBlur(EventFacade e){}
        /// <summary>
        /// Handles `valueChange` events on the input node and fires a `query` event
        /// when the input value meets the configured criteria.
        /// </summary>
        protected void _onInputValueChange(EventFacade e){}
        /// <summary>
        /// Handles source responses and fires the `results` event.
        /// </summary>
        protected void _onResponse(EventFacade e){}
        /// <summary>
        /// Parses result responses, performs filtering and highlighting, and fires the
        /// `results` event.
        /// </summary>
        protected void _parseResponse(object query, object response, object data){}
        /// <summary>
        /// Returns the query portion of the specified input value, or `null` if there
        /// is no suitable query within the input value.
        /// If a query delimiter is defined, the query will be the last delimited part
        /// of of the string.
        /// </summary>
        protected object _parseValue(object value){return null;}
        /// <summary>
        /// Setter for the `enableCache` attribute.
        /// </summary>
        protected void _setEnableCache(object value){}
        /// <summary>
        /// Setter for locator attributes.
        /// </summary>
        protected JsAction _setLocator(object locator){return null;}
        /// <summary>
        /// Setter for the `requestTemplate` attribute.
        /// </summary>
        protected JsAction _setRequestTemplate(object template){return null;}
        /// <summary>
        /// Setter for the `resultFilters` attribute.
        /// </summary>
        protected object _setResultFilters(object filters){return null;}
        /// <summary>
        /// Setter for the `resultHighlighter` attribute.
        /// </summary>
        protected JsAction _setResultHighlighter(object highlighter){return null;}
        /// <summary>
        /// Setter for the `source` attribute. Returns a DataSource or a DataSource-like
        /// object depending on the type of _source_ and/or the value of the
        /// `sourceType` attribute.
        /// </summary>
        protected object _setSource(object source){return null;}
        /// <summary>
        /// Shared success callback for non-DataSource sources.
        /// </summary>
        protected void _sourceSuccess(object data, object request){}
        /// <summary>
        /// Synchronizes the UI state of the `allowBrowserAutocomplete` attribute.
        /// </summary>
        protected void _syncBrowserAutocomplete(){}
        /// <summary>
        /// Synchronizes the UI state of the `inputNode`.
        /// </summary>
        protected void _syncUIACBase(){}
        /// <summary>
        /// Updates the query portion of the `value` attribute.
        /// If a query delimiter is defined, the last delimited portion of the input
        /// value will be replaced with the specified _value_.
        /// </summary>
        protected void _updateValue(object newVal){}
        /// <summary>
        /// Clears the result cache.
        /// </summary>
        public void clearCache(){}
        /// <summary>
        /// Sends a request to the configured source. If no source is configured, this
        /// method won't do anything.
        /// Usually there's no reason to call this method manually; it will be called
        /// automatically when user input causes a `query` event to be fired. The only
        /// time you'll need to call this method manually is if you want to force a
        /// request to be sent when no user input has occurred.
        /// </summary>
        public void sendRequest(){}
        /// <summary>
        /// Sends a request to the configured source. If no source is configured, this
        /// method won't do anything.
        /// Usually there's no reason to call this method manually; it will be called
        /// automatically when user input causes a `query` event to be fired. The only
        /// time you'll need to call this method manually is if you want to force a
        /// request to be sent when no user input has occurred.
        /// </summary>
        public void sendRequest(JsAction requestTemplate){}
        /// <summary>
        /// Sends a request to the configured source. If no source is configured, this
        /// method won't do anything.
        /// Usually there's no reason to call this method manually; it will be called
        /// automatically when user input causes a `query` event to be fired. The only
        /// time you'll need to call this method manually is if you want to force a
        /// request to be sent when no user input has occurred.
        /// </summary>
        public void sendRequest(object query){}
        /// <summary>
        /// Sends a request to the configured source. If no source is configured, this
        /// method won't do anything.
        /// Usually there's no reason to call this method manually; it will be called
        /// automatically when user input causes a `query` event to be fired. The only
        /// time you'll need to call this method manually is if you want to force a
        /// request to be sent when no user input has occurred.
        /// </summary>
        public void sendRequest(object query, JsAction requestTemplate){}
        /// <summary>
        /// Maximum number of results to return. A value of `0` or less will allow an
        /// unlimited number of results.
        /// </summary>
        public YUI_.DataType_.Number maxResults{get;set;}
        /// <summary>
        /// Minimum number of characters that must be entered before a `query` event
        /// will be fired. A value of `0` allows empty queries; a negative value will
        /// effectively disable all `query` events.
        /// </summary>
        public YUI_.DataType_.Number minQueryLength{get;set;}
        /// <summary>
        /// Number of milliseconds to delay after input before triggering a `query`
        /// event. If new input occurs before this delay is over, the previous input
        /// event will be ignored and a new delay will begin.
        /// This can be useful both to throttle queries to a remote data source and to
        /// avoid distracting the user by showing them less relevant results before
        /// they've paused their typing.
        /// </summary>
        public YUI_.DataType_.Number queryDelay{get;set;}
        /// <summary>
        /// Array of local result filter functions. If provided, each filter will be
        /// called with two arguments when results are received: the query and an array
        /// of result objects. See the documentation for the `results` event for a list
        /// of the properties available on each result object.
        /// Each filter is expected to return a filtered or modified version of the
        /// results array, which will then be passed on to subsequent filters, then the
        /// `resultHighlighter` function (if set), then the `resultFormatter` function
        /// (if set), and finally to subscribers to the `results` event.
        /// If no `source` is set, result filters will not be called.
        /// Prepackaged result filters provided by the autocomplete-filters and
        /// autocomplete-filters-accentfold modules can be used by specifying the filter
        /// name as a string, such as `'phraseMatch'` (assuming the necessary filters
        /// module is loaded).
        /// </summary>
        public YUI_.Array resultFilters{get;set;}
        /// <summary>
        /// Current results, or an empty array if there are no results.
        /// </summary>
        public YUI_.Array results{get;private set;}
    }
}
