---
title: Entry for Inventoried Items
---

# Entry for Inventoried Items


**Receiving Inventoried Line Items Retrieved  from a Purchase Order or Added Directly to the Purchase Receipt**


|  | Account | Debit/Credit | Amount |
| FOB Destination | Inventory Control | Debit | Item Amount |
| Accrued Purchases | Credit | Item Amount |
| Item Amount = (Quantity \* (Item Cost – Discount Value))  + Add-on Amount + Non-recoverable Tax Amount |
| FOB Origin | Inventory Control | Debit | Item Amount + Add-on Amount |
| Accrued Purchases | Credit | Item Amount |
| Expense/Liability | Credit | Add-on Amount |
| Item Amount = (Quantity \* (Item Cost – Discount Value))  + Non-recoverable Tax Amount (excludes add-on costs) |



{:.note}
The Add-on Amount for the item is located  in the “Add-on Amount” column of the line item. It is the “Add-on Cost”  column multiplied by the Quantity.


**Receiving Inventoried Line Items Retrieved  from a Purchase Order where the Received Quantity equals the Invoiced  Quantity**


|  | Account | Debit/Credit | Amount |
| FOB Destination | Inventory Control | Debit | Item Amount |
| Accrued Purchases | Credit | Item Amount |
| Accrued Purchase (Adjustment) | Debit/Credit | Balance in the Accrued Purchases account maintained  at each line level in the linked documents |
| Purchase Price Variance | Credit/Debit | Balance in the Accrued Purchases account maintained at each line level  in the linked documents |
| Item Amount = (Quantity \* (Item Cost – Discount Value))  + Add-on Amount + Non-recoverable Tax Amount |
| FOB Origin | Inventory Control | Debit | Item Amount + Add-on Amount |
| Accrued Purchases | Credit | Item Amount |
| Expense/Liability | Credit | Add-on Amount |
| Accrued Purchase (Adjustment) | Debit/Credit | Balance in the Accrued Purchases account maintained  at each line level in the linked documents |
| Purchase Price Variance | Credit/Debit | Balance in the Accrued Purchases account maintained  at each line level in the linked documents |
| Item Amount = (Quantity \* (Item Cost – Discount Value))  + Non-recoverable Tax Amount (excludes add-on costs)<br/><br/><br/>The Item Amount includes the Add-on Amount where indicated. |

: ![]({{site.pp_baseurl}}/img/lens.gif)[Balancing  the Accrued Purchases Account where the Invoiced Quantity of a Line Item  is Equal to the Received Quantity]({{site.pp_baseurl}}/purc-proc/pis/create-pi/create-new-pi/balancing_the_acp_account_where_inv_qty_equals_rec_qty_pur.html)


**Returning Inventoried Line Items (negative  quantity) Retrieved from a Purchase Order or Added Directly to the Purchase  Receipt**


|  | Account | Debit/Credit | Amount |
| FOB Destination | Accrued Purchases | Debit | Item Amount |
| Loss on Purchase Returns (if amount is negative) | Debit | Item Amount - (Quantity \* Average Cost per Purchase Measure) (actual  cost for serialized items) |
| Inventory Control | Credit | Quantity \* Average Cost per Purchase Measure (actual cost for serialized  items) |
| Gain on Purchase Returns (if amount is positive) | Credit | Item Amount - (Quantity \* Average Cost per Purchase Measure) (actual  cost for serialized items) |
| Item Amount = (Quantity \* (Item Cost – Discount Value)) + Non-recoverable  Tax Amount |
| FOB Origin | Accrued Purchases | Debit | Item Amount |
| Loss on Purchase Returns (if amount is negative) | Debit | Item Amount – (Quantity \* Average Cost per Purchase Measure) (actual  cost for serialized items) |
| Inventory Control | Credit | Quantity \* Average cost per Purchase Measure (actual cost for serialized  items) |
| Gain on Purchase Returns (if amount is positive) | Credit | Item Amount – (Quantity \* Average Cost per Purchase Measure) (actual  cost for serialized items) |
| Item Amount = (Quantity \* (Item Cost – Discount Value)) + Non-recoverable  Tax Amount |



**Returning Inventoried Line Items (negative  quantity) Retrieved from a Purchase Order where the Received Quantity  equals the Invoiced Quantity**


|  | Account | Debit/Credit | Amount |
| FOB Destination | Accrued Purchases | Debit | Item Amount |
| Loss on Purchase Returns (if amount is negative) | Debit | Item Amount - (Quantity \* Average Cost per Purchase Measure) (actual  cost for serialized items) |
| Inventory Control | Credit | Quantity \* Average Cost per Purchase Measure (actual cost for serialized  items) |
| Gain on Purchase Returns (if amount is positive) | Credit | Item Amount - (Quantity \* Average Cost per Purchase Measure) (actual  cost for serialized items) |
| Accrued Purchase (Adjustment) | Debit/Credit | Balance in the Accrued Purchases account maintained at each line level  in the linked documents |
| Purchase Price Variance | Credit/Debit | Balance in the Accrued Purchases account maintained at each line level  in the linked documents |
| Item Amount = (Quantity \* (Item Cost – Discount Value)) + Non-recoverable  Tax Amount |
| FOB Origin | Accrued Purchases | Debit | Item Amount |
| Loss on Purchase Returns (if amount is negative) | Debit | Item Amount – (Quantity \* Average Cost per Purchase Measure) |
| Inventory Control | Credit | Quantity \* Average cost per Purchase Measure |
| Gain on Purchase Returns (if amount is positive) | Credit | Item Amount – (Quantity \* Average Cost per Purchase Measure) |
| Accrued Purchase (Adjustment) | Debit/Credit | Balance in the Accrued Purchases account maintained at each line level  in the linked documents |
| Purchase Price Variance | Credit/Debit | Balance in the Accrued Purchases account maintained at each line level  in the linked documents |
| Item Amount = (Quantity \* (Item Cost – Discount Value)) + Non-recoverable  Tax Amount |

: ![]({{site.pp_baseurl}}/img/lens.gif)[Balancing  the Accrued Purchases Account where the Invoiced Quantity of a Line Item  is Equal to the Received Quantity]({{site.pp_baseurl}}/purc-proc/pis/create-pi/create-new-pi/balancing_the_acp_account_where_inv_qty_equals_rec_qty_pur.html)


{:.see_also}
See also
: [Paths  to the Accounts for Accounting Entries]({{site.pp_baseurl}}/misc/paths_to_the_accounts_for_accounting_entries_pur.html)
: [Accounting  Entries - Create a Purchase Receipt]({{site.pp_baseurl}}/purc-proc/prs/create-pr/create-new-pr/accounting_entries_create_pr.html)
: [Default  Accounts for Purchase Transactions]({{site.pp_baseurl}}/misc/default_accounts_for_purchase_transactions.html)
: [Hierarchical  Order for Inventory Posting Group]({{site.bp_chm}}/misc/hierarchical_order_for_inventory_posting_group_doc_flow_control_misc_other2_tab.html)
