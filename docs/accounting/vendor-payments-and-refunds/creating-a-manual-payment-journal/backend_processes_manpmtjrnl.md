---
title: Back End Processes - Payment Journals
---

# Back End Processes - Payment Journals


The processes that occur in the back end when a payment journal is created  are:

- If the transaction  is a vendor payment, then the vendor's unposted  amount and net balance reduces. If the transaction is a vendor refund,  then the vendor's unposted  amount and net balance increases.
- If the payment  was against an existing purchase invoice, purchase order or debit memo,  the amount paid on the document gets updated.



**![]({{site.acc_baseurl}}/img/lens.gif) [Back  End Processes for Payments on Purchases]({{site.pp_chm}}/purc-proc/pis/pi-processes/payments/back-end-processes/back_end_processes_pay_pur_rec.html)**

- If the payment  has an entry type 'Miscellaneous Deposit',  then **Everest** creates a manual  purchase order. The document number is prefixed with an "M"  to denote that it is a manual purchase order. The sequence number for  manual purchase orders specified for the login location or the parent  location of the login sub-location is used. The sequence numbers are specified  in the **Location** profile (path:  **File** > **Setup**  > **Accounting** > **Location**/  **Sub-Location**> **Options**  > **Edit** > **In 
 New Window** > **Purchasing** tab  > **Manual Order #** field).



**If sequence numbers are not defined for  the login location or the parent location of the login sub-location, the  sequence number assigned to the default location is assigned to the document.  The default location is specified in the **Accounting** dialog box (path: **File** > **Setup** > **Preferences** > **Defaults** > **Accounting** > **Miscellaneous** tab **** >  **Default Location** field).**


{:.see_also}
See also
: [Creating  a Payment Journal]({{site.acc_baseurl}}/vendor-payments-and-refunds/creating-a-manual-payment-journal/creating_a_manual_payment_journal.html)
