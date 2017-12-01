---
title: Sales Tax Dialog Box
---

# Sales Tax Dialog Box


Select the following parameter to view the **Sales 
 Tax** report:


**Jurisdiction From**
: The report can be filtered to print the sales tax  pertaining to a particular jurisdiction. Specify the starting code for  the range of jurisdictions to be included in the report.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Drop-Down  List - Right-Click Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html)


**Jurisdiction To**
: The report can be filtered to print the sales tax  pertaining to a particular jurisdiction. Specify the ending code for the  range of jurisdictions to be included in the report.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Drop-Down  List - Right-Click Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html)


**Location/Sub-Location From**
: Specify the starting code for the range of locations  or sub-locations, to be included in the report.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Drop-Down  List - Right-Click Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html)


**Location/Sub-Location To**
: Specify the ending code for the range of locations  or sub-locations, to be included in the report.


{:.note}
All documents created for a location/sub-locations  in the range specified are listed in the report.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Drop-Down  List - Right-Click Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html)


**Date From**
: Specify the start date for the sales tax document,  to be included in the report.


**Date To**
: Specify the end date for the sales tax document,  to be included in the report.


{:.note}
If  the dates are not specified in the **Date 
 From** and **Date To** fields,  by default the current system date are included in the report.


**Report Type**
: Specify the type of report you want to generate.  Select Summary to view the tax totals by date without line item details.  Select Detailed to display the line item details for system documents.


{:.note}
In the case of manual journals where you have  not assigned any tax codes, the report displays manual documents using  the journal’s jurisdiction tax code. If you have assigned a tax code to  some but not all taxable and exempt entries, entries with a tax code appear  under the appropriate tax code while entries without a tax code appear  under the tax code "–."


Also note that some manual journals may have  separate line entries with different tax codes selected. In this case,  the manual journal number will appear multiple times on the report as  each tax code lists its own tax values.


{:.see_also}
See also
: [Sales Tax]({{site.rpt_baseurl}}/everest-reports/accounting/sales_tax.html)
: [Accounting]({{site.rpt_baseurl}}/everest-reports/accounting/accounting.html)
