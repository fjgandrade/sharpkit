/*@Generated by SharpKit v4.22.2000*/
if(typeof($CreateDelegate)=='undefined'){var $fki=0;var $fkp=String.fromCharCode(1);$CreateDelegate=function(a,b){if(a==null) return b;var c=a.$delegateCache;if(c==null){c={};a.$delegateCache=c;}if(b.$fk==null) {$fki++;b.$fk=$fkp+String($fki);}var d=c[b.$fk];if(d==null){ d=function(){return arguments.callee.func.apply(arguments.callee.target, arguments);};d.func=b;d.target=a;d.isDelegate=true;c[b.$fk]=d;}return d;}}
Spinner = function(sd)
{
    this.buildSpinner(sd);
}
Spinner.prototype.buildSpinner = function(sd)
{
    this.spinnerData = sd;
    var canvas=document.getElementsByTagName("canvas")[0];
    this.ctx = canvas.getContext("2d");
    this.index = 0;
    this.degrees = this.spinnerData.degrees;
    this.degreesList = new Array();
    for(var x=0;x < this.degrees;x++)
    this.degreesList.push(x);
    this.index = 0;
    this.canvasTimer = setInterval($CreateDelegate(this,this.draw),1000 / this.degrees);
}
Spinner.prototype.reset = function()
{
    this.ctx.clearRect(0,0,100,100);
    var left=this.degreesList.slice(0,1);
    var right=this.degreesList.slice(1,this.degreesList.length);
    this.degreesList = right.concat(left);
}
Spinner.prototype.draw = function()
{
    if(this.index == 0)
        this.reset();
    this.ctx.save();
    var degree=this.degreesList[this.index];
    var color=Math.floor(255 / this.degrees * this.index);
    this.ctx.strokeStyle = "rgb(" + color + ", " + color + ", " + color + ")";
    this.ctx.lineWidth = this.spinnerData.size;
    this.ctx.beginPath();
    var startAngle=Math.floor(360 / this.degrees * (degree));
    var endAngle=Math.floor(360 / this.degrees * (degree + 1)) - 1;
    this.ctx.arc(this.spinnerData.x,this.spinnerData.y,this.spinnerData.size,(Math.PI / 180) * startAngle,(Math.PI / 180) * endAngle,false);
    this.ctx.stroke();
    this.ctx.restore();
    this.index++;
    if(this.index >= this.degrees)
        this.index = 0;
}
var spinner=new Spinner({x:50,y:50,size:20,degrees:30});
