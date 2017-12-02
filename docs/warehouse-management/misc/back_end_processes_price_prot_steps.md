---
title: Back End Processes
---

# Back End Processes


Following are the back end processes that take place, when you make  an inventory adjustment for price protection:

- The inventory  value of the item increases, if the adjustment is positive, and reduces,  if the adjustment is negative.
- The average  cost of the item changes. The new average cost is calculated by dividing  the new inventory value by the quantity in stock.
- If  the item is serialized, the cost of the serial numbers attached to the  document is updated with the new cost.
- The  amount payable to the vendor increases, if the adjustment increases inventory  value, and decreases, if the adjustment reduces inventory value.
- A  manual purchase invoice is created, if there is an increase in inventory.  The unposted  amount of the vendor also increases. When the accounting entry for the  transaction is posted, the unposted  amount decreases and posted amount increases.
- A  manual debit memo is created, if there is a reduction in inventory. The  unposted amount  of the vendor also decreases. When the accounting entry for the transaction  is posted, then the unposted  amount increases and posted amount decreases.



![Lens.gif]({{site.wm_baseurl}}/img/lens.gif) [Accounting  Information]({{site.mv_chm}}/vendor-details/accounting-information/accounting_information_vendors_content.html)


{:.see_also}
See also
: [Price Protection]({{site.wm_baseurl}}/inv-adj/price-protection/price_protection_new.html)
