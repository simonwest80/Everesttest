---
title: Stock Transfer Information - Inventory Adjustment
---

# Stock Transfer Information - Inventory Adjustment


Select stock area to transfer inventory written off


**Inventory Adjustment**


When you write off an inventory item on account of loss or damages,  the item should also be removed from the stock area/bin where it is currently  stocked.


You can set an option for the automatic transfer of written-off inventoried  items to a specified stock area. Use this option to specify the stock  area for transferring such items. Items can be moved into stock areas  that are of type bin and not general level stock areas. When you create  an inventory adjustment document, the item is automatically transferred  to the default stock area in which the items are transferred using the  following rules:

- If a default  stock area for Inventory Adjustment is specified in the **Workstation****Settings** dialog box (path: **File** > **Setup**  > **Preferences** > **Work 
 Station Settings** > **Stock Areas**  > **Auto-serialize Items/Inventory Adjustments**),  the quantities are assigned to this stock area.
- If no default  stock areas are defined in the **Workstation****Settings** dialog box, the items  are assigned to the stock area defined for Inventory Adjustment (path:  **File** > **Setup** > **Accounting** > **Location/Sub-Location** > **Options** > **Edit** >  **In New Window** > **Stock 
 Transfer** > **Inventory Adjustment**  tab).



Select stock bin to transfer items in In-Transit State


**Stock Transfer Transit State**
: Specify the stock bin to temporarily hold transferred  stock during In-Transit state from the **Stock 
 Transfer In-Transit State** drop-down list. This stock bin should  belong to the origin location. When you specify an In-transit bin for  stock in this tab, the system automatically moves the item to this In-transit  bin during the stock transfer till the transfer is completed. When items  are held in the In-transit bin, the stock at the origin location shows  a decrease in available stock and the requesting location does not show  an increase in available stock. Inventory starts in origin, is moved to  In-transit bin of the origin location; and finally moves to the requesting  location.
: In-transit stock will be assigned to the stock transfer.  You can view the details of In Transit stock by double-clicking on the  SO column in the **Items** browser.  This browser will display both sales orders and stock transfers where  items have been assigned.
: When the status of the stock transfer is changed  to Completed (**Options** > **Process** > **Completed**  from the Stock Transfer profile), the items In transit are automatically  transferred to the To Bin specified in the stock transfer profile. The  Available stock in the origin location shows a decrease and the total  and available stock in the requesting location shows an increase in the  quantity transferred.


{:.see_also}
See also
: [Stock Transfer  Information]({{site.sc_baseurl}}/options/locations-and-sub-locations/location-details/stock-transfer-information/stock_transfer_information.html)
: [Stock Areas]({{site.sc_baseurl}}/options/miscellaneous-set-up/stock-areas/stock_areas_setup.html)
