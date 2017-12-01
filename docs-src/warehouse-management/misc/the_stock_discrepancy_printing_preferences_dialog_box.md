---
title: The Stock Discrepancy Printing Preferences Dialog Box
---

# The Stock Discrepancy Printing Preferences Dialog Box


Define the parameters for generating the **Stock 
 Discrepancy** report. You can produce this report for all records  or selected records.


**Sort By**
: Specify the criteria you want to use to organize  your report. You can sort it by any of the following options:

- Stock Area;  Bin; Category
- Stock Area;  Bin
- Category; Item;  Stock Area
- Item; Stock  Area



**Include Items with Zero Variance**
: Select this option to include items with zero variance  in this report.


**Include Cost**
: Check this option to display the variance cost of  the items in the **Discrepancy** report.


**Include Variance Value**
: Select this check box to show the value of variance  in the report.


**Print Serial # Discrepancy Details**
: Discrepancies for serialized and auto-serialized  items occur for the following reasons:

- Serial  numbers present in the system are not available physically
- Serial  numbers available physically are not present in the system

: For serial numbers to print in this report, they  must be present somewhere in the system. If the serialized items are available  in the system but are not physically present in the stock bin, they display  as “Unmatched Serial # from system” in the report. If the serialized items  are available physically in a stock bin which is different from the stock  bin in the system, they display as “Unmatched Serial # from phys. Count”  in the report.
: To print such serial numbers, select the **Print 
 Serial # Discrepancy Details** check box. For auto-serialized items,  serial numbers along with manufacturer’s serial numbers are printed.


{:.note}
You can also generate this report from the  following:

- **Stock 
 Count** browser > **Options**  > **Print** > **Discrepancy 
 Report**
- **Reports**  menu > **Inventory** > **Stock Discrepancy**


{:.see_also}
See also
: [Print - Discrepancy]({{site.wm_baseurl}}/misc/print_-_discrepancy.html)
