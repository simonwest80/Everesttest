---
title: Quantity Adjustment profile - Grid
---


**Line No.**
: This column displays the line number of the Item  Details Grid.


**Item Code**
: Specify the code of the item for which you want  to make quantity adjustments. This is a mandatory field.


**Description**
: This field displays the item description. You cannot  modify this field.


**Type**
: This field displays the inventory type of the item


**Current Stock**
: The total quantity of the selected item available  from all stock bins is displayed in this column. The current stock is  shown in the stock measure. You cannot edit this quantity, but you can  change the unit of measure. If you change the unit of measure, the Current  Stock field updates to the changed measure.


{:.note}
**Everest** displays  the current stock from only those stock areas for the logged in location,  depending upon your flow control preferences (path: **File 
 &gt; Set up &gt; Preferences &gt; Flow Control &gt; Other Flow Control 
 &gt; General** tab **&gt; Allow Users 
 to access only those stock areas in the logged in location** check  box). If you select the above-mentioned check box, only the current stock  in the stock areas of the logged-in location is displayed.


**UM**
: You can change the stock unit of measure, if necessary,  to any of the purchase/sales measures defined for the selected item. The  Current Stock field updates to the changed measure.


**Adjustment Type**
: Select the adjustment type as add quantity or write  off quantity from the drop down list. By default, this column displays  ‘Add Quantity’.


{:.note}
You can add quantity, write off quantity or do both  in the same document.


**Quantity**
: Enter the quantity to be adjusted in this column.  The quantity is shown in the stock measure, but it updates if the unit  of measure is changed. The quantity defaults to 1 with the decimal accuracy  of the measure. With the appropriate security rights, you can increase  the quantity decimal accuracy up to 6.


{:.example}
Your stock measure is KG and the KG decimal  accuracy is 2. The quantity is shown as 1.00, but you can enter 1.123  or 1.12345.
: If you change the decimal accuracy of the purchase  unit of measure, the original quantity is retained with the decimal accuracy  of the changed measure and cost details update based on the changed measure.


{:.example}
If your quantity is entered as 10.20 and the  decimal accuracy of the measure is changed to 0, the quantity is shown  as 10.


**Cost**
: For additional quantities, enter the new cost based  on the measure selected. For write offs, the average cost for inventoried  items or the weighted average of the actual cost of the serial numbers  for serialized items is displayed.
: You can enter the cost in the cost price decimal  accuracy of the item. If you have the appropriate security rights, you  can increase the cost price decimal accuracy up to 6. If the unit of measure  changes, the cost updates to the changed measure.


**IA Account**
: When you specify an item code, the default Inventory  Adjustment account, specified in the **Accounting**  dialog box (path: **File** > **Setup** > **Preferences**  > **Defaults** > **Accounting**),  for that item is displayed. If you want, you can specify a new Inventory  Adjustment account for each line item. This is a mandatory field.
: The Inventory Adjustment Account defined in the  Posting Group assigned to the line item is considered first. If no Inventory  Adjustment Account is defined for the item, the control account defined  for the category to which the line item belongs is used. If the Inventory  Adjustment Account is not defined for either the item or the category,  the Inventory Adjustment Account of the document’s location is taken into  consideration. You may however select any another inventory adjustment  account.
: For write-off of stock resolve the accounts based  on the **Item** profile or **Item 
 Category** profile or if unavailable there, then based on the account  assigned to the stock area defined in the Inventory Adjustments tab (path:  **File** > **Setup**  > **Accounting** > **Location/Sub 
 location** > **New** >  **Location**).


**Inventory Acnt**
: The Inventory Control Account defined in the Posting  Group assigned to the line item is considered first. If no Inventory Control  Account is defined for the item, the control account defined for the category  to which the line item belongs is used. If the Inventory Control Account  is not defined for either the item or the category, the Inventory Control  Account of the stock area’s location from where the item is assigned is  taken into consideration. You may however override this by selecting another  account of the type inventory control account.


**Previous Stock**
: The stock prior to the quantity adjustment is displayed  in this field. The previous stock is shown in the stock measure, but it  updates if the unit of measure is changed.


**New Stock**
: The stock after you make the quantity adjustment  is displayed in this field. The new stock is shown in the stock measure,  but it updates if the unit of measure is changed.


**Previous Cost**
: This field displays the average cost of the line  item (based on the selected measure) before making the quantity adjustments.  The previous cost is shown in the cost price decimal accuracy of the item.


**New Cost**
: This field displays the average cost of the line  item (based on the selected measure) after making the quantity adjustments.  The new cost is shown in the cost price decimal accuracy of the item.


**IA Amount**
: The inventory adjustment amount is calculated and  displayed in this column. It is in the decimal accuracy defined in the  currency profile.
