---
title: Back End Processes - Purge Receipt Transactions
---

# Back End Processes - Purged Receipt Transactions


The back end processes that occur when a receipt transaction is purged  are:

- The customer's  unposted amount  and net balance increases, if the customer was credited in the voided  transaction; the customer's unposted  amount decreases, if the customer was debited in the voided transaction.
- If the entry  type for payment was a miscellaneous deposit, the manual sales order created  for the transaction is purged.
- If payment  discounts were recorded in the purged transaction, the **Payment 
 Discount** field on the associated sales invoice changes based on  the following rules:


- The **Payment 
 Discount** field reduces by the amount debited to the sales discount  account.
- The **Payment 
 Discount** field increases by the amount credited to the sales discount  account.



{:.see_also}
See also
: [Purging  Receipt Transactions]({{site.acc_baseurl}}/customer-receipts-and-refunds/receipt-jrnl-proc/rcp-jrnl-purge-trans/purging-trans/deleting_transactions_receipt_journal.html)
