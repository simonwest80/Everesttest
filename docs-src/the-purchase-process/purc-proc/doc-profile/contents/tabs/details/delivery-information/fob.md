---
title: fob
---

#  FOB


The **FOB** (Free on Board) field  identifies both the physical location where the title of the items passes  to the buyers and the party responsible for payment of freight.

- **FOB****Origin** - Indicates that the buyer  assumes title to the goods the moment the carrier signs the bill of lading.  The buyer is responsible for paying shipment charges incurred.
- **FOB****Destination** - Indicates that the  seller retains title to the goods until the goods are delivered to the  buyer. The seller is responsible for payment of freight charges incurred.



{:.note}
FOB in a return document for the good received  (purchased) identifies who bears the freight on shipment.


In each new purchase document, the FOB type defaults to the selection  made in the Default FOB Type in Purchase Documents preference (path: **File** > **Setup**  > **Preferences** > **Defaults**  > **Other Defaults**). You may  change the FOB Type by clicking the arrow to open the drop down selection  box.


You may only change the FOB Type in the following documents:

- a purchase  order or debit order which you have not converted to a purchase receipt/invoice  or debit memo. You can no longer edit the FOB Type after you convert it  to a final document.
- a purchase  invoice or debit memo created directly (without converting it from a prior  purchase/return document).
- a purchase  receipt created directly which you have not converted to a purchase invoice.
- a document  for which you have not yet posted the associated purchase journal.



You may enter free text into the text field regardless of whether you  have selected FOB Origin or Destination, or you may leave the text field  blank. This field is purely for indicating the name of the exact location   to where  the title to goods passes ; it displays in the FOB Value column of the  purchase browsers but does not affect the system in any way.


{:.example}
If you have multiple warehouses, you can enter the name of the warehouse  (Warehouse 3) which will eventually house the items.


Special Cases for FOB Type

- The FOB type  for manual purchase documents always defaults to FOB Destination regardless  of the preference setting. You cannot change the type or add text to the  text field. Manual purchase documents do not automatically calculate freight  charges, so if you incur a charge you simply add it manually as a line  item.
- When you use  the Retrieve option in a purchase document profile or browser, the new  document uses the FOB type in the default preference setting regardless  of the type selected in the individual document(s). You may change the  FOB type in the new document if necessary.
![]({{site.pp_baseurl}}/img/lens.gif)[Retrieve  Items from Documents]({{site.pp_baseurl}}/purc-proc/doc-profile/contents/item-info/details/add-retrieve-items/retrieving_items_from_documents.html)
- When you convert  a purchase receipt to a debit memo using the “Generate Debit Order” option,  the FOB type in the debit memo defaults to the one used by the purchase  receipt. You may change the FOB Type in the new document if necessary.
![]({{site.pp_baseurl}}/img/lens.gif) [Generate Debit Order]({{site.pp_baseurl}}/purc-proc/prs/pr-processes/generate-debit-orders/generate_debit_order.html)
- Purchase orders  created automatically (because of Item Replenishment or Drop-shipments)  use the default preference setting. The value in the text field is blank.  You may change the FOB type and add text to the text field.
![]({{site.pp_baseurl}}/img/lens.gif) [Automated  Purchase Orders]({{site.pp_baseurl}}/purc-proc/pos/create-po/auto-generate-po/automatically_generating_purchase_orders.html)



{:.see_also}
See also
: [Delivery Information]({{site.pp_baseurl}}/purc-proc/doc-profile/contents/tabs/details/delivery-information/delivery_information.html)
