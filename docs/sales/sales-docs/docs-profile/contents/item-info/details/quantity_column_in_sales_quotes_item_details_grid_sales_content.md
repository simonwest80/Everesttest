---
title: Quantity Column - Sales Quotes
---

# Quantity Column - Sales Quotes


The **Quantity** column displays  the quantity of the item ordered. This column is available in sales quotes  and in sales orders that are created directly.


Quantity is expressed in terms of the sales measure.


![]({{site.sp_baseurl}}/img/lens.gif) [Measures]({{site.mi_chm}}/item-profile-details/measure/measure.html)


When you add an item to the document, this column displays a default  quantity of 1 measure with the decimal accuracy of the unit of measure.  You can enter the required quantity in this column and you can increase  the decimal accuracy up to 6 places.


{:.example}
Your default sales measure is KG and the KG  decimal accuracy is 2. The quantity is shown as 1.00, but you can enter  1.123 or 1.12345.


When you convert a quote to an order, or an order is converted to an  invoice, the quantity specified in the quote or the ordered quantity is  displayed here.


The quantity entered in this column depends on the **Quantity****Entry** **Method**  specified for the item in the **Item**  profile (path: **** **Inventory**  > **Items** > From the **Items** browser, double-click on the required  record > **Item** profile >  **Purchases** tab)


![]({{site.sp_baseurl}}/img/lens.gif) [Quantity  Entry Methods]({{site.mi_chm}}/item-profile-details/other-items-information/purchase/quantity_entry_method.html)


[Item  Purchase Information]({{site.mi_chm}}/create-regular-items-kits-and-assemblies/creating-an-item/the_items_profile_-_purchases.html)


![]({{site.sp_baseurl}}/img/example.gif)<font style="color: #808000;" color="#808000"> </font>The sales measure of an item is kilograms. This  measure comprises 1000 grams. Therefore two and a half kilograms at a  cost of $2 a gram would be expressed as:


Fractional Method


The quantity is expressed in the fractional  format as 2:500 units.


The value of the quantity is calculated  as follows:


$2 \* 2000 + $2 \* 500


Decimal Method


The quantity 2 kilograms, 500 grams and  15 milligrams is expressed in the decimal format as 2500.15.


The value of the quantity is calculated  as follows:


$2 \*(2500)\* +$2 \*0.15


{:.note}
If the Quantity Entry Method is fractional, you cannot  enter quantities less than 1.


{:.see_also}
See also
: [Item  Details]({{site.sp_baseurl}}/sales-docs/docs-profile/contents/item-info/details/item_details_item_details_grid_sales_process_content.html)
