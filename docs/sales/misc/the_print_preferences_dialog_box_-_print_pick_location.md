---
title: The Print Preferences Dialog Box - Print Pick Location
---

# The Print Preferences Dialog Box - Print Pick Location


The **Printing Preferences** dialog  box allows you to specify that the serial numbers or lot numbers of items  should be printed on the pick location report. This makes it simpler to  identify the items that are committed on the sales order. Also select  the location/bins with enough stock to pick the items from the **Bin 
 Selection** field.


**Serial #**
: Specify whether you want the system-generated serial  numbers or manufacturer's serial numbers to be printed in the pick location  report. The default option, **Both**,  prints the system's as well as the manufacturer's serial numbers.


{:.note}
**For items tracked for lots, the report  prints the total quantity to be picked against the item description as  well as the breakup of this quantity against each lot number.**


**Bin Selection**
: Specify whether you want the system to look for  bins from which to pick stock only from the **Put 
 Away bin** (specified in the **Item 
 Replenishment** tab of the Item Profile of the line items) or to  search other stock bins.  The  search option is useful if the same item is stored in multiple stock bins.


**Copies**
: Specify the number of copies of the report that  you require to print. Once you have printed or previewed the report, you  are asked if you wish to mark the items on the sales order as printed  in the **Pick Location** report.
: If some of the items are previously printed, you  are reminded of the same and asked if you require duplicate copies.


On the **Pick Location**  report, for drop ship items, the **Stock 
 Bin** column displays “**DS**”  for drop ship. An **asterisk** (*****) next to the stock bin, for example  \*CCSA, indicates that the line item is fully committed.


{:.see_also}
See also
: [Print Pick  Location]({{site.sp_baseurl}}/misc/print_pick_location_so.html)
: [The Pick  Location Report]({{site.sp_baseurl}}/misc/the_pick_location_report_sal.html)
