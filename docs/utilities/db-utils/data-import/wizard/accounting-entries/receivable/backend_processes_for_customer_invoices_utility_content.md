---
title: Back End Processes - Importing Accounts Receivable Details
---

# Back End Processes - Importing Accounts Receivable Details

- The balance  in the **Accounts Receivable Control**  account increases or decreases by the amount in the sales invoice or credit  memo documents.
- **Crossing 
 Entry Account (1-4)** balances decrease (credit) and the **Accounts 
 Receivable Control** account balance increases (debit) for sales  invoice documents.
- **Crossing 
 Entry Account (1-4)** balances increase (debit) and the **Accounts 
 Receivable Control** account balance decreases (credit) for credit  memo documents.
- If crossing  amounts are negative, then the amount in the **Accounts 
 Receivable Control** account is credited for sales invoices and debited  for credit memos.
- All import  rows must result in a balanced journal entry.



Sales Invoice


A manual sales invoice is automatically generated when you import a  sales invoice.


![]({{site.utl_baseurl}}/img/lens.gif) [Customer  Profile - Accounting Tab]({{site.mc_chm}}/creating-a-customer/the-customer-profile-accounting/the_customer_profile_accounting.html)


Credit Memo


A manual credit memo is automatically generated when you import a credit  memo.


When you import Accounts Receivable balances and credit memos, entries  are made in an open sales journal that fulfills the following conditions:

- The login date  falls in the same accounting period as the open sales journal.
- The open sales  journal belongs to the same journal group as the one selected in **Workstation Settings** of the user (path:  **File &gt; Setup &gt; Preferences &gt; 
 Workstation Settings**).
- The open sales  journal belongs to the same location/sub-location as the login location/sub-location  of the user importing the balances.
- A system journal  with the description 'A/R Import'  exists.



{:.note}
If such an open journal does not exist, a  new sales journal is created using the sequence number from the **Location** profile (path: **File**  > **Setup** > **Accounting**  > **Location**/**Sub-Location** > **Options** > **Edit** > **In 
 New Window** > **Invoicing**  tab).


{:.see_also}
See also
: [Locations/Sub-Locations]({{site.sc_chm}}/options/locations-and-sub-locations/locations_and_departments.html)
