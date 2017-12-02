---
title: Income Statement (Yearly) Dialog Box
---

# Income Statement (Yearly) Dialog Box


Select the following parameters to view the **Income 
 Statement Yearly** report.


**Fiscal Year**
: Enter the fiscal year to use for creating the income  statement. The Income Statement Yearly Report is limited to a maximum  of 24 periods defined for a fiscal year.


{:.example}
If you select 2006 as the Fiscal Year, the generated report includes  a monthly break up of income and expenses from January to December 2006.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Drop-Down  List - Right-Click Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html)


**Report Type**
: Select the type of report you want to generate.  If you select the option **Detail**,  the report displays a break up of the revenues and expenses by locations/sub-locations.  If the option **Summary** is selected,  only total revenues and expenses are displayed.


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
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Drop-Down  List - Right-Click Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html)


**Include Unposted Amounts**
: Select this check box to display the current balance  which will include posted and unposted amounts. You can select only one  of the two check boxes - **Provisionally 
 Posted Amounts** or **Unposted Amounts**.


{:.note}
You can either include provisionally posted amounts or unposted amounts  in the report.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [The  Posting Process]({{site.acc_chm}}/accounting-structure-in-everest/posting/posting.html)


**Hide Accounts with Zero balance**
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
: [Income Statement  Yearly]({{site.rpt_baseurl}}/everest-reports/financial/income_statement_yearly.html)
: [Financial Reports]({{site.rpt_baseurl}}/everest-reports/financial/financial.html)
