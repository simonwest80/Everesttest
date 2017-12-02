---
title: Sales Order Report Dialog Box
---

# Sales Orders Report Dialog Box


Select the following parameters to view the **Sales Orders** report:


**Document Type**
: Specify the type of sales document (Sales Order  or Credit Order) to be included in the report.


**Document Status**
: Specify the document status to be included in the  report.

- **Back 
 Order** - To display sales/credit orders, whose status is back order.
- **Open 
 Order** - To display only open sales/credit documents.
- **Closed 
 Order** - To display only closed sales/credit documents.

: You can generate the report for documents that have  not been paid (fully open documents) or for the ones that have been paid  (open orders) or for orders that have been processed into sales invoices  (closed orders) or for orders that have been partly fulfilled (back orders).


![]({{site.rpt_baseurl}}/img/lens.gif) [Document  Status]({{site.sp_chm}}/sales-docs/docs-profile/contents/tab-details/details/other/document_status_document_information_sales_content.html)


**Date From**
: Specify the start date for the sales document, to  be included in the report.


**Date To**
: Specify the end date for the sales document, to  be included in the report.


{:.note}
If the **Date 
 From** and **Date To** fields  are left blank, the current system date is included in the report.


**Location/Sub-Location From**
: Specify the starting code for the range of locations  or sub-locations, to be included in the report.


**Location/Sub-Location To**
: Specify the ending code for the range of locations  or sub-locations, to be included in the report.


{:.note}
All documents created for the specified range of location/sub-location  are listed in the report.


**Sales Rep**
: Specify the sales representative based on which  the report is generated.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Drop-Down  List - Right-Click Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html)


**Report Type**
: Specify the type of report you want to generate.


| **Summary** | To view summarized information on sales orders/credit  orders. |
| **Detail** | To view a detailed report on the sales orders/credit  orders. |



**Profit Based On**
: Select the cost base for calculation of profit for  the document.
: The report may be filtered based on the following:

- **Accounting 
 cost -** Select this option to display the most recent cost at which  the item was purchased, in the report. The accounting cost is the cost  debited to the "Cost of Goods Sold" account or the expense account  for the item. If the item has factored cost enabled, the costs are initially  debited at factored costs and an adjustment simultaneously made for the  cost factor. The accounting cost used is the factored cost.
- **Commission 
 costs** - Sales commission may be calculated based on actual cost,  average cost, last cost or user-defined cost depending on the option selected  in the **Type of cost used for commission 
 calculation** field (path: **File 
 &gt; Setup &gt; Preferences &gt; Flow Control &gt; Other Flow Control 
 &gt; Item Cost/Sales Summary** tab). Select this option if you want  the profit to be calculated and displayed based on the cost used for commission  calculation. Costs used for commission are inflated by the percentage  cost factor if the item has factor cost enabled.
- **User-defined 
 cost** - Select this option if you want to include the cost indicated  by the user to be generated in the report. You can calculate profits based  on this cost.



{:.note}
Sales reports show values in the unit of measure  selected in the sales document.


**Sort Order**
: Sort the reports by the following options:

- Document Number  - Ascending - **Select this option to 
 sort the reports in the ascending order of documents' numbers.**
- Document Number  - Descending - **Select this option to 
 sort the reports in the descending order of the documents' numbers.**



**Margin/Markup**
: Select this check box to display the margin of each  line item to be included in the report.
: If this field is cleared, the markup price of the  line items is displayed in the report.


**Print in Base Currency**
: Select this check box to display the amounts relating  to foreign currency customers in your base currency.


{:.see_also}
See also
: [Invoicing]({{site.rpt_baseurl}}/everest-reports/invoicing/invoicing.html)
: [Invoicing Reports]({{site.rpt_baseurl}}/everest-reports/invoicing/invoicing_reports.html)
