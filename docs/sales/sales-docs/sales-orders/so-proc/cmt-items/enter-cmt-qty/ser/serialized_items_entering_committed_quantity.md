---
title: Serialized Items
---

# Serialized Items


Serial numbers of the item to be attached to the sales order or invoice  may be retrieved in any of the following ways:

- [One  by one]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/cmt-items/enter-cmt-qty/ser/retrieving_individual_serial_numbers.html)
- [As  a range]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/cmt-items/enter-cmt-qty/ser/retrieving_a_range_of_serial_numbers.html)
- [By  manufacturer's serial number]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/cmt-items/enter-cmt-qty/ser/retrieving_manufacturer_s_serial_number.html)



**Everest** allows you to select  serial numbers from stock areas for the logged in location if you select  the **Allow Users to access only those 
 stock areas in the logged in location** check box (path: **File 
 &gt; Set up &gt; Preferences &gt; Flow Control &gt; Other Flow Control 
 &gt; General** tab).


{:.note}
When you attach a serial number of an item not present  on the sales order or invoice, you are prompted with a message asking  you whether you want to serialize the item that does not exist on the  order. Click **Yes** to attach the  item on the order or invoice.


This prompt is received if the option **Prompt 
 when trying to retrieve and serialize an item that is not already present 
 in a document** (path: **File &gt; 
 Setup &gt; Preferences &gt; Flow Control &gt; Documents &gt; Miscellaneous 
 &gt; Others &gt; Others 2** tab) is selected.


If you retrieve the same item more than once into a document, and retrieve  or scan a range of serial numbers into the system, the serial numbers  are first assigned to the highlighted line item in the Item Details Grid.  Additional serial numbers are attached to the remaining line items.


| ![]({{site.sp_baseurl}}/img/example.gif) | The item details contained in sales order # 1001 is  detailed below:<br/><br/><br/>| **Line #** | **Item Code** | **Quantity Column** |<br/>| 1 | NESDESSERT | 2 |<br/>| 2 | NESCHOC | 1 |<br/>| 3 | NESDESSERT | 3 |<br/><br/><br/><br/>If you scan serial numbers 1, 2, 3, 4 and 5 while line  #1 is selected, serial numbers 1 and 2 are assigned to line 1 while the  remaining are assigned to line 3. If the serial numbers are scanned into  the system when line 3 is selected, serial numbers 1, 2 and 3 are assigned  to line 3 while the remaining are assigned to line 1. |



If you scan additional serial numbers, for example, 6 and 7, into the  system, **Everest** asks you if the  serial numbers have to be committed to the order. If you confirm this,  the additional serial numbers are attached to the selected line item.

###### {:.see_also}
See also
: [Ordered,  Committed and Received columns]({{site.sp_baseurl}}/sales-docs/docs-profile/contents/item-info/details/ordered_committed_and_shipped_columns_in_sales_orders.html)
: [Serial Number  History]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/cmt-items/enter-cmt-qty/serial_number_history.html)
