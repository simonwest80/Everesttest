---
title: Create a Drop Ship Purchase Order
---

# Create a Drop Ship Purchase Order


{:.steps}
To create a drop ship purchase order, do  the following:

- From a **Sales Order** profile, select **Options 
 &gt; Generate Purchase Order &gt; Generate Drop Ship PO**. You will  see the [**Generate 
 PO - Drop Ship Items** browser]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/gen-po-util/gen-dropship-po/browser/generate_po_-_drop_ship_items_browser.html).
- From the **Generate PO - Drop Ship Items** browser,  select the items for which the drop ship purchase order must be created  and choose **Options &gt; Generate POs**  to create a drop ship purchase order.



![]({{site.sp_baseurl}}/img/lens.gif) [Selecting  Items for Drop Shipment]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/gen-po-util/gen-dropship-po/sel-itms-dropship/selecting_items_for_drop_shipment.html)


![]({{site.sp_baseurl}}/img/avi.gif)  [Show  me]({{site.sp_baseurl}}/misc/dropshipment v3.html){:target="_blank" }


When the process of generating the purchase orders is complete, you  will see the [**Purchase Order Status** browser]({{site.sp_baseurl}}/misc/the_purchase_order_status_browser_sales_content.html).


When you choose to create the purchase order, a new purchase order is  generated for each vendor.


{:.note}
If you create drop ship purchase orders for two items  on a sales order that have the same vendor, a single purchase order is  created with two line items.


The creation of a drop ship purchase order cannot be undone. The delivery  method, the item description and the shipping address specified on the  sales order is copied into the drop ship purchase order that is created.


{:.note}
When drop ship purchase orders are created for all items  on the sales order and you try to create a drop ship purchase order again,  **Everest** prompts you with a message  that says that all the drop ship items have purchase order references.


The **SO #** column in the Item  Details Grid of the **Purchase Order**  profile displays the sales order number for which the drop ship purchase  order is created.


{:.see_also}
See also
: [Generate  Drop Ship Purchase Orders]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/gen-po-util/gen-dropship-po/generate_drop_ship_purchase_orders.html)
