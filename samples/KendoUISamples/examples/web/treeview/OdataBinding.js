/*Generated by SharpKit 5 v4.30.1000*/
$(OnReady);
function OnReady()
{
    var OrderDetails =
    {
        type: "odata",
        transport:
        {
            read:
            {
                url: function (options)
                {
                    return kendo.format("http://demos.kendoui.com/service/Northwind.svc/Products({0})/Order_Details", options["ProductID"]);
                }
            }
        },
        schema:
        {
            model:
            {
                hasChildren: function ()
                {
                    return false;
                }
            }
        }
    };
    var Products =
    {
        type: "odata",
        schema:
        {
            model: {id: "ProductID", hasChildren: "Order_Details", children: OrderDetails}
        },
        transport:
        {
            read:
            {
                url: function (options)
                {
                    return kendo.format("http://demos.kendoui.com/service/Northwind.svc/Categories({0})/Products", options["CategoryID"]);
                }
            }
        }
    };
    var Categories = new kendo.data.HierarchicalDataSource(
    {
        type: "odata",
        transport:
        {
            read: {url: "http://demos.kendoui.com/service/Northwind.svc/Categories"}
        },
        schema:
        {
            model: {hasChildren: "Products", id: "CategoryID", children: Products}
        }
    });
    $("#treeview").kendoTreeView( {dataSource: Categories, dataTextField:  ["CategoryName", "ProductName", "OrderID"]});
};
