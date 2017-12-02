---
title: Expense Account
---

# Expense Account


The **Expense** **Account**  column displays the account to which the Cost of Goods sold/expense/asset  for the item returned are credited. When the customer returns inventoried  items, the inventory control account is debited and the cost of goods  sold account is credited.


When non-inventoried items are returned, the expense/asset account where  the item has been credited is debited.


**Inventoried Items**


When inventoried items are selected, the Cost of Goods Sold Account  is determined by the following rules:

- The account  defined for cost of goods sold in the **** Cost of goods sold/expense field of the **Item**'s  profile (path: **Inventory &gt; Items &gt;** **Options** > **Edit**  > **In New Window** > **Accounts** tab) is displayed.
- If the cost  of goods sold account has not been defined for the item, then the cost  of goods sold account assigned in the **COGS/Expense** field of the item's **Category**  profile (path: **Inventory &gt; Categories 
 &gt;** **Options** > **Edit** > **In 
 New Window** > **Accounting**  tab) is displayed.
- If the cost  of goods sold account has not been defined for the item's **Category**  profile, then the cost of goods sold account specified in the **Cost 
 of goods sold** field of the **A**ccounting  dialog box (path: **File &gt; Setup &gt; 
 Preferences &gt; Defaults &gt; Accounting &gt; Posting Group** tab)  is displayed.

: ![]({{site.sp_baseurl}}/img/lens.gif) [Items  - Category]({{site.mi_chm}}/item-profile-details/item-categories/item_categories.html)
: [Defaults  - Accounting]({{site.acc_chm}}/accounting-structure-in-everest/control-default-accounts/default_accounts.html)


Non-inventoried Items


When an asset account has been selected for a non-inventoried item in  the **Item**'s profile (path: **Inventory &gt; Items &gt; Options** >  **Edit** > **In 
 New Window** > **Accounts**  tab), the asset account is assigned to the expense account column in a  sales document. Any other expense account or asset account can be selected.


{:.see_also}
See also
: [Account  Details]({{site.sp_baseurl}}/sales-ret-docs/sales-ret-doc/contents/item-info/acnt-dtls/account_details_sales_return_document_content.html)
: [Default  Accounts in Sales Transactions]({{site.sp_baseurl}}/misc/default_accounts_for_sales_transactions.html)
