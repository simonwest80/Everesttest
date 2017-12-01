---
title: Accounting Entries - Credit Memo
---

# Accounting Entries - Credit Memo


The accounting entry created when items are returned by customers depends  on the inventory type:

- [Accounting  entry when inventoried items are returned]({{site.sp_chm}}/sales-ret-docs/cms/create-cm/create-new-cm/accnt-entries/accounting_entry_for_inventoried_items_cm.html)
- [Accounting  entry when non-inventoried items are returned]({{site.sp_chm}}/sales-ret-docs/cms/create-cm/create-new-cm/accnt-entries/accounting_entry_for_non_inventoried_items_cm.html)



**Accounting Entries - Line Items on Documents  Associated to Different Accounts**


A Sales Invoice or Credit Memo may consist of more than one line item  with different accounts to be debited for cost of goods sold or taxes.  A transaction entry is generated for each account by accumulating the  amounts for each account.


At the document level you can identify the location or sub-location  to which the income or expense account pertains to in the **Loc/Sub-Loc** column of the items details grid.


![]({{site.acc_baseurl}}/img/lens.gif) [Loc/Sub-Loc  Column - Item Details Grid]({{site.sp_chm}}/sales-ret-docs/sales-ret-doc/contents/item-info/acnt-dtls/department_item_detail_grid_sales_return_document_content.html)


Since expense and income accounts can be accounted for each location/sub-location  separately, the amounts for such type of accounts are accumulated for  each account and location combination.


If job codes are assigned to the line item, then amounts are accumulated  for each account, location/sub-location and job code combination separately.


Click here for an [example]({{site.acc_baseurl}}/misc/example_accounting_entries_sales_invoice.html).


{:.see_also}
See also
: [Accounting  Entries - Sales Invoices]({{site.acc_baseurl}}/sales/sales-through-documents/system-sales-journals/accounting_entries_syssalejrnl.html)
: [Back  End Processes]({{site.acc_baseurl}}/sales/sales-through-documents/system-sales-journals/backend_processes_syssalejrnl.html)
: [Accounting  Entries After Trial Balance](utility.chm::/accounting_entries_customer_invoices_post_trial_balance_utility_content.htm)
