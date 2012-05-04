//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace YUI_.DataTable_
{
    /// <summary>
    /// The baseline implementation of a DataTable.  This class should be used
    /// primarily as a superclass for a custom DataTable with a specific set of
    /// features.  Because features can be composed onto `Y.DataTable`, custom
    /// subclasses of DataTable.Base will remain unmodified when new feature modules
    /// are loaded.
    /// Example usage might look like this:
    /// <pre><code>
    /// // Custom subclass with only sorting and mutability added.  If other datatable
    /// // feature modules are loaded, this class will not be affected.
    /// var MyTableClass = Y.Base.create('table', Y.DataTable.Base,
    /// [ Y.DataTable.Sort, Y.DataTable.Mutable ]);
    /// var table = new MyTableClass({
    /// columns: ['firstName', 'lastName', 'age'],
    /// data: [
    /// { firstName: 'Frank', lastName: 'Zappa', age: 71 },
    /// { firstName: 'Frank', lastName: 'Lloyd Wright', age: 144 },
    /// { firstName: 'Albert', lastName: 'Einstein', age: 132 },
    /// ...
    /// ]
    /// });
    /// table.render('#over-there');
    /// // DataTable.Base can be instantiated if a featureless table is needed.
    /// var table = new Y.DataTable.Base({
    /// columns: ['firstName', 'lastName', 'age'],
    /// data: [
    /// { firstName: 'Frank', lastName: 'Zappa', age: 71 },
    /// { firstName: 'Frank', lastName: 'Lloyd Wright', age: 144 },
    /// { firstName: 'Albert', lastName: 'Einstein', age: 132 },
    /// ...
    /// ]
    /// });
    /// table.render('#in-here');
    /// </code></pre>
    /// DataTable.Base is built from DataTable.Core, and sets the default `headerView`
    /// to `Y.DataTable.HeaderView` and default `bodyView` to `Y.DataTable.BodyView`.
    /// </summary>
    public partial class Base : Widget
    {
    }
}
