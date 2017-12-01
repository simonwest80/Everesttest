---
title: Detached Quantities - Stock Areas Assigned
---

# Detached Quantities - Stock Areas Assigned


Detached quantities are moved to the default stock area that is specified  in the **Workstation** **Settings**  or the stock transfer settings specified for the logged in location.


Items detached from a sales order are assigned to **Stock**  type of stock areas. This is because such stock continues to remain in  your ownership.


![]({{site.sp_baseurl}}/img/lens.gif)<font style="color: #800080;" color="#800080"> </font>[Stock  Areas]({{site.sc_chm}}/options/miscellaneous-set-up/stock-areas/stock_areas_setup.html)


The stock area to which detached quantities are assigned is determined  based on the following rules:

- If a default  stock area for unassigned items on a sales order is specified in **Workstation Settings** of the user detaching  the quantities (path: **File &gt; Setup 
 &gt; Preferences &gt; Workstation Settings &gt; Stock Areas &gt; For Sales** tab), the quantities are assigned to this stock area.



![]({{site.sp_baseurl}}/img/lens.gif) [Workstation  Settings - Stock Transfers]({{site.sc_chm}}/misc/work_station_settings_stock_areas_for_sales.html)

- If no default  stock areas are defined in **Workstation 
 Settings**, the items are assigned to the stock area defined for  unassigned items on sales orders in the **Location**  profile of the logged in location/sub-location (path: **File**  > **Setup** > **Accounting**  > **Location**/ **Sub-Location**  > **Options** > **Edit**  > **In New Window** > **Stock** **Transfer**  > **Sales** **Document**  tab).



![]({{site.sp_baseurl}}/img/lens.gif) [Location  Profile - Stock Transfers]({{site.sc_chm}}/misc/stock_transfer_information_sales_document.html)

- If default  stock areas are NOT defined in **Workstation 
 Settings** or the **Location**  profile, the item continues to remain in the stock area it was in, before  it was detached from the sales order<font style="color: #ff0000;" color="#FF0000">.</font><font style="color: #000000;" color="#000000"> </font>



{:.see_also}
See also
: [Detaching  Committed Quantities]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/detaching-items/detaching_committed_quantities.html)
