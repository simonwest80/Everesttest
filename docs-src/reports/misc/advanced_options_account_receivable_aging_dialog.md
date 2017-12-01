---
title: Advanced Options for Account Receivable Aging dialog box
---

# Advanced Options for Account Receivable Aging dialog box


**Account Selection Method**
: Select the report filter method to filter the report.   You can  choose either **Range** (a range of  accounts) or **Smart Filter**. The  **Smart Filter** allows you to use  wildcards to select accounts based on your segments.


**Smart Filter**
: Use the **Smart Filter**  to select accounts based on your segments. Wildcards can be used in this  field and up to 250 characters can be entered. **Segment 
 separators** must be entered between segments. Enter a semi-colon  (;) to separate accounts in the **Smart 
 Filter**.


| Smart Filter Wildcard | Meaning |
| ? | One Character |
| \* | Multiple Characters |

: ![]({{site.rpt_baseurl}}/img/lens.gif)[Smart Filter]({{site.rpt_baseurl}}/misc/smart_filter.html)
: ![]({{site.rpt_baseurl}}/img/lens.gif)[Segmented\_Chart\_of\_Accounts]({{site.sc_chm}}/options/acc-info/coa/chart-of-accounts-details/segmented_chart_of_accounts.html)


**Accounts From**
: You can filter the report to see only one account  or a range of accounts.  Select  the first account in the range.


**Accounts To**
: You can filter the report to see only one account  or a range of accounts.  Select  the same account or the second account in the range.


**Sales Rep.**
: You can filter the report to see only those documents  assigned to specific sales representatives. The options available are:

- **All**  - Select this option to include all the sales representatives in the report.
- **Specific**  - Select this option to include only documents created by the specific  sales representatives in the report. Click the button beside the selection  field and select the required sales representative.
- **Range**  - Select this option to specify the starting and ending sales representative  codes for the range of sales representatives whose documents must be included  in the report.

: ![]({{site.rpt_baseurl}}/img/lens.gif) [Drop-Down  List - Right-Click Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html)


**Customer**
: You can filter the report to see only those documents  that are created for customers. The options available are:

- **All**  - Select this option to include all the customers in the report.
- **Specific**  - Select this option to include only documents created for specific customers  in the report. Click the button beside the selection field and select  the required customer.
- **Range**  - Select this option to specify the starting and ending customer codes  for the range of customers for whom documents must be included in the  report. You can use the fields that appear to the right to specify the  From and To customers.



**Document Dates**
: You can filter the report to see only those sales  documents created on a certain date or period. Selecting any option here  except **All**, automatically populates  the **From** and **To**  fields, with the date range. You can edit the **From**  and **To** fields only when you select  the option as **Custom**. When a specific  date range is selected, then only those documents whose document date  lies in the above selected date range is included in the report.


{:.note}
All date options (such as **Today**  and **This Week**) are with respect  to the login  date.
: The date options available are detailed below.


| Options | : Displays |
| All | All sales documents (irrespective of their date of creation). |
| Today | Sales documents created on the login date. |
| This Week | Sales documents created during the current week. |
| This Week to Date | Sales documents created from the beginning of the week to the login  date. |
| This Month | Sales documents created during the current month. |
| This Month to Date | Sales documents created from the beginning of the month to the login  date. |
| This Year | Sales documents created during the current year. |
| This Year to Date | Sales documents created from the beginning of the year to the login  date. |
| Yesterday | Sales documents created on the day prior to the login date. |
| Last Week | Sales documents created during the previous week. |
| Last week to date | Sales documents created from the beginning of the previous week to the  login date. |
| Last Month | Sales documents created during the previous month. |
| Last Month to Date | Sales documents created from the beginning of the previous month to  the login date. |
| Custom | Sales documents created on the specified date or within the selected  date range. |



**Document Aliases**
: Specify the document alias for the sales documents.  The options available are:

- **All**  - Select this option to include all the document aliases for the sales  documents in the report.
- **Specific**  - Select this option to display only a specific alias for the sales document  to be included in the report. Click the button beside the selection field  and select the required document aliases. If you select more than one  document alias, the display in the selection field changes to “Multiple”.



**Terms**
: This field allows you to specify the payment terms  that the report should be based on. The options available are:

- **All**  - Select this option to include all the payment terms for the sales documents  in the report.
- **Specific**  - Select this option to include only the specific payment terms for the  sales document in the report. Click the button beside the selection field  and select the required payment terms. If you select more than one payment  term, the display in the selection field changes to “Multiple”.



**Location/Sub-Location**
: Specify the location/sub-location name to be included  in the report. The options available are:

- **All**  - Select this option to include the aging details for all locations/sub-locations  in the report.
- **Specific**  - Select this option to include the aging details only for specific locations/sub-locations  in the report. Click the button beside the selection field and select  the required locations/sub-locations. If you select more than one location/sub-location,  the display in the selection field changes to “Multiple”. The documents  displayed will be for the main location selected and not its sub-locations.



**Day Overdue**
: You can filter the report to include customer balances  that are due for a specified period. The options available are:

- **Do 
 not consider** - When this option is selected, the report will include  details of outstanding balances, irrespective of the number of days by  which a document is overdue.
- **Between**  - When this option is selected, the report includes only those details  of documents which are overdue by greater than or equal to the value entered  in the field **From** and less than  or equal to the value entered in the field **To**.



{:.example}
You can generate the report for customers whose balances are due to  you for a period of 1 to 30 days.
: {:.see_also}
See also
: [Accounts  Receivable Aging dialog box]({{site.rpt_baseurl}}/misc/account_receivable_aging_dialog_box.html)
: [Accounts  Receivable Aging]({{site.rpt_baseurl}}/everest-reports/invoicing/account_receivable_aging_rep.html)
: [Invoicing]({{site.rpt_baseurl}}/everest-reports/invoicing/invoicing.html)
