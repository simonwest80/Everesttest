---
title: Income Statements (Period Year to date) Dialog Box
---

# Income Statements (Period Year to Date) Dialog Box


Select the following parameters to view the **Income 
 Statement** **(Period Year to Date)**  report.


**Fiscal Year**
: Select the fiscal year for which you want to generate  the income statement.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Drop-Down  List - Right-Click Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html)


**Period**
: Enter the accounting period that is to be compared  with the year (any fiscal year) to the current date.


{:.note}
If you enter ‘3’ in the field on 09/12/2008,  the income statement is compared for the accounting period ‘3’ and the  revenues and expenses of the company in 2008 till 09/12/2008.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Drop-Down  List - Right-Click Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html)


**Location/Sub-Location Code**
: Select the location/sub-location to which the transactions  are allocated. This allows you to obtain the income statement for a specified  location or sub-location or cost/profit center.


{:.note}
If this field is left blank, the income statement  compares revenues and expenses for all locations/sub-locations.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Drop-Down  List - Right-Click Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html)


**Smart Filter**
: Use the **Smart Filter**  to select accounts based on your segments. Wildcards can be used in this  field and up to 250 characters can be entered. **Segment 
 separators** must be entered between segments. Enter a semi-colon  (;) to separate accounts in the **Smart 
 Filter**.


| Smart Filter Wildcard | Meaning |
| ? | One Character |
| \* | Multiple Characters |



{:.example}
If you enter **01-10-21-10?**  in the **Smart Filter** field, you  get accounts such as 01-10-21-10**1**,  01-10-21-10**2**, and 01-10-21-10**3**.
: ![]({{site.rpt_baseurl}}/img/lens.gif)[Smart Filter]({{site.rpt_baseurl}}/misc/smart_filter.html)
: ![]({{site.rpt_baseurl}}/img/lens.gif)[Segmented\_Chart\_of\_Accounts]({{site.sc_chm}}/options/acc-info/coa/chart-of-accounts-details/segmented_chart_of_accounts.html)


**Include Provisionally Posted Amounts**
: Select this check box to include provisionally posted  balances.


**Include Unposted Amounts**
: Select this check box to display the current balance  which will include posted and unposted amounts. You can select only one  of the two check boxes - **Provisionally 
 Posted Amounts** or **Unposted Amounts**.
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
: [Income  Statement (Period Year to Date)]({{site.rpt_baseurl}}/everest-reports/financial/income_statement_period_year_to_date_.html)
: [Financial Reports]({{site.rpt_baseurl}}/everest-reports/financial/financial.html)
