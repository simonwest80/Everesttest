---
title: Selecting Items while Creating a Linked PO
---

# Selecting Items while Creating a Linked PO


{:.steps}
To select items while creating a linked purchase  order, do the following:

- From the **Generate Linked PO** browser, select the  items for which the linked purchase order must be created.



If you create a purchase order for an item that has been marked for  drop shipment (by selecting the check box and choosing **Options &gt; Generate Linked POs**), the check box in the **Drop 
 Ship** column in the Item Details Grid of the sales order document  remains unchecked as it is not a drop ship process.


You can change the following in the **Generate 
 Linked PO** browser:

- Vendor
- Quantity Ordered
- Cost



Change the Vendor


You can change or assign the vendor by selecting **Options 
 &gt; Edit Line Items** in the **Generate 
 Linked PO** browser, and selecting a vendor in the **** [**Profile 
 - Line Item(s)** window]({{site.sp_baseurl}}/misc/the_profile_line_item_s_profile_drop_ship.html).


The items selected in the browser are grouped according to the default  vendor attached to the item in the [**Items** profile]({{site.mi_chm}}/create-regular-items-kits-and-assemblies/creating-an-item/the_items_profile_-_purchases.html) (path: **Inventory 
 &gt; Items &gt; Options &gt; Edit &gt; In New Window**).


![]({{site.sp_baseurl}}/img/lens.gif) [Default  Vendor]({{site.mi_chm}}/item-profile-details/other-items-information/purchase/default_vendor.html)


If an item is not assigned a default vendor and you select the check  box for this  item  to create a purchase order, you are prompted of the same. You must assign  a vendor to the item and try again.


Modify the Quantity Ordered


You can change the quantity of the ordered items. Click in the **Qty Needed** column in the **Generate 
 Linked PO** browser and enter the quantity. Quantity ordered cannot  be more than the quantity on the sales order. If it is, you are prompted  with a message to that effect.


Modify the Cost


You can modify the cost of the ordered items. Click in the **Cost** column in the **Generate Linked 
 PO** browser and enter the revised cost.


{:.see_also}
See also
: [Generate  Linked PO Browser]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/gen-po-util/gen-po-links/generate-linked-po-browser/generate_linked_po_browser_sales.html)
