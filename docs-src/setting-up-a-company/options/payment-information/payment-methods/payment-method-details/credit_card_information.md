---
title: Credit Card Information
---
<script type="text/javascript" language="JavaScript1.2" x-save-method="compute-relative" src="{{site.sc_baseurl}}/misc/ehlpdhtm.js"></script><script type="text/javascript" language="JavaScript1.2">
<!-- 
if( typeof( kadovFilePopupInit ) != 'function' ) kadovFilePopupInit = new Function();if( typeof( kadovTextPopupInit ) != 'function' ) kadovTextPopupInit = new Function();
 //-->
</script>
Use this option to verify the validity of the credit card number provided  by various card issuers.

To verify the credit card information through the payment service supported  by **Everest**, select this option.  Otherwise, you must obtain the payment approval from a credit card terminal  not connected to **Everest**.


If you do not select this check box for a service supported by **Everest**, you will have to obtain the  payment approval manually.


{:.note}
Checking this option enables the **Processor** field.

This field is used to associate the credit card processor with the payment  method. Specify the processor to define the payment service that has to  be used to process your credit card payments. Whenever a credit card payment  is received, the payment service is automatically contacted for verification.


If you are using credit card processing, you must set up a payment method  for each credit card type like Master Card or Visa that your payment service  supports.


{:.note}
The payment services supported by **Everest**,  namely ICVerify, PayflowPro and PCCharge, processes credit card payments  only in US dollars. To process payments in other currencies, you must  set up a different payment method. These payments must then be approved  outside **Everest**.
: ![]({{site.sc_baseurl}}/img/lens.gif) [Setting  up credit card processing]({{site.sc_baseurl}}/options/payment-information/credit-card-processing/setting_up_credit_card_processing.html)

This option is used to process transactions in real time when a customer  shops online.

Address Verification Service (AVS) is one of the ways to reduce the  risk of a fraudulent transaction. You can compare the address information  in the **Credit Card** profile in  **Everest** with that held by the  shopper's credit card company. If you select this option, AVS prompts  if there is a mismatch, based on the option that you choose.


The following options are available:

- **Do 
 not verify AVS information** - Select this option if you do want  the address information of the credit card to be verified.
- **Prompt 
 if Address or Zip does not match before processing payment** - Select  this option to be prompted if the address or zip code provided does not  match with the information at the cardholder's issuing bank.
- **Prompt 
 always before processing payment** - Select this option to be prompted  irrespective of whether there is a match between the address or zip code  provided, and the information at the cardholder's issuing bank.
- **Prompt 
 if Address does not match before processing payment** - Select this  option to be prompted if the address provided does not match with the  information at the cardholder's issuing bank.
- **Prompt 
 if Zip does not match** - Select this option to be prompted if the  zip code provided does not match with the information at the cardholder's  issuing bank.



{:.note}
A $1 transaction is done with the Bank/Issuer  of the credit card for the AVS/CVV2 details to be verified. If there is  a mismatch in AVS details, only a dollar is blocked for the customer rather  than the entire amount. If this happens in E-commerce, the customer gets  another chance to re-enter the details and try again. If that transaction  passes, the authorization is carried out for the entire amount.

- **Process 
 payment and store AVS response** - This option allows you to send  the entire amount of the transaction for authorization and does not prompt  irrespective of whether or not there is a match between the address or  zip code provided and the information at the cardholder's issuing bank.  The AVS response is merely stored in the transaction history. If you are  capturing the payment later, you can base your decision on the response  received from the processor. This eliminates the requirement for carrying  out a $1 transaction exclusively for verifying AVS and thereby helps you  reduce the cost of each transaction.



Before you submit a transaction for authorization with this  preference, **Everest** informs you  that the transaction may be approved in spite of a mismatch and asks if  you would like to proceed.


These are default preferences for address verification and can be changed  at the time of receiving payment on a document.
: ![]({{site.sc_baseurl}}/img/lens.gif) [Receiving  Credit Card Payments]({{site.sp_chm}}/sales-docs/sales-orders/so-proc/pmts-refunds/cc-pmts/receiving_credit_card_payments.html)

Using card security codes while processing also reduces the risk of  fraudulent transactions. If you select this option, CVV2 compares the  security code you provide with the code on the credit card and prompts  if there is a mismatch.


{:.note}
For American Express, the code is a four-digit  number that appears on the front of the credit card above the card number.  For Visa and MasterCard,  the code is a three-digit number that appears at the end of the card number  on the back of the credit card.


The following options are available:

- **Do 
 not verify CVV2 information before processing payment** - Select  this option if you do not want the 3 or 4-digit security code on the credit  card verified.
- **Prompt 
 if CVV2 does not match before processing payment** - Select this  option to be prompted if security code provided does not match, with the  information at the cardholder's issuing bank.
- **Prompt 
 always before processing payment** - Select this option to be prompted  irrespective of whether there is a match between the security code provided,  and the information at the cardholder's issuing bank.



{:.note}
A $1 transaction is done with the Bank/Issuer  of the credit card for the AVS/CVV2 details to be verified. If there is  a mismatch in CVV2 details, only a dollar is blocked for the customer  rather than the entire amount. If this happens in E-commerce, the customer  gets another chance to re-enter the details and try again. If that transaction  passes, the authorization is carried out for the entire amount.

- **Process 
 payment and store CVV2 response** - This option allows you to send  the entire amount of the transaction for authorization and does not prompt  irrespective of whether or not there is a match between the security code  provided and the information at the cardholder's issuing bank. The CVV2  response is merely stored in the transaction history. If you are capturing  the payment later, you can base your decision on the response received  from the processor. This eliminates the requirement for carrying out a  $1 transaction exclusively for verifying CVV2 and thereby helps you reduce  the cost of each transaction.



Before you submit a transaction for authorization with this preference,  **Everest** informs you that the transaction  may be approved in spite of a mismatch and asks if you would like to proceed.

# Credit Card Information


**[Verify Card Number](javascript:kadovTextPopup(this)){:id="a1"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a1');
//--></script>**


**[Use Payment Processor](javascript:kadovTextPopup(this)){:id="a2"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a2');
//--></script>**


**[Processor](javascript:kadovTextPopup(this)){:id="a3"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a3');
//--></script>**


**[Use real  time processing for web orders](javascript:kadovTextPopup(this)){:id="a4"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a4');
//--></script>**


Fraud Prevention


Use this section to verify the address or zip, and the security code  number of the credit card for security purposes.


**[]()[Address Verification (AVS)](javascript:kadovTextPopup(this)){:id="a5"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a5');
//--></script>**


**[]()[Security Code Verification (CVV2)](javascript:kadovTextPopup(this)){:id="a6"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a6');
//--></script>**


{:.see_also}
See also
: [**Payment Method** profile - Credit Card  Processing tab]({{site.sc_baseurl}}/options/payment-information/payment-methods/set-up-a-payment-method/payment_method_profile_cc_authorization_tab.html)
