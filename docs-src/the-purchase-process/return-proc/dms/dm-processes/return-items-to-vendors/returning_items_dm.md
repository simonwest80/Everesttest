---
title: Return Items to Vendors
---

# Return Items to Vendors


When returns on an existing order are processed to a debit memo, the  **Requested** column for an item displays  the quantity requested at the time of conversion. The **Debited**  column in the memo displays the quantity committed on order, if any. If  quantities are not committed, it displays the quantity requested and not  debited. If you select the option **Set 
 the quantity received value to zero when converting a purchase order/debit 
 order to a purchase invoice/debit memo** (path: **File 
 &gt; Setup &gt; Preferences &gt; Flow Control &gt; Documents &gt; Miscellaneous 
 &gt; Others &gt; Others 1** tab), this column defaults to zero.


{:.note}
This option works only for auto-serialized and inventoried (non-serialized)  items.


For serialized items,  the  shipped column always displays 'zero'.


If you create a debit memo directly, the **Requested**  column defaults to zero. Enter the quantity being returned in the **Debited** column.


{:.see_also}
See also
: [Enter  Returned Quantity - Serialized Items]({{site.pp_baseurl}}/return-proc/dms/dm-processes/return-items-to-vendors/entering_item_quantities_returned_serialized_items_dm.html)
: [Enter  Returned Quantity - Non-Serialized Items]({{site.pp_baseurl}}/return-proc/dms/dm-processes/return-items-to-vendors/entering_quantities_returned_non_serialized_items_dm.html)
: [Enter  Returned Quantity - Non-Inventoried Items]({{site.pp_baseurl}}/return-proc/dms/dm-processes/return-items-to-vendors/entering_quantities_returned_non_inventoried_items_dm.html)
