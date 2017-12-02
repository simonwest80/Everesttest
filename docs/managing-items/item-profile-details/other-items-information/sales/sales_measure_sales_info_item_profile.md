---
title: Sales Measure
---

# Sales Measure


Sales measures identify the selling quantity of items, which could either  be in formats of a single unit or a number of units.


{:.example}
Hour, inch, foot, yard, pint, quart, gallon,  bushel, ounce, pound, short ton, long ton, each, six-pack, case, dozen,  hundred.


An item, whose sales measure comprises more than one unit, can also  be sold as individual units.


When creating a sales or purchase document for an item, **Everest**  automatically retrieves the item into the document using the sales or  purchase measure defined for the item.


{:.note}
**Everest** can handle up to 1/100000  of a decimal place.


{:.example}
Computer chips that sell at $3.50 for a quantity of 100 or $0.035 each.


**Everest** calculates the total  cost or price of an item in a purchase or sales order by multiplying the  number in the quantity column by the price and dividing that number by  the Unit Measure.


{:.example}
If you sell an item in 100 pack increments,  at a price of $129.00 per 100 the Unit measure would be 100 &  the selling price would be $129.00. If you sell 2 single units from a  100 pack, **Everest** calculates the  price as (129/100) \* 2 = $2.58.


{:.see_also}
See also
: [Measures]({{site.mi_baseurl}}/item-profile-details/measure/measure.html)
: [Other  Sales Information]({{site.mi_baseurl}}/item-profile-details/other-items-information/sales/other_sales_information_item_profile.html)
