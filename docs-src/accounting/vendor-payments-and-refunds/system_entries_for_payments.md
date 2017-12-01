---
title: System Entries for Payments
---

# System Entries for Payments


**Everest** does not create system  journals for payments/refund entries from documents. Accounting entries  for vendor payments and refunds are entered in an open payment journal  that fulfills the following conditions:

- The journal  should belong to the same accounting period as the login date.
- The journal  should have the same journal group as the one selected in **Works****tation** **Settings**  dialog box (path: **File** > **Setup** > **Preferences**  > **Workstation** **Settings &gt; Company Settings** tab > **Journal 
 Group** field) for the user entering the purchase/ purchase return.
- The journal  should have the same location/sub-location as the login location/sub-location  of the user entering the payment/refund.
- The journal  should have the description 'Payment Journal'. All payments made from  a document are created in a journal with the description 'Payment Journal'.
- The journal  must have the same bank account as the one specified for the payment method.



If such an open journal does not exist, a new payment journal is created.


The payment journal number for the new journal is assigned from the  sequence number specified for payment journals in the **Location**  profile (path: **File** > **Setup** > **Accounting**  > **Location**/**Sub-Location 
 &nbsp;**>  **Options** > **Edit**  > **In New Window** > **Accounting** tab > **Payment 
 journal #** field) of the login location or the parent location of  the login sub-location.


![]({{site.acc_baseurl}}/img/lens.gif) [Locations  and Sub-Location]({{site.sc_chm}}/options/locations-and-sub-locations/locations_and_departments.html)


If sequence numbers are not defined for the login location or the parent  location of the login sub-location, the sequence number assigned to the  default location in the **Accounting** dialog  box (path: **File &gt; Setup &gt; Preferences 
 &gt; Defaults &gt; Accounting &gt; Miscellaneous tab &gt; Default Location**  field) is assigned to the document.


![]({{site.acc_baseurl}}/img/lens.gif) [Default  Location]({{site.sc_chm}}/misc/default_location.html)


Select **Payment History** from  the purchase or purchase return document to view details of the payment  journal in which payment entries for a document are recorded.


![]({{site.acc_baseurl}}/img/lens.gif) [Payment  History]({{site.pp_chm}}/purc-proc/pos/po-processes/payments/payment-history/payment_history_pur.html)


{:.see_also}
See also
: [Accounting  Entries for Payment]({{site.acc_baseurl}}/vendor-payments-and-refunds/creating-a-manual-payment-journal/accounting_entries_pmtjrnl.html)
: [Accounting  Entries for Refund]({{site.acc_baseurl}}/vendor-payments-and-refunds/creating-a-manual-payment-journal/accounting_entries_for_refunds_pmtjrnl.html)
