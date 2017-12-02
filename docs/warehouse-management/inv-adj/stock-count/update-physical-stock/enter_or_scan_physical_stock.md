---
title: Enter or Scan Physical Stock
---

# Enter or Scan Physical Stock


The procedure for bringing the physical stock into the document varies  for different types of inventory.


**Inventoried Items**
: You can directly enter the physical quantity for  inventoried items including those that are tracked for lots.


**Serialized Items**
: As long as the physical quantity for serialized  items is equal to the system quantity, you can manually enter the physical  stock. If the quantity entered is less or more than the system quantity,  you are prompted to scan or enter serial numbers of such items. This helps  determine the discrepancy.
: To scan or enter the serial numbers of such items,  invoke the **Retrieve 
 Serial Numbers** dialog box by selecting the **Retrieve 
 Serial Numbers** option (path: **Stock 
 Count** profile > **Options**  > **Retrieve Serial Numbers**).


****Auto-serialized 
 Items****
: Enter or scan the physical quantity for auto-serialized  items. Serial numbers are allocated to them on a first-in-first-out basis.
: If the physical quantity is less than the number  of items with manufacturer’s serial numbers, you are prompted to provide  the serial numbers of the items counted physically. This aids in determining  the discrepancy and making appropriate adjustments.
: If the physical quantity is equal to or more than  the number of items with manufacturer’s serial numbers, all records are  first allocated manufacturer’s serial numbers. When the manufacturer’s  serial numbers are exhausted, the other serial numbers are allocated on  a first-in-first-out basis.
: If the physical quantity is more than the number  of items with or without manufacturer’s serial numbers, serial numbers  at average cost are generated for all the records. This accounts for the  shortage in quantity.


{:.example}
Item Widget, which is auto-serialized, has  five units in Bin A. The table below displays the serial numbers defined  for the item.

| Internal Serial Number | Manufacturer’s Serial Number |
| 1000 |  |
| 1001 | AAA |
| 1002 |  |
| 1003 | BBB |
| 1004 |  |
: The serial numbers allocated depends on the physical  quantity.


| Physical Quantity | Serial Numbers Attached |
| 2 | AAA; BBB |
| 3 | AAA; BBB; 1000 |
| 4 | AAA; BBB; 1000; 1001 |
| 5 | 1000; 1001; 1002; 1003; 1004 |
| 6 | 1000; 1001; 1002; 1003; 1004; one serial number is generated at average  cost |

{:.see_also}
See also: [Update Physical  Stock]({{site.wm_baseurl}}/inv-adj/stock-count/update-physical-stock/update_physical_stock.html)
