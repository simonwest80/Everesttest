---
title: Percent Markup on Cost
---

# Percent Markup on Cost


The selling price is calculated by marking up the item cost by a specified  percentage.


{:.example}
If you specify a markup of 10% on a cost of $100, the item's selling  price would be $110.


Besides the base markup percentage, you can specify different markup  percentages for each customer level in the Customer Levels Grid displayed  below the % Markup field. If you do NOT specify a markup percentage for  a level, the base markup percent is applied to all the customers in that  level. This option is used for items with frequent fluctuations in costs,  and on which it is important to keep gross margins constant.


**Item Cost Considered for Markup Calculations**


The item cost considered for calculating the selling price is either  the last cost of the item or the average cost. You must specify your preference  for the cost that has to be used in calculating the markup in the **Markup calculations cost** field of the  **Flow Control Setup** dialog box  (path: **File &gt; Setup &gt; Preferences 
 &gt; Flow Control &gt; Items &gt; Item details** tab). If the cost  of the item is factored it is the factored last cost or the factored average  cost that is considered.


![Lens.gif]({{site.mi_baseurl}}/img/lens.gif) [Item Costing]({{site.mi_baseurl}}/item-profile-details/item-costing/item_costing.html)


The last cost and average cost of an item are computed per purchase  measure. If the sales measure differs from the purchase measure per unit,  the last cost and the average cost are calculated and multiplied by the  number of units in the sales measure


{:.example}
The purchase measure of an item is a dozen  and it’s average cost is $12. If the sales measure is half dozen and the  markup is 10% on the cost, the selling price per sales measure would be  $6.60.


{:.note}
The setting defined in the **Flow 
 Control Setup** dialog box is for all items where selling price is  calculated as a percent markup on cost. You cannot calculate percent markup  on last cost for one item and percent markup on average cost for another  item.


If you want **Everest**  to consider the percentage markup price while determining  the  item’s least price on sales orders and invoices, clear the option **Customer level price to override list price 
 for price calculation** (path: **File 
 &gt; Setup &gt; Preferences &gt; Flow Control &gt; Documents &gt; Pricing/Discounts**  tab).


{:.see_also}
See also
: [Price Calculation]({{site.mi_baseurl}}/item-profile-details/item-pricing/pricing-calculations/price_calculations.html)
: [Item Pricing]({{site.mi_baseurl}}/item-profile-details/item-pricing/item_pricing.html)
: [How  is an Item's Selling Price Calculated?]({{site.mi_baseurl}}/misc/how_is_an_item_s_selling_price_calculated_.html)
: [Customer  level price to override list price for price calculation]({{site.bp_chm}}/misc/customer_level_price_to_override_list_price_for_price_calculation.html)
