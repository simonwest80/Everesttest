---
title: Attach/Commit Items to a Work Order
---

# Attach/Commit Items to a Work Order


You can attach/commit items to a work order when they are identified/segregated  for use in production.

- [Serialized  Inventory]({{site.ba_baseurl}}/prod-asm/att-cmt-items-to-wo/ser-items/serialized-inventory.html)
- [Non-Serialized  Inventory]({{site.ba_baseurl}}/prod-asm/att-cmt-items-to-wo/ns-items/retrieve-non-serialized-items.html)
- [Auto-serialized  Inventory]({{site.ba_baseurl}}/prod-asm/att-cmt-items-to-wo/as-items/retrieve-auto-serialized-inventory.html)



The **Actual Input** column in the  **Work Order** profile displays the  item quantity that is committed on the work order. Committed items on  a work order are recorded in an 'In type' of Stock Area.


![]({{site.ba_baseurl}}/img/lens.gif) [Attach/Commit  Items on Work Order - Stock areas assigned]({{site.ba_baseurl}}/prod-asm/att-cmt-items-to-wo/set_stock_area_preferences_add_items_to_a_work_order_assembly_content.html)


If the committed quantity exceeds the standard quantity, you are informed  of the same and asked to confirm that you want to proceed.


If you choose to continue, the **Actual 
 Input** column gets updated with the committed quantity. This is  applicable to all items - serialized, non-serialized or auto-serialized.


{:.note}
You cannot attach or detach inventoried item quantities to/from the  work order when it is in the **In Process** stage.


You can add/delete non-inventoried items to/from a work order until  the **Build** stage.


{:.see_also}
See also
: [Item  Details Grid]({{site.ba_baseurl}}/prod-asm/creating-wo/wo-details/item-dtls/item_details_grid_work_order_profile_assembly_contents.html)
