---
title: Entry for Non-inventoried Items - Invoiced and Received
---

# Entry for Non-inventoried Items - Invoiced and Received
: When you create a purchase invoice and quantity  is entered in the Invoiced and the Received columns, the following entries  are made in a system Purchase Journal:


| Account | Path | Debit/<br/><br/><br/>Credit | Amount |
| Accounts Payable Account | The account specified in the **Accounts <br/> Payable** field (path: **File**  > **Setup** > **Accounting**  > **Posting Group** profile) of  **Vendor Posting Group** type.<br/><br/><br/>![]({{site.pp_baseurl}}/img/lens.gif) [Defaults  - Accounting]({{site.sc_chm}}/the-company-creation-wizard/accounting/accounting_defaults_setupco.html) | Credit | Total amount of the document (including recoverable  and non-recoverable portion of tax) |
| Asset/Expense Account | The account defined for assets/expenses in the **Posting Group** profile (path: **File**  > **Setup** > **Accounting**  > **Posting Groups**) of the Inventory  Posting Group type. | Debit | Item cost less discount (including non-recoverable portion  of tax) |
| Tax Component Account (the asset account for Value  Added Tax recoverable in tax component in the purchase tax code) | The account selected for Tax Account Code in the Tax  Components profile (path: **File**  > **Setup** > **Accounting**  > **Taxes** > **Tax <br/> Components** > **Options**  > **Edit** > **In New Window** > **Purchase**  tab). | Debit | Amount of recoverable tax paid on the items |



{:.note}
If non-inventoried items will not be accounted  for in the purchase receipt, we recommend you enter the received quantity  as equal to the invoiced quantity in the purchase invoice. This will debit  the Asset/Expense account and credit the Accounts Payable account.


If you enter only the invoiced quantity, the  Accrued Purchases account will be debited and Accounts Payable will be  credited. The Accrued Purchases account will be offset only when the received  quantity is entered in the receipt or in the invoice.


{:.see_also}
See also
: [Entry  for Non-inventoried Items - Invoiced Only]({{site.pp_baseurl}}/misc/entry_for_non_inventoried_items_create_pi_invoiced_only_pur.html)
: [Accounting  Entries - Create a Purchase Invoice]({{site.pp_baseurl}}/purc-proc/pis/create-pi/create-new-pi/accounting_entries_create_a_purchase_invoice_pur.html)
: [Default  Accounts for Purchase Transactions]({{site.pp_baseurl}}/misc/default_accounts_for_purchase_transactions.html)
: [Hierarchical  Order for Inventory Posting Group]({{site.bp_chm}}/misc/hierarchical_order_for_inventory_posting_group_doc_flow_control_misc_other2_tab.html)
