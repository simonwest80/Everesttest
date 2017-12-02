---
title: Hierarchical Order for Customer Posting Group
---

# Hierarchical Order for Customer Posting Group


First the Posting Group associated to the customer is checked, if blank,  then it looks into the Posting Group associated to the customer class.  If that is also blank it looks into the Posting Group associated to the   document’s  location (Customer Posting Group Type). If this too is blank it looks  into the company defaults (Customer Posting Group Type).


The hierarchical order for Customer Posting Group is mentioned below:


Customer


![]({{site.bp_baseurl}}/img/down arrow.jpg)


**Customer  Class**


![]({{site.bp_baseurl}}/img/down arrow.jpg)


**Location  (‘Customer Posting Group’ Type)**


![]({{site.bp_baseurl}}/img/down arrow.jpg)


**Company Defaults (‘Customer Posting Group’  Type)**


{:.see_also}
See also
: [Document  Dialog Box - Miscellaneous Tab]({{site.bp_baseurl}}/misc/miscellaneous_others_others_2_steps.html#account selection method for resolving posting group conflicts)
