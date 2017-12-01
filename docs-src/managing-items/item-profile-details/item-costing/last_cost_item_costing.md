---
title: Last Cost
---

# Last Cost


Last cost is the last price at which the item was purchased. When you  create an item, you can enter the last cost. Subsequently, if you purchase  the item at a different price, the last cost is updated automatically.


This cost is displayed when you select the item for purchase. The last  cost is also used for computing selling price of the item where the calculation  method for the item is based on last cost.


![]({{site.mi_baseurl}}/img/lens.gif) [Percent Markup of  Cost]({{site.mi_baseurl}}/item-profile-details/item-pricing/pricing-calculations/percent_markup_on_cost.html)


The **Factored Last Cost** indicates  the last cost inflated by the factor percentage or amount.


{:.note}
The last cost of a Kit is not updated when there is a change in the  last cost of any of the items that comprise the Kit. None of the related  fields in the **Purchase** tab of  the **Item** profile are automatically  updated for kit items. The kit’s last cost has to be manually updated  to reflect the changes in the last cost of component items.


The last cost does not get updated if you select the option **Do 
 Not Update Last Cost When Receiving** (path: **File 
 &gt; Setup &gt; Preferences &gt; Workstation Settings &gt; Stock Bins&gt; 
 For Purchase**).


{:.example}
Item ABC is defined with a stock measure of  Tons and purchase measures of KG and Pounds. When the last cost for purchase  measure KG or Pounds is updated, the last cost for the stock measure will  be updated based on the conversion factor.


{:.see_also}
See also
: [Item Costing]({{site.mi_baseurl}}/item-profile-details/item-costing/item_costing.html)
