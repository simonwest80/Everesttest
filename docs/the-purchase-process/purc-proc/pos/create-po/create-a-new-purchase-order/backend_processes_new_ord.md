---
title: Back End Processes - Create a Purchase Order
---

# Back End Processes - Create a Purchase Order


When you create a purchase order directly, the following back end processes  occur:

- The next sequence  number for purchase orders for the logged in location or location of the  logged in location/sub-location  is  assigned (path: **File** > **Setup** > **Accounting**  > **Location**/**Sub-Location**  > **Options** > **Edit**  > **In** **New****Window** > **Purchasing**  tab). The sequence number of the purchase order is generated automatically  by the system.
- A purchase quote  number is assigned to the purchase order. The next sequence number (for  purchase quotes) specified for the logged in location or the location  of the login location/sub-location is assigned to the purchase quote.  This number is used to change the order back to a quote, if the purchase  order is canceled.
- The total quantity  **On** **Order**  for each item increases by quantity of the item ordered.



![]({{site.pp_baseurl}}/img/lens.gif) [Item  Stock Status]({{site.mi_chm}}/misc/columns_in_the_item_stock_status_dialog_box.html)

- The purchase order  is initially assigned the status 'Open'.



{:.see_also}
See also
: [Document Number]({{site.pp_baseurl}}/purc-proc/doc-profile/contents/document-information/document_number.html)
: [Document Status]({{site.pp_baseurl}}/purc-proc/doc-profile/contents/document-information/document_status.html)
: [Stock Status]({{site.pp_baseurl}}/purc-proc/doc-profile/doc-options/item-info/stock_status.html).
: [Create a Purchase  Order]({{site.pp_baseurl}}/purc-proc/pos/create-po/create-a-new-purchase-order/creating_an_order.html)
