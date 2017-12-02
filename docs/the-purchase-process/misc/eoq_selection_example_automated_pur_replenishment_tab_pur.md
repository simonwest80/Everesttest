---
title: EOQ Selection Example
---

# EOQ Selection Example


The following example applies to parameter selections on the **Automated 
 Purchases** dialog box - **Replenishment**  tab (path: **Inventory** > **Automated Purchases** > **Item 
 Replenishment** or press **Ctrl**  + **M**).


Item D has the following values:


Planned Quantity (Maximum) = 100


Planned Quantity – Replenish Inventory To = Maximum Quantity


Total Stock = 75


Open SO = 25


Open PO = 15


Current Supply = 65


EOQ = 4


Current Supply = Total Stock – Open SO + Open PO = 75 – 25 + 15 = 65


Required Quantity (Calculated) = Planned Quantity – Current Supply =  100 – 65 = 35


For Item D, the result of selecting/deselecting **Do 
 Not Exceed Planned QTY** and **Purchase 
 in Increments of Vendor EOQ** is shown in the following table:


| Required Quantity (Calculated) | ADJUSTMENT FACTORS | Required Quantity (Adjusted) |
| Do Not Exceed Planned QTY<br/><br/><br/>check box | Purchase in Increments of Vendor EOQ check  box | EOQ<br/><br/><br/>Increments |
| 35 | Unchecked | Unchecked | N/A | 35 |
| 35 | Checked | Unchecked | N/A | 35 |
| 35 | Unchecked | Checked | 4 \* 9 | 36 |
| 35 | Checked | Checked | 4 \* 8 (Cannot exceed 35) | 32 |



If you do not purchase in increments of the Vendor EOQ, the adjustment  factors are ignored and the Required Quantity (Adjusted) is the same as  the Required Quantity (Calculated).


If you purchase in increments of the Vendor EOQ and the planned quantity  can be exceeded, nine increments of the EOQ (9\*4=36) are used to cover  the calculated required quantity of 35. The Required Quantity (Adjusted)  becomes 36.


If you purchase in increments of the Vendor EOQ but the planned quantity  cannot be exceeded, eight increments of the EOQ (8\*4=32) are used to cover  the calculated required quantity of 35 without going over the planned  quantity.  The  Required Quantity (Adjusted) becomes 32.


If the EOQ was 40 instead of 4, and you were using increments of Vendor  EOQ for purchases and the planned quantity could not be exceeded, the  Required Quantity (Adjusted) would be zero (0) since it is more than the  Required Quantity (Calculated). In this situation, you can make a decision  on how many, if any, should be purchased.


{:.see_also}
See also
: [Automated  Purchases - Replenishment tab]({{site.pp_baseurl}}/purc-proc/pos/create-po/auto-generate-po/item-replenishment/find_item_replenishment_-_replenishment_tab.html)
