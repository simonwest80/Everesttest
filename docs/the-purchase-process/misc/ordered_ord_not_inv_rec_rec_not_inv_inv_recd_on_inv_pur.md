---
title: Ordered, Ordered but not Invoiced, Received, Received to Date, Received but not Invoiced, and Invoiced Columns in Purchase Invoices
---

# Ordered, Ordered but not Invoiced, Received, Received to Date, Received  but not Invoiced, and Invoiced Columns in Purchase Invoices


**Ordered**
: When you convert a purchase order to a purchase  invoice, this column populates with the quantity in the Ordered column  of the purchase order at the time you converted it.
: When you convert a purchase receipt to a purchase  invoice, or when you create a purchase invoice directly (without first  creating a purchase order or receipt), this column displays a zero.
: You cannot edit this column.


**Ordered but not Invoiced**
: When you convert a purchase order to a purchase  invoice, this column is populated with the quantity in the Ordered column  minus the quantity in the Invoiced column of the purchase order at the  time it was converted.
: When you convert a purchase receipt to a purchase  invoice, or when you create a purchase invoice directly (without first  creating a purchase order or receipt), this column displays a zero.
: You cannot edit this column.


**Received**
: When you convert a purchase order to an invoice,  this column displays the quantity of items already received. When you  convert a purchase receipt to a purchase invoice, or when you create a  purchase invoice directly, this column displays a zero.
: Update the **Received**  column when additional quantities are received on the purchase invoice.  You cannot edit this column after saving the invoice. Updates to the **Received** column also update the **Received to Date** column.
: This column is in the decimal accuracy of the unit  of measure. You can also increase the decimal accuracy up to six places.  If you change the decimal accuracy, the original quantity is shown in  the decimal accuracy of the changed measure.


{:.example}
If your quantity is entered as 10.20 and the  decimal accuracy of the measure is changed to 0, the quantity is shown  as 10.
: You can have both positive and negative quantities  of items on a document. Positive quantities on a purchase invoice indicate  that the item is received. Negative quantities indicate that the item  is returned.
: A serial number generated on a purchase invoice  will normally be in a ‘stock’ type. You can view the list of serial numbers  for items received on the invoice by clicking on the quantity in the Received  column. Inventoried items will display in the Assign Quantity dialog box.
: If items are received on the invoice, the following  fields are updated to the stock measure for the item:

- Total
- PO
- PO Commit
- DO
- DO Commit

: You cannot change measures in the following situations:

- Committed Quantities
- Backorders
- Shipped Orders



**Received to Date**
: The **Received to 
 Date** column is based on the total quantity received at the time  of making the invoice and will not be updated based on subsequent receipts  to the purchase order. You cannot manually update the **Received 
 to Date** field for a line item; however it is automatically updated  when the **Received** field is modified.
: When you create a purchase invoice directly (without  first creating a purchase order or receipt), this column displays a zero.
: When you convert a purchase receipt to a purchase  invoice, this column populates with the quantity in the Received column.
: When you convert a purchase order to a purchase  invoice, this column populates with the quantity in the Ordered column  of the order at the time you converted it if there is no committed quantity.  This quantity displays zero if you select the option **Set 
 the quantity received value to zero when converting a purchase order to 
 a purchase invoice** (path: **File**  > **Setup** > **Preferences**  > **Flow Control** > **Documents**  > **Miscellaneous** tab > **Others** tab > **Others 
 1** tab).


{:.example}
Click the following link for an example that  illustrates how the **Received to Date**  field changes for a line item when you create a purchase receipt and purchase  invoices from the same purchase order:


![]({{site.pp_baseurl}}/img/lens.gif)[Received  to Date Field Example]({{site.pp_baseurl}}/misc/received_to_date_field_example_pi_pur.html)


**Received but not Invoiced**
: When you convert a purchase order or receipt to  a purchase invoice, this column populates with the quantity in the Received  column minus the quantity in the Invoiced column of the purchase order/receipt  at the time you converted it.
: When you create a purchase invoice directly (without  first creating a purchase order), this column displays a zero.
: You cannot edit this column.


**Invoiced**
: When you convert a purchase order to a purchase  invoice, this column populates with the quantity in the Ordered but not  Invoiced column of the purchase order at the time you converted it. When  you convert a purchase receipt to a purchase invoice, this column automatically  populates with the quantity in the Received but not Invoiced column of  the purchase receipt.
: You can select the option Set the quantity invoiced  value to zero when converting a purchase order/receipt to a purchase invoice  (path: File > **Setup** > **Preferences** > **Flow 
 Control** > **Documents**  > **Miscellaneous** tab > **Others** tab > **Others 
 1** tab).
: When you create a purchase invoice directly (without  first creating a purchase order), this column displays a zero.
: You must save the new invoice before you can edit  this column. You can edit it after subsequent saves; however, you cannot  edit this column after the purchase invoice is posted.
: You need proper security rights to enter an Invoiced  quantity different from the Received but not Invoiced quantity for inventoried  items.
