---
title: Receipt Journal for Sales Invoice Receipts
---

# Receipt Journal for Sales Invoice Receipts


Payments and refunds are entered in an 'open' **Receipt****Journal** that fulfills the following  conditions:

- A journal with  the accounting period corresponding to the login date.
- A journal with  the same journal group as the journal group selected in **Workstation 
 Settings** of the user entering the payment/refund.
- A journal with  the same location as the logged in location or sub-location of the user  entering the payment/refund.
- A journal with  the description 'Receipt Journal'.



If no such open journal exists, a new Receipt journal is created. The  Receipt journal number for the new journal is taken from the sequence  numbers specified for Receipt journals in the location of the login location  or sub-location.


![]({{site.sp_baseurl}}/img/lens.gif) [Locations  and Sub-Location]({{site.sc_chm}}/options/locations-and-sub-locations/locations_and_departments.html)


If the location does not have sequence numbers assigned, the sequence  number of the default location is used.


![]({{site.sp_baseurl}}/img/lens.gif) [Default  Location]({{site.sc_chm}}/misc/default_location.html)


The journal and transaction number of the payment entry can be seen  in the **Payment History** browser.


![]({{site.sp_baseurl}}/img/lens.gif) [Payment History]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/pmts-refunds/payment-history/payment_history.html)


{:.see_also}
See also
: [Accounting Entries  - Payments from Customers]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/pmts-refunds/pmts-on-so/rcpt-dlg/accounting_entries.html)
