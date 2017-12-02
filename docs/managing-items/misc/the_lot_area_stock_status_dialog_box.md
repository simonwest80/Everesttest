---
title: The Lot Stock Status Dialog Box
---
<script type="text/javascript" language="JavaScript1.2" x-save-method="compute-relative" src="{{site.mi_baseurl}}/misc/ehlpdhtm.js"></script><script type="text/javascript" language="JavaScript1.2">
<!-- 
if( typeof( kadovFilePopupInit ) != 'function' ) kadovFilePopupInit = new Function();if( typeof( kadovTextPopupInit ) != 'function' ) kadovTextPopupInit = new Function();
 //-->
</script>
**View Menu Options**


You can view quantities in the stock measure, default purchase measure,  or default sales measure.


**View Stock in:**


**Stock Measure**


Select this option to view the Lot Stock Status in the stock measure.  This option is selected by default when viewed from the Item browser.


**Default Purchase Measure**


Select this option to display the Lot Stock Status in the default purchase  measure.


**Default Sales Measure**


Select this option to display the Lot Stock Status in the default sales  measure.

| **Column** | **Displays** |
| Item and Description | The item code and description |
| Item Type | The type of the item. |
| UM | The unit of measure (path: **Inventory <br/> &gt; Items &gt; Options &gt; New &gt; In New Window &gt; Purchase**  tab > **Measure** field) used to  purchase an item. You can view the stock status column by the purchase  measure or the sales measure. |
| Total | The total quantity available in “stock” type of stock areas.<br/><br/><br/>{:.note}<br/>The **Total** column displays quantity for the entire company. Double click this  column to view the location-wise breakup of stock in a new browser. To  view a further breakup for stock areas and bins, double click the Total  Stock column for a specific location. |
| SO Committed | The quantity of the item that has been attached or committed to a sales  order and work orders. |
| DO Committed | The quantity of the item that is identified and committed to a debit  order to be returned to the vendor. |

| **Column** | **Displays** |
| Location | The location of the lot track item. |
| Description | The description of the item. |
| Total | The total quantity available in “stock” type of stock areas. |
| SO Committed | The quantity of the item that has been attached or committed to a sales  order and work orders. |
| DO Committed | The quantity of the item that is identified and committed to a debit  order to be returned to the vendor. |

| **Column** | **Displays** |
| Bin Code | The bin code from where the item is located. |
| Description | The description of the item. |
| Bin Type | The type of the bin. |
| Stock Type | The type of stock (Normal, In Process, Exchange, Scrap).<br/><br/><br/>![]({{site.mi_baseurl}}/img/lens.gif)[Types  of stock area]({{site.sc_chm}}/misc/stock_type_options.html) |
| Total | The quantity of the item in that stock area, if the stock area is of  type 'Stock'. |
| SO Committed | The quantity of the item that has been attached or committed to a sales  order and work orders. |
| DO Committed | The quantity of the item that is identified and committed to a debit  order to be returned to the vendor. |
| Stock Area | The name of the stock area in which the item is located. |

**Expand All**


Click this button to expand all grouping. All the records for each item  group and stock area are displayed.


**Purchase Measure**


Click this button to view the stock status in terms of the [purchase  measure]({{site.mi_chm}}/item-profile-details/other-items-information/purchase/measure_pur.html).


**Sales Measure**


Click this button to view the stock status in terms of the [sales  measure]({{site.mi_chm}}/item-profile-details/other-items-information/sales/sales_measure_sales_info_item_profile.html).

# The Lot Stock Status browser


The **Lot Stock Status** browser  displays the details of lots with quantity in stock. This browser displays  details of the stock attached to each lot and the stock area/bin in which  they are located.


The **Lot Stock Status** browser  is detailed under the following sections:

- [View  Options in the **Lot Stock Status**  browser](javascript:kadovTextPopup(this)){:id="a2"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a2');
//--></script>


- [Columns  in the **Lot Stock Status** browser](javascript:kadovTextPopup(this)){:id="a1"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a1');
//--></script>



Double-clicking the **Total** column  will pop up new browser. Details of the columns of the browser are mentioned  below:

- [Columns  in the **Lot Stock Status &lt; Lot #:lot 
 name&gt;** browser](javascript:kadovTextPopup(this)){:id="a4"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a4');
//--></script>



Double clicking the **Total** column  again will pop up a new browser. Details of the columns of the browser  are mentioned below:

- [Columns  in the **Lot Stock Status &lt; Lot#:lot 
 name location&gt;** browser](javascript:kadovTextPopup(this)){:id="a5"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a5');
//--></script>
- [Options  in the Lot Stock Status browser](javascript:kadovTextPopup(this)){:id="a3"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a3');
//--></script>



{:.see_also}
See also
: [Lots]({{site.mi_baseurl}}/the-items-browser/other-options/lots_items_browser_option.html)
: [Lot  Stock Status - Location wise]({{site.mi_baseurl}}/misc/lot_stock_status_-_location_wise.html)
: [Lot Stock  Status - Bin wise]({{site.mi_baseurl}}/misc/lot_stock_status_-_bin_wise.html)
