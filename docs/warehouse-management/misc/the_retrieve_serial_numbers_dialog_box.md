---
title: The Retrieve Serial Numbers Dialog Box
---

# The Retrieve Serial Numbers Dialog Box


The **Retrieve Serial Numbers**  dialog box allows you to scan the system serial numbers or manufacturer’s  serial numbers for serialized and auto-serialized items. You can either  scan the serial numbers using a bar code scanner or manually type the  serial numbers.


**Physical Bin**
: Select a bin from the drop-down for which you are  attaching serial numbers. When you scan or enter a serial number, it is  attached to the bin selected in this field. As a result, the physical  quantity for the matching line item is incremented.
: Here’s an overview of how situations involving a  mismatch are dealt with.

- If you scan  an item that is not present in the bin selected in the **Physical 
 Bin** field, **Everest** asks  if you would like to include the item in the bin.
- If the scanned  item is not present in the document, but belongs to the physical count  bin, you are asked if you want to add the item to the document.
- If the scanned  item does not belong to the location of the **Stock 
 Count** profile, the scanned serial number is ignored. Only items  found in the location of the document are considered for the counting  process.

: The effect of leaving this field blank is as follows:

- There is an  increment in the quantity if the item code of the line item matches the  item code of the serial number scanned.
- If the item  code of the line item does not match the item code of the serial number  scanned, **Everest** looks for the  matching code in the same bin. There is an increment in the quantity if  a similar item code is found; if not, Everest asks if you would like to  add that item code as a separate line item.



Method


This section allows you to specify the method of retrieval of the serial  numbers.


| Option Name | Description |
| System Serial Numbers | Select this option to retrieve one item serial number into the document.  The **Serial #** field is displayed  in this section. Specify the required serial number |
| Range of System Serial Numbers | Select this option to attach more than one item serial number to the  document. The **Serial # from** and  **Serial # to** fields are enabled.  Specify the range of serial numbers to be attached. |
| Manufacturer’s Serial Numbers | Select this option to attach the item to the document by specifying  the manufacturer's serial number. The **Manufacturer's <br/> Serial #** field is enabled. Specify the required number. |



**Serial Number**
: Based on the method you select for retrieval of  serial numbers, scan the individual serial numbers, range of serial numbers  or manufacturer’s serial numbers.


{:.note}
- Serial numbers  of a physical count may not be available in any of the bins of the location  specified in the Stock Count profile. In this case, you cannot include  these numbers for a physical count in this stock count document. You must  first transfer these serial numbers to the location of the Stock Count  profile through a Stock Transfer document.
- If the scanned  serial number does not exist in the system, it must be brought into the  system through a credit memo before scanning it.
