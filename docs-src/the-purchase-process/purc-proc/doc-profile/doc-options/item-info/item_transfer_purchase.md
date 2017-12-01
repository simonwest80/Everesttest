---
title: Item Transfer
---

# Item Transfer


The **Item Transfer** option allows  you to transfer serialized items attached to a purchase document (other  than a purchase quote) to another stock area of the same type.


You can transfer multiple serial numbers attached to an item from different  stock areas to one area at the same time.


You can transfer serial numbers attached to both positive and negative  quantities. However, you can transfer these items only to the same type  of stock area to which they are committed.


{:.example}
A positive quantity committed in a purchase  order is in an "out" type of stock area. Hence, it can be transferred  only to an "out" type of stock area.


{:.note}
- You cannot transfer  non-serialized items.
- You can only transfer  serialized items that are attached to/received on the currently open document  using the **Item Transfer** option.


The **Item Transfer** option from  within a purchase document automatically creates a stock transfer document  and a general journal with the description 'Stock Transfer' for that particular  transfer. Further, it also updates the inventory history and serial number  history for all items that are transferred.


{:.steps}
To transfer serialized items attached to  a purchase document, do the following:

- From the purchase  document profile, select **Options &gt; 
 Item &gt; Item Transfer**. **** You  will see the see the [**Serial No. Transfer for All Items**]({{site.pp_baseurl}}/misc/serial_no_transfer_for_all_items_browser_purch.html)  browser.
- Select the  serial numbers you want to transfer by clicking the check box beside it.
- Specify the  stock area to which you want to transfer the item in the **Stock 
 Area** field and click **Transfer**.
- Click **Close** to return to the purchase document.



{:.see_also}
See also
: [Stock  Transfer]({{site.wm_chm}}/inv-adj/stk-trans/stock-transfer-details/stock_transfer_details.html)
: [Inventory  History]({{site.mi_chm}}/the-items-browser/other-options/inventory_history_item_browser_option.html)
