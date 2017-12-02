---
title: Accounting Entry for Inventoried Items
---

# Accounting Entry for Inventoried Items


The accounting entry created when an inventoried item is sold is given  below:


{:.note}
The revenue and discount accounts that are credited  and debited respectively for different entry types will be the same.


| Entry type | Account | Path | Debit/ Credit | Amount |
| None | Accounts Receivable Control Account | The account selected for **Accounts****Receivable** in the **Accounting**  dialog box (path: **File** > **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **Posting Group** tab) of Customer  Posting Group type.<br/><br/><br/>![]({{site.sp_baseurl}}/img/lens.gif)<font color="#800080" class="hcp11"> </font>**Posting <br/> Group** profile<br/><br/><br/><font color="#800080" class="hcp11">&nbsp;</font>     [Hierarchical  Order for Customer Posting Group]({{site.bp_chm}}/misc/hierarchical_order_for_customer_posting_group_doc_flow_control_misc_other2_tab.html) | Debit | Total value of the sale after reducing the discount |
| Exempt Commissionable  Revenue or<br/><br/><br/>Exempt Non-Commissionable  Revenue or<br/><br/><br/>Taxable Commissionable  Revenue or<br/><br/><br/>Taxable Non-commissionable  Revenue | Sales Discount (Products/Services) | The account selected for **Sales <br/> Discounts** in the **Accounting**  dialog box (path: **File** > **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **Posting Group** tab) of Customer  or Inventory Posting Group type depending on the Flow Control preference  (path: **File** > **Setup**  > **Preferences** > **Flow <br/> Control** > **Documents**  > **Miscellaneous** tab > **Others** tab > **Others 2** tab) | Debit | The value of discount provided to the customer on the  sale |
| Exempt Commissionable  Revenue or<br/><br/><br/>Exempt Non- commissionable  Revenue or<br/><br/><br/>Taxable Commissionable  Revenue or<br/><br/><br/>Taxable  Non-commissionable  Revenue | Sales (Products /Services) | The account selected for **Sales** in the **Accounting** dialog  box (path: **File** > **Setup**  > **Preferences** > **Defaults**  > **Accounting** > **Posting <br/> Group** tab) of Customer or Inventory Posting Group type depending  on the Flow Control preference (path: **File**  > **Setup** > **Preferences**  > **Flow Control** > **Documents**  > **Miscellaneous** tab > **Others** tab > **Others 2** tab) | Credit | The total value of the sale |
| Sales Tax | Sales Tax Payable | The account selected for the **Tax <br/> Account Code** in the **Tax Components**  profile (path: **File** > **Setup** > **Accounting**  > **Taxes** > **Tax****Components** > **Options**  > **Edit** > **In <br/> New Window** > **Sales** tab) | Credit | The value of tax payable on the sale |
| Commissionable  or Non-commissionable | Cost of Goods Sold (hiked by factor if factoring used) | The account selected for **Cost <br/> of goods sold** in the **Accounting**  dialog box (path: **File** > **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **Posting Group** tab) of Inventory  Posting Group type. | Debit | The total cost of the goods sold |
| None | Cost of Goods Sold Other (for factored costs) (the nominal  amount by which Cost of Goods Sold has been hiked to adjust for factoring)<br/><br/><br/>![]({{site.sp_baseurl}}/img/lens.gif) [Factored  Cost]({{site.mi_chm}}/item-profile-details/item-costing/factored_cost_item_costing.html) | The account selected for **Cost <br/> of Goods Sold** in the **Accounting**  dialog box (path: **File** > **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **Posting Group** tab) of Inventory  Posting Group type. | Credit | The factored cost |
| None | Inventory Control | The account selected for **Inventory****Control** in the **Accounting**  dialog box (path: **File** > **Setup** > **Preferences**  > **Defaults** > **Accounting &gt; Posting Group** tab) | Credit | The cost of the items |



{:.note}
These accounts default to the accounts defined in the  Posting Group selected in the **Accounting**  dialog box. If Posting Groups have been defined at location or for any  masters, it will resolve the accounts by deciding the Posting Group based  on hierarchy.


![]({{site.sp_baseurl}}/img/lens.gif)[Hierarchical  order for Customer Posting Group]({{site.bp_chm}}/misc/hierarchical_order_for_customer_posting_group_doc_flow_control_misc_other2_tab.html)


[Hierarchical  order for Inventory Posting Group]({{site.bp_chm}}/misc/hierarchical_order_for_inventory_posting_group_doc_flow_control_misc_other2_tab.html)


[Hierarchical  order for Vendor Posting Group]({{site.bp_chm}}/misc/hierarchical_order_for_vendor_posting_group_misc_tab.html)


![]({{site.sp_baseurl}}/img/lens.gif) [Accounting  Defaults]({{site.acc_chm}}/accounting-flow-control-and-defaults/accounting-defaults/accounting_defaults.html)


{:.see_also}
See also
: [Sales Journal]({{site.sp_baseurl}}/sales-docs/sis/create-si/create-new-si/accnt-entries/sales_journal.html)
: [Default  Accounts for Sales Transactions]({{site.sp_baseurl}}/misc/default_accounts_for_sales_transactions.html)
