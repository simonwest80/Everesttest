---
title: Pull Sheet Wizard - Quantity Allocation
---

# Pull Sheet Wizard - Quantity Allocation


This section allows you to select the method for allocating quantities  of non-serialized items tracked for lots. You can choose to allocate quantities  either automatically (by the system) or manually.


Automatically allocate available quantities


Select this option to allocate available quantities of non-serialized  items to the sales order automatically. The allocation can be based on  the following options:

- **Earliest 
 expiry date** - Out of the stock that is available in the selected  stock bins (selected in the **Stock 
 Bin Selection** section) for allocation to various sales orders,  the lot numbers are assigned according to the “Earliest expiry date of  the lot”. The lot that is expiring first is picked up first.



| ![]({{site.sp_baseurl}}/img/example.gif) | | Stock Bin | Lot number | Expiry date | Quantity |<br/>| Main | A100 | 1/31/2009 | 100 |<br/>| WHA | A101 | 2/10/2009 | 150 |<br/>| Main | A102 | 2/10/2009 | 50 |<br/>| WHR | A103 | 2/20/2009 | 250 | |


- **Earliest 
 manufacture date** - Out of the stock that is available in the selected  stock bins (selected in the **Stock 
 Bin Selection** section) for allocation to various sales orders,  the lot numbers are assigned based on the “Earliest manufacture date of  the lot”. The lot numbers, irrespective of the stock bin, are organized  on a FIFO basis and picked up according to the date of manufacture.



| ![]({{site.sp_baseurl}}/img/example.gif) | | Stock Bin | Lot number | Manufacture date | Quantity |<br/>| Main | A100 | 1/31/2009 | 100 |<br/>| WHA | A101 | 2/10/2009 | 150 |<br/>| Main | A102 | 2/10/2009 | 50 |<br/>| LA | A103 | 2/20/2009 | 250 | |


- **Earliest 
 purchase date** - Out of the stock that is available in the selected  stock bins (selected in the **Stock 
 Bin Selection** section) for allocation to various sales orders,  the lot numbers are assigned based on the “Earliest purchase date of the  lot”. The lot numbers, irrespective of the stock bin, are organized on  a FIFO basis and picked up according to the purchase date.



| ![]({{site.sp_baseurl}}/img/example.gif) | | Stock Bin | Lot number | Purchase date | Quantity |<br/>| Main | A100 | 1/31/2009 | 100 |<br/>| WHA | A101 | 2/10/2009 | 150 |<br/>| Main | A102 | 2/10/2009 | 50 |<br/>| VA | A103 | 2/20/2009 | 250 | |



Manually allocate quantities


If you select this option, the system will consider the total quantity  that is required and the quantity that is available for allocation to  the various sales orders. When you try to enter the quantity for non-serialized  items tracked for lots, you will see the **Assign 
 Quantity** profile. The profile shows only the stock bin allocated  for that line item.


Click **Next**. You will see the  [**Sales Order Selection**]({{site.sp_baseurl}}/sales-docs/ordr-ff/create-a-pull-sheet/wizard/so-selection/document_criteria_sales_order_selection_pick_ticket_wizard.html) section of  the **Pull Sheet Wizard**.


{:.see_also}
See also
: [The Pull Sheet  Wizard]({{site.sp_baseurl}}/sales-docs/ordr-ff/create-a-pull-sheet/wizard/the_pull_sheet_wizard.html)
