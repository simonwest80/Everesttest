---
title: Back End Processes - Creating a Sales Invoice
---

# Back End Processes - Creating a Sales Invoice


The following back-end processes occur  when a sales invoice is created:

- The status  of the sales invoice is 'Open'.
- If the sales  invoice is created from an order, and all items ordered are shipped, the  status of the order changes to 'Closed'. If items remain to be shipped,  the status changes to 'Backorder'.



**![]({{site.sp_baseurl}}/img/lens.gif) [Document  Status]({{site.sp_baseurl}}/sales-docs/docs-profile/contents/tab-details/details/other/document_status_document_information_sales_content.html)**

- The sequence  number of the sales invoice is generated automatically by the system.



**![]({{site.sp_baseurl}}/img/lens.gif) [Document  Number]({{site.sp_baseurl}}/sales-docs/docs-profile/contents/doc-info/document_number_document_information_sales_content.html)**

- When the items  ordered are shipped, the stock status of the item displays the following  changes:


- **Stock 
 Status of the item** – There is a decrease in the quantity 'On Reserve'  for the items shipped. If the quantity shipped was committed on the order,  the quantity 'On Reserve Committed' reduces. There is a decrease in the  'Total Stock' of the item and a decrease in the available stock and net  free stock.
- **Stock 
 Status in the assigned stock area** – The assigned stock area is  the stock area to which the item is transferred when the sales invoice  is created. There is an increase in the quantity of item in the 'Available  Out' column of the assigned stock area. The stock in the 'Out' column  of the item in the assigned stock area increases.
- **Stock 
 Status in committed stock area** - If the quantity shipped was committed  on the order, the quantity 'On Reserve' decreases in the stock area from  which it was committed. The 'Stock' of the item in the committed stock  area also decreases.



![]({{site.sp_baseurl}}/img/lens.gif) [Stock  Status]({{site.sp_baseurl}}/sales-docs/docs-profile/options/items/stock_status_items_option_sales_contents.html)

- **Serial 
 numbers of serialized/auto-serialized items** - If the item is serialized/auto-serialized,  an entry is added to the **Serial Number 
 History** of the item.


- **Average 
 cost of serialized items** - When a serialized item is sold, the  total stock value of that item is reduced by the actual cost of the item.  The average cost of the item is recalculated after the shipment.



![]({{site.sp_baseurl}}/img/example.gif) The  average cost of 10 units of a serialized item is $100. You ship a unit  whose actual cost is $110. The total value of the 9 items in stock is  $890 ($1000 - $110) and the average cost changes to $98.89 ($890/9).

- Stock value  of items is reduced by the value of items that were shipped.
- The customer's  unposted amount  and net balance increases by the value of the invoice. When the sales  journal for the invoice is posted, the posted amount increases and the  unposted amount  reduces.



{:.see_also}
See also
: [Accounting  Entries - Creating a Sales Invoice]({{site.sp_baseurl}}/sales-docs/sis/create-si/create-new-si/accnt-entries/accounting_entries_creating_a_sales_invoice.html)
: [Creating  a Sales Invoice]({{site.sp_baseurl}}/sales-docs/sis/create-si/create-new-si/creating_a_new_sales_invoice.html)
