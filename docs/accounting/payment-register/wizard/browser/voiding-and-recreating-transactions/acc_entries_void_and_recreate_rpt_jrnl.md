---
title: Accounting Entries - Void and Recreate Receipt Transactions
---

# Accounting Entries - Void and Recreate Receipt Transactions


The accounting entries that are created when a receipt/refund transaction  is voided and recreated from the Payment Register are:

- A reversal  entry is created to reverse the debits and credits of the voided transaction.
- A new entry  is created with the same details of the original transaction. If a manual  document was created for a transaction with an entry type 'Miscellaneous  Deposit', then the original document number continues to be used. However,  the payment date and payment reference (in the check details section)  is left blank. If the payment is by check and you want to issue a manual  check for the recreated entry, then you must enter the check number in  the receipt journal for the transaction.



The receipt journal in which the voiding and recreating entries are  made is determined by the following rules:

- The journal  must be an open journal whose accounting period contains the transaction  date of the voided transaction. If the accounting period for the voided  transaction is closed, you have to enter a new transaction date for the  reversal entry.
- The journal  must have the same journal group as the one selected in **Workstation 
 Settings** dialog box (path: **File**  > **Setup** > **Preferences**  > **Workstation Settings** >  **Company Settings** tab > **Journal** **Group**  field) of the user entering the receipt/refund.
- The journal  must have the same location/sub-location as the login location/sub-location  of the user entering the payment/refund.
- The journal  must have the description 'Reversing entries for voiding'.
- The journal  must have the same bank account as the bank account specified for the  payment method.



If such an **open** journal does  not exist, a new receipt journal is created with the description 'Reversing  entries for voiding'. The receipt journal number for the new journal is  taken from the sequence number specified for receipt journals in the login  location or the parent location of the login sub-location.


![]({{site.acc_baseurl}}/img/lens.gif) [Locations  and Sub-Locations]({{site.sc_chm}}/options/locations-and-sub-locations/locations_and_departments.html)


If sequence numbers are not defined for the login location or the parent  location of the login sub-location, the sequence number assigned to the  default location (path: **File &gt; Setup 
 &gt; Preferences &gt; Defaults &gt; Accounting &gt; Miscellaneous** tab **&gt; Default Location** field) is assigned  to the document.


![]({{site.acc_baseurl}}/img/lens.gif) [Default  Location]({{site.sc_chm}}/misc/default_location.html)


{:.see_also}
See also
: [Voiding  and Recreating Transactions - Payment Register]({{site.acc_baseurl}}/payment-register/wizard/browser/voiding-and-recreating-transactions/void_and_recreate_trans_rpt_jrnl.html)
