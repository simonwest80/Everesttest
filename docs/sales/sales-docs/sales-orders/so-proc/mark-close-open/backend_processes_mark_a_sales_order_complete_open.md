---
title: Back End Processes - Mark a Sales Order Close
---

# Back End Processes - Mark a Sales Order Close

- When an order  is marked closed it is displayed only in the **Shipped 
 Sales Orders** browser (path: **Sales 
 Orders** browser **&gt; Options &gt; 
 Shipped Sales Orders**).
- The ordered  quantity is reduced to zero on a line item that is **not**  on backorder. The committed quantity, if any, is detached.
- If the line  item is on backorder, the ordered quantity is reduced to the quantity  shipped. The 'On reserve' stock will get updated with the ordered quantity  and 'On reserve commit' stock will be reduced to the extent of the uncommitted  quantity. The committed quantity, if any, is detached.



{:.see_also}
See also
: [Mark  a Sales Order as Close/Open]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/mark-close-open/mark_a_sales_order_as_complete_open.html)
