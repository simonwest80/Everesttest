---
title: Back End Processes - Void Payroll Journal
---

# Back End Processes - Void Payroll Journal


When you create a Payroll Journal (path: **Payroll 
 Journal &gt; Create Payroll Journal**), a purchase receipt is created  to account for the take home pay of each employee.


Following are the back end processes that take place, when you void  a payroll journal:

- A debit memo  is created.
- A payment journal  with the description "Cancellation of Payroll Transactions"  is created.
- The debit memo  is applied to the purchase receipt that is voided.



Accounting Entries - Void Payroll Journal


The following accounting entry is created in a payment journal.


| Entry Type | Account | Path | Debit/<br/><br/><br/>Credit | Amount |
| Payment on Purchase Receipt | Accounts Payable Control | The A/P control account in the Vendor Posting Group  assigned to the Employee vendor.<br/><br/><br/>![]({{site.prl_baseurl}}/img/lens.gif)[Hierarchical  order for Vendor Posting Group]({{site.bp_chm}}/misc/hierarchical_order_for_vendor_posting_group_misc_tab.html) | Debit | Take home pay |
| Apply/Refund Debit Memo | Accounts Payable Control | The A/P control account in the Vendor Posting Group  assigned to the Employee vendor.<br/><br/><br/>![]({{site.prl_baseurl}}/img/lens.gif)[Hierarchical  order for Vendor Posting Group]({{site.bp_chm}}/misc/hierarchical_order_for_vendor_posting_group_misc_tab.html) | Credit | Take home pay |



{:.see_also}
See also
: [Accounting  Entries for Payroll ]({{site.prl_baseurl}}/payroll-process/creating-journal/accounting_entries_for_payroll.html)
