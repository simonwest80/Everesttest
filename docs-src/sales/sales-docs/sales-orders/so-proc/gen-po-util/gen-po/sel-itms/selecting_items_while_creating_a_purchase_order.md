---
title: Selecting Items while Creating a Purchase Order
---

# Selecting Items while Creating a Purchase Order


{:.steps}
To select items while creating a purchase  order from a sales order, do the following:

- From the **Sales Order** profile, select **Options 
 &gt; Generate Purchase Orders &gt; Generate PO**. You will see the  **Generate** **PO**  browser.
- From the **Generate PO** browser, select the check  box beside the line items for which the purchase order must be created.



{:.note}
If you create a purchase order for an item that is marked  for drop shipment, the check box in the **Drop 
 Ship** column in the Item Details Grid of the sales order document  remains unchecked as it is not a drop ship process.


You can change the following in the **Generate 
 PO** browser:

- Vendor
- Quantity Ordered
- Cost



Change the Vendor


You can change or assign the vendor by selecting **Options 
 &gt; Edit &gt; Line Items** in the **Generate 
 PO** browser, and selecting a vendor in the [**Profile - Line Item(s)**  window]({{site.sp_baseurl}}/misc/the_profile_line_item_s_profile_drop_ship.html).


The items selected in the browser are grouped according to the [default  vendor]({{site.mi_chm}}/item-profile-details/other-items-information/purchase/default_vendor.html) assigned to the item in the **Item**  profile (path: **Inventory &gt; Items &gt; 
 Options &gt; Edit &gt; In New Window**).


If an item is not assigned a default vendor and you select the check  box for this  item  to create a purchase order, you are prompted of the same. You must assign  a vendor to the item and try again.


Modify the Quantity Ordered


You can modify the quantity of the ordered items. Click in the **Qty Needed** column in the **Generate 
 PO** browser and enter the quantity. Quantity ordered cannot be more  than the quantity on the sales order. If it is, you are prompted with  a message to that effect.


Modify the Cost


You can modify the cost of the ordered items. Click in the **Cost** column in the **Generate PO** browser  and enter the revised cost.


{:.see_also}
See also
: [Generate  Purchase Orders]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/gen-po-util/gen-po/generate_purchase_orders_sales.html)
