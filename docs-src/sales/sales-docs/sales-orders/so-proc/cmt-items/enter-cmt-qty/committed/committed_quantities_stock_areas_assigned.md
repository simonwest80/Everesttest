---
title: Committed Quantities - Stock Areas Assigned
---

# Committed Quantities - Stock Areas Assigned


When items are committed on a sales order, they are assigned to a **Stock** type of stock area. These items  are transferred to an **Out** type  of stock area only when the related sales invoice is created.


![]({{site.sp_baseurl}}/img/lens.gif)<font style="color: #800080;" color="#800080"> </font>[Stock  Areas Types]({{site.sc_chm}}/options/miscellaneous-set-up/stock-areas/stock_area_types.html)


The stock area to which committed quantities are assigned is determined  based on the following rules:

- If a default  stock area for sales orders is specified in the **Assign 
 inventory from** > **Sales****Order** field of the **Workstation****Settings** (path: **File 
 &gt; Setup &gt; Preferences &gt; Workstation Settings &gt; Stock Areas 
 &gt; For Sales** tab), the quantities are assigned to this stock  area.

: ![]({{site.sp_baseurl}}/img/lens.gif) [Workstation  Settings]({{site.sc_chm}}/misc/work_station_settings_stock_areas_for_sales.html)

- If no default  stock areas are defined in **Workstation 
 Settings**, the items are assigned to the stock area defined for  sales orders in the logged in location/sub-location (path: **File 
 &gt; Setup &gt; Accounting &gt; Location/Sub-Location &gt; Location** profile **&gt; Stock Transfer &gt; Sales Document**  tab). In case of insufficient stock of non-serialized inventoried items  not tracked for lots in the default stock area, **Everest**  automatically searches in other stock areas, at the time of committing  quantities in sales order and invoice. This is done if you have selected  the options to search in other areas in the **Location**  profile (path: **File &gt; Setup &gt; Accounting 
 &gt; Location/Sub-Location &gt; Location** profile **&gt; Stock transfer** tab **&gt; Miscellaneous**  tab).



{:.note}
- The stock area  to which committed quantities are assigned on a sales order will be the  same for a document, irrespective of the workstation settings or flow  control settings at the time of committing the quantities.
- The **Stock 
 Area** field displays in the status bar when you need to select a  stock area. Select a stock area and press the **Enter**  key or **ESC** key to exit this field  and continue.


![]({{site.sp_baseurl}}/img/example.gif) You  commit quantities of Item 1 on sales order #1000, and the stock area determined  is 'Inspection of Customer Shipments'. You save the order and then change  the default stock area for sales orders in the **Workstation 
 Settings** to 'Customer Shipments'.


If you reopen order #1000 and commit quantities  of Item 2, the stock area assigned continues to be 'Inspection of Customer  Shipments'. However, if you commit quantities to a sales order that does  not already have committed items, the stock area used will be 'Customer  Shipments'.


{:.warn}
Where the inventory control account of the  stock area from which the items are committed is different from the inventory  control account of the stock area to which the items need to be committed,  there is no stock movement  between  these stock areas. Stock is still retained in the 'From' stock area till  the Purchase Receipt or Invoice is created. On creating the Sales Invoice,  the stock moves to the 'Out' area.


{:.see_also}
See also
: [Entering  Committed Quantities]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/cmt-items/enter-cmt-qty/entering_committed_quantities.html)
