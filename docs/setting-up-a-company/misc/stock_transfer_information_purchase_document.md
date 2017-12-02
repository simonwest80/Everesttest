---
title: Stock Transfer Information - Purchase Document
---

# Stock Transfer Information - Purchase Document


Stock transfer options for purchase documents determine the default  stock area/bin into which inventoried items received from vendors are  moved, or the stock area/bin to which items returned to vendors are moved.  Items can be moved into stock areas that are of type bin and not general  level stock areas.


![]({{site.sc_baseurl}}/img/lens.gif) [Stock Areas]({{site.sc_baseurl}}/options/miscellaneous-set-up/stock-areas/stock_areas_setup.html)


Select stock area to transfer inventoried items into when  creating


**Purchase Receipt/Invoice**
: Use this option to identify the default stock area  into which vendor shipments are initially received when creating a purchase  receipt or invoice.


{:.example}
All vendor shipments may be initially received into a stock area called  "Main".


**Debit Memo**
: Use this option to assign a default stock area to  which returns to vendors are transferred when creating a debit memo.


{:.example}
Items returned to vendors may be moved to a virtual stock area called  "Vendor RMA Out".


Select stock area to transfer inventoried items into when  assigning


**Purchase Order**
: Use this option to assign a stock area to transfer  items (for approval) received from vendors, when creating a purchase order.  You receive these items into a stock area for inspection or quality verification.


{:.note}
Only a stock area of type **Out**  can be selected, as items received in this area are not a part of your  stock until a purchase receipt is created for them.


{:.example}
Items received for approval may be moved to a stock area called 'Inspection'.


**Debit Order**
: Use this option to assign a stock area to which  defective stocks to be returned to vendors are transferred.


{:.example}
Defectives expected to be returned may be moved to a stock area called  'Vendor RMA expected'.


Select stock area to transfer inventoried items into when  un-assigning


**Purchase Order**
: Use this option to identify stock area to which  items detached from a purchase order are transferred.


{:.example}
When you receive items from vendors for approval, the rejected items  are returned to the vendors. These items may be moved to a stock area  called 'Vendor Rejects'.


**Debit Order**
: Use this option to identify the stock area to which  items attached to a debit order have to be transferred when the items  are detached.


{:.example}
When items are sent to vendors for repairs or exchange, they are recorded  in a debit order. When the items are returned after repair or exchange,  you can detach them from the debit order. Such items may be moved to a  stock area called 'Repaired Items'.


{:.see_also}
See also
: [Stock Transfer  Information]({{site.sc_baseurl}}/options/locations-and-sub-locations/location-details/stock-transfer-information/stock_transfer_information.html)
