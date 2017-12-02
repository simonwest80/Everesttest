---
title: Accounting Entries - Sales Invoice
---

# Accounting Entries - Sales Invoice


The accounting entries that are created when sales are made against  documents depend on the inventory type.

- [Accounting  entry when inventoried items are sold]({{site.sp_chm}}/sales-docs/sis/create-si/create-new-si/accnt-entries/accounting_entry_for_inventoried_items.html)
- [Accounting  entry when non-inventoried items are sold]({{site.sp_chm}}/sales-docs/sis/create-si/create-new-si/accnt-entries/accounting_entry_for_non_inventoried_items.html)



**Accounting Entries - Line Items on Documents  Associated to Different Accounts**


A Sales Invoice or Credit Memo may consist of more than one line item  with different accounts to be debited for cost of goods sold or taxes.  A transaction entry is generated for each account by accumulating the  amounts for each account.


At the document level you can identify the location or sub-location  to which the income or expense account pertains to in the **Loc/Sub-Loc** column of the items details grid.


![]({{site.acc_baseurl}}/img/lens.gif) [Loc/Sub-Loc  Column - Item Details Grid]({{site.sp_chm}}/sales-docs/docs-profile/contents/item-info/acnt-dtls/department_item_details_grid_sales_content.html)


Since expense and income accounts can be accounted for each location/sub-location  separately, the amounts for such type of accounts are accumulated for  each account and location combination.


If job codes are assigned to the line item, then amounts are accumulated  for each account, location/sub-location and job code combination separately.


Click here for an [example]({{site.acc_baseurl}}/misc/example_accounting_entries_sales_invoice.html).


{:.see_also}
See also
: [Accounting  Entries - Credit Memo]({{site.acc_baseurl}}/sales/sales-through-documents/system-sales-journals/accounting_entries_credit_memo.html)
: [Back  End Processes]({{site.acc_baseurl}}/sales/sales-through-documents/system-sales-journals/backend_processes_syssalejrnl.html)
: [Accounting  Entries After Trial Balance](utility.chm::/accounting_entries_customer_invoices_post_trial_balance_utility_content.htm)
