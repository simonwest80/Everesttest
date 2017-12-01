---
title: Returned Items - Stock Areas Assigned
---

# Returned Items - Stock Areas Assigned


Inventoried items are assigned to a **Stock**  type of stock area when goods are returned. This process depends on two  factors:

- Whether the  credit memo is newly created.
- Whether the  credit memo is converted from a credit order.



**On a New Credit Memo**


Based on the type of item, and the **'Use 
 default out stock area to assign quantity for non-serialized items in 
 credit order or credit memo'** AND **'Use 
 default stock area to receive items when creating a new credit memo'** **** options (path: **File 
 &gt; Setup &gt; Accounting &gt; Locations/Sub-Location &gt; Options &gt; 
 Edit &gt; In New Window &gt; Stock Transfer &gt; Miscellaneous**  tab), the **Attach Quantity** and  **Assign** **Quantity**  profiles are/are not displayed. You can first attach quantity from an  **Out** type of stock area from the  **Attach** **Quantity**  profile. Then, you can assign committed quantities to a **Stock** type of stock area from the **Assign 
 Quantity** profile.


When a Credit Order has been converted to a Credit  Memo

- When items  are NOT committed at the credit order stage, based on the type of item  and the **'Use default out stock area 
 to assign quantity for non-serialized items in credit order or credit 
 memo'** option (path: **File &gt; 
 Setup &gt; Accounting &gt; Locations/Sub-Location &gt; Options &gt; Edit 
 &gt; In New Window &gt; Stock Transfer &gt; Miscellaneous** tab),  the **Assign** **Quantity**  profile is/is not displayed. You can assign quantity to a **Stock**  type of stock area from this profile.



Display of the Attach Quantity Profile (based on the  **'Use default out 
 stock area to assign quantity for non-serialized items in credit order 
 or credit memo'** option)


![]({{site.sp_baseurl}}/img/lens.gif) [Display  of the Attach Quantity Profile (based on the preference selected)]({{site.sp_baseurl}}/sales-ret-docs/cos/co-proc/cmt-items-to-co/attach-cmt-qty/committed/committed_quantities_stock_area_assigned_co.html#display_of_the_attached_quantity_profile)


Display of the Assign Quantity Profile (based on the  **'Use default stock 
 area to receive items when creating a new credit memo'**  option)


| **Item type** | **If the preference is <br/> checked** | **If the preference is <br/> unchecked** |
|  | **Assign Quantity profile <br/> is displayed** |
| Non-serialized item not tracked for lots | No | Yes |
| Non-serialized item tracked for lots | No | Yes |
| Auto serialized item | No | Yes |
| Serialized item | No | Yes |



The default stock area to which the items returned on a credit memo  are transferred is determined using the following rules:

- If a default  stock area for transferring items returned on credit memos is specified  in the **Credit Memos** field of the  **Workstation Settings** dialog box  (path: **File &gt; Setup &gt; Preferences 
 &gt; Workstation Settings &gt; Stock Areas &gt; For Sales** tab),  the quantities are transferred to this stock area.
- If no default  stock areas are defined in the **Workstation 
 Settings** dialog box, the items are transferred to the stock area  defined for **Credit Memos** in the  logged in location or sub-location<font style="color: #ff0000;" color="#FF0000"> </font>(path: **File &gt; Setup &gt; Accounting &gt; Location/Sub-Location 
 &gt; Options &gt; Edit &gt; In New Window** > **Stock 
 Transfer &gt; Sales Document** tab). If no stock area is defined  for the logged in location or sub-location, the stock area defined for  the default location is used.



{:.see_also}
See also
: [Locations  - Stock Transfers]({{site.sc_chm}}/options/locations-and-sub-locations/set-up-locations/the_location_profile_stock_transfer.html)
: [Workstation  Settings - Stock Areas - For Purchase tab]({{site.sc_chm}}/misc/work_station_settings_stock_areas_for_purchase.html)
: [Workstation  Settings - Stock Areas - For Sales Tab]({{site.sc_chm}}/misc/work_station_settings_stock_areas_for_sales.html)
