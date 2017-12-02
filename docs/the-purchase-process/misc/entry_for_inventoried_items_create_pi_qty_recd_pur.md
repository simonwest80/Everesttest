---
title: Entry for Inventoried Items - Items Received
---

# Entry for Inventoried Items - Items Received
: When you create a purchase invoice and some quantity  (part or full) is received on the invoice, the following entries are made  in a system Purchase Journal:


| Account | Path | Debit/<br/><br/><br/>Credit | Amount |
| Accounts Payable Account | The account specified in the **Accounts <br/> Payable** field (path: **File**  > **Setup** > **Accounting**  > **Posting Group** profile) of  **Vendor Posting Group** type.<br/><br/><br/>![]({{site.pp_baseurl}}/img/lens.gif) [Defaults  - Accounting]({{site.sc_chm}}/the-company-creation-wizard/accounting/accounting_defaults_setupco.html) | Credit | Total amount of the document (including recoverable  and non-recoverable portion of tax) |
| Accrued Purchases Account | The account specified in the **Accrued <br/> Purchases** field (path: **File**  > **Setup** > **Accounting**  > **Posting Group** profile) of  **Vendor Posting Group** type.<br/><br/><br/>![]({{site.pp_baseurl}}/img/lens.gif) [Defaults  - Accounting]({{site.sc_chm}}/the-company-creation-wizard/accounting/accounting_defaults_setupco.html) | Debit | Difference between invoice and receipt amount (including  non-recoverable portion of tax) |
| Tax Component Account (the asset account for Value  Added Tax recoverable in tax component in the purchase tax code) | The account selected for Tax Account Code in the Tax  Components profile (path: **File**  > **Setup** > **Accounting**  > **Taxes** > **Tax <br/> Components** > **Options**  > **Edit** > **In New Window** > **Purchase**  tab). | Debit | Amount of recoverable tax |
| Inventory Control Account | The account specified in the **Accounts <br/> Payable** field (path: **File**  > **Setup** > **Accounting**  > **Posting Group** profile) of  **Inventory Posting Group** type.<br/><br/><br/>![]({{site.pp_baseurl}}/img/lens.gif) [Item  Details - Accounts]({{site.mi_chm}}/item-profile-details/accounting-information/accounting_information_items.html)<br/><br/><br/>| ![]({{site.pp_baseurl}}/img/lens.gif) | : [Determining  Inventory Control Account for Purchase Documents]({{site.pp_baseurl}}/misc/determining_inventory_control_account_for_purchase_documents.html) | | Debit | Receipt amount (including non-recoverable portion of  tax) |



![]({{site.pp_baseurl}}/img/note.gif)If a negative quantity is included in the Received and  Invoiced column, gain or loss on returns will be credited/debited.


{:.see_also}
See also
: [Entry  for Inventoried Items - No Items Received]({{site.pp_baseurl}}/misc/entry_for_inventoried_items_create_pi_no_recd_pur.html)
: [Accounting  Entries - Create a Purchase Invoice]({{site.pp_baseurl}}/purc-proc/pis/create-pi/create-new-pi/accounting_entries_create_a_purchase_invoice_pur.html)
: [Default  Accounts for Purchase Transactions]({{site.pp_baseurl}}/misc/default_accounts_for_purchase_transactions.html)
: [Hierarchical  Order for Inventory Posting Group]({{site.bp_chm}}/misc/hierarchical_order_for_inventory_posting_group_doc_flow_control_misc_other2_tab.html)
