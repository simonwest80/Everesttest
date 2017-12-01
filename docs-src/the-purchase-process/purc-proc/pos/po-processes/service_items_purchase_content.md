---
title: Track Service Items
---

# Track Service Items


You can keep track of items that are sent to vendors for service or  repairs. Items can be retrieved into purchase orders, and then their item  type toggled to 'service', to denote that these represent items sent out  for service. You can also use the **Document****Alias** option to track service  orders placed with vendors .


![]({{site.pp_baseurl}}/img/lens.gif) [Document  Alias]({{site.bp_chm}}/doc-aliases/document_aliases_businesss_process_in_everest_content.html)


![]({{site.pp_baseurl}}/img/steps.gif)To track items sent for service or track payments  made for services received, do the following:

- From the main  menu bar, select **Purchasing** >  **Other** **Documents**  > <Document Alias for Service Order>. You will see the **&lt;Service Orders&gt;** browser.
- From the **&lt;Service Orders&gt;** browser, select  **Options** > **New**  > **In New Window**. You will see  the **&lt;Service Order&gt;**profile.



{:.hint}
If you have not created the document alias  ‘Service Order’,  you can create a purchase order directly by selecting **Purchasing**  > **Purchase** **Orders**.


![]({{site.pp_baseurl}}/img/lens.gif) [Create  a Document Alias]({{site.bp_chm}}/doc-aliases/create/creating_a_document_alias_businesss_process_in_everest_content.html)

- Retrieve the  item code into the document.
- Change the  item type to service by clicking the **Type**  column for the line item, and pressing the **Spacebar**  key.
- Attach/commit  the items returned for repair or service.



{:.note}
- The cost of the  item displayed is the item’s last cost. For service items, this amount  represents the value of service charges. If the item is under warranty  and no costs are associated, you must change the item cost to zero.
- Service items although  sent to vendors for service, continue to be a part of your stock.
- The serial number  must be attached from the ‘stock’ type of stock areas for serialized items  sent for service. For non-serialized items, tracked for lots, the item  has to be attached from stock.
- You cannot toggle  a back ordered item to type ‘service’. Further, if quantities are attached  for the line item, **Everest** does  not allow you to toggle it to type ‘Service’.

- When the vendor  has serviced the order, create a purchase receipt for the vendor by converting  the order to a receipt. You can specify the service charges either in  the item’s cost column or add it as line item.



{:.note}
The **Serial****Number** **History**  browser of the item displays the serial number that has been attached  to the service order and later returned by the vendor.
