---
title: Back End Processes - Mark a Credit Order Close/Open
---

# Back End Processes - Mark a Credit Order Close/Open


The following back-end processes occur  when a credit order is marked as closed or open:

- When a credit  order is marked closed, it appears in the **Received 
 Credit Orders** browser and can be viewed by selecting **Options 
 &gt; Received Credit Orders** from the **Credit 
 Orders** browser.
- The requested  quantity is reduced to zero on a line item that is **not**  on backorder. The committed quantity, if any, is detached.
- If the line  item is on backorder, the requested quantity is updated to the quantity  credited. The committed quantity, if any, is detached. The 'On RMA' stock  gets updated with the ordered quantity and the 'On RMA' commit stock is  reduced to the extent of the uncommitted quantity.
- When a credit  order is marked open it appears in the **Credit 
 Orders** browser.



{:.see_also}
See also
: [Mark  a Credit Order as Close/Open]({{site.sp_baseurl}}/sales-ret-docs/cos/co-proc/mark-close-open/mark_a_credit_order_as_complete_open.html)
