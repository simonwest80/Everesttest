---
title: Back End Processes for the Sales Order
---

# Back End Processes for the Sales Order


The following back-end processes occur when a sales order is converted  to a sales invoice:

- If the **Shipped** quantity is less than the **Ordered** quantity, the sales order is  assigned the 'Backorder' status, upon saving the invoice.



![]({{site.sp_baseurl}}/img/lens.gif) [Partial  Invoices]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/convert-to-a-sales-invoice/processing_a_sales_invoice.html)

- If the ordered  quantity is shipped, the sales order is assigned the 'Closed' status.  To view closed sales orders, select **Options 
 &gt; Shipped Sales Orders** from the **Sales 
 Orders** browser.
- When the committed  quantity is shipped, the stock status of the item displays the following  changes:


- **Stock 
 Status of the item** - The quantity 'on reserve'  for the item reduces by the quantity shipped if the quantity was committed.
- **Stock 
 Status in the committed stock area** - If the committed quantity  is shipped, the quantity of item 'On Reserve'  in the stock area from which the item is committed reduces by the quantity  shipped. The 'Total Stock'  also decreases.


- If a sales  order with prepay terms is converted to an invoice, a warning message  is displayed in the following conditions, when you try to save the new  sales invoice:
- the flow control  preference for applying deposits to invoices is set to **Automatic**  or **Prompt**, and the deposit available  on the SO that is being transferred to the SI is less than the invoice  amount



The message that is displayed in the above  condition is “The payment terms on the order require prepayment, but the  deposit available is less than the invoice amount. Do you wish to continue?”.

- the flow control  preference for applying deposits to invoices is set to **Hold**



The message that is displayed in the above  condition is “The payment terms on the order require prepayment, but the  invoice will have a balance. Do you wish to continue?”.


{:.see_also}
See also
: [Item  Stock Status]({{site.mi_chm}}/the-items-browser/information-available/item_stock_status_item_browser_option.html)
: [Committing  items on a Sales Order]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/cmt-items/committing_items_to_the_sales_order.html)
