---
title: Entries for Invoicing Inventoried Items
---

# Entry for Invoicing Inventoried Items


**Invoicing Inventoried Line Items Retrieved from  a Purchase Order or Purchase Receipt**


|  | Account | Debit/Credit | Amount |
| FOB Destination | Accrued Purchases | Debit | Item Amount |
| Recoverable Tax Liability | Debit | Recoverable Tax Amount |
| Accounts Payable | Credit | Item Amount + Recoverable Tax Amount |
| Item Amount = (Quantity \* (Item Cost – Discount Value))  + Add-on Amount + Non-recoverable Tax Amount |
| FOB Origin | Accrued Purchases | Debit | Item Amount |
| Recoverable Tax Liability | Debit | Recoverable Tax Amount |
| Accounts Payable | Credit | Item Amount + Recoverable Tax Amount |
| Item Amount = (Quantity \* (Item Cost – Discount Value))  + Non-recoverable Tax Amount (excludes add-on costs) |



{:.note}
**The Add-on Amount for the item is located  in the “Add-on Amount” column of the line item. It is the “Add-on Cost”  column multiplied by the Quantity.**


**Invoicing Inventoried Line Items:**

- Retrieved from  a purchase order where the quantity you invoice equals all of the quantities  received in purchase receipts and purchase invoices linked to the same  purchase order
- Retrieved from  a purchase receipt where the quantity you invoice equals the quantity  received in the purchase receipt



|  | Account | Debit/Credit | Amount |
| FOB Destination | Accrued Purchases | Debit | Item Amount |
| Recoverable Tax Liability | Debit | Recoverable Tax Amount |
| Accounts Payable | Credit | Item Amount + Recoverable Tax Amount |
| Accrued Purchase (Adjustment) | Debit/Credit | Balance in the Accrued Purchases account maintained at each line level  in the linked documents |
| Purchase Price Variance | Credit/Debit | Balance in the Accrued Purchases account maintained at each line level  in the linked documents |
| Item Amount = (Quantity \* (Item Cost – Discount Value))  + Add-on Amount + Non-recoverable Tax Amount |
| FOB Origin | Accrued Purchases | Debit | Item Amount |
| Recoverable Tax Liability | Debit | Recoverable Tax Amount |
| Accounts Payable | Credit | Item Amount + Recoverable Tax Amount |
| Accrued Purchase (Adjustment) | Debit/Credit | Balance in the Accrued Purchases account maintained  at each line level in the linked documents |
| Purchase Price Variance | Credit/Debit | Balance in the Accrued Purchases account maintained at each line level  in the linked documents |
| Item Amount = (Quantity \* (Item Cost – Discount Value))  + Non-recoverable Tax Amount (excludes add-on costs) |



{:.note}
**The “Balance in the Accrued Purchases account  maintained at each line level in the linked documents” is also the difference  amount between the ACP of the Invoiced Quantity and the ACP of the Received  Quantity.**
: ![]({{site.pp_baseurl}}/img/lens.gif)[Balancing  the Accrued Purchases Account where the Invoiced Quantity of a Line Item  is Equal to the Received Quantity]({{site.pp_baseurl}}/purc-proc/pis/create-pi/create-new-pi/balancing_the_acp_account_where_inv_qty_equals_rec_qty_pur.html)


**Invoicing Inventoried Line Items (negative amount)  Retrieved from a Purchase Order or Purchase Receipt**


|  | Account | Debit/Credit | Amount |
| FOB Destination | Accounts Payable | Debit | Item Amount + Recoverable Tax Amount |
| Accrued Purchases | Credit | Item Amount |
| Recoverable Tax Liability | Credit | Recoverable Tax Amount |
| Item Amount = (Quantity \* (Item Cost – Discount Value)) + Non-recoverable  Tax Amount |
| FOB Origin | Accounts Payable | Debit | Item Amount + Recoverable Tax Amount |
| Accrued Purchases | Credit | Item Amount |
| Recoverable Tax Liability | Credit | Recoverable Tax Amount |
| Item Amount = (Quantity \* (Item Cost – Discount Value)) + Non-recoverable  Tax Amount |



**Invoicing Inventoried Line Items (negative  amount):**

- Retrieved from  a purchase order where the quantity you invoice equals all of the quantities  received in purchase receipts and purchase invoices linked to the same  purchase order
- Retrieved from  a purchase receipt where the quantity you invoice equals the quantity  received in the purchase receipt



|  | Account | Debit/Credit | Amount |
| FOB Destination | Accounts Payable | Debit | Item Amount + Recoverable Tax Amount |
| Accrued Purchases | Credit | Item Amount |
| Recoverable Tax Liability | Credit | Recoverable Tax Amount |
| Accrued Purchase (Adjustment) | Debit/Credit | Balance in the Accrued Purchases account maintained at each line level  in the linked documents |
| Purchase Price Variance | Credit/Debit | Balance in the Accrued Purchases account maintained at each line level  in the linked documents |
| Item Amount = (Quantity \* (Item Cost – Discount Value)) Non-recoverable  Tax Amount |
| FOB Origin | Accounts Payable | Debit | Item Amount + Recoverable Tax Amount |
| Accrued Purchases | Credit | Item Amount |
| Recoverable Tax Liability | Credit | Recoverable Tax Amount |
| Accrued Purchase (Adjustment) | Debit/Credit | Balance in the Accrued Purchases account maintained  at each line level in the linked documents |
| Purchase Price Variance | Credit/Debit | Balance in the Accrued Purchases account maintained  at each line level in the linked documents |
| Item Amount = (Quantity \* (Item Cost – Discount Value))  + Non-recoverable Tax Amount |



{:.note}
**The “Balance in the Accrued Purchases account  maintained at each line level in the linked documents” is also the difference  amount between the ACP of the Invoiced Quantity and the ACP of the Received  Quantity.**
: ![]({{site.pp_baseurl}}/img/lens.gif)[Balancing  the Accrued Purchases Account where the Invoiced Quantity of a Line Item  is Equal to the Received Quantity]({{site.pp_baseurl}}/purc-proc/pis/create-pi/create-new-pi/balancing_the_acp_account_where_inv_qty_equals_rec_qty_pur.html)


{:.see_also}
See also
: [Paths  to the Accounts for Accounting Entries]({{site.pp_baseurl}}/misc/paths_to_the_accounts_for_accounting_entries_pur.html)
: [Accounting  Entries - Create a Purchase Invoice]({{site.pp_baseurl}}/purc-proc/pis/create-pi/create-new-pi/accounting_entries_create_a_purchase_invoice_pur.html)
