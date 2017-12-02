---
title: Linking Serial Numbers
---

# Linking Serial Numbers


<font color="#000000" class="hcp1">You can link the serial numbers, manufacturer's serial 
 numbers, or lot numbers of the input items in an assembly to the serial 
 numbers of the output item. This helps you identify the input items that 
 have gone into the assembled item. Non-inventoried input items cannot 
 be linked to the assembled item. You can link the serial numbers, manufacturer's 
 serial numbers, or lot numbers of input items only to an assembly item 
 that is serialized/auto-serialized.</font>


![]({{site.ba_baseurl}}/img/lens.gif)<font color="#000000" class="hcp1"> </font>[Item  Types]({{site.mi_chm}}/item-profile-details/item-types/item_types.html)


<font color="#000000" class="hcp1">Linking is useful in the following instances:</font>

- <font color="#000000" class="hcp1">The customer returns a defective 
 item. The defect could be in any of the input items. It would be difficult 
 to identify the input item unless the serial numbers of the input and 
 assembly items are linked.</font>
- <font color="#000000" class="hcp1">The assembly item is found 
 defective after it is assembled at the testing stage. The defect could 
 again be due to any of the input items, which need to be tracked.</font>



{:.note}
A work order that contains an assembly item  marked for linking cannot be built until the input items are linked.


If the serial numbers are linked, then the  final serial numbers are generated at the ‘In Process’  stage.


{:.steps}
To link serial/lot numbers of input items  to the assembled item, do the following:

- <font color="#000000" class="hcp1">From the </font>**Work Order** <font color="#000000" class="hcp1">profile, 
 select </font>**Options** <font color="#000000" class="hcp1">&gt; </font>**Link Serial No**<font color="#000000" class="hcp1">. You 
 will see the </font>[**Assembly Link Serial No.** dialog box]({{site.ba_baseurl}}/prod-asm/work-in-proc/link-ser-nmbs-to-asm-item/the_assembly_link_serial_no_dialog_box.html)<font color="#000000" class="hcp1">.</font>



{:.note}
The **Link 
 Serial No.** option is enabled only when the following conditions  are met:

- The check box **Link the serial number/lot number of input 
 items to the assembly item** is selected in the **Assembly 
 Item** profile (**Inventory**  > **Items** > Select the assembly  item > **Edit** > **In 
 New Window** > **Assembly Item**  profile > **Assembly** tab >  **Input** tab).
- The work order  is in the ‘In Process’ stage.


{:.see_also}
See also
: [Link  Serial Number - Stock Area Assigned]({{site.ba_baseurl}}/prod-asm/work-in-proc/link-ser-nmbs-to-asm-item/link_serial_number_stock_area_assigned.html)
: [Work-in-Process]({{site.ba_baseurl}}/prod-asm/work-in-proc/process_work_orders_work_order_profile_assembly_content.html)
: [Calculating  the Cost of Serialized Assembly Items]({{site.ba_baseurl}}/prod-asm/work-in-proc/link-ser-nmbs-to-asm-item/calculating_the_cost_of_serialized_assembly_item.html)
