---
title: Back End Processes - Purge/Void Payment/Refund Transactions
---

# Back End Processes - Purge/Void Payment/Refund Transactions 


The back end processes when a payment transaction is purged or voided  from the Payment Register are:

- The vendor's  unposted amount and net balance is reduced, if the vendor was credited  in the voided transaction; the vendor's unposted amount increases, if  the vendor was debited in the voided transaction.
- If the entry  type for payment was 'miscellaneous deposit',  the amount on the manual purchase order created for the transaction is  zeroed out.
- If all transactions  in the journal are deleted, the journal's description changes to "Voided  Journal".
- If payment  discounts were recorded in the purged/voided transaction, the **Payment 
 Discount** field on the associated purchase invoice changes based  on the following rules:


- The **Payment 
 Discount** field reduces by the amount credited to the purchase discount  account.
- The **Payment 
 Discount** field increases by the amount debited to the purchase  discount account.



{:.see_also}
See also
: [Purging  Transactions from the Payment Register]({{site.acc_baseurl}}/payment-register/wizard/browser/purging-trans/purging_transactions_from_the_payment_register.html)
: [Back  End Processes - Deleting Transactions]({{site.acc_baseurl}}/vendor-payments-and-refunds/payment-jrnl-proc/purge-payment-jrnls-trans/purging-trans/backend_proc_del_trans.html)
