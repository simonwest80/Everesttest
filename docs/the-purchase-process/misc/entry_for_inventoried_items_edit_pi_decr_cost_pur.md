---
title: Entries for Decreasing Item Cost of Inventoried Items
---

# Entries for Decreasing Item Cost of Inventoried Items


**Decreasing the Item Cost of Invoiced Inventoried  Line Items**


|  | Account | Debit/Credit | Amount |
| FOB Destination<br/><br/><br/>Item Amount = (Quantity \* (Item Cost – Discount Value)) + Add-on Amount  + Non-recoverable Tax Amount | ****Invoiced <br/> Quantity Equals the Received Quantity**** |
| Accrued Purchases | Debit | New Item Amount |
| Recoverable Tax Liability | Debit | New Recoverable Tax Amount |
| Purchase Price Variance | Credit/Debit | Balance in the Accrued Purchases account maintained  at each line level in the linked documents |
| Accrued Purchase (Adjustment) | Debit/Credit | Balance in the Accrued Purchases account maintained at each line level  in the linked documents |
| Accounts Payable | Credit | New Item Amount + Recoverable Tax Amount |
| The system updates the existing purchase journal. |
| **Invoiced Quantity Does Not Equal the Received  Quantity** |
| Accrued Purchases | Debit | New Item Amount |
| Recoverable Tax Liability | Debit | New Recoverable Tax Amount |
| Accounts Payable | Credit | New Item Amount + New Recoverable Tax Amount |
| The system updates the existing purchase journal. |
| FOB Origin<br/><br/><br/>Item Amount = (Quantity \* (Item Cost – Discount Value)) + Non-recoverable  Tax Amount (excludes add-on costs) | Invoiced Quantity Equals the Received Quantity |
| Accrued Purchases | Debit | New Item Amount |
| Recoverable Tax Liability | Debit | New Recoverable Tax Amount |
| Accrued Purchase (Adjustment) | Debit/Credit | Balance in the Accrued Purchases account maintained  at each line level in the linked documents |
| Purchase Price Variance | Credit/Debit | Balance in the Accrued Purchases account maintained  at each line level in the linked documents |
| Accounts Payable | Credit | New Item Amount + New Recoverable Tax Amount |
| The system updates the existing purchase journal. |
| Invoiced Quantity Does Not Equal the Received  Quantity |
| Accrued Purchases | Debit | New Item Amount |
| Recoverable Tax Liability | Debit | New Recoverable Tax Amount |
| Accounts Payable | Credit | New Item Amount + New Recoverable Tax Amount |
| The system updates the existing purchase journal. |



{:.note}
- The Add-on Amount  for the item is located in the “Add-on Amount” column of the line item.  It is the “Add-on Cost” column multiplied by the Quantity.
- The “Balance in  the Accrued Purchases account maintained at each line level in the linked  documents” is also the difference amount between the ACP of the Invoiced  Quantity and the ACP of the Received Quantity.
: ![]({{site.pp_baseurl}}/img/lens.gif)[Balancing  the Accrued Purchases Account where the Invoiced Quantity of a Line Item  is Equal to the Received Quantity]({{site.pp_baseurl}}/purc-proc/pis/create-pi/create-new-pi/balancing_the_acp_account_where_inv_qty_equals_rec_qty_pur.html)


**Decreasing the Item Cost of Received Inventoried  Line Items**


|  | Account | Debit/Credit | Amount |
| FOB Destination<br/><br/><br/>Item Amount = (Quantity \* (Item Cost – Discount Value)) + Add-on Amount  + Non-recoverable Tax Amount | Purchase Price Variance | Debit | Difference in Item Amount (New - Original) |
| Inventory Control | Credit | Difference in Item Amount (New - Original) |
| The system creates a Cost Adjustment document. |
| **Invoiced Quantity Equals the Received Quantity** |
| Inventory Control | Debit | Original Item Amount |
| Purchase Price Variance | Debit/Credit | Balance in the Accrued Purchases account maintained at each line level  in the linked documents |
| Accrued Purchases | Credit | New Item Amount |
| Accrued Purchase (Adjustment) | Credit/Debit | Balance in the Accrued Purchases account maintained at each line level  in the linked documents |
| The system updates the existing purchase journal. |
| **Invoiced Quantity Does Not Equal the Received  Quantity** |
| Inventory Control | Debit | Original Item Amount |
| Accrued Purchases | Credit | New Item Amount |
| Purchase Price Variance | Credit | Difference in Item Amount (New - Original) |
| The system updates the existing purchase journal. |
| FOB Origin<br/><br/><br/>Item Amount = (Quantity \* (Item Cost – Discount Value)) + Non-recoverable  Tax Amount (excludes add-on costs) | Purchase Price Variance | Debit | Difference in Item Amount (New - Original) (including  add-on costs for each) |
| Inventory Control | Credit | Difference in Item Amount (New - Original) + Add-on  Amount |
| The system creates a Cost Adjustment document. |
| Invoiced Quantity Equals the Received Quantity |
| Inventory Control | Debit | Original Item Amount |
| Expense/Liability | Debit | New Add-on Amount |
| Purchase Price Variance | Credit/Debit | Balance in the Accrued Purchases account maintained  at each line level in the linked documents |
| Accrued Purchases | Credit | New Item Amount |
| Accrued Purchase (Adjustment) | Debit/Credit | Balance in the Accrued Purchases account maintained  at each line level in the linked documents |
| The system updates the existing purchase journal. |
| Invoiced Quantity Does Not Equal the Received  Quantity |
| Inventory Control | Debit | Original Item Amount |
| Expense/Liability | Debit | New Add-on Amount |
| Purchase Price Variance | Credit | Difference in Add-on Amount (New – Original) |
| Accrued Purchases | Credit | New Item Amount |
| Purchase Price Variance | Credit | Difference in Item Amount (New - Original) |
| The system updates the existing purchase journal. |



{:.note}
- The Add-on Amount  for the item is located in the “Add-on Amount” column of the line item.  It is the “Add-on Cost” column multiplied by the Quantity.
- The “Balance in  the Accrued Purchases account maintained at each line level in the linked  documents” is also the difference amount between the ACP of the Invoiced  Quantity and the ACP of the Received Quantity.
: ![]({{site.pp_baseurl}}/img/lens.gif)[Balancing  the Accrued Purchases Account where the Invoiced Quantity of a Line Item  is Equal to the Received Quantity]({{site.pp_baseurl}}/purc-proc/pis/create-pi/create-new-pi/balancing_the_acp_account_where_inv_qty_equals_rec_qty_pur.html)


**Decreasing the Item Cost of Received Inventoried  Line Items – Quantity Not in Stock**


|  | Account | Debit/Credit | Amount |
| FOB Destination<br/><br/><br/>Item Amount = (Quantity \* (Item Cost – Discount Value)) + Add-on Amount  + Non-recoverable Tax Amount | Purchase Price Variance | Debit | Difference in Item Amount (New - Original) |
| Inventory Adjustment | Credit | Difference in Item Amount (New - Original) |
| The system creates a Cost Adjustment document. |
| **Invoiced Quantity Equals the Received Quantity** |
| Inventory Control | Debit | Original Item Amount |
| Purchase Price Variance | Debit/Credit | Balance in the Accrued Purchases account maintained at each line level  in the linked documents |
| Accrued Purchases | Credit | New Item Amount |
| Accrued Purchase (Adjustment) | Credit/Debit | Balance in the Accrued Purchases account maintained at each line level  in the linked documents |
| The system updates the existing purchase journal. |
| **Invoiced Quantity Does Not Equal the Received  Quantity** |
| Inventory Control | Debit | Original Item Amount |
| Accrued Purchases | Credit | New Item Amount |
| Purchase Price Variance | Credit | Difference in Item Amount (New - Original) |
| The system updates the existing purchase journal. |
| FOB Origin<br/><br/><br/>Item Amount = (Quantity \* (Item Cost – Discount Value)) + Non-recoverable  Tax Amount (excludes add-on costs) | Purchase Price Variance | Debit | Difference in Item Amount (New - Original) (including  add-on costs for each) |
| Inventory Adjustment | Credit | Difference in Item Amount (New - Original) (includes  add-on costs) |
| The system creates a general journal. |
| Invoiced Quantity Equals the Received Quantity |
| Inventory Control | Debit | Original Item Amount |
| Expense/Liability | Debit | New Add-on Amount |
| Accrued Purchases | Credit | New Item Amount |
| Purchase Price Variance | Credit | Difference in Add-on Amount (New – Original) |
| Accrued Purchase (Adjustment) | Credit | Difference in Item Amount (New - Original) |
| The system updates the existing purchase journal. |
| Invoiced Quantity Does Not Equal the Received  Quantity |
| Inventory Control | Debit | Original Item Amount |
| Expense/Liability | Debit | New Add-on Amount |
| Accrued Purchases | Credit | New Item Amount |
| Purchase Price Variance | Credit | Difference in Item Amount (New - Original) |
| Purchase Price Variance | Credit | Difference in Add-on Amount (New – Original) |
| The system updates the existing purchase journal. |



{:.note}
- The Add-on Amount  for the item is located in the “Add-on Amount” column of the line item.  It is the “Add-on Cost” column multiplied by the Quantity.
- The “Balance in  the Accrued Purchases account maintained at each line level in the linked  documents” is also the difference amount between the ACP of the Invoiced  Quantity and the ACP of the Received Quantity.
: ![]({{site.pp_baseurl}}/img/lens.gif)[Balancing  the Accrued Purchases Account where the Invoiced Quantity of a Line Item  is Equal to the Received Quantity]({{site.pp_baseurl}}/purc-proc/pis/create-pi/create-new-pi/balancing_the_acp_account_where_inv_qty_equals_rec_qty_pur.html)


{:.see_also}
See also
: [Accounting  Entries - Edit a Purchase Invoice]({{site.pp_baseurl}}/purc-proc/pis/modify-a-purchase-invoice/accounting_entries_edit_a_purchase_invoice_pur.html)
: [Paths  to the Accounts for Accounting Entries]({{site.pp_baseurl}}/misc/paths_to_the_accounts_for_accounting_entries_pur.html)
