---
title: Accounting Entries - Collections from Customers
---

# Accounting Entries - Collections from Customers


The following accounting entries are created when a collection is received  on a credit order in the receipt journal:


| Account Name | Entry Type | Path | Debit/<br/><br/><br/>Credit | Amount |
| Bank Account (the account defined for the Payment Method) | Payment by cash/check/credit card/others | The account defined in the Account field of the **Payment** **Method**  profile (path: **File &gt; Setup &gt; Accounting <br/> &gt; Payment Methods** > **Options**  > **New** > **In <br/> New Window**) | Debit | Net amount after discount |
| Sales Discount Account | None | The account defined for **Sales <br/> Discounts** in the **Accounting**  dialog box (path: **File &gt; Setup &gt; <br/> Preferences &gt; Defaults &gt; Accounting &gt; Posting Group** tab)  of Customer or Inventory Posting Group type depending on the Flow Control  preference (path: **File** > **Setup** > **Preferences**  > **Flow Control** > **Documents**  > **Miscellaneous** tab > **Others** tab > **Others <br/> 2** tab) | Debit | Discount value |
| Customer Deposit Account | Apply/Refund Credit Order | The account selected for **Customer <br/> Deposits** in the [**Accounting** dialog box](accounting.chm::/accounting_control_accounts.htm) (path: **File &gt; Setup &gt; Preferences &gt; Defaults <br/> &gt; Accounting &gt; Posting Group** tab) | Credit | Amount applied |
| Customer Deposit Account | Gain/Loss on deposit | The account selected for **Customer <br/> Deposits** in the **Accounting**  dialog box (path: **File &gt; Setup &gt; <br/> Preferences &gt; Defaults &gt; Accounting &gt; Posting Group** tab) | Debit (if there is a loss)<br/><br/><br/>Credit (if there is a gain) | Difference between the original payment rate and the  rate of collection received |



{:.see_also}
See also
: [Receipt  Journal for Receipts]({{site.acc_chm}}/customer-receipts-and-refunds/multiple-receipts/wizard/receipt_information_receipt_journal.html)
: [Collections  on a Credit Order]({{site.sp_baseurl}}/sales-ret-docs/cos/co-proc/collections/collections_on_a_credit_order.html)
