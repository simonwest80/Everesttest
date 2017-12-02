---
title: Back End Processes - Create a Debit Order
---

# Back End Processes - Create a Debit Order


When you create a debit order, the following back end processes occur:

- The next sequence  number of the debit order is generated automatically by the system.



**![]({{site.pp_baseurl}}/img/lens.gif) [Document  Number]({{site.pp_baseurl}}/return-proc/doc-prof/contents/document-information/document_number_pr.html)**

- A debit quote number  is assigned to the debit order. The next sequence number specified for  debit quotes in the **Location** profile  is assigned to the quote. This is used to change the order back to a quote,  if the debit order is cancelled.



**![]({{site.pp_baseurl}}/img/lens.gif) [Location  Profile]({{site.sc_chm}}/options/locations-and-sub-locations/set-up-locations/the_location_profile.html)**

- The debit order  is initially assigned the status ‘open’.
- The following changes  occur in the stock status of the item as viewed in the **Item 
 Stock Status** dialog box:



| Column | Stock Increase/Decrease |
| On Debit | Increases by quantity of the item returned. |
| Available Quantity | Decreases by the quantity returned. |



![]({{site.pp_baseurl}}/img/lens.gif) [Item  Stock Status]({{site.mi_chm}}/misc/columns_in_the_item_stock_status_dialog_box.html)
