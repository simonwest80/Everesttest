---
title: Back End Processes - Deposit Received on a Sales Order
---

# Back End Processes - Deposit Received on a Sales Order


The following back-end processes occur  when a deposit is received against a sales order:

- The unposted  amount as seen in the **Customer**'s  profile reduces by the amount of payment received from the customer. The  net balance of the customer is also reduced. When the receipt journal  is posted, the unposted  amount increases and the posted amount reduces with the amount receivable  from the customer staying the same.
- The amount  paid on the sales order increases.
- If the amount  is paid by applying a credit memo, the customer's balance is reduced by  the amount applied. The balance on the sales order is reduced by the amount  applied. If the entire amount of the credit memo is applied, the status  of the Credit Memo changes to 'Paid' in the browser and the balance of  the credit memo becomes 'Nil'.



{:.see_also}
See also
: [Accounting Entries  - Payments from Customers]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/pmts-refunds/pmts-on-so/rcpt-dlg/accounting_entries.html)
