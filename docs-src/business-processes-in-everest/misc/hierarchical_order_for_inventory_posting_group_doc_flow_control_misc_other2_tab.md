---
title: Hierarchical Order for Inventory Posting Group
---

# Hierarchical Order for Inventory Posting Group


First the system looks at the Posting Group defined for each line item.  If this is blank at the **Item** profile  level, then it checks which category it falls into and considers the Posting  Group. If this is not defined at the category level, then it looks if  the category has been defined at **Location-Category**  grid level. (The location in question is the stock area’s location.)


If yes, it picks up the Inventory control account from the grid, else  it considers the Inventory account mentioned under the location (Inventory  Posting Group Type).


The hierarchical order for Inventory Posting Group is mentioned below:


Item


![]({{site.bp_baseurl}}/img/down arrow.jpg)


Item  Category


![]({{site.bp_baseurl}}/img/down arrow.jpg)


Location (Location-Category Grid)


![]({{site.bp_baseurl}}/img/down arrow.jpg)


Location  (‘Inventory Posting Group’ Type)


![]({{site.bp_baseurl}}/img/down arrow.jpg)


Company  Defaults (Inventory Posting Group’ Type)


{:.see_also}
See also
: [Document  Dialog Box - Miscellaneous Tab]({{site.bp_baseurl}}/misc/miscellaneous_others_others_2_steps.html#account selection method for resolving posting group conflicts)
