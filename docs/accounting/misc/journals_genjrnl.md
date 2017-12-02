---
title: Journal Information
---

# Journal Information


Journal information relates to the number, description and fiscal period  for the transaction. It is common to all transactions in the journal.


**Journal #**
: This field denotes the unique number used to identify  the journal, and is automatically generated. You can view other journals  by selecting a journal number from the drop-down list.
: When a new general journal is created, the number  assigned is the following number in sequence specified for general journals  in the login location or the parent location of the login sub-location.  The sequence numbers are specified in the **Location**  profile (path: **File** > **Setup** > **Accounting**  > **Location**/**Sub-Location** > **Options** > **Edit** > **In****New Window** > **Accounting**  tab > **General** **journal****#** field).
: ![]({{site.acc_baseurl}}/img/lens.gif) [Location  Profile - Accounting Tab]({{site.sc_chm}}/options/locations-and-sub-locations/set-up-locations/location_profile_accounting.html)
: If sequence numbers are not defined for the login  location or the parent location of the login sub-location, the sequence  number assigned to the default location is assigned to the document. The  default location is specified in the **Accounting**  dialog box (path: **File &gt; Setup &gt; 
 Preferences &gt; Defaults &gt; Accounting &gt; Miscellaneous** tab **&gt; Default Location** field).
: ![]({{site.acc_baseurl}}/img/lens.gif) [Journals]({{site.acc_baseurl}}/accounting-structure-in-everest/journals/journals.html)
: [Default  Location]({{site.sc_chm}}/misc/default_location.html)


**Fiscal Year and Period**
: The fiscal year and period for the journal is displayed  in these fields. The transaction date of all accounting entries in the  journal must fall in this period. The fiscal year and period cannot be  modified once the journal has been saved.
: ![]({{site.acc_baseurl}}/img/lens.gif) [Fiscal  Year and Periods]({{site.sc_chm}}/options/acc-info/fiscal-year-and-periods/fiscal_year_and_periods_1.html)


**Journal Group**
: This field displays the journal group selected in  the **Workstation Settings** dialog  box (path: **File** > **Setup** > **Preferences** > **Workstation Settings** > **Company 
 Settings** tab > **Journal Group** field) at the time of creating the transaction. All transactions  accounted in the journal belong to the same journal group. You cannot  edit the journal group after saving the **General 
 Journal** profile.


![]({{site.acc_baseurl}}/img/lens.gif) [Journal  Groups]({{site.sc_chm}}/options/acc-info/journal-groups/journal_groups.html)


**Description**
: The journal description helps the user identify  the nature of transactions in the journal. This description is printed  on all applicable reports.
: The description for the different system general  journals are:

- When stocks  are transferred – Stock transfer
- When inventory  costs are adjusted - Cost Adjustment
- For price protection  adjustments – Price Protection
- For quantity  adjustments - Quantity Adjustment
- When item balances  are imported – Inventory Import Journal
- For depreciation  entries – Depreciation
- Adjusting entries  on bank reconciliation – Bank reconciliation adjustments
- Creating opening  balances for new company – Opening Balances
- Year end closing  entries – Three journals entries are created with the following descriptions:



| Journal Description | Journal Created to: |
| Transfer to Retained Earnings account | Transfer the difference between the income and  expense accounts to the retained earnings account |
| Closing balance carried forward to next year | Close the balance sheet accounts |
| Opening balances brought forward from previous  year | State opening balances of the balance sheet  accounts |



{:.see_also}
See also
: [System  General Journal Profile]({{site.acc_baseurl}}/general-journals/system-general-journals/system_general_journal_profile_general.html)
: [Editing  accounts in journals]({{site.acc_baseurl}}/misc/editing_accounts_in_journals_accounting.html)
