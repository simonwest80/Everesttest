---
title: Entry for Increase in Item Cost, Quantity Not in Stock
---

# Entry for Increase in Item Cost, Quantity Not in Stock


**Increasing Item Cost of Received Inventoried  Line Items – Quantity Not in Stock**


|  | Account | Debit/Credit | Amount |
| FOB Destination<br/><br/><br/>Item Amount = (Quantity \* (Item Cost – Discount Value)) + Add-on Amount  + Non-recoverable Tax Amount | Purchase Price Variance | Credit | Difference in Item Amount (New - Original) |
| Inventory Adjustment | Debit | Difference in Item Amount (New - Original) |
| The system creates a general journal. |
| **Invoiced Quantity Equals the Received Quantity** |
| Inventory Control | Debit | Original Item Amount |
| Accrued Purchases | Credit | New Item Amount |
| Accrued Purchase (Adjustment) | Debit/Credit | Balance in the Accrued Purchases account maintained at each line level  in the linked documents |
| Purchase Price Variance | Debit/Credit | Balance in the Accrued Purchases account maintained at each line level  in the linked documents |
| The system updates the existing purchase journal. |
| **Invoiced Quantity Does Not Equal the Received  Quantity** |
| Inventory Control | Debit | Original Item Amount |
| Accrued Purchases | Credit | New Item Amount |
| Purchase Price Variance | Debit | Difference in Item Amount (New - Original) |
| The system updates the existing purchase journal. |
| FOB Origin<br/><br/><br/>Item Amount = (Quantity \* (Item Cost – Discount Value)) + Non-recoverable  Tax Amount (excludes add-on costs) | Inventory Adjustment | Debit | Difference in Item Amount (New - Original)<br/><br/><br/>(includes add-on costs for each) |
| Purchase Price Variance | Credit | Difference in Item Amount (New - Original) (including  add-on costs for each) |
| The system creates a general journal. |
| Invoiced Quantity Equals the Received Quantity |
| Inventory Control | Debit | Original Item Amount |
| Accrued Purchase (Adjustment) | Debit/Credit | Balance in the Accrued Purchases account maintained  at each line level in the linked documents |
| Purchase Price Variance | Debit/Credit | Balance in the Accrued Purchases account maintained  at each line level in the linked documents |
| Accrued Purchases | Credit | New Item Amount |
| Expense/Liability | Credit | New Add-on Amount |
| The system updates the existing purchase journal. |
| Invoiced Quantity Does Not Equal the Received  Quantity |
| Inventory Control | Debit | Original Item Amount |
| Purchase Price Variance | Debit | Difference in Item Amount (New - Original) |
| Purchase Price Variance | Debit | Difference in Add-on Amount (New – Original) |
| Accrued Purchases | Credit | New Item Amount |
| Expense/Liability | Credit | New Add-on Amount |
| The system updates the existing purchase journal. |



{:.note}
The Add-on Amount for the item is located  in the “Add-on Amount” column of the line item. It is the “Add-on Cost”  column multiplied by the Quantity.


{:.see_also}
See also
: [Paths  to the Accounts for Accounting Entries]({{site.pp_baseurl}}/misc/paths_to_the_accounts_for_accounting_entries_pur.html)
: [Accounting  Entries - Create a Purchase Receipt]({{site.pp_baseurl}}/purc-proc/prs/create-pr/create-new-pr/accounting_entries_create_pr.html)
: [Default  Accounts for Purchase Transactions]({{site.pp_baseurl}}/misc/default_accounts_for_purchase_transactions.html)
: [Hierarchical  Order for Inventory Posting Group]({{site.bp_chm}}/misc/hierarchical_order_for_inventory_posting_group_doc_flow_control_misc_other2_tab.html)
