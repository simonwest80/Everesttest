---
title: Stock Transfer Information - Sales Document
---

# Stock Transfer Information - Sales Document


Stock transfer options for sales documents determine the default stock  area/bin into which inventoried items sold to customers have to be moved  or the stock area/bin to which items returned by customers are moved.  Items can be moved into stock areas that are of type bin and not general  level stock areas.<font style="font-family: Verdana;" face="Verdana"> </font>


![]({{site.sc_baseurl}}/img/lens.gif) [Stock Areas]({{site.sc_baseurl}}/options/miscellaneous-set-up/stock-areas/stock_areas_setup.html)


Select stock area to transfer inventoried items when creating


**Sales Invoice**
: Use this option to identify the default stock area  to transfer items sold to customers, when creating a sales invoice.


{:.example}
Items sold to customers may be moved to a virtual stock area called  'Released'.


**Credit Memo**
: Use this option to identify the default stock area  into which customer returns are received when creating a credit memo.


{:.example}
Customer returns may be received into a stock area called 'Customer  RMA' or 'Seconds'.


Select stock area to transfer inventoried items into when  assigning


**Sales Order**
: Use this option to specify the stock area to which  items committed on a sales order must be transferred.


{:.example}
When you identify the items to be shipped to customers, move them to  a separate stock area called 'Packing' to segregate them from the items  to be shipped from other stock areas.


**Credit Order**
: Use this option to specify the stock area to which  stocks committed on a credit order must be transferred. When you issue  a Return Merchandise Authorization (RMA) to customers, you attach the  items to be returned to the credit order.


{:.example}
Defectives expected to be returned or items  sent by customers for exchange or repairs may be moved to a stock area  called 'Customer RMA expected'.


Select stock area to transfer inventoried items into when  un-assigning


**Sales Order**
: Use this option to specify the stock area to which  items detached from a sales order have to be moved.


{:.example}
Items could be detached from a sales order if the customer cancels the  order, or the order is modified. Such items may be moved back to a stock  area called 'Main'.


**Credit Order**
: Use this option to specify the stock area to which  items detached from a credit order have to be moved.


{:.example}
When items are sent by customers for repairs or exchange, you can record  them  in  a credit order. When these items are returned to the customer, you can  un-assign them from the credit order and move them to a stock area called  'Serviced Items'.


{:.see_also}
See also
: [Stock Transfer  Information]({{site.sc_baseurl}}/options/locations-and-sub-locations/location-details/stock-transfer-information/stock_transfer_information.html)
