---
title: Sales Invoice Report Dialog Box
---

# Sales Invoices Report Dialog Box


Select the following parameters to view the **Sales Invoices** report.


**Document Type**
: Specify the type of sales document (Sales Invoice  or Credit Memo) to be included in the report.


**Document Status**
: Specify the document status to be included in the  report.

- All
- Open
- Paid

: Selecting **All**  includes all document types in the report.


![]({{site.rpt_baseurl}}/img/lens.gif)<font style="color: #000000;" color="#000000"> 
 </font>[Document  Status]({{site.sp_chm}}/sales-docs/docs-profile/contents/tab-details/details/other/document_status_document_information_sales_content.html)


**Report Type**
: Specify the type of report you want to generate.


| **Summary** | To view summarized information on sales invoices/credit memos. |
| **Detail** | To view detailed information on sales invoices/credit memos. |



**Sales Rep From**
: Select the starting code for the range of sales  representatives to be included in the report.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Drop-Down  List - Right-Click Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html)


**Sales Rep To**
: Select the ending code for the range of sales representatives  to be included in the report.


{:.note}
If  the **Sales Rep From** and **Sales 
 Rep To** fields are left blank, all sales representatives are included.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Drop-Down  List - Right-Click Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html)


**Date From**
: Specify the start date for the sales document to  be included in the report.


**Date To**
: Specify the end date for the sales document to be  included in the report.


{:.note}
If the  **Date From** and **Date 
 To** fields are left blank, by default the current system date is  included in the report.


**Location/Sub-Location From**
: Specify the starting code for the range of locations  or sub-locations to be included in the report.


**Location/Sub-Location To**
: Specify the starting code for the range of locations  or sub-locations to be included in the report.


{:.note}
All documents created for the specified range  of location/sub-locations are listed in the report.


**Profit Based On**
: Select the cost base for calculation of profit for  the document.
: The report may be filtered based on the following:

- **Accounting 
 Cost -** Select this option to display the most recent cost at which  the item was purchased, to be included in the report. The accounting cost  is the cost debited to the "Cost of Goods Sold" account or the  expense account for the item. If the item has factored cost enabled, the  costs are initially debited at factored costs and an adjustment is simultaneously  made for the cost factor. The accounting cost used is the factored cost.
- **Commission 
 Cost** - Sales commission may be calculated based on actual cost,  average cost, last cost or user-defined cost depending on the option selected  in the **Type of cost used for commission 
 calculation** field (path: **File**  > **Setup** > **Preferences**  > **Flow Control** > **Other 
 Flow Control** > **Item Cost/Sales 
 Summary** tab). Select this option if you want the profit to be calculated  and displayed based on the cost used for commission calculations. Costs  used for commission are inflated by the percentage cost factor if the  item has factor cost enabled.
- **User-defined 
 Cost -** Select this option to include the cost indicated by the  user, in the report. You can calculate profits based on this cost.



**Margin/Markup**
: Select this check box to display the margin of each  line item to be included in the report. If this box is cleared, the markup  price of the line items is displayed in the report.


{:.note}
Sales reports show values in the unit of measure  selected in the sales document.


{:.see_also}
See also
: [Invoicing]({{site.rpt_baseurl}}/everest-reports/invoicing/invoicing_reports.html)
