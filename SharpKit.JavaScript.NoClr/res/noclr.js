/*Generated by SharpKit v4.28.3000*/
ListHelper = function()
{
};
ListHelper.AddRange = function(list,items)
{
     list.push.apply(list,items);
};
ListHelper.IndexOf = function(list,item)
{
    var length=list.length;
    for(var i=0;i < length;i++)
    {
        if(list[i] == item)
            return i;
    }
    return -1;
};
ListHelper.Remove = function(list,item)
{
    var index=ListHelper.IndexOf(list,item);
    if(index >= 0)
    {
        list.splice(index,1);
        return true;
    }
    return false;
};
