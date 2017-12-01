---
title: Mark Close
---

# Mark Close


A sales order is closed either when all items on an order are shipped  or when you mark an order complete. You can mark an order complete even  if the order contains items on backorder or line items with committed  quantities.


Closed sales orders are displayed only in the **Shipped 
 Sales Orders** browser. The status of a sales order is displayed  in the **Status** column of the **Sales Orders** browser or in the lower  section of the **Sales Order** profile.


{:.steps}
To mark a sales order as closed, do the following:

- Save the **Sales Order** profile.
- Select **Options &gt; Process &gt; Mark Close/Open**.  The sales order will be marked as 'Closed'.



**When you close an 'open' order with line items,  the following changes occur:**

- The ordered  quantity is reduced to zero.
- The committed  quantity, if any, is detached.



**When you close a 'backorder', the following changes  occur:**

- The ordered  quantity is reduced to the quantity shipped (on partially shipped line  items).
- The committed  quantity, if any, is detached.



{:.note}
You cannot mark the following orders complete:

- Orders with  outstanding deposits
- Drop-ship sales  orders
- Sales orders  that are linked to purchase orders



However, for drop-ship orders and orders that are linked  to purchase orders, you can break the link to the sales order and subsequently  mark it closed.


{:.see_also}
See also
: [Mark  a Sales Order as Complete/Open]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/mark-close-open/mark_a_sales_order_as_complete_open.html)
: [Comparison  - Close/Cancel a Sales Order]({{site.sp_baseurl}}/misc/comparison_cancel_and_close_a_sales_order.html)
