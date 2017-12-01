---
title: Create a Purchase Order from a Sales Order
---

# Create a Purchase Order from a Sales Order


{:.steps}
To create a purchase order from a sales order,  do the following:

- From a **Sales Order** profile, select **Options 
 &gt; Generate Purchase Orders &gt; Generate PO**. You will see the  **Generate PO** browser.
- From the **Generate PO** browser, select the items  for which the purchase order must be created and choose **Options 
 &gt; Generate POs**.

: ![]({{site.sp_baseurl}}/img/lens.gif) [Selecting  Items while Creating a Purchase Order]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/gen-po-util/gen-po/sel-itms/selecting_items_while_creating_a_purchase_order.html)


When the process of generating the purchase orders is complete, you  will see the [**Purchase Order Status** browser]({{site.sp_baseurl}}/misc/purchase_order_status_browser_generate_po_sales.html) wherein  a new purchase order is generated for each vendor.


{:.note}
If you create purchase orders for two items on a sales  order that have the same vendor, a single purchase order is created with  two line items.


The creation of a purchase order cannot be undone.<font style="color: #ff0000;" color="#FF0000"> 
 </font>The default shipping address of the vendor is displayed in the  ship to address column of the purchase order. The delivery method is the  same as the default delivery method of the vendor.


{:.note}
If you have already created drop ship or linked purchase  orders for all items on the sales order, you cannot create another purchase  order from the sales order document as **Everest**  looks for line items without a purchase order reference. **Everest**  prompts you with a message that says that all the non-drop ship items  have purchase order references.


The **SO #** column in the Item  Details Grid of the **Purchase Order**  profile does NOT display the sales order number from which the purchase  order has been created as it is not linked to the sales order.


If the line items contained in a sales order have the same item code,  vendor, delivery date and cost, the quantities are clubbed and displayed  in the purchase order that is created.


If the delivery date or cost of the line items that have the same item  code and vendor are different, separate line items are created for each  item in the purchase order.


{:.see_also}
See also
: [Generate  Purchase Orders]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/gen-po-util/gen-po/generate_purchase_orders_sales.html)
