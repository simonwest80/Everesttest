---
title: Critical Items
---

# Critical Items


Critical items are those items without which other items on the sales  order cannot be sold. Dependant items are items whose sale depends on  another. The items on which the dependant items depend on are called critical  items. Dependant items cannot be sold individually without the critical  items.


{:.example}
Critical  item - Computer


Dependent items - Keyboard, mouse and speakers.


You can ship the critical item (computer) without the dependent items  (keyboard, mouse and speakers), but you cannot ship the dependent items  without the critical item.


The **Critical** check box allows  you to specify whether an item is critical to a shipment. The **Critical**  column on the **Sales** **Order**  profile is selected by default for critical items.


![Lens.gif]({{site.mi_baseurl}}/img/lens.gif) [Critical  Column - Sales Orders]({{site.sp_chm}}/sales-docs/docs-profile/contents/item-info/other/critical_and_dependent_on_columns_sales_contents.html)


In sales orders a critical item should have items that are dependant  on it. A sales order cannot be saved and processed, if a dependant item  has not been specified for the critical item. The dependant items are  specified in the **Dependant on** column  of the **Sales** **Order**  profile.


{:.see_also}
See also
: [Other  Sales Information]({{site.mi_baseurl}}/item-profile-details/other-items-information/sales/other_sales_information_item_profile.html)
