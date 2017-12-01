---
title: Back End Processes - Attach/Commit Quantities
---

# Back End Processes - Attach/Commit Quantities


The following back end processes occur when items are attached to a  work order:

- The stock status  of the item displays the following changes (as displayed in the **Item Stock Status** dialog box):


- **Stock 
 status for the item** - There is an increase in the **On 
 Reserve Committed** stock and a reduction in the **Free 
 Stock** at the item level (by the quantity committed).
- **Item 
 stock status in the original stock area** - There is a decrease in  the quantity of the **Stock** and  **Free Stock** (i.e. the stock available  for sale) of the item (by the quantity committed) in the original stock  area.
- **Item 
 stock status in the committed stock area** - There is an increase  in the **Stock** and **On 
 Reserve** stock (by the quantity committed) in the stock area to  which the item is committed/assigned.



{:.note}
To view the item stock status, select **Options** > **Item**  > **Stock Status** from the **Work Order** profile.

- **Serial 
 numbers of serialized/auto-serialized items** - The serial numbers  attached to the document are moved to the stock area that they are assigned  to.

: ![]({{site.ba_baseurl}}/img/lens.gif)  [Attach/Commit  Items on Work Order - Stock Areas Assigned]({{site.ba_baseurl}}/prod-asm/att-cmt-items-to-wo/set_stock_area_preferences_add_items_to_a_work_order_assembly_content.html)


{:.see_also}
See also
: [Attach/Commit  Items on a Work Order]({{site.ba_baseurl}}/prod-asm/att-cmt-items-to-wo/attach_commit_items_to_a_work_order_profile_assembly_content.html)
