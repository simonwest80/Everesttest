---
title: Accounting Entries - Void and Recreate Payment Transactions
---

# Accounting Entries - Void and Recreate Payment Transactions


The payment journal in which the voiding and recreating entries are  made is determined by the following rules:

- The journal  must be 'open' and its accounting period must contain the transaction  date of the voided transaction. If the accounting period for the voided  transaction is closed, you have to enter a new transaction date for the  new entry.
- The journal  must have the same journal group as the one selected in **Workstation 
 Settings** dialog box (path: **File**  > **Setup** > **Preferences**  > **Workstation Settings** >  **Company Settings** tab > **Journal** **Group**  field) of the user entering the payment/refund.
- The journal  must have the same location/sub-location as the login location/sub-location  of the user entering the payment/refund.
- The journal  must have the same bank account as the one specified for the payment method.



If such an **open** journal does  not exist, a new payment journal is created. The payment journal number  for the new journal is taken from the sequence number specified for payment  journals in the login location or the parent location of the sub-location.


![]({{site.acc_baseurl}}/img/lens.gif) [Location  Profile - Accounting Tab]({{site.sc_chm}}/options/locations-and-sub-locations/set-up-locations/location_profile_accounting.html)


If sequence numbers are not defined for the login location or the parent  location of the login sub-location, the sequence number assigned to the  default location (path: **File &gt; Setup 
 &gt; Preferences &gt; Defaults &gt; Accounting &gt; Miscellaneous** tab  >**Default Location** field) is  assigned to the document.


![]({{site.acc_baseurl}}/img/lens.gif) [Default  Location]({{site.sc_chm}}/misc/default_location.html)


{:.see_also}
See also
: [Voiding  and Recreating Payment Transactions]({{site.acc_baseurl}}/payment-register/wizard/browser/voiding-and-recreating-transactions/voiding_and_recreating_transactions_payment_register.html)
