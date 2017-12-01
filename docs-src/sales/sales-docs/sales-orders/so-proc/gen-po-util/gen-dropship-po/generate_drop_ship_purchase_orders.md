---
title: Generate Drop Ship Purchase Orders
---

# Generate Drop Ship Purchase Orders


Drop shipments refer to the direct shipment of items from your vendors  to your customers. This method is useful for firms that do not stock inventory  of the products they sell. A purchase order is placed with vendors for  the products ordered by customers; the vendor directly supplies the items  to the customer.


Use the drop-ship utility to perform the following functions:

- Create drop-ship  purchase orders for selected items and related default vendors on sales  orders.
- Automatically  reference the customer's shipping address in the drop-ship purchase order.
- Automatically  assign items received on purchase receipts or invoices created through  drop-ship purchase orders, to sales order.
- Link the sales  orders and the drop-ship purchase orders by mutual references.



If a drop-ship purchase order is not created from the sales order, you  can generate it from the **Automated Purchases 
 - Drop Ship Items** browser (path: **Inventory 
 &gt; Automated Purchases &gt; For Dropships**).


![]({{site.sp_baseurl}}/img/lens.gif) [Automated  Drop Ship]({{site.pp_chm}}/purc-proc/pos/create-po/auto-generate-po/for-drop-ships/automated_purchases_for_drop_shipments.html)


If you have set a preference in the [**Documents** dialog box]({{site.bp_chm}}/misc/prompts_sales_document_sales_document_2_steps.html) by selecting  the **Prompt to create PO** option  in the **When a sales order with drop ship 
 items is saved** field (path: **File 
 &gt; Setup &gt; Preferences &gt; Flow Control &gt; Documents &gt; Prompts 
 &gt; Sales Documents &gt; Sales Documents 2** tab), and you save  a sales order that has a drop-ship item, you are asked whether you want  to create a purchase order for drop-ship items in the document. Click  **Yes** and you will see the **Generate PO - Dropship 
 Items** browser from where you can create a drop-ship purchase order.  Click **No** to return to the sales  order document.


[]()Drop Ship Items


Items can be marked as drop ship items by selecting one of the following:

- The **Drop 
 Shipment** check box in the **Item**  profile (path: **Inventory &gt; Items &gt; 
 Options &gt; Edit &gt; In New Window &gt; Purchases** tab).



**OR**

- The check box  in the **Drop Ship** column in the  Item Details Grid of the sales order document. You can select the **Drop Ship** check box by pressing the  **Spacebar** key.



{:.see_also}
See also
: [Generate  PO - Drop Ship Items Browser]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/gen-po-util/gen-dropship-po/browser/generate_po_-_drop_ship_items_browser.html)
: [Flow  Chart of the Drop Shipment Process]({{site.sp_baseurl}}/misc/flow_chart_of_the_drop_shipment_process.html)
