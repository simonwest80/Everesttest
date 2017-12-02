---
title: Accounts Related to Customers
---

# Accounts Related to Customers


This grid displays all the accounts pertaining to the Customer Posting  Group that is assigned to the customer selected in the sales or purchase  documents.


For Sales Documents the following rows are displayed:

- Sales
- Sales Returns
- Sales Line Item  Discounts
- Sales Payment Discounts
- Accounts Receivable
- Customer Advances



**Certain accounts are common between Posting  Groups and hence there is a conflict at the transaction time regarding  the Posting Group to be used. The accounts common between Posting Groups  are indicated below:**


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


**If the preference setting is Inventory over  Customer/Vendor Posting Group:**

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


**If the preference setting is Customer/Vendor  Posting Group over the Inventory Posting Group:**


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
- User  may edit any of the accounts in the Posting Account information screen,  but cannot leave any cell blank (except for Asset/liability/Expense account  for non-inventoried items).


You can edit the accounts in any of the enabled columns provided you  do not leave the column blank. Only account columns relevant to the document  are enabled. The edited accounts appear in bold.


{:.note}
The column **Sales 
 Line Item Discount** in this grid is enabled only for 102 WHEELS.


{:.see_also}
See also
: [Posting  Accounts Information]({{site.sp_baseurl}}/sales-docs/docs-profile/options/docs/posting_accounts_information_doc_info_common_sales_document_options.html)
: [Other  Posting Accounts Browser Information]({{site.sp_baseurl}}/misc/legends_information_posting_acc_doc_info_common_sales_doc_options.html)
