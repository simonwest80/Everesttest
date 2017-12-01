---
title: Back End Processes - Receipt on a Sales Invoice
---

# Back End Processes - Receipt on a Sales Invoice


The back end processes when a payment is received against a sales order or sales invoice document are:

- The customer's un-posted amount as seen in the **Customer**'s profile reduces by the amount of payment. The amount receivable from the customer reduces. When the receipt journal for the receipt is posted, the un-posted amount increases and the posted amount reduces with the amount receivable from the customer staying the same.
- The amount received on the sales order or sales invoice increases.
- If the amount is paid by applying a credit memo, the customer's balance is reduced by the amount applied and the amount payable to the customer on the credit memo reduces by the amount applied.



{:.see_also}
See also
: [Back End Processes and Accounting Entries - Sale]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/pmts-refunds/cc-pmts/cc-verify/sale-details/back_end_processes_and_accounting_entries_sale.html)
