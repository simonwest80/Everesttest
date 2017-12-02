---
title: Bin Column in Purchase Documents
---

# Bin Column in Purchase Receipts and Invoices


This column defaults to the Put Away Bin defined in the Item Profile  (path: **Inventory** > **Item 
 profile** > **Replenishment**  tab) for the logged in location. It appears in newly created purchase  receipts and  invoices  and stops displaying after you save the receipt/invoice.


If the Put Away Bin is defined for a line item, the received item moves  to the Put Away Bin and the Assign Quantity dialog box does not appear  (unless you have lot tracked items). If the bin is not defined for a line  item and **the Use default stock bin to 
 receive items when creating a new purchase receipt/invoice** is selected  (path: **Location** profile > **Stock Transfer** tab > **Miscellaneous**  tab), the item moves to the area defined for the logged in location or,  if not defined, to the main location. If the Put Away Bin is not defined  and **Use Default Stock Bin** is not  selected, the Assign Quantity dialog box appears.


You must have appropriate security rights if the selected Put Away Bin  resides in a location other than your logged in location.
