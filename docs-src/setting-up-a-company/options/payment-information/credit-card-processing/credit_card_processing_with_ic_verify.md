---
title: Credit Card Processing with IC Verify
---

# Credit Card Processing with ICVerify


The communication between **Everest**  and the ICVerify payment service is handled in the background by means  of creating **request** and **answer** files.


The process may be detailed as follows:

- The cardholder  presents the card for a purchase. This information is either swiped or  entered into the system.
- The **Everest**  workstation sends the payment information and payment method details to  the **Everest** server.
- The **Everest**  server creates a request file and copies the file to the directory mentioned  in the processor attached to the payment method.
- The ICVerify  server constantly scans this location and obtains the request details.
- Through a modem,  the ICVerify server contacts the ICVerify payment gateway.
- The request  is routed through the payment network and the cardholder’s bank is contacted  for payment approval or address verification.
- If the request  is for payment approval, the cardholder’s bank sends an approval number  to the payment gateway. The approved amount is transferred to your bank  account.
- The ICVerify  payment gateway then communicates the response to the ICVerify software.
- An answer file  is created by the ICVerify software which is picked up by the **Everest**  application server.
- This response  is displayed on the workstation that initiated the request.



{:.note}
**ICVerify will only process payments and refunds  with up to two places of decimal accuracy. Errors might occur in processing  if the process file contains more than two decimal places of accuracy.**


Click [here]({{site.sc_baseurl}}/misc/credit_card_processing_ic_verify.html) for a  diagrammatic representation of this process.


{:.see_also}
See also
: [Setting  up Credit Card Processing]({{site.sc_baseurl}}/options/payment-information/credit-card-processing/setting_up_credit_card_processing.html)
: [Receiving  Credit Card Payments]({{site.sp_chm}}/sales-docs/sales-orders/so-proc/pmts-refunds/cc-pmts/receiving_credit_card_payments.html)
: [Configuration  File for ICVerify]({{site.sc_baseurl}}/options/payment-information/credit-card-processing/ini-file-for-icverify/configuration_file_for_icverify.html)
