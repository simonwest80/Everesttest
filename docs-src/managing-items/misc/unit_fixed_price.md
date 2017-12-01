---
title: Unit Fixed Price
---

# Unit Fixed Price


This is the price per unit of sales measure of an item. The measure  specified in the **Other sales information**  section of the **Sales** tab is considered  when calculating the unit fixed price. The unit fixed price is calculated  as follows:


Fixed Price / Unit Quantity of the Measure


{:.example}
The fixed price of Item A is $12 and the sales  measure is specified as ‘DZ’  (Dozen). The unit quantity specified for ‘DZ’  is 12. Therefore, the unit fixed price is calculated as: 12/12 = $1.


This field is enabled only if:

- the  quantity in sales measure is more than 1



![Lens.gif]({{site.mi_baseurl}}/img/lens.gif) [Sales  Measure]({{site.mi_baseurl}}/item-profile-details/other-items-information/sales/sales_measure_sales_info_item_profile.html)

- **Fixed 
 Price** is selected for price calculation.



![Lens.gif]({{site.mi_baseurl}}/img/lens.gif) [Fixed Price]({{site.mi_baseurl}}/item-profile-details/item-pricing/pricing-calculations/fixed_price.html)


When you change the fixed price in the **Item**  profile with sales measure more than one, **Everest**  calculates unit fixed price up to 6 decimals.


In sales and purchase documents, the unit price is rounded off based  on the unit quantity in the measure.


{:.example}
If quantity in measure is 0-9, unit fixed  price is calculated up to two decimals, and if quantity in measure has  5 digits (10000-99999), unit fixed price is calculated up to six decimals.
