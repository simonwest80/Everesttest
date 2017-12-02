---
title: Create a Purchase Order Linked to a Sales Order
---

# Create a Purchase Order Linked to a Sales Order


{:.steps}
To create a purchase order linked to a sales  order, do the following:

- From a **Sales Order** profile, select **Options 
 &gt; Generate Purchase Orders &gt; Generate Linked PO**. You will  see the **Generate Linked PO** browser.
- From the **Generate Linked PO** browser, select the  items for which the linked purchase order must be created and choose **Options &gt; Generate Linked POs**.



![]({{site.sp_baseurl}}/img/lens.gif) [Selecting  Items while Creating a Linked PO]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/gen-po-util/gen-po-links/sel-items-creating-po/selecting_items_while_creating_a_linked_po_sales.html)


When the process of generating the purchase orders is complete, you  will see the [**Purchase Order Status** browser]({{site.sp_baseurl}}/misc/the_purchase_order_status_browser_po_with_links_sales.html) wherein  a new purchase order is generated for each vendor.


{:.note}
A single purchase order is created for two line items  on a sales order that have the same vendor.


The creation of a purchase order cannot be undone. The default shipping  address of the vendor is displayed in the ship to address column of the  purchase order. The delivery method in a linked purchase order is the  same as the default delivery method of the vendor.


{:.note}
When purchase orders are created for all items on the  sales order and you try to create a purchase order with links again, **Everest** prompts you that all the non-drop  ship items have purchase order references.


The **SO #** column in the Item  Details Grid of the **Purchase Order**  profile displays the sales order number from which the purchase order  has been created.
