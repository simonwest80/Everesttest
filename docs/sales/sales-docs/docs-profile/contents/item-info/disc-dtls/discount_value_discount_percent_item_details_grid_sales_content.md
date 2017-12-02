---
title: Discount Value/Discount Percent
---

# Discount Value/Discount Percent


You may enter discounts available on an item either as a percentage  of the price or as a value of discount per unit of sales measure.


If you enter the discount value the discount percentage is computed  automatically and displayed in the **Discount 
 %** column.


If you enter the discount percentage the discount value per unit of  measure is computed and displayed in the **Discount****Value** column. Enter the discount  value in the sales price decimal accuracy of the item.


Discount on the item is calculated by each of these methods:

1. Discount available  for the customer for the quantity ordered (Quantity discount scheme for  the customer level).

: ![]({{site.sp_baseurl}}/img/lens.gif) [Quantity  Discounts]({{site.mi_chm}}/item-profile-details/item-pricing/discounts-and-special-pricing/quantity-discounts/quantity_discounts.html)

1. Discount available  on the item for a specified period (Promotional pricing).

: ![]({{site.sp_baseurl}}/img/lens.gif) [Promotional  Pricing]({{site.mi_chm}}/item-profile-details/item-pricing/discounts-and-special-pricing/promotional-pricing/promotional_pricing.html)


{:.note}
For a kit item, discount is not calculated  according to the parameters set in the **Promotions**  profile and the **Special Pricing**  profile. You need to do it manually.

1. Discount available  for the customer on the item (Special pricing).



The computed discount percentage or value is displayed in this field  only when the pricing method for an item is either "Discount percent  from least price" or "Discount fixed amount from least price"  in the **Special Pricing** dialog  box (path: **Inventory &gt; Discounts &gt; 
 Special Pricing**).


If the pricing is for "Discount fixed amount from least price"  and the discount amount exceeds the price of the item, the scheme is ignored  and no discount is applied on the item.


![]({{site.sp_baseurl}}/img/lens.gif) [Special  Pricing]({{site.mi_chm}}/item-profile-details/item-pricing/discounts-and-special-pricing/special-pricing/special_pricing.html)


{:.note}
The discount applied to the item price is the **highest** of all the discounts calculated  as above (in 1, 2 or 3). You may modify this discount.


Discounts are calculated for the quantity of the item in each line.


{:.note}
Discounts available are automatically calculated if  you select the option **Automatically apply 
 item discounts to customers** (path: **File**  > **Setup** > **Preferences**  > **Documents &gt; Miscellaneous**  > **Document Payments** tab).


![]({{site.sp_baseurl}}/img/example.gif) Item  1001 is entered on two lines with ordered quantities of 50 on each line.  If a discount is available for quantities of 100 or more, no discount  is calculated for the item. To automatically calculate the discount, the  ordered quantity must be 100 on each line.


If you modify the item quantity in the **Quantity** column, the discount value is automatically re-computed.


Discounts on Items Whose Price Includes Tax


Discount is computed differently for items whose price includes tax.


![]({{site.sp_baseurl}}/img/lens.gif) [Tax  Inclusive Selling Price]({{site.mi_chm}}/item-profile-details/other-items-information/sales/sales_price_inclusive_of_tax.html)


If the price of an item is inclusive of tax, discount is calculated  on the item price after excluding tax while discount is directly computed  on the item price for an item whose price does NOT include tax. In the  case of an item with 'Tax inclusive selling price',  the selling price is computed in the following manner:

- The price of  the item excluding tax is computed.
- The discount  applicable to the item is computed on this price.
- The amount  of discount is deducted from the item's sale price.
- The tax is  then computed on the discounted price.
- The item price  including tax is displayed in the **Item 
 Price** column of the Item Details Grid.



![]({{site.sp_baseurl}}/img/example.gif) If  an item's price is $110 which is inclusive of tax at 10%, the discount  is calculated on 100, not 110.


{:.see_also}
See also
: [Discount]({{site.sp_baseurl}}/misc/discounts_item_details_grid_sales_process_content.html)
