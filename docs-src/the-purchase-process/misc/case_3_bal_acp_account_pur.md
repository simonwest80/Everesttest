---
title: "Case 3: Partial Shipments - Item Costs are Different - ACP (Adjustment) Entry is used"
---

# Case 3: Partial Shipments - Item Costs are Different - ACP (Adjustment)  Entry is used


In Case 3, the cost of the items on the PR is less that on the PO and  PI. This situation creates a balance in the ACP account for the line item  that is offset by the system automatically using an ACP (Adjustment) entry  to the ACP account.


The accounting entries are shown at the bottom of the table.

| Purchase Order | Purchase Receipt | Purchase Invoice |
| Qty | Cost | Qty | Cost | Rec Qty | Cost | Inv Qty | Cost |
| 10 | 10 | 7 | 9 | 3 | 10 | 10 | 10 |
|  |  |  |  |  |  |  |  |
|  | Account | Debit | Credit | Debit | **Credit** | Debit | Credit |
|  | INV | 63 |  | 30 |  |  |  |
|  | ACP |  | 63 |  | 30 | 100 |  |
|  | AP |  |  |  |  |  | 100 |
|  | ACP (Adj) |  |  |  |  |  | 7 |
|  | PPV |  |  |  |  | 7 |  |


Accrued Purchases (PR - Received Quantity) = 7 \* 9 = 63


Accrued  Purchases (PI - Received Quantity) = 3 \* 10 = 30


Accrued Purchases (Total Received) = **93**


Accrued Purchases (PI - Invoiced Quantity) = 10 \* 10 = **100**


Accrued Purchases (Total Invoiced) - Accrued Purchases (Total Received)  = ACP balance maintained at the line level of the linked documents = 100  - 93 = 7


The Accrued Purchases amount invoiced is 100 and the total Accrued Purchases  amount received is 93. This leaves a debit balance in the ACP account  of 7. The system automatically creates an ACP (Adjustment) credit entry  of 7 to zero out the balance in the ACP account.


**Summary of the ACP Account Entries for Case 3**


| Document | Account | Debit | Credit |
| PR - Received Quantity | ACP |  | 63 |
| PI - Received Quantity | ACP |  | 30 |
| PI - Invoiced Quantity | ACP | 100 |  |
| ACP (Adj) |  | 7 |



{:.see_also}
See also
: [Balancing  the Accrued Purchases Account where the Invoiced Quantity of a Line Item  is Equal to the Received Quantity]({{site.pp_baseurl}}/purc-proc/pis/create-pi/create-new-pi/balancing_the_acp_account_where_inv_qty_equals_rec_qty_pur.html)
