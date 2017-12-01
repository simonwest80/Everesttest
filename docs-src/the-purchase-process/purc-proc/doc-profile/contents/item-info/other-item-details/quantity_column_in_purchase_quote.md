---
title: Quantity - Purchase Quotes
---

# Quantity Column in Purchase Quotes


The **Quantity** column displays  the quantity of the item to be purchased. This column is displayed only  in purchase quotes. Enter the quantity being purchased.


**Quantity Measure**


Quantity is expressed in terms of the purchase measure. When an item  is added to the document, the **Quantity** column defaults to one with the decimal accuracy of the unit of  measure. You can increase the decimal accuracy up to six places.


{:.example}
Your default purchase measure is KG and the  KG decimal accuracy is 2. The quantity is shown as 1.00, but you can enter  1.123 or 1.12345.


![]({{site.pp_baseurl}}/img/lens.gif) [Measure]({{site.mi_chm}}/item-profile-details/other-items-information/purchase/measure_pur.html)


The value that you enter in the **Quantity**  column depends on the **Quantity Entry 
 Method** specified for the item (path: **Inventory**  > **Items** > **Options**  > **Edit** > **In 
 New Window** > **Item** profile  > **Purchases** tab).


![]({{site.pp_baseurl}}/img/lens.gif) [Item  Profile - Purchases Tab - Quantity Entry Method Field]({{site.mi_chm}}/create-regular-items-kits-and-assemblies/creating-an-item/the_items_profile_-_purchases.html)


{:.example}
The purchase measure of an item is kilograms. This measure  comprises 1000 grams.


**Fractional Method**


Two and a half kilograms is expressed as 2:500 units.


The value of the item at a cost of $2 per kilogram is  calculated as follows:


2 \* $2 + (500/1000)\*$2


**Decimal Method**


Two kilograms, 500 grams and 15 milligrams is expressed  in the decimal format as 2500.15.


The value of the item is calculated as follows:


2\*2.5+(2/1000000)\*15


{:.note}
If the quantity entry method is fractional,  you cannot enter quantities less than 1.


{:.see_also}
See also
: [Item Information]({{site.pp_baseurl}}/purc-proc/doc-profile/contents/item-info/item_information_pp.html)
: [Measures]({{site.mi_chm}}/item-profile-details/measure/measure.html)
: [Quantity  Entry Methods]({{site.mi_chm}}/item-profile-details/other-items-information/purchase/quantity_entry_method.html)
