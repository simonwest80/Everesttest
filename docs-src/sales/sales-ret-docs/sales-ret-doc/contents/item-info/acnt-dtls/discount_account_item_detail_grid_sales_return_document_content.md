---
title: Discount Account
---

# Discount Account


The **Discount****Account** column displays the account  to which the discount amount is credited. If required you can select any  other discount account for the item in this line.


The discount account for the item is determined by the following rules:

- The account  defined for sales discount in the **Discount 
 Revenue** field of the **Item**  profile (path: **Inventory &gt; Items &gt;** **Options** > **Edit**  > **In New Window** > **Accounts** tab) is assigned.
- If the sales  discount account has not been defined for the item then the sales discount  account defined in the **Revenue Discount**  field of the item's **Category** profile  (path: **Inventory &gt; Categories &gt;** From the **Categories** browser,  double-click on the required record > **Category**  profile **Accounting** tab) is assigned.
- If the discount  account has not been defined for the item's **Category**  profile then the discount account specified in the **Sales 
 Discount** field of the **Accounting**  dialog box (path: **File &gt; Setup &gt; 
 Preferences &gt; Defaults &gt; Accounting &gt; Revenue Accounts**)  is assigned.



{:.note}
You cannot select any of the accounts specified in the  **Control Accounts** tab of the **Accounting**  dialog box.


{:.see_also}
See also
: [Account  Details]({{site.sp_baseurl}}/sales-ret-docs/sales-ret-doc/contents/item-info/acnt-dtls/account_details_sales_return_document_content.html)
