---
title: Automated Purchases for Drop Shipments
---

# Automated Purchases for Drop Shipments


The **For Dropships**  option (path: **Inventory &gt; Automated 
 Purchases &gt; For Drop Ships**) allows you to create purchase orders  for dropship  items on existing sales orders. A dropship  item is a line item in which the **Drop 
 ship** column is selected in the sales order. Selecting  this option brings up the **Automated Purchases 
 - Drop Ship Items** browser.


The **Automated Purchases 
 - Drop Ship Items** Browser


This browser lists all the dropship  items on sales orders for which dropship purchase orders have not been  created.


This browser contains information such as item code, description, category,  sales measure, selling price, cost, last cost, average cost and weight.  It also lists the quantity needed, delivery date, ship to address, sales  order number, customer number, total stock, and stock available, on reserve,  on debit, on order and on credit. This browser also displays the customer's  name, whether the customer is on hold, the payment terms and currency  code of the sales order, and the balance receivable on the order.


All items are grouped according to the default vendor. All items for  which a vendor is not defined are grouped together.


![]({{site.pp_baseurl}}/img/lens.gif) [The  Item Profile]({{site.mi_chm}}/create-regular-items-kits-and-assemblies/creating-an-item/the_item_profile_-_general.html)


{:.note}
If a sales order is partially fulfilled, the  remaining items are not displayed in the **Automated 
 Purchases - Drop Ship Items** browser.


You can edit the **Qty Needed**  and **Cost** columns. However, the  ‘quantity needed’ **** cannot exceed the quantity specified  in the sales order.


{:.note}
The line item due dates specified in the sales document  are displayed in the **Automated Purchases 
 - Dropship 
 Items** browser. If line item due dates are not specified, **Everest** takes the document delivery  date instead.


If the document delivery date is changed subsequently,  **Everest** gives a message that line  items have delivery dates different from the document’s delivery date,  and the existing delivery dates of the line items will be retained.


For drop ship orders, the purchase orders created are in the same measure  and quantity as in the sales order. If the sales measure is not defined  as a purchase measure, you will be given the option to create the sales  measure as the purchase measure, in order to create the drop-ship PO.


{:.note}
If you change the purchase measure in the  drop ship purchase order, the link to the sales order is removed.


{:.see_also}
See also
: [Automated  Purchases - Drop Ship Items Browser Options]({{site.pp_baseurl}}/purc-proc/pos/create-po/auto-generate-po/for-drop-ships/automated_purchases_drop_ship_items_browser_options.html)
: [Create  Purchase Orders for Drop Ship Items]({{site.pp_baseurl}}/purc-proc/pos/create-po/auto-generate-po/for-drop-ships/create_automated_purchase_orders_for_dropship_items.html)
: [Automated  Purchases]({{site.pp_baseurl}}/purc-proc/pos/create-po/auto-generate-po/automatically_generating_purchase_orders.html)
