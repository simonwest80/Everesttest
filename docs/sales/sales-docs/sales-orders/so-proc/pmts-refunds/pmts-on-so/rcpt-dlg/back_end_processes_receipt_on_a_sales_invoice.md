---
title: Back End Processes - Receipt on a Sales Invoice
---

# Back End Processes - Receipt on a Sales Invoice


The following back-end processes occur  when a payment is received against a sales invoice:

- The customer's  unposted amount as seen in the **Customer**'s  profile reduces by the amount of payment. The amount receivable from the  customer reduces. When the receipt journal is posted, the unposted amount  increases and the posted amount reduces with the amount receivable from  the customer staying the same.
- The amount  received on the sales invoice increases. If the total amount due on the  sales invoice is paid, the status of the sales invoice changes to 'Paid'.
- If the amount  is paid by applying a credit memo, the customer's balance is reduced by  the amount applied and the amount payable to the customer on the credit  memo reduces by the amount applied. The status of the credit memo changes  to 'Paid', if the credit memo has been fully applied to the invoice.
- If the amount  is paid by applying an existing deposit received on a sales order, the  deposit available on the sales order reduces by the amount applied. The  balance on the invoice is reduced by the amount applied. The customer's  balance as seen in the **Customer**  profile remains the same.



{:.see_also}
See also
: [Accounting Entries  - Payments from Customers]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/pmts-refunds/pmts-on-so/rcpt-dlg/accounting_entries.html)
