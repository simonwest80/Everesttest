---
title: Back End Processes - Purge/Void Receipt/Refund Transactions
---

# Back End Processes - Purge Receipt/Refund Transactions


The back end processes that occur when a receipt/refund transaction  is purged from the **Payment Register**  browser are:

- The customers  unposted amount and net balance increases, if the customer was credited  in the voided transaction; the customer's unposted amount decreases, if  the customer was debited in the voided transaction.
- If the entry  type for payment was a miscellaneous deposit, the manual sales order created  for the transaction is deleted.
- If payment  discounts were recorded in the purged/voided transaction, the **Payment 
 Discount** field on the associated sales invoice changes based on  the following rules:


- The **Payment 
 Discount** field reduces by the amount debited to the sales discount  account.
- The **Payment 
 Discount** field increases by the amount credited to the sales discount  account.



{:.see_also}
See also
: [Purging  Transactions from the Payment Register]({{site.acc_baseurl}}/payment-register/wizard/browser/purging-trans/purging_receipt_refund_transactions_payment_register.html)
