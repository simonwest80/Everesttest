---
title: Back End Processes - Creating a Credit Memo from an Order
---

# Back End Processes - Creating a Credit Memo from an Order


The following back-end processes occur when a credit order is converted  to a credit memo:

- If the 'credited'  quantity is less than the 'requested' quantity, the credit order is assigned  the status of 'Backorder'.



![]({{site.sp_baseurl}}/img/lens.gif) [Partial  Returns]({{site.sp_baseurl}}/sales-ret-docs/cos/co-proc/convert-to-a-credit-memo/processing_a_credit_memo.html)

- If the 'requested'  quantity is returned, the credit order is assigned the status 'Closed'.  To view closed credit orders, select **Options 
 &gt; Received Credit Orders** from the **Credit 
 Orders** browser.
- When the 'committed'  quantity is received, the stock status of the item displays the following  changes:


- **Stock 
 Status of the item** – The quantity 'On Credit' for the item reduces  by the quantity received. The total and available quantity of the item  increases.
- **Stock 
 Status in the committed stock area** - If the committed quantity  is returned, the available out, free out and on credit stock of the item  reduces by the quantity returned.
- **Stock 
 Status in the assigned stock area** - The total stock and the free  stock increases by the quantity returned.



{:.see_also}
See also
: [Stock  Status]({{site.sp_baseurl}}/sales-docs/docs-profile/options/items/stock_status_items_option_sales_contents.html)
: [Committing  items on a Credit Order]({{site.sp_baseurl}}/sales-ret-docs/cos/co-proc/cmt-items-to-co/attach-cmt-qty/attaching_committed_quantities_on_credit_order.html)
