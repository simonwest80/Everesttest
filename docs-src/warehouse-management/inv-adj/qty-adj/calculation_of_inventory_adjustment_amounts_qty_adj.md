---
title: Calculation of Inventory Adjustment Amounts
---

# Calculation of Inventory Adjustment Amounts


**Everest** displays the available  stock from only those stock areas for the logged in location, depending  upon your flow control preferences (path: **File 
 &gt; Set up &gt; Preferences &gt; Flow Control &gt; Other Flow Control 
 &gt; General** tab > **Allow users 
 to access only those stock areas in the logged in location** check  box). If you select the above-mentioned check box, then, only the available  stock in the stock areas of the logged-in location will be displayed.


Add Quantity


In case of all serialized and non-serialized items, you will have to  enter the quantity to be added in the **Quantity** column.


Serialized Items


When the document is saved, serial numbers are generated for the new  quantities in the selected stock area.


Non-serialized Items


The additional quantity is added to the total stock of the item and  to the stock specified in the stock area.


Assigning Manufacturer's Serial Numbers


Manufacturer's serial numbers can be assigned to the serial numbers  generated from the **Serial Number**  browser.


Write off Quantity


Serialized and Auto-Serialized Items


If the item specified is serialized or auto-serialized, you will have  to attach the serial numbers of the item being written off by selecting  the option **Attach Serial #**. The  **Retrieve Serial Numbers** dialog  box displays all serial numbers of the item that are NOT committed to  a sales order or debit order. Serial numbers committed to a sales or debit  order cannot be written off.


![Lens.gif]({{site.wm_baseurl}}/img/lens.gif) [Serialized  Items]({{site.sp_chm}}/sales-docs/sales-orders/so-proc/cmt-items/enter-cmt-qty/ser/serialized_items_entering_committed_quantity.html)


[Auto-serialized  Items]({{site.sp_chm}}/sales-docs/sales-orders/so-proc/cmt-items/enter-cmt-qty/auto-ser/auto_serialized_items_entering_committed_quantity.html)


Non-serialized


You will have to enter the quantity to be written off in the **Quantity** column, if the item specified is non-serialized. This quantity  cannot exceed the total quantity.


![Lens.gif]({{site.wm_baseurl}}/img/lens.gif) [Non-serialized  Items]({{site.sp_chm}}/sales-docs/sales-orders/so-proc/cmt-items/enter-cmt-qty/non-ser/non_serialized_items_entering_committed_quantity.html)


**Inventory Adjustment Account**
: An accounting entry is made in the general journal  for the inventory adjustment amount. The accounts affected are Inventory  Adjustment account and Inventory Control account. The Inventory Control  Account defined in the Posting Group assigned to the line item is considered  first.
: If no Inventory Control Account is defined for the  item, the control account defined for the category to which the line item  belongs is used. If the Inventory Control Account is not defined for either  the item or the category, the Inventory Control Account of the stock area’s  location from where the item is assigned is taken into consideration.  The user may however override this account by selecting another account.  The Inventory Adjustment account can also be selected for each line.


![Lens.gif]({{site.wm_baseurl}}/img/lens.gif) [Accounting  Defaults]({{site.acc_chm}}/accounting-flow-control-and-defaults/accounting-defaults/accounting_defaults.html)


**Inventory Adjustment Amount**
: The amount of inventory adjustment on that line  is calculated and displayed. Accounting entries are made for this value.
: The amount of inventory adjustment is calculated  using these formulae:
: Adjustment amount = (Cost per measure \* Quantity  for adjustment)
: The computation of amounts depends on the quantity  entry method.


{:.example}
If the quantity of an item is measured in kilograms,  2 kilograms and a half of the item, at a cost of $2000, would be expressed  as 2:500 under the fractional method. The amount would be calculated as  follows:


2 \* $2000 + (500/1000) \* $2000


If the quantity is 2 kilograms and 500 grams and the  decimal accuracy is 2, the quantity under the decimal method would be  expressed as 2.50.


The amount would be calculated as follows:


2.50\*$2000


{:.see_also}
See also
: [Quantity  Adjustment]({{site.wm_baseurl}}/inv-adj/qty-adj/quantity_adjustments_price_protection.html)
