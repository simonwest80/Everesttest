---
title: Periods Status
---

# <font style="color: #000000;" color="#000000">Periods Status</font>


Three types of status are available for each period: **Active**,  **Lock** and **Open**.  The status of each period can be defined as follows:


**Open**
: When periods are first established, their status  is defined as open. Transactions flow into any open period depending on  the date specified when creating the transaction. In **Everest**,  you can have any number of periods open simultaneously.


**Active**
: This status overrides the **Open**  status of other periods and directs transactions appropriately dated to  that one active period. If a period is made active, the dates of the final  transactions must be within the active period. The final documents whose  dates fall out of the active period cannot be created. Further, any transaction  that has an effect on the COA  is not allowed in any of the non-active periods, i.e., open periods. Only  one period can be active at any point of time.


**Lock**
: Locked periods are those which are not available  for transactions. You may change the status of a period to lock when you  no longer want anyone to create transactions for that period. When a fiscal  year is closed, all periods within the year are automatically locked.


{:.see_also}
See also
: [Change Period  Status]({{site.sc_baseurl}}/options/acc-info/fiscal-year-and-periods/change_period_status.html)
