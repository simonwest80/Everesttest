---
title: Best Practices in Modifying Costs on Purchase Documents to Match Vendor Invoices
---

# Best Practices in Modifying Costs on Purchase Documents to Match Vendor  Invoices


It is a best practice to negotiate prices with your vendors  when you create purchase orders and hold them to those prices to minimize  cost adjustments. While this is a best practice, it is not always practical  and there are times when you must adjust costs on your purchase documents  to match the vendor invoices.


Costs can be adjusted in two places: the purchase receipt  or the purchase invoice. You can receive items on either of these documents  depending upon your processes.


It is a best practice to adjust costs on the purchase document  that you use to receive inventory so that the value of your inventory  best represents the prices that you paid.


If you use purchase receipts to receive items and make a  cost adjustment on a purchase receipt, it automatically creates a cost  adjustment document. Since the Purchase Price Variance (PPV) account transactions  on the PR and Cost Adjustment document cancel each other out, there is  no PPV balance. Likewise, if you use the purchase invoice to receive items  and make a cost adjustment on the purchase invoice, the value of your  inventory is adjusted. However, if you adjust the cost on a purchase invoice  that is not used to receive inventory, your adjustment will go to the  PPV account and the value of your inventory will not reflect the prices  that you actually paid.


The following example shows the accounting transactions created  when a cost adjustment is made on a purchase receipt.


**Example: Adjust Cost on the Purchase Receipt**


A purchase order is created for 1 item with a quantity of  10 at a cost of $10/each. The purchase order is then processed into a  purchase receipt and saved. No accounting entries are created for a purchase  order.


The accounting transactions for the saved purchase receipt  are as follows:


| Account | Debit | Credit |
| Inventory Control | $100 |  |
| Accrued Purchases |  | $100 |



A vendor invoice is received showing a purchase price of  $9/each. The purchase receipt is opened, the cost is changed from $10.00  to $9.00 and resaved.


When costs are adjusted on the PR, two sets of transactions  are created:


1. Transactions displayed on the Transaction tab of the Purchase  Receipt.


2. Transactions from the Inventory Adjustment document created.


After the cost adjustment on the PR, you will see the following  transactions on the PR **Transactions**  tab:


| Account | Debit | Credit |
| Inventory Control | $100 |  |
| Accrued Purchases Control |  | $90 |
| Purchase Price Variance |  | $10 |



![]({{site.pp_baseurl}}/img/pr_cost_lowered_transactions_tab_pur.jpg)


**Figure: Cost Adjusted Purchase Receipt – Transactions  Tab**


If you check the Transaction History (**Options**  > **Transaction History** or press  **Ctrl+T**), you will also see that  an inventory adjustment document was created.


![]({{site.pp_baseurl}}/img/transaction_history_pur.jpg)


**Figure: Transaction History**


From the **Everest**  main menu, select **Inventory** >  **Inventory Adjustment** > **Cost** **Adjustment**  to view the cost adjustment document automatically created. A cost adjustment  document is a type of inventory adjustment.


![]({{site.pp_baseurl}}/img/cost_adjustment_document_pur.jpg)


**Figure: Cost Adjustment Document Automatically  Created**


If you check the General Journal for that cost adjustment  document, you will see the following transactions:


| Account | Debit | Credit |
| Purchase Price Variance | $10 |  |
| Inventory Control |  | $10 |



![]({{site.pp_baseurl}}/img/general_journal_transaction_for_cost_adjustment_pur.jpg)


**Figure: General Journal Transaction for the Cost  Adjustment**


The Purchase Price Variance (PPV) Debit of $10 will cancel  out the PPV Credit of $10 shown on the Purchase Receipt Transactions tab.  The Inventory Control Credit of $10 will reduce the Inventory Control  account Debit of $100 to $90.


The **Net Result** of  the cost adjusted Purchase Receipt transactions is:


| Account | Debit | Credit |
| Inventory Control | $90 |  |
| Accrued Purchases |  | $90 |



Since the PPV transactions are a wash (cancel each other  out), there is no PPV balance for the PR transactions. This is because  the cost adjustment was made on the purchase document where the items  were received, in this case the purchase receipt.


**LIMITATIONS:**

- Costs can only  be modified if the purchase document has not been posted.
- Inventory Control  will only be updated for quantities that are still in stock. If you edit  the cost of an item after it has already been sold, the balance of the  adjustment will remain in PPV.



{:.see_also}
See also
: [Modify  a Purchase Receipt]({{site.pp_baseurl}}/purc-proc/prs/modify-a-purchase-receipt/modifying_purchase_receipts.html)
: [Modify  a Purchase Invoice]({{site.pp_baseurl}}/purc-proc/pis/modify-a-purchase-invoice/modifying_purchase_invoices_pur.html)
