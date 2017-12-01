---
title: The Lot History Browser Migration Records
---

# The Lot History Browser - Migration Records


Migration Records in the Lot History Browser


If you have upgraded from a previous version of **Everest**,  the **Lot History** browser will only  display the stock quantity of the Lot as on the date of upgrade with the  transaction type as ‘Opening Balance’.


The following record is created on migration for all lot tracked items:


| Field | Description |
| Document Date | Date of Migration |
| Quantity in Stock | Stock for the Lot as on Date |
| Stock UM | Stock Unit of Measure |
| Transaction Type | Displays the Transaction Type ‘Opening Balance’ |



This record appears as a line in the **Lot 
 History** browser.


{:.example}
Item A is created and lot tracked using version  2.1.  Item  A has 10 units in Lot 1234 and 20 units in Lot 4321.  After  the migration to version 3.0, the **Lot 
 History** browser for Lot 1234 displays an opening balance of 10  and the **Lot History** browser for  Lot 4321 displays an opening balance of 20. These opening balances are  the initial balances of the two lots in version 3.0.


{:.see_also}
See also
: [The Lot History  Browser]({{site.wm_baseurl}}/lot-number-tracking/assigning-a-lot-number/the_lot_history_browser.html)
