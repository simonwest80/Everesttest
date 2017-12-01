---
title: Inventory History Grid
---

# Inventory History Grid


The transaction details for the item are displayed in this grid. Details  pertaining to all purchase receipts and invoices, debit memos, sales invoices,  credit memos, work orders and inventory adjustment documents that contain  the item are displayed in this section. The columns in this grid are:

- **Sequence**-  This column identifies the sequence in which the transactions affecting  the item are recorded.



{:.example}
If two sales invoices were created at the  same date for the item, you can use the natural sequence number to find  out which was created first as the transaction created first will have  a lower natural sequence number.

- **Document 
 and Date** – This column identifies the document number and date  that contains the item.
- **Quantity**  - This column indicates the quantity by which the item's stock increased  or decreased as a result of this transaction. A negative quantity implies  that an item is sold, thereby, reducing the stock. The quantity is in  the measure used in the respective document. In case of inventory adjustment  documents for price protection and cost adjustment, it displays the quantity  for which the adjustment was made.


- UM - This column shows the unit of measure used  in the respective document.
- **Sell 
 Amount** - This is the total sales value of the item, which is the  product of the sale price and the quantity sold.

: Sell Amount = Sell  (price) \* Quantity

- **Sell**  - This column displays the selling price in the measure entered in the  sales document.



{:.note}
The **Sell**  and **Sell Amount** columns display  zero if the transaction was through a purchase receipt or invoice, credit  memo quantity adjustment (add quantity), or when the item is an assembly  item and was built through a work order.

- **Cost**  - The cost displayed depends on the document type.



| **Document** | **Cost Displayed** |
| Purchase Receipt | The cost at which the item was purchased (including  freight distributed and tax). |
| Purchase Invoice | The cost at which the item was purchased (including  freight distributed and tax). |
| Credit Memo | The average cost of the item when it was returned. |
| Sales Invoice | The average cost when the item was sold. |
| Debit Memo | The average cost when the item was returned to the vendor. |
| Cost Adjustment/Price Protection | The new adjusted cost. |
| Quantity Adjustment - Add quantity | The cost at which the item was added to stock. |
| Quantity Adjustment - Write off quantity | The average cost prevailing at time of write off. |
| Work Order (where the item is a Component of the Assembly  Process | The average cost when the work order (in which the item  is a component) is built. |
| Work Order and the item is the Assembled Item | The average cost per unit in the work order. |


- **Cost 
 Amount** - The cost displayed depends on the document type:



| Document | Cost Amount Displayed |
| Purchase Receipt | The cost of purchase (inclusive of freight and taxes). |
| Purchase Invoice | The cost of purchase (inclusive of freight and taxes). |
| Credit Memo | The cost of items returned. |
| Sales Invoice | The cost of goods sold. The cost amount is displayed  as a negative figure since the value of stock is reduced when items are  sold. |
| Debit Memo | The cost of items returned. The cost amount is displayed  as a negative figure since the value of stock is reduced when items are  returned to vendors. |
| Cost Adjustment/Price Protection | The value of adjustments. |
| Quantity Adjustment - Add quantity | The value of quantity added. |
| Quantity Adjustment - Write off quantity | The value of quantity written off. The cost amount is  displayed as a negative figure since the value of stock is reduced when  quantity of an item is written off. |
| Assembled Item | Cost of goods manufactured. |


- **Stock 
 Balance** - The value of stock after the transaction. The stock balance  is computed as the product of the average cost and the total stock AFTER  the current transaction. You can also derive the stock balance by adding  the immediately preceding stock balance and the cost amount. In case of  purchases, the stock value increases by the value of purchase, i.e. Old  stock balance + current cost of purchase is the value of the current stock  balance. In case of sales, old stock balance reduced by the cost of goods  sold is the current stock balance.
- **Average 
 Cost** - This column displays the average cost of the item after  considering the transaction. The average cost is shown in the stock measure.
- **Total 
 Stock** - This column displays the total stock after accounting for  the transaction. The total stock is shown in the stock measure.
- **Document 
 Alias and Description** - The document alias that contains the item  and the document’s system description is displayed in these columns.



If all entries are listed in the sequence of creation (i.e. they are  sorted by the **Natural** column)  the total stock in the previous row added to the quantity in the current  row is equal to the total stock in current row. Thus the inventory history  browser basically functions as a stock ledger for the item.


The following example shows an **Inventory 
 History** where more than one unit of measure is used:


{:.example}
You have the following measures defined for the Cream Soda item:


Stock Measure: Each


Purchase Measure: Crate and Each


Sales Measure: Crate and Each


1 Crate = 10 Each


You make the following purchases:


• PR-1002 – 100 Crates of Cream Soda purchased at $5.


• PR-1004 – 10 units of Cream Soda purchased at $0.6


You sell the following items:


• SI-2301 – 10 Crates of Cream Soda sold at $10.


• SI-2304 – 10 Crates of Cream Soda sold at $1.5.


The **Inventory History** shows  the following information for the Cream Soda item:


| Doc# | Qty/UM | Sell | Sell Amt | Cost | Cost Amt | Qty (stk<br/><br/><br/>measure) | Stock Balance | Average Cost | Total Stock |
| PR-1002 | 100  Crate |  |  | 5 | 500 | 1000 | 500.0 | .50 | 1000 |
| PR-1004 | 10 Each |  |  | 0.6 | 60 | 10 | 560.0 | .55 | 1010 |
| SI-2301 | 10 Crate | 10 | 100 | 5.5 | 55 | -100 | 505.0 | .55 | 910 |
| SI-2305 | 4 Each | 1.5 | 6 | .55 | 2.2 | -4 | 502.8 | .55 | 906 |



{:.see_also}
See also
: [The  Inventory History Browser]({{site.mi_baseurl}}/misc/the_inventory_history_browser.html)
: [Inventory  History]({{site.mi_baseurl}}/the-items-browser/other-options/inventory_history_item_browser_option.html)
