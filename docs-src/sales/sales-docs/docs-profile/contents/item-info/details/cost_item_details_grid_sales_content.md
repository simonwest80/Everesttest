---
title: Cost
---

# Cost


The **Cost** column in the Item  Details Grid displays the average cost or the last cost of the item depending  on the preference set in the **Default 
 value for the user defined cost column in a document** option of  the **Other Flow Control** dialog  box (path: **File** > **Setup**  > **Preferences** > **Flow****Control** > **Other****Flow** **Control** > **Item** **Cost**/**Sales** **Summary** tab).


If the display cost in the **Other****Flow** **Control**  dialog box is set to **None,** the  cost displayed is zero.


Factored last or average cost is displayed if the item's cost is factored  and you select the option **Factor cost 
 (enable cost inflation)** in the **Other 
 Flow Control** dialog box (path: **File 
 &gt; Setup &gt; Preferences &gt; Flow Control &gt; Other Flow Control 
 &gt; Item Cost/Sales Summary** tab).


For non-inventoried items, the cost displayed is a percentage of the  selling price.


![]({{site.sp_baseurl}}/img/lens.gif) [Workstation  Settings]({{site.sc_chm}}/options/miscellaneous-set-up/workstation-settings/work_station_settings.html)


If a quote is converted to an order or an order is converted to an invoice,  the cost as per the quote or the order is displayed in the converted document.


You can modify the cost displayed for the line item in the Item Details  Grid. The cost displayed or entered in this column is used to calculate  sales commissions:

- If sales commission  is calculated on profits and
- if the type  of cost is user-defined cost, that is defined in the **Type 
 of cost used for commission calculation** option of the **Other****Flow Control** dialog box (path:  **File &gt; Setup &gt; Preferences &gt; 
 Other Flow Control &gt; Item Cost/Sales Summary** tab).



However, accounting entries for Cost of Goods sold are generated for  the actual cost (in case of serialized items) or the average cost (in  case of non-serialized or non-inventoried items).


![]({{site.sp_baseurl}}/img/lens.gif) [Cost  for Commission Calculation with Multiple Unit of Measures]({{site.sp_baseurl}}/misc/cost_for_commission_calculation_with_multiple_unit_of_measures_sales_process.html)


{:.see_also}
See also
: [Item  Information]({{site.sp_baseurl}}/sales-docs/docs-profile/contents/item-info/details/item_details_item_details_grid_sales_process_content.html)
