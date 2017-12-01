---
title: Posting Accounts Information
---

# Posting Accounts Information


This option brings up the **Posting Accounts 
 Information** window that constitutes the following two grids:

- [Accounts  Related to Vendor]({{site.sp_baseurl}}/misc/accounts_related_to_vendors.html)
- [Accounts  Related to Line Items]({{site.sp_baseurl}}/misc/accounts_related_to_line_items_posting_acc_info_purchase.html)



Use this option to view all the accounts tagged to the vendor or any  of the line items in a document. You can edit the accounts in any of the  enabled columns provided you do not leave the column blank.


The only exception to this is as follows:

- Where the asset  and liability accounts have not been defined in the Posting Group for  the item or item category, these cells for the line item will be blank
- In case of  non inventoried line items, the Expense account will be resolved based  on the hierarchy. Where no liability account is available in the Posting  Account Information screen, then the user may blank out the Expense account  for the non-inventoried line item and save the document.



The edited accounts appear in bold. You can edit an account either from  the **Items Detail** Grid in a document  or from the **Posting Accounts Information**  browser. The accounts edited in any of the above windows reflect this  revision in the other window.


**Hide/Show Description button**
: Use the **Hide/Show 
 Description** toggle button to hide or display the description of  line items and account columns in both the grids of the **Posting 
 Accounts Information** window.


{:.note}
For an inventoried line item in the Purchase transaction:

- **Everest**  will always use COGS account
- Asset/Expense/Liability  account is always disabled.



For a non-inventoried line item in the Purchase transaction:

- **Everest**  will always disables COGS account
- Asset/Expense/Liability  account is used based on the precedence of accounts.



![]({{site.sp_baseurl}}/img/lens.gif)[Precedence  of accounts]({{site.sp_baseurl}}/misc/accounts_related_to_line_items_posting_acc_info_purchase.html#precedence_vendor)


{:.see_also}
See also
: [Other  Posting Accounts Browser Information]({{site.sp_baseurl}}/misc/legends_information_posting_acc_doc_info_common_sales_doc_options.html)
