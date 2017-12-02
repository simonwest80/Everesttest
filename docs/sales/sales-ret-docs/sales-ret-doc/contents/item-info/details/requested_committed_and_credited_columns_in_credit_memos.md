---
title: Requested and Credited Columns in Credit Memos
---

# Requested and Credited Columns in Credit Memos


**Requested Column**
: When a credit order is converted to a credit memo  the **Requested** column displays  the quantity that was on order and not returned at the time of creating  the credit memo. When you create a new credit memo this column defaults  to 1 with the decimal accuracy of the unit of measure. You can increase  the decimal accuracy up to 6 places.


![]({{site.sp_baseurl}}/img/example.gif) If  300 units of an item were on order, and the quantities are returned in  2 lots of 100 and 200, the first credit memo would display 300 as the  quantity ordered and the second credit memo would display 200 as the quantity  ordered.


This column is in the decimal accuracy of the unit of measure. You can  increase the decimal accuracy up to six places.


**Credited Column**
: The **Credited**  column displays the quantity of the items returned by the customer. When  a credit order is converted to a credit memo, the credited column displays  the quantity committed (if quantity was committed on the items). If quantity  has not been committed on the item, this column displays the quantity  requested.


{:.note}
You can enter a quantity that is greater than the requested  quantity.


The quantity entered in this column depends on the Quantity Entry Method  specified for the item in **Item**  profile (path: **Inventory** >  **Items** > **Options**  > **Edit** > **In 
 New Window** > **Purchases**<font style="font-family: Verdana;" face="Verdana"> tab</font>).


This column is in the decimal accuracy of the unit of measure. You can  increase the decimal accuracy up to six places.


![]({{site.sp_baseurl}}/img/lens.gif) [Quantity  Entry Method]({{site.mi_chm}}/item-profile-details/other-items-information/purchase/quantity_entry_method.html)
