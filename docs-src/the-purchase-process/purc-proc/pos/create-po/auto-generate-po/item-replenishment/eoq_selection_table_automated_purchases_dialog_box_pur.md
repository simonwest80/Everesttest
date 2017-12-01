---
title: EOQ Selection Table - Automated Purchases - Replenishment Tab
---

# EOQ Selection Table - Automated Purchases - Replenishment Tab


| Purchase in Increments of Vendor EOQ **check box** | Do Not Exceed Planned Quantity **check <br/> box** | Result |
| Checked | Unchecked | Order will be placed for the calculated Required Quantity adjusted for  increments of the Vendor EOQ. The Vendor EOQ increments MAY exceed the  planned quantity.<br/><br/><br/>In the **Item Replenishment** browser,  **Required** quantity is displayed  in increments of Vendor EOQ. \*\* |
| Unchecked | Checked | Order will be placed for the calculated Required Quantity. The Required  Quantity will not be adjusted for Vendor EOQ.<br/><br/><br/>In the **Item Replenishment** browser,  **Required** quantity is displayed  as the calculated Required Quantity.\* |
| Unchecked | Unchecked | Order will be placed for the calculated Required Quantity. The Required  Quantity will not be adjusted for Vendor EOQ.<br/><br/><br/>In the **Item Replenishment** browser,  **Required** quantity is displayed  as calculated Required Quantity.\* |
| Checked | Checked | Order will be placed for the calculated Required Quantity adjusted for  increments of the Vendor EOQ. The Vendor EOQ increments CANNOT exceed  the planned quantity. \*\*<br/><br/><br/>In the **Item Replenishment** browser,  **Required** quantity is displayed  in increments of Vendor EOQ. |



\*Required Quantity (Calculated) = Planned Quantity – Current Supply


Current Supply = Total Stock – Open SO + Open PO


\*\*Planned Quantity = The selected replenishment quantity (Max / Reorder  Point / Min)


{:.note}
**If **Purchase 
 in Increments of Vendor EOQ** is selected, Planned Quantity is adjusted  with open sales orders and open purchase orders and is compared with increments  of the EOQ to get the required quantity. If you see a zero (0) in the  Required quantity column of the **Item 
 Replenishment** browser, the item is needed but you must make the  decision on if or how many should be purchased. This can occur when the  Vendor EOQ is higher than the calculated required quantity, increments  of Vendor EOQ are used, and the planned quantity cannot be exceeded.**


**![]({{site.pp_baseurl}}/img/lens.gif)[Item  Replenishment Browser]({{site.pp_baseurl}}/purc-proc/pos/create-po/auto-generate-po/item-replenishment/item_replenishment_browser_find_items_dialog_box.html)**


{:.example}
[EOQ  Selection Example]({{site.pp_baseurl}}/misc/eoq_selection_example_automated_pur_replenishment_tab_pur.html)
