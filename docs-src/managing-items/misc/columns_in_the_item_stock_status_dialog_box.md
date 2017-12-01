---
title: Columns in the Item Stock Status Dialog Box
---

# Columns in the Item Stock Status Dialog Box


The columns displayed in the **Item Stock 
 Status** dialog box are detailed below:


| Column | Displays: |
| Item Code | Displays the code of the item. |
| Description | Displays a brief description about the item. |
| Type | Displays the item type as inventoried or non-inventoried. |
| **Total** | The total of all quantities in the stock. |
| **Measure** | The unit of measure (path: **Inventory**  > **Items** > **Options <br/> &gt; New &gt; In New Window** > **Purchase**  tab > **Measure** field) used to  purchase an item.<br/><br/><br/>You can view the stock status column by the purchase  measure or the sales measure. |
| **Available** | The stock available for shipment against new sales after  all items on sales orders and on vendor returns are accounted for.<br/><br/><br/>It is computed by deducting the stock on reserve and  the stock on debit (order) from the total stock.<br/><br/><br/>A negative quantity in this column indicates that you  have accepted more sales orders than what can be fulfilled and stocks  need to be replenished.<br/><br/><br/>Available stock = Total Stock - Stock on reserve - Stock  on debit (order) |
| SO | - All quantities of the  item (whether committed or otherwise) on a sales order<br/>- The standard input  quantity of assembly components on a work order |
| SO Committed | The quantity of the item that has been attached or committed  to a sales order and work orders. |
| PO | - The quantity of that  item on a purchase order<br/>- The quantity to be  built of the assembly item on work order |
| PO Committed | The stock that has been received for inspection or committed  by vendor for supply against purchase orders. This stock is not a part  of the stock available for sale. |
| CO | The quantity of the item that is on a credit order (expected  to be returned by customers). |
| CO Committed | The quantity of the item on credit order that has been  committed to the credit order. |
| **DO** | All quantities of the item (whether committed or otherwise)  on debit order (expected to be returned to the vendor). |
| **DO Committed** | The quantity of the item that is identified and committed  to a debit order to be returned to the vendor. |



{:.see_also}
See also
: [Item  Stock Status]({{site.mi_baseurl}}/the-items-browser/information-available/item_stock_status_item_browser_option.html)
