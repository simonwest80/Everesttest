---
title: Sales Order Import Preferences Profile - Payments
---

# Sales Order Import Preferences Profile - Payments


The **Payments** tab allows you  to set pay preference for credit cards and select default payment methods  and payment terms.


Payment Status for Imported Sales Orders


Select an option based on which a credit card payment for sales order  import has to be processed.

- Credit card  authorized for payment
- Paid
- No payment  has been processed



**Default payment method \***
: Specify the default payment method to be applied  to the sales orders if the payment method in **Everest**  does not match the payment method on the order.


{:.warn}
Presently, the sales orders from Yahoo! Stores  do not contain any information regarding Credit Card Verification Values  (CVV2). In order to process the transactions using the **Batch 
 Payment Processing** browser, select a default payment method, which  does not require CVV2 verification or uncheck the **Security 
 Code Verification (CVV2)** option in the selected **Payment 
 Method** profile.


| ![]({{site.utl_baseurl}}/img/lens.gif) | [Default  Payment Method]({{site.utl_baseurl}}/misc/default_payment_method_sales_order_info_order_import_preferences_details_utility_main_content.html)<br/><br/><br/>[Payment  Method Profile]({{site.sc_chm}}/options/payment-information/payment-methods/set-up-a-payment-method/the_payment_method_profile.html) |



**Default payment terms \***
: Specify the default payment terms to be applied  to all imported orders.


{:.note}
Only On Account type of payment terms are  available for selection.
: ![]({{site.utl_baseurl}}/img/lens.gif) [Default  Payment Terms]({{site.utl_baseurl}}/misc/default_payment_term_sales_order_info_order_import_preferences_details_utility_main_content.html)


{:.see_also}
See also
: [Sales  Order Import Preferences Profile]({{site.utl_baseurl}}/db-utils/so-import/set-prefs/prefs-profile/orders_import_preferences_profile_utility_content.html)
