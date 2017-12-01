---
title: Advanced Options for Account Payable Aging dialog box
---

# Advanced Options for Account Payable Aging dialog box


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


**Purchase Rep.**
: You can filter the report to see only those documents  assigned to specific purchase representatives. The options available are:

- **All**  - Select this option to include all the purchase representatives in the  report.
- **Specific**  - Select this option to include only documents created by the selected  purchase representative in the report. Click the button beside the selection  field and select the purchase representative.
- **Range**  - Select this option to specify the starting and ending purchase representative  codes for the range of purchase representatives whose documents must be  included in the report.

: ![]({{site.rpt_baseurl}}/img/lens.gif) [Drop-Down  List - Right-Click Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html)


**Vendor**
: You can filter the report to see only those documents  that are created for vendors. The options available are:

- **All**  - Select this option to include all the vendors in the report.
- **Specific**  - Select this option to include only documents created for a specific  vendor in the report. Click the button beside the selection field and  select the required vendor.
- **Range**  - Select this option to specify the starting and ending vendor codes for  the range of vendors for whom documents must be included in the report.  You can use the fields that appear to the right to specify the **From**  and **To** vendor codes.



**Document Dates**
: You can filter the report to see only those purchase  documents created on a certain date or period. Selecting any option here  except the **All** option, automatically  populates the **From** and **To**  fields, with the date range. You can edit the **From**  and **To** fields only when you select  the option as **Custom**. When a specific  date range is selected, then only those documents whose document date  lies in the above selected date range is included in the report.


{:.note}
All date options (such as **Today**  and **This Week**) are with respect  to the login date.
: The date options available are detailed below.


| Options | : Displays |
| All | All purchase documents (irrespective of their date of creation). |
| Today | Purchase documents created on the login date. |
| This Week | Purchase documents created during the current week. |
| This Week to Date | Purchase documents created from the beginning of the week to the login  date. |
| This Month | Purchase documents created during the current month. |
| This Month to Date | Purchase documents created from the beginning of the month to the login  date. |
| This Year | Purchase documents created during the current year. |
| This Year to Date | Purchase documents created from the beginning of the year to the login  date. |
| Yesterday | Purchase documents created on the day prior to the login date. |
| Last Week | Purchase documents created during the previous week. |
| Last week to date | Purchase documents created from the beginning of the previous week to  the login date. |
| Last Month | Purchase documents created during the previous month. |
| Last Month to Date | Purchase documents created from the beginning of the previous month  to the login date. |
| Custom | Purchase documents created on the specified date or within the selected  date range. |



**Document Aliases**
: Specify the document alias for purchase documents.  The options available are:

- **All**  - Select this option to include all the document aliases for purchase  documents in the report.
- **Specific**  - Select this option to display only a specific purchase document alias  to be included in the report. Click the button beside the selection field  and select the required document alias. If you select more than one document  alias, the display in the selection field changes to “Multiple”.



**Terms**
: Specify the payment terms that the report should  be based on. The options available are:

- **All**  - Select this option to include all the payment terms for purchase documents  in the report.
- **Specific**  - Select this option to include only the specific payment term for purchase  documents in the report. Click the button beside the selection field and  select the required payment term. If you select more than one payment  term, the display in the selection field changes to “Multiple”.



**Location/Sub-Location**
: Specify the location/sub-location name to be included  in the report. The options available are:

- **All**  - Select this option to include the aging details for all locations/sub-locations  in the report.
- **Specific**  - Select this option to include the aging details only for specific locations/sub-locations  in the report. Click the button beside the selection field and select  the required locations/sub-locations. If you select more than one location/sub-location,  the display in the selection field changes to “Multiple”. The documents  displayed will be for the main location selected and not its sub-locations.



**Day Overdue**
: You can filter the report to include vendor balances  that are due for a specified period. The options available are:

- **Do 
 not consider** - When this option is selected, the report will include  details of outstanding balances, irrespective of the number of days by  which a document is overdue.
- **Between**  - When this option is selected, the report includes only those details  of documents which are overdue by greater than or equal to the value entered  in the field **From** and less  than or equal to the value entered in the field **To**.



{:.example}
You can generate the report for vendors whose balances are due for a  period of 1 to 30 days.
: {:.see_also}
See also
: [Accounts  Payable Aging dialog box]({{site.rpt_baseurl}}/misc/account_payable_aging_dialog_box.html)
: [Accounts  Payable Aging]({{site.rpt_baseurl}}/everest-reports/purchasing/account_payable_aging_rep.html)
: [Purchasing]({{site.rpt_baseurl}}/everest-reports/purchasing/purchasing_reports.html)
