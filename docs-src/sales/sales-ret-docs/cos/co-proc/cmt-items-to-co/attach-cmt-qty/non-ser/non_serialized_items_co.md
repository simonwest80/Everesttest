---
title: Non-serialized Items
---

# Non-serialized Inventoried Items


Inventory contained in only 'out' type of stock areas can be attached  to a credit order/memo.


{:.steps}
To enter the committed quantity for a non-serialized,  inventoried item, do the following:

- From the **Credit Order/Credit Memo** profile, click  the required item in the item grid.
- Select **Options &gt; Attach / Retrieve Serial # &gt; 
 Show/Attach Area-wise Stock**. You will see the [**Attach quantity for &lt;item name&gt;**  dialog box]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/cmt-items/enter-cmt-qty/non-ser/the_attach_quantity_profile.html).



{:.note}
The **Attach Quantity** dialog box  is also displayed when you double-click the **Committed**  column or when you try to enter quantities in the column. In the latter  case, it is displayed if the option **Use 
 default out stock area to assign quantity for non-serialized items in 
 credit order or credit memo** is NOT checked in the **Location**  profile (path: **File &gt; Setup &gt; Accounting 
 &gt;** **Location** profile **&gt; Stock Transfer &gt; Miscellaneous**  tab). Further, this dialog box shows up for non-serialized inventoried  items tracked for lots.


Adding to Items Committed


You may commit additional units of an item to the previously specified  quantity. The additional quantity is assigned to the stock area to which  other items are committed.


![]({{site.sp_baseurl}}/img/example.gif) If  you want to commit 20 items of an item, out of which 10 were previously  committed, enter 20 in the **Attached**  column of the **Attach Quantity** dialog  box.


{:.see_also}
See also
: [Requested,  Credited and Committed Columns]({{site.sp_baseurl}}/sales-ret-docs/sales-ret-doc/contents/item-info/details/requested_committed_and_credited_columns_in_credit_orders.html)
: [Attaching  Committed Quantities]({{site.sp_baseurl}}/sales-ret-docs/cos/co-proc/cmt-items-to-co/attach-cmt-qty/attaching_committed_quantities_on_credit_order.html)
