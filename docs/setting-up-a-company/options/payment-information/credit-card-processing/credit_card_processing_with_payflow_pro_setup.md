---
title: Credit Card Processing with Payflow Pro
---

# Credit Card Processing with Payflow Pro


Payflow Pro  is a payment service that **Everest**  uses for credit card processing. **Everest**  communicates with the **Payflow 
 Pro** gateway through the Internet using the port specified in the  **Processor** profile.


<font style="color: #000000;" color="#000000">The process may be 
 detailed as follows:</font>

- The cardholder  presents the card for a purchase. This information is either swiped or  entered into the system.
- The **Everest**  workstation sends the payment information and payment method details to  the **Everest** server.
- The **Everest**  application server communicates to the Payflow  Pro payment gateway via the Internet.
- The request  is routed through the payment network and the cardholder’s bank is contacted  for payment approval or address verification.
- If the request  is for payment approval, the cardholder’s bank sends an approval number  to the payment gateway. The approved amount is transferred to your bank  account.
- The Payflow  Pro payment gateway then communicates the response to the **Everest**  application server via the Internet.
- This response  is then displayed on the workstation that initiated the request.



Click [here]({{site.sc_baseurl}}/misc/credit_card_processing_payflow_pro.html) for  a diagrammatic representation of this process.


{:.see_also}
See also
: [Setting  up Credit Card Processing]({{site.sc_baseurl}}/options/payment-information/credit-card-processing/setting_up_credit_card_processing.html)
: [Receiving  Credit Card Payments]({{site.sp_chm}}/sales-docs/sales-orders/so-proc/pmts-refunds/cc-pmts/receiving_credit_card_payments.html)
