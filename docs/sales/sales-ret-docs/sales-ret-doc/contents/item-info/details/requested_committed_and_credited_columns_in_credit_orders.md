---
title: Requested, Committed and Credited Columns in Credit Orders
---

# Requested, Committed and Credited Columns in Credit Orders


**Requested Column**
: The **Requested**  column displays the quantity of the item that the customer wants to return.  The item may be inventoried or non-inventoried. Entering the item quantity  is useful even in case of non-inventoried items.
: ![]({{site.sp_baseurl}}/img/example.gif) You  may not want to maintain an inventory of stationery returned, but it would  be useful to know the information while dealing with the customer.


This column is in the decimal accuracy of the unit of measure. You can  increase the decimal accuracy up to six places.


![]({{site.sp_baseurl}}/img/lens.gif) [Items]({{site.mi_chm}}/items_introduction.html)


**Committed Column**
: The **Committed**  column displays the quantity of the item that the customer has notified  will be returned or has already shipped. The quantity displayed in this  column also represents the following:

- Items  that have been physically received but cannot be accounted into stock  until inspection, approval or items in transit.
- Items  sent for exchange or repair.

: Committed quantities on credit order are assigned  to an out type of stock area. An entry can be made in this column only  for inventoried items. The quantity entered in this column cannot exceed  the quantity requested.


This column is in the decimal accuracy of the unit of measure. You can  increase the decimal accuracy up to six places.


![]({{site.sp_baseurl}}/img/lens.gif) [Stock  Areas]({{site.sc_chm}}/options/miscellaneous-set-up/stock-areas/stock_areas_setup.html)


**Credited Column**
: The **Credited**  column displays the total quantity that has been returned by the customer  and taken into stock. An entry cannot be made directly in this column.  When a credit order is converted to a credit memo, the quantity returned  is entered in the credit memo, as there may be many returns against an  order.


{:.note}
When a committed quantity of a non-serialized item is  returned or serial numbers of a serialized item attached to a credit order  are returned, the quantity in the committed column reduces. The committed  column displays quantities committed but not returned.


The quantity entered in this column depends on the Quantity Entry Method  specified for the item in **Item**  profile (path: **Inventory** >  **Items** > **Options**  > **Edit** > **In 
 New Window** > **Purchases**<font style="font-family: Verdana;" face="Verdana"> tab</font>).


This column is in the decimal accuracy of the unit of measure. You can  increase the decimal accuracy up to six places.


![]({{site.sp_baseurl}}/img/lens.gif) [Quantity  Entry Method]({{site.mi_chm}}/item-profile-details/other-items-information/purchase/quantity_entry_method.html)
