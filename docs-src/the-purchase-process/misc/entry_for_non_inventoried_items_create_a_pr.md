---
title: Entry for Non-inventoried Items
---

# Entry for Non-inventoried Items


**Receiving Non-inventoried Line Items Retrieved  from a Purchase Order or Added Directly to the Purchase Receipt (positive  amount)**


| Account | Debit/Credit | Amount |
| Expense/Asset | Debit | Item Amount |
| Accrued Purchases | Credit | Item Amount |
| Item Amount = (Quantity \* (Item Cost – Discount Value))  + Non-recoverable Tax Amount |



**Receiving Non-inventoried Line Items Retrieved  from a Purchase Order or Added Directly to the Purchase Receipt (negative  amount)**


| Account | Debit/Credit | Amount |
| Accrued Purchases | Debit | Item Amount |
| Expense/Asset | Credit | Item Amount |
| Item Amount = (Quantity \* (Item Cost – Discount Value))  + Non-recoverable Tax Amount |



**Receiving Non-inventoried Line Items Retrieved  from a Purchase Order where the Received Quantity equals the Invoiced  Quantity (positive amount)**


| Account | Debit/Credit | Amount |
| Expense/Asset | Debit | Item Amount |
| Accrued Purchases | Credit | Item Amount |
| Accrued Purchase (Adjustment) | Debit/Credit | Balance in the Accrued Purchases account maintained  at each line level in the linked documents |
| Purchase Price Variance | Credit/Debit | Balance in the Accrued Purchases account maintained at each line level  in the linked documents |
| Item Amount = (Quantity \* (Item Cost – Discount Value))  + Non-recoverable Tax Amount |



![]({{site.pp_baseurl}}/img/lens.gif)[Balancing  the Accrued Purchases Account where the Invoiced Quantity of a Line Item  is Equal to the Received Quantity]({{site.pp_baseurl}}/purc-proc/pis/create-pi/create-new-pi/balancing_the_acp_account_where_inv_qty_equals_rec_qty_pur.html)


**Receiving Non-inventoried Line Items Retrieved  from a Purchase Order where the Received Quantity equals the Invoiced  Quantity (negative amount)**


| Account | Debit/Credit | Amount |
| Accrued Purchases | Debit | Item Amount |
| Expense/Asset | Credit | Item Amount |
| Accrued Purchase (Adjustment) | Debit/Credit | Balance in the Accrued Purchases account maintained  at each line level in the linked documents |
| Purchase Price Variance | Credit/Debit | Balance in the Accrued Purchases account maintained at each line level  in the linked documents |
| Item Amount = (Quantity \* (Item Cost – Discount Value))  + Non-recoverable Tax Amount |



{:.see_also}
See also
: [Paths  to the Accounts for Accounting Entries]({{site.pp_baseurl}}/misc/paths_to_the_accounts_for_accounting_entries_pur.html)
: [Accounting  Entries - Create a Purchase Receipt]({{site.pp_baseurl}}/purc-proc/prs/create-pr/create-new-pr/accounting_entries_create_pr.html)
: [Determining  Inventory Control Account for Sales Documents]({{site.sp_chm}}/misc/determining_inventory_control_account_for_sales_documents.html)
: [Determining  Inventory Control Account for Purchase Documents]({{site.pp_baseurl}}/misc/determining_inventory_control_account_for_purchase_documents.html)
: [Default  Accounts for Purchase Transactions]({{site.pp_baseurl}}/misc/default_accounts_for_purchase_transactions.html)
