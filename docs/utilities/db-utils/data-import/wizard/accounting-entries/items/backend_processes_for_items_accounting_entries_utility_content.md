---
title: Back end Processes for Items
---

# Back End Processes for Items

- The balance in  the Inventory Control account increases to the extent of the item value.
- The balance in  the Journal Difference account, which is an expense account increases  by the value of the items. The balance in the journal difference account  is nullified when the other Trial Balance items are imported.



When items are imported, entries are made in an open general journal  that fulfills the following conditions:

- The login date  falls in the same accounting period as the open general journal.
- The open general  journal belongs to the same journal group as the one selected in **Workstation Settings** (path: **File 
 &gt; Setup &gt; Preferences &gt; Workstation Settings**).
- The open general  journal with the same location/sub-location as the login location/sub-location  of the user importing the balances.
- A system journal  with the description 'Item Import'  exists.



{:.note}
If such an open journal does not exist, a  new general journal is created using the sequence number from the **Location** profile (path: **File**  > **Setup** > **Accounting**  > **Location**/**Sub-Location**>  **Options** > **Edit**  > **In New Window** > **Inventory** tab).
