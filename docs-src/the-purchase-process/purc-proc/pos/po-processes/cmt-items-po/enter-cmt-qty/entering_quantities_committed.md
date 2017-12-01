---
title: Enter Quantities Committed
---

# Entering Quantities Committed


Enter the quantity committed in the **Committed**  column of the **Item Details Grid**.  The committed quantities are assigned to an 'out' type of stock area.


{:.note}
An entry can be made in the **Committed**  column only for inventoried items. In the case of a non-inventoried line  item, this column displays a cross mark.


**Serialized Items**


If the item is serialized/auto-serialized, serial  numbers are generated for the quantities committed. Serial numbers are  generated in a series that starts from the next serial number specified  for the logged in location or location of the logged in location/sub-location.  This series is specified in the **Location** profile (path: **File** >  **Setup** > **Accounting**  > **Location**/**Sub-Location**  > **Options** > **Edit**  > **In** **New****Window &gt; Inventory** tab).


If the serial number is not specified for the logged in location or  sub-location, then the next serial number specified for the **Default 
 Location** (path: **File** >  **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **Miscellaneous**) is used.


{:.note}
An entry can be made in the Committed column only for  inventoried items. In the case of a non-inventoried line item, this column  displays a cross mark.


The quantity committed on a purchase order cannot exceed  the quantity orders.


When you attach a serial number of an item that is not  present on the document, you are prompted that the item does not exist  on the document. To attach the item to the document click **Yes**.  This prompt will be displayed only if you select the **Prompt 
 when trying to retrieve and serialize an item that is not present on a 
 document** option (path: **File**  > **Setup** > **Preferences**  > **Flow** **Control**  > **Documents** > **Miscellaneous**  > **Others - Others 2**tab).


{:.see_also}
See also
: [Sequence  Numbers]({{site.sc_chm}}/misc/sequence_numbers_departments.html)
: [Default  Location/Sub-Location]({{site.sc_chm}}/misc/default_location.html)
: [Stock  Area to Which Committed Quantities are Assigned]({{site.pp_baseurl}}/purc-proc/pos/po-processes/cmt-items-po/enter-cmt-qty/cmt-items/stock_area_to_which_committed_quantities_are_assigned_po.html)
