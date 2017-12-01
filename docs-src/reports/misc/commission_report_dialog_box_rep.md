---
title: Commission Report Dialog Box
---

# Sales Commission Report Dialog Box


**Sort By**
: Select the option to sort the report by: ****

- A - Sales Rep,  Date, Invoice #, Category, Item
- B - Sales Rep,  Invoice #, Date, Category, Item
- C  - Sales Rep, Customer, Date/Invoice #, Category
- D - Sales Rep,  Category, Item, Date/Invoice



**Sales Representative From**
: Specify a starting code for the range of sales representatives  to be included in the report.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Drop-Down  List - Right-Click Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html)


**To**
: Specify an ending code for the range of sales representatives  to be included in the report.


{:.note}
If the **Sales 
 Representative From** and **To**  fields are left blank, all sales representatives are included in the report.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Drop-Down  List - Right-Click Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html)


**Customer From**
: Specify the starting code for the range of customers  to be included in the report.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Drop-Down  List - Right-Click Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html)


**To**
: Specify the ending code for the range of customers  to be included in the report.


{:.note}
If the **Customer 
 From** and **To** fields are  left blank, all the customers are included in the report.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Drop-Down  List - Right-Click Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html)


**Item Category From**
: Specify the starting category code for the range  of items to be included in the report.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Drop-Down  List - Right-Click Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html)


**To**
: Specify the ending category code for the range of  items to be included in the report.


{:.note}
If a range of categories is not mentioned,  items belonging to all categories that meet the specified parameters are  displayed in the report.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Drop-Down  List - Right-Click Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html)


**Item Code From**
: Specify the starting code for the range of items  to be included in the report.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Drop-Down  List - Right-Click Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html)


**To**
: Specify the ending code for the range of items to  be included in the report.


{:.note}
If the **Item Code From** and the  **To** fields are left blank, all  items are included in the report.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Drop-Down  List - Right-Click Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html)


**Date From**
: Specify the start date for the commission to be  included in the report.


**To**
: Specify the end date for the commission to be included  in the report.


{:.note}
: If the **Date 
 From** and **To** fields are  left blank, the current system date appears in these fields.
: When a date range is specified and the **Fully Paid** option is unchecked, the  report filters documents based on the document date.


If the **Fully Paid** option is  checked, **Everest** retrieves all  documents on which payments are made, after identifying all posted receipt  journals created between the dates selected in the **Date 
 From** and **To** fields.


**Location/Sub-Location**
: Specify the location/sub-location based on which  the report is generated. If this field is left blank, the item categories  for all locations/sub-locations are included in the report.


**Terms to be Included**
: Specify the payment terms that the report should  be based on. If this field is not selected, all payment terms are included.


**Terms to be Excluded**
: Use this field to omit a payment term from the report.  It is used when all terms are to be included except one.


**Report Type**
: Specify the type of report you want to generate.


| **Summary** | Select this option to view a summary of the commission  report. A summarized version displays the Invoice date, Sales value, Profit/Margin  percentage and the Commission amount. |
| **Detail** | Select this option to view detailed information regarding  the commission payable on sales. Apart from what a summarized report displays,  a detailed report also includes the invoice date and number, item/category  description, item quantities and the rate of commission. |



**Print Commission Amount**
: Select this check box to include the amount of commission  in the report.


**Fully Paid**
: Select this check box to generate a report for fully  paid invoices.


{:.note}
: When a date range is specified and the **Fully Paid** option is unchecked, the  report filters documents based on the document date.
: If the **Fully 
 Paid** option is checked, **Everest**  retrieves all documents on which payments are made, after identifying  all posted receipt journals created between the dates selected in the  **Date From** and **To**  fields.
: For each document identified as above, the  total paid amount is calculated, by summing up all the payments made on  the document before the selected date range (without considering the payments  made during the selected dates). **Everest**  compares the above calculated amount with the document amount, to determine  if the document has been fully paid or not. **Similarly, 
 for each identified document, the total paid amount is calculated, by 
 summing up all the payments made on the document till the end of the selected 
 date range.** **Everest** **compares the above calculated amount with the 
 document amount to determine if the document has been fully paid or not.**


**Use Margin**
: Select this check box to display the margin cost  on the sales made to be included in the report.


**Use Saved Data**
: Select this check box to view a report generated  previously, and saved.


{:.note}
Commissions are calculated based on the present rates defined. In case  the commission rates change often, it is recommended that you use the  Save option in the **Sales Commission****report** **Details**  browser, after exporting the report using the **Export**  option. You can retrieve the document at a later date, using the above  option.


**Select Report**
: Use this option to view all saved reports. You can  modify the **Cost** and **Commission****Rate** columns in a saved report,  by clicking the [**Export**  button]({{site.rpt_baseurl}}/misc/export_commission_report.html). The **Commission Report Details**  browser is displayed.


{:.note}
This option is enabled only if you select the **Use 
 Saved Data** check box.


{:.see_also}
See also
: [Commission Report]({{site.rpt_baseurl}}/everest-reports/invoicing/commission_report.html)
