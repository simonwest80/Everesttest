---
title: Back End Processes - Refund a Point of Sale (Credit Memo)
---

# Back-End Processes - Refund a Point of Sale (Credit Memo)


The following back-end processes occur when a refund is made against  a Point of Sale (credit memo):

- The customer's  unposted amount  as seen in the **Customer** profile  increases by the amount of refund. The amount receivable from the customer  increases. When the receipt journal for the payment is posted, the unposted  amount decreases and the posted amount increases with the amount receivable  from the customer staying the same.
- The amount  paid on the Point of Sale (credit memo) document increases. If the amount  paid is applied to a Point of Sale (sales invoice) document, the paid  amount on these documents increases.
- The total balance  of the Point of Sale (credit memo) document reduces. If the amount paid  is applied to a Point of Sale (sales invoice) document, the balance on  these documents decreases by the amount applied.



{:.see_also}
See also
: [Processing  Credit Card Refunds - Point of Sale]({{site.pos_baseurl}}/pos-trans/create-pos-doc/pos-refunds/processing/processing_credit_card_refunds_point_of_sale.html)
: [Accounting  Entries - Refund a Point of Sale (Credit Memo)]({{site.pos_baseurl}}/pos-trans/create-pos-doc/pos-refunds/processing/verification-dlg/accnt-entries-refund-cm/accounting_entries.html)
