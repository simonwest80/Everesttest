---
title: Deleted Items - Stock Areas Assigned
---

# Deleted Items - Stock Areas Assigned


You can set a preference to move the inventoried item to another stock  area once the item is removed (detached) from a work order. This stock  area is decided using the following logic:

- Use the stock  area defined in the **Select stock area 
 to receive back inventoried components of assembly previously issued on 
 a work order** field of the **Location** profile (path: **File** >  **Setup** > **Accounting**  > **Location/Sub-Location** >  **Options** > **Edit**  > **In New Window** > **Stock Transfer** > **Assembly 
 1** tab) for the login location/sub-location.



**![]({{site.ba_baseurl}}/img/lens.gif) [Location  Profile - Stock Transfer Tab]({{site.sc_chm}}/options/locations-and-sub-locations/set-up-locations/the_location_profile_stock_transfer.html)**

- If a stock  area is not defined for the logged in location/sub-location, the stock  area assigned for the default location in the **Accounting**  dialog box (path: **File** > **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **Miscellaneous** tab > **Default Location** field) is used.



**![]({{site.ba_baseurl}}/img/lens.gif) [Default  Location]({{site.sc_chm}}/misc/default_location.html)**

- If this stock  area is not defined for the default location also, the stock area specified  in the **Purchase Receipt/Invoice** option  (path: **File** > **Setup**  > **Accounting** > **Location**/**Sub-Location** > **Options**  > **Edit** > **In 
 New Window** > **Stock** **Transfer** > **Purchase 
 Document** tab > **Select stock 
 area to transfer inventoried items when creating** section) for the  login location is used.
- If the stock  area is not specified for the login location, the stock area specified  for purchase receipts/invoices in the default location is used.



{:.see_also}
See also
: [Delete  Items From a Work Order]({{site.ba_baseurl}}/prod-asm/creating-wo/wo-details/item-dtls/del-items-from-wo/delete_items_from_a_work_order.html)
