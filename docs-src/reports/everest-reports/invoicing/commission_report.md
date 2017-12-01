---
title: Sales Commission Report
---

# Sales Commission 


The **Sales Commission** report  calculates the commission payable to the sales representatives on the  sales made by them.

- Commissions paid  to sales representatives are based on the value of items, or profit made  on the sale. The basis for computing commission is defined in the **Commission Based On** field in the **Other Flow** dialog box (path: **File 
 &gt; Setup &gt; Preferences &gt; Flow Control &gt; Other Flow Control 
 &gt; Item Cost/Sales Summary** tab).
- The cost displayed  in the report is based on the option selected in the **Type 
 of cost used for commission calculation** and **Default 
 value for user defined cost** column in the document fields (path:  **File &gt; Setup &gt; Preferences &gt; 
 Flow Control &gt; Other Flow Control &gt; Item Cost/Sales Summary**  tab).



{:.note}
The commission report displays the commission payable only if the relevant  sales and receipt journals recording the transaction are posted. Further,  the report lists only those items for which the option **Include 
 in commission report calculation** is checked in the **Sales**  tab of the **Item** profile.


{:.example}
A sales invoice with serial number 1421 is generated when the option  **Actual Cost** is selected in the  **Type of cost used for commission calculation**  field (path**: File &gt; Setup &gt; Preferences 
 &gt; Flow Control &gt; Other Flow Control &gt; Item Cost/Sales Summary**  tab). The sales commission is calculated on the **Actual 
 Cost** of the item.


Later the option is changed from **Actual 
 Cost** to **Average Cost** in  the **Type of cost used for commission 
 calculation** field (path: **File**  > **Setup** > **Preferences**  > **Flow** **Control**  > **Other** **Flow****Control** > **Item****Cost/Sales** **Summary**  tab). Now another sales invoice is created with serial number 1521. The  sales representative's commission for this invoice is calculated based  on the **Average Cost of items** sold.


The report displays the following information:

- Sales invoice/Credit  memo number and date of creation of the document.
- Item category and  code on which the commission is applicable, along with the quantity and  unit of measure.
- Cost of each item,  and profit, and margin percentage (if selected) on sale of each item.  If the option **Use Margin** is not  selected, the markup percentage is displayed in the report.
- Commission percentage  and amount of commission payable (if selected) for each item.
- Total commission  payable to each sales person.



{:.steps}
To  generate the Sales Commission report, do the following:

- From the main  menu bar, select **Reports** >  **Invoicing** > **Commission**.  You will see the [**Sales Commission Report** dialog box]({{site.rpt_baseurl}}/misc/commission_report_dialog_box_rep.html).
- Specify the  report parameters and click:


- **Preview**,  to preview the report in the **Report Preview** dialog box
- **Print**,  to print the report
- **Export**,  to save the report in text, Excel, HTML or Crystal Report file formats



{:.note}
Sales reports show values in the unit of measure  selected in the sales document.


{:.see_also}
See also
: [Invoicing]({{site.rpt_baseurl}}/everest-reports/invoicing/invoicing.html)
: [Invoicing Reports]({{site.rpt_baseurl}}/everest-reports/invoicing/invoicing_reports.html)
