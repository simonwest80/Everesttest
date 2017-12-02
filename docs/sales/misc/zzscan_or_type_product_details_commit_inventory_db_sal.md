---
title: Scan or type product details
---

- Scan or enter the  Item Code, Item Alias, Model Number or Serial Number of an item in the  **Scan or type product details** field.
- The quantity field  (**Qty**) defaults to 1. With the  appropriate security right, you can change the quantity for regular items.  Serial numbers always scan as 1 unit and the quantity cannot be changed.
- Click the **Commit** button. The **Save**  button is enabled.
- Click the **Save** button. The committed quantity  in the sales order is increased by the number in the **Qty**  field.
- The system opens  the sales order and increases the committed quantity by the number in  the **Qty** field and saves and locks  the order again at the back end.



When you do not specify whether you are scanning the item  by code, alias, model number or serial number, the system follows the  order you specify in the flow control preferences (path: **File**  > **Setup** > **Flow 
 Control** > **Items** >  **Item Details** tab).


An invalid scan message is indicated both visually and audibly  for the following reasons:

- Item does not exist
- Quantity exceeds  order quantity
- Item is not in the  document list



Click the **History**  button to view the history of all scan attempts/actions. This screen can  be useful for identifying when an invalid barcode was scanned or a mistake  was made. The history will only display while the Commit Inventory dialog  box is open and is not saved after closing.
