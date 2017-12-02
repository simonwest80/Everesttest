---
title: Income Statement (Period Comparison) Dialog Box
---

# Income Statement (Period Comparison) Dialog Box


In the **Income Statement (Period Comparison)**  dialog box, select the two periods to be compared. The first two fields  are for the first period being compared (Fiscal Year 1 and Period) and  the next two fields (Fiscal Year 2 and Period) are for the second period.  Once you select your periods to compare, select the other report parameters.


{:.example}
You can compare the income statements for December 2006 and December  2007


**Fiscal Year 1**
: Select the first fiscal year for which you want  to compare the income statement.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Drop-Down  List - Right-Click Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html)


**Period**
: Specify the period for which you want to compare  the income and expenses.


**Fiscal Year 2**
: Select the second fiscal year for comparison. The  system will generate the comparison report for the specified periods of  Fiscal Year 1 and Fiscal Year 2.


**Period**
: Specify the next period for comparison.


{:.example}
: To Compare Period 11 of Fiscal Year 2008 with Period  11 of Fiscal Year 2007, enter the following in the Income Statement (Period  Comparison) dialog box:
: **Fiscal Year 1**:  2008
: **Period**:  11
: **Fiscal Year 2**:  2007
: **Period**:  11


**Location/Sub-Location**
: Select the location/sub-location to which the transactions  are allocated. This allows you to obtain the income statement for a specified  location or sub-location or cost/profit center.


{:.note}
If this field is left blank, the report displays  period comparison consolidated for all locations/sub-locations.


**Smart Filter**
: Use the **Smart Filter**  to select accounts based on your segments. Wildcards can be used in this  field and up to 250 characters can be entered. **Segment 
 separators** must be entered between segments. Enter a semi-colon  (;) to separate accounts in the **Smart 
 Filter**.


| Smart Filter Wildcard | Meaning |
| ? | One Character |
| \* | Multiple Characters |



{:.example}
If you enter **01-10-21-104**  in the **Smart Filter** field, you  will filter for that specific account only.
: ![]({{site.rpt_baseurl}}/img/lens.gif)[Smart Filter]({{site.rpt_baseurl}}/misc/smart_filter.html)
: ![]({{site.rpt_baseurl}}/img/lens.gif)[Segmented\_Chart\_of\_Accounts]({{site.sc_chm}}/options/acc-info/coa/chart-of-accounts-details/segmented_chart_of_accounts.html)


**Include Provisionally Posted Amounts**
: Select this check box to include provisionally posted  balances.


**Include Unposted Amounts**
: Select this check box to display the current balance  which will include posted and unposted amounts. You can select only one  of the two check boxes - **Provisionally 
 Posted Amounts** or **Unposted Amounts**.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [The  Posting Process]({{site.acc_chm}}/accounting-structure-in-everest/posting/posting.html)


**Hide Accounts with Zero Balance**
: Select this check box to exclude accounts with a  zero balance from the report. This will also exclude discontinued accounts.  If left unchecked, all accounts display regardless of the balance status.


**Show Location Details**
: Select this check box to include all of the details  for the individual locations. Clear this check box if you do not want  to include the location details and instead want a summary for all locations.


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
: [Income  Statement (Period Comparison)]({{site.rpt_baseurl}}/everest-reports/financial/income_statement_period_comparison_.html)
: [Financial]({{site.rpt_baseurl}}/everest-reports/financial/financial.html)
