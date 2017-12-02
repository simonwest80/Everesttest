---
title: Back End Processes - Purging Receipt Journals
---

# Back End Processes - Purging Receipt Journals


The processes in the back end when a receipt journal is purged are:

- The customer's  unposted amount and net balance increases, if the customer was credited  in the purged transaction. The customer's unposted amount decreases, if  the customer was debited in the purged transaction.
- <font style="color: #000000;" color="#000000">If the entry type for receipt was 'miscellaneous deposit', 
 the manual Sales Order that was created for the transaction is deleted.</font>
- If payment  discounts were recorded in the purged transaction, the **Payment 
 Discount** field on the associated sales invoice changes based on  the following rules:


- The **Payment 
 Discount** field reduces by the amount debited to the sales discount  account.
- The **Payment 
 Discount** field increases by the amount credited to the sales discount  account.



{:.see_also}
See also
: [Purging  Receipt Journals]({{site.acc_baseurl}}/customer-receipts-and-refunds/receipt-jrnl-proc/rcp-jrnl-purge-trans/voiding_receipts_journals.html)
