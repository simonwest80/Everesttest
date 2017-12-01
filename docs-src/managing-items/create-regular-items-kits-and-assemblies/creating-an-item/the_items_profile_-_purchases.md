---
title: The Item Profile - Purchases
---

# The Item Profile - Purchases


Use the **Purchases** tab to specify  purchase information such as cost information, purchase measure and the  quantity entry method.


Cost information


Enter information for each purchase measure. Right click and select  **Insert** to add additional measures.  Right click and select **Delete**  to remove a measure from the list. Purchase measures can be added and  removed at any time.


**Default**
: Specify only one default purchase measure from the  drop-down list. Right click the **Default**  field and select **Set As Default**.  The default purchase measure can be changed at any time.


**Measure**
: Specify the purchase measure of the item. Only measures  with a conversion factor to the stock measure are available in the drop-down  list. Measures listed here are the only allowed purchase measures for  this item in purchase documents. Purchase measures can be deleted even  if they are used in documents and they can be added at any time.


{:.note}
- This field defaults  to the value specified in **File &gt; Setup 
 &gt; Preferences &gt; Defaults &gt; Items**. You can select any measure  but it will be considered with a quantity of one for a Kit.
- In case of a matrix  group, you are asked if you would like to apply the measure selected to  the matrix items as well. You cannot edit this field in a matrix item’s  profile.
: ![Lens.gif]({{site.mi_baseurl}}/img/lens.gif) [The  Measure Profile]({{site.mi_baseurl}}/item-profile-details/measure/measure_profile_general_tab.html)
: ![]({{site.mi_baseurl}}/img/lens.gif) [Purchase  Measure]({{site.mi_baseurl}}/item-profile-details/other-items-information/purchase/measure_pur.html)


**Last Landed Cost**
: This field indicates the most recent cost at which  you purchased the item as per the purchase measure. You can leave this  field at 0 when creating an item.  When you purchase an item, **Everest** automatically updates this field.  It is used to compute the selling price of the item, where the calculation  method is based on last landed cost.


{:.note}
The last landed cost of a Kit is not updated  when there is a change in the last landed cost of any of the items that  comprise the Kit. None of the related fields in the Purchase tab of the  Item profile are automatically updated for kit items. The kit’s last landed  cost has to be manually updated to reflect the changes in the last landed  cost of component items.


{:.note}
The **Last 
 Landed Cost** in the stock measure on the **Inventory**  tab is updated at the same time the **Last 
 Landed Cost** for the purchase measure is updated.


{:.example}
If item ABC is purchased in KG at 10/per kg,  the **Last Landed Cost** for the KG  measure is updated. If the purchase cost is either the **High**  or **Low Cost** for the item, one  of these fields is updated as well. The **Last 
 Landed Cost** for the stock measure, located on the **Inventory**  tab, is also updated based on the conversion factor.
: ![Lens.gif]({{site.mi_baseurl}}/img/lens.gif) [Landed  Cost]({{site.mi_baseurl}}/item-profile-details/item-costing/purchase_costs_landed_cost_mi.html)
: This field updates whenever you receive items on  a purchase receipt, purchase invoice, or debit memo.


**Factored Cost**
: This field indicates the factored cost of the item.  The system calculates the factored cost based on the last landed cost  and using the percentage or amount specified on the **Inventory**  tab of the Item profile.


{:.note}
The factored last landed cost of a Kit is  not updated when there is a change in the last landed cost of any of the  items that comprise the Kit. None of the related fields in the Purchase  tab of the Item profile are automatically updated for kit items. The kit’s  last landed cost has to be manually updated to reflect the changes in  the last landed cost of component items.


**Last Cost**
: Specify the last cost at which you purchased the  item from the vendor. This cost considers just the actual cost (price  minus discounts) of the item and excludes any additional costs. This field  updates every time you purchase an item in the measure associated with  the vendor. By default this field shows the line item's last cost, but  you may edit the field. The Last Cost field always accepts up to six decimal  places.
: This field updates whenever you receive items on  a purchase receipt, purchase invoice, or debit memo.


**Last Add-on Cost**
: This displays the last add-on cost at which you  purchased the item from the vendor. Add-on costs, a portion of Landed  Cost, consider just the additional costs necessary to transport the items  to you such as custom duties, transportation insurance, etc. You may not  edit this field.
: This field updates whenever you receive items on  a purchase receipt, purchase invoice, or debit memo.


**High Cost**
: This field indicates the highest cost at which an  item has been purchased. **E**verest  calculates this value<font style="color: #ff0000;" color="#FF0000"> </font>for all items<font style="color: #000000;" color="#000000">. You cannot edit this field.</font>
: ![Lens.gif]({{site.mi_baseurl}}/img/lens.gif) [High  Cost]({{site.mi_baseurl}}/item-profile-details/item-costing/high_cost_item_costing.html)


**Low Cost**
: This field indicates the lowest cost of an item  it ever has. **Everest** calculates  this value for all items. You cannot edit this field.
: ![Lens.gif]({{site.mi_baseurl}}/img/lens.gif) [Low  Cost]({{site.mi_baseurl}}/item-profile-details/item-costing/low_cost_item_costing.html)


**Freight**
: This field indicates if freight is being considered  for this measure. Double-click the field to open the **Item 
 Freight** dialog box. Enter the item freight details in this dialog  box.
: ![]({{site.mi_baseurl}}/img/lens.gif)[Item  Freight Dialog Box]({{site.mi_baseurl}}/create-regular-items-kits-and-assemblies/creating-an-item/item_freight_dialog_box_mi.html)


**Cost Decimal Accuracy**
: Specify a decimal accuracy of between 0 and 6from  the drop-down list.  You  can modify this field after the item is used in a document. All of the  costs in the Purchase and Inventory tabs are based on this cost decimal  accuracy, except the Last Cost fields (Last Cost, Last Add-on Cost, and  Last Landed Cost) which always allow up to six decimal places.
: The following can be entered in the cost decimal  accuracy for the item:

- : The cost price  and the discount value in the purchase documents
- : The cost in  the work order and inventory adjustment documents
- : The cost in  the sales documents



{:.note}
: • For serialized items, the stock measure is shown  as the default purchase measure automatically and cannot be changed. In  this case, additional purchase measures cannot be selected.


Other purchase information


**Allow Freight Distribution**
: Select this check box to distribute the freight  charge among the items you purchase according to the distribution methods  specified in the **Freight Distribution**  dialog box. If the option **Allow Freight 
 Distribution** is unchecked the item will not be available for the  distribution of freight charges.
: ![Lens.gif]({{site.mi_baseurl}}/img/lens.gif) [Freight  Distribution]({{site.mi_baseurl}}/item-profile-details/other-items-information/purchase/freight_distribution_item_profile_content.html)


**Drop Shipment**
: Select this check box this item to appear as a "drop  ship" item in a Sales document.
: ![Lens.gif]({{site.mi_baseurl}}/img/lens.gif) [Drop  Shipment]({{site.mi_baseurl}}/misc/drop_shipment_pur__tab_content.html)


**Include in Freight Calculation**
: Use this option to indicate whether the weight of  this item is to be included when estimating freight on a purchase document  in which the item is included.
: You can enter the weight for computation of freight  on purchases in the **Weight** field  of the **Item Freight** dialog box.  Double-click the **Freight** field  in the **Cost Information** section  grid. Freight is computed on purchases only for items that have this option  selected.


{:.note}
- If this option  is not selected, freight calculations will not consider the weight of  the item in any document for computing freight based on Item/ Category  based freight rates.
- If freight rates  have been defined for document weight, the document weight used to determine  freight on the document will not include the weight of the item.
- Further, if freight  rates have been defined for document value, the document value used to  determine freight on the document will not include the value of the item.


{:.note}
- If this option  is not checked for a complete kit, but is checked for the items contained  in the kit, the complete kit is not considered for freight calculation.  Freight is not calculated and charged.
- When this option  is checked for a kit, freight is calculated based on the total weight  of the kit, after excluding all items, which have this option unchecked.  The item weights are recalculated based on the quantity of items.


{:.example}
If the freight calculation option is checked for a kit, and only  6  out of 8 items comprising the kit have the freight calculation option  checked, **Everest** considers only  the 6 items for calculating the document weight and applies the freight  rate for the document weight calculated.
: ![Lens.gif]({{site.mi_baseurl}}/img/lens.gif) [Include  in freight calculation]({{site.mi_baseurl}}/item-profile-details/other-items-information/sales/include_in_freight.html)


**Tax-inclusive Cost**
: Select this check box to include the tax amount  in the purchase cost of an item**.**
: ![Lens.gif]({{site.mi_baseurl}}/img/lens.gif) [Cost  Including Tax]({{site.mi_baseurl}}/item-profile-details/other-items-information/purchase/cost_including_tax_item_profile_content.html)


{:.see_also}
See also
: <font style="color: #008000;" color="#008000"><a href="{{site.mi_baseurl}}/create-regular-items-kits-and-assemblies/creating-an-item/setting_up_an_item.html">Create an Item</a></font>
