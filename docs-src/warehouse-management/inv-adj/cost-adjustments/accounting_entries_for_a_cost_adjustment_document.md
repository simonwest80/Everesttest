---
title: Accounting Entries for a Cost Adjustment Document
---

# Accounting Entries for a Cost Adjustment Document


The following accounting entries are created when a cost adjustment  is made:


**If the total adjustment amount on the document  is positive**


| ### Account | **Path** | **Debit/** **Credit** | ### Amount |
| Inventory Control Account | The Inventory Control Account defined in the Posting Group assigned  to the line item is considered first. If no Inventory Control Account  is defined for the item, the control account defined for the category  to which the line item belongs is used. If the Inventory Control Account  is not defined for either the item or the category, the Inventory Control  Account of the stock area’s location from where the item is assigned is  taken into consideration. The user may however override this account by  selecting another account.<br/><br/><br/>![Lens.gif]({{site.wm_baseurl}}/img/lens.gif) [Accounting  Dialog Box]({{site.acc_chm}}/accounting-flow-control-and-defaults/accounting-defaults/accounting_dialog_box_-_posting_groups.html) | Debit | The total value of the cost adjustments as displayed in the **Inventory****Adjustment** **Amount**  column of the **Cost** **Adjustment**  profile.<br/><br/><br/>![Lens.gif]({{site.wm_baseurl}}/img/lens.gif) [Calculation  of Inventory Adjustment Document]({{site.wm_baseurl}}/inv-adj/cost-adjustments/calculation_of_inventory_adjustment_amounts_cost_adj.html) |
| Inventory Adjustment Account | The Inventory Adjustment Account defined in the Posting Group assigned  to the line item is considered first. If no Inventory Adjustment Account  is defined for the item, the control account defined for the category  to which the line item belongs is used. If the Inventory Adjustment Account  is not defined for either the item or the category, the Inventory Adjustment  Account of the document’s location is taken into consideration.<br/><br/><br/>![Lens.gif]({{site.wm_baseurl}}/img/lens.gif) [Accounting  Dialog Box]({{site.acc_chm}}/accounting-flow-control-and-defaults/accounting-defaults/accounting_dialog_box_-_posting_groups.html) | Credit | The total value of the cost adjustments as displayed in the **Inventory****Adjustment** **Amount**  column of the **Cost** **Adjustment**  profile.<br/><br/><br/>![Lens.gif]({{site.wm_baseurl}}/img/lens.gif) [Calculation  of Inventory Adjustment Document]({{site.wm_baseurl}}/inv-adj/cost-adjustments/calculation_of_inventory_adjustment_amounts_cost_adj.html) |



**<font style="font-family: Verdana;" face="Verdana">If the total adjustment 
 amount on the document is negative:</font>**


| ### Account | **Path** | **Debit/** **Credit** | ### Amount |
| Inventory Control Account | The Inventory Control Account defined in the Posting Group assigned  to the line item is considered first. If no Inventory Control Account  is defined for the item, the control account defined for the category  to which the line item belongs is used. If the Inventory Control Account  is not defined for either the item or the category, the Inventory Control  Account of the stock area’s location from where the item is assigned is  taken into consideration. The user may however override this account by  selecting another account.<br/><br/><br/>![Lens.gif]({{site.wm_baseurl}}/img/lens.gif) [Accounting  Dialog Box]({{site.acc_chm}}/accounting-flow-control-and-defaults/accounting-defaults/accounting_dialog_box_-_posting_groups.html) | Credit | The total value of the cost adjustments as displayed in the **Inventory****Adjustment** **Amount**  column of the **Cost** **Adjustment**  profile.<br/><br/><br/>![Lens.gif]({{site.wm_baseurl}}/img/lens.gif) [Calculation  of Inventory Adjustment Document]({{site.wm_baseurl}}/inv-adj/cost-adjustments/calculation_of_inventory_adjustment_amounts_cost_adj.html) |
| Inventory Adjustment Account | The Inventory Adjustment Account defined in the Posting Group assigned  to the line item is considered first. If no Inventory Adjustment Account  is defined for the item, the control account defined for the category  to which the line item belongs is used. If the Inventory Adjustment Account  is not defined for either the item or the category, the Inventory Adjustment  Account of the document’s location is taken into consideration.<br/><br/><br/>![Lens.gif]({{site.wm_baseurl}}/img/lens.gif) [Accounting  Dialog Box]({{site.acc_chm}}/accounting-flow-control-and-defaults/accounting-defaults/accounting_dialog_box_-_posting_groups.html) | Debit | The total value of the cost adjustments as displayed in the **Inventory****Adjustment** **Amount**  column of the **Cost** **Adjustment**  profile.<br/><br/><br/>![Lens.gif]({{site.wm_baseurl}}/img/lens.gif) [Calculation  of Inventory Adjustment Document]({{site.wm_baseurl}}/inv-adj/cost-adjustments/calculation_of_inventory_adjustment_amounts_cost_adj.html) |



If the inventory adjustment accounts differ from line to line, amounts  are cumulated for each adjustment account.


![example.gif]({{site.wm_baseurl}}/img/example.gif) Line  1 Inventory Adjustment Account # 1 - Adjustment Amount $500


**Line 2 Inventory Adjustment Account # 1 -  Adjustment Amount ($250)**


**Line 3 Inventory Adjustment Account # 2 -  Adjustment Amount $1500**


**Total adjustment amount = $1750**


Entry made:


**Inventory Control Account - Debit $1750**


**Inventory Adjustment Account # 1 - Credit  $250**


**Inventory Adjustment Account # 2 - Credit  $1500**


{:.see_also}
See also
: [General  Journal in which Cost Adjustment entries are made]({{site.wm_baseurl}}/inv-adj/cost-adjustments/general_journal_in_which_cost_adjustment_entries_are_made.html)
