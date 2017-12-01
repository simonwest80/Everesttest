---
title: Commit Inventory
---

# Commit Inventory


Select this option to scan items by Model No., Item Code,  Item Alias or Serial Number from the **Commit 
 Inventory** dialog box (path: **Options**  > **Commit Inventory** from the  **Sales Orders** browser or profile).  You can set the sequence of the order by which **Everest**  will retrieve the item by setting flow control preferences (path: **File** > **Setup** > **Preferences** > **Flow Control** > **Items**  > **Item Details** tab).


All inventoried, serialized and auto-serialized items can  be scanned. Every correct entry increases the quantity in the Committed  column of the sales order by the quantity in the **Qty**  field of the **Commit Inventory**  dialog box. The **Qty** field defaults  to 1, but with the appropriate security right, you can change the quantity  for regular items. Serial numbers always scan as 1 unit and the quantity  cannot be changed.


To prevent mistakes, this screen flashes a red signal and  sounds a beep for an invalid entry. An invalid scan message is indicated  both visually and audibly for the following:

- Item does not exist.
- Quantity exceeds  order quantity.
- Item is not in  document list.



Click the **History** button to  view the history of all scan attempts/actions.


**Location**
: Select the location of the item from the **Stock 
 bins from** drop-down.
: If you select the **Specific 
 Location** option, the **Location**  field is enabled. Select the location from the **Location**  drop-down when you select the **Specific 
 Location** option.


**History**
: Click the **History**  button to view the history of all scan attempts/actions.  This  screen can be useful for identifying when an invalid barcode was scanned  or mistake was made. History will only display the scan history while  the commit inventory screen has been open.


{:.see_also}
See also
: [Scanning  the Item to Commit Quantities]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/cmt-items/enter-cmt-qty/scanning_the_item_to_commit_quantities_sal.html)
