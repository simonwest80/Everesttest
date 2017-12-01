---
title: Shipped Items - Stock Area Assigned
---

# Shipped Items – Stock Area Assigned


Inventoried items are assigned to an 'Out'  stock area on shipment.


The default stock area to which the items shipped on the sales invoice  are transferred is determined by the following rules:

- A default stock  area is specified in the **Sales Invoice**  field of the **Workstation Settings** dialog  box (path: **File &gt; Setup &gt; Preferences 
 &gt; Workstation Settings &gt; Stock Areas &gt; For Sales** tab)  of the user creating the sales invoice.
- If no default  stock areas are defined in the **Workstation 
 Settings**, the items are transferred to the stock area defined for  sales invoices in the logged in location or sub-location (path: **File &gt; Setup &gt; Accounting &gt; Location/Sub-Location 
 &gt; Options** > **New** >  **Locations** > **In 
 New Window** **&gt; Stock Transfer 
 &gt; Sales Document** tab).
- If no stock  area is defined for the logged in location or sub-location, the stock  area defined for the default location is used.



{:.see_also}
See also
: [Location  Profile - Stock Transfers]({{site.sc_chm}}/options/locations-and-sub-locations/set-up-locations/the_location_profile_stock_transfer.html)
: [Workstation  Settings Dialog Box - Stock Transfers - For Sales tab]({{site.sc_chm}}/misc/work_station_settings_stock_areas_for_sales.html)
