---
title: Columns in the Bill of Materials Grid
---

# Columns in the Bill of Materials Grid


Use the columns in the Bill of Materials Grid to do the following:

- Specify all  the items that are required to create the assembly item. This list is  automatically retrieved when the assembly item is selected on a Work Order.
- Define the  standard inputs and the normal losses. This data allows you to perform  variance analysis.



The assembly components are defined in relation to the stock measure  of the assembly item.


{:.example}
You have an assembly item, Sugar, with the  following components:


• Cane


• Chemical


The stock measure for the assembly item is **Ton**  and the stock measure for the assembly components is **KG**.  The quantity of the assembly components (in KG) in the **Assembly**  tab is for building each **Ton** of  sugar.


The columns in the bill of material details grid are detailed below:


{:.note}
**Standard 
 Input (incl loss)**, **Standard input 
 (excl loss)** and **Normal Loss Qty**  are in the cost decimal accuracy of the stock measure for the item.


**Item Code**
: This column displays the code of the item.


**Description/Notes**
: This column displays the item description that has  been specified in the **Description**  field (path: **Item** profile >  **General** tab) of the selected item.


**Std  Input**
: Enter the standard quantity or input required under  normal conditions to assemble one stock measure of an assembly item. The  standard input includes the normal loss quantity.


{:.example}
If the stock measure of the assembly item  is 10 units, you must mention the standard input for all the units.


**Normal Loss %**
: Normal loss is the quantity of the item lost during  the assembly process.


{:.example}
During the process of extracting aromatic  oil from 10 Kg. of mint, the normal loss (due to spoilage or spillage)  is 500 gm. To offset this loss, a standard input of 10.5 Kg. is used.
: Enter the percentage of the selected item’s quantity  that is normally lost during assembly. If no loss occurs do not enter  any value in this column.
: If you enter a value in the **Normal 
 Loss Qty** column, **Everest** automatically  computes the loss percentage.


**Normal Loss Qty**
: Enter the normal quantity if any, of the selected  item that will be lost during the assembly. If no loss occurs, do not  enter any value in this column.
: If you enter a value in the **Normal 
 Loss %** column, **Everest**  automatically computes the quantity of normal loss. The quantity in the  **Normal Loss Qty** column is automatically  rounded off using the following rules:

- If the decimal  is 0.5 or more, the quantity is increased by one.
- If the decimal  is less than 0.5, the decimal is not considered.



**Std  Input (before loss)**
: The standard input before loss is computed using  the following formula:
: Standard input before loss = Standard input - Normal  loss quantity
: If there is no loss during assembly, this column  equals the **Std 
 Input** column.


**Std  Rate**
: The standard rate is the standard cost per stock  measure of the selected item that should be incurred during the assembly  process.
: The average cost of the selected item (when creating  the assembly item) is displayed by default in this column. You can modify  this rate to reflect the standard cost that should be incurred.


**UM**
: The stock measure of the selected item is displayed.  This column cannot be modified.


**Line Number**
: The **Line Number**  column displays the line numbers of the **Bill 
 of Materials** Grid in chronological order.
: Use the **Move up/ 
 Move down** option (path: Right-click in the **Bill 
 of Materials** Grid > **Move up/Move 
 down**) to rearrange the order of the items.
: The order of the items in this tab, is the order  in which they are:

- Retrieved into  sales or purchase documents.
- Displayed on  your online store.



**Amount**
: The **Amount**  column displays the product of the standard input and the standard rate.  This column cannot be edited. Thus:
: Amount = Standard Input \* Standard Rate
: The amount shown is in the currency decimal accuracy.


{:.see_also}
See also
: [The  Item Profile - Assembly - Input Tab]({{site.mi_baseurl}}/misc/the_item_profile_assembly_input.html)
