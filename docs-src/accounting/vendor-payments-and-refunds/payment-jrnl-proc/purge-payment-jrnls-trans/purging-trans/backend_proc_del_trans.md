---
title: Back End Processes - Purge Payment Transactions
---

# Back End Processes - Purge Payment Transactions


The back end processes when a transaction is purged from a payment journal  are:

- The vendor's  unposted amount  and net balance is reduced, if the vendor was credited in the voided transaction;  the vendor's unposted  amount increases, if the vendor was debited in the voided transaction.
- If the entry  type for payment was a miscellaneous deposit, the amount on the manual  purchase order that was created for the transaction is zeroed out.
- If payment  discounts were recorded in the deleted journal/transaction, the **Payment Discount** field on the associated  purchase invoice changes based on the following rules:


- The **Payment 
 Discount** field reduces by the amount credited to the purchase discount  account.
- The **Payment 
 Discount** field increases by the amount debited to the purchase  discount account.



{:.see_also}
See also
: [Purging  transactions]({{site.acc_baseurl}}/vendor-payments-and-refunds/payment-jrnl-proc/purge-payment-jrnls-trans/purging-trans/del_trans_in_pmnt_jrnl.html)
: [Purging  transactions from the Payment Register]({{site.acc_baseurl}}/payment-register/wizard/browser/purging-trans/purging_transactions_from_the_payment_register.html)
