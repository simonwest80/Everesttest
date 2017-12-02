---
title: Ordered and Shipped Columns in Sales Invoices
---

# Ordered and Shipped Columns in Sales Invoices


**The Ordered Column**


When a sales order is converted to a sales invoice, the **Ordered** column on the sales invoice displays the quantity ordered but not  shipped. When you create a new sales invoice this column defaults to 1  with the decimal accuracy of the unit of measure. You can increase the  decimal accuracy up to 6 places.


![]({{site.sp_baseurl}}/img/example.gif) If  300 units of an item were on order, and the quantities are shipped in  2 lots of 100 and 200, the first sales invoice would display 300 as the  quantity ordered. This is because none of the items have been shipped  as yet. After the first lot of 100 units have been shipped, the second  sales invoice would display the remaining 200 as the quantity ordered.


**The Shipped Column**


The **Shipped** column displays  the quantity of the item shipped (for which the Sales Invoice is being  created). When a Sales Order is converted to a Sales Invoice, the **Shipped** column displays the quantity  committed (if the item quantity is committed). If not, it displays the  quantity ordered unless the option **Set 
 Quantity shipped value to zero when converting the sales order to sales 
 invoice (force you to enter the quantity shipped)** (path: **File &gt; Setup &gt; Preferences** > **Flow****Control** > **Documents**  > **Miscellaneous** > **Others** > **Others 
 1** tab) is checked.


When you create a sales invoice directly, this column gets updated with  the unit quantity for non-inventoried items including kits.


This column is in the decimal accuracy of the unit of measure. You can  increase the decimal accuracy up to six places.


![]({{site.sp_baseurl}}/img/lens.gif) [Documents  - Flow Control - Miscellaneous Tab]({{site.bp_chm}}/flow-ctrl/ctrl/opt/misc/flow_control_setup_dialog_box_miscellaneous_tab_steps.html)


{:.note}
You may enter a quantity that is greater than the ordered  quantity.


Once you save the sales invoice, you cannot change the  quantity of inventoried items in the **Shipped**  column; however, you can modify the quantity of non-inventoried items.


The following fields are updated to the stock measure after conversion  from the sales measure for the item:

- Total Stock
- On Reserve
- On Reserve Commit
- On Credit
- On Credit Commit  Quantity



You cannot change measures in the following situations:

- Committed Quantities
- Backorders
- Shipped Orders



If you change the decimal accuracy of a measure, the original quantity  is shown in the decimal accuracy of the changed measure.


{:.example}
If your quantity is entered as 10.20 and the  decimal accuracy of the measure is changed to 0, the quantity is shown  as 10.


{:.see_also}
See also
: [Item  Information]({{site.sp_baseurl}}/sales-docs/docs-profile/contents/item-info/item_information_item_details_grid_sales_content.html)
