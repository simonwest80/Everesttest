---
title: Back End Processes - Commit Items on a Purchase Order
---

# Back End Processes - Commit Items on a Purchase Order


When items are committed to a purchase order the following back end  processes occur:

- The stock status  of the item as viewed in the **Item****Stock** **Status**  dialog box displays the following changes:



**Item Stock 
 Status**


| Column | **Stock** **Increase**/**Decrease** |
| On Order Committed | Increase |



![]({{site.pp_baseurl}}/img/lens.gif) [Item  Stock Status]({{site.mi_chm}}/misc/columns_in_the_item_stock_status_dialog_box.html)


****Stock Area 
 Details****


| **Column** | **Stock Increase/Decrease** |
| On Order | Increase in the ‘out’ stock area to which the item  has been assigned. |



![]({{site.pp_baseurl}}/img/lens.gif) [Stock  Area Details]({{site.mi_chm}}/misc/stock_status_details_section.html)

- If the item is  serialized/auto-serialized, serial numbers are generated for the quantities  committed and assigned to the stock area determined for the purchase order  when you save the document.
- Serial numbers  are generated in a series that starts from the next serial number assigned  in the **Location** profile (path:  **File** > **Setup**  > **Accounting** > **Location**/**Sub-Location**> **Options**  > **Edit** > **In 
 New Window**) for the login location or location of the login location/sub-location.  If the serial number for the login location/sub-location is blank, the  next serial number assigned for the **Default 
 Location** (path: **File** >  **Setup** > **Preferences**  > **Defaults** > **Accounting**)  is used.



![]({{site.pp_baseurl}}/img/lens.gif) [Entering  Quantities Committed]({{site.pp_baseurl}}/purc-proc/pos/po-processes/cmt-items-po/enter-cmt-qty/entering_quantities_committed.html)


{:.see_also}
See also
: [Location/Sub-location  - Sequence Numbers]({{site.sc_chm}}/misc/sequence_numbers_departments.html)
: [Default  Location]({{site.sc_chm}}/misc/default_location.html)
: [View Serial  Numbers]({{site.pp_baseurl}}/purc-proc/pos/po-processes/cmt-items-po/enter-cmt-qty/viewing_serial_numbers.html)
