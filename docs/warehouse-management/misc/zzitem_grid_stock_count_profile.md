---
title: Item Grid
---

# Item Grid


**Line Number**
: This column displays the line number of the Item  Details Grid.


**Item Code**
: Specify the code of the item for which you want  to count the stock. This is a mandatory field.


**Stock Bin**
: The bin that contains the line item is displayed  in this column.


{:.note}
In case you are retrieving an item directly  in the Item Details Grid, without using any of the **Retrieve****Items** options, you are required  to select a bin in this column. Double click in this column to display  the drop-down arrow. Click the arrow and select the bin for which you  want to conduct the stock count from the browser that is displayed.


**Stock Area**
: This column displays the stock area to which the  line item belongs.


**Stock Measure**
: The unit of measure specified in the **Stock 
 Measure** field of the Item profile (path: **Inventory**  > **Items** > **Items****browser** > **Edit**  > **In New Window** > **Inventory** tab) is displayed in this  column.


**System Cost**
: In case of inventoried items, this column displays  the average cost; for serialized items, it displays the weighted average  of the actual cost of the system serial numbers.


{:.note}
If you are using the Take Snapshot to Count  method, average cost, at the time of creation of the **Stock 
 Count** profile, may differ from the average cost when the document  is marked as Counted. The **System Cost**  column in the Item Details Grid is automatically updated with the new  cost. This change is also conveyed through a message.


**System Value**
: This is calculated as follows:


 - Inventoried  items: System Stock \* Average Cost
 - Serialized/Auto-serialized  items: Sum of actual cost of serial numbers




**Physical Cost**
: In case of inventoried items, this column displays  the average cost and for serialized and auto-serialized items, it displays  the weighted average of the actual cost of the physical serial numbers.


**Physical Value**
: This is calculated as follows:


 - Inventoried  items: Physical Stock \* Average Cost
 - Serialized/Auto-serialized  items: Sum of actual cost of serial numbers




**Adjustment Quantity**
: This column displays the quantity of variance by  default. The quantity is negative if physical stock is less than the system  stock and positive if the physical stock is more than the system stock.  You can edit the quantity in the following cases:


 - The item  is either inventoried or auto-serialized
 - The adjusted  quantity is being added


: The adjusted quantity should not exceed the variance  quantity of the inventoried item.
: For serialized and auto-serialized items, this column  is updated to the quantity of the serial numbers written off when an inventory  adjustment document is created.


**Adjustment Cost**
: By default, this column displays the average cost  of the items used to adjust the quantity of variance. You can edit this  cost in the following cases:


 - The item  is either inventoried or auto-serialized.
 - The adjusted  quantity is being added.


: You cannot edit this column if you are writing off  a quantity.
: For serialized and auto-serialized items, this column  is updated with the weighted average of the actual cost of the serial  numbers written off when an inventory adjustment document is created.


**Adjustment Value**
: This is calculated as the adjustment quantity multiplied  by the adjustment cost.


**Variance Quantity**
: This column displays the difference between the  physical and system stocks.


**Variance Value**
: This column displays the difference between the  physical and system values.


**Serial # Difference**


**System Quantity**
: This column displays the total stock of the line  item in the system when the Stock Count document is created. The stock  measure of the line item as specified in the profile of that item is used  to calculate the system stock. You cannot edit this column.


{:.note}
Double click in this column to view details  of the system quantity of serialized items in the **System 
 Serial Numbers for All Items** browser.


**Physical Quantity**
: Enter the actual quantity of the item determined  by the physical count.


{:.note}
Double click in this column to view details  of the physical quantity of serialized items in the **Physical 
 Serial Numbers for All Items** browser.


{:.note}
By default only **Line 
 number**, **Item Code**, **Stock Bin**, **Stock 
 Area**, **Stock Measure**, **System Cost**, **System 
 Quantity**, and **Physical Quantity**  columns will appear. To view other columns, click **Field 
 Chooser** icon from the tool bar.
