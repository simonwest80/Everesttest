---
title: Other Information
---

# Other Information


The other user-interface related information for **Posting 
 Accounts Information** browser is as follows:

1. There will  be a **Hide Description** button which  if toggled changes to the **Show Description**  button. By default the description for all the account columns in **Accounts Related to Customers** grid and  the line item description and account columns for **Accounts 
 Related to Line Items** grid will be hidden. If the user clicks on  button the description for all the account columns in both the grids will  be displayed.
- There will  be three legends indicating the following:
- Irrelevant-  uses the < > Posting Group
- Irrelevant  to the transaction
- Overridden


1. **Legend 
 with gray background**: Depending on the flow control preference,  the background of the cells that have common accounts will have gray background.  System will display Inventory, Customer, or Vendor in the place of <>  dynamically. If the preference is set to Customer/Vendor Posting Group,  then the column data (for customer/vendor) will display the data for all  the accounts applicable to the customer/vendor Posting Group with a white  background. Else, if the preference has been set to Inventory Posting  Group, then the column data for customer/vendor will display the data  for non-conflicting accounts with a white background; i.e.



In Sales documents, the following cells will  be displayed with a white background

- Sales Payment  Discounts
- Accounts Receivable
- Customer Advances



In purchase documents, the following cells  will be displayed with a white background:

- Accounts Payable
- Vendor Advances
- Purchase Payment  Discounts
- Expense Account



The data for other rows like ‘Sales’ etc  will be the accounts from the Inventory Posting Group and hence have a  gray background indicating that it is based on the respective Inventory  Posting Group for each line item.


If the flow control preference is set to  Inventory Posting Group, then the column data for the Accounts Related  to Line Items grid will display the data for all the hard coded account-columns  with the white background.


Else, if the preference has been set to Customer/  Vendor Posting Group, then this grid will display the data only for the  non-conflicting accounts with white background; I.e.

- Inventory Account
- Cost of Goods  (Cost Factor)
- Cost of Goods
- Expense
- Asset (for  Non Inventoried items)
- Liability



The other columns like ‘Sales’ or “Gain on  Purchase Returns ‘ will display the data based on the customer/vendor  Posting Group and have a gray background, indicating that the same is  based on the respective Customer/Vendor Posting Group for the document.


| ![]({{site.pp_baseurl}}/img/lens.gif) | : [Accounts  for Conflicting Posting Groups]({{site.bp_chm}}/misc/miscellaneous_others_others_2_steps.html) |


1. **Legend with grayed 
 text**: Also, only the accounts relevant to the document transaction  will be displayed in black text, the others will be displayed in gray  text. So, if a document does not have a Gain or Loss on purchase return,  then the accounts for Gain/Loss on purchase Return will be picked from  the flow control Posting Group but displayed in gray text. And if only  one line item has a line item discount then the Sales Line Item Discount  account will get enabled only for that line item and not for the others.  Similarly the Expense, Asset, Liability account will appear in grayed  text where the line item is an inventoried item.


1. **Legend 
 with bold text**: The user can edit any of the enabled accounts,  but cannot leave it blank. The user can change any of the accounts as  mentioned above and save and close this screen. Saving this screen will  save the overriding accounts in the database. Where the user edits the  Inventory control account, then a warning message is displayed informing  the user that it could lead to a discrepancy between the financial and  inventory reports.



{:.see_also}
See also
: Posting  Accounts Information
