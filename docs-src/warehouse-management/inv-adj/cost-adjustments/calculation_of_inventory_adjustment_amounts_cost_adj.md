---
title: Calculation of Inventory Adjustment Amounts
---

# Calculation of Inventory Adjustment Amounts


Serialized and Auto-serialized Items


If the item specified is serialized or auto-serialized, you must attach  the serial numbers of the items for which you want to make cost adjustments  by selecting the option **Line &gt; Attach****Serial #**, **** available in the **Cost Adjustments**  profile.


![Lens.gif]({{site.wm_baseurl}}/img/lens.gif) [Serialized  Items]({{site.sp_chm}}/sales-docs/sales-orders/so-proc/cmt-items/enter-cmt-qty/ser/serialized_items_entering_committed_quantity.html)


[Auto-serialized  Items]({{site.sp_chm}}/sales-docs/sales-orders/so-proc/cmt-items/enter-cmt-qty/auto-ser/auto_serialized_items_entering_committed_quantity.html)


Non-serialized


If the item specified is non-serialized, the quantity to be adjusted  can be specified using **Attach Quantity**  dialog box. When you try to enter the quantity in the **Quantity 
 column,** this dialog box displays the stock available in various  stock areas. Enter the quantity from the required stock area and click  **OK**. The specified quantity will  be displayed in the **Quantity** column.  This quantity cannot exceed the total quantity available.


![Lens.gif]({{site.wm_baseurl}}/img/lens.gif) [Non-serialized  Items]({{site.sp_chm}}/sales-docs/sales-orders/so-proc/cmt-items/enter-cmt-qty/non-ser/non_serialized_items_entering_committed_quantity.html)


New Cost


The **New cost** is the new cost  of the quantity to be adjusted. It is in the stock unit of measure of  the item. If the item is serialized, the new cost is applied to all the  serial numbers attached to the line.


To specify different costs for different serial numbers, you must attach  each serial number to a new line and define the cost for each.


![example.gif]({{site.wm_baseurl}}/img/example.gif) To  specify the cost of same kind of items with serial numbers 10023 at $42.50  and 10024 at $43, you must create a line entry for each serial number.


Inventory Adjustment Account


An accounting entry is made in the general journal for the Inventory  Adjustment amount. The accounts affected are Inventory Adjustment account  and Inventory Control account. The Inventory Control Account defined in  the Posting Group assigned to the line item is considered first.


If no Inventory Control Account is defined for the item, the control  account defined for the category to which the line item belongs is used.  If the Inventory Control Account is not defined for either the item or  the category, the Inventory Control Account of the stock area’s location  from where the item is assigned is taken into consideration. The user  may however override this account by selecting another account. The Inventory  Adjustment account can be selected for each line.


![Lens.gif]({{site.wm_baseurl}}/img/lens.gif) [Accounting  Defaults]({{site.acc_chm}}/accounting-flow-control-and-defaults/accounting-defaults/accounting_defaults.html)


Inventory Adjustment Amount


The amount of inventory adjustment for the line item is calculated and  displayed. Accounting entries are made for this value.


The amount of inventory adjustment is calculated for serialized, auto-serialized  and non-serialized items using the following formulae:


Serialized/Auto-serialized Items:


Adjustment amount = (New Cost per measure \* Quantity for adjustment)  - (Sum of actual cost of serial numbers attached)


If the adjustment amount is negative, the inventory value reduces; if  positive, inventory value increases. Cost and Quantity are in the stock  unit of measure.


Non-serialized Items:


Adjustment amount = (Cost per measure \* Quantity for adjustment) - (Quantity  for adjustment \* Old Average cost per measure)


The computation of amounts depends on the quantity entry method.


![example.gif]({{site.wm_baseurl}}/img/example.gif) If the  quantity of an item is measured in kilograms, 2 kilograms and 500 grams  of the item, at a cost of $2000, would be expressed as 2:500 under the  fractional method. The amount would be calculated as follows:


2 \* $2000 + (500/1000)  \* $2000


If the quantity is 2 kilograms, 500 grams  and 15 milligrams, the quantity under the decimal method would be expressed  as 2500.15. The amount would be calculated as follows:


(2500/1000) \* $2000+(0.15/1000)  \* $2000


{:.see_also}
See also
: [Cost Adjustment]({{site.wm_baseurl}}/inv-adj/cost-adjustments/cost_adjustments_new.html)
