---
title: Default accounts for purchase transactions
---

# Default accounts for purchase transactions


While creating a company **Everest**  prompts you to automatically set default accounts for the company. If  you opt to do it manually go to **Posting 
 Group** profile.


Default accounts for purchase transactions


| Account | Posting Group |
| All accounts except Gain/Loss on purchase | Vendor Posting Group |
| Inventory account | Inventory Posting Group |
| Gain/Loss on purchase | Vendor Posting Group or Inventory Posting Group based on the flow control  preference (path: **File** > **Setup** > **Preference**  > **Flow Control** > **Documents**  > **Miscellaneous** > **Others** > **Others <br/> 2** tab) |
| Vendor Advances for initial documents | For the first payment, Vendor Posting Group will be based on hierarchy.  Subsequent payments for the same document will use the Vendor advances  account used for the first payment.<br/><br/><br/>![]({{site.pp_baseurl}}/img/lens.gif)[Hierarchical  Order for Vendor Posting Group]({{site.bp_chm}}/misc/hierarchical_order_for_vendor_posting_group_misc_tab.html) |
| Payments for final documents | If vendor advance is applied, the account used for the corresponding  initial document is considered.<br/><br/><br/>If vendor advances are not applied and payment is made on a purchase  invoice from the Payment dialog box or the Payment Journal, the relevant  A/P control account is used. Also, once a Account Payable control account  is used in a payment for a document, subsequent payments will use the  same Account Payable control account . User cannot change the Account  Payable control account while making part payments for the same document. |



{:.see_also}
See also
: [Default  Accounts for Sales Transactions]({{site.sp_chm}}/misc/default_accounts_for_sales_transactions.html)
