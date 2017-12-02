---
title: Recoverable Tax in Purchase Invoices
---

# Recoverable Tax in Purchase Invoices


If the tax code selected in the **Tax****Code** column for a line item comprises  tax components that have purchase tax recoverable, the amount of tax that  is recoverable is displayed in the **Recoverable****Tax** column.


The amount of tax recoverable is treated as an asset and debited to  the account specified in the **Tax****Account** **Code**  field (path: **File** > **Setup**  > **Accounting** > **Taxes**  > **Tax** **Components**  > **Options** > **Edit** > **In New Window** >  **Purchase** tab) when the item is  purchased.


If the item is returned, this amount is credited to the account specified  in the **Tax** **Account****Code** field.


The amount of tax that is not recoverable is added to the value of the  item.


{:.example}
If $100 is the total purchase tax on an item  valued at $1000, out of which 80% is recoverable; $80 is **Recoverable****Tax** and $20 is **Tax**.  Value of item debited to Inventory Control Account (if item is inventoried)  or Expense/Asset accounts (if item is non-inventoried) will be $1020.


{:.see_also}
See also
: [Tax]({{site.pp_baseurl}}/purc-proc/doc-profile/contents/item-info/tax-details/tax_item_details_grid_purchase_content.html)
: [Modify  Tax/Recoverable Tax Amounts]({{site.pp_baseurl}}/misc/modify_tax_recoverable_tax_amounts_purchase_process.html)
