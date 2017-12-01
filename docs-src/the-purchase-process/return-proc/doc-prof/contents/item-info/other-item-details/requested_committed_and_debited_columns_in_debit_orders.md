---
title: Requested, Committed and Debited Columns in Debit Orders
---

# Requested, Committed and Debited Columns in Debit Orders


The quantity entered depends on the **Quantity 
 Entry Method** for the item.


![]({{site.pp_baseurl}}/img/lens.gif) [Quantity  Entry Methods]({{site.mi_chm}}/item-profile-details/other-items-information/purchase/quantity_entry_method.html)


**Requested**
: The **Requested**  column displays the quantity of the item that you want to return. Entering  the item quantity is useful even in case of non-inventoried items.


{:.example}
You may not want to maintain an inventory  of paper clip boxes, but the vendor would still want to know how many  boxes you are returning.
: If the order was processed from a quote, the quantity  entered in the **Quantity** column  of the quote is displayed in the **Requested**  column of the debit order.


**Committed**
: The **Committed**  displays the quantity of the inventoried item requested that you have  committed for shipment. The committed quantity could represent the following:

- Items  that you physically send but do not take out of stock until approval
- Items  in transit
- Items  sent for exchange or repair



{:.note}
When committed quantity of a non-serialized item are  returned or serial numbers of a serialized item attached to a debit order  are returned, the quantity in the committed column reduces. The committed  column shows quantities committed but not returned.
: Committed quantities on debit order are assigned  to a 'stock' type of stock area.
: ![]({{site.pp_baseurl}}/img/lens.gif) [Stock  Area Types]({{site.sc_chm}}/options/miscellaneous-set-up/stock-areas/stock_area_types.html)
: An entry can be made in this column only for inventoried  items. The quantity entered in this column cannot exceed the quantity  requested.
: In case of an auto-serialized item, this column  displays the quantity committed with a suffix ‘a’ indicating the item  is auto-serialized.


**Debited**
: This column displays the total quantity returned  and taken out of stock. You cannot make an entry directly in this column.
: This column does not have a value in the case of  **Open** debit orders.
: ![]({{site.pp_baseurl}}/img/lens.gif)  [Document Status]({{site.pp_baseurl}}/return-proc/doc-prof/contents/document-information/document_status_pr.html)
: When a debit order is converted to a debit memo,  the returned quantity is entered in the debit memo. There may be many  returns against an order. The **Debited**  column comprises the total quantity of the item returned on all debit  memos against the order.


{:.see_also}
See also
: [Requested]({{site.pp_baseurl}}/misc/requested_pr.html)
: [Committed]({{site.pp_baseurl}}/misc/committed_pr.html)
: [Debited]({{site.pp_baseurl}}/misc/debitted_pr.html)
: [Other Information]({{site.pp_baseurl}}/misc/other_information_sr_con.html)
