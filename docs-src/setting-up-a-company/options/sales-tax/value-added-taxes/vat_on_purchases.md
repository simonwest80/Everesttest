---
title: VAT on Purchases
---

# VAT on Purchases


When an item is added into a purchase document, the item's tax code  for purchase (if any) comes up in the line item.


The amount of tax recoverable for the VAT tax component in the tax code  is calculated and debited to the account specified in the profile. If  VAT is partially recoverable, the Inventory Control account is debited  for the amount of unrecoverable tax paid on purchase.


**Accounting Entries**


| Account | Path | Debit/Credit | Amount |
| Inventory Control | Account specified for Inventory Control in the **Accounting** dialog box (path: **File**  > **Setup** > **Preferences**  > **Defaults** > **Accounting** > **Accounts** tab).<br/><br/><br/>| ![]({{site.sc_baseurl}}/img/lens.gif) | [Determining  Inventory Control Account for Sales Documents]({{site.sp_chm}}/misc/determining_inventory_control_account_for_sales_documents.html)<br/><br/><br/>[Determining  Inventory Control Account for Purchase Documents]({{site.pp_chm}}/misc/determining_inventory_control_account_for_purchase_documents.html) | | Debit | The cost of the item.<br/><br/><br/>The unrecoverable tax amount. |
| Account to be debited with VAT | Account specified in the **Tax <br/> Account Code** field in the **Tax <br/> Components** profile (path: **File**  > **Setup** > **Accounting**  > **Taxes** > **Tax <br/> Components** > **Purchase** tab). | Debit | VAT amount |
| Accounts Payable A/C | Account specified for Accounts Payable in  the **Accounting** dialog box (path:  **File** > **Setup**  > **Preferences** > **Defaults**  > **Accounting** > **Accounts** tab). | Credit |  |



{:.note}
For purchase returns, the accounting entry is reversed.


{:.see_also}
See also
: [The  **Tax Components** Profile - Purchase  Tab]({{site.sc_baseurl}}/misc/the_tax_components_profile_purchase_tab.html)
: [VAT Process]({{site.sc_baseurl}}/options/sales-tax/value-added-taxes/vat_process.html)
