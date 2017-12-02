---
title: Scanning the Item to Commit Quantities
---

# Scanning the Item to Commit Quantities


Inventoried items can be scanned by Item Code, Model No., Item Alias  or Serial Number from the Sales Orders browser and the Sales Order profile  to commit inventory.


Commit Items from a Sales Order Browser


You can scan an item to commit the quantity by selecting **Options**  > **Commit Inventory** from the  **Sales Orders** browser.


{:.steps}
To commit inventory from the Sales Orders  browser towards a sales order, do the following:

- Select and highlight  a Sales Order from the Sales Order browser (path: **Invoicing**  > **Sales** **Orders**).
- Select **Options**  > **Commit Inventory**. The **Commit Inventory** dialog box opens.
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



**![]({{site.sp_baseurl}}/img/commit_inventory_error_not_required_db_sal.gif)**


**Figure: Incorrect Scan Message**


Click the **History**  button to view the history of all scan attempts/actions. This screen can  be useful for identifying when an invalid barcode was scanned or a mistake  was made. The history will only display while the Commit Inventory dialog  box is open and is not saved after closing.


{:.see_also}
See also
: [Commit Inventory]({{site.sp_baseurl}}/misc/commit_inventory_sal.html)
: [Serialized  Items]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/cmt-items/enter-cmt-qty/ser/serialized_items_entering_committed_quantity.html)
