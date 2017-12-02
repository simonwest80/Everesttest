---
title: Expense Account
---

# Expense Account


The **Expense Account** column displays  the account to which the **Cost of Goods 
 Sold** for the item is debited.


**Inventoried Items**


When you select inventoried items, the **Cost 
 of Goods Sold** account is determined by the following rules:

- The account defined  for cost of goods sold in the **** **Cost of goods sold/expense** field of  the **Item**'s profile (path: **Inventory &gt; Items &gt; Options &gt; Edit 
 &gt; In New Window** > **Accounts**  tab) is displayed.
- If it is not defined  for the item, the cost of goods sold account assigned in the **COGS/Expense** field of the item's **Category**  profile (path: **Inventory &gt; Categories 
 &gt; Options** > **Edit**  > **In New Window** > **Accounting** tab) is displayed.

: ![]({{site.sp_baseurl}}/img/lens.gif) [Item  Category]({{site.mi_chm}}/item-profile-details/item-categories/item_categories.html)

- If it is not defined  in the item's **Category** profile,  the cost of goods sold account specified in the **Cost 
 of goods sold** field of the **Accounting** dialog box (path: **File &gt; Setup 
 &gt; Preferences &gt; Defaults &gt; Accounting &gt; Posting Group** tab)  is displayed.



Non-inventoried Items


When you select an asset account for a non-inventoried item in the **Item** profile (path: **Inventory**  > **Items** > **Options**  > **Edit** > **In 
 New Window** > **Accounts**  tab), the asset account is assigned to the **Expense****Account** column in a sales document.  You can select any other expense account or asset account.


The expense account is debited and the asset account specified in the  **Item**'s profile is credited.


When you select an expense and a liability account for a non-inventoried  item in the **Item**'s profile (path:  **Inventory** > **Items**  > **Options &gt; Edit &gt; In New Window**  > **Accounts** tab), the expense  account is assigned to the **Expense Account**  column in a sales document. The expense account is debited and the liability  account specified in the item's profile is credited.


If the item is non-inventoried and a liability account is not selected,  the expense account specified in the item's profile is displayed.


You can select any other expense account for the item in this line.


{:.note}
All accounts selected in sales documents can  be in the base currency or document currency.


{:.see_also}
See also
: [Account  Details]({{site.sp_baseurl}}/sales-docs/docs-profile/contents/item-info/acnt-dtls/account_details_item_details_grid_sales_process_content.html)
: [Default  Accounts for Sales Transactions]({{site.sp_baseurl}}/misc/default_accounts_for_sales_transactions.html)
