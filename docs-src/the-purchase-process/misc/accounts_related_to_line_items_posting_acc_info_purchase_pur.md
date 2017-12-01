---
title: Accounts Related to Line Items
---

# Accounts Related to Line Items


The bottom grid has the following columns:

- Inventory Account
- Cost of Goods
- Expense
- Asset (for Non  Inventoried items)
- Liability
- Gain on Purchase  Returns
- Loss on Purchase  Returns



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


**![]({{site.pp_baseurl}}/img/lens.gif)[Flow  control preference]({{site.bp_chm}}/misc/miscellaneous_others_others_2_steps.html)**


****If the preference 
 setting is Inventory over Customer/Vendor Posting Group:****

- Gain  on Purchase Returns
- Loss  on Purchase Returns



**For each line item, all the above accounts  will be based on the Inventory Posting Group associated to the line item.**


**For the vendor grid (purchase transactions),  the Gain on Purchase Returns and Loss on Purchase Returns will still be  based on the vendor  Posting  Group, however they will have a gray background with a legend indicating  that in the transaction, the inventory Posting Group’s account will be  used.**


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


You can edit the accounts in any of the enabled columns provided you  do not leave the column blank. Only account columns relevant to the document  are enabled. The edited accounts appear in bold.


[]()Precedence of accounts


While defining the accounts in the Inventory Posting Group, **Everest**  will not validate the combination of accounts.


{:.example}
You may define COGS and EXPENSE account in  a Inventory Posting Group and associate this Posting Group to an Inventoried  item or select ASSET, COGS and EXPENSE and LIABILITY account for a Inventory  Posting Group and associate it to a Non-Inventoried item.


Therefore, you may define all the accounts in the Inventory Posting  Group and during a transaction there needs to be precedence for determining  the accounts.


For Inventoried items, **Everest** always  uses COGS account in Sales transaction. Moreover, EXPENSE, ASSET, and  LIABILITY account will be disabled in Sales documents though you can view  their values.


For Non-inventoried items:


If LIABILITY account is defined in **Posting 
 Accounts Information** screen then for Purchase Invoice:


| **Purchase Invoice** | Expense account | Debit |
| A/P control account | Credit |



{:.note}
**Everest** displays an error if  you blanks out the EXPENSE account in the **Posting account Information** screen, even when LIABILITY account  has been defined.


If LIABILITY account is not defined in **Posting 
 Accounts Information** screen then for Purchase Invoice:


| **Purchase Invoice** | Asset account | Debit |
| A/P control account | Credit |



{:.note}
- If Asset account  is not defined in **Posting Accounts Information**  screen, use Expense account as Debit entry.
- **Everest**  displays an error if both the EXPENSE account and ASSET account in the  **Posting account Information** screen  are blank, when LIABILITY account is not defined.


{:.see_also}
See also
: [Posting  Accounts Information]({{site.pp_baseurl}}/purc-proc/doc-profile/doc-options/ex-doc-details/posting_accounts_information_purchase.html)
