---
title: When the Refund is made on a Purchase Invoice
---

# When the Refund is made on a Purchase Invoice


When a refund is made on a purchase invoice, the following accounting  entry is created:


| Entry type | Account | Path | Debit/<br/><br/><br/>Credit | Amount |
| Payment by check/others/credit card/cash | Bank Account | The account defined in the **Account**  field of the **Payment Method** profile  (path: **File** > **Setup**  > **Accounting** > **Payment****Methods** > **Options**  > **Edit** > **In <br/> New Window**) | Debit | Net refund after the called back discount |
| Refund of purchase invoice | Accounts Payable Account | The account defined in the **Accounts**  payable field of the **Accounting**  dialog box (path: **File** > **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **Posting Group** tab)<br/><br/><br/>![]({{site.pp_baseurl}}/img/lens.gif) [Accounting  dialog box - Posting Group tab]({{site.acc_chm}}/accounting-flow-control-and-defaults/accounting-defaults/accounting_dialog_box_-_posting_groups.html) | Credit | Amount of refund |
| Payment Discount | Payment Discount on Purchases Account | The account specified in the **Payment <br/> Discount on Purchases** field of the **Accounting**  dialog box (path: **File** > **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **Posting Group** tab).<br/><br/><br/>![]({{site.pp_baseurl}}/img/lens.gif) [Accounting  dialog box - Posting Group tab]({{site.acc_chm}}/accounting-flow-control-and-defaults/accounting-defaults/accounting_dialog_box_-_posting_groups.html) | Debit | Amount of discount called back |



{:.see_also}
See also
: [Accounting  Entries - Refunds from Vendors]({{site.pp_baseurl}}/misc/accounting_entries_ref_pr.html)
: [Default  Accounts For Purchase Transactions]({{site.pp_baseurl}}/misc/default_accounts_for_purchase_transactions.html)
