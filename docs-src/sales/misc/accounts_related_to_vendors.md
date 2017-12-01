---
title: Accounts Related to Vendors
---

# Accounts Related to Vendors


This grid displays all the accounts pertaining to the Vendor Posting  Group that is assigned to the vendor selected in the sales or purchase  documents.


For Purchase Documents the following rows are displayed:

- Accounts Payable
- Vendor Advances
- Purchase Payment  Discounts
- Gain on Purchase  Returns
- Loss on Purchase  Returns
- Expense Account



Certain accounts are common between Posting Groups and hence there is  a conflict at the transaction time regarding the Posting Group to be used.  The accounts common between Posting Groups are indicated below:


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


****If the preference 
 setting is Inventory over Customer/Vendor Posting Group:****

- Gain  on Purchase Returns
- Loss  on Purchase Returns



**For each line item, all the above accounts  will be based on the Inventory Posting Group associated to the line item.**


**For the vendor grid (purchase transactions),  the Gain on Purchase Returns and Loss on Purchase Returns will still be  based on the vendor  Posting  Group, however they will have a gray background with a legend indicating  that in the transaction, the inventory Posting Group's account will be  used.**


**If the preference setting is Customer/Vendor  Posting Group over the Inventory Posting Group**


**The vendor  grid  will display the accounts based on the respective vendor posting group.**


**All the line items will also display the  conflicting accounts based only on the vendor posting group.**


**And in the transaction, the vendor accounts  will be used, not the inventory accounts.**


{:.note}
- **The 
 Posting Group that is used to resolve the default accounts in this screen 
 is based on hierarchy**
- Also, not all the  accounts get resolved from the same Posting Group. So the A/P control  account can get resolved from the Posting Group 1 which is associated  to the vendor, but if the Vendor advances account is not defined  in  Posting Group 1,  then  it will look at the Posting Group associated with vendor class to resolve  the Vendor advances account
- **User 
 may edit any of the accounts in the Posting Account information screen, 
 but cannot leave any cell blank (except for Asset/liability/Expense account 
 for non-inventoried items)**.
- You can edit the  accounts in any of the enabled columns provided you do not leave the column  blank. Only account columns relevant to the document are enabled. The  edited accounts appear in bold.
