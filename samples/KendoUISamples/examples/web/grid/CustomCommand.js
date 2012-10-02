/*Generated by SharpKit 5 v4.29.7000*/
$(OnReady);
function OnReady()
{
     var detailsTemplate;
    var grid=$("#grid").kendoGrid(
    {
        dataSource:{pageSize:10,data:createRandomData(50)},
        pageable:true,
        height:260,
        columns: [{field:"FirstName",title:"First Name"},{field:"LastName",title:"Last Name"},{field:"Title"},
        {
            command:{text:"Details",click:showDetails},
            title:" ",
            width:"110px"
        }]
    }).data("kendoGrid");
    var wnd=$("#details").kendoWindow({title:"Customer Details",modal:true,visible:false,resizable:false,maxWidth:300}).data("kendoWindow");
      detailsTemplate = kendo.template($('#template').html());;
    var detailsTemplate=kendo.template($("#template").html());
};
function showDetails(e,wnd)
{
    e.preventDefault();
    var dataItem=this.dataItem($(e.currentTarget).closest("tr"));
    wnd.center().open();
};