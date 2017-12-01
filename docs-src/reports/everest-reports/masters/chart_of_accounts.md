---
title: Chart of Accounts
---

# Chart of Accounts


The **Chart of Accounts** report  displays account details for a range of accounts, or for all accounts,  in a hierarchical order. The report provides you with a snapshot of the  basic accounting structure of your company. It displays the following  information:

- Account code and  description
- Type of account  - Asset, Liability, Capital, Expense or Revenue account.
- The level each  account belongs to.
- Parent account  code.
- Whether the account  is a General (G)  or a Detail (D) account.



![]({{site.rpt_baseurl}}/img/lens.gif)[General  and Detail]({{site.acc_chm}}/accounting-structure-in-everest/chart_of_accounts_accounting.html)


{:.steps}
To generate the Chart of Accounts report, do the following:

- From the main  menu bar, select **Reports &gt; Masters 
 &gt; Chart of Accounts**. You will see the **Chart 
 of Accounts** dialog box.
- Specify the  report parameters and click:


- **Preview**,  to preview the report in the **Report Preview** dialog box
- **Print**,  to print the report
- **Export**,  to save the report in text, Excel, HTML or Crystal Report file formats



Chart of Accounts Dialog Box


**Account Selection Method**
: Select the report filter method to filter the report.   You can  choose either **Range** (a range of  accounts) or **Smart Filter**. The  **Smart Filter** allows you to use  wildcards to select accounts based on your segments.


**Account From**
: Specify the starting account code for the range  of accounts to be included in the report.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Drop-Down  List - Right-Click Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html)


**Account To**
: Specify the ending account code for the range of  accounts to be included in the report.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Drop-Down  List - Right-Click Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html)


{:.note}
If values are not specified in the **Account 
 From** and the **Account To**  fields, all the accounts are included in the report.


**Smart Filter**
: Use the **Smart Filter**  to select accounts based on your segments. Wildcards can be used in this  field and up to 250 characters can be entered. **Segment 
 separators** must be entered between segments. Enter a semi-colon  (;) to separate accounts in the **Smart 
 Filter**.


| Smart Filter Wildcard | Meaning |
| ? | One Character |
| \* | Multiple Characters |

: ![]({{site.rpt_baseurl}}/img/lens.gif)[Smart Filter]({{site.rpt_baseurl}}/misc/smart_filter.html)
: ![]({{site.rpt_baseurl}}/img/lens.gif)[Segmented\_Chart\_of\_Accounts]({{site.sc_chm}}/options/acc-info/coa/chart-of-accounts-details/segmented_chart_of_accounts.html)


{:.see_also}
See also
: [Masters]({{site.rpt_baseurl}}/everest-reports/masters/master_reports.html)
