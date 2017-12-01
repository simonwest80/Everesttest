---
title: Non-Inventoried Items
---

# Non-inventoried Items


Non-inventoried items are items for which you either do not or cannot  maintain stock.


{:.example}
You may not want to maintain stocks of boxes  of paper clips, and you cannot maintain stock of a service item like shipping  charges.


If you set up an item as a non-inventoried item:

- **Everest**  does not maintain stocks of the item.
- You can enter  the quantity of the item bought or sold.
- **Everest**  computes the purchase cost of the item based on the quantity purchased.



{:.example}
Paper Clips and Shipping are two non-inventoried  items. You buy 10 boxes of paper clips for $10 and another 20 boxes for  $10.50. Shipping charges for each purchase are $3 and $4 respectively.  **Everest** computes the average cost  for paper clips at {(10\*10)+(20\*10.5)}/(10+20) = $10.33, but will not  maintain the stock on hand. In case of Shipping, **Everest**  computes the average cost at $3.50 and the last cost at $4.


Non-inventoried items are created for:

- Items that  are to be tracked for their value without being included in stock.



{:.example}
A network services company does not want to  maintain inventory for the cable wires it uses, but would like to track  the expense on such wires as well as the value of the cables in stock.  The company could create this as a non-inventoried item and associate  an asset account with it.

- Expense items  billed to you by vendors, which you want to record in purchase documents.



{:.example}
Freight charges that you pay to vendors on shipments.

- Services that  you want to bill customers for.



{:.example}
Repair charges, maintenance services etc.


The accounts to be used for these item types are specified in the **Accounts**  tab of the **Item** profile (path:  **Inventory &gt; Items**).


{:.see_also}
See also
: [Inventory Type]({{site.mi_baseurl}}/item-profile-details/inventory-type/inventory_type.html)
