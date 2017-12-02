---
title: Process - Mark Counted/Recount
---

# Process - Mark Counted/Recount


This toggle option is enabled only when the status of the **Stock 
 Count** profile is **Counting in Process**.  Use the **Mark Counted** option to  indicate that the physical count is complete. The following processes  occur as a result of this action:

- The status  of the document changes to **Counted**.
- If you have  chosen the **Block for Counting**  option, **Everest** prompts you that  the variance will be calculated and the status of the document will be  changed to **Counted**. You are further  asked to confirm your selection.
- If you have  selected the option **Take Snapshot to 
 Count**, you are informed that no transactions would be allowed against  the bins included in this document until the inventory adjustments are  made.
- Variance is  computed as the difference between the physical stock and the system stock.



Variance Stock = Physical - System


Variance stock is negative if the physical stock is less than the system  stock and positive if the physical stock is more than the system stock.

- In case the  method used for counting is **Take Snapshot 
 to Count**, average cost, at the time of creation of the Stock Count  document, may differ from the average cost when the document is marked  as **Counted**. The **System 
 Cost** column in the Item Details Grid is automatically updated with  the new cost. This change is also conveyed through a message.
- The **Adjustment 
 Quantity** column is automatically populated with the variance quantity.  This quantity is negative if the physical stock is less than the system  stock and positive if the physical stock is more than the system stock.
- The **Adjustment 
 Cost** column displays the average cost by default.



To clear the variance and reverse the status to **Counting 
 in Process**, select the **Recount**  option.


{:.note}
You cannot insert or delete items once you  have marked a document as **Counted**.


{:.see_also}
See also
: [Stock  Count Profile Options]({{site.wm_baseurl}}/inv-adj/stock-count/stock-count-profile-options/stock_count_profile_options.html)
