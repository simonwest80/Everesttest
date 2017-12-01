---
title: Back End Processes - Canceling a Credit Order
---

# Back End Processes - Canceling a Credit Order


**The following back-end processes occur  when a credit order is canceled:**

- The credit  order is converted to a credit quote.
- If the canceled  credit order was converted from a quote, it gets converted to a credit  quote with the same number as the original quote.
- If the canceled  credit order was created directly, it gets converted to a credit quote  with the next number assigned to it in the sequence of credit quotes.
- The sequence  number of the canceled credit order is not available for further use in  other credit orders.
- The quantity  'on credit' for the item reduces in the item stock status.



{:.see_also}
See also
: [Canceling  a Credit Order]({{site.sp_baseurl}}/sales-ret-docs/cos/co-proc/cancel-a-credit-order/canceling_a_credit_order.html)
