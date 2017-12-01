---
title: Back End Processes - Receipt on a Point of Sale Invoice
---

# Back-End Processes - Receipt on a Point of Sale Invoice


The back-end processes when a payment is received against a Point of  Sale (sales invoice) document are:

- The customer's  un-posted amount as seen in the **Customer**'s  profile reduces by the amount of payment. The amount receivable from the  customer reduces. When the receipt journal for the receipt is posted,  the un-posted amount increases and the posted amount reduces with the  amount receivable from the customer staying the same.
- The amount  received on the Point of Sale (sales invoice) document increases.
- If the amount  is paid by applying a credit memo, the customer's balance is reduced by  the amount applied and the amount payable to the customer on the credit  memo reduces by the amount applied.



{:.see_also}
See also
: [Sale]({{site.pos_baseurl}}/pos-trans/create-pos-doc/pos-receipts/proc-cc-pmnts/receiving/verify-dtls/sale-details/sale.html)
: [Processing  Credit Card Payments]({{site.pos_baseurl}}/pos-trans/create-pos-doc/pos-receipts/proc-cc-pmnts/processing_credit_card_payments_pos.html)
