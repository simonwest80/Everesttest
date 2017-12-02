---
title: Back End Processes - Purging Payment Journals
---

# Back End Processes - Purging Payment Journals


The processes in the back end when a payment journal is purged are:

- The vendor's  unposted amount  and net balance is reduced, if the vendor was credited in the purged transaction.  The vendor's unposted  amount increases, if the vendor was debited.
- <font style="color: #000000;" color="#000000">If the entry type for payment was 'miscellaneous deposit', 
 the manual Purchase Order that was created for the transaction is deleted.</font>
- The journal's  description changes to **Purged Journal**.
- If payment  discounts were recorded in the purged journal, the **Payment 
 Discount** field on the associated purchase invoice changes based  on the following rules:


- The **Payment 
 Discount** field reduces by the amount credited to the purchase discount  account.
- The **Payment 
 Discount** field increases by the amount debited to the purchase  discount account.



{:.see_also}
See also
: [Purging Payment  Journals]({{site.acc_baseurl}}/vendor-payments-and-refunds/payment-jrnl-proc/purge-payment-jrnls-trans/voiding_payment_journals.html)
