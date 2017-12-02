---
title: Payment Journal for Collection on Debit Order
---

# Payment Journal for Collection on Debit Order


The accounting entries for collections on a debit order are entered  in an open system **Payment Journal**  that fulfills the following conditions:

- A journal with  the accounting period corresponding to the login date.
- A journal with  the same journal group as the one selected in **Workstation 
 Settings** of the user entering the collection/payment.
- A journal with  the same location as the logged-in location/sub-location of the user entering  the collection/ payment.
- A journal with  the description 'Payment Journal'.
- A journal with  the same bank account as the one specified for the payment method.



If no such **open** journal exists,  a new payment journal is created. The number for the new journal is taken  from the sequence numbers specified for **Payment 
 Journals** in the logged-in location or sub-location.
: ![]({{site.pp_baseurl}}/img/lens.gif) [Locations  and Sub-Locations]({{site.sc_chm}}/options/locations-and-sub-locations/locations_and_departments.html)


If the location does not have sequence numbers assigned, the sequence  number of the default location is used.


![]({{site.pp_baseurl}}/img/lens.gif) [Default  location]({{site.sc_chm}}/misc/default_location.html)


The journal and transaction number of the payment entry can be seen  in the **Payment History** browser.
: ![]({{site.pp_baseurl}}/img/lens.gif) [Payment  History]({{site.pp_baseurl}}/purc-proc/pos/po-processes/payments/payment-history/payment_history_pur.html)


{:.see_also}
See also
: [Accounting  Entries - Collection on Debit Order]({{site.pp_baseurl}}/return-proc/dos/do-processes/collection-payment/accounting_entries_collection_on_debit_order.html)
: [Collections  on a Debit Order]({{site.pp_baseurl}}/return-proc/dos/do-processes/collection-payment/collections_on_a_debit_order.html)
