---
title: Calculation of Inventory Adjustment Amounts
---

# Calculation of Inventory Adjustment Amounts


Serialized and Auto-serialized Items


If the item specified is serialized or auto-serialized, you will have  to attach the serial numbers of the item for which you want to make price  protection by selecting **Options &gt; 
 Attach Serial #**, available in the **Price Protection** profile, to attach the serial numbers.


![Lens.gif]({{site.wm_baseurl}}/img/lens.gif) [Serialized  Items]({{site.sp_chm}}/sales-docs/sales-orders/so-proc/cmt-items/enter-cmt-qty/ser/serialized_items_entering_committed_quantity.html)


[Auto-serialized  Items]({{site.sp_chm}}/sales-docs/sales-orders/so-proc/cmt-items/enter-cmt-qty/auto-ser/auto_serialized_items_entering_committed_quantity.html)


Non-serialized


If the item specified is non-serialized, the quantity to be adjusted  can be specified using **Attach Quantity**  dialog box. When you try to enter the quantity in the **Quantity** column**,** this dialog box  displays the stock available in various stock areas. Enter the quantity  from the required stock area and click **OK**.  The specified quantity will be displayed in the **Quantity**  column. This quantity cannot exceed the total quantity available.


![Lens.gif]({{site.wm_baseurl}}/img/lens.gif) [Non-serialized  Items]({{site.sp_chm}}/sales-docs/sales-orders/so-proc/cmt-items/enter-cmt-qty/non-ser/non_serialized_items_entering_committed_quantity.html)


**Inventory Adjustment account**
: The accounts affected are Inventory Adjustment account  and Inventory Control account. The Inventory Adjustment Account defined  in the Posting Group assigned to the line item is considered first. If  no Inventory Adjustment Account is defined for the item, the control account  defined for the category to which the line item belongs is used. If the  Inventory Adjustment Account is not defined for either the item or the  category, the Inventory Adjustment Account of the document’s location  is taken into consideration.  You  may select another account if required. Inventory Adjustment accounts  must be an expense type of account.


![Lens.gif]({{site.wm_baseurl}}/img/lens.gif) [Accounting  Defaults]({{site.acc_chm}}/accounting-flow-control-and-defaults/accounting-defaults/accounting_defaults.html)


**IA account for Price**
: An accounting entry is made in the purchase journal  to adjust the amount payable to the vendor. The accounts affected are  Price Protection Account and A/P Control Account.
: The Inventory Adjustment Account defined in the  Posting Group assigned to the line item is considered first. If no Inventory  Adjustment Account is defined for the item, the control account defined  for the category to which the line item belongs is used. If the Inventory  Adjustment Account is not defined for either the item or the category,  the Inventory Adjustment Account of the document’s location is taken into  consideration. You may select another account if required. Price Protection  accounts must be an expense type of account.


![Lens.gif]({{site.wm_baseurl}}/img/lens.gif) [Accounting  Defaults]({{site.acc_chm}}/accounting-flow-control-and-defaults/accounting-defaults/accounting_defaults.html)


**Inventory Adjustment Amount**
: The amount of inventory adjustment for the line  item is calculated and displayed. Accounting entries are made for this  value.
: The amount of inventory adjustment is calculated  using these formulae:


Serialized/Auto-serialized Items


Adjustment amount = (Cost per measure \* Quantity for adjustment) - (Sum  of actual cost of serial numbers attached)


If the adjustment amount is negative, the inventory value reduces; if  positive, inventory value increases.


Non-serialized Items


Adjustment amount = (Cost per measure \* Quantity for adjustment) - (Quantity  for adjustment \* Previous cost per measure)


The computation of amounts depends on the quantity entry method.


![example.gif]({{site.wm_baseurl}}/img/example.gif) If  the quantity of an item is measured in kilograms, 2 kilograms and 500  grams of the item, at a cost of $2000, would be expressed as 2:500 under  the fractional method. The amount would be calculated as follows:


2 \* $2000 + (500/1000)  \* $2000


If the quantity is 2 kilograms, 500 grams  and 15 milligrams, the quantity under the decimal method would be expressed  as 2500.15. The amount would be calculated as follows:


(2500/1000) \* $2000+(0.15/1000) \* $2000
