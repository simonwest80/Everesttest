---
title: Back End Processes - Committing Items on a Sales Order
---

# Back End Processes - Committing Items on a Sales Order


The following back-end processes occur when items are committed on a  sales order:

- **Stock 
 status for the item** - There is an increase in the 'On Reserve Committed'  stock and a decrease in the free stock for the item committed.
- **Item 
 stock status in the original stock area** - There is a decrease in  the quantity of the **Stock** and  **Free S****tock** (i.e. the stock available for sale) **** of the item in the original stock area. To view the item stock  status, select **Options &gt; Item &gt; 
 Stock Status** from the document profile.
- **Item 
 stock status in the assigned stock area** - There is an increase  in the **Stock** and **On 
 Reserve** stock in the stock area to which the item has been assigned.  The quantity committed is displayed in the **On 
 Reserve** column.



**![]({{site.sp_baseurl}}/img/lens.gif) [Stock  Status]({{site.mi_chm}}/the-items-browser/information-available/item_stock_status_item_browser_option.html)**

- **Serial 
 numbers of serialized/auto-serialized items** - The serial numbers  attached to the document are moved to the stock area that they are assigned  to.



**![]({{site.sp_baseurl}}/img/lens.gif)[Committed  Quantities - Stock Areas Assigned]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/cmt-items/enter-cmt-qty/committed/committed_quantities_stock_areas_assigned.html)**


{:.see_also}
See also
: [Entering  Committed Quantities]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/cmt-items/enter-cmt-qty/entering_committed_quantities.html)
