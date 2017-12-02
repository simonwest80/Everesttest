---
title: Back End Processes - Posting Payment Journals
---

# Back End Processes - Posting Payment Journals


The processes that occur in the back end when a payment journal is posted  are:

- Payments will  decrease the vendor's posted amount and increase the unposted  amount, with the net balance remaining the same.
- Refunds will  increase the vendor's posted amount and decrease the unposted  amount, with the net balance remaining the same.
- The period  balances for the account, its parent account and all the accounts higher  to the parent in the COA  hierarchy are updated.



{:.note}
The balance of an account that is an asset  or expense account reduces if it is credited, and increases if it is debited.  The balance of an account that is a liability, revenue or capital account  reduces if it is debited, and increases if it is credited.


{:.see_also}
See also
: [Posting Payment  Journals]({{site.acc_baseurl}}/vendor-payments-and-refunds/payment-jrnl-proc/common-jrnl-proc/posting_payment_journals.html)
