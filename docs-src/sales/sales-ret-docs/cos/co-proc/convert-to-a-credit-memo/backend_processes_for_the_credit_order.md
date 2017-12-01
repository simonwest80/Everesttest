---
title: Back End Processes for the Credit Order
---

# Back End Processes for the Credit Order


The following back-end processes occur when a credit order is converted  to a credit memo:

- If the quantities  credited are lesser than the quantities requested, the credit order is  assigned the status of 'Backorder'.



![]({{site.sp_baseurl}}/img/lens.gif) [Partial  Returns]({{site.sp_baseurl}}/sales-ret-docs/cos/co-proc/convert-to-a-credit-memo/processing_a_credit_memo.html)

- If the quantity  displayed in the **Requested** column  is returned, the credit order is assigned the status 'Closed'. To view  closed credit orders, select **Options 
 &gt; Shipped Credit Orders** in the **Credit 
 Orders** browser.
- When the 'committed'  quantities are received, the stock status of the item displays the following  changes:


- **Stock 
 Status of the item** - The quantity **On 
 Credit** for the item reduces by the quantity received. The **Total Stock**, **Available 
 Stock** and **Free Stock** of  the item increases.
- **Stock 
 Status in the committed stock area** - If the quantity returned is  a committed quantity, the **Available Out**,  **Free Out** and **On 
 Credit** stock of the item reduces **** by the quantity returned.
- **Stock 
 Status in the assigned stock area** - The total stock and the free  stock increases by the quantity returned.



{:.see_also}
See also
: [Stock  Status]({{site.sp_baseurl}}/sales-docs/docs-profile/options/items/stock_status_items_option_sales_contents.html)
: [Committing  items to the order]({{site.sp_baseurl}}/sales-ret-docs/cos/co-proc/cmt-items-to-co/attach-cmt-qty/attaching_committed_quantities_on_credit_order.html)
