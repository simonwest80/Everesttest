---
title: Invoiced Column
---

# Invoiced Column in Purchase Documents


Purchase Orders


In the case of an open purchase order, this column has no value.


When you convert a purchase order to a purchase invoice, this column  automatically updates when you enter quantity into the Invoiced column  of the purchase invoice and save the invoice.


You cannot edit this column.


Purchase Receipts


When you convert a purchase order to a purchase receipt, this column  populates with the quantity in the Invoiced column of the purchase order  at the time you converted it.


When you create a purchase receipt directly (without first creating  a purchase order), this column displays a zero.


When you convert a purchase receipt to a purchase invoice, this column  updates when you save the invoice if you entered a new value in the Invoiced  column of the purchase invoice. The receipt also updates with each invoice  if you convert it to multiple purchase invoices.


You cannot edit this column.


Purchase Invoices


When you convert a purchase order to a purchase invoice, this column  populates with the quantity in the Ordered but not Invoiced column of  the purchase order at the time you converted it. When you convert a purchase  receipt to a purchase invoice, this column automatically populates with  the quantity in the Received but not Invoiced column of the purchase receipt.


You can select the option Set the quantity invoiced value to zero when  converting a purchase order/receipt to a purchase invoice (path: **File** > **Setup**  > **Preferences** > **Flow 
 Control** > **Documents**  > **Miscellaneous** > **Others** > **Others 
 1** tab).


You must save the new invoice before you can edit this column. You can  edit it after subsequent saves; however, you cannot edit this column after  the purchase invoice is posted.


When you create a purchase invoice directly (without first creating  a purchase order), this column does not automatically populate and you  must manually enter the information. You cannot edit this after you save  the purchase invoice created directly.


You need proper security rights to enter an Invoiced quantity different  from the Received but not Invoiced quantity for inventoried items.


{:.see_also}
See also
: [Ordered,  Committed, Received, and Invoiced Columns in Purchase Orders]({{site.pp_baseurl}}/purc-proc/doc-profile/contents/item-info/other-item-details/ordered_committed_and_received_po.html)
: [Ordered, Ordered  but not Received, Received, Invoiced, and Invoiced but not Received in  Purchase Receipts]({{site.pp_baseurl}}/purc-proc/doc-profile/contents/item-info/other-item-details/ordered_and_received_pr.html)
: [Ordered,  Ordered but not Invoiced, Received, Received but not Invoiced, Invoiced,  and Received on Invoice Columns in Purchase Invoices]({{site.pp_baseurl}}/misc/ordered_ord_not_inv_rec_rec_not_inv_inv_recd_on_inv_pur.html)
