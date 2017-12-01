---
title: Accounting Entries - Void Receipt/Refund Transactions
---

# Accounting Entries - Void Receipt/Refund Transactions


When a transaction is voided from the purchase register, a reversal  entry is created to reverse the debits and credits of the voided transaction.


The receipt journal in which the entry is made is determined by the  following rules:

- The journal  must be an open journal whose accounting period contains the transaction  date of the voided transaction. If the accounting period for the voided  transaction is closed, you have to enter a new transaction date for the  reversal entry.
- The journal  must have the same journal group as the one selected in **Workstation 
 Settings** dialog box (path: **File**  > **Setup** > **Preferences**  > **Workstation Settings** >  **Company Settings** tab > **Journal** **Group**  field) of the user entering the payment/refund.
- The journal  must have the same location/sub-location as the login location/sub-location  of the user entering the payment/refund.
- The journal  must have the description 'Reversing entries for voiding'.
- The journal  must have the same bank account as the bank account specified for the  payment method.



If no such open journal exists, a new receipt journal is created with  the description 'Reversing entries for voiding'. The receipt journal number  for the new journal is taken from the sequence number specified for receipt  journals in the login location or the parent location of the login sub-location.


![]({{site.acc_baseurl}}/img/lens.gif) [Locations  and Sub-Locations]({{site.sc_chm}}/options/locations-and-sub-locations/locations_and_departments.html)


If sequence numbers are not defined for the login location or the parent  location of the login sub-location, then the sequence number assigned  to the default location (path: **File &gt; 
 Setup &gt; Preferences &gt; Defaults &gt; Accounting &gt; Miscellaneous** tab **&gt; Default Location**  field) is assigned to the document.


![]({{site.acc_baseurl}}/img/lens.gif) [Default  Location]({{site.sc_chm}}/misc/default_location.html)


{:.see_also}
See also


[Voiding  Transactions from the Payment Register]({{site.acc_baseurl}}/payment-register/wizard/browser/voiding-transactions-payment-register/voiding_receipt_refund_transactions_payment_register.html)
