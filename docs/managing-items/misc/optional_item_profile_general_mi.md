---
title: Optional
---

# Optional


![]({{site.mi_baseurl}}/img/item_profile_general_tab_non_inv_item_circled_mi.gif)


**Figure: Item Profile – General (Non-Inventoried  Item)**


This field allows you to have an non-inventoried item show  in the drop down list for a kit, but be omitted from the sales order.   This field  pertains to non-inventoried items with $0.00 price that are selected as  components of kits either as a kit item or as a related item to a kit  item.


{:.example}
A kit contains an inventoried item, “Printer1”,  with related items of “Printer2” and “No Printer”.  The  “No Printer” item is marked as an optional item.  If  a web shopper selects “No Printer” on the kit configuration page and the  price is $0.00, it will be omitted from the sales order.


An item marked as an optional item displays on the Shopping  Cart page of the web store if it is included as part of a kit , but does  not print on the sales order if its price is $0.00.  If  the price of an item marked as an optional item is updated to a value  greater than $0.00, the item is no longer considered an optional item  and will be displayed in the sales order.


{:.note}
This feature is only available with **Everest eStorefront Professional**.


{:.see_also}
See also
: [The Item  Profile - General]({{site.mi_baseurl}}/create-regular-items-kits-and-assemblies/creating-an-item/the_item_profile_-_general.html)
