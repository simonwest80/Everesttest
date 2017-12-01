---
title: Price Protection profile - Grid
---


**Line No.**
: This column displays the line number of the Item  Details Grid.


**Item Code**
: Specify the code of the item for which you want  to make price protection. This is a mandatory field.


**Description**
: This field displays the description of the item.  You cannot modify this field.


**Type**
: Inventory type of the item is displayed in this  field. You cannot modify this field.


**Current Stock**
: The total quantity of the selected item available  from all stock bins is displayed in this column. The current stock is  shown in the default purchase measure. You cannot edit this quantity.


{:.note}
**Everest** displays  the current stock from only those stock areas for the logged in location,  depending upon your flow control preferences (path: **File 
 &gt; Set up &gt; Preferences &gt; Flow Control &gt; Other Flow Control 
 &gt; General** tab **&gt; Allow Users 
 to access only those stock areas in the logged in location** check  box). If you select the above-mentioned check box, then, only the current  stock in the stock areas of the logged-in location will<font style="font-family: Verdana;" face="Verdana"> </font>be displayed.


**UM**
: You can change the purchase unit of measure, if  necessary, to any of the purchase measures defined for the selected item.  The Current Stock field is updated to the changed measure.


**Quantity**
: Enter quantity of the item, if the item specified  is non-serialized. Enter the quantity of the item if the item specified  is not serialized. The quantity defaults to 1 with the decimal accuracy  of the measure. With the appropriate security rights, you can increase  the quantity decimal accuracy up to 6.


{:.example}
Your default purchase measure is KG and the  KG decimal accuracy is 2. The quantity is shown as 1.00, but you can enter  1.123 or 1.12345.
: If you change the decimal accuracy of the purchase  unit of measure, the original quantity is retained with the decimal accuracy  of the changed measure.


{:.example}
If your quantity is entered as 10.20 and the  decimal accuracy of the measure is changed to 0, the quantity is shown  as 10.
: You will have to attach the serial numbers of the  item, if the item specified is serialized or auto-serialized.


**Inventory Acnt**
: The Inventory Control Account defined in the Posting  Group assigned to the line item is considered first. If no Inventory Control  Account is defined for the item, the control account defined for the category  to which the line item belongs is used. If the Inventory Control Account  is not defined for either the item or the category, the Inventory Control  Account of the stock area’s location from where the item is assigned is  taken into consideration. You can choose any other inventory control account  of the type Inventory Control Account.


**Previous Cost**
: This field displays the average cost of the line  item (based on purchase measure) before enabling price protection. The  previous cost is shown in the cost price decimal accuracy of the item.


**Corrected Cost**
: The corrected cost is shown in the cost price decimal  accuracy of the item.


**Inventory Adjustment Amount**
: The amount of inventory adjustment on that line  is calculated and displayed in this column.
