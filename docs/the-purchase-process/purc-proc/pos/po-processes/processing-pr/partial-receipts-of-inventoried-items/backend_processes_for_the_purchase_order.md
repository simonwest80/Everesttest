---
title: Back End Processes - Partial Receipt of Items
---

# Back End Processes - Partial Receipt of Items

- If the quantity  received is less than the ordered quantity, the purchase order is assigned  the status ‘Partially Received’.



**![]({{site.pp_baseurl}}/img/lens.gif) [Partial  Receipts]({{site.pp_baseurl}}/purc-proc/pos/po-processes/processing-pr/partial-receipts-of-inventoried-items/partial_receipts_of_inventoried_items.html)**

- If the ordered  quantity is received, the purchase order is assigned the status 'Fully  Received'. If the quantity is not fully invoiced, the purchase order is  still “open” and listed under the Open Purchase Orders toggle in the Purchase  Orders browser. If the purchase order Received status is Fully Received  and Invoiced status is Fully Invoiced, you can view it under the Fully  Received and Invoiced toggle of the Purchase Orders browser.
- When committed  quantities are received, the following changes occur in the stock status  of the item as viewed in the **Item****Stock** **Status**  dialog box:



**Item Stock 
 Status**


| **Column** | **Stock Increase/Decrease** |
| PO | Reduced by the quantity received. |



**![]({{site.pp_baseurl}}/img/lens.gif) [Item  Stock Status]({{site.mi_chm}}/misc/columns_in_the_item_stock_status_dialog_box.html)**


**Stock 
 Area Details**


| **Column** | **Stock Increase/Decrease** |
| PO | The committed quantity of item **On****Order** in the ‘out’ stock area  to which the item has been assigned is reduced by the quantity that has  been received. |



![]({{site.pp_baseurl}}/img/lens.gif) [Stock  Area Details]({{site.mi_chm}}/misc/stock_status_details_section.html)


{:.see_also}
See also
: [Stock Status]({{site.pp_baseurl}}/purc-proc/doc-profile/doc-options/item-info/stock_status.html)
: [Committing  items to the order]({{site.pp_baseurl}}/purc-proc/pos/po-processes/cmt-items-po/committing_items_to_the_purchase_order.html)
