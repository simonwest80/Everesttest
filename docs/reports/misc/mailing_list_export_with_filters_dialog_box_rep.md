---
title: Mailing List Export (With Filters) Dialog Box
---

# Mailing List Export (With Filters) Dialog Box


Select the following parameters to view the **Mailing List Export (With Filter)** report.


**Code From**
: Specify the starting code for the range of customers  to be included in the report.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Drop-Down  List - Right-Click Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html)


**Code To**
: Specify the ending code for the range of customers  to be included in the report.


{:.note}
If the **Code 
 From** and **Code To** fields  are left blank, all customers are included in the report.
: <font style="color: #000000;" color="#000000">&nbsp;</font>![]({{site.rpt_baseurl}}/img/lens.gif) [Drop-Down  List - Right-Click Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html)


**Customer Status**
: Select the status of the customers to be included  in the report.


| **Active** | To include all customers that are in use. |
| **Inactive** | To include all customers that are discontinued. |



**Location/Sub-Location**
: Specify the location/sub-location code to generate  a list of customers assigned to the specified location/sub-location. If  this field is not selected, customers belonging to all locations/sub-locations  are included in the report.


**Address Type**
: Specify the address type of the customer to be included  in the report from the drop-down list. The options are **Bill 
 To**, **Ship To** and **Contact**.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Drop-Down  List - Right-Click Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html)


**If Address Blank**
: Specify the address to be included in the report,  in case the one mentioned in the **Address 
 Type** field is not available in the database. The options are **None** and **Bill 
 To**. Select **None** to leave  the address field blank. Since it is mandatory to specify the billing  address, select **‘Bill To’**to ensure that the address field in the report is never left blank.


**Sales Person**
: Select the code of the sales representative, to  generate a list of customers assigned to the specified sales representative.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Drop-Down  List - Right-Click Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html)


**Last Tran  Date**
: Select a transaction date to generate a list of  customers whose last transaction date was on or before the selected date.


**Total Sales**
: Enter a sales figure. The report is generated for  customer sales greater than the value entered.


**Company Only**
: Select **Yes**  to display only the address of the customers’ company and select **No** to preview or print all details in  the report.


{:.see_also}
See also
: [Masters]({{site.rpt_baseurl}}/everest-reports/masters/master_reports.html)
