---
title: Stock Area to Which Detached Quantities are Assigned
---

# Stock Area to Which Detached Quantities are Assigned


The stock area to which detached quantities for **debit 
 orders** are assigned is determined by the following rules:

- If a default  stock area for detached quantities is specified in the **Workstation 
 Settings** dialog box (path: **File 
 &gt; Setup &gt; Preferences &gt; Workstation Settings &gt; Stock Areas 
 &gt; For Purchase** tab > **Unassign 
 Inventory to** section > **Debit 
 Order**), the quantities are assigned to this stock area.
- If a default  stock area is not defined in the **Workstation 
 Settings** dialog box, the items are assigned to the stock area defined  for detached quantities in the **Location**  profile (path: **File** > **Setup** > **Accounting**  > **Location**/**Sub-Location**>  **Options** > **Edit** > **In New Window &gt; Stock****Transfer** > **Purchase** **Document** tab >  **Select stock area to transfer inventoried 
 items into when un-assigning** section **&gt; 
 Debit Order** field) of the logged in location/ sub-location.
- If the stock area is not defined in the login  location also, the items continue to remain in the stock area from which  the items are attached/assigned.


{:.note}
The **Stock 
 Area** field displays in the status bar when you need to select a  stock area. Select a stock area and press the **Enter**  key or **ESC** key to exit this field  and continue.



{:.see_also}
See also
: [Stock  Transfers]({{site.sc_chm}}/misc/stock_transfer_information_purchase_document.html)
: [Workstation  Settings Dialog Box - For Purchases Tab]({{site.sc_chm}}/misc/work_station_settings_stock_areas_for_purchase.html)
