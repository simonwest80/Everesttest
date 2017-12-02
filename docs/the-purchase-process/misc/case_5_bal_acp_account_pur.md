---
title: "Case 5: Partial Shipments - Costs are Different and Tax Amounts are considered - ACP (Adjustment) Entry is used"
---

# Case 5: Partial Shipments - Costs are Different and Tax Amounts are  considered - ACP (Adjustment) Entry is used


In Case 5, there are two line items with different inventory control  accounts. The PO is created first, next the PR is created, and then the  PI.


**Purchase Order**


| Item | Cost | Ordered Quantity | Add-on Cost Amount | Recoverable Tax Amount | Non-recoverable Tax Amount |
| 101 FGTips | 10.00 | 10 | 20.00 | 0.00 | 0.00 |
| 102 Wheels | 15.00 | 10 | 0.00 | 0.00 | 0.00 |



Notice that the quantity ordered for each line item is 10.


**Purchase Receipt**


| Item | Cost | Received Quantity | Add-on Cost Amount | Recoverable Tax Amount | Non-recoverable Tax Amount |
| 101 FGTips | 9.00 | 7 | 20.00 | 3.78 | 2.52 |
| 102 Wheels | 15.00 | 7 | 30.00 | 6.30 | 4.20 |



Notice for each line item that while 10 were ordered, only 7 were received.  The cost for 101 FGTips is also less than on the purchase order. The purchase  order shows 10.00 and the purchase receipt shows 9.00.


**Purchase Receipt - Accounting Entries on Received  Quantity**


The table below shows the accounting entries for 7 received items for  both line items.


| Account | Debit | Credit |
| INV - 101 FGTips | 85.52 |  |
| INV - 102 Wheels | 139.20 |  |
| ACP |  | 224.72 |



ACP (PR - Received) 101 FGTips = (  9.00 \* 7) + 20.00 + 2.52 = 85.52


**ACP  (PR - Received) 102 Wheels = (15.00 \* 7) + 30.00 + 4.20 = 139.20**


ACP (Total PR Received) = **224.72**


**Purchase Invoice - Received Amount**


| Item | Cost | Received Quantity | Received Add-on Cost Amount | Recoverable Tax Amount | Non-recoverable Tax Amount |
| 101 FGTips | 10.00 | 3 | 5.00 | 1.80 | 1.20 |
| 102 Wheels | 15.00 | 3 | 5.00 | 2.70 | 1.80 |



For each line item on the purchase invoice, 3 more items were received.  Notice that the cost is now 10 for 101 FGTips.


**Purchase Invoice - Accounting Entries on Received  Quantity**


The table below shows the accounting entries for the remaining 3 items  received for both line items.


| Account | Debit | Credit |
| INV - 101 FGTips | 36.20 |  |
| INV - 102 Wheels | 51.80 |  |
| ACP |  | 88.00 |



ACP (PI - Received) 101 FGTips = (10.00 \* 3) + 5.00 + 1.20 = 36.20


**ACP  (PI - Received) 102 Wheels = (15.00 \* 3) + 5.00 + 1.80 = 51.80**


ACP (Total PI Received) = **88.00**


**Purchase Invoice - Invoiced Amount**


| Item | Cost | Invoiced<br/><br/><br/>Quantity | Invoiced<br/><br/><br/>Add-on Cost Amount | Recoverable Tax Amount | Non-recoverable Tax Amount |
| 101 FGTips | 10.00 | 10 | 25.00 | 6.00 | 4.00 |
| 102 Wheels | 15.00 | 10 | 40.00 | 9.00 | 6.00 |



**Purchase Invoice - Accounting Entries on Invoiced  Quantity**


| Account | Debit | Credit |
| ACP | 325.00 |  |
| R-Tax | 15.00 |  |
| AP |  | 340.00 |
| ACP (Adj) |  | **12.28** |
| PPV | 12.28 |  |



ACP (PI - Invoiced) 101 FGTips = (10.00 \* 10) + 25.00 + 4.00 = 129.00


**ACP  (PI - Invoiced) 102 Wheels = (15.00 \* 10) + 40.00 + 6.00 = 196.00**


ACP (Total PI Invoiced) = **325.00**


**Summary of the ACP and ACP (Adjustment) Account  Entries**


The following table shows a summary of the ACP and ACP (Adjustment)  account entries:


| Document | Account | Debit | Credit |
| PR - Received Quantity | ACP |  | 224.72 |
| PI - Received Quantity | ACP |  | 88.00 |
| PI - Invoiced Quantity | ACP | 325.00 |  |
| ACP (Adj) |  | 12.28 |



The **Accrued Purchase (Adjustment)**  entry is the amount pertaining to the difference between the ACP amount  of the Invoiced Quantity and ACP amount of the Received Quantity. In this  example, the amount invoiced (325.00) is greater than the amount received  (224.72 + 88.00).


Accrued Purchase (Adjustment) = 325 (ACP - Invoiced) - 312.72 (ACP -  Received) = **12.28**


Because of this difference, the balance in the ACP account becomes 12.28  and it should be zero to be balanced. To resolve this, the ACP (Adjustment)  account is automatically credited by the system for 12.28. This entry  is used to bring the ACP account balance to zero. The PPV account is debited  for this amount also since it is the amount used to offset the ACP (Adjustment)  account.


The overall result of the previous accounting entries is as follows:


| Account | Debit | Credit |
| ACP |  |  |
| PPV | 12.28 |  |
| INV | 312.72<br/><br/><br/>(224.72 + 88.00) |  |
| AP |  | 340.00 |
| Recoverable Tax | 15.00 |  |
| EXP |  |  |
|  | 340.00 | 340.00 |



Notice that the ACP account is in balance.


{:.see_also}
See also
: [Balancing  the Accrued Purchases Account where the Invoiced Quantity of a Line Item  is Equal to the Received Quantity]({{site.pp_baseurl}}/purc-proc/pis/create-pi/create-new-pi/balancing_the_acp_account_where_inv_qty_equals_rec_qty_pur.html)
