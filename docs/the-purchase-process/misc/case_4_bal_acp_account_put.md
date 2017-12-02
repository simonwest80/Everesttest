---
title: "Case 4: Partial Shipments - Item Costs are the same but Add-on Costs are Different - ACP (Adjustment) Entry is used"
---

# Case 4: Partial Shipments - Item Costs are the same but Add-on Costs  are Different - ACP (Adjustment) Entry is used


In Case 4, the cost of the items on the PO, PR, and PI are the same  but the Add-on costs are different.


{:.note}
These add-on costs are located in the "Add-on Amount" column of the line item. This is the total add-on cost amount  for the line item (Add-on Cost per unit \* Quantity). It is not the per  unit cost found in the "Add-on Cost" column.


The accounting entries are shown at the bottom of the table.

| Purchase Order | Purchase Receipt | Purchase Invoice |
| Qty | Cost | Add-on Costs | Qty | Cost | Add-on Costs | Rec Qty | Cost | Add-on Costs | Inv Qty | Cost | Add-on Costs |
| 10 | 10 | 2 | 7 | 10 | 3 | 3 | 10 | 4 | 10 | 10 | 3 |
|  |  |  |  |  |  |  |  |  |  |  |  |
|  |  | Act | Dr | Cr |  | Dr | **Cr** |  | Dr | Cr |  |
|  |  | INV | 73 |  |  | 34 |  |  |  |  |  |
|  |  | ACP |  | 73 |  |  | 34 |  | 103 |  |  |
|  |  | AP |  |  |  |  |  |  |  | 103 |  |
|  |  | ACP (Adj) |  |  |  |  |  |  | 4 |  |  |
|  |  | PPV |  |  |  |  |  |  |  | 4 |  |


Accrued Purchases (PR - Received Quantity) = (7 \* 10) + 3 = 73


Accrued  Purchases (PI - Received Quantity) = (3 \* 10) + 4 = 34


Accrued Purchases (Total Received) =  **107**


Accrued Purchases (PI - Invoiced Quantity) = (10 \* 10) + 3 = **103**


Accrued Purchases (Total Invoiced) - Accrued Purchases (Total Received)  = ACP balance maintained at the line level of the linked documents = 103  - 107 = -4


The Accrued Purchases amount invoiced is 103 and the total Accrued Purchases  amount received is 107. This leaves a credit balance in the ACP account  of 4. The system automatically creates an ACP (Adjustment) debit entry  of 4 to zero out the balance in the ACP account.


**Summary of the ACP Account Entries for Case 4**


| Document | Account | Debit | Credit |
| PR - Received Quantity | ACP |  | 73 |
| PI - Received Quantity | ACP |  | 34 |
| PI - Invoiced Quantity | ACP | 103 |  |
| ACP (Adj) | 4 |  |



Notice that the accounting transactions in the purchase invoice show  a debit of $69 ($103 - $34) which reflects both the received and invoiced  quantities.


{:.see_also}
See also
: [Balancing  the Accrued Purchases Account where the Invoiced Quantity of a Line Item  is Equal to the Received Quantity]({{site.pp_baseurl}}/purc-proc/pis/create-pi/create-new-pi/balancing_the_acp_account_where_inv_qty_equals_rec_qty_pur.html)
