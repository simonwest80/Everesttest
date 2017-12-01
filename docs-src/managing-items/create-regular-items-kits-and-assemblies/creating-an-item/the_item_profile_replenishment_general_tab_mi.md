---
title: The Item Profile - Replenishment - General Tab
---

# The Item Profile - Replenishment - General Tab


Specify replenishment details on the **General**  tab. The **Everest Inventory Planning Wizard**  can be used to automatically update your replenishment points (Min Quantity,  Max Quantity, and Reorder Point) and average lead time per vendor.


Location related information


**Location**
: Select the location for which you want to define  replenishment planning details. You cannot select a location more than  once in this grid.


**Description**
: This field will automatically get populated when  you select the location.


**Min Quantity**
: Specify the minimum quantity of an item that is  required in the stock. The default quantity will be in the stock measure  of the item and will be zero by default when a new line is inserted.


**Max Quantity**
: Specify the maximum quantity of items that are required  in the stock.


**Reorder Point**
: Specify the level of inventory at which a purchase  requisition has to be initiated. The numerical value here represents the  combination of expected usage during the lead time period and the minimum  stock.


**Put Away Bin**
: Select the stock bin where the item quantity will  be received. This field will be blank by default.


Vendor related information


**Vendor**
: Select the vendor from whom the item is purchased.  You can associate more than one vendor with an item. In such case, you  should mark one vendor as primary vendor. The rest of the vendors will  become secondary vendors. If there is only one vendor then that vendor  will automatically be marked as primary vendor. You can modify the primary  vendor at any point of time. You cannot select a vendor more than once  in this grid.


{:.note}
You can disassociate any vendor at any point  of time even if there is an open purchase order for the vendor.


**Vendor Name**
: This field will automatically get populated when  you select the Vendor.


**Purchase Measure**
: Select the measure in which the item is purchased  from the vendor. You can edit this field at any point of time. However,  after updating this field you should also update standard cost and vendor  last cost.


**Standard Cost**
: Specify the cost at which the item will be purchased  from the vendor. This is an editable field and by default it shows the  item’s standard cost. For a new item, Standard Cost equals Last Cost.


**Last Landed Cost**
: Specify the last landed cost at which you purchased  the item from the vendor. This field updates every time you purchase an  item from the vendor in the measure associated with that vendor. By default  this field shows the item's last landed cost, but you may edit the field.
: This field updates whenever you receive items on  a purchase receipt, purchase invoice, or debit memo.
: ![]({{site.mi_baseurl}}/img/lens.gif)[Landed  Cost]({{site.mi_baseurl}}/item-profile-details/item-costing/purchase_costs_landed_cost_mi.html)


**Last Cost**
: Specify the last cost at which you purchased the  item from the vendor. This cost considers just the actual cost (price  minus discounts) of the item and excludes any additional costs. This field  updates every time you purchase an item in the measure associated with  the vendor. By default this field shows the line item's last cost, but  you may edit the field.
: This field updates whenever you receive items on  a purchase receipt, purchase invoice, or debit memo.


**Last Add-on Cost**
: This displays the last add-on cost at which you  purchased the item from the vendor. Add-on costs, a portion of Landed  Cost, consider just the additional costs necessary to transport the items  to you such as custom duties, transportation insurance, etc. You may not  edit this field.
: This field updates whenever you receive items on  a purchase receipt, purchase invoice, or debit memo.


**EOQ**
: The EOQ (Economic Order Quantity) refers to the  most suitable economic quantity that can be ordered which minimizes the  total of inventory holding cost and ordering cost.
: Specify the economic order quantity that you want  to order from the vendor. This field will be in the purchase measure selected  for the vendor. This is an editable field and by default it will show  zero value.


**Vendor Part Number**
: Specify the part number supplied by the vendor.  This is an editable field.


**Lead Time**
: This field indicates the last lead time for the  vendor. It represents the time it took to receive the items after they  were ordered (difference between the PO and the PR for the vendor and  the item).
: Specify the time required by the vendor to deliver  the goods in number of days. The default value is Unknown. The Lead Time  is used for information and for inventory planning if you are using the  **Everest Inventory Planning Wizard**.  You do not have to use the value of this field to calculate the delivery  date or to a select vendor with minimum lead time. You can edit this field  at any point of time.


{:.note}
- The details as  and when updated in the **Item** profile  will reflect in the **Vendor** profile  and vice versa.
- You cannot associate  a vendor twice with the same item.
- If the company  is new, the grid will show the details for the MAIN location with zero  values for minimum, maximum, reorder quantity and put away bin.


**Average Lead Time**
: This field indicates the average number of days  that it takes to receive the item from the vendor. This field calculates  if the option is selected in the **Everest 
 Inventory Planning Wizard**.


{:.see_also}
See also
: [The  Item Profile - Replenishment]({{site.mi_baseurl}}/create-regular-items-kits-and-assemblies/creating-an-item/the_item_profile_-_replenishment.html)
: [Right-click  options for Location related information grid]({{site.mi_baseurl}}/misc/right-click_options_for_location_related_information_grid_the_item_profile_replenishment_tab.html)
: [Right-click  options for Vendor related information grid]({{site.mi_baseurl}}/misc/right-click_options_for_vendor_related_information_grid_the_item_profile_replenishment_tab.html)
