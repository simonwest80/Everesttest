---
title: Item Replenishment Browser
---

# Item Replenishment Browser


This browser allows you to replenish the items and generate purchase  orders. It displays a list of the primary vendors or vendors with lowest  standard cost with their respective item codes, standard cost, last cost,  lead time, EOQ, purchase measure, and whether the vendor is a primary  vendor or not.


The result of the parameters that you set for filtering in **Automated 
 Purchases** dialog box will appear in this browser. If you have selected  multiple locations in **Automated Purchases**  dialog box, the details in the browser is divided based on the location.  Otherwise, the details will appear according to the primary vendor.


**Planned Quantity**
: The **Planned Quantity**  is the quantity selected on the **Planned 
 Quantity** – **Replenish Inventory 
 To** field of the **Automated Purchases**  – **Replenishment** tab. This field  displays the Maximum Quantity, Reorder Point, or Minimum Quantity for  each item depending upon your previous selection.


**Transit (In)**
: This column shows the stock that is transferred  to the requesting location.


**Transit (Out)**
: This column shows the stock that is transferred  out of the origin location.


**Required**
: The **Required**  field displays the adjusted required quantity based on your selections  in the **Automated****Purchases** dialog box. Adjust  the **Required** quantity to purchase  as needed. The **Required** quantity  defaults to the same decimal accuracy as the purchase measure. Your field  selections for **Purchase in Increments 
 of Vendor EOQ**, **Do Not Exceed Panned 
 Quantity**, and **Planned Quantity 
 – Replenish Inventory To** in the **Automated 
 Purchases** dialog box can change this required quantity.


{:.note}
This field includes the quantity that is In  transit. For the source location, it will show a decrease of the transferred  quantity and calculate the replenishment. For the destination location,  it will show an increase in the transferred quantity at the Completed  stage and calculate replenishment.


The browser options for the **Item Replenishment**  browser are detailed below:


**Change Vendor**
: This option allows you to change the vendor for  the selected item. Select either the **Associated 
 Vendors** or **All Vendors**  sub-option to bring up the [**Replenishment Details** browser]({{site.pp_baseurl}}/purc-proc/pos/create-po/auto-generate-po/item-replenishment/replenishment_details_browser_option_change_vend_item_rep_brow.html) **** based on your selection.

- **Associated 
 Vendor** - Allows you to view the list of vendors that are associated  with the item.


- **All 
 Vendors** - Allows you to view a list of all the vendors irrespective  of whether they are associated with the item or not.

: The **All Vendors**  sub-option is useful when you have to generate a purchase order for a  vendor not defined for the item. In the **Replenishment 
 Details** browser, click the vendor that you want to associate with  the selected item.


**Select all Items**
: This option allows you to select all the items in  this browser.


**Select Items (Current Vendor)**
: This option allows you to select the items for the  vendor selected in the **Automated Purchases** dialog box.


**Unselect Items (Current vendor)**
: This option allows you to deselect the items for  the vendor selected in the **Automated 
 Purchases** dialog box.


**Mark Selected Item**
: This option allows you to mark (select) the item  currently selected in this browser.


**Item Stock Status**
: This option displays the stock status of the selected  item in **Item 
 Stock Status** browser.


**Item Purchase History**
: This option displays the purchase history of the  selected item in the **Item 
 Purchase History** browser.


**Generate POs**
: Creates purchase order for the selected items. The  **Purchase 
 Order Status** dialog box appears after the purchase order is  created. Double-click on the item to view the purchase order. If you have  multiple locations, you can create one purchase order for each location  or one purchase order for all locations depending upon your **Purchase 
 Order Generation Selection Method** selection on the **Automated****Purchases** dialog box – **Replenishment**  tab.
: ![]({{site.pp_baseurl}}/img/lens.gif) [Automated  Purchases - Replenishment tab]({{site.pp_baseurl}}/purc-proc/pos/create-po/auto-generate-po/item-replenishment/find_item_replenishment_-_replenishment_tab.html)


**Generate PO (Current Vendor)**
: Creates purchase orders for the vendor selected  in the **Automated Purchases** dialog  box.


Options common to all browsers are also available in this  browser.
: ![]({{site.pp_baseurl}}/img/lens.gif) [Standard  Browser Options]({{site.wwe_chm}}/everest-client/ui/browsers/standard_browser_options.html)


{:.see_also}
See also
: [Automated  Purchases Dialog Box]({{site.pp_baseurl}}/purc-proc/pos/create-po/auto-generate-po/item-replenishment/automated_purchases_-_item_replenishment.html)
