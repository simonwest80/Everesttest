---
title: Quantity - Debit Quotes
---

# Quantity - Debit Quotes


The **Quantity** column displays  the quantity of the item that is to be returned. This column is displayed  only in debit quotes.


**Quantity Measure**


Quantity is expressed in terms of the purchase measure. When an item  is added to the document, the column displays a default quantity for 1  measure.


If a quote is converted to an order or an order is converted to a memo,  the quoted quantity or the ordered quantity is displayed.


The quantity entered in the **Quantity**  column depends on the **Quantity Entry 
 Method** specified (path: **Inventory**  > **Items** > **Options**  > **Edit** > **In 
 New Window** > **Purchases**  tab).


{:.example}
The purchase measure of an item is kilograms. This measure  comprises 1000 grams. Therefore two and a half kilograms at a cost of  $2 a kilogram would be expressed as:


**Fractional Method**


The quantity is expressed in the fractional format as  2:500 units.


The value of the quantity is calculated as follows:


2 \* $2 + (500/1000)\*$2


**Decimal Method**


The quantity 2 kilograms, 500 grams and 15 milligrams  is expressed in the decimal format as 2500.15.


The value of the quantity is calculated as follows:


2\*2.5+(2/100000)\*15


{:.note}
If the quantity entry method is fractional,  you cannot enter quantities less than 1.


{:.see_also}
See also
: [Item Details]({{site.pp_baseurl}}/return-proc/doc-prof/contents/item-info/details/item_details_sr_con.html)
: [Measures]({{site.mi_chm}}/item-profile-details/measure/measure.html)
: [Items  - Quantity Entry Methods]({{site.mi_chm}}/item-profile-details/other-items-information/purchase/quantity_entry_method.html)
: [Other Information]({{site.pp_baseurl}}/misc/other_information_sr_con.html)
