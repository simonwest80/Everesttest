---
title: Address Verification Details
---

# Address Verification Details


The **Address Verification (AVS)** field is enabled if you select the **Supports****Address Verification** **(AVS)**  check box in the **Processor** profile  and the **Address Verification (AVS)** check box in the **Payment Method** profile.


![]({{site.sp_baseurl}}/img/lens.gif) [The  Processor Profile]({{site.sc_chm}}/options/payment-information/credit-card-processing/create-a-processor/the_processors_profile.html)


You can verify the card holder's address as displayed in the card details  with the card holder's address in the database of the issuer of the card.  Based on the comparison, a response confirms whether the address matches  or not. The verification is carried out for the address and zip code match  for addresses in the United States.


When address verification is done, the merchant is charged at a lower  rate for the transactions processed. Address verification often allows  merchants to receive a lower interchange rate on transactions, putting  more money in the merchant's pocket.


{:.note}
Banks  do not decline authorization if there is an address mismatch. This information  is for advice only. Merchants who wish to qualify for low rates with their  banks usually use the address check.


By default, **the Address Verification 
 (AVS)**  field in the **Card** **Verification**  dialog box displays the option selected in the **Address 
 Verification (AVS)**  field in the **Payment** **Method**  dialog box (path: **File &gt; Setup &gt; 
 Accounting &gt; Payment Methods** > **Options**  > **Edit** > **In 
 New Window** > **Credit Card Processing**  tab). You can select another option. The options available in the **Address Verification (AVS)**  field are enumerated below:

- **Do 
 not verify AVS 
 Information** - Select this option if you do not want the message  from the processing network to provide the address verification result.
- **Prompt 
 if address or zip does not match** **before 
 processing payment** - Select this option if you want **Everest**  to prompt you when the address or zip code does not match. **Everest**   informs  you that the address or zip code cannot be verified and asks you to get  an authorization for the amount.

: Select **Yes**  to make **** a request to process the  payment. Select **No** to abort to  process. If the address matches, the amount is automatically processed.

- **Prompt 
 Always** **before processing payment** - If this option is selected, the message from the processing network  providing the verification result is always displayed.

: Irrespective of whether the address matches or not,  you are prompted with a message asking you whether you want to get authorization  for the amount.

- **Prompt 
 if address does not match before processing payment** - Select this  option if you want **Everest** to  prompt you when the address does not match. **Everest**  informs you that the address cannot be verified and asks whether you want  to get an authorization for the amount.

: Select **Yes**  to make **** a request to process the  payment. Select **No** to abort to  process.

- **Prompt 
 if Zip does not match before processing payment** - Select this option  if you want **Everest** to prompt  you when the zip code does not match. **Everest**  informs you that the zip code cannot be verified and asks whether you  want to get an authorization for the amount.

: Select **Yes**  to make **** a request to process the  payment. Select **No** to abort to  process.


{:.note}
Banks do not decline authorization if there is an address  mismatch. This information is for advice only. Merchants who wish to qualify  for low rates with their banks usually use the address check.

- **Process 
 payment and store AVS response** - This option allows you to send  the entire amount of the transaction for authorization and does not prompt  irrespective of whether or not there is a match between the address or  zip code provided and the information at the cardholder's issuing bank.  The AVS response is merely stored in the transaction history. If you are  capturing the payment later, you can base your decision on the response  received from the processor. This eliminates the requirement for carrying  out a $1 transaction exclusively for verifying AVS and thereby helps you  reduce the cost of each transaction.



{:.note}
A $1 transaction is done with the Bank/Issuer of the  credit card for the AVS/CVV2 details to be verified. If there is a mismatch  in AVS details, only a dollar is blocked for the customer rather than  the entire amount. If this happens in E-commerce, the customer gets another  chance to re-enter the details and try again. If that transaction passes,  the authorization is carried out for the entire amount.


Before you submit a transaction for authorization with this preference,  **Everest** informs you that the transaction  may be approved in spite of a mismatch and asks if you would like to proceed.


{:.see_also}
See also
: [The  Card Verification Dialog Box]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/pmts-refunds/cc-pmts/cc-verify-dlg/the_card_verification_dialog_box.html)
