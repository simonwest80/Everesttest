---
title: Accounting Entries - Payments from Customers
---

# Accounting Entries - Payments from Customers


The following accounting entry is created when a new payment is received  on a **Point of Sale (sales invoice)**  profile.


| Account | Entry Type | Path | Debit/Credit | Path |
| Bank Account (the account defined for the Payment Method) | Payment by cash/check/<br/><br/><br/>credit card/others | The account selected for **Account** in the **Payment** Method dialog  box (path: **File &gt; Setup &gt; Accounting <br/> &gt; Payment Methods &gt;** **Options <br/> &gt; Edit &gt; In New Window** > **General**  tab) | Debit | Net amount after discount |
| Sales Discount Account | None | The account selected for **Sales <br/> Discounts** in the **Accounting**  dialog box (path: **File &gt; Setup &gt; <br/> Preferences &gt; Defaults &gt; Accounting &gt; Revenue Accounts**  tab) | Debit | Discount value |
| Accounts Receivable Control | Payment on Sales Invoice | The account selected for **Accounts <br/> Receivable** in the **Accounting**  dialog box (path: **File &gt; Setup &gt; <br/> Preferences &gt; Defaults &gt; Accounting &gt; Control Accounts** tab) | Credit | Amount applied |



{:.see_also}
See also
: [The  Card Verification Dialog Box]({{site.pos_baseurl}}/pos-trans/create-pos-doc/pos-receipts/proc-cc-pmnts/verification-dlg/the_card_verification_dialog_box_pos.html)
: [Accounting  Dialog Box - Control Accounts](accounting.chm::/accounting_control_accounts.htm)
