---
title: VAT on Sales
---

# VAT on Sales


If an item against which VAT is recoverable is sold, the process remains  the same but a report calculating the amount of VAT recoverable against  each line item in sale is generated.


**Accounting Entries**


| Account | Path | Debit/Credit | <font style="color: #000000;" color="#000000">Amount</font> |
| Account Receivable | Account specified for Accounts Receivable in the **Accounting** dialog box (path: **File <br/> &gt; Setup &gt; Preferences &gt; Defaults &gt; Accounting &gt; Accounts** tab). | Debit | Document Total |
| Sales | Account specified for sales in the **Accounting**  dialog box (path: **File &gt; Setup &gt; <br/> Preferences &gt; Defaults &gt; Accounting &gt; Accounts** tab). | Credit | Sales tax amount reduced from the total document amount |
| Sales Tax Liability | Account specified in the **Tax <br/> Account Code** field in the **Tax <br/> Components** profile (path: **File <br/> &gt; Setup &gt; Accounting &gt; Taxes &gt; Tax Components &gt; Sales** tab). | Credit | Sales tax amount |



{:.see_also}
See also
: [The  **Tax Components** Profile - Sales  Tab]({{site.sc_baseurl}}/misc/the_tax_components_profile_sales_tab_.html)
: [VAT Process]({{site.sc_baseurl}}/options/sales-tax/value-added-taxes/vat_process.html)
: [Determining  Inventory Control Account for Sales Documents]({{site.sp_chm}}/misc/determining_inventory_control_account_for_sales_documents.html)
: [Determining  Inventory Control Account for Purchase Documents]({{site.pp_chm}}/misc/determining_inventory_control_account_for_purchase_documents.html)
