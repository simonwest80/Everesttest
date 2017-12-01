---
title: Ordered, Committed and Shipped Columns in Sales Orders
---

# Quantity, Ordered, Committed and Shipped Columns in Sales Orders


**Quantity Column**


The **Quantity** column displays  the ordered quantity of the item. This column is available in sales orders  that have not been saved and that are created directly. This field defaults  to 1 with the decimal accuracy of the unit of measure. You can increase  the decimal accuracy up to 6 places.


{:.example}
Your default sales measure is KG and the KG  decimal accuracy is 2. The quantity is shown as 1.00, but you can enter  1.123 or 1.12345.


![]({{site.sp_baseurl}}/img/lens.gif) [Quantity  Column - Sales Quotes]({{site.sp_baseurl}}/sales-docs/docs-profile/contents/item-info/details/quantity_column_in_sales_quotes_item_details_grid_sales_content.html)


**The Ordered Column**


The **Ordered** column displays  the quantity of the item that has been ordered by the customer. The item  may be inventoried or non-inventoried. When you process a sales quote  to a sales order, the **Ordered**  column in the sales order gets populated with the quantity specified in  the **Quantity** column in the sales  quote.


Even though stock of non-inventoried items is not maintained in **Everest**, it is useful to enter the quantity  ordered.


![]({{site.sp_baseurl}}/img/example.gif) You  may not want to maintain an inventory of paper clip boxes, but you will  still want to know how many boxes a customer has ordered.


This column is in the decimal accuracy  of the unit of measure. You can increase the decimal accuracy up to six  places.


The Committed Column


The **Committed**  column displays the quantity of an inventoried item that is reserved for  delivery against the sales order. The quantity displayed in this column  also represents the items in transit as well as the items that have been  physically delivered but are not reduced from stock until the customer  approval is obtained.


Committed quantities issued on sales order  are assigned to an 'In type'  of Stock Area. The committed quantity cannot exceed the ordered quantity.


![]({{site.sp_baseurl}}/img/lens.gif) [Stock Areas](managing-items.chm::/stock_area.htm)


{:.note}
An entry can be made in the committed column for auto-serialized  items. This column is crossed in case of a non-inventoried line item.  In case of an auto-serialized item, this column displays the quantity  committed with a suffix '**a'** indicating  that the item is auto-serialized.


This column is  in the decimal accuracy of the unit of measure. You can increase the decimal  accuracy up to six places.


**The Shipped Column**


The **Shipped** column is automatically  populated with total quantity that is delivered and invoiced. You cannot  make an entry directly in this column. You cannot edit this field.


This column displays quantities for back orders.


![]({{site.sp_baseurl}}/img/lens.gif) [Order  Status]({{site.sp_baseurl}}/misc/order_status_find_sales_orders_content.html)


When a sales order is converted to a sales invoice, the quantity shipped  is entered in the sales invoice. There may be many shipments against an  order. The **Shipped** column in the  sales order comprises the total quantity of the item that is shipped against  the order.


{:.note}
When a committed quantity of non-serialized items is  shipped, or serial numbers of a serialized item attached to a Sales Order  are shipped, the quantity in the committed column reduces. The committed  column displays quantities committed but not shipped.


This column is  in the decimal accuracy of the unit of measure. You can increase the decimal  accuracy up to six places.


The following fields are updated to the stock measure after conversion  from the sales measure for the item:

- Total Stock
- On Reserve
- On Reserve Commit
- On Credit
- On Credit Commit  Quantity



You cannot change measures in the following situations:

- Committed Quantities
- Backorders
- Shipped Orders



If you change the decimal accuracy of a measure, the original quantity  is shown in the decimal accuracy of the changed measure.


{:.example}
If your quantity is entered as 10.20 and the  decimal accuracy of the measure is changed to 0, the quantity is shown  as 10.


{:.see_also}
See also
: [Item  Information]({{site.sp_baseurl}}/sales-docs/docs-profile/contents/item-info/item_information_item_details_grid_sales_content.html)
