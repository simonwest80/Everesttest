---
title: Stock Area to which Components Utilized are Transferred
---

# Stock Area to which Components Utilized are Transferred


Inventoried items used during production lose their individual identity.  The items consumed must be transferred to an 'OUT' type of stock area  as these items can no longer be available for use or sale.


You can define another stock area to transfer these inventoried items  to using the following logic:

- Use the stock  area defined in the **Select stock area 
 to transfer inventoried components of completed assembly items** field  of the **Location** profile (path:  **File &gt; Setup &gt; Accounting &gt; 
 Location/Sub-Location &gt; Options &gt; Edit &gt; In New Window &gt; Stock 
 Transfer &gt; Assembly 1** tab) for the login  location.



**![]({{site.ba_baseurl}}/img/lens.gif) [Location  Profile - Stock Transfer Tab]({{site.sc_chm}}/options/locations-and-sub-locations/set-up-locations/the_location_profile_stock_transfer.html)**

- If a stock  area is not defined for the logged in location/sub-location, the stock  area assigned for the default location in the **Accounting**  dialog box (path: **File** > **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **Miscellaneous** tab > **Default Location** field) is used.



**![]({{site.ba_baseurl}}/img/lens.gif) [Default  Location]({{site.sc_chm}}/misc/default_location.html)**

- If it is not  defined for the default location also, the stock area specified in the  **Sales Invoice** option (path: **File** > **Setup**  > **Accounting** > **Location**/**Sub-Location**> **Options**  > **Edit** > **In 
 New Window** > **Stock** **Transfer** > **Sales 
 Document** tab > **Select stock 
 area to transfer inventoried items when creating** section) for the  login location  is used.
- If it is not  specified for the login  location, the stock area specified for sales invoices in the default location  is used.



{:.see_also}
See also
: [Stock  Status of Assembly Components]({{site.ba_baseurl}}/prod-asm/building-wo/entering-qty-built/back-proc/asm-items/asm-cmpts/stock_status_of_assembly_components.html)
