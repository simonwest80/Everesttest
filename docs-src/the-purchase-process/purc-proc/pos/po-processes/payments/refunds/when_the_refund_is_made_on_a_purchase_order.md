---
title: When the Refund is made on a Purchase Order
---

# When the Refund is made on a Purchase Order


When a refund is made on a purchase order, the following accounting  entry is created:


| Entry type | Account | Path | Debit/<br/><br/><br/>Credit | Amount |
| Payment by check/others/ credit card/cash | Bank Account | The account defined in the **Account**  field of the **Payment Method** profile  (path: **File** > **Setup**  > **Accounting** > **Payment****Methods** > **Options**  > **Edit** > **In <br/> New Window**) | Debit | Amount of refund |
| Apply/refund deposit | Vendor Deposits Account | The account defined in the **Vendor <br/> Deposit** field of the **Accounting**  dialog box (path: **File** > **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **Posting Group** tab)<br/><br/><br/>![]({{site.pp_baseurl}}/img/lens.gif) [Accounting  dialog box - Posting Group tab]({{site.acc_chm}}/accounting-flow-control-and-defaults/accounting-defaults/accounting_dialog_box_-_posting_groups.html) | Credit | Amount of refund |



{:.see_also}
See also
: [Accounting  Entries - Refunds from Vendors]({{site.pp_baseurl}}/misc/accounting_entries_ref_pr.html)
: [Default  Accounts for Purchase Transactions]({{site.pp_baseurl}}/misc/default_accounts_for_purchase_transactions.html)
