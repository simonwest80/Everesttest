---
title: Back End Processes
---

# Back End Processes


Following are the back end processes that take place, when you write  off a quantity of items from a stock:

- The inventory  value of the item decreases.
- The quantity  written off is moved to an ‘Out’ stock area. The stock area to which the  quantity written off is determined by the following rules:


- If a default stock  area for stock write off is specified in **Workstation 
 Settings &gt; Stock Areas**, then the quantities are assigned to  this stock area.
- If default stock  areas are not defined in **Workstation 
 Settings**, then the items are assigned to the stock area defined  for stock write off in **Location/Sub-Location** profile (path: **File &gt; Setup 
 &gt; Accounting &gt; Location/Sub-Location** profile **&gt; 
 Stock Transfer &gt; Inventory Adjustments** tab).


- The  stock status of the item shows the following changes:


- **Stock 
 Status for the item** - There is a decrease in total stock and available  stock of the item.
- **Stock 
 Status in the original stock area** - There is a decrease in the  quantity of item available in the stock area from which the item was written  off. The total stock of the item in the stock area decreases.
- **Stock 
 Status in the Out stock area** - There is an increase in the quantity  of item available in the stock area from which the item written off is  moved. The total stock of the item in the stock area decreases.



{:.see_also}
See also
: [Accounting  Entries for a Write off Quantity Document]({{site.wm_baseurl}}/misc/accounting_entries_for_a_write_off_quantity_document.html)
