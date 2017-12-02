---
title: Calculation of Stock Transfer Amounts
---

# Calculation of Stock Transfer Amounts


Serialized and Auto-serialized Items


If the item specified is serialized or auto-serialized, you must attach  the serial numbers to be transferred by selecting **Options**  > **Attach Serial #** available  in the **Stock Transfer** profile.


The **Retrieve Serial Numbers** dialog  box is displayed wherein you can attach specific serial numbers from your  inventory to the document.


Non-serialized Items


If the item specified is non-serialized, the quantity to be adjusted  can be specified using **Attach****Quantity** dialog box. When you  try to enter the quantity in the **Quantity**  column, this dialog box displays the stock available in various stock  areas. Enter the quantity from the required stock area and click **OK**. The specified quantity will be displayed  in the **Quantity** column. This quantity  cannot exceed the total quantity available.


**Amount**
: The amount is the total sum for the items to be  transferred.
: The value of the stock transfer in case of non-serialized  items is the average cost multiplied by the quantity transferred.
: The value of stock transfer in case of serialized  and auto-serialized items is the sum of the actual cost of the serialized  items.


<font style="font-family: Verdana;" face="verdana">The calculation depends on the 
 quantity entry method for the item.</font>


![example.gif]({{site.wm_baseurl}}/img/example.gif) If  the quantity of an item is measured in kilograms, 2 kilograms and 500  grams of the item, at a cost of $2000, would be expressed as 2:500 under  the fractional method.


The value of the quantity would be calculated  as follows:


**2 \* $2000 + (500/1000) \* $2000**


If the quantity is 2 kilograms, 500 grams  and 15 milligrams, the quantity under the decimal method would be expressed  as 2500.15.


The value of the quantity would be calculated  as follows:


**(2500/1000) \* $2000+(0.15/1000) \* $2000**
