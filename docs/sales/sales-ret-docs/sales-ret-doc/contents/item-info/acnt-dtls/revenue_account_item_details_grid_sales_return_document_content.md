---
title: Revenue Account
---

# Revenue Account


The **Revenue****Account** column displays the account  to which the sales return value of the item is debited. If required you  can select any other revenue account for the item in this line.


The revenue account for the item is determined by the following rules:

- The account  defined for sales revenue in the **Returns**  field of the **Item** profile (path:  **Inventory &gt; Items &gt;** **Options** > **Edit**  > **In New Window** > **Accounts** tab) is automatically populated  in this column.
- If the sales  revenue account has not been defined for the item then the revenue account  specified in the **Returns** field  of the item's **Category** profile  (path: **Inventory &gt; Categories**  > **Options** > **Edit**  > **In New Window** > **Accounting** tab) is assigned.



![]({{site.sp_baseurl}}/img/lens.gif) [Category  Profile - Accounting tab](managing-items.chm::/category_profile_accounting_tab.htm)

- If the sales  revenue account has not been defined for the item's **Category**  profile, then the sales revenue account in the **Sales****returns** field specified in the  **Accounting** dialog box (path: **File &gt; Setup &gt; Preferences &gt; Defaults 
 &gt; Accounting &gt; Revenue Accounts** tab) is assigned.



{:.note}
You cannot select any of the accounts specified in the  **Control Accounts** tab of the **Accounting**  dialog box.


{:.see_also}
See also
: [Item  Profile]({{site.mi_chm}}/create-regular-items-kits-and-assemblies/creating-an-item/setting_up_an_item.html)
: [Account  Details]({{site.sp_baseurl}}/sales-ret-docs/sales-ret-doc/contents/item-info/acnt-dtls/account_details_sales_return_document_content.html)
