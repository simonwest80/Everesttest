---
title: Price Calculations
---

# Price Calculations


**An item's selling price can be calculated by  the following means:**

- Base selling  price calculation (fixed price or percent markup on cost or percent of  invoice total).

: ![Lens.gif]({{site.mi_baseurl}}/img/lens.gif) [Fixed Price]({{site.mi_baseurl}}/item-profile-details/item-pricing/pricing-calculations/fixed_price.html)
: [%  Markup]({{site.mi_baseurl}}/item-profile-details/item-pricing/pricing-calculations/percent_markup_on_cost.html)
: [Based  on Sales Total (Non-Inventory Items Only)]({{site.mi_baseurl}}/item-profile-details/item-pricing/pricing-calculations/based_on_sales_total.html)

- Selling price  for the customer level (in the Customer Levels Grid displayed below the  **Fixed Price** field for calculating  the selling price at different customer levels).


- Selling price  at the quantity ordered (special quantity pricing scheme for the item).

: ![Lens.gif]({{site.mi_baseurl}}/img/lens.gif) [Quantity  Pricing]({{site.mi_baseurl}}/item-profile-details/item-pricing/discounts-and-special-pricing/quantity-pricing/quantity_pricing.html)
: [Quantity  Discounts]({{site.mi_baseurl}}/item-profile-details/item-pricing/discounts-and-special-pricing/quantity-discounts/quantity_discounts.html)

- Selling price  for the item in a specified period (promotional pricing).

: ![Lens.gif]({{site.mi_baseurl}}/img/lens.gif) [Promotional  Pricing]({{site.mi_baseurl}}/item-profile-details/item-pricing/discounts-and-special-pricing/promotional-pricing/promotional_pricing.html)

- Selling price  for the item with special pricing rules (special pricing).

: ![Lens.gif]({{site.mi_baseurl}}/img/lens.gif) [Special  Pricing]({{site.mi_baseurl}}/item-profile-details/item-pricing/discounts-and-special-pricing/special-pricing/special_pricing.html)


{:.note}
- The selling price  that is the least of all the above, is the price displayed for the item  on the sales document.
- The least price  is dependent upon preferences set in Fi**le 
 &gt; Setup &gt; Preferences &gt; Flow Control &gt; Documents &gt; Pricing/Discounts**  tab. If you check the **Customer level 
 price to override list price for price calculation** option, it ignores  the List Price (Fixed Price/% Markup) if a Customer Level price is defined.  If this option is unchecked, it considers the List Price in the least  price calculation. If you check this option and a Customer Level price  is not defined, the List Price is considered along with Quantity pricing,  Promotional pricing, and Special pricing to arrive at the least price.
