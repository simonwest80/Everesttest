---
title: Inventoried Items
---

# Inventoried Items


Inventoried items are assigned to an "In" type of stock area  when they are received on a purchase receipt. The default stock area in  which the items are received is determined using the following rules:

- If a default  stock area for purchase receipts is specified in the **Workstation 
 Settings** dialog box (path: **File**  > **Setup** > **Preferences**  > **Workstation** **Settings**  > **Stock** **Areas**  > **For** **Purchase** tab **&gt; Transfer Inventory to** section **&gt; Purchase Receipt**  field), then the quantities are assigned to this stock area.
- If a default  stock areas is not defined in the **Workstation 
 Settings** dialog box, then the items are assigned to the stock area  defined for the login location (path: **File**  > **Setup** > **Accounting**  > **Location**/**Sub-Location**  > **Options** > **Edit**  > **In New Window** > Stock  Transfer **** > **Purchas**ing  tab > **Select Stock Area to transfer 
 inventoried items into when creating** section > **Receipt**).
- If the stock  area is not defined for the login location, then the items are assigned  to the stock area defined for purchase receipts in the default location.  The default location is specified in the **Accounting**  dialog box (path: **File** > **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **Miscellaneous** tab > **Default Location** field).



{:.note}
You can set a preference to **Use 
 default stock area for receiving items** (path: **File**  > **Setup** > **Accounting**  > **Location**/**Sub-Location**  > **Options** > **Edit****&gt; In New Window** > **Stock** **Transfer**  > **Miscellaneous** tab). If this  option is selected, then you will not be prompted with the **Assign****Quantity** dialog box to assign  quantities to stock areas. If this option is not selected, then the **Assign** **Quantity**  dialog box is displayed.


{:.see_also}
See also
: [Workstation  Settings - Stock Areas]({{site.sc_chm}}/misc/work_station_settings_stock_areas_for_purchase.html)
