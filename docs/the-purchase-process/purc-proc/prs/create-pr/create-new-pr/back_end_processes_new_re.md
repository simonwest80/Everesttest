---
title: Back End Processes - Create a Purchase Receipt
---

# Back End Processes - Create a Purchase Receipt

- A purchase  receipt is created with the status 'open'.
- If the purchase  receipt was created by converting an order, and all items ordered are  both fully received and invoiced, the status of the purchase order changes  to ‘closed’. Otherwise, the purchase order remains open with a received  status (not received, partially received, or fully received) and an invoiced  status (not invoiced, partially invoiced, or fully invoiced).



**![]({{site.pp_baseurl}}/img/lens.gif) [Document  Status]({{site.pp_baseurl}}/purc-proc/doc-profile/contents/document-information/document_status.html)**

- The sequence  number of the purchase receipt is generated automatically by the system.



**![]({{site.pp_baseurl}}/img/lens.gif) [Document  Number]({{site.pp_baseurl}}/purc-proc/doc-profile/contents/document-information/document_number.html)**

- Serial numbers  of serialized/auto-serialized items - If the item is serialized/auto-serialized,  serial numbers are generated for the quantities received that were not  committed. Serial numbers are assigned when the purchase receipt is saved.



Serial numbers are generated in a series  that starts from the next serial number assigned in the **Location**  profile (path: **File** > **Setup** > **Accounting**  > **Location**/**Sub-Location**  > **Options** > **Edit**  > **In New Window**) for the login  location/sub-location. If the serial number for location of the login  location/sub-location is blank, the next serial number assigned for the  **Default Location** (path: **File** > **Setup**  > **Preferences** > **Defaults**  > **Accounting**) is used.


**![]({{site.pp_baseurl}}/img/lens.gif) [Sequence  Numbers]({{site.sc_chm}}/misc/sequence_numbers_departments.html)**


**![]({{site.pp_baseurl}}/img/lens.gif) [Default  Location]({{site.sc_chm}}/misc/default_location.html)**


![]({{site.pp_baseurl}}/img/note.gif)  To  view serial numbers committed to all items in a document, select **Show All Serial Numbers**.

- The average  cost of the item is updated by adding the value of item on the receipt  to the value of total stock in 'Stock' type of stock areas and dividing  it by total quantity in stock.



Average Cost = (Value of total stock in stock  type of stock areas + Value of items received)/(Existing quantity of total  stock + Quantity received)


Value of item includes freight distributed  to the item. The purchase measure is considered for computing stock for  average cost calculations.

- The low cost,  high cost and purchase history of the item is also automatically updated.
- When quantities  of an item ordered are received on a purchase receipt, the stock status  of the item displays the following changes:



**Item Stock 
 Status**

1. There is a  decrease in the quantity of **PO**  for the items received. If the quantity received was committed on order,  the quantity of **PO** **Committed**  reduces.
- There is an  increase in **Total** quantity **** of the item.
- There is a  decrease in the **Available** quantity  of the item.
- If receipt was against a **Drop****Shipment** sales order, the items  received are automatically committed to the sales order and the **SO** **Commit**  for the item increases.
    ![]({{site.pp_baseurl}}/img/lens.gif) [Item  Stock Status ]({{site.mi_chm}}/misc/columns_in_the_item_stock_status_dialog_box.html)
    **Stock 
 Area Details**
- Stock Status  in the assigned stock area - There is an increase in the quantity of **Available** in the stock area to which  the item is assigned. The **Total**  of the item in the assigned stock area increases.
- Stock status  in committed stock area - If the quantity received was committed on order,  the quantity **PO** decreases in the  ‘out’ stock area to which it was committed.
- If the quantity  was received against a new purchase receipt without converting from order,  then the stock status of the item shows the changes listed in (2) and  (5).



![]({{site.pp_baseurl}}/img/lens.gif)[Stock  Status Details]({{site.mi_chm}}/misc/stock_status_details_section.html)
