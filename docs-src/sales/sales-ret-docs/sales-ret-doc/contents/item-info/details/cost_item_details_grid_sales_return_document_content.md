---
title: Cost
---

# Cost


The **Cost** column in the Item  Details Grid displays the cost of the item. This column displays the average  cost or the last cost, depending on the preferences set in the **Default 
 value for the user defined cost column in a document** option of  the **Other** **Flow****Control** dialog box (path: **File** > **Setup**  > **Preferences** > **Flow****Control** > **Other****Flow** **Control** > **Item** **Cost**/**Sales** **Summary** tab).


If the display cost in the **Other****Flow** **Control**  dialog box is set to **None** then  the cost displayed will be zero.


If the item is factored, the factored last or average cost is displayed.  Factored costs are displayed only if the item's cost is factored and if  the option **Factor cost (enable cost inflation)**  is selected in the **Other** **Flow Control** dialog box (path: **File &gt; Setup &gt; Preferences &gt; Flow 
 Control &gt; Other Flow Control &gt; Item Cost/Sales Summary** tab).


For non-inventoried items with cost calculated as a percent of selling  price, cost displayed is displayed as a percent of the return price.


![]({{site.sp_baseurl}}/img/lens.gif) [Workstation  Settings]({{site.sc_chm}}/options/miscellaneous-set-up/workstation-settings/work_station_settings.html)


If required, the cost displayed in the sales return document can be  modified.


The cost displayed or entered in this column will be used to calculate  sales commissions:

- If sales commission  is calculated on profits and
- The type of  cost used for commission calculation is user-defined cost (defined in  the **Type of cost used for commission 
 calculation** option of the **Other****Flow Control** dialog box. Path:  **File &gt; Setup &gt; Preferences &gt; 
 Flow Control &gt; Other Flow Control &gt; Item Cost/Sales Summary**  tab).



However, accounting entries for the Cost of Goods sold are generated  for the actual cost (in case of serialized items) or the average cost  (in case of non-serialized or non-inventoried items).


{:.note}
When non-serialized or non-inventoried items are returned,  cost at which the return is accounted is the current average cost and  not the average cost at the time of sale.


{:.see_also}
See also
: [Item  Information]({{site.sp_baseurl}}/misc/item_information_sales_return_document_content.html)
