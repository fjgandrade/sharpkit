qx.$$packageData['512']={"locales":{},"resources":{"qxc/application/datademo/identica.png":[200,150,"png","qxc.application.datademo"]},"translations":{"C":{},"cs":{},"de":{},"de_AT":{},"de_DE":{},"en":{},"en_GB":{},"en_US":{},"es":{},"es_ES":{},"es_MX":{},"pt":{},"ro":{},"ro_RO":{},"sv":{},"sv_SE":{}}};
qx.Part.$$notifyLoad("512", function() {
(function(){var j="loadEnd",i="qx.io.request.AbstractRequest",h="changePhase",g="sent",f="qx.io.request.authentication.IAuthentication",e="error",d="loading",c="success",b="String",a="",B="opened",A="POST",z="statusError",y="readyStateChange",x="abstract",w="unsent",v="changeResponse",u="Number",t="Content-Type",s="timeout",q="undefined",r="GET",o="qx.event.type.Data",p="load",m="abort",n="fail",k="qx.debug.io",l="qx.event.type.Event";qx.Class.define(i,{type:x,extend:qx.core.Object,construct:function(C){qx.core.Object.call(this);if(C!==undefined){this.setUrl(C);};this.__ro={};var D=this._transport=this._createTransport();this._setPhase(w);this.__uP=qx.lang.Function.bind(this._onReadyStateChange,this);this.__uQ=qx.lang.Function.bind(this._onLoad,this);this.__uR=qx.lang.Function.bind(this._onLoadEnd,this);this.__uS=qx.lang.Function.bind(this._onAbort,this);this.__tz=qx.lang.Function.bind(this._onTimeout,this);this.__uT=qx.lang.Function.bind(this._onError,this);D.onreadystatechange=this.__uP;D.onload=this.__uQ;D.onloadend=this.__uR;D.onabort=this.__uS;D.ontimeout=this.__tz;D.onerror=this.__uT;},events:{"readyStateChange":l,"success":l,"load":l,"loadEnd":l,"abort":l,"timeout":l,"error":l,"statusError":l,"fail":l,"changeResponse":o,"changePhase":o},properties:{url:{check:b},timeout:{check:u,nullable:true,init:0},requestData:{check:function(E){return qx.lang.Type.isString(E)||qx.Class.isSubClassOf(E.constructor,qx.core.Object)||qx.lang.Type.isObject(E);},nullable:true},authentication:{check:f,nullable:true}},members:{__uP:null,__uQ:null,__uR:null,__uS:null,__tz:null,__uT:null,__uU:null,__tB:null,__uV:null,__ro:null,__uW:null,_transport:null,_createTransport:function(){throw new Error("Abstract method call");},_getConfiguredUrl:function(){},_getConfiguredRequestHeaders:function(){},_getParsedResponse:function(){throw new Error("Abstract method call");},_getMethod:function(){return r;},_isAsync:function(){return true;},send:function(){var J=this._transport,F,I,G,H;F=this._getConfiguredUrl();if(/\#/.test(F)){F=F.replace(/\#.*/,a);};J.timeout=this.getTimeout();I=this._getMethod();G=this._isAsync();if(qx.core.Environment.get(k)){this.debug("Open low-level request with method: "+I+", url: "+F+", async: "+G);};J.open(I,F,G);this._setPhase(B);H=this._serializeData(this.getRequestData());this._setRequestHeaders();if(qx.core.Environment.get(k)){this.debug("Send low-level request");};I==r?J.send():J.send(H);this._setPhase(g);},abort:function(){if(qx.core.Environment.get(k)){this.debug("Abort request");};this.__tB=true;this.__uV=m;this._transport.abort();},_setRequestHeaders:function(){var M=this._transport,K=this._getAllRequestHeaders();for(var L in K){M.setRequestHeader(L,K[L]);};},_getAllRequestHeaders:function(){var N={};qx.lang.Object.mergeWith(N,this._getConfiguredRequestHeaders());qx.lang.Object.mergeWith(N,this.__uX());qx.lang.Object.mergeWith(N,this.__uW);qx.lang.Object.mergeWith(N,this.__ro);return N;},__uX:function(){var P=this.getAuthentication(),O={};if(P){P.getAuthHeaders().forEach(function(Q){O[Q.key]=Q.value;});return O;};},setRequestHeader:function(R,S){this.__ro[R]=S;},getRequestHeader:function(T){return this.__ro[T];},removeRequestHeader:function(U){if(this.__ro[U]){delete this.__ro[U];};},getTransport:function(){return this._transport;},getReadyState:function(){return this._transport.readyState;},getPhase:function(){return this.__uV;},getStatus:function(){return this._transport.status;},getStatusText:function(){return this._transport.statusText;},getResponseText:function(){return this._transport.responseText;},getAllResponseHeaders:function(){return this._transport.getAllResponseHeaders();},getResponseHeader:function(V){return this._transport.getResponseHeader(V);},getResponseContentType:function(){return this.getResponseHeader(t);},isDone:function(){return this.getReadyState()===4;},getResponse:function(){return this.__uU;},_setResponse:function(W){var X=W;if(this.__uU!==W){this.__uU=W;this.fireEvent(v,qx.event.type.Data,[this.__uU,X]);};},_onReadyStateChange:function(){var Y=this.getReadyState();if(qx.core.Environment.get(k)){this.debug("Fire readyState: "+Y);};this.fireEvent(y);if(this.__tB){return;};if(Y===3){this._setPhase(d);};if(this.isDone()){this.__uY();};},__uY:function(){var ba;if(qx.core.Environment.get(k)){this.debug("Request completed with HTTP status: "+this.getStatus());};this._setPhase(p);if(qx.util.Request.isSuccessful(this.getStatus())){if(qx.core.Environment.get(k)){this.debug("Response is of type: '"+this.getResponseContentType()+"'");};ba=this._getParsedResponse();this._setResponse(ba);this._fireStatefulEvent(c);}else {if(this.getStatus()!==0){this._fireStatefulEvent(z);this.fireEvent(n);};};},_onLoad:function(){this.fireEvent(p);},_onLoadEnd:function(){this.fireEvent(j);},_onAbort:function(){this._fireStatefulEvent(m);},_onTimeout:function(){this._fireStatefulEvent(s);this.fireEvent(n);},_onError:function(){this.fireEvent(e);this.fireEvent(n);},_fireStatefulEvent:function(bb){{};this._setPhase(bb);this.fireEvent(bb);},_setPhase:function(bc){var bd=this.__uV;{};this.__uV=bc;this.fireDataEvent(h,bc,bd);},_serializeData:function(be){var bf=typeof this.getMethod!==q&&this.getMethod()==A;if(!be){return;};if(qx.lang.Type.isString(be)){return be;};if(qx.Class.isSubClassOf(be.constructor,qx.core.Object)){return qx.util.Serializer.toUriParameter(be);};if(qx.lang.Type.isObject(be)){return qx.util.Uri.toParameter(be,bf);};}},environment:{"qx.debug.io":false},destruct:function(){var bh=this._transport,bg=function(){};if(this._transport){bh.onreadystatechange=bh.onload=bh.onloadend=bh.onabort=bh.ontimeout=bh.onerror=bg;bh.dispose();};}});})();(function(){var b="//",a="qx.util.Request";qx.Bootstrap.define(a,{statics:{isCrossDomain:function(c){var e=qx.util.Uri.parseUri(c),location=window.location;if(!location){return false;};var d=location.protocol;if(!(c.indexOf(b)!==-1)){return false;};if(d.substr(0,d.length-1)==e.protocol&&location.host===e.host&&location.port===e.port){return false;};return true;},isSuccessful:function(status){return (status>=200&&status<300||status===304);},methodAllowsRequestBody:function(f){return !((/^(GET)|(HEAD)$/).test(f));}}});})();(function(){var j="changeModel",i="application/json",h="json",g="loaded",f="error",e="fail",d="queued",c="changeState",b="success",a="String",x="changePhase",w="__rE",v="_marshaler",u="qx.data.store.Json",t="changeUrl",s="_applyUrl",r="aborted",q="qx.event.type.Data",p="receiving",o="sending",m="completed",n="failed",k="timeout",l="configured";qx.Class.define(u,{extend:qx.core.Object,construct:function(y,z){qx.core.Object.call(this);this._marshaler=new qx.data.marshal.Json(z);this._delegate=z;if(y!=null){this.setUrl(y);};},events:{"loaded":q,"error":q},properties:{model:{nullable:true,event:j},state:{check:[l,d,o,p,m,r,k,n],init:l,event:c},url:{check:a,apply:s,event:t,nullable:true}},members:{_marshaler:null,_delegate:null,__rE:null,_applyUrl:function(A,B){if(A!=null){A=qx.util.AliasManager.getInstance().resolve(A);A=qx.util.ResourceManager.getInstance().toUri(A);this._createRequest(A);};},_getRequest:function(){return this.__rE;},_setRequest:function(C){this.__rE=C;},_createRequest:function(D){if(this.__rE){this.__rE.dispose();this.__rE=null;};var E=new qx.io.request.Xhr(D);this._setRequest(E);E.setAccept(i);E.setParser(h);E.addListener(b,this._onSuccess,this);var F=this._delegate;if(F&&qx.lang.Type.isFunction(F.configureRequest)){this._delegate.configureRequest(E);};E.addListener(x,this._onChangePhase,this);E.addListener(e,this._onFail,this);E.send();},_onChangePhase:function(G){var H=G.getData(),J={},I;J={"opened":l,"sent":o,"loading":p,"success":m,"abort":r,"timeout":k,"statusError":n};I=J[H];if(I){this.setState(I);};},_onFail:function(K){var L=K.getTarget();this.fireDataEvent(f,L);},_onSuccess:function(M){if(this.isDisposed()){return;};var O=M.getTarget(),P=O.getResponse();var N=this._delegate;if(N&&qx.lang.Type.isFunction(N.manipulateData)){P=this._delegate.manipulateData(P);};this._marshaler.toClass(P,true);var Q=this.getModel();this.setModel(this._marshaler.toModel(P));if(Q&&Q.dispose){Q.dispose();};this.fireDataEvent(g,this.getModel());if(this.__rE){this.__rE.dispose();this.__rE=null;};},reload:function(){var R=this.getUrl();if(R!=null){this._createRequest(R);};}},destruct:function(){if(this.__rE!=null){this._disposeObjects(w);};this._disposeSingletonObjects(v);this._delegate=null;}});})();(function(){var f="callback",e="changePhase",d="fail",c="success",b="qx.data.store.Jsonp",a="String";qx.Class.define(b,{extend:qx.data.store.Json,construct:function(g,h,i){if(i!=undefined){this.setCallbackParam(i);};qx.data.store.Json.call(this,g,h);},properties:{callbackParam:{check:a,init:f,nullable:true},callbackName:{check:a,nullable:true}},members:{_createRequest:function(j){if(this._getRequest()){this._getRequest().dispose();};var k=new qx.io.request.Jsonp();this._setRequest(k);k.setCallbackParam(this.getCallbackParam());k.setCallbackName(this.getCallbackName());k.setUrl(j);k.addListener(c,this._onSuccess,this);var l=this._delegate;if(l&&qx.lang.Type.isFunction(l.configureRequest)){this._delegate.configureRequest(k);};k.addListener(e,this._onChangePhase,this);k.addListener(d,this._onFail,this);k.send();}}});})();(function(){var q="null",p="XMLHttpRequest",o="Boolean",n="X-Requested-With",m="application/x-www-form-urlencoded",l="Cache-Control",k="Content-Type",j="qx.debug.io",i="qx.io.request.Xhr",h="json",c="Accept",g="String",f="function",b="xml",a="GET",e="",d="qx.event.type.Event";qx.Class.define(i,{extend:qx.io.request.AbstractRequest,construct:function(r,s){if(s!==undefined){this.setMethod(s);};qx.io.request.AbstractRequest.call(this,r);},events:{"readyStateChange":d,"success":d,"load":d,"statusError":d},statics:{PARSER:{json:qx.lang.Json.parse,xml:qx.xml.Document.fromString}},properties:{method:{init:a},async:{check:o,init:true},accept:{check:g,nullable:true},cache:{check:function(t){return qx.lang.Type.isBoolean(t)||qx.lang.Type.isString(t);},init:true}},members:{__va:null,_createTransport:function(){return new qx.bom.request.Xhr();},_getConfiguredUrl:function(){var u=this.getUrl(),v;if(this.getMethod()===a&&this.getRequestData()){v=this._serializeData(this.getRequestData());u=qx.util.Uri.appendParamsToUrl(u,v);};if(this.getCache()===false){u=qx.util.Uri.appendParamsToUrl(u,{nocache:new Date().valueOf()});};return u;},_getConfiguredRequestHeaders:function(){var w={},x=qx.util.Request.methodAllowsRequestBody(this.getMethod());if(!qx.util.Request.isCrossDomain(this.getUrl())){w[n]=p;};if(qx.lang.Type.isString(this.getCache())){w[l]=this.getCache();};if(this.getRequestData()!==q&&x){w[k]=m;};if(this.getAccept()){if(qx.core.Environment.get(j)){this.debug("Accepting: '"+this.getAccept()+"'");};w[c]=this.getAccept();};return w;},_getMethod:function(){return this.getMethod();},_isAsync:function(){return this.isAsync();},_getParsedResponse:function(){var z=this._transport.responseText,y=this._getParser();if(typeof y===f){if(z!==e){return y.call(this,z);};};return z;},setParser:function(A){var B=qx.io.request.Xhr;if(typeof B.PARSER[A]===f){return this.__va=B.PARSER[A];};{};return this.__va=A;},_getParser:function(){var C=this.__va,D;if(C){return C;};if(!this.isDone()){return null;};D=this.getResponseContentType()||e;D=D.replace(/;.*$/,e);if((/^application\/(\w|\.)*\+?json$/).test(D)){C=qx.io.request.Xhr.PARSER[h];};if((/^application\/xml$/).test(D)){C=qx.io.request.Xhr.PARSER[b];};if((/[^\/]+\/[^\+]+\+xml$/).test(this.getResponseContentType())){C=qx.io.request.Xhr.PARSER[b];};return C;}}});})();(function(){var i="qx.bom.request.Jsonp",h="callback",g="open",f="dispose",e="_onNativeLoad",d="].callback",c="qx.bom.request.Jsonp[",b="",a="qx.debug.io";qx.Bootstrap.define(i,{extend:qx.bom.request.Script,construct:function(){qx.bom.request.Script.apply(this);this.__uo();},members:{responseJson:null,__bV:null,__ui:null,__uj:null,__uk:null,__ul:null,__tJ:null,__um:b,open:function(j,k){if(this.__tJ){return;};var l={},n,m,o=this;this.responseJson=null;this.__uk=false;n=this.__ui||h;m=this.__uj||this.__um+c+this.__bV+d;if(!this.__uj){this.constructor[this.__bV]=this;}else {if(!window[this.__uj]){this.__ul=true;window[this.__uj]=function(p){o.callback(p);};}else {if(qx.core.Environment.get(a)){qx.Bootstrap.debug(qx.bom.request.Jsonp,"Callback "+this.__uj+" already exists");};};};if(qx.core.Environment.get(a)){qx.Bootstrap.debug(qx.bom.request.Jsonp,"Expecting JavaScript response to call: "+m);};l[n]=m;k=qx.util.Uri.appendParamsToUrl(k,l);this.__gT(g,[j,k]);},callback:function(q){if(this.__tJ){return;};this.__uk=true;{};this.responseJson=q;this.constructor[this.__bV]=undefined;this.__un();},setCallbackParam:function(r){this.__ui=r;return this;},setCallbackName:function(name){this.__uj=name;return this;},setPrefix:function(s){this.__um=s;},dispose:function(){this.__un();this.__gT(f);},_onNativeLoad:function(){this.status=this.__uk?200:500;this.__gT(e);},__un:function(){if(this.__ul&&window[this.__uj]){window[this.__uj]=undefined;this.__ul=false;};},__gT:function(t,u){qx.bom.request.Script.prototype[t].apply(this,u||[]);},__uo:function(){this.__bV=(new Date().valueOf())+(b+Math.random()).substring(2,5);}}});})();(function(){var a="showcase.page.databinding.Content";qx.Class.define(a,{extend:showcase.AbstractContent,construct:function(b){showcase.AbstractContent.call(this,b);this.setView(new qxc.application.datademo.Demo());}});})();(function(){var k="activex",j="If-None-Match",i="xhr",h="engine.version",g="GET",f="-1",d="load",c="abort",b="Microsoft.XMLHTTP",a="browser.version",G="If-Match",F="Microsoft.XMLDOM",E="If-Range",D="Content-Type",C="io.xhr",B="on",A="timeout",z="If-Modified-Since",y="onunload",x="browser.documentmode",r="loadend",s="opera",p="gecko",q="file:",n="error",o="mshtml",l="undefined",m="qx.debug.io",t="",u="readystatechange",w="qx.bom.request.Xhr",v="engine.name";qx.Bootstrap.define(w,{construct:function(){this.__tx=qx.Bootstrap.bind(this.__tM,this);this.__ty=qx.Bootstrap.bind(this.__tL,this);this.__tz=qx.Bootstrap.bind(this.__tQ,this);this.__tK();this._emitter=new qx.event.Emitter();if(window.attachEvent){this.__tA=qx.Bootstrap.bind(this.__tT,this);window.attachEvent(y,this.__tA);};},statics:{UNSENT:0,OPENED:1,HEADERS_RECEIVED:2,LOADING:3,DONE:4},events:{"readystatechange":w,"error":w,"loadend":w,"timeout":w,"abort":w,"load":w},members:{readyState:0,responseText:t,responseXML:null,status:0,statusText:t,timeout:0,open:function(H,I,J,K,L){this.__tV();if(typeof I===l){throw new Error("Not enough arguments");}else if(typeof H===l){H=g;};this.__tB=false;this.__tC=false;this.__tD=false;this.__tE=I;if(typeof J==l){J=true;};this.__tF=J;if(!this.__tU()&&this.readyState>qx.bom.request.Xhr.UNSENT){this.dispose();this.__tK();};this.__tH.onreadystatechange=this.__tx;try{if(qx.core.Environment.get(m)){qx.Bootstrap.debug(qx.bom.request.Xhr,"Open native request with method: "+H+", url: "+I+", async: "+J);};this.__tH.open(H,I,J,K,L);}catch(M){if(!qx.util.Request.isCrossDomain(I)){throw M;};if(!this.__tF){this.__tG=M;};if(this.__tF){if(window.XDomainRequest){this.readyState=4;this.__tH=new XDomainRequest();this.__tH.onerror=qx.Bootstrap.bind(function(){this._emit(u);this._emit(n);this._emit(r);},this);if(qx.core.Environment.get(m)){qx.Bootstrap.debug(qx.bom.request.Xhr,"Retry open native request with method: "+H+", url: "+I+", async: "+J);};this.__tH.open(H,I,J,K,L);return;};window.setTimeout(qx.Bootstrap.bind(function(){if(this.__tJ){return;};this.readyState=4;this._emit(u);this._emit(n);this._emit(r);},this));};};if(qx.core.Environment.get(v)===o&&qx.core.Environment.get(x)<9&&this.__tH.readyState>0){this.__tH.setRequestHeader(z,f);};if(qx.core.Environment.get(v)===p&&parseInt(qx.core.Environment.get(h),10)<2&&!this.__tF){this.readyState=qx.bom.request.Xhr.OPENED;this._emit(u);};},setRequestHeader:function(N,O){this.__tV();if(N==G||N==z||N==j||N==E){this.__tD=true;};this.__tH.setRequestHeader(N,O);return this;},send:function(P){this.__tV();if(!this.__tF&&this.__tG){throw this.__tG;};if(qx.core.Environment.get(v)===s&&this.timeout===0){this.timeout=10000;};if(this.timeout>0){this.__tI=window.setTimeout(this.__tz,this.timeout);};P=typeof P==l?null:P;try{if(qx.core.Environment.get(m)){qx.Bootstrap.debug(qx.bom.request.Xhr,"Send native request");};this.__tH.send(P);}catch(R){if(!this.__tF){throw R;};if(this._getProtocol()===q){this.readyState=2;this.__tN();var Q=this;window.setTimeout(function(){if(Q.__tJ){return;};Q.readyState=3;Q.__tN();Q.readyState=4;Q.__tN();});};};if(qx.core.Environment.get(v)===p&&!this.__tF){this.__tM();};this.__tC=true;return this;},abort:function(){this.__tV();this.__tB=true;this.__tH.abort();if(this.__tH){this.readyState=this.__tH.readyState;};return this;},_emit:function(event){this[B+event]();this._emitter.emit(event,this);},onreadystatechange:function(){},onload:function(){},onloadend:function(){},onerror:function(){},onabort:function(){},ontimeout:function(){},on:function(name,S,T){this._emitter.on(name,S,T);return this;},getResponseHeader:function(U){this.__tV();return this.__tH.getResponseHeader(U);},getAllResponseHeaders:function(){this.__tV();return this.__tH.getAllResponseHeaders();},getRequest:function(){return this.__tH;},dispose:function(){if(this.__tJ){return false;};window.clearTimeout(this.__tI);if(window.detachEvent){window.detachEvent(y,this.__tA);};try{this.__tH.onreadystatechange;}catch(W){return false;};var V=function(){};this.__tH.onreadystatechange=V;this.__tH.onload=V;this.__tH.onerror=V;this.abort();this.__tH=null;this.__tJ=true;return true;},_createNativeXhr:function(){var X=qx.core.Environment.get(C);if(X===i){return new XMLHttpRequest();};if(X==k){return new window.ActiveXObject(b);};qx.Bootstrap.error(this,"No XHR support available.");},_getProtocol:function(){var Y=this.__tE;var ba=/^(\w+:)\/\//;if(Y!==null&&Y.match){var bb=Y.match(ba);if(bb&&bb[1]){return bb[1];};};return window.location.protocol;},__tH:null,__tF:null,__tx:null,__ty:null,__tA:null,__tz:null,__tC:null,__tE:null,__tB:null,__eG:null,__tJ:null,__tI:null,__tG:null,__tD:null,__tK:function(){this.__tH=this._createNativeXhr();this.__tH.onreadystatechange=this.__tx;if(this.__tH.onabort){this.__tH.onabort=this.__ty;};this.__tJ=this.__tC=this.__tB=false;},__tL:function(){if(!this.__tB){this.abort();};},__tM:function(){var bc=this.__tH,bd=true;if(qx.core.Environment.get(m)){qx.Bootstrap.debug(qx.bom.request.Xhr,"Received native readyState: "+bc.readyState);};if(this.readyState==bc.readyState){return;};this.readyState=bc.readyState;if(this.readyState===qx.bom.request.Xhr.DONE&&this.__tB&&!this.__tC){return;};if(!this.__tF&&(bc.readyState==2||bc.readyState==3)){return;};this.status=0;this.statusText=this.responseText=t;this.responseXML=null;if(this.readyState>=qx.bom.request.Xhr.HEADERS_RECEIVED){try{this.status=bc.status;this.statusText=bc.statusText;this.responseText=bc.responseText;this.responseXML=bc.responseXML;}catch(be){bd=false;};if(bd){this.__tR();this.__tS();};};this.__tN();if(this.readyState==qx.bom.request.Xhr.DONE){if(bc){bc.onreadystatechange=function(){};};};},__tN:function(){var bf=this;if(this.readyState===qx.bom.request.Xhr.DONE){window.clearTimeout(this.__tI);};if(qx.core.Environment.get(v)==o&&qx.core.Environment.get(x)<8){if(this.__tF&&!this.__tC&&this.readyState>=qx.bom.request.Xhr.LOADING){if(this.readyState==qx.bom.request.Xhr.LOADING){return;};if(this.readyState==qx.bom.request.Xhr.DONE){window.setTimeout(function(){if(bf.__tJ){return;};bf.readyState=3;bf._emit(u);bf.readyState=4;bf._emit(u);bf.__tO();});return;};};};this._emit(u);if(this.readyState===qx.bom.request.Xhr.DONE){this.__tO();};},__tO:function(){if(this.__eG){this._emit(A);if(qx.core.Environment.get(v)===s){this._emit(n);};this.__eG=false;}else {if(this.__tB){this._emit(c);}else {if(this.__tP()){this._emit(n);}else {this._emit(d);};};};this._emit(r);},__tP:function(){var bg;if(this._getProtocol()===q){bg=!this.responseText;}else {bg=!this.statusText;};return bg;},__tQ:function(){var bh=this.__tH;this.readyState=qx.bom.request.Xhr.DONE;this.__eG=true;bh.abort();this.responseText=t;this.responseXML=null;this.__tN();},__tR:function(){var bi=this.readyState===qx.bom.request.Xhr.DONE;if(this._getProtocol()===q&&this.status===0&&bi){if(!this.__tP()){this.status=200;};};if(this.status===1223){this.status=204;};if(qx.core.Environment.get(v)===s){if(bi&&this.__tD&&!this.__tB&&this.status===0){this.status=304;};};},__tS:function(){if(qx.core.Environment.get(v)==o&&(this.getResponseHeader(D)||t).match(/[^\/]+\/[^\+]+\+xml/)&&this.responseXML&&!this.responseXML.documentElement){var bj=new window.ActiveXObject(F);bj.async=false;bj.validateOnParse=false;bj.loadXML(this.responseText);this.responseXML=bj;};},__tT:function(){try{if(this){this.dispose();};}catch(e){};},__tU:function(){var name=qx.core.Environment.get(v);var bk=qx.core.Environment.get(a);return !(name==o&&bk<9||name==p&&bk<3.5);},__tV:function(){if(this.__tJ){throw new Error("Already disposed");};}},defer:function(){qx.core.Environment.add(m,false);}});})();(function(){var c="qx.io.request.Jsonp",b="Boolean",a="qx.event.type.Event";qx.Class.define(c,{extend:qx.io.request.AbstractRequest,events:{"success":a,"load":a,"statusError":a},properties:{cache:{check:b,init:true}},members:{_createTransport:function(){return new qx.bom.request.Jsonp();},_getConfiguredUrl:function(){var d=this.getUrl(),e;if(this.getRequestData()){e=this._serializeData(this.getRequestData());d=qx.util.Uri.appendParamsToUrl(d,e);};if(!this.getCache()){d=qx.util.Uri.appendParamsToUrl(d,{nocache:new Date().valueOf()});};return d;},_getParsedResponse:function(){return this._transport.responseJson;},setCallbackParam:function(f){this._transport.setCallbackParam(f);},setCallbackName:function(name){this._transport.setCallbackName(name);}}});})();(function(){var u="&",t="null",s='\\t',r='\\"',q='\\n',p='\\b',o="=",n="qx.util.Serializer",m='\\r',l='\\\\',d='\\f',k="}",g="]",c='":',b="",f="get",e="{",h="[",a=",",j='"';qx.Class.define(n,{statics:{toUriParameter:function(v,w,x){var B=b;var C=qx.util.PropertyUtil.getAllProperties(v.constructor);for(var name in C){if(C[name].group!=undefined){continue;};var y=v[f+qx.lang.String.firstUp(name)]();if(qx.lang.Type.isArray(y)){var A=qx.data&&qx.data.IListData&&qx.Class.hasInterface(y&&y.constructor,qx.data.IListData);for(var i=0;i<y.length;i++){var z=A?y.getItem(i):y[i];B+=this.__vb(name,z,w);};}else if(qx.lang.Type.isDate(y)&&x!=null){B+=this.__vb(name,x.format(y),w);}else {B+=this.__vb(name,y,w);};};return B.substring(0,B.length-1);},__vb:function(name,D,E){if(D instanceof qx.core.Object&&E!=null){var F=encodeURIComponent(E(D));if(F===undefined){var F=encodeURIComponent(D);};}else {var F=encodeURIComponent(D);};return encodeURIComponent(name)+o+F+u;},toNativeObject:function(G,H,I){var L;if(G==null){return null;};if(qx.data&&qx.data.IListData&&qx.Class.hasInterface(G.constructor,qx.data.IListData)){L=[];for(var i=0;i<G.getLength();i++){L.push(qx.util.Serializer.toNativeObject(G.getItem(i),H,I));};return L;};if(qx.lang.Type.isArray(G)){L=[];for(var i=0;i<G.length;i++){L.push(qx.util.Serializer.toNativeObject(G[i],H,I));};return L;};if(G instanceof qx.core.Object){if(H!=null){var M=H(G);if(M!=undefined){return M;};};L={};var N=qx.util.PropertyUtil.getAllProperties(G.constructor);for(var name in N){if(N[name].group!=undefined){continue;};var K=G[f+qx.lang.String.firstUp(name)]();L[name]=qx.util.Serializer.toNativeObject(K,H,I);};return L;};if(qx.lang.Type.isDate(G)&&I!=null){return I.format(G);};if(qx.locale&&qx.locale.LocalizedString&&G instanceof qx.locale.LocalizedString){return G.toString();};if(qx.lang.Type.isObject(G)){L={};for(var J in G){L[J]=qx.util.Serializer.toNativeObject(G[J],H,I);};return L;};return G;},toJson:function(O,P,Q){var T=b;if(O==null){return t;};if(qx.data&&qx.data.IListData&&qx.Class.hasInterface(O.constructor,qx.data.IListData)){T+=h;for(var i=0;i<O.getLength();i++){T+=qx.util.Serializer.toJson(O.getItem(i),P,Q)+a;};if(T!=h){T=T.substring(0,T.length-1);};return T+g;};if(qx.lang.Type.isArray(O)){T+=h;for(var i=0;i<O.length;i++){T+=qx.util.Serializer.toJson(O[i],P,Q)+a;};if(T!=h){T=T.substring(0,T.length-1);};return T+g;};if(O instanceof qx.core.Object){if(P!=null){var U=P(O);if(U!=undefined){return j+U+j;};};T+=e;var V=qx.util.PropertyUtil.getAllProperties(O.constructor);for(var name in V){if(V[name].group!=undefined){continue;};var S=O[f+qx.lang.String.firstUp(name)]();T+=j+name+c+qx.util.Serializer.toJson(S,P,Q)+a;};if(T!=e){T=T.substring(0,T.length-1);};return T+k;};if(O instanceof qx.locale.LocalizedString){O=O.toString();};if(qx.lang.Type.isDate(O)&&Q!=null){return j+Q.format(O)+j;};if(qx.lang.Type.isObject(O)){T+=e;for(var R in O){T+=j+R+c+qx.util.Serializer.toJson(O[R],P,Q)+a;};if(T!=e){T=T.substring(0,T.length-1);};return T+k;};if(qx.lang.Type.isString(O)){O=O.replace(/([\\])/g,l);O=O.replace(/(["])/g,r);O=O.replace(/([\r])/g,m);O=O.replace(/([\f])/g,d);O=O.replace(/([\n])/g,q);O=O.replace(/([\t])/g,s);O=O.replace(/([\b])/g,p);return j+O+j;};if(qx.lang.Type.isDate(O)||qx.lang.Type.isRegExp(O)){return j+O+j;};return O+b;}}});})();(function(){var k="qxc/application/datademo/identica.png",j="one",h="http",g="source",f="error",e="selection[0]",d="Location: ",c="Details",b="http://identi.ca/api/statuses/user_timeline/linuxfoundation.json",a="Name: ",B="... service unavailable!",A="</a>",z="' target='_blank'>",y="qxc.application.datademo.Demo",x="user.name",w="user.location",v="<a href='",u="Avatar: ",t="Message: ",s="text",q="mshtml",r="engine.name",o=" ",p="user.profile_image_url",m="value",n="icon",l="model";qx.Class.define(y,{extend:qx.ui.container.Composite,construct:function(){qx.ui.container.Composite.call(this);this._createView();},members:{_createView:function(){this.setLayout(new qx.ui.layout.Canvas());var I=new qx.ui.basic.Image(k);this.add(I,{left:10,top:15});var E=new qx.ui.form.List();this.add(E,{left:10,top:175,bottom:5});E.set({selectionMode:j,width:300,maxHeight:400,height:300});var F=new qx.data.controller.List(null,E);F.setDelegate(this);F.setLabelPath(s);if(qx.core.Environment.get(r)!=q){F.setIconPath(p);};var C=b;var K=new qx.data.store.Jsonp(C);K.bind(l,F,l);var H=new qx.ui.basic.Label(B);H.setTextColor("invalid");H.hide();this.add(H,{left:290,top:145});K.addListener(f,function(){H.show();E.setEnabled(false);D.setEnabled(false);},this);var D=new qx.ui.groupbox.GroupBox(c);this.add(D,{left:320,top:156,bottom:5});D.setWidth(270);D.setHeight(320);D.setAllowGrowY(false);D.setLayout(new qx.ui.layout.Grid(5,5));D.add(new qx.ui.basic.Label(a),{row:0,column:0});D.add(new qx.ui.basic.Label(d),{row:1,column:0});D.add(new qx.ui.basic.Label(t),{row:2,column:0});var name=new qx.ui.basic.Label();D.add(name,{row:0,column:1});var location=new qx.ui.basic.Label();D.add(location,{row:1,column:1});var J=new qx.ui.basic.Label();J.setRich(true);J.setWidth(150);J.setSelectable(true);D.add(J,{row:2,column:1});var G=new qx.data.controller.Object();G.addTarget(name,m,x);G.addTarget(location,m,w);G.addTarget(J,m,s,false,{converter:function(M){var N=M.split(o);for(var i=N.length-1;i>=0;i--){if(N[i].indexOf(h)==0){N[i]=v+N[i]+z+N[i]+A;};};return N.join(o);}});if(qx.core.Environment.get(r)!=q){D.add(new qx.ui.basic.Label(u),{row:3,column:0});var L=new qx.ui.basic.Image();D.add(L,{row:3,column:1});G.addTarget(L,g,p);};F.bind(e,G,l);},configureItem:function(O){O.setRich(true);O.getChildControl(n).setWidth(48);O.getChildControl(n).setHeight(48);O.getChildControl(n).setScale(true);}}});})();
});