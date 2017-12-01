---
title: "Case 1: One Line Item - Full Shipment - No ACP (Adjustment) Entry"
---

# Case 1: One Line Item - Full Shipment - No ACP (Adjustment) Entry


In Case 1, there is one line item and a purchase order was created for  10 items at a cost of 10. The Purchase Receipt and Purchase Invoices contain  the same quantity and cost.


The accounting entries are shown at the bottom of the table.

| Purchase Order | Purchase Receipt | Purchase Invoice |
| Qty | Cost | Qty | Cost | Qty | Cost |
| 10 | 10 | 10 | 10 | 10 | 10 |
|  |  |  |  |  |  |
|  | Account | Debit | Credit | Debit | Credit |
|  | INV | 100 |  |  |  |
|  | ACP |  | 100 | 100 |  |
|  | AP |  |  |  | 100 |


Accrued Purchases (PR) = 10 \* 10 = 100


Accrued Purchases (PI) = 10 \* 10 = 100


In this situation, the received quantity (10) is equal to the invoiced  quantity (10) and the Accrued Purchases (ACP) amount is the same for the  received quantity and the invoiced quantity.


**Summary of the ACP Account Entries for Case 1**


| Document | Account | Debit | Credit |
| PR - Received Quantity | ACP |  | 100 |
| PI - Invoiced Quantity | ACP | 100 |  |



The ACP account is in balance and therefore an ACP (Adjustment) entry  is not needed.


{:.see_also}
See also
: [Balancing  the Accrued Purchases Account where the Invoiced Quantity of a Line Item  is Equal to the Received Quantity]({{site.pp_baseurl}}/purc-proc/pis/create-pi/create-new-pi/balancing_the_acp_account_where_inv_qty_equals_rec_qty_pur.html)


