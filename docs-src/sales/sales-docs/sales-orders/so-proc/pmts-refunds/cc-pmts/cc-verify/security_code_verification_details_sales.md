---
title: Security Code Verification Details
---

# Security Code Verification Details


The **Security Code Verification (CVV2)**  field is enabled if you select the **Supports 
 Security Code Verification (CVV2)** check box in the **Processor**  profile and the **Security** **Code** **Verification****(CVV2)** check box in the **Payment Method** profile.


You can verify the cardholder's card verification value. Based on the  comparison, a response confirms whether the card verification value matches  or not.


By default, the **Security Code Verification 
 (CVV2)** field in the **Card****Verification** dialog box displays  the option selected in the **Security Code 
 Verification (CVV2)** field in the **Payment****Method** dialog box (path: **File &gt; Setup &gt; Accounting &gt; Payment 
 Methods** > **Options** >  **Edit** > **In 
 New Window** > **Credit Card Processing**  tab). You can select another option. The options available in the **Security Code Verification (CVV2)** field  are enumerated below:

- **Do 
 not verify CVV2 Information** - Select this option if you do not  want the message from the processing network to provide the card verification  value result.
- **Prompt 
 if CVV2 does not match** **before 
 processing payment** - Select this option if you want **Everest**  to prompt you when the card verification value does not match. **Everest**  informs you that the card verification value cannot be verified and asks  whether you want to get an authorization for the amount.

: Select **Yes**  to make **** a request to process the  payment. Select **No** to abort to  process.

- **Prompt 
 Always** **before processing payment** - If this option is selected, the message from the processing network  providing the verification result is always displayed.

: Irrespective of whether the card verification value  matches or not, you are prompted with a message asking you whether you  want you get authorization for the amount.

- **Process 
 payment and store CVV2 response** - This option allows you to send  the entire amount of the transaction for authorization and does not prompt  irrespective of whether or not there is a match between the security code  provided and the information at the cardholder's issuing bank. The CVV2  response is merely stored in the transaction history. If you are capturing  the payment later, you can base your decision on the response received  from the processor. This eliminates the requirement for carrying out a  $1 transaction exclusively for verifying CVV2 and thereby helps you reduce  the cost of each transaction.



{:.note}
A $1 transaction is done with the Bank/Issuer of the  credit card for the AVS/CVV2 details to be verified. If there is a mismatch  in CVV2 details, only a dollar is blocked for the customer rather than  the entire amount. If this happens in E-commerce, the customer gets another  chance to re-enter the details and try again. If that transaction passes,  the authorization is carried out for the entire amount.


Before you submit a transaction for authorization with this preference,  **Everest** informs you that the transaction  may be approved in spite of a mismatch and asks if you would like to proceed.


{:.see_also}
See also
: [The  Card Verification Dialog Box]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/pmts-refunds/cc-pmts/cc-verify-dlg/the_card_verification_dialog_box.html)
