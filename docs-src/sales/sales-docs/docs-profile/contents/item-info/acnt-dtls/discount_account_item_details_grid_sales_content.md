---
title: Discount Account
---

# Discount Account


The **Discount Account** column  displays the account to which the discount amount is debited. The discount  account for the item is determined by the following rules:

- The account defined  for sales discount in the **Discount Revenue**  field of the **Item** profile (path:  **Inventory &gt; Items &gt;** **Options** > **Edit**  > **In New Window** > **Accounts** tab) is assigned.
- If it is not defined  for the item, the sales discount account defined in the **Revenue 
 Discount** field of the item's **Category**  profile (path: **Inventory &gt; Categories 
 &gt; Options &gt; Edit &gt; In New Window &gt; Accounting** tab)  is assigned.

: ![]({{site.sp_baseurl}}/img/lens.gif) [Item  Category]({{site.mi_chm}}/item-profile-details/item-categories/item_categories.html)

- If it is not defined  in the item's **Category** profile,  the sales discount account specified in the **Sales 
 Discount** field of the **Accounting** dialog box (path: **File &gt; Setup 
 &gt; Preferences &gt; Defaults &gt; Accounting &gt; Revenue Accounts**)  is assigned



If the discount account selected in the **Accounting**  dialog box (path: **File** > **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **Revenue Accounts** tab) is  the same as the revenue account, the revenue is calculated after deducting  the discount amount. If the revenue account is different from the discount  account, the revenue is stated at the gross amount and the discount (sales)  account displays the discount amounts.


{:.note}
You can select any other discount account of type revenue  for the specified item in this line. You cannot, however, select any of  the accounts specified in the **Control 
 Accounts** tab of the **Accounting**  dialog box.


{:.see_also}
See also
: [Account  Details]({{site.sp_baseurl}}/sales-docs/docs-profile/contents/item-info/acnt-dtls/account_details_item_details_grid_sales_process_content.html)
