---
title: Customer Statements (Date Range)
---

# Customer Statements (Date Range)


The **Customer Statements (Date Range)**  report provides you with a complete statement of all transactions with  a selected customer or a range of customers in the date range specified.  You are able to include both posted and unposted journal transactions.  This report can be used for:

- Obtaining balance  confirmation.
- Sending balance  confirmation when required by customers.
- Following up on  balances.



The information available from this report is detailed below:

- The company’s logo.  If the logo of the company is not attached, the company name, address  and telephone number specified in the company profile are printed.
- The report heading  (“Statement”) and the date range as selected in the parameters.
- Customer name,  contact person and address details.
- Customer related  information such as account code, credit limit, sales representative,  as well as the page number and the database server date when the report  was printed.
- The customer’s  cumulative balance on a particular date. This is calculated by adding  any charge amounts and deducting any credit amounts.  The  **Credit** column is populated when  payments are received from the customer and the **Charge**  column reflects the refunds made to the customer.
- Transactions with  the customer prior to the date range selected for viewing the report.  These are totaled and presented as the Opening Balance (OB).
- Sales invoices  (both system and manual), credit memos (both system and manual), deposits  on sales orders, deposits on debit orders and receipts on invoice and  also refunds against credit memos. The transactions listed depend on the  parameter preferences.
- The aging analysis  of the closing balance, printed at the bottom of each page.
- The statement for  each customer on a new page, in case of multiple customer selection.
- The customer statement  document policy as specified in the **Customer 
 statement** field in Everest Default Preferences (path: **File**  > **Setup** > **Preferences**  > **Defaults** > **Documents**  > **Sales Policy** tab).



{:.note}
You can define document policies from the  **Document Policies** browser (path:  **File** > **Setup**  > **Miscellaneous** > **Document** **Policy**).

- Transactions for  the customer are segregated based on their aging:


- 91+ days
- 61-90 days
- 31-60 days
- 01 to 30 days



{:.steps}
To generate the Customer Statements (Date Range) report,  do the following:

- From the main  menu bar, select **Reports** >  **Invoicing** > **Customer 
 Statements (Date Range)**. You will see the [Customer  Statements (Date Range)]({{site.rpt_baseurl}}/misc/customer_statements_(date_range)_dialog_box.html) dialog box.
- Specify the  report parameters and click:

 - **Preview**,  to preview the report in the **Report Preview**  dialog box
 - **Print**,  to print the report
 - **Export**,  to save the report in text, Excel, HTML or Crystal Report file formats



{:.see_also}
See also
: [Invoicing]({{site.rpt_baseurl}}/everest-reports/invoicing/invoicing_reports.html)
