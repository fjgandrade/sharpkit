/*Generated by SharpKit 5 v4.29.7000*/
if (typeof($CreateDelegate)=='undefined'){
    if(typeof($iKey)=='undefined') var $iKey = 0;
    if(typeof($pKey)=='undefined') var $pKey = String.fromCharCode(1);
    var $CreateDelegate = function(target, func){
        if (target == null || func == null) 
            return func;
        if(func.target==target && func.func==func)
            return func;
        if (target.$delegateCache == null)
            target.$delegateCache = {};
        if (func.$key == null)
            func.$key = $pKey + String(++$iKey);
        var delegate;
        if(target.$delegateCache!=null)
            delegate = target.$delegateCache[func.$key];
        if (delegate == null){
            delegate = function(){
                return func.apply(target, arguments);
            };
            delegate.func = func;
            delegate.target = target;
            delegate.isDelegate = true;
            if(target.$delegateCache!=null)
                target.$delegateCache[func.$key] = delegate;
        }
        return delegate;
    }
}
if(typeof(PhoneGapSamples) == "undefined")
    var PhoneGapSamples={};
PhoneGapSamples.DefaultClient = function()
{
};
PhoneGapSamples.DefaultClient.prototype.DefaultClient_Load = function()
{
    var doc=document;
    doc.addEventListener("deviceready",$CreateDelegate(this,this.doc_deviceready),false);
    doc.removeEventListener("deviceready",$CreateDelegate(this,this.doc_deviceready),false);
};
PhoneGapSamples.DefaultClient.prototype.doc_deviceready = function()
{
};
