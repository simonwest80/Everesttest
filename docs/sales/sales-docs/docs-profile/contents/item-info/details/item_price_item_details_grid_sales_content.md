---
title: Item Price
---

# Item Price


The selling price of an item is the price at which the item is sold  to the customer. The difference between the cost of the item (**actual 
 cost** in case of **serialized inventory**  and **average cost** in case of **non-serialized inventory**) and the selling  price of the item is the profit.


If an item with zero Fixed Price or zero Markup percentage is retrieved  into a document, the **Item Price**  column in the Item Details grid displays zero.


**Everest** allows you to enter  negative prices for both inventoried and non-inventoried items on sales  documents.


{:.example}
Some merchants provide discount coupons at  stores. A certain percent is marked off some items when the customer produces  the coupon during checkout. These coupons may bear a serial number. In  order to track the serial numbers on discount coupons, such serial numbers  are treated as serialized inventory and scanned/entered on the sales document.  In such cases, the price of the discount line item will be a negative  value.


When a new document is created, the selling price of an item is calculated  by each of the following methods. The selling price displayed for the  item in a sales document will be the **least**  of all the calculated prices. If the option **Customer 
 level price to override list price for price calculation** (path:  **File &gt; Setup &gt; Preferences &gt; 
 Flow control &gt; Documents &gt; Pricing/Discounts** tab) is checked  in the flow control preferences, the base selling price will not be considered  while displaying the least price in the document.

1. Base selling price calculation (fixed price, percent  markup on cost or percent of invoice total).



![]({{site.sp_baseurl}}/img/lens.gif) [Price  Calculations]({{site.mi_chm}}/item-profile-details/item-pricing/pricing-calculations/price_calculations.html)

1. Selling price for the customer's level.



![]({{site.sp_baseurl}}/img/lens.gif) [Pricing  and Customer Levels]({{site.mi_chm}}/item-profile-details/item-pricing/item_pricing_and_customer_levels.html)

1. Selling price at the quantity ordered.



![]({{site.sp_baseurl}}/img/lens.gif) [Quantity  Pricing]({{site.mi_chm}}/item-profile-details/item-pricing/discounts-and-special-pricing/quantity-pricing/quantity_pricing.html)

1. Selling price for the item in a specified period.



![]({{site.sp_baseurl}}/img/lens.gif) [Promotional  Pricing]({{site.mi_chm}}/item-profile-details/item-pricing/discounts-and-special-pricing/promotional-pricing/promotional_pricing.html)

1. Special selling price for the customer.



![]({{site.sp_baseurl}}/img/lens.gif) [Special  Pricing]({{site.mi_chm}}/item-profile-details/item-pricing/discounts-and-special-pricing/special-pricing/special_pricing.html)


{:.note}
The price applicable to an item is calculated after  considering all pricing schemes when you retrieve the item into the document.  If the quantity of an item is changed and thus another price becomes applicable  to the item, the price may change automatically or **Everest** may prompt you depending on the option selected in the **Behavior 
 for price column if quoted/ordered quantity is changed and a new price 
 is available** field (path: **File**  > **Setup** > **Preferences**  > **Flow** **Control**  > **Documents** > **Pricing/Discounts**  tab).


![]({{site.sp_baseurl}}/img/lens.gif)<font style="color: #ff0000;" color="#FF0000"> </font>[Flow  Control - Documents]({{site.bp_chm}}/misc/behaviour_for_price_column_if_quantity_is_changed_and_a_new_price_is_available.html)


If a quote is converted to an order, or an order is converted to an  invoice, the quoted or ordered price is displayed. You can modify the  item price on a quote or an order or an invoice anytime, till the journal  is posted.


{:.note}
Once a sales invoice or point of sale invoice is posted,  the price cannot be changed.


![]({{site.sp_baseurl}}/img/lens.gif) [Items]({{site.mi_chm}}/create-regular-items-kits-and-assemblies/creating-an-item/setting_up_an_item.html)


**Foreign Currency Documents**


In a foreign currency document the price is<font style="color: #000000;" color="#000000"> expressed 
 in terms of the following:</font>

- The foreign  currency in the document currency mode
- The base currency  in the base currency mode.



![]({{site.sp_baseurl}}/img/lens.gif) [Foreign  Currency Documents]({{site.sp_baseurl}}/sales-docs/docs-profile/contents/tab-details/details/frgn-cur/foreign_currency_documents_sales_document_content.html)


Change the item price, if necessary, using the sales price decimal accuracy  of the item. It shows the price from the **Item**  profile for the selected unit of measure. If the **Item 
 Price** is not defined in the **Item**  profile for the selected item, this field defaults to zero. Special pricing,  promotional pricing, or quantity pricing must be available in the selected  measure to be applicable. Discounts for the item must apply to the selected  measure.


{:.note}
If you want to change the default unit of  measure, the sales price decimal accuracy, or the quantity decimal accuracy,  you need additional security rights.


{:.note}
The percent markup is calculated on the average  cost/last cost depending upon your preference defined in Flow Control  (Path: **File** > **Setup**  > **Preferences** > **Flow 
 Control** > **Other Flow Control**  > **Item Cost/Sales Summary**).  The average cost is converted to the sales measure based on the conversion  factor. If a purchase measure matching the sales measure is available,  the last cost on the **Purchase**  tab of the item is converted to the sales measure. If a purchase measure  is not available, the last cost on the **Inventory**  tab is converted to the sales measure.


{:.see_also}
See also
: [Items  with Promotional Pricing]({{site.sp_baseurl}}/sales-docs/docs-profile/contents/item-info/details/pricing/items_with_promotional_pricing_item_details_grid_sales_content.html)
: [Selling  Price for Matrix Items]({{site.sp_baseurl}}/sales-docs/docs-profile/contents/item-info/details/pricing/selling_price_for_matrix_items_item_details_grid_sales_content.html)
: [Selling  Price for Kit Items]({{site.sp_baseurl}}/sales-docs/docs-profile/contents/item-info/details/pricing/selling_price_for_kit_items_item_details_grid_sales_content.html)
: [Item  Details]({{site.sp_baseurl}}/sales-docs/docs-profile/contents/item-info/details/item_details_item_details_grid_sales_process_content.html)
: [Maintaining  Critical or Minimum Markup/Margin on Sales Documents]({{site.sp_baseurl}}/sales-docs/sqs/sq-proc/pricing-analysis/maintaining_critical_and_minimum_markup_margin_on_sales.html)
