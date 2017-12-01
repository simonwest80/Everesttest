---
title: Serialized Items
---
<script type="text/javascript" language="JavaScript1.2" x-save-method="compute-relative" src="{{site.wm_baseurl}}/misc/ehlpdhtm.js"></script><script type="text/javascript" language="JavaScript1.2">
<!-- 
if( typeof( kadovFilePopupInit ) != 'function' ) kadovFilePopupInit = new Function();if( typeof( kadovTextPopupInit ) != 'function' ) kadovTextPopupInit = new Function();
 //-->
</script>
****Import file 
 with mapped manufacturer’s serial numbers****


| Item Code | Manufacturer’s Serial # Scanned |
| 17 700 Monitor | 101 |
| 17 700 Monitor | 102 |
| 17 700 Monitor | 103 |
| 17 700 Monitor | 103 |
| 17 700 Monitor | 103 |



**Stock Count document with system and manufacturer’s  serial numbers**


| **Item Code** | **Bin** | **System Stock** | **System Serial #** | **Manufacturer Serial #** |
| 17 700 Monitor | 1 | 6 | 221 | 101 |
|  |  |  | 222 | 102 |
|  |  |  | 223 | 103 |
|  |  |  | 224 | 103 |
|  |  |  | 225 | 103 |
|  |  |  | 226 | 103 |



**Notice that the quantity of Manufacturer’s  Serial Number 103 is three in the import file whereas it is four in the  system stock. The serial numbers 223, 224, and 225 are picked up on a  first-in-first-out basis to update the physical stock.**

****Import 
 File****


| Item Code | Manufacturer’s Serial # Scanned |
| 17 700 Monitor | 101 |
| 17 700 Monitor | 102 |
| 17 700 Monitor | 103 |
| 17 700 Monitor | 103 |
| 17 700 Monitor | 103 |
| 17 700 Monitor | 103 |
| 17 700 Monitor | 103 |



**Stock Count Document**


| **Item Code** | **Bin** | **System Stock** | **System Serial #** | **Manufacturer Serial #** |
| 17 700 Monitor | 1 | 6 | 221 | 101 |
|  |  |  | 222 | 102 |
|  |  |  | 223 | 103 |
|  |  |  | 224 | 103 |
|  |  |  | 225 | 103 |
|  |  |  | 226 | 103 |
|  | 2 | 2 | 227 | 103 |



**Notice that, in this case, the quantity  of the Manufacturer’s Serial Number 103 in the import file is five but  only four in bin 1 of the **Stock Count**  profile. For the additional manufacturer’s serial number in the import  file, **Everest** searches the other  bins in the location and finds the matching item code and manufacturer’s  serial number in bin 2. It picks up serial number 227 from bin 2 to update  the physical stock.**

# Serialized Items


When you map the **Physical Count**  field along with the **Serial Number**  or **Manufacturer’s Serial Number**  field, the physical count is updated if the serial numbers in the **Stock Count** profile match those in the  import file. The physical count does not matter in this case. If, however,  you do not map the **Serial Number**  or the **Manufacturer’s Serial Number**  field, the physical stock must exactly match the system stock.


{:.example}
**The example below illustrates this.**


**Import File Details**


| **Line** | **Item Code** | **Bin** | **Physical Stock** |
| 1 | 17 700 Monitor | 1 | 24 |
| 2 | 17 CRT Monitor | 1 | 32 |
| 3 | 17 700 Monitor | 2 | 29 |
| 4 | 17 CRT Monitor | 2 | 30 |



**Stock Count Details**


| **Item Code** | **Bin** | **System Stock** | **Physical Stock** |
| 17 700 Monitor | 1 | 24 | 24 |
| 17 CRT Monitor | 1 | 30 |  |
| 17 700 Monitor | 2 | 29 | 29 |
| 17 CRT Monitor | 2 |  |  |
| 17 CRT Monitor | 3 | 29 | 30 |


- Line 1 and  line 3 are imported as such since the physical stock tallies with the  system stock.
- Line 2 is not  imported as the physical stock does not tally with the system stock in  bin 1. You must manually scan the serial numbers to reflect the variance.
- Line 4 is inserted  as an additional record if bin 3 lies within the item retrieval limits  specified in the **Stock Count** profile.



**On mapping only the manufacturer’s serial  number, the physical stock is updated if the manufacturer’s serial numbers  in the **Stock Count** profile match  the manufacturer’s serial numbers in the import file. Duplicate manufacturer’s  serial numbers are updated after matching the item code and the manufacturer’s  serial numbers with the next serial number available in the bin. If a  serial number that matches the item code and manufacturer’s serial number  is not available in the bin, other bins in the same location are searched.**


{:.example}
**This is illustrated by the examples below.**

- [Scenario  1](javascript:kadovTextPopup(this)){:id="a1"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a1');
//--></script>
- [Scenario  2](javascript:kadovTextPopup(this)){:id="a2"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a2');
//--></script>



{:.see_also}
See also
: [Import Physical  Stock]({{site.wm_baseurl}}/inv-adj/stock-count/update-physical-stock/import_physical_stock.html)
