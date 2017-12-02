---
title: Accounting Entries for an Add Quantity Document
---

# Accounting Entries for an Add Quantity Document


The following accounting entries are created when an add quantity document  is created:


| ### Account | **Path** | **Debit/** **Credit** | ### Amount |
| Inventory Control Account | The Inventory Control Account defined in the Posting  Group assigned to the line item is considered first. If no Inventory Control  Account is defined for the item, the control account defined for the category  to which the line item belongs is used. If the Inventory Control Account  is not defined for either the item or the category, the Inventory Control  Account of the stock area’s location from where the item is assigned is  taken into consideration. The user may however override this account by  selecting another account.<br/><br/><br/>![Lens.gif]({{site.wm_baseurl}}/img/lens.gif) [Accounting  Dialog Box]({{site.acc_chm}}/accounting-flow-control-and-defaults/accounting-defaults/accounting_dialog_box_-_posting_groups.html) | Debit | The total value of the quantity added as displayed in  the **Inventory** **Adjustment****Amount** column of the **Quantity <br/> Adjustments** profile<br/><br/><br/>![Lens.gif]({{site.wm_baseurl}}/img/lens.gif) [Calculation  of Inventory Adjustment Document]({{site.wm_baseurl}}/inv-adj/qty-adj/calculation_of_inventory_adjustment_amounts_qty_adj.html) |
| Inventory Adjustment Account | The Inventory Adjustment Account defined in the Posting  Group assigned to the line item is considered first. If no Inventory Adjustment  Account is defined for the item, the control account defined for the category  to which the line item belongs is used. If the Inventory Adjustment Account  is not defined for either the item or the category, the Inventory Adjustment  Account of the document’s location is taken into consideration.<br/><br/><br/>![Lens.gif]({{site.wm_baseurl}}/img/lens.gif) [Accounting  Dialog Box]({{site.acc_chm}}/accounting-flow-control-and-defaults/accounting-defaults/accounting_dialog_box_-_posting_groups.html) | Credit<br/><br/><br/>. | The total value of the quantity added as displayed in  the **Inventory** **Adjustment****Amount** column of the **Quantity <br/> Adjustments** profile<br/><br/><br/>![Lens.gif]({{site.wm_baseurl}}/img/lens.gif) [Calculation  of Inventory Adjustment Document]({{site.wm_baseurl}}/inv-adj/qty-adj/calculation_of_inventory_adjustment_amounts_qty_adj.html) |



If the Inventory Adjustment accounts selected differ from line to item,  then amounts are cumulated for each adjustment account.


![example.gif]({{site.wm_baseurl}}/img/example.gif) Line  1: Inventory Adjustment Account # 1 - Adjustment Amount $500


Line 2: Inventory Adjustment Account # 2  - Adjustment Amount $500


Line 3: Inventory Adjustment Account # 2  - Adjustment Amount $1000


Total adjustment amount = $2000


Entry made:


Inventory Control Account  - Debit $2000


Inventory Adjustment Account # 1 - Debit  $500


Inventory Adjustment Account # 2 - Debit  $1500


{:.see_also}
See also
: [General  Journal in which entries for Add Quantity documents are made]({{site.wm_baseurl}}/inv-adj/qty-adj/general_journal_in_which_entries_for_add_quantity_documents_are_made.html)
: [Back  End Processes - Add Quantity]({{site.wm_baseurl}}/misc/back_end_processes_add_quantity.html)
