---
title: The Item Profile - Replenishment - Usage Tab
---

# The Item Profile - Replenishment - Usage Tab


Specify item usage details on the **Usage**  tab. These details are used for inventory planning with the **Everest 
 Inventory Planning Wizard**.


Usage Type
: Indicate whether the item is a regular or seasonal  item. This makes a difference while calculating the usage class or quantity  in the Everest Inventory Planning Wizard since the sales history period  used for inventory planning is calculated differently for each.


**Regular**
: Select this option if the item is normally sold  throughout the year.


**Seasonal**
: Select this option if the item is normally sold  in a particular season or a specific time period.


**Usage Class**
: This field automatically populates with the Usage  Class determined by the Inventory Planning Wizard. You can change the  usage class, if required.


**Freeze usage class**
: Select this checkbox if you do not want the Usage  Class to be updated by the Inventory Planning Wizard the next time that  the utility is run. If this checkbox is not selected, it will be automatically  updated when the utility is run the next time.
: If a usage class is deleted in the Inventory Planning  Wizard and this option is checked, the deleted usage class will still  be assigned. If this option is not checked, the deleted usage class will  be replaced with another class after running the utility.


**Calculated usage**
: This field populates directly from the Inventory  Planning Wizard and is a display-only field. The following formula is  used to calculate this value:
: Total Quantity sold for this item in the  indicated number of history periods (defined in the Inventory Planning  Wizard)


{:.note}
- The history period  used in the calculation depends upon whether the item is a seasonal or  regular item.
- The total quantity  sold is based on the stock measure.
- It is the gross  number of units considering only the sales invoice (without considering  the returns).
: The automated purchasing feature does not use the  Calculated Usage field.


**Usage quantity**
: This field displays the modified usage quantity  and is for internal reference only. The Usage Quantity field is not used  for the automated purchasing feature or by the Inventory Planning Wizard.  Inventory Planning Wizard calculations only consider the Calculated Usage  field.
: You can change the quantity in this field up to  2 decimal places. You may want to update the Usage Quantity field to match  a standard usage quantity.


{:.example}
The Inventory Planning Wizard automatically  populated the Calculated Usage field as 22.30 based on the criteria selected  in the wizard. Since a standard crate has 24 units and it is easier to  source for a crate of items, the Purchasing Department changed the Usage  Quantity field to 24 to give them an indication of average consumption  for their internal reference.


{:.see_also}
See also
: [The  Item Profile - Replenishment]({{site.mi_baseurl}}/create-regular-items-kits-and-assemblies/creating-an-item/the_item_profile_-_replenishment.html)
