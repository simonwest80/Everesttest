---
title: Trial Balance Dialog Box
---

# Trial Balance Dialog Box


Select the following parameters to view the **Trial 
 Balance** report:


**Fiscal Year**
: Select the fiscal year that the balance sheet should  pertain to.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Drop-Down  List - Right-Click Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html)


**Period From**
: Specify the starting period for the range of accounting  periods to be included in the report.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Drop-Down  List - Right-Click Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html)


**Period To**
: Specify the ending period for the range of accounting  periods to be included in the report.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Drop-Down  List - Right-Click Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html)


**Income and Expense Balance**
: **Everest**  allows you to allocate expenses and revenues to specific sub-locations  or locations. Use this option to select the display of  income  and expense balances in the trial balance report.

- **Consolidated 
 for all Locs/Sub-Locs**– If this option is selected, a single consolidated  amount is displayed against each account.   This  amount represents the total balance of that account and includes unallocated  amounts and allocations made to all locations/sub-locations.
- **Breakup 
 for all Locs/Sub-Locs** – If this option is selected, the balance  in each income and expense account is broken up into unallocated amounts  and amounts allocated to each locations/sub-locations.



{:.note}
Amounts displayed against locations and sub-locations  with sub-sub-locations only relate to amounts specifically allocated to  that location and sub-location; the balance does not include balances  of sub-sub-locations for that account.

- **Selected 
 Locs/Sub-Locs**– If this option is selected, the balances of income  and expense accounts displayed pertain to amounts allocated to the selected  location/sub-location only.



**Location/Sub-Location**
: Select the location/sub-location for which you want  to generate the trial balance report. This field is enabled only when  the option **Selected Locs/Sub-Locs**s  specified. This allows you to obtain the income statement for a specified  location or sub-location or cost/profit center.


{:.note}
- The balances  of assets and liabilities will not be displayed with this selection, as  amounts accounted in asset and liability accounts cannot be allocated  to locations/sub-locations.
- Only amounts  allocated to the selected locations/sub-locations will be included in  the balance displayed; balances of sub-sub-locations will not roll up  into the balance of the selected location/sub-location.
- The total of  debit balances may not equal the credit balances as the crossing entries  for a transaction may be allocated to other locations/sub-locations, or  may relate to asset and liability accounts.
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


**Include General Accounts**
: Select this check box to include details of the  general (or parent) accounts in the report.


**Include Provisionally Posted Amounts**
: Select this check box to include provisionally posted  amounts in the account balance. The account balance used in the report  would be the sum of the posted balance and the provisionally posted amounts.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Provisional  Posting]({{site.acc_chm}}/provisionally-posting-journals/provisional_posting.html)


**Include Unposted Amounts**
: Select this check box if you want the report to  list the current balance inclusive of unposted amounts.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [The  Posting Process]({{site.acc_chm}}/accounting-structure-in-everest/posting/posting.html)


**Hide Accounts with Zero Balance**
: Select this check box to exclude accounts with a  zero balance from the report. This will also exclude discontinued accounts.  If left unchecked, all accounts display regardless of the balance status.


{:.see_also}
See also
: [Trial Balance]({{site.rpt_baseurl}}/everest-reports/financial/trial_balance.html)
: [Financial]({{site.rpt_baseurl}}/everest-reports/financial/financial.html)
