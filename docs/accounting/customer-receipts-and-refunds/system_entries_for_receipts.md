---
title: System Entries for Receipts
---

# System Entries for Receipts


**Everest** does not create system  journals for receipts/refund entries from documents. Accounting entries  for customer receipts and refunds are entered in an open receipt journal  that fulfills the following conditions:

- The journal  should belong to the same accounting period as the login date.
- The journal  should have the same journal group as the one selected in the **Workstation 
 Settings** dialog box (path: **File**  > **Setup** > **Preferences**  > **Workstation** **Settings**) of the user entering the purchase/purchase return.
- The journal  should have the same location/sub-location as the login location/sub-location  of the user entering the payment/refund.
- The journal  should have the description 'Receipts Journal'.
- The journal  must have the same bank account as the bank account specified for the  payment method.



If such an open journal does NOT exist, a new receipt journal is created.


The receipt journal number for the new journal is assigned from the  sequence number specified for receipt journals in the **Location**  profile (path: **File** > **Setup** > **Accounting**  > **Location**/**Sub-Location** > **Options** > **Edit** > **In 
 New Window** > **Accounting**  tab > **Receipt journal #** field)  of the login location or the parent location of the login sub-location.


![]({{site.acc_baseurl}}/img/lens.gif) [Locations  and Sub-Location]({{site.sc_chm}}/options/locations-and-sub-locations/locations_and_departments.html)


If sequence numbers are not defined for the login location or the parent  location of the login sub-location, the sequence number assigned to the  default location is assigned to the document. The default location is  specified in the **Accounting** dialog  box (path: **File &gt; Setup &gt; Preferences 
 &gt; Defaults &gt; Accounting &gt; Miscellaneous** tab **&gt; Default Location** field).


![]({{site.acc_baseurl}}/img/lens.gif) [Default  Location]({{site.sc_chm}}/misc/default_location.html)


Select **Payment History** from  the sales or sales return document to view the details of the receipt  journal in which receipt entries for a document are recorded.


![]({{site.acc_baseurl}}/img/lens.gif) [Payment  History]({{site.sp_chm}}/sales-docs/sales-orders/so-proc/pmts-refunds/payment-history/payment_history.html)
