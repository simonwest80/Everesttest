---
title: Process - Finalize and Adjust Inventory
---

# Process - Finalize and Adjust Inventory


Use this option to create the quantity adjustment document to adjust  the variance in quantity determined by the process of stock counting.  A Stock Transfer document is created to transfer serial numbers from the  bin of the system stock to the bin where the physical quantity is available.


This option is activated only when the **Stock 
 Count** profile is in the **Counted**  status. On creation of the Quantity Adjustment and Stock Transfer documents,  the status changes to **Completed**.  Hereafter, you can carry out transactions from the bins in the Stock Count  document.


It is possible that the bins in which the serial numbers are placed  by the system do not tally with the bins identified by physical count.  On detection of such a discrepancy, the corresponding items are displayed  in the **Stock Count Serial Transfer**  browser.


Select the items that you want adjusted and click **OK**  in this browser. This results in the occurrence of the following processes:

- The **Adjustment 
 Quantity** column in the **Stock Count**  profile displays the item quantity written off for the bin.
- The **Stock 
 Transfer Quantity** column displays the item quantity transferred  from another area.
- The **Adjustment 
 Cost** column shows the weighted average of the actual cost of the  serial numbers transferred.
- The **Adjustment 
 Value** column shows the adjustment quantity multiplied by the adjustment  cost.
- The **Stock 
 Transfer Value** column shows the sum of the serial numbers transferred.



{:.note}
When you add quantity to auto-serialized items,  serial numbers are generated with the average cost.


You can clear the check box for an item that you do not want adjusted  in the **Stock Count Serial Transfer**  browser. You cannot select serial numbers from OUT bins since these items  are already released. You can adjust previously released items by using  credit memos. Alternatively, you can generate new serial numbers for those  items either through purchase receipts or Quantity Adjustments.


If you select the **Finalize and Adjust 
 Inventory** option when the document is in the **Counting 
 in Process** stage, you are warned that necessary inventory adjustments  would be made and the count finalized. You may choose to continue or abort  the process.


Once an inventory adjustment document is created, you can neither edit  it nor create another adjustment document for a Stock Count document.


| ![]({{site.wm_baseurl}}/img/lens.gif) | [Impact  on Quantity Adjustment]({{site.wm_baseurl}}/inv-adj/stock-count/impact-of-quantity-adjustment/impact_of_quantity_adjustment.html) |



{:.see_also}
See also
: [Stock  Count Profile Options]({{site.wm_baseurl}}/inv-adj/stock-count/stock-count-profile-options/stock_count_profile_options.html)
