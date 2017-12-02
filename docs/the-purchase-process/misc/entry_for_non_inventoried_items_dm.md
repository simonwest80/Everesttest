---
title: Entry for Non-inventoried Items
---

# Entry for Non-inventoried Items


The accounting entry created when a debit memo for inventoried items  is raised is:


| Account | Path | Debit/<br/><br/><br/>Credit | Amount |
| Accounts Payable Account | The account specified in the **Accounts****Payable** field of the **Accounting**  dialog box (path: **File** > **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **Posting Group** tab).<br/><br/><br/>![]({{site.pp_baseurl}}/img/lens.gif) [Accounting  dialog box - Posting Group tab]({{site.acc_chm}}/accounting-flow-control-and-defaults/accounting-defaults/accounting_dialog_box_-_posting_groups.html) | Debit | Total value of the returned items less the discount. |
| Tax Component Account <font style="color: #000000;" color="#000000">(asset account <br/> defined for Value Added Tax recoverable in tax component in purchase tax <br/> code)</font> | The account selected for **Tax****Account** **Code**  in the **Tax** **Components**  profile (path: **File** > **Setup** > **Accounting**  > **Taxes** > **Tax****Components** > **Options**  > **Edit** > **In****New Window** > **Purchase**  tab). | Credit | The value of tax paid on the items. |
| Asset/Expense Account | The account defined for assets/expenses in the **Posting Group** profile (path: **File <br/> &gt; Setup &gt; Accounting &gt; Posting Group** profile).<br/><br/><br/>![]({{site.pp_baseurl}}/img/lens.gif) [Items  - Accounts]({{site.mi_chm}}/item-profile-details/accounting-information/accounting_information_items.html) | Credit | The cost of the items - discount. |



{:.see_also}
See also
: [Accounting  Entries - Creating a Debit Memo]({{site.pp_baseurl}}/return-proc/dms/create-debit-memos/create-a-new-debit-memo/accounting_entries_cre_dm.html)
: [Determining  Inventory Control Account for Sales Documents]({{site.sp_chm}}/misc/determining_inventory_control_account_for_sales_documents.html)
: [Determining  Inventory Control Account for Purchase Documents]({{site.pp_baseurl}}/misc/determining_inventory_control_account_for_purchase_documents.html)
: [Defaults  Accounts for Purchase Transactions]({{site.pp_baseurl}}/misc/default_accounts_for_purchase_transactions.html)
