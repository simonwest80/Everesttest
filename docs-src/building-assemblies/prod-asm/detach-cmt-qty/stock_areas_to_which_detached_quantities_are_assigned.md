---
title: Detach Committed Quantities - Stock Areas Assigned
---

# Detach Committed Quantities - Stock Areas Assigned


Items that are detached from a work order are assigned to a "Stock"  type of stock area.


![]({{site.ba_baseurl}}/img/lens.gif) [Stock  Area Types]({{site.sc_chm}}/options/miscellaneous-set-up/stock-areas/stock_area_types.html)


{:.steps}
To detach serialized quantities on a work order, do the following:

- From the Work Order  profile, highlight the serialized/auto-serialized item and select Options  > Item > Show Serial #. Right-click the Serial Number browser and  select Deserialize.



For Inventoried Non-serialized items

- From the **Work Order** profile, highlight the inventoried  item and select **Options** > **Attach/Retreive Serial #** > **Show/Attach Quantities**. Enter the reduced  number in the **Attached** column  in the **Attached** **Quantity**  dialog box.



For Non-inventoried items

- You can directly  enter the reduced quantity in the **Actual****Input** column in the **Work****Order** profile.



You can set a preference to move the detached inventoried items to another  stock area. This stock area is decided using the following logic:

- Use the stock  area defined in the **Select stock area 
 to receive back inventoried components of an assembly previously issued** field of the **Location** profile  (path: **File** > **Setup**  > **Accounting** > **Location**/**Sub-Location** > **Options**  > **Edit** > **In 
 New Window** > **Stock** **Transfer** > **Assembly 
 1** tab) for the login location.



![]({{site.ba_baseurl}}/img/lens.gif) [Location  Profile - Stock Transfer Tab]({{site.sc_chm}}/options/locations-and-sub-locations/set-up-locations/the_location_profile_stock_transfer.html)

- If a stock  area is not defined for the logged in location/sub-location, the stock  area assigned for the default location specified in the **Accounting**  dialog box (path: **File** > **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **Miscellaneous** tab > **Default Location** field) is used.



![]({{site.ba_baseurl}}/img/lens.gif) [Default  Location]({{site.sc_chm}}/misc/default_location.html)

- If this stock  area is not defined for the default location also, the stock area specified  in the **Purchase Receipt/Invoice** option  (path: **File** > **Setup**  > **Accounting** > **Location**/**Sub-Location**> **Options**  > **Edit** > **In 
 New Window** > **Stock** **Transfer** > **Purchase 
 Document** tab > **Select stock 
 area to transfer inventoried items when creating** section) for the  login location is used.
- If the stock  area is not specified for the login location, the stock area specified  for purchase receipts/invoices in the default location is used.



{:.see_also}
See also
: [Detaching  Quantities Committed]({{site.ba_baseurl}}/prod-asm/detach-cmt-qty/detaching_quantities_committed_from_the_work_order_building_assemblies.html)
