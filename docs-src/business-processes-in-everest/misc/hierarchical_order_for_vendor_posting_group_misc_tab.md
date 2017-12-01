---
title: Hierarchical Order for Vendor Posting Group
---

# Hierarchical Order for Vendor Posting Group


First the Posting Group associated to the vendor is checked, if blank,  then it looks into the Posting Group associated to the vendor class. If  that is also blank it looks into the Posting Group associated to the  document’s  location (Vendor Posting Group Type). If this too is blank it looks into  the company defaults (Vendor Posting Group Type).


The hierarchical order for Vendor Posting Group is mentioned below:


Vendor


![]({{site.bp_baseurl}}/img/down arrow.jpg)


**Vendor  Class**


![]({{site.bp_baseurl}}/img/down arrow.jpg)


Location (‘Vendor Posting Group’ Type)


![]({{site.bp_baseurl}}/img/down arrow.jpg)


**Company Defaults (‘Vendor Posting Group’ Type)**


{:.see_also}
See also
: [Document  Dialog Box - Miscellaneous Tab]({{site.bp_baseurl}}/misc/miscellaneous_others_others_2_steps.html#account selection method for resolving posting group conflicts)
