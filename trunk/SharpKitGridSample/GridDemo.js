/*@Generated by SharpKit v4.23.8000*/
function Load()
{
    var list=new Array();
    for(var i=0;i < 10;i++)
    {
        var c={Name:"MyContact" + i,Age:i,PhoneNumber:"44557799" + i,Description:"This is a contact " + i};
        list.push(c);
    }
    var grid=(function()
    {
        var $v1=new SharpKitGridSample.Grid();
        $v1.Element = document.getElementById("MyGrid");
        return $v1;
    }).call(this);
    grid.Render();
    for(var $i2=0,$l2=list.length,c=list[$i2];$i2 < $l2;$i2++,c = list[$i2])
    {
        var row={Element:grid.CreateRowElement(document.getElementById("MyGridRowTemplate")),Data:c};
        var tr=$(row.Element);
        tr.find(".CellName").text(c.Name);
        tr.find(".CellPhoneNumber").text(c.PhoneNumber);
        tr.find(".CellAge").text(c.Age.toString());
        tr.find(".CellDescription").text(c.Description);
        grid.AddRow(row);
    }
}
