---
title: Accounts Related to Line Items
---

# Accounts Related to Line Items


The bottom grid has the following columns:

- Inventory Account
- Cost of Goods (Cost  Factor)
- Cost of Goods
- Expense
- Asset (for Non  Inventoried items)
- Sales
- Sales Returns
- Sales Line Item  Discounts



****Certain 
 accounts are common between Posting Groups and hence there is a conflict 
 at the transaction time regarding the Posting Group to be used. The accounts 
 common between Posting Groups are indicated below:****


| Accounts | Posting Group | Posting Group |
| Sales | Customer Posting Group | Inventory Posting Group |
| Sales Returns | Customer Posting Group | Inventory Posting Group |
| Sales Line Item Discounts | Customer Posting Group | Inventory Posting Group |
|  |  |  |
| Gain on Purchase Returns | Vendor Posting Group | Inventory Posting Group |
| Loss on Purchase Returns | Vendor Posting Group | Inventory Posting Group |



**The customer grid (in a sales transaction)and  the vendor grid (in a purchase transaction) will always display the accounts  resolved from their respective Posting Groups.**


{:.note}
**The Posting Group that is used is based  on the hierarchy (give link for hierarchy).**


**However the line items will display the  data for the common accounts based on the preference setting.(path: **File** > **Setup**  > **Preferences** > **Flow 
 Contro**l > **Documents**  > **Miscellaneous** > **Others** > **Others 
 2** tab )**


**![]({{site.sp_baseurl}}/img/lens.gif)[Flow  control preference]({{site.bp_chm}}/misc/miscellaneous_others_others_2_steps.html)**


If the preference setting is Inventory over  Customer/Vendor Posting Group:

- Sales
- Sales  Returns
- Sales  Line Item Discounts
- Gain  on Purchase Returns
- Loss  on Purchase Returns



**For each line item, all the above accounts  will be based on the Inventory Posting Group associated to the line item.**


**For the customer gird (sales transactions),  the sales, Sales returns and Sales Line item discounts will be still be  based on the Customer Posting Group, however they will have a gray background  with a legend indicating that in the transaction, the inventory Posting  Group's account will be used.**


**For the vendor grid (purchase transactions),  the Gain on Purchase Returns and Loss on Purchase Returns will still be  based on the vendor  Posting  Group, however they will have a gray background with a legend indicating  that in the transaction, the inventory Posting Group's account will be  used.**


|  | Sales account | Sales Returns account | Sales Line Item Discounts |
| Customer Posting Group | R50 | R150 | R250 |
|  |  |  |  |
| Line Item A | R100 | R200 | R300 |
| Line Item B | R600 | R200 | R800 |



**In the above example, the customer grid  will display the accounts resolved from the customer posting group itself,  but with a gray background since the preference is set to Inventory Posting  Group.**


**However the Sales, Sales Returns and Sales  Line Item Discounts for each line item will display their respective accounts.**


**And in the transaction, both the Revenue  accounts and both the sales line item discount accounts will be used.**


If the preference setting is Customer/Vendor  Posting Group over the Inventory Posting Group:


**The customer/vendor  grid  will display the accounts based on the respective customer /vendor posting  group.**


**All the line items will also display the  conflicting accounts based only on the customer/vendor Posting Group .**


|  | Sales account | Sales Returns account | Sales Line Item Discounts |
| Customer Posting Group | R50 | R150 | R250 |
|  |  |  |  |
| Line Item A | R100 | R200 | R300 |
| Line Item B | R600 | R200 | R800 |



**In the Posting Accounts Information screen  the Sales, Sales Returns and Sales Line Item Discounts for each line item  will also display R 50,R150  and  R250. They will with a gray background since the preference is set to  Customer Posting Group.**


**And in the transaction, the customer/vendor  accounts will be used, not the inventory accounts.**


{:.note}
- The Posting Group  that is used to resolve the default accounts in this screen is based on  hierarchy.
- Also, not all the  accounts get resolved from the same Posting Group. So the Sales account  can get resolved from the Posting Group 1 which is associated to the customer,  but if the Sales Return account is not defined  in  Posting Group 1,  then  it will look at the Posting Group associated with customer class to resolve  the Sales Return account.
- **&nbsp;User 
 may edit any of the accounts in the Posting Account information screen, 
 but cannot leave any cell blank (except for Asset/liability/Expense account 
 for non-inventoried items).**


You can edit the accounts in any of the enabled columns provided you  do not leave the column blank. Only account columns relevant to the document  are enabled. The edited accounts appear in bold.


{:.note}
The column **Sales 
 Line Item Discount** in this grid is enabled only for 102 WHEELS.


**[]()Precedence of accounts**


While defining the accounts in the Inventory Posting Group, **Everest**  will not validate the combination of accounts.


{:.example}
You may define COGS and EXPENSE account in  a Inventory Posting Group and associate this Posting Group to an Inventoried  item or select ASSET, COGS and EXPENSE and LIABILITY account for a Inventory  Posting Group and associate it to a Non-Inventoried item.


Hence you may define all the accounts in the Inventory Posting Group  and during a transaction time there needs to be precedence for determining  the accounts.


For Inventoried items, **Everest** always  uses COGS account in Sales transaction. Moreover, EXPENSE, ASSET, and  LIABILITY account will be disabled in Sales documents though you can view  their values.


For Non-inventoried items:


If LIABILITY account is defined in **Posting 
 Accounts Information** screen then for Sales Invoice:


| **Sales Invoice** | A/R control account | Debit |
| Expense account | Debit |
| Sales  account | Credit |
| Liability account | Credit |



{:.note}
- If LIABILITY account  is defined in **Posting Accounts Information**  screen, the ASSET account will be disabled for that particular line item.
- **Everest**  displays an error if either in purchase and sales document you blanks  out the EXPENSE account in the **Posting 
 account Information** screen even when LIABILITY account has been  defined.


If LIABILITY account is not defined in **Posting 
 Accounts Information** screen then for Sales Invoice:


| **Sales Invoice** | A/R control account | Debit |
| Sales account | Credit |



{:.note}
- ASSET/ LIABILITY  accounts appear in the **Posting Accounts 
 Information** screen only if the same has been defined in the Posting  Group at the Item profile or Item category level; else, leave these cells  blank in the Posting Account Information screen.
- If you have chosen  the **Do not accrue cost** option  in the **Item** profile, the Liability  account will be blank in the **Posting 
 Account Information** screen. You can enter the liability account  for each line item that will override the **Item**  profile and create a liability accrual.
- Resolve the EXPENSE  account in the **Posting Account Information**  screen based on the hierarchy for Inventory Posting Group.
- If you have chosen  the **Use asset account** option in  the **Item** profile, the Expense  account will be blank and the Asset account will be populated in the **Posting Accounts Information** screen.  You can add the Expense account that will override the **Item**  profile.

: ![]({{site.sp_baseurl}}/img/lens.gif)[Hierarchical  order for Inventory Posting Group]({{site.bp_chm}}/misc/hierarchical_order_for_inventory_posting_group_doc_flow_control_misc_other2_tab.html)


{:.see_also}
See also
: [Posting  Accounts Information]({{site.sp_baseurl}}/sales-docs/docs-profile/options/docs/posting_accounts_information_doc_info_common_sales_document_options.html)
: [Other  Posting Accounts Browser Information]({{site.sp_baseurl}}/misc/legends_information_posting_acc_doc_info_common_sales_doc_options.html)
