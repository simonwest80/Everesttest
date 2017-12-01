---
title: Item Transfer for All Items
---

# Item Transfer for All Items


You access this browser from the **Options 
 &gt; Item &gt;Item Transfer** menu option from the sales order. The  browser contains two sections. The top section displays all committed  serialized and non-serialized items from the sales order. The bottom section  contains details of the serialized and non-serialized items. For example,  if you select a serialized item in the top section that has a committed  quantity of 5, the bottom section displays five line items – one for each  serial number. This allows you to transfer, for example, only those items  with a specific serial number. After you select items in the top section  of the screen, you can modify the transfer quantity for non serialized  items and manufacturer serial numbers for the serialized items in the  bottom section.


The top section contains the following columns:

- **Select**  – Select the checkboxes in this column to move your selections to the  bottom grid. You can also right-click in the top section and select or  de-select all items. When you move an item to the bottom section of the  screen, the system automatically displays a line item for each quantity  of the item.
- **Sequence 
 #** - Displays the sequence number associated with the line item.
- **Item 
 Code** - Displays the item code for the items that qualify for a  transfer.
- **Item 
 Type** - Displays the symbol that indicates the item type.
- **Item 
 Description** - Displays the description of the items.
- **Transfer 
 Qty** - By default, the system displays the committed quantity value,  but you can override this with a lesser value for non-serialized items.  For serialized items, the transfer quantity column displays the sum of  all selected serial numbers and is not editable. You cannot transfer more  than the committed quantity.
- **Committed 
 Qty** - Displays the actual committed quantity for serialized and  non-serialized items.



The bottom section contains the following columns:

- **Select**  – Select the checkboxes in this column for those items you want to transfer.  Only those items you select here are transferred.
- Item  Code
- Item  Type
- Commit  Qty
- **Transfer 
 Qty** - By default, the system displays the committed quantity value,  but you can override this with a lesser value for non-serialized items.  For serialized items, the transfer quantity column displays the sum of  all selected serial numbers and is not editable. You cannot transfer more  than the committed quantity.
- **Bin 
 Type** - Displays the type of bin in which the items are stored.  You can transfer item to other bins of the same type only. For example,  if your committed quantities are stored in an In bin type, you can transfer  them only to other In bin type locations.
- **From 
 Stock Bin** - Displays the current stock bin location of the items.
- **To 
 Stock Bin** - Select the stock bin to which you want to transfer  the items. The system displays only those bins that are associated with  the sales order location.
- **Lot 
 #** - Displays the lot numbers for lot-tracked items.
- **Serial 
 #** - Displays the serial number associated with the serialized items.
- **Mfg 
 Sl** **#** - Specify the manufacturing  serial number associated with the items you want to transfer.



You can click the **Hide Details**  button to hide the bottom section of the screen.


In addition to the columns, the browser contains the following fields  in the top section of the screen:


**To Stock Bin and Description**
: Use the To Stock Bin field to transfer all selected  items in the bottom grid to one stock bin. For example, if you want to  transfer the items you selected to the same stock bin, you can specify  that bin here instead of selecting the bin for each line item.
: If you selected **To 
 Stock Bin** values at the line item level first and then you select  a stock bin here, the system overrides the value at the line item level.  The system displays a message that allows you to accept or cancel this  action.
: Conversely, if you select a stock bin here, you  can override the value at the line item level before you process the transfer.


When you are through making your selections, click **Transfer**  to transfer the items you selected in the bottom section of the screen.


{:.see_also}
See also
: [Item  Transfer for Sales Orders]({{site.sp_baseurl}}/misc/item_transfer_for_sales_orders_sal.html)
: [Item  Transfer]({{site.sp_baseurl}}/sales-docs/docs-profile/options/items/item_transfer_items_option_sales_contents.html)
