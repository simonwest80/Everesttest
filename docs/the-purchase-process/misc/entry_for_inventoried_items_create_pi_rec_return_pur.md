---
title: Entries for Receiving and Returning Inventoried Items
---

# Entries for Receiving and Returning Inventoried Items


**Receiving Inventoried Line Items Retrieved from  a Purchase Order or Purchase Receipt**


|  | Account | Debit/Credit | Amount |
| FOB Destination | Inventory Control | Debit | Item Amount |
| Accrued Purchases | Credit | Item Amount |
| Item Amount = (Quantity \* (Item Cost – Discount Value))  + Add-on Amount + Non-recoverable Tax Amount |
| FOB Origin | Inventory Control | Debit | Item Amount + Add-on Amount |
| Accrued Purchases | Credit | Item Amount |
| Assets/Expense | Credit | Add-on Amount |
| Item Amount = (Quantity \* (Item Cost – Discount Value))  + Non-recoverable Tax Amount (excludes add-on costs) |



{:.note}
The Add-on Amount for the item is located  in the “Add-on Amount” column of the line item. It is the “Add-on Cost”  column multiplied by the Quantity.


Returning Inventoried Line Items (negative  quantity)


|  | Account | Debit/Credit | Amount |
| FOB Destination | Accrued Purchases | Debit | Item Amount |
| Loss on Purchase Returns (if amount is positive) | Debit | Item Amount - (Quantity \* Average Cost per Purchase Measure) |
| Inventory Control | Credit | Quantity \* Average Cost per Purchase Measure |
| Gain on Purchase Returns (if amount is negative) | Credit | Item Amount - (Quantity \* Average Cost per Purchase Measure) |
| Item Amount = (Quantity \* (Item Cost – Discount Value)) + Non-recoverable  Tax Amount<br/><br/><br/>For serialized items, use actual cost instead of average cost. |
| FOB Origin | Accrued Purchases | Debit | Item Amount |
| Loss on Purchase Returns (if amount is positive) | Debit | Item Amount – (Quantity \* Average Cost per Purchase Measure) |
| Inventory Control | Credit | Quantity \* Average cost per Purchase Measure |
| Gain on Purchase Returns (if amount is negative) | Credit | Item Amount – (Quantity \* Average Cost per Purchase Measure) |
| Item Amount = (Quantity \* (Item Cost – Discount Value)) + Non-recoverable  Tax Amount<br/><br/><br/>For serialized items, use actual cost instead of average cost. |



{:.see_also}
See also
: [Paths  to the Accounts for Accounting Entries]({{site.pp_baseurl}}/misc/paths_to_the_accounts_for_accounting_entries_pur.html)
: [Accounting  Entries - Create a Purchase Invoice]({{site.pp_baseurl}}/purc-proc/pis/create-pi/create-new-pi/accounting_entries_create_a_purchase_invoice_pur.html)
