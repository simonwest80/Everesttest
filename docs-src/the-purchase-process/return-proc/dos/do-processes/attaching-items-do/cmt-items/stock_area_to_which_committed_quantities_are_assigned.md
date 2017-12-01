---
title: Stock Area to Which Committed Quantities are Assigned
---

# Stock Area to Which Committed Quantities are Assigned


The committed items on a **debit order** are assigned to the ‘Stock’ type of stock area. They continue to  remain in your ownership<font style="color: #0000ff;" color="#0000FF">. </font>


![]({{site.pp_baseurl}}/img/lens.gif) [Stock  Areas]({{site.sc_chm}}/options/miscellaneous-set-up/stock-areas/stock_areas_setup.html)


The stock area to which committed quantities are assigned is determined  by the following rules:

- If you specify  a default stock area for debit orders in the **Workstation Settings** dialog box (path: **File 
 &gt; Setup &gt; Preferences &gt; Workstation Settings &gt; Stock Areas 
 &gt; For Purchase &gt; Assign Inventory to/from** section **&gt; 
 Debit Order**), the quantities are assigned to this stock area.
- If you do not  specify a default stock area in the **Workstation 
 Settings** dialog box, the items are assigned to the stock area defined  in the **Location** profile (path:  **File** > **Setup**  > **Accounting** > **Location**/  **Sub-Location** > **Options 
 &gt; Edit &gt; In New Window &gt; Stock** **Transfer**  > **Purchase** **Document**  tab > **Select stock area to transfer 
 inventoried items into when assigning** section > **Debit 
 Order**) of the logged in location/ sub-location.



![]({{site.pp_baseurl}}/img/lens.gif) [Location  Profile]({{site.sc_chm}}/options/locations-and-sub-locations/set-up-locations/location_profile_purchasing.html)

- If the stock  area is not defined for the logged in location also, the items will continue  to remain in the stock area from which they are committed.



{:.note}
The stock area to which committed quantities are assigned  on a debit order is the same for a document, irrespective of the workstation  settings or flow control settings when committing the quantities.


{:.example}
You commit quantities on Item 1 of debit order  #10012, and the stock area determined is 'Vendor Returns Expected'. You  save the order and then change workstation settings for debit orders to  'Vendor RMA'. If you reopen order #10012 and commit quantities for Item  2, the stock area assigned continues to be 'Vendor Returns Expected'.  However, if you commit quantities on a purchase order on which no items  are committed, the stock area used is 'Vendor RMA'.
