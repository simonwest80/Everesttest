---
title: "Case 2: Partial Shipments - Costs are the same - No ACP (Adjustment) Entry"
---

# Case 2: Partial Shipments - Costs are the same - No ACP (Adjustment)  Entry


In Case 2, there is one line item and a purchase order was created for  10 items at a cost of 10. Only 7 items were received on the PR and an  additional 3 items were received on the PI. The items were received in  partial shipments at different times.


The accounting entries are shown at the bottom of the table.

| Purchase Order | Purchase Receipt | Purchase Invoice |
| Qty | Cost | Qty | Cost | Rec Qty | Cost | Inv Qty | Cost |
| 10 | 10 | 7 | 10 | 3 | 10 | 10 | 10 |
|  |  |  |  |  |  |  |  |
|  | Account | Debit | Credit | Debit | **Credit** | Debit | Credit |
|  | INV | 70 |  | 30 |  |  |  |
|  | ACP |  | 70 |  | 30 | 100 |  |
|  | AP |  |  |  |  |  | 100 |


Accrued Purchases (PR - Received Quantity) = 7 \* 10 = 70


Accrued Purchases (PI - Received Quantity) = 3 \* 10 = 30


Accrued Purchases (PI - Invoiced Quantity) = 10 \* 10 = 100


In this situation, the received items on the PR and PI (7 + 3) equal  the invoiced items on the PI (10).


**Summary of the ACP Account Entries for Case 2**


| Document | Account | Debit | Credit |
| PR - Received Quantity | ACP |  | 70 |
| PI - Received Quantity | ACP |  | 30 |
| PI - Invoiced Quantity | ACP | 100 |  |



Since the costs did not change, the ACP account is in balance and an  ACP (Adjustment) entry is not needed.


{:.see_also}
See also
: [Balancing  the Accrued Purchases Account where the Invoiced Quantity of a Line Item  is Equal to the Received Quantity]({{site.pp_baseurl}}/purc-proc/pis/create-pi/create-new-pi/balancing_the_acp_account_where_inv_qty_equals_rec_qty_pur.html)
