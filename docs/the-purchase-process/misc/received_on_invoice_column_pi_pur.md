---
title: Received to Date Column
---

# Received to Date Column


The **Received to Date** column  is based on the total quantity received at the time of making the invoice  and will not be updated based on subsequent receipts to the purchase order.  You cannot manually update the **Received 
 to Date** field for a line item; however it is automatically updated  when the **Received** field is modified.


When you create a purchase invoice directly (without first creating  a purchase order or receipt), this column displays a zero.


When you convert a purchase receipt to a purchase invoice, this column  populates with the quantity in the Received column.


When you convert a purchase order to a purchase invoice, this column  populates with the quantity in the Ordered column of the order at the  time you converted it if there is no committed quantity. This quantity  displays zero if you select the option **Set 
 the quantity received value to zero when converting a purchase order to 
 a purchase invoice** (path: **File**  > **Setup** > **Preferences**  > **Flow Control** > **Documents**  > **Miscellaneous** tab > **Others** tab > **Others**  1 tab).


{:.example}
Click the following link for an example that  illustrates how the **Received to Date**  field changes for a line item when you create a purchase receipt and purchase  invoices from the same purchase order:


![]({{site.pp_baseurl}}/img/lens.gif)[Received  to Date Field Example]({{site.pp_baseurl}}/misc/received_to_date_field_example_pi_pur.html)


{:.see_also}
See also
: [Ordered,  Ordered but not Invoiced, Received, Received to Date, Received but not  Invoiced, and Invoiced Columns in Purchase Invoices]({{site.pp_baseurl}}/misc/ordered_ord_not_inv_rec_rec_not_inv_inv_recd_on_inv_pur.html)
