---
title: Determining Inventory Control Account
---

# Determining Inventory Control Account


RULE 1

1. The Inventory Control Account defined in the Posting  Group assigned to the line item is considered first.
- If no Inventory Control Account is defined for  the item, the control account defined for the category to which the line  item belongs is used.
- If the Inventory Control Account is not defined  for either the item or the category, the Inventory Control Account of  the stock area's location from where the item is assigned to the document  is taken into consideration.
- To commit quantity to a sales order the inventory  control account of the stock area from where the item is assigned must  be the same as the inventory control account of the stock area to which  the item is being committed. If the two accounts match, you are allowed  to commit quantity and transfer the stock to the committed stock bin,  else  you  are prompted with a message that you can commit quantity to the sales  order; however the quantity will not be reduced from the current location  and will not move to the committed stock bin at this stage.



The example below illustrates which account is used when the stock is  available in more than one location.


{:.example}
There are 10 units of Item A in Sales Invoice.  The location of the document is USA and the Inventory Control Account  for the location is A300.


The table below shows the stock areas and locations from where the item  is assigned to the sales invoice.


| Stock Area | Location | Quantity | Inventory Control Account |
| Retail | USA | 3 | A300 |
| Warehouse | USA | 4 | A300 |
| Retail | Canada | 3 | A750 |
| Total |  | 10 |  |



Accounting entry when an inventory control account A100 is defined for  Item A


| Account | Quantity | Debit | Credit |
| E0410 – Cost of Goods Sold | 10 | $10,000 |  |
| To A100 – Inventory Account | 10 |  | $10,000 |



Accounting entry when no Posting Group is assigned to the item or category  and the entire quantity is assigned from Retail Stock Area in USA.


| Account | Quantity | Debit | Credit |
| E0410 – Cost of Goods Sold | 10 | $10,000 |  |
| To A300 – Inventory Account | 10 |  | $10,000 |



Accounting entry when no Posting Group is assigned to the item or category  and the quantity is assigned from locations in USA and Canada.


| Account | Quantity | Debit | Credit |
| E0410 – Cost of Goods Sold | 10 | $10,000 |  |
| To A300 – Inventory Account | 7 |  | $7,000 |
| To A750 – Inventory Account | 3 |  | $3,000 |



{:.note}
In the example above the COGS account is based  on the location of the document. Since stock is available in multiple  locations the inventory control account is based on the location from  where the item is retrieved into the document. In this example, seven  units of the item retrieved from stock areas in the USA use the account  A300 whereas, three units retrieved from the stock area in Canada use  the account A750.
