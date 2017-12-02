---
title: Back End Processes - Convert a Debit Quote to a Debit Order
---

# Back End Processes - Convert a Debit Quote to a Debit Order


When a debit quote is converted to a debit order, the following back  end processes occur:

- The debit quote  is converted to an ‘open’ debit order. It cannot be retrieved as a quote.
- The sequence number  of the debit order is generated automatically by the system.



![]({{site.pp_baseurl}}/img/lens.gif) [Document  Number]({{site.pp_baseurl}}/return-proc/doc-prof/contents/document-information/document_number_pr.html)

- The following changes  occur in the stock status of the item as viewed in the **Item 
 Stock Status** dialog box:



| Column | Stock Increase/Decrease |
| On Debit | Increases by quantity of the item returned. |
| Available Quantity | Decreases by the quantity returned. |



{:.see_also}
See also
: [Debit Orders]({{site.pp_baseurl}}/return-proc/dos/debit_orders.html)
