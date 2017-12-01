---
title: measure
---

# Measure


Measures are used by **Everest**  to define the number of items sold, which could either be in formats of  a single unit or multiple units.


{:.example}
Hour, inch, foot, yard, pint, quart, gallon,  bushel, ounce, pound, short ton, long ton, each, six-pack, case, dozen,  hundred etc.


In Everest, you can buy, stock, and sell inventory using different Units  of Measure.  You  can purchase an item using the purchase measures defined in the item profile.  Similarly, you can sell an item using the sales measures defined in the  item profile.


Define conversion factors to change the measure in sales or purchase  documents to a measure other than the stock measure.


The type of measure used for an item is specified when the item is created  in the **Item** profile. The purpose  of using measures is to price items in formats other than a single unit.  At the time of creating a sales or purchase document for an item, **Everest** automatically retrieves the  item in the defined measure.


{:.note}
**Everest** can handle up to 1/100000  of a decimal place.


{:.example}
Computer chips are sold at $3.50 for a quantity of 100 or at $0.035  each.


You can buy an item in one unit of measure and sell it in another unit  of measure. Prices can be set separately for each unit of measure.


{:.example}
CDs are stocked in the Each unit of measure.  They are purchased by the dozen and are sold either by the dozen or individually  (Each). You purchase two dozen CDs at $12.00 per dozen. You now have 24  each in stock. You sell one dozen CDs at $10.00 per dozen. Your stock  then decreases from 24 each to 12 each. Next you sell one CD at $1.00  each. Your stock then decreases from 12 each to 11 each. These actions  are summarized in the following table:


| Action | Purchases | Sales | Stock |
| Purchase 2 Dozen CDs | 2 Dozen CDs at $12.00 per Dozen |  | 24 Each |
| Sell 1 Dozen CDs |  | 1 Dozen CDs at $10.00 per Dozen | 12 Each (24 - 12) |
| Sell 1 CD (Each) |  | 1 CD at $1.00 per Each | 11 Each (21 - 11) |



{:.example}
If you sell an item in 100 pack increments,  at a price of $129.00 per 100, the Unit Measure would be 100 and the selling  price would be $129.00. For 2 single units from a pack of 100, **Everest**  will calculate the price as $129.00 \* 2/100 = $2.58.


{:.see_also}
See also
: [Define a Measure]({{site.mi_baseurl}}/item-profile-details/measure/setting_up_a_measure.html)
: [Purchase Measure ]({{site.mi_baseurl}}/item-profile-details/other-items-information/purchase/measure_pur.html)
: [Sales  Measure]({{site.mi_baseurl}}/item-profile-details/other-items-information/sales/sales_measure_sales_info_item_profile.html)
: [Item Profile  Details]({{site.mi_baseurl}}/item-profile-details/item_profile_details.html)
