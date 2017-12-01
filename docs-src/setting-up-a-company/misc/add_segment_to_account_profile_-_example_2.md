---
title: Add Segment to Account Profile - Example 2
---

# Add Segment to Account Profile - Example 2


{:.example}
Another company has a segment format of COM-BRAN.  The detail account is 001-Main and postings have been made to this account  in the amount of $5,000.


Before Adding Segment to Account:


| Account | Account Type | Balance |
| 001-Main | Detail | $5,000 |



The user adds a 4 character segment to their segment format called DIVS.  The user accepts the default account code of 0000 for historic transactions  and creates a new detail account called 001-Main-Svcs for new transactions.


After Adding Segment to Account:


| Account | Account Type | Balance |
| 001-Main | General | $0 |
| 001-Main-0000 | Detail (For Historical Transactions) | $5,000 |
| 001-Main-Svcs | Detail | $0 |



The 001-Main account becomes a general account and is a parent account  of 001-Main-0000. The $5,000 balance gets transferred to the 001-Main-0000  account. Transactions can now be posted to 001-Main-0000 or 001-Main-Svcs.  Since 001-Main is now a general account, no transactions can be posted  to it. To transfer part of the $5,000 balance to the 001-Main-Svcs account,  the user must create a manual entry to the General Journal.


![]({{site.sc_baseurl}}/img/see_also.gif)
: [Add  Segment to Account Profile]({{site.sc_baseurl}}/misc/add_segment_to_account_profile_segmented_coa.html)
