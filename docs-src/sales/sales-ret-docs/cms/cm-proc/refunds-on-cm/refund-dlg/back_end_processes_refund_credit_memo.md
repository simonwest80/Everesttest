---
title: Back End Processes - Refund Credit Memo
---

# Back End Processes - Refund Credit Memo


When a refund is made against a credit  memo, the following back-end processes occur:

- The customer's  unposted amount  as seen in the **Customer** profile  increases by the amount of payment. The net balance of the customer increases.  When the receipt journal for the payment is posted, the unposted  amount decreases and the posted amount increases with the net balance  of the Customer staying the same.



![]({{site.sp_baseurl}}/img/example.gif) The customer's net balance  (amount receivable from the customer) was initially $1500 and you create  a credit memo of $200. When you make a refund of $100, the customer's  account is debited and the net balance increases to $1600.

- The amount  paid on the credit memo increases. If the amount paid is applied to a  sales order or sales invoice, then the paid amount on these documents  increases.
- The total balance  of the credit memo reduces. If the amount paid is applied to a sales order  or sales invoice, then the balance on these documents decreases by the  amount applied.



{:.see_also}
See also
: [Accounting  Entries - Refund Credit Memo]({{site.sp_baseurl}}/sales-ret-docs/cms/cm-proc/refunds-on-cm/refund-dlg/accounting_entries_refund_credit_memo.html)
