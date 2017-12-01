---
title: Payment Journal
---

# Payment Journal


Document payments or refunds are entered in a payment journal. Payments  and refunds are entered in an 'open' journal that fulfills the following  conditions:

- A journal whose  accounting period corresponds to the login date.
- A journal with  the same journal group as the one selected in **Workstation 
 Settings** of the user entering the payment/refund.
- A journal with  the same location/sub-location as the login location/sub-location of the  user entering the payment/refund.
- A journal with  the description 'Payment Journal'.
- A journal with  the same bank account as the one specified for the payment method.



If such an open journal does not exist, a new payment journal is created.  The new journal bears the sequence numbers assigned for payment journals  for the logged in location or sub-location.


![]({{site.pp_baseurl}}/img/lens.gif) [Location\Sub-Location]({{site.pp_baseurl}}/purc-proc/doc-profile/contents/document-information/department_purchasing.html)


If such a sequence number is not assigned, the sequence number assigned  to the **Default Location** (path:  **File** > **Setup** > **Preferences** > **Defaults** > **Accounting** > **Miscellaneous**  tab) is used.


{:.see_also}
See also
: [Payment History]({{site.pp_baseurl}}/purc-proc/pos/po-processes/payments/payment-history/payment_history_pur.html)
