---
title: Back End Process - Assembled Items
---

# Back End Process - Assembled Items


The following back end processes occur when an item is built:

- The rate per  unit is calculated for the finished item and the defective units using  the following formula:

: Actual Cost of Finished Item = (Actual  Cost of the Assembly Item - Cost of Scrap or By Product)/Required Output

- Accounting  entries are generated.



![]({{site.ba_baseurl}}/img/lens.gif) [Accounting  Entries]({{site.ba_baseurl}}/prod-asm/building-wo/entering-qty-built/accounting-entries/accounting_entries-built-items.html)

- If the assembly  item is a serialized or auto-serialized item, serial numbers are automatically  generated for all the assembly items, good and defective.



{:.note}
To view the serial numbers generated for the items built from the work  order, select **Options** > **Show** **All 
 Serial** #.


![]({{site.ba_baseurl}}/img/lens.gif) [Stock  Area to Which Defective Items are Transferred]({{site.ba_baseurl}}/prod-asm/building-wo/entering-qty-built/back-proc/defective-items/stock_transfer_of_defective_items.html)


You can also assign lot numbers to the items built, if the lot preferences  are selected. Lot numbers are generated for both the good units and defective  units assembled.

- The built assembly  items are transferred to the default stock area for assembled/built items.

: ![]({{site.ba_baseurl}}/img/lens.gif) [Stock  Status of Assembled/Build Items]({{site.ba_baseurl}}/prod-asm/building-wo/entering-qty-built/back-proc/asm-items/set_stock_area_completed_assembly.html)

- The "On  Order" stock of the assembly item decreases by the quantity entered  in the **Required Output** field of  the **Work Order** profile (path:  **Inventory** > **Bill 
 of Material** > **Work Order** >  **Options** > **Edit** > **In New Window** >  **Work Order** profile).
- The ‘On Reserve’  column in the [**Item Stock Status** dialog box]({{site.mi_chm}}/misc/the_item_stock_status_dialog_box.html) decreases  by the standard input and the ‘On Reserve Commit’  column decreases by the quantity committed on the built work order (for  the component items).



{:.see_also}
See also
: [Back End  Processes when Items are Built]({{site.ba_baseurl}}/prod-asm/building-wo/entering-qty-built/back-proc/back_end_processes_built.html)
