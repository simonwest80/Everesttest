---
title: Committed Quantities - Stock Area Assigned
---

# Committed Quantities - Stock Area Assigned


Items committed on the credit order are assigned to **Out** type of stock areas and transferred to the **Stock**  type of stock area only upon creation of the credit memo.


![]({{site.sp_baseurl}}/img/lens.gif)<font style="color: #800080;" color="#800080"> </font>[Stock  Areas Types]({{site.sc_chm}}/options/miscellaneous-set-up/stock-areas/stock_area_types.html)


Display of the [**Attach 
 Quantity** profile]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/cmt-items/enter-cmt-qty/non-ser/the_attach_quantity_profile.html) for non-serialized items depends on the **Use default out stock area to assign quantity 
 for non-serialized items in a credit order or credit memo** option  in the **Location** profile.


[]()Display  of the Attach Quantity Profile


| **Item Type** | **If the preference is <br/> checked** | **If the preference is <br/> unchecked** |
|  | Attach Quantity profile is  displayed |
| Non-serialized item not tracked for lots | No | Yes |
| Non-serialized item tracked for lots | Yes | Yes |



The stock area to which committed quantities are assigned is determined  by the following rules:

- If a default  stock area for credit orders is specified in the **Assign 
 inventory from &gt; Credit Order** field (path: **File 
 &gt; Setup &gt; Preferences &gt; Workstation Settings &gt; Stock Areas 
 &gt; For Sales** tab), the quantities are assigned to this stock  area.



![]({{site.sp_baseurl}}/img/lens.gif) [Workstation  Settings]({{site.sc_chm}}/misc/work_station_settings_stock_areas_for_sales.html)

- If no default  stock areas are defined in the **Workstation 
 Settings** dialog box, the items are assigned to the stock area defined  for credit orders in the logged in location/sub-location (path: **File &gt; Setup &gt; Accounting &gt; Location/Sub-Location 
 &gt; Options &gt; New &gt; Locations &gt; In New Window &gt; Stock Transfer 
 &gt; Sales Document** tab).
- If default  stock areas are NOT defined in **Workstation 
 Settings** or the **Location**  profile, the item remains in the stock area it was in, before it was committed  to the credit order.



{:.note}
- You can assign  different stock areas for items committed in the same credit order.
- The **Stock 
 Area** field displays in the status bar when you need to select a  stock area. Select a stock area and press the **Enter**  key or **ESC** key to exit this field  and continue.


![]({{site.sp_baseurl}}/img/example.gif) You  commit quantities on Item 1 of credit order #1000, and the stock area  determined is 'Customer Returns Expected'. You save the order and then  change workstation settings for credit orders to 'Customer RMA'.


If you reopen order #1000 and commit quantities  for Item 2, the stock area assigned becomes Customer RMA.


{:.warn}
Where the inventory control account of the  stock area from which the items are committed is different from the inventory  control account of the stock area to which the items need to be committed,  there is no stock movement  between  these stock areas. Stock is still retained in the 'From' stock area till  the Purchase Receipt or Invoice is created. On creating the Sales Invoice,  the stock moves to the 'Out' area.


{:.see_also}
See also
: [Location  profile - Stock Transfers for Sales Documents]({{site.sc_chm}}/misc/stock_transfer_sales_document.html)
