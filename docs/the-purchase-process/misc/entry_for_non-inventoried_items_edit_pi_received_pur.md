---
title: Entries for Changing Item Cost of Received Non-inventoried Items
---

# Entries for Changing Item Cost of Received Non-inventoried Items


**Editing Item Cost of Received Non-inventoried  Line Items – Increase in Positive Amount**


|  | Account | Debit/Credit | Amount |
| ****Invoiced <br/> Quantity Equals the Received Quantity**** | Expense/Asset | Debit | New Item Amount |
| Accrued Purchase (Adjustment) | Debit/Credit | New Item Amount – Original Accrued Purchases Entry |
| Accrued Purchases | Credit | New Item Amount |
| Purchase Price Variance | Credit/Debit | New Item Amount – Original Item Amount |
| The system updates the existing purchase journal. |
| **Invoiced Quantity Does Not Equal the Received  Quantity** | Expense/Asset | Debit | New Item Amount |
| Accrued Purchases | Credit | New Item Amount |
| The system updates the existing purchase journal. |
| Item Amount = (Quantity \* (Item Cost –  Discount Value)) + Non-recoverable Tax Amount |



{:.note}
The “Balance in the Accrued Purchases account  maintained at each line level in the linked documents” is also the difference  amount between the ACP of the Invoiced Quantity and the ACP of the Received  Quantity.
: ![]({{site.pp_baseurl}}/img/lens.gif)[Balancing  the Accrued Purchases Account where the Invoiced Quantity of a Line Item  is Equal to the Received Quantity]({{site.pp_baseurl}}/purc-proc/pis/create-pi/create-new-pi/balancing_the_acp_account_where_inv_qty_equals_rec_qty_pur.html)


**Editing Item Cost of Received Non-inventoried  Line Items – Decrease in Positive Amount**


|  | Account | Debit/Credit | Amount |
| ****Invoiced <br/> Quantity Equals the Received Quantity**** | Expense/Asset | Debit | New Item Amount |
| Purchase Price Variance | Debit/Credit | New Item Amount – Original Item Amount |
| Accrued Purchase (Adjustment) | Credit/Debit | New Item Amount – Original Accrued Purchases Entry |
| Accrued Purchases | Credit | New Item Amount |
| The system updates the existing purchase journal. |
| **Invoiced Quantity Does Not Equal the Received  Quantity** | Expense/Asset | Debit | New Item Amount |
| Accrued Purchases | Credit | New Item Amount |
| The system updates the existing purchase journal. |
| Item Amount = (Quantity \* (Item Cost –  Discount Value)) + Non-recoverable Tax Amount |



**Editing Item Cost of Received Non-inventoried  Line Items – Increase in Negative Amount**


|  | Account | Debit/Credit | Amount |
| ****Invoiced <br/> Quantity Equals the Received Quantity**** | Purchase Price Variance | Debit/Credit | Balance in the Accrued Purchases account maintained at each line level  in the linked documents |
| Accrued Purchases | Debit | New Item Amount |
| Expense/Asset | Credit | New Item Amount |
| Accrued Purchase (Adjustment) | Credit/Debit | Balance in the Accrued Purchases account maintained at each line level  in the linked documents |
| The system updates the existing purchase journal. |
| **Invoiced Quantity Does Not Equal the Received  Quantity** | Accrued Purchases | Debit | New Item Amount |
| Expense/Asset | Credit | New Item Amount |
| The system updates the existing purchase journal. |
| Item Amount = (Quantity \* (Item Cost –  Discount Value)) + Non-recoverable Tax Amount |



**Editing Item Cost of Received Non-inventoried  Line Items – Decrease in Negative Amount**


|  | Account | Debit/Credit | Amount |
| ****Invoiced <br/> Quantity Equals the Received Quantity**** | Accrued Purchases | Debit | New Item Amount |
| Accrued Purchase (Adjustment) | Debit/Credit | New Item Amount – Original Accrued Purchases Entry |
| Purchase Price Variance | Credit/Debit | New Item Amount – Original Item Amount |
| Expense/Asset | Credit | New Item Amount |
|  | The system updates the existing purchase journal. |
| **Invoiced Quantity Does Not Equal the Received  Quantity** | Accrued Purchases | Debit | New Item Amount |
| Expense/Asset | Credit | New Item Amount |
| The system updates the existing purchase journal. |
| Item Amount = (Quantity \* (Item Cost –  Discount Value)) + Non-recoverable Tax Amount |



{:.see_also}
See also
: [Accounting  Entries - Edit a Purchase Invoice]({{site.pp_baseurl}}/purc-proc/pis/modify-a-purchase-invoice/accounting_entries_edit_a_purchase_invoice_pur.html)
: [Paths  to the Accounts for Accounting Entries]({{site.pp_baseurl}}/misc/paths_to_the_accounts_for_accounting_entries_pur.html)
