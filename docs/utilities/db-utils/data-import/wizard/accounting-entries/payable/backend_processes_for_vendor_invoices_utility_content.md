---
title: Back End Processes - Importing Accounts Payable Details
---

# Back End Processes - Importing Accounts Payable Details

- The balance  in the **Accounts Payable Control**  account increases or decreases by the amount in the purchase invoice or  debit memo documents.
- **Crossing 
 Entry Account (1-4)** balances increase (debit) and the **Accounts 
 Payable Control** account balance decreases (credit) for purchase  invoice documents.
- **Crossing 
 Entry Account (1-4)** balances decrease (credit) and the **Accounts 
 Payable Control** account balance increases (debit) for debit memo  documents.
- If crossing  amounts are negative, then the amount in the **Accounts 
 Payable Control** account is debited for purchase invoices and credited  for debit memos.
- All import  rows must result in a balanced journal entry.



Purchase Invoice


A manual purchase invoice is automatically generated when a purchase  invoice is imported.


Debit Memo


A manual debit memo is automatically generated when a debit memo is  imported.


When you import purchase invoices and debit memos, entries are made  in an open purchase journal that fulfils the following conditions:

- The login date  falls in the same accounting period as the open purchase journal.
- The open purchase  journal belongs to the same journal group as the one selected in **Workstation Settings** of the user (path:  **File &gt; Setup &gt; Preferences &gt; 
 Workstation Settings**).
- The open purchase  journal with the same location/sub-location as the login location/sub-location  of the user importing the balances.
- A system journal  with the description 'A/P Import'  exists.



{:.note}
If such an open journal does not exist, a  new purchase journal is created using the sequence number from the **Location** profile (path: **File**  > **Setup** > **Accounting**  > **Location**/**Sub-Location**>  **Options** > **Edit**  > **In New Window** > **Purchasing** tab).


{:.see_also}
See also
: [Location/Sub-Locations]({{site.sc_chm}}/options/locations-and-sub-locations/locations_and_departments.html)
