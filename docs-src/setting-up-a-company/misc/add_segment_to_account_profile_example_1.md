---
title: Add Segment to Account Profile - Example 1
---

# Add Segment to Account Profile - Example 1


{:.example}
A company has a Segment Format of Div-Dep-Bra-Acct  (Division, Department, Branch, and Account). The accounts that have been  created are:


| Existing Accounts |
| 001 |
| 001-001 |
| 001-001-mai |
| 001-001-mai-5200 |
| 002 |
| 002-001 |
| 002-002 |
| 002-003 |
| 002-004 |
| 002-005 |



Division 1 posts at the account level and Division 2 currently posts  at the department level. Division 2 would like to post at the branch level  since they added a new NC branch.


In the **Chart of Accounts** browser,  the user highlights account 002-001 and selects the **Add 
 Segment to Account** option.


![]({{site.sc_baseurl}}/img/coa add segment to chart of account example 1.gif)


The **Parent Account Code** field  displays 002-001. The **Account Code**  field displays 002-001-000 since the length of the branch segment is three.  The original account, 002-001, becomes a general account and the balances  from this account are transferred to the new account.


![]({{site.sc_baseurl}}/img/see_also.gif)
: [Add  Segment to Account Profile]({{site.sc_baseurl}}/misc/add_segment_to_account_profile_segmented_coa.html)
