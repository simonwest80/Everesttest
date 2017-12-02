---
title: Back End Processes - Canceling a Sales Order
---

# Back End Processes - Canceling a Sales Order


**The following back-end processes occur  when a sales order is canceled:**

- The sales order  is converted to a sales quote.
- If the canceled  sales order was originally converted from a quote, it gets converted to  a sales quote with the number of the original quote.
- If the canceled  sales order was created directly, it gets converted to a sales quote with  the sales quote number assigned to it.
- The sequence  number of the canceled sales order cannot be used again.
- The quantity  'on reserve'  for the item reduces and available stock increases.



{:.see_also}
See also
: [Canceling  a Sales Order]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/cancel-a-sales-order/canceling_a_sales_order.html)
