---
title: Last Cost Calculation in the Stock Measure
---

# Last Cost Calculation in the Stock Measure


After a purchase, the **Last Cost**  on the **Item** profile **Purchases**  tab is updated in the purchase measure. After that, the **Last 
 Cost** on the **Item** profile  **Inventory** tab is updated in the  stock measure using the conversion factor for the measures.


{:.example}
Stock Measure: PCS


Purchase Measures: Box and Carton


1 Box = 20 PCS


1 Carton = 50 PCS


After you purchase 10 boxes @$30 per box, the **Last 
 Cost** in the **Purchases** tab  updates to $30 for the Box purchase measure. The **Last 
 Cost** in the **Inventory** tab  updates to $1.50 ($30/20).


You decide to also purchase 10 Cartons @$60 per Carton. The **Last 
 Cost** in the **Purchases** tab  updates to $60 for the **Carton**  purchase measure. The **Last Cost**  in the **Inventory** tab updates to  $1.20 ($60/50).


{:.see_also}
See also
: [Ordered,  Committed and Received Columns in Purchase Orders]({{site.pp_baseurl}}/purc-proc/doc-profile/contents/item-info/other-item-details/ordered_committed_and_received_po.html)
: [Ordered and  Received Columns in Purchase Receipts]({{site.pp_baseurl}}/purc-proc/doc-profile/contents/item-info/other-item-details/ordered_and_received_pr.html)
