---
title: Combine Multiple Purchase Orders into a Purchase Receipt
---

# Combine Multiple Purchase Orders into a Purchase Receipt


Everest allows you to combine multiple purchase orders for the same  vendor into a single purchase receipt (path: **Purchase 
 Receipt** profile > **Options**  > **Process** > **Unreceived 
 Orders**). You may only use this option in a new purchase receipt  created directly.


This option opens [The  Unreceived Orders Browser]({{site.pp_baseurl}}/purc-proc/prs/create-pr/convert-multiple-po-to-pr/the_unreceived_orders_browser_pur.html) displaying the line items of the orders  placed with the vendor selected in the purchase receipt. The list only  considers items which are not received or partially received and excludes  drop ship line items. It also excludes items from purchase orders using  a different Accrued Purchases account as the one assigned in the purchase  receipt.


If you did not edit the Accrued Purchases account within a purchase  order, the Unreceived Orders browser will display a blank Accrued Purchases  account, and these items will be available in the browser list. All selected  items with a blank Accrued Purchase account will take the one assigned  in the purchase receipt.


Select the items you want to include in the purchase receipt and click  the OK button. The items now display in the purchase receipt. You may  add more line items directly into the purchase receipt.


When you convert multiple orders into one purchase receipt, information  does not copy into the following tabs of the Purchase Receipt profile:

- History
- Multimedia
- Custom Fields
- Document Tasks
- Document Tracking



You need adequate security rights to create a purchase receipt from  multiple purchase orders.
