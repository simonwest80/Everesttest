---
title: Processing a Sales Invoice
---

# Processing a Sales Invoice


**A sales order can be processed to a sales  invoice using the **Process** >  **Invoice** option from the **Sales Order** profile. The details of  the order are copied to a **Sales Invoice**  profile; the quantity in the **Committed**  column appears in the **Shipped**  column by default. When the Sales Invoice is saved, the **Shipped**  column of the Sales Order is updated with the quantity shipped.**


**You can create a sales invoice every time  a shipment is made against the sales order.**


**Partial Shipments of Inventoried Items**


**If items are shipped in various stages  against a sales order, multiple sales invoices can be created for the  same sales order.**


![]({{site.sp_baseurl}}/img/example.gif) If five computers are  ordered but only three are shipped initially, a sales invoice can be created  for the three items that are shipped. Later when the rest of the computers  are shipped, another sales invoice can be created.


**When a partial shipment is made the status  of the sales order changes to **Back Order** on the document and in the **Sales 
 Orders** browser. When all the items are shipped, the sales order  status changes to **Closed**.**


{:.see_also}
See also
: [Ordered,  Committed and Shipped in Sales Orders]({{site.sp_baseurl}}/sales-docs/docs-profile/contents/item-info/details/ordered_committed_and_shipped_columns_in_sales_orders.html)
: [Creating  a Sales Invoice]({{site.sp_baseurl}}/sales-docs/sis/create-si/convert-a-sales-order/converting_an_existing_order_to_an_invoice.html)
