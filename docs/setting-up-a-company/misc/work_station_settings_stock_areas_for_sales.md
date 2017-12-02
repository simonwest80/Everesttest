---
title: Workstation Settings - Stock Bins - For Sales
---

# Workstation Settings - Stock Bins- For Sales


Use the **For Sales** tab to specify  the default stock bins codes for the sales and sales return documents.


****Transfer 
 Inventory To****


**Sales Invoice**
: Identify the default stock area/bin for transferring  items sold to customers by creating a sales invoice.


{:.example}
Move items sold to customers to a virtual stock area/bin called 'Released'.


**Credit Memos**
: Identify the default stock area/bin for receiving  customer returns, when a credit memo is created.


{:.example}
Receive customer returns into a stock area/bin called 'Customer RMA'  or 'Seconds'.


****Assign 
 Inventory To****


**Sales Order**
: When you identify items to be shipped to customers,  you move them to a separate stock area/bin. Identify the stock area/bin  for committing shipments made on sales orders.


{:.example}
Move items that you expect to ship to a stock area/bin called 'Packing'.


**Credit Order**
: Identify  the stock area/bin for committing stocks to be returned by customers.


{:.example}
Move defectives expected to be returned or  items sent by customers for exchange or repairs to a stock area/bin called  'Customer RMA expected'.


****Unassign 
 Inventory To****


**Sales Order**
: You must detach items committed on a sales order,  if the customer cancels or modifies the order. Specify the stock area/bin  where items detached from the sales order must be transferred.


{:.example}
Move items detached from Sales Orders back to a stock area/bin called  'Main'.


**Credit Order**
: When a customer intends to return items, the items  are committed in a credit order. If a stock area/bin is specified in the  **Assign inventory from &gt; Credit Order**  field, items are assigned to this stock area/bin. If, at a later date,  the customer does not return the items due to some reason, or you do not  accept the returns due to some warranty or company policy, the items must  be detached from the credit order.
: Specify the stock area/bin where such items must  be transferred.


{:.example}
Customer returns not finally accepted due to expiry  of the warranty period are unassigned and moved to a stock area/bin called  "Returns Not Accepted".


{:.see_also}
See also
: [Workstation  Settings - Stock Bins]({{site.sc_baseurl}}/options/miscellaneous-set-up/workstation-settings/work_station_settings_stock_areas.html)
