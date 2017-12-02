---
title: Receipt Journal for Credit Order Refunds
---

# Receipt Journal for Credit Order Refunds


The accounting entries for refunds on credit order are entered in a  **Receipt Journal** that fulfills  the following conditions:

- A journal with  the accounting period corresponding to the login date.
- A journal with  the same journal group as the one selected in **Workstation 
 Settings.**
- A journal with  the same location as the logged in location or sub-location.
- A journal with  the description 'Receipt Journal'.
- A journal with  the same bank account as the one specified for the payment method.



If no such **open** journal exists,  a new receipt journal is created. The number for the new journal is taken  from the sequence number specified for **Receipt 
 Journals** in the logged in location or sub-location.


![]({{site.sp_baseurl}}/img/lens.gif) [Locations  and Sub-Location]({{site.sc_chm}}/options/locations-and-sub-locations/locations_and_departments.html)


If the location does not have sequence numbers assigned, the sequence  number of the default location is used.


![]({{site.sp_baseurl}}/img/lens.gif) [Default  Location]({{site.sc_chm}}/misc/default_location.html)


You can see the journal and transaction number of the payment entry  in the [**Payment 
 History** browser]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/pmts-refunds/payment-history/payment_history.html)<font style="color: #000000;" color="#000000">.</font>


{:.see_also}
See also
: [System  Receipts]({{site.acc_chm}}/customer-receipts-and-refunds/system_entries_for_receipts.html)
