---
title: Back End Processes - Cancel a Work Order
---

# Back End Processes - Cancel a Work Order


The back end processes that occur when a work order is cancelled are:

- The items committed  to the work order are detached if you choose to do so during the cancellation  process.



![]({{site.ba_baseurl}}/img/lens.gif) [Detach  Quantities Committed to a Work Order]({{site.ba_baseurl}}/prod-asm/detach-cmt-qty/detaching_quantities_committed_from_the_work_order_building_assemblies.html)

- The ‘Reserve’  column decreases in the [**Item Stock Status** dialog box]({{site.mi_chm}}/misc/the_item_stock_status_dialog_box.html) by  the standard input. The ‘Reserve Commit’  column of the item decreases by the quantity committed on the cancelled  work order.
- An accounting  entry is generated reversing the initial entry for work-in-process.
- The items in  the Work In Process stock area are moved to the stock area defined for  receiving back items issued on a work order. This stock area is decided  using the following logic:


- Use the stock area  defined in the **Select stock area to receive 
 back inventoried components of assembly previously issued on a work order**  field of the **Location** profile  (path: **File** > **Setup**  > **Accounting** > **Location**/**Sub-Location** > **Options**  > **Edit** > **In****New** **Window**  > **Stock** **Transfer**  > **Assembly 1** tab) for the login  location/sub-location.



![]({{site.ba_baseurl}}/img/lens.gif) [Location  Profile - Stock Transfer Tab]({{site.sc_chm}}/options/locations-and-sub-locations/set-up-locations/the_location_profile_stock_transfer.html)

- If a stock area is  not defined for the logged in location/sub-location, the stock area assigned  for the default location in the **Accounting**  dialog box (path: **File** > **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **Miscellaneous** tab > **Default Location** field) is used.



![]({{site.ba_baseurl}}/img/lens.gif) [Default  Location]({{site.sc_chm}}/misc/default_location.html)

- If this stock area  is not defined for the default location also, the stock area specified  in the **Purchase Receipt/Invoice** option  (path: **File** > **Setup**  > **Accounting** > **Location**/**Sub-Location** > **Options**  > **Edit** > **In 
 New Window** > **Stock** **Transfer** > **Purchase 
 Document** tab > **Select stock 
 area to transfer inventoried items when creating** section) for the  login location  is used.
- If the stock area  is not specified for the login  location, the stock area specified for purchase receipts/invoices in the  default location is used.



{:.see_also}
See also
: [Cancel  a Work Order]({{site.ba_baseurl}}/prod-asm/cancelling-wo/cancel_a_work_order_work_order_profile_options_process_cancel_assembly.html)
