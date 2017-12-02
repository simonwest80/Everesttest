---
title: Income Statement (History/Budget - Comp) Dialog Box
---

# Income Statement (History/Budget - Comp) Dialog Box


Select the following parameters to view the **Income 
 Statement** (**History** - **Budget**) report.


**Fiscal Year**
: Select the fiscal year for which you want to view  the income statement.


**Report Type**
: Select the type of report to be generated from the  drop-down list. The options are:

- **Budget 
 -** Select this option to compare the actuals  of the specified period with the budgeted amounts specified for the same  period and fiscal year.
- **History**  - Select this option to view the balances for the selected period and  for the corresponding period in the previous fiscal year. The variance  is also calculated and displayed.



{:.example}
If the starting and ending periods were January  2008 and April 2008, the corresponding historical periods are January  2007 to April 2007. If the previous fiscal year was an extended fiscal  year from April 2006 to December 2007 as the company moved to the calendar  fiscal, the corresponding history would be from April 2006 to July 2006.


**Start Period**
: Specify the starting period for the range of periods  to be included in the report.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Drop-Down  List - Right-Click Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html)


**End Period**
: Specify the ending period for the range of periods  to be included in the report.


{:.note}
**The report considers all transactions for  the period starting on the first day of the starting period and ending  on the last day of the ending period.**
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Drop-Down  List - Right-Click Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html)


**Location/Sub-Location**
: Select the location/sub-location to which the transactions  are allocated. This allows you to obtain the income statement for a specified  location or sub-location or cost/profit center. For a report that includes  all locations, leave this field blank.


{:.note}
**If you select **Budget**  in the **Report Type** field, this  field is disabled as **Everest** does  not allow you set up budgets for individual locations/sub-locations. Instead,  the budget amounts are displayed for all locations/sub-locations.**
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Drop-Down  List - Right-Click Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html)


**Smart Filter**
: Use the **Smart Filter**  to select accounts based on your segments. Wildcards can be used in this  field and up to 250 characters can be entered. **Segment 
 separators** must be entered between segments. Enter a semi-colon  (;) to separate accounts in the **Smart 
 Filter**.


| Smart Filter Wildcard | Meaning |
| ? | One Character |
| \* | Multiple Characters |



{:.example}
If you enter **R05***  in the **Smart Filter** field, you  will filter for all accounts that begin with R05.
: ![]({{site.rpt_baseurl}}/img/lens.gif)[Smart Filter]({{site.rpt_baseurl}}/misc/smart_filter.html)
: ![]({{site.rpt_baseurl}}/img/lens.gif)[Segmented\_Chart\_of\_Accounts]({{site.sc_chm}}/options/acc-info/coa/chart-of-accounts-details/segmented_chart_of_accounts.html)


**Include Provisionally Posted Amounts**
: Select this check box to include provisionally posted  balances.


**Include Unposted Amounts**
: Select this check box to display the current balance  which will include posted and unposted amounts. You can select only one  of the two check boxes - **Provisionally 
 Posted Amounts** or **Unposted Amounts**.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [The  Posting Process]({{site.acc_chm}}/accounting-structure-in-everest/posting/posting.html)


{:.note}
You can either include provisionally posted amounts or unposted amounts  in the report.


**Hide Accounts with Zero Balance**
: Select this check box to exclude accounts with a  zero balance from the report. This will also exclude discontinued accounts.  If left unchecked, all accounts display regardless of the balance status.


**Show Location Details**
: Select this check box to include a location-wise  breakup of the income statement report. If unchecked, the report will  show the summary of total income and expenses.


{:.note}
This field is disabled if you choose a specific location in the **Location/Sub-Location** field.


**Show Other Income (Expenses) Details**
: Select this check box to include the details of  Other Income (Expenses). If unchecked, the report will show the summary  of Other Income (Expenses).


**Show Provisional Tax Details**
: Select this check box to include Provisional Tax  details in the report. If unchecked, the report will include the summary  of Provisional Tax details.
: The generated report classifies the Income Statement  for the specified Fiscal Period as follows:

1. Total Revenue
- Total Cost of Goods Sold
- Gross Profit
- Total Operating Expense
- Total Other Income (Expenses)
- Total Provision for Income Taxes

: These report classifications are generated only  when the values are available. The report gives a percentage calculation  on Total Product Revenue for each of these.  The  Gross Profit is shown only when Cost of Goods Sold type of accounts are  printed.
: The summary of the following are calculated and  given in the report:


| 1. | Gross Profit | = | Total Revenue - Total Cost of Goods Sold |
| 2. | Income from Operations | = | Gross Profit - Total Operating Expenses |
| 3. | Income before Income Taxes | = | Income from Operations + Other (Expense) Income |
| 4. | Net Income | = | Income before Income Taxes - Provision for Income Taxes |



{:.see_also}
See also
: [Income  Statement (History - Budget)]({{site.rpt_baseurl}}/everest-reports/financial/income_statement_history_budget_.html)
: [Financial Reports]({{site.rpt_baseurl}}/everest-reports/financial/financial.html)
