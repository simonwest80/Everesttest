---
title: Accounting Entries for a Stock Transfer Document
---

# Accounting Entries for a Stock Transfer Document


The accounting entries for a stock transfer created in a general journal  are:


| ### Account | **Path** | **Debit/** **Credit** | ### Amount |
| Inventory Control Account | The Inventory Control Account defined in the Posting Group assigned  to the line item is considered first. If no Inventory Control Account  is defined for the item, the control account defined for the category  to which the line item belongs is used. If the Inventory Control Account  is not defined for either the item or the category, the Inventory Control  Account of the stock area’s location from where the item is assigned is  taken into consideration. The user may however override this account by  selecting another account.<br/><br/><br/>![Lens.gif]({{site.wm_baseurl}}/img/lens.gif) [Accounting  Dialog Box]({{site.acc_chm}}/accounting-flow-control-and-defaults/accounting-defaults/accounting_dialog_box_-_posting_groups.html) | Credit | Value of items as per the **Amount**  column of the **Stock** **Transfer**  profile |
| Inventory Control Account | The Inventory Adjustment Account defined in the Posting Group assigned  to the line item is considered first. If no Inventory Adjustment Account  is defined for the item, the control account defined for the category  to which the line item belongs is used. If the Inventory Adjustment Account  is not defined for either the item or the category, the Inventory Adjustment  Account of the document’s location is taken into consideration.<br/><br/><br/>![Lens.gif]({{site.wm_baseurl}}/img/lens.gif) [Accounting  Dialog Box]({{site.acc_chm}}/accounting-flow-control-and-defaults/accounting-defaults/accounting_dialog_box_-_posting_groups.html) | Debit<br/><br/><br/>. | Value of items as per the **Amount**  column of the [Stock Transfer  profile]({{site.wm_baseurl}}/inv-adj/stk-trans/create-stock-transfer-document/the_stock_transfers_profile.html) **.** |



{:.see_also}
See also
: [Stock  Transfer profile]({{site.wm_baseurl}}/inv-adj/stk-trans/create-stock-transfer-document/the_stock_transfers_profile.html)
