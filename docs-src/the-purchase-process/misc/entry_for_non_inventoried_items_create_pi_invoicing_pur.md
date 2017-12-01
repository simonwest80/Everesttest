---
title: Entry for Invoicing Non-inventoried Items
---

# Entry for Invoicing Non-inventoried Items


**Invoicing Non-inventoried Line Items (positive  amount)**


| Account | Debit/Credit | Amount |
| Accrued Purchases | Debit | Item Amount |
| Recoverable Tax Liability | Debit | Recoverable Tax Amount |
| Accounts Payable | Credit | Item Amount + Recoverable Tax Amount |
| Item Amount = (Quantity \* (Item Cost – Discount Value))  + Non-recoverable Tax Amount |



**Invoicing Non-inventoried Line Items (negative  amount)**


| Account | Debit/Credit | Amount |
| Accounts Payable | Debit | Item Amount + Recoverable Tax Amount |
| Accrued Purchases | Credit | Item Amount |
| Recoverable Tax Liability | Credit | Recoverable Tax Amount |
| Item Amount = (Quantity \* (Item Cost – Discount Value))  + Non-recoverable Tax Amount |



****Invoicing 
 Non-inventoried Line Items (positive amount):****

- Retrieved from  a purchase order where the quantity you invoice equals all of the quantities  received in purchase receipts and purchase invoices linked to the same  purchase order
- Retrieved from  a purchase receipt where the quantity you invoice equals the quantity  received in the purchase receipt



| Account | Debit/Credit | Amount |
| Accrued Purchases | Debit | Item Amount |
| Recoverable Tax Liability | Debit | Recoverable Tax Amount |
| Accounts Payable | Credit | Item Amount + Recoverable Tax Amount |
| Accrued Purchase (Adjustment) | Debit/Credit | Balance in the Accrued Purchases account maintained at each line level  in the linked documents |
| Purchase Price Variance | Credit/Debit | Balance in the Accrued Purchases account maintained  at each line level in the linked documents |
| Item Amount = (Quantity \* (Item Cost – Discount Value))  + Non-recoverable Tax Amount |



{:.note}
**The “Balance in the Accrued Purchases account  maintained at each line level in the linked documents” is also the difference  amount between the ACP of the Invoiced Quantity and the ACP of the Received  Quantity.**
: ![]({{site.pp_baseurl}}/img/lens.gif)[Balancing  the Accrued Purchases Account where the Invoiced Quantity of a Line Item  is Equal to the Received Quantity]({{site.pp_baseurl}}/purc-proc/pis/create-pi/create-new-pi/balancing_the_acp_account_where_inv_qty_equals_rec_qty_pur.html)


****Invoicing 
 Non-inventoried Line Items (negative amount):****

- Retrieved from  a purchase order where the quantity you invoice equals all of the quantities  received in purchase receipts and purchase invoices linked to the same  purchase order
- Retrieved from  a purchase receipt where the quantity you invoice equals the quantity  received in the purchase receipt



| Account | Debit/Credit | Amount |
| Accounts Payable | Debit | Item Amount + Recoverable Tax Amount |
| Accrued Purchases | Credit | Item Amount |
| Recoverable Tax Liability | Credit | Recoverable Tax Amount |
| Accrued Purchase (Adjustment) | Debit/Credit | Balance in the Accrued Purchases account maintained at each line level  in the linked documents |
| Purchase Price Variance | Credit/Debit | Balance in the Accrued Purchases account maintained  at each line level in the linked documents |
| Item Amount = (Quantity \* (Item Cost – Discount Value))  + Non-recoverable Tax Amount |



{:.note}
**The “Balance in the Accrued Purchases account  maintained at each line level in the linked documents” is also the difference  amount between the ACP of the Invoiced Quantity and the ACP of the Received  Quantity.**
: ![]({{site.pp_baseurl}}/img/lens.gif)[Balancing  the Accrued Purchases Account where the Invoiced Quantity of a Line Item  is Equal to the Received Quantity]({{site.pp_baseurl}}/purc-proc/pis/create-pi/create-new-pi/balancing_the_acp_account_where_inv_qty_equals_rec_qty_pur.html)


{:.see_also}
See also
: [Paths  to the Accounts for Accounting Entries]({{site.pp_baseurl}}/misc/paths_to_the_accounts_for_accounting_entries_pur.html)
: [Accounting  Entries - Create a Purchase Invoice]({{site.pp_baseurl}}/purc-proc/pis/create-pi/create-new-pi/accounting_entries_create_a_purchase_invoice_pur.html)
