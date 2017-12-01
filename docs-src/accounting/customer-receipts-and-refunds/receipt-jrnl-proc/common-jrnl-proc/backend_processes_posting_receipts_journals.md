---
title: Back End Processes - Posting Receipt Journals
---

# Back End Processes - Posting Receipt Journals


The back end processes that occur when a receipt journal is posted are:

- Receipts will  decrease the customer's posted amount and increase the unposted  amount, with the net balance remaining the same.
- Refunds will  increase the customer's posted amount and decrease the unposted  amount, with the net balance remaining the same.
- The period  balances for the account, its parent account and all the accounts higher  to the parent in the COA hierarchy are updated.



{:.note}
The balance of an account that is an asset  or expense account reduces if it is credited, and increases if it is debited.  The balance of an account that is a liability, revenue or capital account  reduces if it is debited, and increases if it is credited.


{:.see_also}
See also
: [Posting  Receipt Journals]({{site.acc_baseurl}}/customer-receipts-and-refunds/receipt-jrnl-proc/common-jrnl-proc/posting_receipts_journals.html)
