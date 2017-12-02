---
title: Non-serialized Items
---

# Non-serialized Items


You can attach inventory contained in only 'stock' type of stock areas  to a sales order/invoice for positive quantities.


{:.steps}
To enter the committed quantity for a non-serialized,  inventoried item, do the following:

- From the **Sales Order/Sales Invoice** profile, click  on the required item in the item grid.
- Select **Options &gt; Attach/Retrieve Serial # &gt; 
 Show/Attach area wise stock**. You will see the [**Attach quantity for &lt;item name&gt;** dialog  box]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/cmt-items/enter-cmt-qty/non-ser/the_attach_quantity_profile.html).



{:.note}
The **Attach Quantity**  dialog box can also be displayed by double-clicking in the **Committed**  column. The profile is displayed if the option 'Use Default Stock area  to assign quantity for non-serialized items in sales documents' is not  selected in **Location** profile.  All 'Stock' type of stock areas will be listed. For negative quantities,  this profile lists all 'Out' type of stock areas.


Adding to Items Committed


Additional items may be committed by entering the new quantity committed.  The additional quantity will be assigned to the stock area to which other  items have been committed.


![]({{site.sp_baseurl}}/img/example.gif) If  you now want to commit 20 items of an item out of which 10 were previously  committed, enter 20 in the **Attached**  column of the **Attach Quantity** dialog  box.


{:.see_also}
See also
: [Ordered,  Committed and Received columns]({{site.sp_baseurl}}/sales-docs/docs-profile/contents/item-info/details/ordered_committed_and_shipped_columns_in_sales_orders.html)
: [Entering  Committed Quantities]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/cmt-items/enter-cmt-qty/entering_committed_quantities.html)
