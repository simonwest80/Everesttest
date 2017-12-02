---
title: Stock Discrepancy Printing Preferences
---

# Stock Discrepancy Printing Preferences


**Document From**
: Select the starting document number in the range  of documents for which you want to generate the Stock Discrepancy report.


**Document To**
: Select the ending document number in the range of  documents for which you want to generate the Stock Discrepancy report.
: ![]({{site.rpt_baseurl}}/img/lens.gif)[Right-Click  Menu Options in the Drop-Down List]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html)


**Sort By**


Specify the criteria you want to use to organize your report. You can  sort it by any of the following options:

- Stock Area; Bin;  Category
- Stock Area; Bin
- Category; Item;  Stock Area
- Item; Stock Area



**Include Items with Zero Variance**
: Select this option to include items with zero variance  in this report.


**Include Cost**
: Check this option to display the cost of the items  in the Discrepancy report.


**Include Variance Value**
: Select this check box to show the value of variance  in the report.


**Print Serial # Discrepancy Details**
: Discrepancies for serialized and auto-serialized  items occur for the following reasons:

- Serial numbers  present in the system are not available physically
- Serial numbers  available physically are not present in the system

: For serial numbers to print in this report, they  must be present somewhere in the system. If the serialized items are available  in the system but are not physically present in the stock bin, they display  as “Unmatched Serial # from system” in the report. If the serialized items  are available physically in a stock bin which is different from the stock  bin in the system, they display as “Unmatched Serial # from phys. Count”  in the report.
: To print such serial numbers, select the **Print 
 Serial # Discrepancy Details** check box. For auto-serialized items,  serial numbers along with manufacturer’s serial numbers are printed.


{:.see_also}
See also
: [Stock  Discrepancy Report]({{site.rpt_baseurl}}/everest-reports/inventory/stock_discrepancy_report_inventory_rep.html)
