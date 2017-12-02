---
title: Sales Order Report (Summary) Dialog Box
---

# Sales Order Report (Summary) Dialog Box


**Status**
: Specify the status of the orders to be included  in the report.


| **Option Name** | **Select this option to view a list of:** |
| Outstanding Backorders | Sales orders that are on backorder, and have a document date that falls  within the selected period. |
| Outstanding Orders | Sales orders that are open, and have a document date that falls within  the selected period. |
| Completed Orders | Sales orders that are marked complete/completely shipped, and have a  document date that falls within the selected period. |
| Outstanding Backorders/Orders | Sales orders that are either open or on backorder, and have a document  date that falls within the selected period. |
| All Orders | All sales orders that have a document date that falls within the selected  period. |



**Sales Rep.**
: Select the sales representative of the sales orders  to be included in the report.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Right-Click  Menu Options in the Drop-Down List]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html)


{:.note}
**If a sales representative is not selected,  sales orders of all representatives matching the other criteria are included.**


**Date From**
: Specify the start date for the range of sales orders  to be included in the report. The date you specify here is the date that  appears on the sales order profile.


![]({{site.rpt_baseurl}}/img/lens.gif) [Document  Date]({{site.pp_chm}}/purc-proc/doc-profile/contents/document-information/document_date.html)


**Date To**
: Specify the end date for the range of sales orders  to be included in the report. The date you specify here is the date that  appears on the sales order profile.


{:.note}
**The **Date 
 From** and **Date To** fields  default to the login date.**


**Use Cost**
: Select the cost base for calculation of profit for  the sales order. The options available are:


| **Option Name** | **Description** |
| Saved | Select this option to calculate and display the profit based on the  item’s accounting cost in the report. The item’s accounting cost is the  average cost of the item selected on a sales order. |
| Commissionable | Select this option to calculate and display the profit based on the  cost used for commission calculations in the report. Costs used for commission  are inflated by cost factor percent if the item has factor cost enabled.<br/><br/><br/>Sales commission may be calculated based on actual cost, average cost,  last cost or user-defined cost based on the other flow control preference  setting (path: **File &gt; Setup &gt; Preferences <br/> &gt; Flow Control &gt; Other Flow Control &gt; Item Cost &gt; Sales Summary <br/> &gt; Type of Cost Used for Commission Calculation** field). |



**Print in Base Currency**
: Select this check box to display the amounts relating  to foreign currency customers in your base currency.


{:.see_also}
See also
: [Sales Order (Summary)]({{site.rpt_baseurl}}/everest-reports/invoicing/sales_order_summary_.html)
