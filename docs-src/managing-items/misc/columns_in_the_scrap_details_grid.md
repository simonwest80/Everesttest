---
title: Columns in the Scrap Details Grid
---

# Columns in the Scrap Details Grid


Use the columns in the Scrap Details Grid to do the following:

- Specify all  the items that are created as scrap when the assembly item is created.  These items are automatically retrieved into the Work Order when you indicate  that the assembly is built.
- Define the  standard scrap output and the cost of such items.



The columns in the Scrap Details Grid are detailed below:


**Item Code**
: This column displays the code of the item.


{:.note}
Only inventoried and non-inventoried items  can be included in the Scrap Details Grid. Serialized, Auto serialized,  Matrix Group and Matrix items cannot be included in this grid.


**Quantity**
: This column denotes the standard quantity of scrap  that is derived when the stock measure an assembly item is created. By  default this column displays 1. The quantity shown is in the cost decimal  accuracy of the stock measure for the item.


{:.example}
If the stock measure of the assembly item  is 10 kilograms, the quantity of scrap that is derived when 10 kilograms  of the assembly item is created, should be mentioned.


**Cost**
: The cost denotes the standard cost of the scrap  item. The average cost of the item is displayed by default in this column.  Also ![mi_up_arrow.gif]({{site.mi_baseurl}}/img/mi_up_arrow.gif) and ![mi_down_arrow.gif]({{site.mi_baseurl}}/img/mi_down_arrow.gif) buttons can be used.


**Line Number**
: The **Line Number**  column displays the line numbers of the **Scrap 
 Details** Grid in chronological order. All lines in the **Scrap 
 Details** Grid are printed in order of their line numbers.
: You can move the line up or down. Use the Move up/  Move down option (path: Right-click in the Scrap Details Grid > **Move up**/**Move 
 down**) to rearrange the order of the items in the Bill of Materials  Grid.


**Amount**
: The **Amount**  column displays the product of the quantity and the cost. This column  cannot be edited. Thus:
: Amount = Quantity \* Cost
: The amount is shown in the currency decimal accuracy.


{:.see_also}
See also
: [The  Item Profile - Assembly - Scrap Tab]({{site.mi_baseurl}}/misc/the_item_profile_assembly_scrap.html)
