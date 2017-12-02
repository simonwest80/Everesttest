---
title: Stock Area to which Built Items are Transferred
---

# Stock Area to which Built Items are Transferred


You can define a stock area for transferring assembled item using the  following logic:

- Use the stock  area specified in the **Select stock area 
 to receive completed assembly items** field of the Location profile  (path: **File** > **Setup** > **Accounting** > **Location/Sub-Location** > **Options** > **Edit** > **In 
 New Window** > **Stock Transfer** > **Assembly 1** tab) for  the login location.



**![]({{site.ba_baseurl}}/img/lens.gif) [Location  Profile - Stock Transfer Tab]({{site.sc_chm}}/options/locations-and-sub-locations/set-up-locations/the_location_profile_stock_transfer.html)**

- If the stock  area is not defined for the login location, then the stock area for the  default location in the **Accounting** dialog  box (path: **File** > **Setup**  > **Preferences** > **Defaults**  > **Accounting** > **Miscellaneous**  tab > **Default Location** field)  is used.



**![]({{site.ba_baseurl}}/img/lens.gif) [Default  Location]({{site.sc_chm}}/misc/default_location.html)**

- If it is not  defined for the default location also, the stock area specified in the  **Purchase Receipt/Invoice** option  (path: **File** > **Setup**  > **Accounting** > **Location**/**Sub-Location** > **Options**  > **Edit** > **In 
 New Window** > **Stock** **Transfer** > **Purchase****Document** tab > **Select 
 stock area to transfer inventoried items when creating** section)  for the login location is used.
- If it is not  specified for the login location, the stock area specified for purchase  receipts/invoices in the default location is used.



{:.see_also}
See also
: [Stock  Status of Built Items]({{site.ba_baseurl}}/prod-asm/building-wo/entering-qty-built/back-proc/asm-items/set_stock_area_completed_assembly.html)
: [Back  End Process - Assembled Items]({{site.ba_baseurl}}/prod-asm/building-wo/entering-qty-built/back-proc/asm-items/backend_process_assemblied_items.html)
: [Build  a Work Order]({{site.ba_baseurl}}/prod-asm/building-wo/building_work_orders_content_building_assembly.html)
