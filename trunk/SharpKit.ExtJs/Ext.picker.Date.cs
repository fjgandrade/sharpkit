//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:41 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.picker
{
    #region Date
    /// <inheritdocs />
    /// <summary>
    /// <p>A date picker. This class is used by the <see cref="Ext.form.field.Date">Ext.form.field.Date</see> field to allow browsing and selection of valid
    /// dates in a popup next to the field, but may also be used with other components.</p>
    /// <p>Typically you will need to implement a handler function to be notified when the user chooses a date from the picker;
    /// you can register the handler using the <see cref="Ext.picker.DateEvents.select">select</see> event, or by implementing the <see cref="Ext.picker.DateConfig.handler">handler</see> method.</p>
    /// <p>By default the user will be allowed to pick any date; this can be changed by using the <see cref="Ext.picker.DateConfig.minDate">minDate</see>,
    /// <see cref="Ext.picker.DateConfig.maxDate">maxDate</see>, <see cref="Ext.picker.DateConfig.disabledDays">disabledDays</see>, <see cref="Ext.picker.DateConfig.disabledDatesRE">disabledDatesRE</see>, and/or <see cref="Ext.picker.DateConfig.disabledDates">disabledDates</see> configs.</p>
    /// <p>All the string values documented below may be overridden by including an Ext locale file in your page.</p>
    /// <pre><code><see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.panel.Panel">Ext.panel.Panel</see>', {
    /// title: 'Choose a future date:',
    /// width: 200,
    /// bodyPadding: 10,
    /// renderTo: <see cref="Ext.ExtContext.getBody">Ext.getBody</see>(),
    /// items: [{
    /// xtype: 'datepicker',
    /// minDate: new Date(),
    /// handler: function(picker, date) {
    /// // do something with the selected date
    /// }
    /// }]
    /// });
    /// </code></pre>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Date : Ext.Component
    {
        /// <summary>
        /// The text to display for the aria title
        /// Defaults to: <c>&quot;Date Picker: {0}&quot;</c>
        /// </summary>
        public JsString ariaTitle;
        /// <summary>
        /// The date format to display for the current value in the ariaTitle
        /// Defaults to: <c>&quot;F d, Y&quot;</c>
        /// </summary>
        public JsString ariaTitleDateFormat;
        /// <summary>
        /// An array of textual day names which can be overriden for localization support (defaults to Ext.Date.dayNames)
        /// </summary>
        public JsString dayNames;
        /// <summary>
        /// True to disable animations when showing the month picker.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool disableAnim;
        /// <summary>
        /// The class to apply to disabled cells.
        /// Defaults to: <c>&quot;x-datepicker-disabled&quot;</c>
        /// </summary>
        public JsString disabledCellCls;
        /// <summary>
        /// An array of 'dates' to disable, as strings. These strings will be used to build a dynamic regular expression so
        /// they are very powerful. Some examples:
        /// <li>['03/08/2003', '09/16/2003'] would disable those exact dates</li>
        /// <li>['03/08', '09/16'] would disable those days for every year</li>
        /// <li>['<sup>03/08']</sup> would only match the beginning (useful if you are using short years)</li>
        /// <li>['03/../2006'] would disable every day in March 2006</li>
        /// <li>['<sup>03']</sup> would disable every day in every March</li>
        /// Note that the format of the dates included in the array should exactly match the <see cref="Ext.picker.DateConfig.format">format</see> config. In order
        /// to support regular expressions, if you are using a date format that has '.' in it, you will have to escape the
        /// dot when restricting dates. For example: ['03\.08\.03'].
        /// </summary>
        public JsString disabledDates;
        /// <summary>
        /// JavaScript regular expression used to disable a pattern of dates. The disabledDates
        /// config will generate this regex internally, but if you specify disabledDatesRE it will take precedence over the
        /// disabledDates value.
        /// Defaults to: <c>null</c>
        /// </summary>
        public JsRegExp disabledDatesRE;
        /// <summary>
        /// The tooltip text to display when the date falls on a disabled date.
        /// Defaults to: <c>&quot;Disabled&quot;</c>
        /// </summary>
        public JsString disabledDatesText;
        /// <summary>
        /// An array of days to disable, 0-based. For example, [0, 6] disables Sunday and Saturday.
        /// Defaults to: <c>null</c>
        /// </summary>
        public JsNumber disabledDays;
        /// <summary>
        /// The tooltip to display when the date falls on a disabled day.
        /// Defaults to: <c>&quot;Disabled&quot;</c>
        /// </summary>
        public JsString disabledDaysText;
        /// <summary>
        /// True to automatically focus the picker on show.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool focusOnShow;
        /// <summary>
        /// The default date format string which can be overriden for localization support. The format must be valid
        /// according to Ext.Date.parse (defaults to Ext.Date.defaultFormat).
        /// </summary>
        public JsString format;
        /// <summary>
        /// Optional. A function that will handle the select event of this picker. The handler is passed the following
        /// parameters:
        /// <li><c>picker</c> : <see cref="Ext.picker.Date">Ext.picker.Date</see></li>
        /// This Date picker.
        /// <li><c>date</c> : Date</li>
        /// The selected date.
        /// </summary>
        public System.Delegate handler;
        /// <summary>
        /// Specifies optional custom key event handlers for the Ext.util.KeyNav attached to this date picker. Must
        /// conform to the config format recognized by the Ext.util.KeyNav constructor. Handlers specified in this
        /// object will replace default handlers of the same name.
        /// </summary>
        public JsObject keyNavConfig;
        /// <summary>
        /// The format for displaying a date in a longer format.
        /// Defaults to: <c>&quot;F d, Y&quot;</c>
        /// </summary>
        public JsString longDayFormat;
        /// <summary>
        /// Maximum allowable date (JavaScript date object)
        /// Defaults to: <c>null</c>
        /// </summary>
        public JsDate maxDate;
        /// <summary>
        /// The error text to display if the maxDate validation fails.
        /// Defaults to: <c>&quot;This date is after the maximum date&quot;</c>
        /// </summary>
        public JsString maxText;
        /// <summary>
        /// Minimum allowable date (JavaScript date object)
        /// Defaults to: <c>null</c>
        /// </summary>
        public JsDate minDate;
        /// <summary>
        /// The error text to display if the minDate validation fails.
        /// Defaults to: <c>&quot;This date is before the minimum date&quot;</c>
        /// </summary>
        public JsString minText;
        /// <summary>
        /// An array of textual month names which can be overriden for localization support (defaults to Ext.Date.monthNames)
        /// </summary>
        public JsString monthNames;
        /// <summary>
        /// The date format for the header month
        /// Defaults to: <c>&quot;F Y&quot;</c>
        /// </summary>
        public JsString monthYearFormat;
        /// <summary>
        /// The header month selector tooltip
        /// Defaults to: <c>&quot;Choose a month (Control+Up/Down to move years)&quot;</c>
        /// </summary>
        public JsString monthYearText;
        /// <summary>
        /// The next month navigation button tooltip
        /// Defaults to: <c>&quot;Next Month (Control+Right)&quot;</c>
        /// </summary>
        public JsString nextText;
        /// <summary>
        /// The previous month navigation button tooltip
        /// Defaults to: <c>&quot;Previous Month (Control+Left)&quot;</c>
        /// </summary>
        public JsString prevText;
        /// <summary>
        /// The scope (this reference) in which the handler function will be called.
        /// Defaults to this DatePicker instance.
        /// </summary>
        public JsObject scope;
        /// <summary>
        /// The class to apply to the selected cell.
        /// Defaults to: <c>&quot;x-datepicker-selected&quot;</c>
        /// </summary>
        public JsString selectedCls;
        /// <summary>
        /// False to hide the footer area containing the Today button and disable the keyboard handler for spacebar that
        /// selects the current date.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool showToday;
        /// <summary>
        /// Day index at which the week should begin, 0-based.
        /// Defaults to <c>0</c> (Sunday).
        /// </summary>
        public JsNumber startDay;
        /// <summary>
        /// The text to display on the button that selects the current date
        /// Defaults to: <c>&quot;Today&quot;</c>
        /// </summary>
        public JsString todayText;
        /// <summary>
        /// A string used to format the message for displaying in a tooltip over the button that selects the current date.
        /// The {0} token in string is replaced by today's date.
        /// Defaults to: <c>&quot;{0} (Spacebar)&quot;</c>
        /// </summary>
        public JsString todayTip;
        /// <summary>
        /// Create the month picker instance
        /// </summary>
        /// <returns>
        /// <span><see cref="Ext.picker.Month">Ext.picker.Month</see></span><div><p>picker</p>
        /// </div>
        /// </returns>
        private Month createMonthPicker(){return null;}
        /// <summary>
        /// Update the contents of the picker for a new month
        /// </summary>
        /// <param name="date"><p>The new date</p>
        /// </param>
        private void fullUpdate(JsDate date){}
        /// <summary>
        /// Get the current active date.
        /// </summary>
        /// <returns>
        /// <span><see cref="Date">Date</see></span><div><p>The active date</p>
        /// </div>
        /// </returns>
        private JsDate getActive(){return null;}
        /// <summary>
        /// Gets a single character to represent the day of the week
        /// </summary>
        /// <param name="value">
        /// </param>
        /// <returns>
        /// <span><see cref="String">String</see></span><div><p>The character</p>
        /// </div>
        /// </returns>
        public JsString getDayInitial(object value){return null;}
        /// <summary>
        /// Gets the current selected value of the date field
        /// </summary>
        /// <returns>
        /// <span><see cref="Date">Date</see></span><div><p>The selected date</p>
        /// </div>
        /// </returns>
        public JsDate getValue(){return null;}
        /// <summary>
        /// Respond to a date being clicked in the picker
        /// </summary>
        /// <param name="e">
        /// </param>
        /// <param name="t">
        /// </param>
        private void handleDateClick(EventObject e, object t){}
        /// <summary>
        /// Respond to the mouse wheel event
        /// </summary>
        /// <param name="e">
        /// </param>
        private void handleMouseWheel(EventObject e){}
        /// <summary>
        /// Hides the month picker, if it's visible.
        /// </summary>
        /// <param name="animate"><p>Indicates whether to animate this action. If the animate
        /// parameter is not specified, the behavior will use <see cref="Ext.picker.DateConfig.disableAnim">disableAnim</see> to determine
        /// whether to animate or not.</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Ext.picker.Date">Ext.picker.Date</see></span><div><p>this</p>
        /// </div>
        /// </returns>
        public Ext.picker.Date hideMonthPicker(object animate=null){return null;}
        /// <summary>
        /// Setup the disabled dates regex based on config options
        /// </summary>
        private void initDisabledDays(){}
        /// <summary>
        /// Respond to a cancel click on the month picker
        /// </summary>
        private void onCancelClick(){}
        /// <summary>
        /// Respond to an ok click on the month picker
        /// </summary>
        /// <param name="picker">
        /// </param>
        /// <param name="value">
        /// </param>
        private void onOkClick(object picker, object value){}
        /// <summary>
        /// Perform any post-select actions
        /// </summary>
        private void onSelect(){}
        /// <summary>
        /// Run any animation required to hide/show the month picker.
        /// </summary>
        /// <param name="isHide"><p>True if it's a hide operation</p>
        /// </param>
        private void runAnimation(bool isHide){}
        /// <summary>
        /// Sets the current value to today.
        /// </summary>
        /// <returns>
        /// <span><see cref="Ext.picker.Date">Ext.picker.Date</see></span><div><p>this</p>
        /// </div>
        /// </returns>
        public Ext.picker.Date selectToday(){return null;}
        /// <summary>
        /// Update the selected cell
        /// </summary>
        /// <param name="date"><p>The new date</p>
        /// </param>
        private void selectedUpdate(JsDate date){}
        /// <summary>
        /// Replaces any existing disabled dates with new values and refreshes the DatePicker.
        /// </summary>
        /// <param name="disabledDates"><p>An array of date strings (see the <see cref="Ext.picker.DateConfig.disabledDates">disabledDates</see> config for
        /// details on supported values), or a JavaScript regular expression used to disable a pattern of dates.</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Ext.picker.Date">Ext.picker.Date</see></span><div><p>this</p>
        /// </div>
        /// </returns>
        public Ext.picker.Date setDisabledDates(object disabledDates){return null;}
        /// <summary>
        /// Replaces any existing disabled days (by index, 0-6) with new values and refreshes the DatePicker.
        /// </summary>
        /// <param name="disabledDays"><p>An array of disabled day indexes. See the <see cref="Ext.picker.DateConfig.disabledDays">disabledDays</see> config for details
        /// on supported values.</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Ext.picker.Date">Ext.picker.Date</see></span><div><p>this</p>
        /// </div>
        /// </returns>
        public Ext.picker.Date setDisabledDays(JsArray<Number> disabledDays){return null;}
        /// <summary>
        /// Set the disabled state of various internal components
        /// </summary>
        /// <param name="disabled">
        /// </param>
        private void setDisabledStatus(bool disabled){}
        /// <summary>
        /// Replaces any existing maxDate with the new value and refreshes the DatePicker.
        /// </summary>
        /// <param name="value"><p>The maximum date that can be selected</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Ext.picker.Date">Ext.picker.Date</see></span><div><p>this</p>
        /// </div>
        /// </returns>
        public Ext.picker.Date setMaxDate(JsDate value){return null;}
        /// <summary>
        /// Replaces any existing minDate with the new value and refreshes the DatePicker.
        /// </summary>
        /// <param name="value"><p>The minimum date that can be selected</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Ext.picker.Date">Ext.picker.Date</see></span><div><p>this</p>
        /// </div>
        /// </returns>
        public Ext.picker.Date setMinDate(JsDate value){return null;}
        /// <summary>
        /// Sets the value of the date field
        /// </summary>
        /// <param name="value"><p>The date to set</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Ext.picker.Date">Ext.picker.Date</see></span><div><p>this</p>
        /// </div>
        /// </returns>
        public Ext.picker.Date setValue(JsDate value){return null;}
        /// <summary>
        /// Checks whether a hide/show action should animate
        /// </summary>
        /// <param name="animate"><p>A possible animation value</p>
        /// </param>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div><p>Whether to animate the action</p>
        /// </div>
        /// </returns>
        private bool shouldAnimate(object animate=null){return false;}
        /// <summary>
        /// Show the month picker
        /// </summary>
        /// <param name="animate"><p>Indicates whether to animate this action. If the animate
        /// parameter is not specified, the behavior will use <see cref="Ext.picker.DateConfig.disableAnim">disableAnim</see> to determine
        /// whether to animate or not.</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Ext.picker.Date">Ext.picker.Date</see></span><div><p>this</p>
        /// </div>
        /// </returns>
        public Ext.picker.Date showMonthPicker(object animate=null){return null;}
        /// <summary>
        /// Show the next month.
        /// </summary>
        /// <param name="e">
        /// </param>
        /// <returns>
        /// <span><see cref="Ext.picker.Date">Ext.picker.Date</see></span><div><p>this</p>
        /// </div>
        /// </returns>
        public Ext.picker.Date showNextMonth(object e){return null;}
        /// <summary>
        /// Show the next year.
        /// </summary>
        /// <returns>
        /// <span><see cref="Ext.picker.Date">Ext.picker.Date</see></span><div><p>this</p>
        /// </div>
        /// </returns>
        public Ext.picker.Date showNextYear(){return null;}
        /// <summary>
        /// Show the previous month.
        /// </summary>
        /// <param name="e">
        /// </param>
        /// <returns>
        /// <span><see cref="Ext.picker.Date">Ext.picker.Date</see></span><div><p>this</p>
        /// </div>
        /// </returns>
        public Ext.picker.Date showPrevMonth(object e){return null;}
        /// <summary>
        /// Show the previous year.
        /// </summary>
        /// <returns>
        /// <span><see cref="Ext.picker.Date">Ext.picker.Date</see></span><div><p>this</p>
        /// </div>
        /// </returns>
        public Ext.picker.Date showPrevYear(){return null;}
        /// <summary>
        /// Update the contents of the picker
        /// </summary>
        /// <param name="date"><p>The new date</p>
        /// </param>
        /// <param name="forceRefresh"><p>True to force a full refresh</p>
        /// </param>
        private void update(JsDate date, bool forceRefresh){}
        public Date(Ext.picker.DateConfig config){}
        public Date(){}
        public Date(params object[] args){}
    }
    #endregion
    #region DateConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class DateConfig : Ext.ComponentConfig
    {
        /// <summary>
        /// The text to display for the aria title
        /// Defaults to: <c>&quot;Date Picker: {0}&quot;</c>
        /// </summary>
        public JsString ariaTitle;
        /// <summary>
        /// The date format to display for the current value in the ariaTitle
        /// Defaults to: <c>&quot;F d, Y&quot;</c>
        /// </summary>
        public JsString ariaTitleDateFormat;
        /// <summary>
        /// An array of textual day names which can be overriden for localization support (defaults to Ext.Date.dayNames)
        /// </summary>
        public JsString dayNames;
        /// <summary>
        /// True to disable animations when showing the month picker.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool disableAnim;
        /// <summary>
        /// The class to apply to disabled cells.
        /// Defaults to: <c>&quot;x-datepicker-disabled&quot;</c>
        /// </summary>
        public JsString disabledCellCls;
        /// <summary>
        /// An array of 'dates' to disable, as strings. These strings will be used to build a dynamic regular expression so
        /// they are very powerful. Some examples:
        /// <li>['03/08/2003', '09/16/2003'] would disable those exact dates</li>
        /// <li>['03/08', '09/16'] would disable those days for every year</li>
        /// <li>['<sup>03/08']</sup> would only match the beginning (useful if you are using short years)</li>
        /// <li>['03/../2006'] would disable every day in March 2006</li>
        /// <li>['<sup>03']</sup> would disable every day in every March</li>
        /// Note that the format of the dates included in the array should exactly match the <see cref="Ext.picker.DateConfig.format">format</see> config. In order
        /// to support regular expressions, if you are using a date format that has '.' in it, you will have to escape the
        /// dot when restricting dates. For example: ['03\.08\.03'].
        /// </summary>
        public JsString disabledDates;
        /// <summary>
        /// JavaScript regular expression used to disable a pattern of dates. The disabledDates
        /// config will generate this regex internally, but if you specify disabledDatesRE it will take precedence over the
        /// disabledDates value.
        /// Defaults to: <c>null</c>
        /// </summary>
        public JsRegExp disabledDatesRE;
        /// <summary>
        /// The tooltip text to display when the date falls on a disabled date.
        /// Defaults to: <c>&quot;Disabled&quot;</c>
        /// </summary>
        public JsString disabledDatesText;
        /// <summary>
        /// An array of days to disable, 0-based. For example, [0, 6] disables Sunday and Saturday.
        /// Defaults to: <c>null</c>
        /// </summary>
        public JsNumber disabledDays;
        /// <summary>
        /// The tooltip to display when the date falls on a disabled day.
        /// Defaults to: <c>&quot;Disabled&quot;</c>
        /// </summary>
        public JsString disabledDaysText;
        /// <summary>
        /// True to automatically focus the picker on show.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool focusOnShow;
        /// <summary>
        /// The default date format string which can be overriden for localization support. The format must be valid
        /// according to Ext.Date.parse (defaults to Ext.Date.defaultFormat).
        /// </summary>
        public JsString format;
        /// <summary>
        /// Optional. A function that will handle the select event of this picker. The handler is passed the following
        /// parameters:
        /// <li><c>picker</c> : <see cref="Ext.picker.Date">Ext.picker.Date</see></li>
        /// This Date picker.
        /// <li><c>date</c> : Date</li>
        /// The selected date.
        /// </summary>
        public System.Delegate handler;
        /// <summary>
        /// Specifies optional custom key event handlers for the Ext.util.KeyNav attached to this date picker. Must
        /// conform to the config format recognized by the Ext.util.KeyNav constructor. Handlers specified in this
        /// object will replace default handlers of the same name.
        /// </summary>
        public JsObject keyNavConfig;
        /// <summary>
        /// The format for displaying a date in a longer format.
        /// Defaults to: <c>&quot;F d, Y&quot;</c>
        /// </summary>
        public JsString longDayFormat;
        /// <summary>
        /// Maximum allowable date (JavaScript date object)
        /// Defaults to: <c>null</c>
        /// </summary>
        public JsDate maxDate;
        /// <summary>
        /// The error text to display if the maxDate validation fails.
        /// Defaults to: <c>&quot;This date is after the maximum date&quot;</c>
        /// </summary>
        public JsString maxText;
        /// <summary>
        /// Minimum allowable date (JavaScript date object)
        /// Defaults to: <c>null</c>
        /// </summary>
        public JsDate minDate;
        /// <summary>
        /// The error text to display if the minDate validation fails.
        /// Defaults to: <c>&quot;This date is before the minimum date&quot;</c>
        /// </summary>
        public JsString minText;
        /// <summary>
        /// An array of textual month names which can be overriden for localization support (defaults to Ext.Date.monthNames)
        /// </summary>
        public JsString monthNames;
        /// <summary>
        /// The date format for the header month
        /// Defaults to: <c>&quot;F Y&quot;</c>
        /// </summary>
        public JsString monthYearFormat;
        /// <summary>
        /// The header month selector tooltip
        /// Defaults to: <c>&quot;Choose a month (Control+Up/Down to move years)&quot;</c>
        /// </summary>
        public JsString monthYearText;
        /// <summary>
        /// The next month navigation button tooltip
        /// Defaults to: <c>&quot;Next Month (Control+Right)&quot;</c>
        /// </summary>
        public JsString nextText;
        /// <summary>
        /// The previous month navigation button tooltip
        /// Defaults to: <c>&quot;Previous Month (Control+Left)&quot;</c>
        /// </summary>
        public JsString prevText;
        /// <summary>
        /// The scope (this reference) in which the handler function will be called.
        /// Defaults to this DatePicker instance.
        /// </summary>
        public JsObject scope;
        /// <summary>
        /// The class to apply to the selected cell.
        /// Defaults to: <c>&quot;x-datepicker-selected&quot;</c>
        /// </summary>
        public JsString selectedCls;
        /// <summary>
        /// False to hide the footer area containing the Today button and disable the keyboard handler for spacebar that
        /// selects the current date.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool showToday;
        /// <summary>
        /// Day index at which the week should begin, 0-based.
        /// Defaults to <c>0</c> (Sunday).
        /// </summary>
        public JsNumber startDay;
        /// <summary>
        /// The text to display on the button that selects the current date
        /// Defaults to: <c>&quot;Today&quot;</c>
        /// </summary>
        public JsString todayText;
        /// <summary>
        /// A string used to format the message for displaying in a tooltip over the button that selects the current date.
        /// The {0} token in string is replaced by today's date.
        /// Defaults to: <c>&quot;{0} (Spacebar)&quot;</c>
        /// </summary>
        public JsString todayTip;
        public DateConfig(params object[] args){}
    }
    #endregion
    #region DateEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class DateEvents : Ext.ComponentEvents
    {
        /// <summary>
        /// Fires when a date is selected
        /// </summary>
        /// <param name="this"><p>DatePicker</p>
        /// </param>
        /// <param name="date"><p>The selected date</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void select(Ext.picker.Date @this, JsDate date, object eOpts){}
        public DateEvents(params object[] args){}
    }
    #endregion
}
