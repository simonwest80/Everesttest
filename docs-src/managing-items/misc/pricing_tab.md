---
title: Pricing Tab
---

# Pricing Tab


Use the **Pricing** tab to define  how item prices will be calculated when you retrieve the kit in to a sales  document.


**Type**
: Specify the sales price calculation method.


Display the price of each item separately


Select this option to display the price of each item in the kit separately.  This option displays the following fields:


**Use item price defined in the kit details**
: Select this option to display the individual price  of the items in the kit.


**Recalculate the price of each item in the kit**
: Select this option to recalculate the price of each  item in the kit based on any special pricing rules set up. **Everest**  calculates the least price of each item, after considering all the pricing  options set up, like Customer Level pricing, Quantity pricing etc.


![Lens.gif]({{site.mi_baseurl}}/img/lens.gif) [Discounts  and Special Pricing]({{site.mi_baseurl}}/item-profile-details/item-pricing/discounts-and-special-pricing/discounts_and_special_pricing.html)


The following table details the price display based on the options detailed  above:


| **Pricing Option** | **Price Displayed in <br/> Sales Documents** |
| Price of the Kit | Price of Individual Items in the Kit |
| Use item price defined in the kit details | Will not be displayed | Individual prices of items in the kit are displayed |
| Recalculate the price of each item in the kit | Will not be displayed | Individual prices of items in the kit **based <br/> on special pricing rule** are displayed |



Reset item prices to zero and display the total price  of the kit on a total line
: Select this option to reset the prices of all individual  items in the kit to zero, and display the total price of the kit according  to the options displayed. This option displays the following fields:


**Use pricing defined in the Sales tab to determine  the total price**
: Select this option to display the sales price of  the item kit, specified in the **Sales**  tab of the **Item** profile. The kit  is added as the first line item with the prices defined in its profile.  **Everest** displays zero prices for  all individual items in the kit.


![Lens.gif]({{site.mi_baseurl}}/img/lens.gif) [Item Profile  -Sales Tab]({{site.mi_baseurl}}/create-regular-items-kits-and-assemblies/creating-an-item/the_item_profile_-_sales_tab.html)


![]({{site.mi_baseurl}}/img/lens.gif) [How Do I Discount  a Kit?]({{site.mi_baseurl}}/create-regular-items-kits-and-assemblies/creating-an-item-kit/how_do_i_discount_a_kit_mi.html)


**Sum item prices defined in the kit details to  determine the total price of the kit**
: Select this option to display the sum of the prices  of all individual items in the kit, as the kit price. The individual items  display zero prices.


**Recalculate the price of each item in the kit  and sum them to determine the total price of the kit**
: Select this option to display the sum of the recalculated  prices of the items in the kit (based on any special pricing rules set  up). **Everest** displays zero prices  for the individual items.


{:.note}
If the option **Tax 
 inclusive selling price** (**Item**  profile > **Sales** tab) is checked  for any of the kit components and you select either of the options - **Sum item prices defined in the kit details 
 to determine the total price of the kit** or **Recalculate 
 the price of each item in the kit and sum them to determine the total 
 price of the kit**, **Everest**  displays the following message:


“Some of the kit components are marked tax  inclusive. When this kit is retrieved into a sales document, the total  price of the kit in the sales document will be the sum of tax inclusive  price for kit components marked as tax inclusive and tax exclusive price  for kit components marked as tax exclusive. Tax will be calculated on  the total price.


Do you wish to save?”


The following table details the price display based on the options detailed  above


| **Pricing Option&nbsp;** | **Price Displayed in <br/> Sales Documents** |
| **Price of the Kit** | Price of Individual Items in the Kit |
| Use pricing defined in the **Sales**  tab to determine the total price | Fixed Price of kit as defined in the **Sales**  tab | Individual prices of items in the kit display 0 |
| Sum item prices defined in the kit details to determine  the total price of the kit | Sum of prices of individual items in the kit | Individual prices of items in the kit display 0 |
| Recalculate the price of each item in the kit and sum  them to determine the total price of the kit | Sum of prices of individual items in the **kit <br/> based on special pricing rules** | Individual prices of items in the kit display 0 |



{:.see_also}
See also
: [Item Profile  - Details Tab]({{site.mi_baseurl}}/create-regular-items-kits-and-assemblies/creating-an-item-kit/the_item_profile_details.html)
