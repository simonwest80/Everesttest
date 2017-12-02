---
title: Back End Processes - Create a Debit Memo
---

# Back End Processes - Create a Debit Memo


When a debit memo is created the following back end processes occur:

- A debit memo  is created with the status ‘Open’.
- If the debit  memo was created by converting an order, and all items requested are returned,  the status of the order changes to ‘Closed’. If items remain to be returned,  it changes to ‘Backorder’.



**![]({{site.pp_baseurl}}/img/lens.gif) [Document  Status]({{site.pp_baseurl}}/return-proc/doc-prof/contents/document-information/document_status_pr.html)**

- The sequence  number of the debit memo is generated automatically by the system



**![]({{site.pp_baseurl}}/img/lens.gif) [Document  Number]({{site.pp_baseurl}}/return-proc/doc-prof/contents/document-information/document_number_pr.html)**

- When quantities  of an item requested are returned on a debit memo, the stock status of  the item displays the following changes as viewed in the [**Item Stock Status** dialog box]({{site.mi_chm}}/misc/the_item_stock_status_dialog_box.html):


1. **Stock 
 status of the item** - There is a decrease in the quantity of items  "On Debit" for the items returned. If the items were committed  on the debit order, the quantity "On Debit Committed" also reduces.  There is a decrease in the "Total stock".
- **Stock 
 status in the assigned stock area** - The assigned stock area is  the area to which items are transferred when a debit memo is created.  There is an increase in the "Out" and "Free Out" quantity  in the assigned stock area.
- **Stock 
 Status in the committed stock area** - If the quantity returned was  committed on the order, the "Stock" and "On Debit"  quantity reduces in the committed stock area.


- **Average 
 cost of serialized items** - When a serialized item is returned,  the total stock value of that item is reduced by the actual cost of the  item. The average cost of the item is recalculated after the return.



{:.example}
The average cost of 10 units of a serialized  item is $100; you return a unit whose actual cost is $110, the total value  of the 9 items in stock is $890 and the average cost changes to $98.8.

- **Serial 
 numbers of serialized/auto-serialized items** - If the item is serialized/auto-serialized,  an entry is added to the **Serial Number 
 History** of the item.
- The vendor's unposted  amount and payable amount reduces by the value of memo. When the Purchase  Journal for the memo is posted, the posted amount reduces and unposted  amount increases.

