---
title: Combine Multiple Purchase Orders or Receipts into a Purchase Invoice
---

# Combine Multiple Purchase Orders or Receipts into a Purchase Invoice


Everest allows you to combine multiple purchase orders or receipts for  the same vendor into a single purchase invoice (path: **Purchase 
 Invoice** profile > **Options**  > **Process** > **Uninvoiced 
 Orders/Receipts**). You may only use this option in a new purchase  invoice created directly.


This option opens [The  Uninvoiced Orders/Receipts Browser]({{site.pp_baseurl}}/misc/the_uninvoiced_orders_receipts_browser_pur.html) displaying the line items of the  orders/receipts for the vendor selected in the purchase invoice. The list  only considers items which are not invoiced or partially invoiced and  excludes drop ship line items. It also excludes items from purchase orders/receipts  using a different Accrued Purchases account as the one assigned in the  purchase invoice.


If you did not edit the Accrued Purchases account within a purchase  order/receipt, the Uninvoiced Orders/Receipts browser will display a blank  Accrued Purchases account, and these items will be available in the browser  list. All selected items with a blank Accrued Purchase account will take  the one assigned in the purchase invoice.


Select the items you want to include in the purchase invoice and click  the OK button. The items now display in the purchase invoice. You may  add more line items directly into the purchase invoice.


All of the receipts must also use the same FOB type. If they do not,  the system prompts that only receipts with FOB type matching the FOB type  of the first


selected record will get converted.


When you convert multiple orders/receipts into one purchase invoice,  information does not copy into the following tabs of the Purchase Invoice  profile:

- History
- Multimedia
- Custom Fields
- Document Tasks
- Document Tracking



You need adequate security rights to create a purchase invoice from  multiple purchase orders/receipts.
