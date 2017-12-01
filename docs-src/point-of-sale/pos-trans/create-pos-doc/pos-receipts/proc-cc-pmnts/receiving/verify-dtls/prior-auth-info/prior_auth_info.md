---
title: Prior Authorization Information
---

# Prior Authorization Information


The **Use Prior Authorization**  option in the **Card Verification**  dialog box is used for processing payments on cards which are pre-authorized.  Upon fulfillment of the order, when the payment becomes due, the amount  for which prior authorization are obtained must be processed to capture  funds. In a Point of Sale scenario, this option is used primarily for  customer layaway transactions, where the customer reserves one or more  items from your store. Usually such customers pay an initial amount as  a guarantee that they will return later and pay for the items.


![]({{site.pos_baseurl}}/img/lens.gif) [Customer Layaways]({{site.pos_baseurl}}/pos-trans/create-pos-doc/customer-layaways/customer_layaways_pos.html)


ICVerify


When the payment service is ICVerify, select **Force 
 Sale** to capture funds on an existing voice authorization or other  authorization. Select **Ship (Prior Booking)**  to capture amounts that are booked through prior authorization in case  of MO/TO sales.


![]({{site.pos_baseurl}}/img/lens.gif) [Credit  Card Processing with ICVerify]({{site.pos_baseurl}}/pos-trans/create-pos-doc/pos-receipts/proc-cc-pmnts/credit_card_processing_with_ic_verify_pos.html)


Payflow  Pro


When the payment service is Payflow  Pro, select **Voice Authorization** to  capture funds on an existing voice authorization or any other authorization.  Select **Delayed Capture** to capture  amounts that are booked through prior authorization in case of MO/TO sales.


![]({{site.pos_baseurl}}/img/lens.gif) [Credit  Card Processing with Payflow  Pro]({{site.pos_baseurl}}/pos-trans/create-pos-doc/pos-receipts/proc-cc-pmnts/credit_card_processing_with_payflow_pro_pos.html)


**Approval Code/PNRef #**
: Enter the approval code, if it is a voice authorization.  In case of existing authorizations, select the approval code.
: In case the payment service is Payflow  Pro and the option selected is **Delayed 
 Capture** select the appropriate PNREF number  (Payment Network Reference Number) in this field.


{:.note}
You can select only one of the options: sale or prior  authorization while processing a payment.


{:.see_also}
See also
: [Processing  Credit Card Payments]({{site.pos_baseurl}}/pos-trans/create-pos-doc/pos-receipts/proc-cc-pmnts/processing_credit_card_payments_pos.html)
