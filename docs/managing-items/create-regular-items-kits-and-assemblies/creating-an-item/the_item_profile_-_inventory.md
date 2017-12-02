---
title: The Item Profile - Inventory
---

# The Item Profile - Inventory


Use this tab to enter inventory information. Define the stock measure  for the item and view or enter cost information related to the stock measure.  Costs are displayed in the stock measure. Specify the stock bin and whether  the lot should be tracked.


Cost information


**Average Cost**
: The average cost of the item is automatically computed  and displayed in this field. This value cannot be edited. The average  cost is arrived at by including the unrecoverable portion of the purchase  tax.
: **Average Cost**  is the current weighted average cost of the item. It is computed by adding  the value of a purchase to the value of quantity in stock and dividing  the sum by the sum of the quantity in stock and quantity purchased. Average  cost is thus computed using the following formula:
: Average Cost = (Value of Purchase + Value  of Quantity in Stock)/(Quantity purchased + Quantity in Stock)


{:.example}
You buy 100 of item A at $10. The value of the quantity of stock is  $1000. The weighted average cost of item A is $10. You buy another 50  of item A at $11. The weighted average cost of item A is now $10.33.
: It is used for computing the selling price of the  item where the calculation method for the item is based on average cost.


**Last Landed Cost**
: This field indicates the most recent cost at which  the item has been purchased converted to the stock measure. The last landed  cost in the purchase measure is converted to the last landed cost in the  stock measure based on the conversion factor between the stock and purchase  measures at the time the last landed cost for each purchase measure is  updated. You can leave this field at 0 when creating an item. When  you purchase an item, **Everest**  automatically updates this field.


{:.note}
The last landed cost of a Kit is not updated  when there is a change in the last landed cost of any of the items that  comprise the Kit. None of the related fields in the Purchase tab of the  Item profile are automatically updated for kit items. The kit’s last landed  cost has to be manually updated to reflect the changes in the last landed  cost of component items.


{:.example}
Item ABC is defined with a stock measure of Tons and purchase measures  of KG and Pounds. When the last landed cost for purchase measure KG or  Pounds is updated, the last landed cost for the stock measure will be  updated based on the conversion factor.
: This field updates whenever you receive items on  a purchase receipt, purchase invoice, or debit memo.
: ![Lens.gif]({{site.mi_baseurl}}/img/lens.gif) [Landed  Cost]({{site.mi_baseurl}}/item-profile-details/item-costing/purchase_costs_landed_cost_mi.html)


**Last Cost**
: Specify the last cost at which you purchased the  item from the vendor. This cost considers just the actual cost (price  minus discounts) of the item and excludes any additional costs. This field  updates every time you purchase an item in the measure associated with  the vendor. By default this field shows the line item's last cost, but  you may edit the field. The Last Cost field always accepts up to six decimal  places.
: This field updates whenever you receive items on  a purchase receipt, purchase invoice, or debit memo.


**Last Add-on Cost**
: This displays the last add-on cost at which you  purchased the item from the vendor. Add-on costs, a portion of Landed  Cost, consider just the additional costs necessary to transport the items  to you such as custom duties, transportation insurance, etc. You may not  edit this field.
: This field updates whenever you receive items on  a purchase receipt, purchase invoice, or debit memo.


**Factor Cost**
: Select this check box to enable cost factoring on  the item based on the last landed cost. Use this option to inflate the  cost of the item to adjust for overhead or other costs incurred.
: ![Lens.gif]({{site.mi_baseurl}}/img/lens.gif) [Factored  Costs]({{site.mi_baseurl}}/item-profile-details/item-costing/factored_cost_item_costing.html)
: When costs are factored, the item's selling price  is calculated using the factored cost. If sales commission is payable  on profits, the profit is computed by deducting the factored costs from  the selling price. Factoring costs:

1. Helps to conceal the actual gross margins on a  sale since it is the factored cost of an item that appears on a sales  document.
- Reduces the sales commission payable on profits.  If you want this profit to reflect net margins (gross profit less other  expenses) instead of gross margins (before considering the other expenses),  use factored costs to calculate this commission.



**(Factored) Average Cost**
: The average cost of the item is displayed in this  field, if Factor cost is enabled. This field cannot be edited. The average  cost is arrived at by including the unrecoverable portion of the purchase  tax. This cost includes the factor percentage/amount.


{:.example}
If the **Factor 
 Cost** is 1% and the **Average Cost**  is $10.00, then the **(Factored) Average 
 Cost** is $10.10 which is inflated by the factor percentage.


**Percent**
: Enter the percentage by which you want to inflate  the cost of the item. This field is enabled only if you select the **Factor Cost** check box. You can specify  a maximum value of 999.99 in this field.


**(Factored) Last Landed Cost**
: Enter the last landed cost to be used as the item  cost. This field is enabled only if you select the **Factor 
 Cost** check box. This cost includes the factor percentage/amount.


{:.note}
The factored last landed cost of a Kit is  not updated when there is a change in the last landed cost of any of the  items that comprise the Kit. None of the related fields in the **Purchase**  tab of the **Item** profile are automatically  updated for kit items. The kit’s last landed cost has to be manually updated  to reflect the changes in the last landed cost of component items.


Other Inventory Information


**Stock Measure**
: Select the **Stock 
 Measure** for the inventory. The Stock Measure must be selected to  be able to select the purchase or sales measures for the item. The stock  measure description is shown to the right of the Stock Measure.
: Note: For serialized items, measures with a decimal  accuracy of zero can be defined as a stock measure.  Also  for serialized items, measures with a fractional quantity entry method  cannot be defined as a stock measure.
: The stock measure can be edited only when there  are no transactions for the item.


**Use lot tracking**
: Select this check box to enable lot tracking in  **Everest**. Non-serialized items,  purchased from a vendor or returned by a customer, can be tracked easily  by assigning lot numbers to a batch, or lot of items.
: **Everest**  picks the starting sequence for the lot number from the login location.  If the sequence number column is blank, the sequence number is picked  from the default or the main location.
: An item must be lot tracked for details to display  in the **Lot 
 History** **Browser**.


**Auto generate lot numbers**
: Select this option if you want **Everest**  to automatically generate lot numbers for the item in purchase documents.  This field is enabled only if you select the **Use****lot** **tracking**  check box.


**Critical**
: Select this option, if this item is always critical  to a shipment.
: Critical items are those items without which other  items on the sales order cannot be sold. Dependant items depend on critical  items for their sale.


{:.example}
Critical item - Computer


Dependent items - Keyboard, mouse and speakers.


You can ship the critical item (computer) without the dependent items  (keyboard, mouse and speakers), but you cannot ship the dependent items  without the critical item.
: If this option is checked, the **Critical**  column in sales orders is also selected by default.
: In sales orders, a critical item should have an  item or items dependant on it. You cannot save and process a sales order,  if the dependant item has not been specified in the **Dependant On** column of the **Sales 
 Order** profile.


**Bulk Item**
: Select this option to specify the item packing type  as a bulk item, to be packed and shipped separately.
: An item that needs to be packed separately due to  its physical attributes is called a bulk item. If an item can be packed  with other items, it is called a ‘Piece item’.


**Gift Card**
: Select this check box to specify if the item is  a gift card. The Processor field is enabled when you select this check  box. It is mandatory to select this check box if the item you are creating  or modifying is a gift card. This check box is enabled only if the Gift  Card license is activated in **Everest**.


{:.note}
A gift card can be created in **Everest**  by using Autoserialized items in **Everest**.  Select Inventoried - Autoserialized as the Inventory Type when you create  a gift card as an item in **Everest**.


**Include in Pick Ticket**
: Select this check box to mark a non-inventoried  line item as “Include in Pick Ticket” in a sales order by default. “Include  in Pick Ticket” is also a column in the line item of the sales order and  it is selected by default if this option is selected. This check box is  enabled only for non-inventoried items.
: If non-inventoried items are not present on the  pick ticket, they can still get invoiced automatically by the Pull Sheet.  This occurs if the “Set the quantity shipped value to zero when converting  the sales order to sales invoice (force you to enter the quantity shipped)”  flow control preference is not checked (path: **File**  > **Setup** > **Preferences**  > **Flow Control** > **Documents**  > **Miscellaneous Tab** > **Others Tab** > **Others 
 1 Tab**). If this flow control preference is checked, non-inventoried  items will not be invoiced unless they are included on the pull sheet.


{:.example}
WWC is a company that has several promotional  items that customers sometimes request such as product catalogs or calendars.  These products are configured as non-inventoried and will be added to  the sales order by the phone operator at the time of printing the order.  They are not included with every shipment. The operator is able to identify  the non-inventoried items marked for inclusion on pick tickets.


{:.see_also}
See also
: [Create an Item]({{site.mi_baseurl}}/create-regular-items-kits-and-assemblies/creating-an-item/setting_up_an_item.html)
