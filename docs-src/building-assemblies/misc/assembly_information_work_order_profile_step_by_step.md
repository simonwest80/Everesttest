---
title: Assembly Details
---

# Assembly Details


**Assembly**
: Specify the code of the assembly item that has to  be manufactured. All items of type ‘assembly’ are available for selection.  This is a mandatory field. You cannot edit this field once you change  the work order's status to "In Process".


**Description**
: The **Description**  field (beside the **Assembly** field)  displays description of the assembly item as entered in assembly item’s  profile. This is a display field and cannot be edited.


**Unit Of Measure**
: This field displays the stock unit of measure for  the item (selected in the **Assembly** field)  as specified in the **Item** profile.  This is a display field and cannot be edited.


**Inventory Type**
: This field displays the inventory type of the item;  the item could be Inventoried, Inventoried - Serialized or Inventoried  - Auto serialized item. This is a display field and cannot be edited.


**Created Date**
: The **Created****Date** field displays the date on  which the work order was originally created. The date displayed in this  field is the date of the database server (when the work order was created)  and not the login  date. This is a display field and cannot be edited.


**Required Date**
: Select the date by which the work order should be  completed. By default this field displays the login  date. You can select another date if required.


**Required Output**
: Enter the number of units (of the item) that has  to be manufactured. By default this field displays an output of one. You  can enter another quantity (that is greater than zero) in this field.
: ![]({{site.ba_baseurl}}/img/note.gif)  The  output must be indicated in terms of the stock unit of measure for the  item.


**Quantity to be built**
: Enter the quantity that is being built during the  current production run.
: You can edit the quantity to be built till the ‘In  Process’ stage provided the check box **Link 
 the serial number/lot number of input items** to the assembly item  is not selected in the **Assembly Item**  profile (**Inventory** > **Items** > Select the assembly item  > **Edit** > **In 
 New Window** > **Assembly Item**  profile > **Assembly** tab >  **Input** tab). If you select this  check box, you cannot modify the quantity to be built beyond the ‘Not  Started’ stage of the work order.


{:.see_also}
See also
: [The  Work Order Profile]({{site.ba_baseurl}}/prod-asm/creating-wo/create-a-work-order/the_work_order_profile_assembly_step_by_step.html)
: [Assembly  Information]({{site.ba_baseurl}}/prod-asm/creating-wo/wo-details/assembly_information_work_order_profile_assembly_contents.html)
