---
title: Item Transfer
---

# Item Transfer


**Important:** The information in  this help file does not pertain to item transfers on sales orders. For  information on the process of transferring items on a sales order, refer  to the following topic:


![]({{site.sp_baseurl}}/img/lens.gif)[Item  Transfer for Sales Orders ]({{site.sp_baseurl}}/misc/item_transfer_for_sales_orders_sal.html)


The **Item Transfer** (path: Sales  Document profile > **Options &gt; Item 
 &gt; Item Transfer**) option allows you to transfer serialized items  attached to a sales document (other than a sales quote) to another stock  area of the same type. You can transfer serial numbers attached to both  positive and negative quantities of items. However, you can transfer these  items only to the same type of stock area to which they are committed.


![]({{site.sp_baseurl}}/img/example.gif) A  positive quantity committed in a sales order and a negative quantity in  a credit order will be in a 'stock' type of stock area. Hence, they can  be transferred only to a 'stock' type of stock area.


You can choose to transfer multiple serial numbers attached to an item  from different stock areas to one area at the same time. You can have  both positive and negative quantities of items on a document. Positive  quantities on a sales invoice indicate that the item has been sold. Negative  quantities indicate that the item has been returned by the customer. Positive  quantities on a sales order indicate that the item is to be sold, while  negative quantities indicate that it is to be returned.


A serial number attached and committed to a positive item on a sales  order is in a 'stock' type of area, while a serial number attached to  a negative quantity is in an 'out' type of area. A serial number attached  to a sales invoice is generally in an 'out' type of stock area. All the  serial numbers selected for transfer from a document must be in the same  type of stock area - either 'stock' or 'out' type. They cannot be from  different types of stock areas.


{:.note}
You cannot transfer non-serialized items.


You can only transfer serialized items that are attached  to currently open sales order/invoice using the **Item 
 Transfer** option.


The **Item Transfer** option from  within a sales document automatically creates a stock transfer document  for that particular transfer. Further, it also updates the inventory and  serial number history for all the items that are transferred.


![]({{site.sp_baseurl}}/img/lens.gif) [Inventory  Adjustment]({{site.wm_chm}}/inv-adj/inventory_adjustments.html)


[Inventory  History]({{site.mi_chm}}/misc/inventory_history_grid.html)


[Serial  Number History]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/cmt-items/enter-cmt-qty/serial_number_history.html)


{:.steps}
To transfer serialized items attached to  a sales document, do the following:

- From the Sales  Document profile, select **Options &gt; 
 Item &gt; Item Transfer**. You will see the [**Serial # Transfer for All Items** browser]({{site.sp_baseurl}}/misc/the_serial_transfer_for_all_items_browser_item_transfer_sales_options.html).
- Select the  serial numbers you want to transfer by selecting the check box next to  it.
- Specify the  stock area to which you want to transfer the item in the **Stock 
 Area** field and click **Transfer**.  Stock can be transferred only to the same stock area types.
- Click **Close** to return to the sales document.



{:.see_also}
See also
: [Item  Information]({{site.sp_baseurl}}/sales-docs/docs-profile/options/items/item_information_items_option_sales_contents.html)
