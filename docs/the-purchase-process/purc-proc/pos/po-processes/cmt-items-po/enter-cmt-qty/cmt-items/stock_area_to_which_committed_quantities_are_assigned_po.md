---
title: Stock Area to Which Committed Quantities are Assigned
---

# Stock Area to Which Committed Quantities are Assigned


The committed items on a **purchase order** are assigned to an 'Out' type of stock area. This stock will not  be available for sale or use until you receive them on a purchase receipt.


![]({{site.pp_baseurl}}/img/lens.gif) [Stock  Areas]({{site.sc_chm}}/options/miscellaneous-set-up/stock-areas/stock_areas_setup.html)


The stock area to which committed quantities are assigned is determined  by the following rules:

- If you specify  a default stock area for purchase orders in the **Purchase****Order** field of the **Work**s**tation Settings** dialog box (path: **File &gt; Setup &gt; Preferences &gt; Workstation 
 Settings** > **Stock** **Areas** > **For****Purchase** tab **&gt; Assign inventory to/from** section **&gt; Purchase Order** field), the quantities are assigned to this  stock area.
- If you do not  define a default stock area in **Workstation****Settings**, the items are assigned  to the stock area defined in the **Purchase****Order** field (path: **File**  > **Setup** > **Accounting**  > **Location**/ **Sub-Location** > **Options** > **Edit** > **In****New** **Window**  > **Stock** **Transfer**  > **Purchase** **Document**  tab > **Select stock areas** **to transfer inventoried items into when assigning** section) for the login location/sub-location.
- If the stock  area is not defined in the login location, the items are assigned to the  stock area for purchase orders defined for the default location. The default  location is specified in the **Accounting** dialog box (path: **File**  > **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **Miscellaneous** tab > **Default Location** field).



{:.note}
- The stock area  to which additional committed quantities, are assigned on a purchase order  is the same for a document, irrespective of the workstation settings or  flow control settings while committing the quantities.
- The **Stock 
 Area** field displays in the status bar when you need to select a  stock area. Select a stock area and press the **Enter**  key or **ESC** key to exit this field  and continue.


{:.example}
You commit 10 quantity of Item 1 on purchase  order #10012, and the stock area determined is "Vendor Shipments  Expected". You save the order and then change workstation settings  for purchase orders to "Inspection of Vendor Shipments". If  you reopen order #10012 and commit 5 quantity of Item 2, the stock area  assigned continues to be "Vendor Shipments Expected". However,  if you commit quantities on a purchase order on which no items are committed,  the stock area "Inspection of Vendor Shipments" is used.


{:.see_also}
See also
: [Stock  Transfers]({{site.sc_chm}}/misc/stock_transfer_information_purchase_document.html)
