---
title: Automated Purchases - Replenishment tab
---
<script type="text/javascript" language="JavaScript1.2" x-save-method="compute-relative" src="{{site.pp_baseurl}}/misc/ehlpdhtm.js"></script><script type="text/javascript" language="JavaScript1.2">
<!-- 
if( typeof( kadovFilePopupInit ) != 'function' ) kadovFilePopupInit = new Function();if( typeof( kadovTextPopupInit ) != 'function' ) kadovTextPopupInit = new Function();
 //-->
</script>
| Purchase in Increments of Vendor EOQ **check box** | Do Not Exceed Planned Quantity **check <br/> box** | Result |
| Checked | Unchecked | Order will be placed for the calculated Required Quantity adjusted for  increments of the Vendor EOQ. The Vendor EOQ increments MAY exceed the  planned quantity.<br/><br/><br/>In the **Item Replenishment** browser,  **Required** quantity is displayed  in increments of Vendor EOQ. \*\* |
| Unchecked | Checked | Order will be placed for the calculated Required Quantity. The Required  Quantity will not be adjusted for Vendor EOQ.<br/><br/><br/>In the **Item Replenishment** browser,  **Required** quantity is displayed  as the calculated Required Quantity.\* |
| Unchecked | Unchecked | Order will be placed for the calculated Required Quantity. The Required  Quantity will not be adjusted for Vendor EOQ.<br/><br/><br/>In the **Item Replenishment** browser,  **Required** quantity is displayed  as calculated Required Quantity.\* |
| Checked | Checked | Order will be placed for the calculated Required Quantity adjusted for  increments of the Vendor EOQ. The Vendor EOQ increments CANNOT exceed  the planned quantity. \*\*<br/><br/><br/>In the **Item Replenishment** browser,  **Required** quantity is displayed  in increments of Vendor EOQ. |



\*Required Quantity (Calculated) = Planned Quantity – Current Supply


Current Supply = Total Stock – Open SO + Open PO


\*\*Planned Quantity = The selected replenishment quantity (Max / Reorder  Point / Min)


{:.note}
**If **Purchase 
 in Increments of Vendor EOQ** is selected, Planned Quantity is adjusted  with open sales orders and open purchase orders and is compared with increments  of the EOQ to get the required quantity. If you see a zero (0) in the  Required quantity column of the **Item 
 Replenishment** browser, the item is needed but you must make the  decision on if or how many should be purchased. This can occur when the  Vendor EOQ is higher than the calculated required quantity, increments  of Vendor EOQ are used, and the planned quantity cannot be exceeded.**


**![]({{site.pp_baseurl}}/img/lens.gif)[Item  Replenishment Browser]({{site.pp_baseurl}}/purc-proc/pos/create-po/auto-generate-po/item-replenishment/item_replenishment_browser_find_items_dialog_box.html)**


{:.example}
**[EOQ  Selection Example]({{site.pp_baseurl}}/misc/eoq_selection_example_automated_pur_replenishment_tab_pur.html)**

| Purchase in Increments of Vendor EOQ **check box** | Do Not Exceed Planned Quantity **check <br/> box** | Result |
| Checked | Unchecked | Order will be placed for the calculated Required Quantity adjusted for  increments of the Vendor EOQ. The Vendor EOQ increments MAY exceed the  planned quantity.<br/><br/><br/>In the **Item Replenishment** browser,  **Required** quantity is displayed  in increments of Vendor EOQ. \*\* |
| Unchecked | Checked | Order will be placed for the calculated Required Quantity. The Required  Quantity will not be adjusted for Vendor EOQ.<br/><br/><br/>In the **Item Replenishment** browser,  **Required** quantity is displayed  as the calculated Required Quantity.\* |
| Unchecked | Unchecked | Order will be placed for the calculated Required Quantity. The Required  Quantity will not be adjusted for Vendor EOQ.<br/><br/><br/>In the **Item Replenishment** browser,  **Required** quantity is displayed  as calculated Required Quantity.\* |
| Checked | Checked | Order will be placed for the calculated Required Quantity adjusted for  increments of the Vendor EOQ. The Vendor EOQ increments CANNOT exceed  the planned quantity. \*\*<br/><br/><br/>In the **Item Replenishment** browser,  **Required** quantity is displayed  in increments of Vendor EOQ. |



\*Required Quantity (Calculated) = Planned Quantity – Current Supply


Current Supply = Total Stock – Open SO + Open PO


\*\*Planned Quantity = The selected replenishment quantity (Max / Reorder  Point / Min)


{:.note}
**If **Purchase 
 in Increments of Vendor EOQ** is selected, Planned Quantity is adjusted  with open sales orders and open purchase orders and is compared with increments  of the EOQ to get the required quantity. If you see a zero (0) in the  Required quantity column of the **Item 
 Replenishment** browser, the item is needed but you must make the  decision on if or how many should be purchased. This can occur when the  Vendor EOQ is higher than the calculated required quantity, increments  of Vendor EOQ are used, and the planned quantity cannot be exceeded.**


**![]({{site.pp_baseurl}}/img/lens.gif)[Item  Replenishment Browser]({{site.pp_baseurl}}/purc-proc/pos/create-po/auto-generate-po/item-replenishment/item_replenishment_browser_find_items_dialog_box.html)**


{:.example}
**[EOQ  Selection Example]({{site.pp_baseurl}}/misc/eoq_selection_example_automated_pur_replenishment_tab_pur.html)**

# Automated Purchases - Replenishment tab


Use the **Automated Purchases**  – **Replenishment** tab to indicate  the replenishment details of the item or items to be replenished including  your preferences for the inventory supply calculations.


Inventory Supply Calculation


**Location (s) Considered**
: Select a location where the item is placed. By default,  the logged in location is selected. You need adequate security rights  to select a location other than the logged in location. You can select  more than one location.


{:.note}
**If the item replenishment details for the  selected location are not defined it will be considered as zero.**


**Stock Bins Considered**
: Select the bin type to be used when calculating  required quantity. You can select one of the following values:

- **Normal 
 Type Bins Only** – This selection excludes repair, in process, scrap,  exchange, write off, and defective bins. Select this option if you do  not want to include all bin types in the **Required**  quantity on the **Item Replenishment**  browser.
- **All 
 Bins** – This selection includes bins of every type. Select this  option if you want to include bins of every type in the **Required**  quantity on the **Item Replenishment**  browser.



**Consider Open Purchase Orders/Work Orders**
: Select this check box to include open purchase orders  or work orders while filtering for the item.


**Consider Open Sales Orders/Debit Orders/Work  Orders**
: Select this check box to include all open sales  orders, debit orders, or work orders while filtering for the item. By  default, this is selected. There are two sub-options:


**Filter Sales Orders by Delivery Date**
: Select this check box to view sales orders with  delivery dates within the specified period.


**Exclude Sales Orders for Accounts On Hold**
: Select this check box to exclude the sales orders  that still have accounts on hold.


Planned Quantity – Replenish Inventory to
: The **Planned Quantity**  is the restocking point or the replenishment quantity. Select one of the  three options to use for the replenishment planning of the item:

- **Maximum 
 Quantity** – Allows you to replenish the item when the item stock  falls below the maximum level defined for the location. Maximum Quantity  is the maximum quantity of an item required in stock.
- **Reorder 
 Point** – Allows you to replenish the item when item stock falls  below the reorder point defined for the location. The Reorder Point is  the level of inventory at which a purchase requisition is to be created.
- **Minimum 
 Quantity** - Allows you to replenish the item when item stock falls  below the minimum level defined for the location. Minimum Quantity is  the minimum quantity of an item required in stock.

: By default, the **Maximum 
 Quantity** option is selected. If you do not want to purchase items  in large quantities, you can select either the **Reorder 
 Point** or **Minimum Quantity**.


**Purchase Order Generation Method**
: Select one of the following options to determine  how to generate purchase orders for your locations:

- **Generate 
 separate PO for each location** – For each vendor, one purchase order  is created for each location.
- **Generate 
 single PO for all locations** – For each vendor, one purchase order  is created for all locations. On the purchase order documents, separate  line items are created for items in multiple locations.

: Line items in purchase documents are assigned to  the location requiring the inventory.


**Purchase in Increments of Vendor EOQ**
: Select this check box to use **Increments 
 of Vendor EOQ** (Economic Order Quantity) to determine the required  quantity of an item. The **Required Quantity**  is the calculated quantity for which a purchase order will be generated.  This option is selected by default. The result of selecting/deselecting  this field is described in this [table](javascript:kadovTextPopup(this)){:id="a1"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a1');
//--></script>.


{:.example}
**[EOQ  Selection Example]({{site.pp_baseurl}}/misc/eoq_selection_example_automated_pur_replenishment_tab_pur.html)**


**Do Not Exceed Planned Quantity**
: Select this check box so that the ordered quantity  cannot exceed the planned quantity. The planned quantity is calculated  based on the replenishment method selected in the **Planned 
 Quantity – Replenish Inventory To** section.  The  result of selecting/deselecting this field is described in this [table](javascript:kadovTextPopup(this)){:id="a2"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a2');
//--></script>.


{:.example}
**[EOQ  Selection Example]({{site.pp_baseurl}}/misc/eoq_selection_example_automated_pur_replenishment_tab_pur.html)**


**Vendor Selection Method**
: Select either the **Primary 
 Vendor**, **Vendor with lowest standard 
 cost**, or **Associated Vendor**  option to retrieve the items associated with the vendors. By default,  the **Primary Vendor** option is selected.  If you select the **Vendor with lowest 
 standard cost** option, the Vendor Standard Cost is automatically  selected in the **Cost selection method**  drop-down field. If you select the **Associated****Vendor** option, all vendors associated  with items display in the **Vendor**  field on the **Item Selection** tab;  vendors not associated with any items do not appear in the **Vendor**  field.


**Cost selection method**
: Select a cost method that you want to use to find  the item. By default, **Vendor Standard 
 Cost** is selected.


{:.note}
The purchase measure of the item is updated based on the selection of  the cost in this field:

- If Vendor Standard  Cost or Vendor Last Cost is selected, the purchase measure will be updated  with the measure associated with the vendor.
- If Item Last Cost  or Item Average Cost is selected, default purchase measure will appear  as the purchase measure.



The purchase measure can be edited before creating the purchase orders.


{:.see_also}
See also
: [Automated  Purchases Dialog Box]({{site.pp_baseurl}}/purc-proc/pos/create-po/auto-generate-po/item-replenishment/automated_purchases_-_item_replenishment.html)
: [Automated  Purchases - Item Selection]({{site.pp_baseurl}}/purc-proc/pos/create-po/auto-generate-po/item-replenishment/find_item_replenishment_-_item_selection.html)
