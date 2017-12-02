---
title: Activity Report Dialog Box
---

# Activity Report Dialog Box


Select the following parameters to view the **Activity**  report.


**Account Selection Method**
: Select the report filter method to filter the report.   You can  choose either **Range** (a range of  accounts) or **Smart Filter**. The  **Smart Filter** allows you to use  wildcards to select accounts based on your segments.


**Account Status**
: Select the status for the accounts you want to include  in the report.

- **Active**  – This is the default. The report will only include accounts currently  in use.
- **Discontinued**  – The report will only include discontinued accounts.



**Account From**
: Specify the ending code for the range of accounts  to include in the report. The accounts available depend on the **Account 
 Status** selection.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Drop-Down  List - Right-Click Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html)


**Account To**
: Specify the starting code for the range of accounts  to include in the report. The accounts available depend on the **Account 
 Status** selection.


{:.note}
If options are not selected in the **Account 
 From** and **Account To** fields,  all the account codes are included in the report.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Drop-Down  List - Right-Click Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html)


**Smart Filter**
: Use the **Smart Filter**  to select accounts based on your segments. Wildcards can be used in this  field and up to 250 characters can be entered. **Segment 
 separators** must be entered between segments. Enter a semi-colon  (;) to separate accounts in the **Smart 
 Filter**.


| Smart Filter Wildcard | Meaning |
| ? | One Character |
| \* | Multiple Characters |

: ![]({{site.rpt_baseurl}}/img/lens.gif)[Smart Filter]({{site.rpt_baseurl}}/misc/smart_filter.html)
: ![]({{site.rpt_baseurl}}/img/lens.gif)[Segmented\_Chart\_of\_Accounts]({{site.sc_chm}}/options/acc-info/coa/chart-of-accounts-details/segmented_chart_of_accounts.html)


**Date From**
: Specify the start date for the transactions to be  included in the report.


**Date To**
: Specify the end date for the transactions to be  included in the report.


{:.note}
If you do not specify dates in the **Date 
 From** and **Date To** fields,  the current system date is included in the report.


**Show Cust/Vend**
: Specify the accounts to be included in the report.  The options available in the field are:

- **Both**  - Select this option to include both customer and vendor accounts.
- **Customer**  - Select this option to include customer accounts.
- **Vendor**  - Select this option to include vendor accounts.



**Cust/Vend**
: You can filter the report for a specific vendor/customer  account depending on what you have selected in the previous field. If  you have selected **Customer** in  the **Show Cust/Vend**  field, you can specify a particular customer account in this field.


**Sales/Pur  Rep**
: You can filter the report for a specific sales/purchase  representative. Enter the name of a sales/purchase representative assigned  to the customers/vendors.


**Summary/Detail**
: This report can be generated to print detailed or  summarized information about the account activity. A detailed list provides  elaborate information about each document that affects the account.


**Reporting Currency**
: Select the currency in which debit, credit and balance  amounts are to be displayed.


| **Account Currency** | To display amounts in the currency specified for the  account in the COA. |
| **Base Currency** | To display amounts in the base currency. |
| **Both** | To display amounts in account and base currencies. The  exchange rate between the two currencies is also displayed. |



**Include Unposted Amounts**
: Select this check box to include unposted transactions  in the report.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [The  Posting Process]({{site.acc_chm}}/accounting-structure-in-everest/posting/posting.html)


{:.see_also}
See also
: [Activity]({{site.rpt_baseurl}}/everest-reports/accounting/activity.html)
