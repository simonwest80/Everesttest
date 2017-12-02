---
title: Back End Processes - Posting Purchase Journals
---

# Back End Processes - Posting Purchase Journals


The processes that occur in the back end when a purchase journal is  posted are:

- Purchase invoice  transactions will increase the vendor's posted amount and reduce the unposted  amount with the net balance of the vendor remaining the same.
- Debit memo  transactions will decrease the vendor's posted amount and increase the  unposted amount  with the net balance of the vendor remaining the same.
- The period  balances for the account, its parent account and all the accounts higher  than the parent in the COA  hierarchy are updated.



![]({{site.acc_baseurl}}/img/lens.gif) [Chart  of Accounts]({{site.sc_chm}}/options/acc-info/coa/chart_of_accounts_1.html)

- The status  of purchase invoices and debit memos displayed in the status bar of the  document changes to **Posted**.



{:.note}
The balance of an account that is an asset  or expense account reduces if it is credited and increases if it is debited.  The balance of an account that is a liability, revenue or capital account  reduces if it is debited, and increases if it is credited.


{:.see_also}
See also
: [Posting  Purchase Journals]({{site.acc_baseurl}}/purchasing/purchase-jrnl-proc/common-jrnl-proc/posting/posting_purchase_journals.html)
