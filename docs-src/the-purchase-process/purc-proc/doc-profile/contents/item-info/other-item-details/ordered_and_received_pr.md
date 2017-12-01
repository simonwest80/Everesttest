---
title: Ordered, Ordered but not Received, Received, Invoiced, and Invoiced but not Received in Purchase Receipts
---

# Ordered, Ordered but not Received, Received, Invoiced, and Invoiced  but not Received in Purchase Receipts


**Ordered**
: When you convert a purchase order to a purchase  receipt, this column of the receipt populates with the quantity in the  Ordered column of the purchase order at the time you converted it.
: When you create a purchase receipt directly (without  first creating a purchase order), this column displays a zero.
: You cannot edit this column.


**Ordered but not Received**
: When you convert a purchase order to a purchase  receipt, this column in the receipt populates with the quantity in the  Ordered column minus the quantity in the Received column of the purchase  order at the time you converted it.
: When you create a purchase receipt directly (without  first creating a purchase order), this column displays a zero.
: You cannot edit this column.


**Received**
: When you convert a purchase order to a purchase  receipt, this column populates with the quantity already committed into  stock at the time you convert it. If there is no quantity committed, the  column displays the quantity ordered but not received unless you select  the option **Set the quantity received 
 value to zero when converting a purchase/debit order to a purchase receipt 
 or purchase invoice/debit memo** (path: **File**  > **Setup** > **Preferences**  > **Flow Control** > **Documents**  > **Miscellaneous** > **Others** > **Others 
 1** tab).


{:.note}
This option works only for auto-serialized and inventoried (non-serialized)  items.


For serialized items,  the  shipped column always displays a zero.
: In a purchase receipt created from a purchase order  for inventoried and non-inventoried line items, the Received quantity  cannot be more than the ordered quantity. In this situation, if it is  necessary to receive more than the current ordered quantity, increase  the ordered quantity in the purchase order or include the additional quantity  received on a separate line.
: This column is in the decimal accuracy of the unit  of measure. You can also increase the decimal accuracy up to six places.
: You cannot edit this column after you save the purchase  receipt.


**Invoiced**
: When you convert a purchase order to a purchase  receipt, this column populates with the quantity in the Invoiced column  of the purchase order at the time you converted it.
: When you create a purchase receipt directly (without  first creating a purchase order), this column displays a zero.
: When you convert a purchase receipt to a purchase  invoice, this column updates when you save the invoice if you entered  a new value in the Invoiced column of the purchase invoice.
: You cannot edit this column.


**Invoiced but not Received**
: When you convert a purchase order to a purchase  receipt, this column populates with the quantity in the Invoiced column  minus the quantity in the Received column of the purchase order at the  time you converted it.
: When you create a purchase receipt directly (without  first creating a purchase order), this column displays a zero.
: When you convert a purchase receipt to a purchase  invoice, this column updates when you save the invoice. It displays the  Invoiced value from the purchase invoice minus the Received value of the  purchase receipt and the Received on Invoice value of the purchase invoice  (the invoiced quantity minus all quantities received in both documents).
: You cannot edit this column.


**Positive and Negative Quantities in Purchase  Receipts**


You can have both positive and negative quantities of items on a document.  Positive quantities on a purchase receipt indicate that the item is received.  Negative quantities indicate that the item is returned.


A serial number generated on a purchase receipt will normally be  in a 'stock' type of area.


The following fields are updated to the stock measure after conversion  from the sales measure for the item:

- Total Stock
- PO
- PO Commit
- DO
- DO Commit



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
: [Recei[ved]({{site.pp_baseurl}}/misc/last_cost_calculation_in_the_stock_measure_the_purchase_process.html)]({{site.pp_baseurl}}/misc/received.html)
