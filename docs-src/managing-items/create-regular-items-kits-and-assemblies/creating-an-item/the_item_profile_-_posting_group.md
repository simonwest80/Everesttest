---
title: The Item Profile - Accounts
---

# The Item Profile - Accounts


Use the **Item** profile  – **Accounts** tab to define specific  accounting information for this item. It is not necessary to define accounts  at the Item profile level. They can be defined for Item Categories, Locations,  or company defaults. You can quickly make account changes for groups of  items, such as all items in a particular category, if you make the changes  at the Item Category level instead of the Item profile level.


Accounting Information


**Posting Account Preferences**
: Specify an account selection methodology to be used  for the Item profile. You can specify accounts without setting up posting  groups. If you prefer to use posting groups (groups of accounts), instead  of making individual account selections, that option is also available.

- **Use 
 Accounts Based Upon Hierarchy** – Select this option if you would  like the system to use inventory accounts at the location level first  (if defined) and then at the company level (accounting defaults).
- **Use 
 Posting Groups** – Select this option if you would like to use Posting  Groups to define your accounts. If you select this option, you must enter  an “Inventory Posting Group” in the **Posting****Group** field that appears when  you make this selection. 
By default the Posting Group assigned to the category to which the  item belongs is associated with the item. You can change the Posting Group  in the **Item** profile.
You can define a Posting Group in the **Item**  profile as well as the **Category**  profile.
For existing items, this field is blank, indicating that the Posting  Group for the category to which the item belongs would be considered.  To override the Posting Group of the category, select a Posting Group  in this field.
The selection of the Posting Group for an item is based on the following  hierarchy:
The Posting Group defined in the **Item**  profile is the first preference, followed by the Posting Group specified  in the **Category** profile. If no  Posting Group is defined in these two profiles, the Posting Group selected  in the **Location-Category** grid  of the **Location** profile is used.  If the **Location-category** grid  does not contain the category to which this item belongs, the Inventory  Posting Group for the location of the stock area is considered. In case  the **Inventory Posting Group Type**  field for the location of the stock area is also left blank, the Posting  Group defined in the company defaults is used.



{:.warn}
: It is not recommended to select a Posting Group  for which an Inventory control account is defined. This account would  override the account specified in the location of the document’s location/sub-location.  As a result discrepancies would occur in the financial and inventory reports.  You may choose to continue, or select another Posting Group in this field.

- **Specify 
 Accounts** – Select this option if you would like to specify the  inventory control accounts to use for this Item. Click the ![]({{site.mi_baseurl}}/img/look_up_button_mi.gif) lookup button to view the related accounts that can be defined  (see the links below of the Accounts 1 and Accounts 2 tabs). On the Accounts  screen, select the Inventory Control Accounts that you would like to define  for this Category. Click **Apply**  and then click **OK** to apply your  selections.**Accounts Screen (Item)**
If you selected “Specify Accounts”, specify the control accounts to  use for this item. Click the links below for additional information on  the Accounts 1 and Accounts 2 tabs:

: ![]({{site.mi_baseurl}}/img/lens.gif) [Accounts  Screen (Item) - Accounts 1 Tab]({{site.mi_baseurl}}/misc/accounts_screen_item_accounts1_item_profile_accts_mi.html)
: ![]({{site.mi_baseurl}}/img/lens.gif) [Accounts  Screen (Item) - Accounts 2 Tab]({{site.mi_baseurl}}/misc/accounts_screen_item_accounts2_item_profile_accts_mi.html)


Accounting behavior for non-inventoried items


This section displays only for **Non-inventoried 
 items**. Use the **Accounting behavior 
 for non-inventoried items** section of the **Item**  profile – **Accounts** tab to specify  how costs should be considered on sales and purchase documents for non-inventoried  items. You can indicate whether costs for the non-inventoried items should  be accrued when a non-inventoried item is sold. If you choose not to accrue  costs, cost is not considered and the entire sale price displays as profit  in the reports. If you choose to accrue costs, the profits show as the  sales price minus the cost in the reports.


Sales documents


**Do not accrue cost**
: Select this option if you do not want to show costs  on your reports when the non-inventoried item is sold. Because the entire  sale price shows as profit, any commissions may not be shown appropriately.  The system will not create an accrual accounting transaction for the Non-inventoried  item.
: If you select the **Do 
 not accrue cost** option, the Liability account will be blank in  the **Posting Accounts Information**  screen. You can enter the Liability account for each line item that will  override the **Item** profile and  create a Liability accrual. (Path to **Posting 
 Accounts Information** screen: sales document profile > **Options** > **Document**  > **Posting Accounts Information**  or press **Ctrl+J**.)


![]({{site.mi_baseurl}}/img/lens.gif)[Posting  Accounts Information]({{site.sp_chm}}/sales-docs/docs-profile/options/docs/posting_accounts_information_doc_info_common_sales_document_options.html)


**Accrue cost using liability and expenses accounts**
: Select this option if you want costs to be considered  when the non-inventoried item is sold. The system will go through the  posting account preferences to retrieve the appropriate Liability and  Expense accounts to use in the accrual accounting transaction when the  Non-inventoried item is sold. The Expense account is debited and the Liability  account is credited for the cost of the non-inventoried item. Because  item costs are considered, profit and commissions will be calculated accordingly.  These costs will also be reflected in your reports.


{:.example}
Shipping is often setup as a non-inventoried  item. You can accrue cost each time the shipping product is sold. This  allows you to compare accrued cost for a period to the actual cost based  on the bill from your shipping carrier. After the comparison is made,  you must create a general journal entry to reverse the accrual for the  period. Cost used for each invoice can be based on Last cost or “Cost  % of Sell Price” which is configured on the Sales tab of the Item profile.


![]({{site.mi_baseurl}}/img/lens.gif)[Hierarchical  Order for Inventory Posting Group]({{site.bp_chm}}/misc/hierarchical_order_for_inventory_posting_group_doc_flow_control_misc_other2_tab.html)


{:.note}
: If a non-inventoried item does not have a liability  account defined, all costs – last, average, and actual – except user-defined  cost are displayed as zero in the **Pricing 
 Analysis browser**.


![]({{site.mi_baseurl}}/img/lens.gif)[Pricing  Analysis browser]({{site.sp_chm}}/sales-docs/sqs/sq-proc/pricing-analysis/the_pricing_analysis_browser.html)


Purchase documents


**Use expense account**
: Select this option if you want the system go through  the posting account preferences to retrieve the appropriate expense account  to use in the purchase accounting transaction to expense the non-inventoried  item.


{:.example}
This option can be useful for making routine  purchases for expenses like Office Supplies. Instead of manually creating  a purchase journal, you can simply create a purchase document with the  non-inventoried item for the value of the expense.


![]({{site.mi_baseurl}}/img/lens.gif)[Hierarchical  Order for Inventory Posting Group]({{site.bp_chm}}/misc/hierarchical_order_for_inventory_posting_group_doc_flow_control_misc_other2_tab.html)


**Use asset account**
: Select this option if you want the system to retrieve  the appropriate asset account to use in the purchase accounting transaction  to capitalize the non-inventoried item. You can add the Expense account  in the **Posting Accounts Information**  screen that will override the Item profile. (Path to **Posting 
 Accounts Information** screen: purchase document profile > **Options** > **Document**  > **Posting Accounts Information**  or press **Ctrl+J**.)


{:.example}
This option is useful if you are making a  capital purchase that you want to show up on the balance sheet as an asset.


![]({{site.mi_baseurl}}/img/lens.gif)[Posting  Accounts Information]({{site.sp_chm}}/sales-docs/docs-profile/options/docs/posting_accounts_information_doc_info_common_sales_document_options.html)


{:.see_also}
See also
: [The  Item Profile]({{site.mi_baseurl}}/create-regular-items-kits-and-assemblies/creating-an-item/the_item_profile_mi.html)
