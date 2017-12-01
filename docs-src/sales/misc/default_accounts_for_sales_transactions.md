---
title: Default accounts for sales transactions
---

# Default accounts for sales transactions


While creating a company **Everest**  prompts you to automatically set default accounts for the company. If  you opt to do it manually go to **Posting 
 Group** profile.


Default accounts for sales transactions


| Accounts | Posting Group |
| A/R Control Account | Customer Posting Group |
| Sales<br/><br/><br/>Sales Discounts<br/><br/><br/>Sales Line Item Discounts | Customer Posting Group or Inventory Posting Group based on the flow  control preference (path: **File**  > **Setup** > **Preference**  > **Flow Control** > **Documents**  > **Miscellaneous** > **Others** > **Others <br/> 2** tab) |
| COGS Account | Inventory Posting Group (used for an inventoried item) |
| Inventory Control Account | Inventory Posting Group |
| Customer Advances for initial documents | First payment will use the Customer Posting Group based on hierarchy  . Subsequent payments also use the customer advances account used for  the first payment. |
| Customer Advances for final documents | If customer advance is applied, the account used for the corresponding  initial document is considered.<br/><br/><br/>If customer advances are not applied and payment is received on a Sales  Invoice from the Receipt dialog box or the Receipt Journal, the relevant  A/R control account is used. Once an A/R account has been used in a sales  document, all subsequent receipts for the same document will refer to  the same A/R control account. |



{:.see_also}
See also
: [Defaults  Accounts for Purchase Transactions]({{site.pp_chm}}/misc/default_accounts_for_purchase_transactions.html)
