---
title: Entries for Increasing and Decreasing Inventoried Quantity
---

# Entries for Increasing and Decreasing Inventoried Quantity


**Increasing Quantity of Invoiced Inventoried  Line Items Retrieved from a Purchase Order or Purchase Receipt**


|  | Account | Debit/Credit | Amount |
| FOB Destination<br/><br/><br/>Item Amount = (Quantity \* (Item Cost – Discount Value)) + Add-on Amount  + Non-recoverable Tax Amount | **Invoiced Quantity Equals the Received Quantity  after the Increase** |
| Accrued Purchases | Debit | New Item Amount |
| Recoverable Tax Liability | Debit | New Recoverable Tax Amount |
| Accounts Payable | Credit | New Item Amount + New Recoverable Tax Amount |
| Accrued Purchase (Adjustment) | Debit/Credit | Balance in the Accrued Purchases account maintained at each line level  in the linked documents |
| Purchase Price Variance | Credit/Debit | Balance in the Accrued Purchases account maintained at each line level  in the linked documents |
| The system updates the existing purchase journal. |
| **Invoiced Quantity Does Not Equal the Received  Quantity after the Increase** |
| Accrued Purchases | Debit | New Item Amount |
| Recoverable Tax Liability | Debit | New Recoverable Tax Amount |
| Accounts Payable | Credit | New Item Amount + Recoverable Tax Amount |
| The system updates the existing purchase journal. |
| FOB Origin<br/><br/><br/>Item Amount = (Quantity \* (Item Cost – Discount Value)) + Non-recoverable  Tax Amount (excludes add-on costs) | ****Invoiced <br/> Quantity Equals the Received Quantity after the Increase**** |
| Recoverable Tax Liability | Debit | New Recoverable Tax Amount |
| Accrued Purchases | Debit | New Item Amount |
| Accounts Payable | Credit | New Item Amount + New Recoverable Tax Amount |
| Accrued Purchase (Adjustment) | Debit/Credit | Balance in the Accrued Purchases account maintained at each line level  in the linked documents |
| Purchase Price Variance | Credit/Debit | Balance in the Accrued Purchases account maintained at each line level  in the linked documents |
| The system updates the existing purchase journal. |
| **Invoiced Quantity Does Not Equal the Received  Quantity after the Increase** |
| Accrued Purchases | Debit | New Item Amount |
| Recoverable Tax Liability | Debit | New Recoverable Tax Amount |
| Accounts Payable | Credit | New Item Amount + Recoverable Tax Amount |
| The system updates the existing purchase journal. |



{:.note}
- The Add-on Amount  for the item is located in the “Add-on Amount” column of the line item.  It is the “Add-on Cost” column multiplied by the Quantity.
- The “Balance in  the Accrued Purchases account maintained at each line level in the linked  documents” is also the difference amount between the ACP of the Invoiced  Quantity and the ACP of the Received Quantity.
: ![]({{site.pp_baseurl}}/img/lens.gif)[Balancing  the Accrued Purchases Account where the Invoiced Quantity of a Line Item  is Equal to the Received Quantity]({{site.pp_baseurl}}/purc-proc/pis/create-pi/create-new-pi/balancing_the_acp_account_where_inv_qty_equals_rec_qty_pur.html)


**Decreasing Quantity of Invoiced Inventoried  Line Items Retrieved from a Purchase Order or Purchase Receipt**


|  | Account | Debit/Credit | Amount |
| FOB Destination | Accrued Purchases | Debit | New Item Amount |
| Recoverable Tax Liability | Debit | New Recoverable Tax Amount |
| Accounts Payable | Credit | New Item Amount + New Recoverable Tax Amount |
| The system updates the existing purchase journal. If the invoiced quantity  equals the received quantity before you decrease it, the system deletes  the Purchase Price Variance and Accrued Purchase (Adjustment) entries.  The Accrued Purchases, Recoverable Tax Liability, and Accounts Payable  accounts are updated based on the decreased quantity. |
| Item Amount = (Quantity \* (Item Cost – Discount Value)) + Add-on Amount  + Non-recoverable Tax Amount |
| FOB Origin | Accrued Purchases | Debit | New Item Amount |
| Recoverable Tax Liability | Debit | New Recoverable Tax Amount |
| Accounts Payable | Credit | New Item Amount + New Recoverable Tax Amount |
| The system updates the existing purchase journal. If the invoiced quantity  equals the received quantity before you decrease it, the system deletes  the Purchase Price Variance and Accrued Purchase (Adjustment) entries.  The Accrued Purchases, Recoverable Tax Liability, and Accounts Payable  accounts are updated based on the decreased quantity. |
| Item Amount = (Quantity \* (Item Cost – Discount Value)) + Non-recoverable  Tax Amount |



{:.note}
- The Add-on Amount  for the item is located in the “Add-on Amount” column of the line item.  It is the “Add-on Cost” column multiplied by the Quantity.
- The Accrued Purchases,  Recoverable Tax Liability, and Accounts Payable accounts are updated based  on the decreased quantity.


{:.see_also}
See also
: [Paths  to the Accounts for Accounting Entries]({{site.pp_baseurl}}/misc/paths_to_the_accounts_for_accounting_entries_pur.html)
: [Accounting  Entries - Create a Purchase Invoice]({{site.pp_baseurl}}/purc-proc/pis/create-pi/create-new-pi/accounting_entries_create_a_purchase_invoice_pur.html)
