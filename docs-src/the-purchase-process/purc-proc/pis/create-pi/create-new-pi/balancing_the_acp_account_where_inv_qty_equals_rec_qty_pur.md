---
title: Balancing the Accrued Purchases Account where the Invoiced Quantity of a Line Item is Equal to the Received Quantity
---

# Balancing the Accrued Purchases Account where the Invoiced Quantity  of a Line Item is Equal to the Received Quantity


To ensure that the **Accrued Purchases**  (ACP) account is in balance (is zeroed out) when the received quantity  and invoiced quantity are equal for a line item, an **Accrued 
 Purchase (Adjustment)** entry is utilized by the system to offset  any remaining balances when updating the existing purchase journal.


The **Accrued Purchase (Adjustment)**  entry is the amount pertaining to the difference between the ACP amount  of the Invoiced Quantity and ACP amount of the Received Quantity. Accounting  entries are created by the system automatically when necessary to balance  the ACP account. The Accrued Purchase (Adjustment) entry is either debited  or credited depending upon the situation. The **Purchase 
 Price Variance** (PPV) account used in the existing journal is basically  meant to offset the ACP (Adjustment) entry and is also credited/debited  for the difference in ACP between the invoiced quantity and ACP of the  received quantity for each line item.


The formulas for Accrued Purchases are shown below:


**Accrued Purchases (PR or PI - Received 
 Quantity) = [(Quantity * (Item Cost – Discount Value)) + Add-on Cost Amount 
 + Non-Recoverable Tax Amount]**


**Accrued Purchases (PI - Invoiced Quantity) 
 = [(Quantity * (Item Cost – Discount Value)) + Add-on Cost Amount + Non-Recoverable 
 Tax Amount]**


The Accrued Purchase (Adjustment) definition is shown below:


**Accrued Purchase (Adjustment) = [Balance  in the ACP account maintained at each line level of the linked documents]**


{:.example}
The following example cases illustrate how the Accrued Purchases (ACP)  account is balanced. The formulas used to arrive at the balances are shown  along with the accounting entries.


Cases 1- 4 show how the ACP account is balanced with one line item.  Case 5 is a more advanced example that uses two line items, add-on costs,  recoverable tax amounts, and non-recoverable tax amounts to show how the  ACP account is balanced. In all cases, the purchase order (PO) is created  first, the purchase receipt (PR) is created next, and then the purchase  invoice (PI) is created.


Click the following links to view the example cases:

- [Case  1: One Line Item – Full Shipment – No ACP (Adjustment) Entry]({{site.pp_baseurl}}/misc/case_1_bal_acp_account_pur.html)
- [Case  2: Partial Shipments – Costs are the same – No ACP (Adjustment) Entry]({{site.pp_baseurl}}/misc/case_2_bal_acp_account_pur.html)
- [Case  3: Partial Shipments – Item Costs are Different – ACP (Adjustment) Entry  is used]({{site.pp_baseurl}}/misc/case_3_bal_acp_account_pur.html)
- [Case  4: Partial Shipments – Item Costs are the same but Add-on Costs are Different  – ACP (Adjustment) Entry is used]({{site.pp_baseurl}}/misc/case_4_bal_acp_account_put.html)
- [Case  5: Partial Shipments – Costs are Different and Tax Amounts are considered  – ACP (Adjustment) Entry is used]({{site.pp_baseurl}}/misc/case_5_bal_acp_account_pur.html)


{:.see_also}
See also
: [Accounting  Entries - Create a New Purchase Receipt]({{site.pp_baseurl}}/purc-proc/prs/create-pr/create-new-pr/accounting_entries_create_pr.html)
: [Accounting  Entries - Edit a Purchase Receipt]({{site.pp_baseurl}}/purc-proc/prs/modify-a-purchase-receipt/accounting_entries_edit_a_purchase_receipt_pur.html)
: [Accounting  Entries - Create a Purchase Invoice]({{site.pp_baseurl}}/purc-proc/pis/create-pi/create-new-pi/accounting_entries_create_a_purchase_invoice_pur.html)
: [Accounting  Entries - Edit a Purchase Invoice]({{site.pp_baseurl}}/purc-proc/pis/modify-a-purchase-invoice/accounting_entries_edit_a_purchase_invoice_pur.html)
