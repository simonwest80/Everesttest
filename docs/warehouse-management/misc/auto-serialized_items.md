---
title: Auto-serialized Items
---

# Auto-serialized Items


When you map the **Physical Count**  field along with the **Serial Number**  or **Manufacturer’s Serial Number**  field, the physical count is updated if the serial numbers in the **Stock Count** profile match those in the  import file.


If neither the serial number nor the manufacturer’s serial number is  mapped, the quantity of the item is updated provided the physical quantity  in the import file is greater than or equal to the system quantity for  items with manufacturer’s serial numbers.


Serial numbers are generated for items that are in excess in the physical  stock.


In case the physical quantity is less than the system quantity with  manufacturer’s serial numbers, the items are not imported. This is because  it is not possible to determine which items with manufacturer’s serial  numbers are included in the physical stock.


{:.example}
Item Widget, which is auto-serialized, has  five units in Bin A. The table below displays the serial numbers defined  for the item.


| Internal Serial Number | Manufacturer’s Serial Number |
| 1000 |  |
| 1001 | AAA |
| 1002 |  |
| 1003 | BBB |
|  |  |



The serial numbers allocated depend on the physical quantity.


| Physical Quantity | Serial Numbers Attached |
| 1 | Nil |
| 2 | AAA;BBB |
| 3 | AAA;BBB;1000 |
| 4 | AAA;BBB;1000;1002 |
| 5 | AAA;BBB;1000;1002;1003;1004 |
| 6 | AAA;BBB;1000;1002;1003;1004 one serial number is generated at average  cost |



If only the manufacturer’s serial number is mapped, the quantity matching  the manufacturer’s serial number in the Stock Count document and the import  file is updated.


In case of duplication of the manufacturer’s serial number, the next  serial number in the bin that has an item code and manufacturer’s serial  number to match is used to update the quantity. If such an item is unavailable  in that bin, **Everest** searches  for the item with the matching criteria in another bin of the same location.


Duplicate records for an item and bin combination may be detected in  an import file when the physical count field is mapped. If this happens,  the physical count is attached to the matching item and bin in the Stock  Count document if the existing physical stock is zero; otherwise, the  duplicate item is ignored.


In case of duplicate serial numbers in the import file, only the first  record is imported.


{:.see_also}
See also
: [Import Physical  Stock]({{site.wm_baseurl}}/inv-adj/stock-count/update-physical-stock/import_physical_stock.html)
