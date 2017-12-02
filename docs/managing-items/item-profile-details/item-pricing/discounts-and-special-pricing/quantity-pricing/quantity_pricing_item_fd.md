---
title: The Quantity Pricing Dialog Box
---

# The Quantity Pricing Dialog Box


Use this dialog box to define the quantity pricing and markup values  you wish to use for this item/kit for each measure listed. When a measure  is selected in the sales document for an item, the quantity pricing defined  for that measure applies to the item.


**Quantity**
: Enter the minimum quantity to be purchased by the  customer in order to receive the special pricing. You can define up to  5 different quantity levels. The quantity is in the decimal accuracy for  the sales measure.


**% Markup**
: Enter the markup percentage at which the item should  be sold. For each quantity level, you can specify a different percent  markup. **Everest** calculates the  selling price of the item by marking up the cost of the item with this  percentage.


{:.note}
You cannot specify zero (0) in this field. **Everest**  prompts you to enter a value greater than zero.


{:.example}
The cost of an item is $400. The special quantity pricing defined for  the item is that, if a customer buys 20 quantities of this item, the cost  is marked up by 10%.


In this case, the selling price is calculated as follows:400 \* 10/100  = $40. This amount is added to the cost price i.e., $400 + $40 = $440.  Therefore, when a customer buys 20 quantities of this item, it is sold  at $440 per unit.


**Price**
: To specify a fixed price (per measure) at which  the item has to be sold, specify the price in this column.


{:.note}
You cannot specify zero (0) in this field. **Everest**  prompts you to enter a value greater than zero.


{:.example}
The selling price of the item 'A' is $100.  The special quantity pricing defined for the item is $90 per unit. It  is applicable only if a customer buys 20 quantities of this item.


{:.note}
It is mandatory to define either a fixed price or a markup percentage  if you specify a quantity greater than zero in the **Quantity**  column.


You cannot define both fixed price and markup percentage for a certain  quantity of an item.


{:.see_also}
See also
: [Quantity Pricing]({{site.mi_baseurl}}/item-profile-details/item-pricing/discounts-and-special-pricing/quantity-pricing/quantity_pricing.html)
: [Define  a Quantity Pricing Scheme]({{site.mi_baseurl}}/item-profile-details/item-pricing/discounts-and-special-pricing/quantity-pricing/setting_up_a_quantity_pricing_scheme.html)
