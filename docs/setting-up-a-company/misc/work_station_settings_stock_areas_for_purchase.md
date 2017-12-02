---
title: Workstation Settings - Stock Bins - For Purchase
---

# Workstation Settings - Stock Bins - For Purchase


Use the **For Purchase** tab to  specify the default stock areas for purchase documents.


****Transfer 
 Inventory To****


**Purchase Receipts/Invoices**
: Identify the default stock bin into which vendor  shipments are received when creating a purchase receipt or invoice.


{:.example}
All vendor shipments may be received into a stock bin called 'Main'.


**Debit Memos**
: Assign a default stock bin to which returns to vendors  are transferred when creating a debit memo.


{:.example}
Move items returned to vendors to a virtual stock bin called 'Vendor  RMA Out'.


****Assign 
 Inventory To****


**Purchase Order**
: You would normally commit items on a purchase order,  when they are on an approval basis, and you want to verify their quality.  Assign a stock area/bin to transfer items received against a purchase  order.


{:.note}
You can select only a stock area/bin of type  'Out', as items received in this area/bin are not a part of your stock  until a purchase receipt is created for them.


{:.example}
Move items received for approval to a stock area/bin called 'Inspection'.


**Debit Order**
: Assign a stock area/bin for committing defective  stock to be returned to vendors.


{:.example}
Defective items expected to be returned may be moved to a stock area/bin  called 'Vendor RMA expected'.


****Unassign 
 Inventory To****


**Debit Order**
: When items are committed to be sent to vendors for  repairs or exchange, assign them to a debit order. When the items are  returned after repair or exchange, detach them from the debit order.
: Specify the stock area/bin for items to be transferred,  after they are returned (after repair or exchange) from the vendor.


{:.example}
Move items returned after repair from vendors to a stock area/bin called  'Repaired Items'.


**Do not update last cost/last add-on cost when  receiving**
: Select this check box if you do not want the last  cost/last add-on cost of the item to be updated when it is purchased.


{:.example}
Select this option, if an item's selling price is defined as a mark  up on its last cost/last add-on cost and you do not want the last cost/last  add-on cost to fluctuate every time the item is purchased.


{:.see_also}
See also
: [Workstation  Settings - Stock Bins]({{site.sc_baseurl}}/options/miscellaneous-set-up/workstation-settings/work_station_settings_stock_areas.html)
