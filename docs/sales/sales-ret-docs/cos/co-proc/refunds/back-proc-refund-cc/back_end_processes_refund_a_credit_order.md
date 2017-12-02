---
title: Back End Processes - Refund a Credit Order
---

# Back End Processes - Refund a Credit Order


When a refund is made against a credit order, the following back-end  processes occur:

- The customer's  unposted amount  as seen in the **Customer** profile  increases by the amount of payment. The net balance of the customer increases.  When the receipt journal for the payment is posted, the unposted  amount decreases and the posted amount increases with the net balance  of the customer staying the same.



![]({{site.sp_baseurl}}/img/example.gif) The  customer's net balance (amount receivable from the customer) was initially  $1500 and you create a credit order of $200. When you MAKE a refund of  $100, the customer's account is debited and the net balance increases  to $1600.

- The amount  paid on the credit order increases.
- The total balance  of the credit order reduces.



{:.see_also}
See also
: [Accounting  Entries - Refund Credit Order]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/pmts-refunds/refunds-on-so/accounting_entries_refunds_to_customers.html)
