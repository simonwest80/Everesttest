---
title: Ordered, Committed, Received, and Invoiced Columns in Purchase Orders
---

# Ordered, Committed, Received, and Invoiced Columns in Purchase Orders


The quantity entered depends on the **Quantity 
 Entry Method** for the item.


![]({{site.pp_baseurl}}/img/lens.gif) [Quantity  Entry Method]({{site.mi_chm}}/item-profile-details/other-items-information/purchase/quantity_entry_method.html)


**Quantity**
: This column displays the quantity of the item that  has been ordered. This column is available in purchase orders that are  created directly and have not yet been saved.


**Ordered**
: This column displays the quantity of the item ordered  from the vendor. If the order was processed from a quote, the quantity  entered in the **Quantity** column  of the quote is displayed in the **Ordered**  column of the purchase order.
: Entering the item quantity is useful even in the  case of non-inventoried items.


{:.example}
You may not want to maintain an inventory  of paper clip boxes, but the vendor would still want to know how many  boxes you are ordering.
: This column is in the decimal accuracy of the unit  of measure. You can increase the decimal accuracy up to six places.


**Committed**
: This column displays the quantity of the inventoried  item that has been committed by the vendor for shipment. The committed  quantity can represent either:

- Items  that you physically receive but do not take into stock until approval,  or
- Items  in transit.



{:.note}
When a committed quantity of a non-serialized item is  received or serial numbers of a serialized item attached to a purchase  order are received, the quantity in the committed column reduces. The  committed column displays quantities committed but not received.
: Committed quantities received on a purchase order  are received in an **Out** type of  stock area.
: ![]({{site.pp_baseurl}}/img/lens.gif) [Stock  Area Types]({{site.sc_chm}}/options/miscellaneous-set-up/stock-areas/stock_area_types.html)


{:.note}
You cannot enter quantities for non-inventoried items in this column.


The quantity entered in this column cannot exceed the quantity ordered.


In case of an auto-serialized item, this column displays the quantity  committed with a suffix ‘a’ indicating the item is auto-serialized.
: This column is in the decimal accuracy of the unit  of measure. You can increase the decimal accuracy up to six places.


**Received**
: In the case of an open purchase order, this column  has no value.
: When you convert a purchase order to a purchase  receipt, this column automatically updates with the quantity entered into  the Received column of the purchase receipt. When a purchase order is  converted to a purchase invoice, this column automatically updates with  the quantity in the Received on Invoice column of the purchase invoice.
: You cannot edit this column.


**Invoiced**
: In the case of an open purchase order, this column  has no value.
: When you convert a purchase order to a purchase  invoice, this column automatically updates when you enter quantity into  the Invoiced column of the purchase invoice and save the invoice.
: You cannot edit this column.


**Positive and Negative Quantities**


You can have both positive and negative quantities of items on a document.  Positive quantities on a purchase order indicate that the item has been  ordered, while negative quantities indicate that it is to be returned.


A serial number generated and committed to a positive quantity  on a purchase order will be in an "out" type of stock  area, while a serial number attached to a negative quantity will  be in a "stock" type of area**.**


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


![]({{site.pp_baseurl}}/img/lens.gif)[Average  Cost Calculation]({{site.pp_baseurl}}/misc/average_cost_calculation_the_purchase_process.html)


![]({{site.pp_baseurl}}/img/lens.gif)[Last  Cost Calculation in the Stock Measure]({{site.pp_baseurl}}/misc/last_cost_calculation_in_the_stock_measure_the_purchase_process.html)


{:.see_also}
See also
: [Ordered]({{site.pp_baseurl}}/misc/ordered.html)
: [Committed]({{site.pp_baseurl}}/misc/committed.html)
: [Received]({{site.pp_baseurl}}/misc/received.html)
