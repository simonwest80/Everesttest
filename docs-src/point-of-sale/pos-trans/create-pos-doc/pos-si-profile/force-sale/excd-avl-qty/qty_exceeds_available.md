---
title: Quantity Brought to the Cash Counter Exceeds the Quantity Available
---

# Quantity Brought to the Cash Counter Exceeds the Quantity Available


Quantity Available


Quantity available refers to the net free stock available in the default  stock area if you select the **Use default 
 stock area to assign quantity for non-serialized items in sales documents**  check box in the **Location** profile  (path: **File &gt; Setup &gt; Accounting 
 &gt; Location/Sub-Location &gt; Options &gt; Edit &gt; In New Window &gt; 
 Stock Transfer &gt; Miscellaneous** tab).


If you do not select this check box in the **Location**  profile, the quantity available refers to the free stock for the item  in all locations.


![]({{site.pos_baseurl}}/img/lens.gif) [The  Location Profile - Stock Transfer - Miscellaneous]({{site.sc_chm}}/misc/stock_transfer_miscellaneous.html)


Net Free Stock


Net free stock is defined in the **Items**  dialog box (path: **File &gt; Setup &gt; 
 Preferences &gt; Flow Control &gt; Items &gt; Net Free Stock** tab).


![]({{site.pos_baseurl}}/img/lens.gif) [Items  Dialog Box]({{site.mi_chm}}/misc/the_flow_control_setup_dialog_box_net_free_stock_mi.html)


Free Stock


Free stock refers to the stock that is free for sale or use after all  items committed on sales and debit orders are accounted for.


![]({{site.pos_baseurl}}/img/lens.gif) [Columns  in the Item Stock Status Dialog box]({{site.mi_chm}}/misc/columns_in_the_item_stock_status_dialog_box.html)


Default Stock Area


During the sales process, while committing  quantities,  the default stock area is determined by the following rules:

- If a default  stock area for sales orders is specified in the **Assign 
 inventory from &gt; Sales Order** field of the **Workstation 
 Settings** of the user committing the quantities (path: **File &gt; Setup &gt; Preferences &gt; WorkStation 
 Settings &gt; Stock Areas &gt; For Sales** tab), the quantities are  assigned to this stock area.
- If no default  stock areas are defined in **Workstation 
 Settings**, the items are assigned to the stock area defined for  sales orders in the login location or the parent location of the login  sub-location (path: **File &gt; Setup &gt; 
 Accounting &gt; Location/Sub-Location &gt; Options &gt; Edit &gt; In New 
 Window &gt; Stock Transfer &gt; Sales Document** tab). If no stock  area is defined in the **Location**  profile, the stock area defined for the default location is used.
- If no default  stock areas for sales orders are defined in **Workstation 
 Settings** or in the stock transfer preferences for the logged in  location as above, the default stock area defined for **Purchase 
 Receipts/Invoices** in the **Workstation 
 Settings** of the user committing the quantities is used (path: **File &gt; Setup &gt; Preferences &gt; WorkStation 
 Settings &gt; Stock Areas &gt; For Purchase** tab).
- If no default  stock areas for sales orders or purchase receipts/invoices are defined  in **Workstation Settings** or in  the stock transfer preferences for the logged in location the items are  assigned to the stock area defined in the **Purchase****Receipt/Invoice** field of the **Location** profile (path: **File 
 &gt; Setup &gt; Accounting &gt; Location/Sub-Location &gt; Options &gt; 
 Edit &gt; In New Window &gt; Stock Transfer &gt; Purchase Document**  tab). If no stock area is defined for login location or the parent location  of the login sub-location, the stock area defined for the default location  is used.



{:.note}
If the option **Allow users to access 
 only those stock areas in the logged in Location** in the **Other 
 Flow Control** dialog box (path: **File 
 &gt; Setup &gt; Preferences &gt; Other Flow Control &gt; General**  tab) is selected, only those stock areas that belong to the logged in  location will be displayed.


{:.see_also}
See also
: [Mark an  Item for Force Sale]({{site.pos_baseurl}}/misc/mark_an_item_for_force_sale.html)
