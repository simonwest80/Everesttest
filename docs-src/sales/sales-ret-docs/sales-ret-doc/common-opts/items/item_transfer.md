---
title: Item Transfer
---

# Item Transfer


The **Item Transfer** (path: Sales  Return Document profile > **Options 
 &gt; Item &gt; Item Transfer**) option allows you to transfer serialized  items attached to a sales return document (other than a credit quote)  to another stock area of the same type. You can transfer serial numbers  attached to both positive and negative quantities of items. However, you  can transfer these items only to the same type of stock area to which  they are committed.


![]({{site.sp_baseurl}}/img/example.gif) A  positive quantity committed in a credit order will be in an 'out' type  of stock area. Hence, it can be transferred only to an 'out' type of stock  area.


You can choose to transfer multiple serial numbers attached to an item  from different stock areas to one area at the same time. You can have  both positive and negative quantities of items on a document. Positive  quantities on a credit memo indicate that the item has been returned by  the customer. Negative quantities indicate that the item has been sold.  Positive quantities on a credit order indicate that the item is to be  returned by the customer, while negative quantities indicate that it is  to be sold.


A serial number committed to a positive quantity on a credit order will  be in a 'out' type of stock area, while a serial number attached to a  negative quantity will be in an 'stock' type of area. A serial number  attached to a credit memo will be in an 'stock' type of area. All the  serial numbers selected for transfer from a document must be in the same  type of stock area - either 'stock' or 'out' type. They cannot be from  different types of stock areas.


{:.note}
You cannot transfer non-serialized items.


You can only transfer serialized items that are attached  to currently open credit order/memo using the **Item 
 Transfer** option.


The **Item Transfer** option from  within a sales return document automatically creates a stock transfer  document for that particular transfer. Further, it also updates the inventory  and serial number history for all the items that are transferred.


![]({{site.sp_baseurl}}/img/lens.gif) [Stock  Transfer Details]({{site.wm_chm}}/inv-adj/stk-trans/stock-transfer-details/stock_transfer_details.html)<font style="color: #000000;" color="#000000"> </font>


[Inventory  History]({{site.mi_chm}}/the-items-browser/other-options/inventory_history_item_browser_option.html)


[Serial  Number History]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/cmt-items/enter-cmt-qty/serial_number_history.html)


![]({{site.sp_baseurl}}/img/sales_step_icon.gif)To transfer serialized items attached to a  sales return document, do the following:

- From the Sales  Return Document profile, select **Options 
 &gt; Item &gt; Item Transfer**. You will see the **Serial 
 # Transfer for All Items** browser.
- Select the  serial numbers you want to transfer by selecting the check box next to  it.
- Specify the  stock area to which you want to transfer the item in the **Stock 
 Area** field and click **Transfer**.  Stock can be transferred only to the same stock area types.
- Click **Close** to return to the sales document.



{:.see_also}
See also
: [Item  Information]({{site.sp_baseurl}}/misc/item_information_sales_return_document_content.html)
