---
title: Accounting Entries - New Payment on a Purchase Invoice
---

# Accounting Entries - New Payment on a Purchase Invoice


Accounting entry when a new payment is made on a purchase invoice is  detailed below:


| **Entry type** | **Account** | **Path** | **Debit/**<br/><br/><br/>**Credit** | **Amount** |
| Payment by check/others/credit card/cash | Bank Account | The account defined in the **Account**  field of the **Payment Method** profile  (path: **File** > **Setup**  > **Accounting** > **Payment****Methods** > **Options <br/> &gt; Edit &gt; In New Window**). | Credit | Net amount paid after discount |
| Payment Discount | Payment Discount on Purchases Account | The account selected for **Payment <br/> Discounts** in the Posting Group profile (path: **File**  > **Setup** > **Preferences**  > **Accounting** > **Posting <br/> Group** profile) of Customer or Inventory Posting Group type depending  on the Flow Control preference (path: **File**  > **Setup** > **Preferences**  > **Flow Control** > **Documents**  > **Miscellaneous** tab > **Others** tab > **Others <br/> 2** tab).<br/><br/><br/>![]({{site.pp_baseurl}}/img/lens.gif) [Accounting  dialog box - Posting Group tab]({{site.acc_chm}}/accounting-flow-control-and-defaults/accounting-defaults/accounting_dialog_box_-_posting_groups.html) | Credit | Discount value |
| Payment on Purchase Invoice | Accounts Payable Account | The account specified in the **Accounts****payable** field (path: **File**  > **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **Posting Group** profile)of  Vendor Posting Group type.<br/><br/><br/>![]({{site.pp_baseurl}}/img/lens.gif) [Accounting  dialog box - Posting Group tab]({{site.acc_chm}}/accounting-flow-control-and-defaults/accounting-defaults/accounting_dialog_box_-_posting_groups.html) | Debit | Total amount of the purchase invoice |



{:.see_also}
See also
: [Default  Accounts for Purchase Transactions]({{site.pp_baseurl}}/misc/default_accounts_for_purchase_transactions.html)
