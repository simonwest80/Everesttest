---
title: The Category Profile - Accounts
---

# The Category Profile - Accounts


**Posting Account Preferences**
: Specify an account selection methodology to be used  for the Category profile. You can specify accounts without setting up  posting groups. If you prefer to use posting groups (groups of accounts),  instead of making individual account selections, that option is also available.

- **Use 
 Accounts Based Upon Hierarchy** – Select this option if you would  like the system to use inventory accounts at the location level first  (if defined) and then at the company level (accounting defaults).
- **Use 
 Posting Groups** – Select this option if you would like to use Posting  Groups to define your accounts. If you select this option, you must enter  an “Inventory Posting Group” in the **Posting****Group** field that appears when  you make this selection. 
Select a Posting Group to be associated with the category being defined.  All the Posting Groups of the type Inventory are available for selection.  This is not a mandatory field.
If no Posting Group is defined in these two profiles, the Posting Group  selected in the **Location-Category**  grid of the **Location** profile is  used.



{:.note}
The location referred to is the location of  the stock area from where or to which the items are retrieved into a sales  or purchase document.


{:.warn}
It is not recommended to select a Posting  Group in the Item category for which an Inventory control account is defined.   Doing so  would override the inventory account specified in the stock area’s location  . As a result discrepancies would occur in the financial and inventory  reports. A warning message is displayed when the user selects such a Posting  Group in a Item category. You may choose to continue, or select another  Posting Group in this field.

- **Specify 
 Accounts** – Select this option if you would like to specify the  inventory control accounts to use for this Category. Click the ![]({{site.mi_baseurl}}/img/look_up_button_mi.gif) lookup button to view the related accounts that can be defined  (see the following figure). On the **Accounts**  screen, select the **Inventory** **Control Accounts** that you would like  to define for this Category. Click **Apply**  and then click **OK** to apply your  selections.



**Accounts Screen (Category)**


If you selected “Specify Accounts”, specify the control accounts  to use for this category.


![]({{site.mi_baseurl}}/img/category_profile_ accts_tab_when_lookup_selected_ accounts_1.gif)


**Figure: Accounts (Category) screen that displays  when the Lookup button for “Specify Accounts” is clicked – Accounts 1  tab**


**Inventory Account**
: Select an account defined in the Chart of Accounts  (COA) profile with the Account Type “Inventory Control”. (This field is  only available if “Specify Accounts” is selected.)


**WIP**
: Select an account defined in the Chart of Accounts  (COA) profile with the Account Type “Inventory Control” for Work In Process  (WIP). (This field is only available if “Specify Accounts” is selected.)


**Cost of Goods (Cost Factor)**
: Select an expense account to use for the Inventory  control account for this field. (This field is only available if “Specify  Accounts” is selected.)


**Cost of Goods**
: Select an expense account to use for the Inventory  control account for this field. (This field is only available if “Specify  Accounts” is selected.)


**Expense Account**
: Select an expense account to use for the Inventory  control account for this field. (This field is only available if “Specify  Accounts” is selected.)


**Asset Account**
: Select an asset account to use for the Inventory  control account for this field. (This field is only available if “Specify  Accounts” is selected.)


**Liability Account**
: Select a liability account to use for the Inventory  control account for this field. (This field is only available if “Specify  Accounts” is selected.)


**Inventory Adjustment**
: Select an expense or liability account to use for  the Inventory control account for inventory adjustments. (This field is  only available if “Specify Accounts” is selected.)


![]({{site.mi_baseurl}}/img/category_profile_accts_tab_when_lookup_selected_ accounts_2.gif)


**Figure: Accounts (Category) screen that displays  when the Lookup button for “Specify Accounts” is clicked – Accounts 2  tab**


**Sales**
: Select a revenue account to use for the Inventory  control account for sales for this location. (This field is only available  if “Specify Accounts” is selected.)


**Sales Returns**
: Select a revenue account to use for the Inventory  control account for sales returns for this location. (This field is only  available if “Specify Accounts” is selected.)


**Sales Line Item Discounts**
: Select a revenue or expense account to use for the  Inventory control account for discounts on sales line items for this location.  (This field is only available if “Specify Accounts” is selected.)


**Gain on Purchase Returns**
: Select a revenue or expense account to use for the  Inventory control account for gains on purchase returns. (This field is  only available if “Specify Accounts” is selected.)


**Loss on Purchase Returns**
: Select a revenue or expense account to use for the  Inventory control account for losses on purchase returns. (This field  is only available if “Specify Accounts” is selected.)


**Work Order Abnormal Gain**
: Select a revenue or expense account to use for the  Inventory control account for abnormal gains on work orders. (This field  is only available if “Specify Accounts” is selected.)


**Work Order Abnormal Loss**
: Select a revenue or expense account to use for the  Inventory control account for abnormal losses on work orders. (This field  is only available if “Specify Accounts” is selected.)


{:.see_also}
See also
: [Create an Item  Category]({{site.mi_baseurl}}/item-profile-details/item-categories/setting_up_a_category.html)
: [Item Categories]({{site.mi_baseurl}}/item-profile-details/item-categories/item_categories.html)
