---
title: Item Transfer
---

# Item Transfer


The **Item Transfer** option allows  you to transfer serialized items attached to a purchase return document  (other than a debit quote) to another stock area of the same type. You  can transfer serial numbers attached to both positive and negative quantities  of items. However, you can transfer these items only to the same type  of stock area to which they are committed.


{:.example}
A positive quantity committed in a debit order  will be in a "stock" type of stock area. Hence, it can be transferred  only to a "stock" type of stock area.


You can choose to transfer multiple serial numbers attached to an item  from different stock areas to one area at the same time. You can have  both positive and negative quantities of items on a document. Positive  quantities on a debit memo indicate that the item has been returned. Negative  quantities indicate that the item has been received. Positive quantities  on a debit order indicate that the item is to be returned, while  negative quantities indicate that it is to be received.


<font color="#000000" class="hcp5">A serial number&nbsp;generated and committed to a 
 positive&nbsp;quantity on a&nbsp;debit order will&nbsp;be in a&nbsp;&quot;stock&quot; 
 type of stock area, while a serial number attached to a negative&nbsp;quantity 
 will be in an&nbsp;&quot;out&quot; type of area. </font><font color="#000000" class="hcp5">A serial number generated on a&nbsp;debit memo&nbsp;will 
 be in an&nbsp;&quot;out&quot; type of area. </font><font color="#000000" class="hcp5">All 
 the serial numbers selected for transfer from a document must be in the 
 same type of stock area - either&nbsp;&quot;stock type&quot;&nbsp;or&nbsp;&quot;out&quot;&nbsp;type.</font>**&nbsp;** <font color="#000000" class="hcp5">They cannot be from different types of stock areas.</font>


{:.note}
You cannot transfer non-serialized items.


You can only transfer serialized items that are attached to the currently  open debit order/memo using the **Item 
 Transfer** option.


If a serialized item attached to a debit memo has been received back  from the vendor, (i.e., it is transferred from an "out" type  to a "stock" type of area), the serial number of that particular  item is still available for transfer between "stock" types of  stock areas from the debit memo.


The **Item Transfer** option from  within a purchase return document automatically creates a stock transfer  document for that particular transfer. Further, it also updates the inventory  history and serial number history for all items that are transferred.


{:.steps}
To transfer serialized items attached to  a purchase return document, do the following:

- From the purchase  document profile, select **Options &gt; 
 Item &gt; Item Transfer**. **** You  will see the see the [**Serial No. Transfer for All Items**]({{site.pp_baseurl}}/misc/serial_no_transfer_for_all_items_browser_purch.html)  browser.
- Select the  serial numbers you want to transfer by clicking on the check box next  to it.
- Specify the  stock area to which you want to transfer the item in the **Stock 
 Area** field and click **Transfer**.
- Click **Close** to return to the purchase document.



{:.see_also}
See also
: [Stock  Transfer]({{site.wm_chm}}/inv-adj/stk-trans/stock-transfer-details/stock_transfer_details.html)
: [Inventory  History]({{site.mi_chm}}/the-items-browser/other-options/inventory_history_item_browser_option.html)
