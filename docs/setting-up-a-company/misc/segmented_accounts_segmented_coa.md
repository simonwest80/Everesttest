---
title: Segmented Accounts
---

# Segmented Accounts


Accounts can be created using the **Chart 
 of Accounts** profile or browser. If you are using segmented accounts,  enter the **Account Code** without  the segment separators. The segment separators are added automatically.


| ![]({{site.sc_baseurl}}/img/lens.gif) | [Create an  Account]({{site.sc_baseurl}}/options/acc-info/coa/setup-coa/creating_an_account.html) |



Account codes can have characters up to the defined length of each segment.


{:.example}
If your segment length is 3, account codes  for that segment can have 1-3 characters, such as 1, 10, or 100.


Accounts must be created in hierarchical order. Accounts in the 1st  segment must be created before accounts in the 2nd segment. Accounts in  the 2nd segment must be created before the 3rd segment, and so on.


{:.example}
In order to create the account 001-001-supp-5200-001,  accounts used in the segments prior to the last segment must be created:


| Accounts that Must be Created Prior to Creating the  001-001-supp-5200-001 Account |
| 001 |
| 001-001 |
| 001-001-supp |
| 001-001-supp-5200 |



**Detail** accounts can be at different  levels in your segment format, depending upon your business needs.


{:.example}
Account with Detail level at the 4th segment:


| Account | Account Type |
| 001 | General |
| 001-001 | General |
| 001-001-supp | General |
| 001-001-supp-5200 | Detail |



{:.example}
Account with Detail level at the 2nd segment:


| Account | Account Type |
| 001 | General |
| 001-002 | Detail |



![]({{site.sc_baseurl}}/img/see_also.gif)
: [Add  Segment to Chart of Account Profile]({{site.sc_baseurl}}/misc/add_segment_to_account_profile_segmented_coa.html)
