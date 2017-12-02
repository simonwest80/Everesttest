---
title: Detached Quantities - Stock Areas Assigned
---

# Detached Quantities - Stock Areas Assigned


Detached quantities are moved to the default stock area that is specified  in the **Workstation** **Settings**  or the stock transfer preferences specified for the login  location.


Stock areas to which items detached from a credit order are assigned,  are **Out** type of stock areas. This  is because you still do not own the stock returned to you.


![]({{site.sp_baseurl}}/img/lens.gif)<font style="color: #800080;" color="#800080"> </font>[Stock  Areas]({{site.sc_chm}}/options/miscellaneous-set-up/stock-areas/stock_areas_setup.html)


The stock area to which detached quantities are assigned is determined  by the following rules:

- If a default  stock area for unassigned items on credit orders is specified in the **Workstation Settings** dialog box (path:  **File &gt; Setup &gt; Preferences &gt; 
 Workstation Settings &gt; Stock Areas &gt; For Sales** tab), the  quantities are assigned to this stock area.
- If no default  stock area is defined in **Workstation****Settings**, the items are assigned  to the stock area defined for unassigned items on credit orders in the  logged in location or sub-location (path: **File 
 &gt; Setup &gt; Accounting &gt; Location/Sub-Location &gt; Options &gt; 
 New &gt; Location &gt; In New Window &gt; Stock Transfer &gt; Sales Document** tab). If no stock area is defined for logged in location or sub-location,  the stock area defined for the default location is used.

: ![]({{site.sp_baseurl}}/img/lens.gif) [Default  Location]({{site.sc_chm}}/misc/default_location.html)

- If no default  stock areas for unassigned items on credit orders are defined in **Workstation Settings** or in stock transfer  preferences of the login  location as above, the default stock area defined for **Sales 
 Invoices** in the **Workstation Settings** (path: **File &gt; Setup &gt; Preferences 
 &gt; Workstation Settings &gt; Stock Areas &gt; For Sales** tab)  is used.
- If no default  stock area for unassigned credit orders is defined in the **Workstation 
 Settings** dialog box or the logged in location and no default stock  area for **Sales invoices** is defined  in **Workstation Settings** dialog  box, the items are assigned to the stock area defined for sales invoices  in the logged in location or sub-location (path: **File 
 &gt; Setup &gt; Accounting &gt; Location/Sub-Location** > **Options &gt; Edit &gt; In New Window** >  **Stock** **Transfer**  > **Sales** **Document**  tab). If no stock area is defined for the logged in location or sub-location,  the stock area defined for the default location is used.



![]({{site.sp_baseurl}}/img/lens.gif) [Location  profile >Stock Transfers]({{site.sc_chm}}/misc/stock_transfer_sales_document.html)


[Workstation  Settings – Stock Transfers]({{site.sc_chm}}/misc/work_station_settings_stock_areas_for_purchase.html)


{:.see_also}
See also
: [Detaching  Committed Quantities]({{site.sp_baseurl}}/sales-ret-docs/cos/co-proc/detach-items/detaching_committed_quantities_co.html)
