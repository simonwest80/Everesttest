---
title: Back End Processes - Posting Sales Journals
---

# Back End Processes - Posting Sales Journals


The processes that occur in the back end when a sales journal is posted  are:

- Sales invoice  transactions will increase the customer's posted amount and reduce the  unposted amount  with the net balance remaining the same.
- Credit memo  transactions will decrease the customer's posted amount and increase the  unposted amount  with the net balance remaining the same.
- The period  balances for the account, its parent account and all the accounts higher  than the parent in the COA hierarchy are updated.

: ![]({{site.acc_baseurl}}/img/lens.gif) [Chart  of Accounts]({{site.sc_chm}}/options/acc-info/coa/chart_of_accounts_1.html)

- The status  of sales invoices and credit memos displayed in the status bar of the  document changes to **Posted**.



{:.note}
The balance of an account that is an asset  or expense account reduces if it is credited and increases if it is debited.  The balance of an account that is a liability, revenue or capital account  reduces if it is debited and increases if it is credited.


{:.see_also}
See also
: [Posting Sales  Journals]({{site.acc_baseurl}}/sales/sales-jrnl-proc/common-jrnl-proc/posting_sales_journals.html)
