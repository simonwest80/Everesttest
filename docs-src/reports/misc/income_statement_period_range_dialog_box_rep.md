---
title: Income Statement (Period Range) Dialog Box
---

# Income Statement (Period Range) Dialog Box


Select the following parameters to view the **Income 
 Statement** (**Period Range**)  report.


{:.example}
If you select 2006 as the Fiscal Year and  you have defined your fiscal year as starting in January and ending December  31, when you select the Start Period as 1 and the End Period as 10, the  system generates the income statement report for the period January to  October 2006.


**Fiscal Year**
: Select the fiscal year for which you want to generate  the income statement.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Drop-Down  List - Right-Click Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html)


**Start Period**
: Specify the starting period for the period range.  The report will be generated from the first day of the start period.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Drop-Down  List - Right-Click Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html)


**End Period**
: Specify the ending period for the period range.   The report  will be generated up to the last day of the end period.


{:.note}
**The statement will consider all transactions  for the period starting on the first day of the starting period and ending  on the last day of the ending period.**
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Drop-Down  List - Right-Click Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html)


**Location/Sub-Location Code**
: Select the location/sub-location to which the transactions  are allocated. This allows you to obtain the income statement for a specified  location or sub-location or cost/profit center.


{:.note}
**If this field is left blank, the report displays  period comparison according to each locations/sub-locations.**


**Smart Filter**
: Use the **Smart Filter**  to select accounts based on your segments. Wildcards can be used in this  field and up to 250 characters can be entered. **Segment 
 separators** must be entered between segments. Enter a semi-colon  (;) to separate accounts in the **Smart 
 Filter**.


| Smart Filter Wildcard | Meaning |
| ? | One Character |
| \* | Multiple Characters |



{:.example}
If you enter **01-10-21-***  in the **Smart Filter** field, you  will filter for all accounts that begin with the segments 01-10-21-.
: ![]({{site.rpt_baseurl}}/img/lens.gif)[Smart Filter]({{site.rpt_baseurl}}/misc/smart_filter.html)
: ![]({{site.rpt_baseurl}}/img/lens.gif)[Segmented\_Chart\_of\_Accounts]({{site.sc_chm}}/options/acc-info/coa/chart-of-accounts-details/segmented_chart_of_accounts.html)


**Include Provisionally Posted Amounts**
: Select this check box to include provisionally posted  balances.


**Include Unposted Amounts**
: Select this check box to display the current balance  which includes posted and unposted amounts. You can either select the  **Include Provisionally Posted Amounts**  or the **Include Unposted** Amounts.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [The  Posting Process]({{site.acc_chm}}/accounting-structure-in-everest/posting/posting.html)


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
: [Income  Statement (Period Range)]({{site.rpt_baseurl}}/everest-reports/financial/income_statement_period_range_.html)
: [Financial]({{site.rpt_baseurl}}/everest-reports/financial/financial.html)
