---
title: How is an Item\'s Selling Price Calculated?
---

# How is an Item's Selling Price Calculated?


An item's selling price can be calculated by each of these methods:

- Base selling  price calculation (fixed price or percent markup on cost or percent of  invoice total).
- Selling price  for the customer level (Advanced option for calculating selling price  at different customer levels).
- Selling price  at the quantity ordered (Special quantity pricing scheme for the item).
- Selling price  for the item in a specified period (Promotional pricing).
- Selling price  for the item with special pricing rules (Special pricing).



The selling price that is the least of all the above prices is the price  displayed for the item on the sales document.


{:.note}
The least price is dependent upon preferences  set in **File** > **Setup**  > **Preferences** > **Flow 
 Control** > **Documents**  > **Pricing/Discounts** tab. If  you check the **Customer level price to 
 override list price for price calculation option**, it ignores the  List Price (Fixed Price/% Markup) if a Customer Level price is defined.  If this option is unchecked, it considers the List Price in the least  price calculation. If you check this option and a Customer Level price  is not defined, the List Price is considered along with Quantity pricing,  Promotional pricing, and Special pricing to arrive at the least price.


{:.see_also}
See also
: [Item Pricing]({{site.mi_baseurl}}/item-profile-details/item-pricing/item_pricing.html)
