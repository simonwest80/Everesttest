---
title: The Build Dialog Box
---

# The Build Dialog Box


The **Build** dialog box allows  you to enter the quantity built. This can be less than or greater than  the required quantity. The difference is reflected in the variances.


![]({{site.ba_baseurl}}/img/lens.gif) [Variance]({{site.ba_baseurl}}/prod-asm/variance-analysis/variance_analysis_work_order_profile_browser_option_assembly.html)


**Built By**
: Select the user who is responsible for building  the item.


**Normal Output**
: Enter the good units that are actually built. This  field defaults to the quantity mentioned in the **Quantity 
 to be built** field.


**Defective output**
: Enter the defective units that are built.
: ![]({{site.ba_baseurl}}/img/lens.gif) [Defective  Items]({{site.ba_baseurl}}/prod-asm/building-wo/defectives-and-scrap/defective_items_work_order_profile_process_build_assembly.html)


{:.note}
The sum of the normal output and defectives  is the actual output. The actual output cannot exceed the Quantity to  be built specified in the work order. You must have adequate security  rights to build items if the actual output is less than the Quantity to  be built.


Scrap Details Grid
: The ‘Scrap Details Grid’  is displayed in the lower section of the **Build**  dialog box. This grid by default displays the scrap as defined in the  **Scrap** tab of the **Item**  (Assembly) profile (path: **Inventory** > **Items** > **Options** > **Edit** > **In 
 New Window** > **Assembly**  > **Scrap** tab).


{:.note}
You can add more scrap items in the ‘Scrap  Item Details Grid’,  if you have the required security rights. Scrap items cannot be ‘serialized’  or ‘auto-serialized’ type of items. You can also edit the rate and quantity  fields, if required.


If the scrap items use lot tracking, they  are assigned a system-generated lot number.


The scrap items generated are transferred  to the default stock area specified in the **Location**  profile (path: **File &gt; Setup &gt; Accounting 
 &gt; Location/Sub-Location &gt; Edit &gt; In New Window &gt; Location**  profile > **Stock Transfer &gt; Assembly 
 2** tab).


![]({{site.ba_baseurl}}/img/lens.gif) [Inventory Types]({{site.mi_chm}}/item-profile-details/inventory-type/inventory_type.html)
: The ‘Scrap Details Grid’ displays the following  information:


| **Column** | **Displays** |
| Item Code | The item code of the scrap item. |
| Description | The description of the scrap as defined in the **Scrap**  tab of the **Item** (Assembly) profile. |
| Type | The item type. |
| Quantity | The quantity of scrap. By default this column displays the quantity  as defined in the **Scrap** tab. However,  the quantity of scrap is proportional to the required quantity as defined  in the **Required Output** field of  the **Work Order** profile. You can  edit this column. |
| Rate | The cost per unit of the scrap. By default this column displays the  rate as defined in the **Scrap** tab.  If the rate of a scrap item is changed, the last cost of the item in the  **Item** profile is updated accordingly. |
| UM | The Stock Measure as defined in the **Scrap**  tab. |
| Line# | The line number of the line item. |
| Amount | The total cost (Scrap Quantity \* Scrap Rate) of the line item. |



{:.see_also}
See also
: [Build  a Work Order]({{site.ba_baseurl}}/prod-asm/building-wo/building_work_orders_content_building_assembly.html)
