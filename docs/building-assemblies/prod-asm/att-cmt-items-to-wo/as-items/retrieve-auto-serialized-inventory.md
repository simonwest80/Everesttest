---
title: Retrieve Auto-Serialized Inventory
---

# Retrieve Auto-Serialized Inventory


In case of an auto-serialized item, the **Actual 
 Input** column displays the quantity committed with the suffix ‘a’.


Auto-serialized items can be added to a Work Order in any of the following  ways:

- **Auto-Serialize 
 Item** - Use the **Auto-Serialize****Item** option (path: **Work****Order** profile > **Options**  > **Attach** / **Retrieve****Serial** **#**  > **Auto**-**Serialize****Item**) to attach serial numbers  to the selected line item automatically.
- **Auto-Serialize 
 All** - Use the **Auto**-**Serialize** **All**  option (path: **Work** **Order**  profile > **Options** > **Attach** / **Retrieve****Serial #** > **Auto**-**Serialize** **All**)  to attach serial numbers to all auto-serialized items on the work order.
- Directly enter  the quantity in the **Actual Input**  column.



If the quantities in the selected stock area include items to which  a manufacturer’s serial numbers are assigned, you can choose to skip such  items or auto-serialize them without being prompted. This preference has  to be set in the **When an item marked 
 as auto-serialized consists of a manufacturer serial number, how do you 
 wish to auto-serialize the item** option of the **Documents** dialog box (path: **File &gt; Setup 
 &gt; Preferences &gt; Flow Control &gt; Documents &gt; Prompts &gt; Sales 
 Documents &gt; Sales Document 1** tab).


![]({{site.ba_baseurl}}/img/lens.gif)[Location  profile - Stock Transfer tab - Miscellaneous tab]({{site.sc_chm}}/misc/stock_transfer_miscellaneous.html)


{:.note}
You can use the Auto-serialized feature only when you have values in  the **Std. Input** field in a Work  Order for Auto-serialized items.


{:.see_also}
See also
: [Attach/Commit  Items to a Work Order]({{site.ba_baseurl}}/prod-asm/att-cmt-items-to-wo/attach_commit_items_to_a_work_order_profile_assembly_content.html)
