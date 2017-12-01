---
title: Accounting Entries - Apply a Purchase Deposit on a Purchase Invoice
---

# Accounting Entries - Apply a Purchase Deposit on a Purchase Invoice


Accounting entry when a purchase deposit is applied on a purchase invoice  is detailed below:


| Entry type | Account | Path | Debit/<br/><br/><br/>Credit | Amount |
| Payment by check/others/credit card/cash | Bank Account | The account defined in the **Account**  field of the **Payment Method** profile  (path: **File** > **Setup**  > **Accounting** > **Payment****Methods** > **Options <br/> &gt; Edit &gt; In New Window**). | Credit | None |
| Payment Discount | Payment Discount on Purchases Account | The account specified in the **Payment <br/> Discount on Purchases** field (path: **File**  > **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **Posting Group** tab).<br/><br/><br/>![]({{site.pp_baseurl}}/img/lens.gif) [Accounting  dialog box - Posting Group tab]({{site.acc_chm}}/accounting-flow-control-and-defaults/accounting-defaults/accounting_dialog_box_-_posting_groups.html) | Credit | Discount value |
| Payment on Purchase Invoice | Accounts Payable Account | The account specified in the **Accounts****payable** field (path: **File**  > **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **Posting Group** profile) of  Vendor Posting Group type.<br/><br/><br/>![]({{site.pp_baseurl}}/img/lens.gif) [Accounting  dialog box - Posting Group tab]({{site.acc_chm}}/accounting-flow-control-and-defaults/accounting-defaults/accounting_dialog_box_-_posting_groups.html) | Debit | Amount applied |
| Apply deposit | Vendor Deposits Account | The account specified in the **Accounts <br/> Payable** field (path: **File**  > **Setup** > **Accounting**  > **Posting Group** profile) of  Vendor Posting Group type.<br/><br/><br/>![]({{site.pp_baseurl}}/img/lens.gif) [Accounting  dialog box - Posting Group tab]({{site.acc_chm}}/accounting-flow-control-and-defaults/accounting-defaults/accounting_dialog_box_-_posting_groups.html) | Credit | Amount applied |



{:.see_also}
See also
: [Defaults  Accounts for Purchase Transactions]({{site.pp_baseurl}}/misc/default_accounts_for_purchase_transactions.html)
