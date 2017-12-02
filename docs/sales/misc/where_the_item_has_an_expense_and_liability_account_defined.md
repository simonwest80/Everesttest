---
title: When the Item has an Expense and Liability Account Defined
---

# When the Item has an Expense and Liability Account Defined


The following accounting entry is created when an item that has an expense  and asset account defined is sold.


| Entry type | Account | Path | Debit/ Credit | Amount |
| None | A/R Control Account | The account selected for **Accounts**  Receivable in the **Accounting** dialog  box (path: **File** > **Setup**  > **Preferences** > **Defaults**  > **Accounting** > **Posting <br/> Group** tab)of Customer Posting Group type.<br/><br/><br/>**Posting <br/> Group** profile<br/><br/><br/>[Hierarchical  Order for Customer Posting Group]({{site.bp_chm}}/misc/hierarchical_order_for_customer_posting_group_doc_flow_control_misc_other2_tab.html) | Debit | Total value of the sale after reducing the discount |
| Exempt Commissionable  Revenue or<br/><br/><br/>Exempt Non-commissionable Revenue or<br/><br/><br/>Taxable Commissionable  Revenue or<br/><br/><br/>Taxable Non-commissionable Revenue | Sales Discount (Products/Services) | The account selected for **Sales****Discounts** in the **Accounting**  dialog box (path: **File** > **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **Posting Group** tab) of Customer  or Inventory Posting Group types depending on the Flow Control preference  (path: **File** > **Setup**  > **Preferences** > **Flow <br/> Control** > **Documents**  > **Miscellaneous** tab > **Others** tab > **Others <br/> 2** tab)<br/><br/><br/>![]({{site.sp_baseurl}}/img/lens.gif)[Hierarchical  Order for Inventory Posting Group type]({{site.bp_chm}}/misc/hierarchical_order_for_inventory_posting_group_doc_flow_control_misc_other2_tab.html) | Debit | The value of discount provided to the customer on the  sale |
| Exempt Commissionable  Revenue or<br/><br/><br/>Exempt Non-commissionable Revenue or<br/><br/><br/>Taxable Commissionable  Revenue or<br/><br/><br/>Taxable Non-commissionable Revenue | Sales (Products /Services) | The account selected for **Sales** in the **Accounting** dialog  box (path: **File** > **Setup**  > **Preferences** > **Defaults**  > **Accounting** > **Posting <br/> Group** tab) of Customer or Inventory Posting Group types depending  on the Flow Control preference (path: **File**  > **Setup** > **Preferences**  > **Flow Control** > **Documents**  > **Miscellaneous** tab > **Others** tab > **Others <br/> 2** tab)<br/><br/><br/>![]({{site.sp_baseurl}}/img/lens.gif)[Hierarchical  Order for Inventory Posting Group type]({{site.bp_chm}}/misc/hierarchical_order_for_inventory_posting_group_doc_flow_control_misc_other2_tab.html) | Credit | The total value of the sale excluding the amount of  tax |
| Sales Tax | Sales Tax Payable | The account selected for the **Tax <br/> Account Code** in the **Tax Components**  profile (path: **File** > **Setup** > **Accounting**  > **Taxes** > **Tax****Components** > **Options**  > **Edit** > **In****New** **Window**  > **Sales** tab) | Credit | The value of tax payable on the sale |
| Commissionable  or Non - commissionable | Cost of Goods Sold (hiked by factor if factoring used) | The account selected for **Cost <br/> of Goods Sold** in the **Accounting**  dialog box (path: **File** > **Setup** > **Preferences**  > **Defaults** > **Accounting** > **Posting Group** tab)  of Inventory Posting Group type.<br/><br/><br/>![]({{site.sp_baseurl}}/img/lens.gif)[Hierarchical  Order for Inventory Posting Group type]({{site.bp_chm}}/misc/hierarchical_order_for_inventory_posting_group_doc_flow_control_misc_other2_tab.html) | Debit | The total cost of the goods sold |
| None | Cost of Goods Sold Other (for factored costs) (the nominal  amount by which COGS has been hiked to adjust for factoring)<br/><br/><br/>![]({{site.sp_baseurl}}/img/lens.gif) [Factored  Cost]({{site.mi_chm}}/item-profile-details/item-costing/factored_cost_item_costing.html) | The account selected for **Cost <br/> of Goods Sold** in the **Accounting**  dialog box (path: **File** > **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **P****osting <br/> Group** tab) of Inventory Posting Group type.<br/><br/><br/>![]({{site.sp_baseurl}}/img/lens.gif)[Hierarchical  Order for Inventory Posting Group type]({{site.bp_chm}}/misc/hierarchical_order_for_inventory_posting_group_doc_flow_control_misc_other2_tab.html) | Credit | The factored cost |
| None | Expense Account | The account selected for **Expense** in the **Item** profile (path:  **Inventory &gt; Items &gt;** **Options** > **Edit**  > **In New Window** > **Accounts** tab) | Debit | The cost of the item |
| **None** | Liability Account | The account selected for **Liability** in the **Item** profile (path:  **Inventory &gt; Items &gt;** **Options** > **Edit**  > **In New Window** > **Accounts** tab) | Credit | The cost of the item |



{:.note}
All accounts other than the asset account default to  the accounts selected in the **Accounting** dialog box.


![]({{site.sp_baseurl}}/img/lens.gif) [Accounting  Dialog Box]({{site.acc_chm}}/accounting-flow-control-and-defaults/accounting-defaults/accounting_defaults.html)


{:.see_also}
See also
: [Accounting  Information - Items]({{site.mi_chm}}/item-profile-details/accounting-information/accounting_information_items.html)
: [Accounting  Entry - Non-inventoried Items]({{site.sp_baseurl}}/sales-docs/sis/create-si/create-new-si/accnt-entries/accounting_entry_for_non_inventoried_items.html)
: [Default  Accounts for Sales Transactions]({{site.sp_baseurl}}/misc/default_accounts_for_sales_transactions.html)
