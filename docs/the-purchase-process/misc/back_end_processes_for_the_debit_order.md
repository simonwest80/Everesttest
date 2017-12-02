---
title: Back End Processes - Partial Returns
---

# Back End Processes - Partial Returns

- If the quantities debited are lower than the quantities requested, the debit order is assigned the status of ‘backorder’.



![]({{site.pp_baseurl}}/img/lens.gif)[Partial Returns]({{site.pp_baseurl}}/return-proc/dos/do-processes/partial-returns/partial_returns_proc_dm.html)

- If all quantities requested are returned, then the debit order is assigned the status ‘closed’.  To view closed debit orders, you must select the option Shipped Debit Orders in the **Debit** **Order** browser.
- When quantities of an item committed to a debit order are returned, the stock status of the item displays the following changes:


1. **Stock Status for the item** - The quantity **On** **Debit** order for the item reduces by the quantity returned. The total quantity of the item reduces.
- **Stock Status in the committed stock area** - If the quantity returned is a committed quantity, the quantity of item **On** **Debit** in the stock area to which the item has been assigned reduces by the quantity returned. The **Total** **Stock** of the item in the stock area decreases.



{:.see_also}
See also
: [The Stock Status Dialog Box]({{site.mi_chm}}/misc/the_item_stock_status_dialog_box.html)
: [Committing Items to the Order]({{site.pp_baseurl}}/purc-proc/pos/po-processes/cmt-items-po/committing_items_to_the_purchase_order.html)
