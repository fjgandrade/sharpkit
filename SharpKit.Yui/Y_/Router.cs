//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace Y_
{
    /// <summary>
    /// Provides URL-based routing using HTML5 `pushState()` or the location hash.
    /// This makes it easy to wire up route handlers for different application states
    /// while providing full back/forward navigation support and bookmarkable, shareable
    /// URLs.
    /// </summary>
    public partial class Router : Y_.Base
    {
        /// <summary>
        /// Handles `history:change` and `hashchange` events.
        /// </summary>
        protected void _afterHistoryChange(EventFacade e){}
        /// <summary>
        /// Wrapper around `decodeURIComponent` that also converts `+` chars into
        /// spaces.
        /// </summary>
        protected object _decode(object @string){return null;}
        /// <summary>
        /// Default handler for the `ready` event.
        /// </summary>
        protected void _defReadyFn(EventFacade e){}
        /// <summary>
        /// Shifts the topmost `_save()` call off the queue and executes it. Does
        /// nothing if the queue is empty.
        /// </summary>
        protected void _dequeue(){}
        /// <summary>
        /// Dispatches to the first route handler that matches the specified _path_.
        /// If called before the `ready` event has fired, the dispatch will be aborted.
        /// This ensures normalized behavior between Chrome (which fires a `popstate`
        /// event on every pageview) and other browsers (which do not).
        /// </summary>
        protected void _dispatch(object path, object url, object src){}
        /// <summary>
        /// Gets the current path from the location hash, or an empty string if the
        /// hash is empty.
        /// </summary>
        protected object _getHashPath(){return null;}
        /// <summary>
        /// Gets the location origin (i.e., protocol, host, and port) as a URL.
        /// </summary>
        protected object _getOrigin(){return null;}
        /// <summary>
        /// Gets the current route path, relative to the `root` (if any).
        /// </summary>
        protected object _getPath(){return null;}
        /// <summary>
        /// Gets the current route query string.
        /// </summary>
        protected object _getQuery(){return null;}
        /// <summary>
        /// Creates a regular expression from the given route specification. If _path_
        /// is already a regex, it will be returned unmodified.
        /// </summary>
        protected object _getRegex(object path, Y_.Array keys){return null;}
        /// <summary>
        /// Gets a request object that can be passed to a route handler.
        /// </summary>
        protected object _getRequest(object path, object url, object src){return null;}
        /// <summary>
        /// Gets a response object that can be passed to a route handler.
        /// </summary>
        protected object _getResponse(object req){return null;}
        /// <summary>
        /// Getter for the `routes` attribute.
        /// </summary>
        protected object _getRoutes(){return null;}
        /// <summary>
        /// Gets the current full URL.
        /// </summary>
        protected object _getURL(){return null;}
        /// <summary>
        /// Returns `true` when the specified `url` is from the same origin as the
        /// current URL; i.e., the protocol, host, and port of the URLs are the same.
        /// All host or path relative URLs are of the same origin. A scheme-relative URL
        /// is first prefixed with the current scheme before being evaluated.
        /// </summary>
        protected object _hasSameOrigin(object url){return null;}
        /// <summary>
        /// Joins the `root` URL to the specified _url_, normalizing leading/trailing
        /// `/` characters.
        /// </summary>
        protected object _joinURL(object url){return null;}
        /// <summary>
        /// Parses a URL query string into a key/value hash. If `Y.QueryString.parse` is
        /// available, this method will be an alias to that.
        /// </summary>
        protected object _parseQuery(object query){return null;}
        /// <summary>
        /// Queues up a `_save()` call to run after all previously-queued calls have
        /// finished.
        /// This is necessary because if we make multiple `_save()` calls before the
        /// first call gets dispatched, then both calls will dispatch to the last call's
        /// URL.
        /// All arguments passed to `_queue()` will be passed on to `_save()` when the
        /// queued function is executed.
        /// </summary>
        protected void _queue(){}
        /// <summary>
        /// Saves a history entry using either `pushState()` or the location hash.
        /// This method enforces the same-origin security constraint; attempting to save
        /// a `url` that is not from the same origin as the current URL will result in
        /// an error.
        /// </summary>
        protected void _save(){}
        /// <summary>
        /// Saves a history entry using either `pushState()` or the location hash.
        /// This method enforces the same-origin security constraint; attempting to save
        /// a `url` that is not from the same origin as the current URL will result in
        /// an error.
        /// </summary>
        protected void _save(object replace){}
        /// <summary>
        /// Saves a history entry using either `pushState()` or the location hash.
        /// This method enforces the same-origin security constraint; attempting to save
        /// a `url` that is not from the same origin as the current URL will result in
        /// an error.
        /// </summary>
        protected void _save(object url, object replace){}
        /// <summary>
        /// Setter for the `routes` attribute.
        /// </summary>
        protected object _setRoutes(object routes){return null;}
        /// <summary>
        /// Dispatches to the first route handler that matches the current URL, if any.
        /// If `dispatch()` is called before the `ready` event has fired, it will
        /// automatically wait for the `ready` event before dispatching. Otherwise it
        /// will dispatch immediately.
        /// </summary>
        public void dispatch(){}
        /// <summary>
        /// Gets the current route path, relative to the `root` (if any).
        /// </summary>
        public object getPath(){return null;}
        /// <summary>
        /// Returns `true` if this router has at least one route that matches the
        /// specified URL, `false` otherwise.
        /// This method enforces the same-origin security constraint on the specified
        /// `url`; any URL which is not from the same origin as the current URL will
        /// always return `false`.
        /// </summary>
        public object hasRoute(object url){return null;}
        /// <summary>
        /// Returns an array of route objects that match the specified URL path.
        /// This method is called internally to determine which routes match the current
        /// path whenever the URL changes. You may override it if you want to customize
        /// the route matching logic, although this usually shouldn't be necessary.
        /// Each returned route object has the following properties:
        /// * `callback`: A function or a string representing the name of a function
        /// this router that should be executed when the route is triggered.
        /// * `keys`: An array of strings representing the named parameters defined in
        /// the route's path specification, if any.
        /// * `path`: The route's path specification, which may be either a string or
        /// a regex.
        /// * `regex`: A regular expression version of the route's path specification.
        /// This regex is used to determine whether the route matches a given path.
        /// </summary>
        public object match(object path){return null;}
        /// <summary>
        /// Removes the `root` URL from the front of _url_ (if it's there) and returns
        /// the result. The returned path will always have a leading `/`.
        /// </summary>
        public object removeRoot(object url){return null;}
        /// <summary>
        /// Replaces the current browser history entry with a new one, and dispatches to
        /// the first matching route handler, if any.
        /// Behind the scenes, this method uses HTML5 `pushState()` in browsers that
        /// support it (or the location hash in older browsers and IE) to change the
        /// URL.
        /// The specified URL must share the same origin (i.e., protocol, host, and
        /// port) as the current page, or an error will occur.
        /// </summary>
        public void replace(){}
        /// <summary>
        /// Replaces the current browser history entry with a new one, and dispatches to
        /// the first matching route handler, if any.
        /// Behind the scenes, this method uses HTML5 `pushState()` in browsers that
        /// support it (or the location hash in older browsers and IE) to change the
        /// URL.
        /// The specified URL must share the same origin (i.e., protocol, host, and
        /// port) as the current page, or an error will occur.
        /// </summary>
        public void replace(object url){}
        /// <summary>
        /// Adds a route handler for the specified URL _path_.
        /// The _path_ parameter may be either a string or a regular expression. If it's
        /// a string, it may contain named parameters: `:param` will match any single
        /// part of a URL path (not including `/` characters), and `*param` will match
        /// any number of parts of a URL path (including `/` characters). These named
        /// parameters will be made available as keys on the `req.params` object that's
        /// passed to route handlers.
        /// If the _path_ parameter is a regex, all pattern matches will be made
        /// available as numbered keys on `req.params`, starting with `0` for the full
        /// match, then `1` for the first subpattern match, and so on.
        /// Here's a set of sample routes along with URL paths that they match:
        /// * Route: `/photos/:tag/:page`
        /// * URL: `/photos/kittens/1`, params: `{tag: 'kittens', page: '1'}`
        /// * URL: `/photos/puppies/2`, params: `{tag: 'puppies', page: '2'}`
        /// * Route: `/file/*path`
        /// * URL: `/file/foo/bar/baz.txt`, params: `{path: 'foo/bar/baz.txt'}`
        /// * URL: `/file/foo`, params: `{path: 'foo'}`
        /// If multiple route handlers match a given URL, they will be executed in the
        /// order they were added. The first route that was added will be the first to
        /// be executed.
        /// </summary>
        public void route(object path, object callback){}
        /// <summary>
        /// Saves a new browser history entry and dispatches to the first matching route
        /// handler, if any.
        /// Behind the scenes, this method uses HTML5 `pushState()` in browsers that
        /// support it (or the location hash in older browsers and IE) to change the
        /// URL and create a history entry.
        /// The specified URL must share the same origin (i.e., protocol, host, and
        /// port) as the current page, or an error will occur.
        /// </summary>
        public void save(){}
        /// <summary>
        /// Saves a new browser history entry and dispatches to the first matching route
        /// handler, if any.
        /// Behind the scenes, this method uses HTML5 `pushState()` in browsers that
        /// support it (or the location hash in older browsers and IE) to change the
        /// URL and create a history entry.
        /// The specified URL must share the same origin (i.e., protocol, host, and
        /// port) as the current page, or an error will occur.
        /// </summary>
        public void save(object url){}
        /// <summary>
        /// Upgrades a hash-based URL to an HTML5 URL if necessary. In non-HTML5
        /// browsers, this method is a noop.
        /// </summary>
        public object upgrade(){return null;}
    }
}
