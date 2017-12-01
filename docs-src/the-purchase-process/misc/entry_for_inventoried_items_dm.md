---
title: Entry for inventoried items
---

# Entry for inventoried items


The accounting entry created when a debit memo for inventoried items  is raised is:


| Account | Path | Debit/<br/><br/><br/>Credit | Amount |
| Accounts Payable Account | The account specified in the **Accounts****Payable** field (path: **File**  > **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **Posting Group** tab).<br/><br/><br/>![]({{site.pp_baseurl}}/img/lens.gif) [Accounting  dialog box - Posting Group tab]({{site.acc_chm}}/accounting-flow-control-and-defaults/accounting-defaults/accounting_dialog_box_-_posting_groups.html) | Debit | Total value of the returned items less the discount. |
| Tax Component Account <font style="color: #000000;" color="#000000">(asset account <br/> defined for Value Added Tax recoverable in tax component in purchase tax <br/> code)</font> | The account selected for **Tax****Account** **Code**  in the **Tax** **Components**  profile (path: **File** > **Setup** > **Accounting**  > **Taxes** > **Tax****Components** > **Options <br/> &gt; Edit &gt; In New Window &gt;** **Purchase**  tab). | Credit | The value of tax paid on the items. |
| Gain/Loss on Return | The account specified in the **Gain/Loss <br/> on Return** fields (path: **File**  > **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **Posting Group** tab). | Credit/ Debit | The profile/loss on the return |
| Inventory Control Account | The account specified in the **Inventory****Control** field (path: **File**  > **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **Posting Group** tab). | Credit | The average cost of the item in case of inventoried  items and the actual cost  in  case of serialized items. |



{:.see_also}
See also
: [Accounting  Entries - Creating a Debit Memo]({{site.pp_baseurl}}/return-proc/dms/create-debit-memos/create-a-new-debit-memo/accounting_entries_cre_dm.html)
: [Determining  Inventory Control Account for Sales Documents]({{site.sp_chm}}/misc/determining_inventory_control_account_for_sales_documents.html)
: [Determining  Inventory Control Account for Purchase Documents]({{site.pp_baseurl}}/misc/determining_inventory_control_account_for_purchase_documents.html)
: [Defaults  Accounts for Purchase Transactions]({{site.pp_baseurl}}/misc/default_accounts_for_purchase_transactions.html)
