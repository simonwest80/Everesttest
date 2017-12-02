---
title: Accounting Entries - Void Payment/Refund Transactions
---

# Accounting Entries - Void Payment/Refund Transactions


When a transaction is voided from the payment register a reversal entry,  reversing the debits and credits of the voided transaction is created.


The payment journal in which the entry is made is determined by the  following rules:

- The journal  must be an open journal whose accounting period contains the transaction  date of the voided transaction. If the accounting period for the voided  transaction is closed, you have to enter a new transaction date for the  reversal entry.
- The journal  must have the same journal group as the one selected in **Workstation 
 Settings** dialog box (path: **File**  > **Setup** > **Preferences**  > **Workstation Settings** >  **Company Settings** tab > **Journal** **Group**  field) of the user entering the payment/refund.
- The journal  must have the same location/sub-location as the login location/sub-location  of the user entering the payment/refund.
- The journal  must have the description 'Reversing entries for voiding'.
- The journal  must have the same bank account as that specified for the payment method.



If no such open journal exists, a new payment journal  is created with the description 'Reversing entries for voiding'. The payment  journal number for the new journal is taken from the sequence number specified  for payment journals in the login location or the parent location of the  login sub-location.
: ![]({{site.acc_baseurl}}/img/lens.gif) [Location  Profile - Accounting Tab]({{site.sc_chm}}/options/locations-and-sub-locations/set-up-locations/location_profile_accounting.html)


If sequence numbers are not defined for the login location or the parent  location of the login sub-location, then the sequence number assigned  to the default location (path: **File &gt; 
 Setup &gt; Preferences &gt; Defaults &gt; Accounting &gt; Miscellaneous** tab **&gt; Default Location**  field) is assigned to the document.
: ![]({{site.acc_baseurl}}/img/lens.gif) [Default  Location]({{site.sc_chm}}/misc/default_location.html)


{:.see_also}
See also


[Voiding  Transactions from the Payment Register]({{site.acc_baseurl}}/payment-register/wizard/browser/voiding-transactions-payment-register/voiding_transactions_from_the_payment_register.html)
