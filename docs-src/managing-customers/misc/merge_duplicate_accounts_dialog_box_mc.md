---
title: Merge Duplicate Accounts Dialog Box
---

# Merge Duplicate Accounts Dialog Box


Select the following parameters to merge a duplicate account  into a master account.


**Duplicate Account Name**
: Specify the Duplicate Account Name for the customer  account that is to be merged.


**Master Account Name**
: Specify the Master Account Name for the master customer  account into which the duplicate customer account is to be merged.


Address Options


**Discontinue shipping and contact address details  from duplicate account**
: Select this option to discontinue the shipping and  contact addresses specified in the duplicate account.


**Re-assign shipping and contact address details  to master account**
: Select this option to reassign the shipping and  contact address details from the duplicate account to the master account.


After you merge the duplicate account into the master account:

- The merge account  feature deletes the duplicate account from the system and transfers all  the documents of the duplicate account to the master account.
- The **Customers**  browser lists only the master account and the duplicate account is not  listed
- Multimedia Files,  All Sales Documents, Sales Opportunity, Credit Card Information, Sales  History, Account Balance History, Accounts Receivable  Balances,  Open Sales Journals, Tasks, and Memorized Transactions of the duplicate  account are all merged into the master account.
- Sales history for  the duplicate customer account will not be merged on the Dashboard after  using the **Merge Account** feature.   To update  sales history on the Dashboard to include both accounts, the “Start Over”  option must be used in the **Data Warehouse**  > **ETL** **Schedule**.
- Special Pricing,  Special Tax Rules, Wish List, and Customer Tracking details pertaining  to the duplicate customer account will be deleted when the duplicate account  is merged into a master account.
- Payment Terms, Credit  Limit, Custom Fields are retained from the master account.



{:.note}
After using the "Merge Accounts"  feature, it is possible that data from closed years will be affected.  For example, the Aging report (as of date) that previously showed two  accounts will display the same balance under one account after running  the utility.


{:.see_also}
See also
: [Merge  Duplicate Accounts]({{site.mc_baseurl}}/customers-browser/other-options/merge_duplicate_accounts_mc.html)
