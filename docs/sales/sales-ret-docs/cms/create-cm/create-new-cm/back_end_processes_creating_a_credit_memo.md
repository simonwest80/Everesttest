---
title: Back End Processes - Creating a Credit Memo
---

# Back End Processes - Creating a Credit Memo


The following back-end processes occur  when a credit memo is created:

- A credit memo  is created with the status 'Open'.
- If the credit  memo is created by converting an order, and all items requested are received  or credited, the status of the order changes to 'Closed'. If items remain  to be received, the status changes to 'Backorder'.



**![]({{site.sp_baseurl}}/img/lens.gif) [Document  Status]({{site.sp_baseurl}}/sales-ret-docs/sales-ret-doc/contents/tab-details/dtls-info/other/document_status.html)**

- The sequence  number of the credit memo is generated automatically by the system.



**![]({{site.sp_baseurl}}/img/lens.gif) [Document  Number]({{site.sp_baseurl}}/sales-ret-docs/sales-ret-doc/contents/doc-info/document_number_document_information_sales_return_document_content.html)**

- When the items  requested are returned, the stock status of the item displays the following  changes:


- **Stock 
 Status of the item** – There is a decrease in the quantity of 'On  Credit' and  'On Credit Committed'  for the items received. There is an increase in the 'Total Stock' and  'Available Stock' of the item.
- **Stock 
 Status in the assigned stock area** - The assigned stock area is  the stock area to which the item is transferred when the credit memo is  created. There is an increase in the quantity of item in the 'Available  Stock' and 'Stock' columns of the assigned stock area.
- **Stock 
 Status in Committed Stock Area** - If the quantity returned was committed  on the order, the quantity 'On Credit' decreases in the stock area from  which it was committed. The 'Stock' of the item in the committed stock  area also decreases.



![]({{site.sp_baseurl}}/img/lens.gif)<font style="color: #800080;" color="#800080"> 
 </font>[Stock Status]({{site.sp_baseurl}}/sales-docs/docs-profile/options/items/stock_status_items_option_sales_contents.html)

- If the item  is serialized/auto-serialized, an entry is added to the **Serial 
 Number History** of the item.


- When a serialized  item is returned, the total stock value of that item is increased by the  actual cost of the item. The average cost of the item is recalculated  after the return.



![]({{site.sp_baseurl}}/img/example.gif) The  average cost of 10 units of a serialized item is $100. A unit whose actual  cost is $110 is returned. The total value of the 11 items in stock is  $1110 {($100 \* 10) + $110} and the average cost changes to $100.09.

- Stock value  of items is increased by the value of items returned.
- The customer's  unposted amount  and receivable amount reduces by the value of the memo. When the sales  journal for the credit memo is posted, the posted amount reduces and the  unposted amount  increases.



{:.see_also}
See also
: [Accounting  Entries - Creating a Credit Memo]({{site.sp_baseurl}}/sales-ret-docs/cms/create-cm/create-new-cm/accnt-entries/accounting_entries_creating_a_credit_memo.html)
: [Requested,  Committed and Received Quantities]({{site.sp_baseurl}}/sales-ret-docs/sales-ret-doc/contents/item-info/details/requested_committed_and_credited_columns_in_credit_memos.html)
: [Creating  a Credit Memo]({{site.sp_baseurl}}/sales-ret-docs/cms/create-cm/create-new-cm/creating_a_new_credit_memo.html)
