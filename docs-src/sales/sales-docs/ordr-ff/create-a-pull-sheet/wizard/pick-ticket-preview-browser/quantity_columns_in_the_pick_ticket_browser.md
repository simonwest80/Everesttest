---
title: Quantity Columns in the Pick Ticket Browser
---

# Quantity Columns in the Pick Ticket Browser


The quantity columns in the **Pick Ticket 
 Browser** are detailed below:


**Measure Code**
: This column shows the sales measure selected for  the item in the sales order.


**Quantity Available**
: This column displays the total stock of the item  available in all the stock areas selected in the [Stock  Bin Selection]({{site.sp_baseurl}}/sales-docs/ordr-ff/create-a-pull-sheet/wizard/stock-bin-selection/document_criteria_-_stock_area_selection_pick_ticket_wizard.html) **** section of the  **Pull Sheet Wizard**. The quantity  available is shown in the sales measure selected for the item in the sales  order up to 6 decimal places. This quantity does not include stock committed  on sales orders and debit orders.
: ![]({{site.sp_baseurl}}/img/lens.gif) [Item  Stock Status]({{site.mi_chm}}/the-items-browser/information-available/item_stock_status_item_browser_option.html)
: You cannot edit this column.
: If an item is displayed more than once in this browser,  and it is selected for picking, the available stock progressively decreases  for later occurrences of the item.
: ![]({{site.sp_baseurl}}/img/example.gif) Item 1 exists in sales orders 1000, 1001 and 1002, the initial  quantity available is 100 and all the sales orders have been selected  for picking. The details are given below:


**Sales Order # Quantity  Ordered (of Item 1)**


1000 10


1001 15


1002 20


The quantity available will be as follows:

### Sales Order # Quantity Available (of  Item 1)


1000 100


1001  90


1002  75


**Quantity Ordered**
: This column displays the quantity as displayed in  the **Ordered** column of the **Sales Order** profile. You cannot edit  this column. The quantity ordered displays in the decimal accuracy allowed  for the item selected in the sales order.


**Quantity Shipped/Committed**
: This column displays the quantity that is already  shipped and/or committed on the sales order. You cannot edit this column.  Manually committed inventory is indicated in bright green on the **Pick Ticket** browser. The quantity shipped/committed  displays in the decimal accuracy allowed for the item selected in the  sales order.


**Quantity Required**
: This column displays the total quantity that has  to be picked for the item. The quantity required is equal to the quantity  ordered (provided that no shipments have been made on the sales order).
: Quantity Required = Quantity Ordered - Quantity  Shipped
: You cannot edit this column. The quantity required  displays in the decimal accuracy allowed for the item selected in the  sales order.


**Quantity to be Picked**
: This column displays the actual number of items  that are being picked. By default, the **Quantity 
 to be Picked** is the quantity displayed in the **Quantity 
 Required** column.
: Enter the quantity that you will pick in this column.  It cannot exceed the **Quantity****Required**.


**<font style="color: #000000;" color="#000000">Quantity that can be Picked</font>**
: This column displays the quantity displayed in the  **Quantity to be Picked** column or  the **Quantity Available** column,  whichever is lesser. If the **Quantity 
 to be Picked** column is edited, the quantity in the **Quantity 
 that can be picked** column is recalculated as it is based on the  **Quantity to be Picked** and **Quantity Available** columns. The quantity  that can be picked displays in the decimal accuracy allowed for the item  selected in the sales order.


{:.see_also}
See also
: [Pick  Ticket Browser]({{site.sp_baseurl}}/sales-docs/ordr-ff/create-a-pull-sheet/wizard/pick-ticket-preview-browser/pick_ticket_browser_pick_ticket_wizard.html)
: [The Pull Sheet  Wizard]({{site.sp_baseurl}}/sales-docs/ordr-ff/create-a-pull-sheet/wizard/the_pull_sheet_wizard.html)
