---
title: Card Details
---

# Card Details


**Card Number and Expiration**
: The default card number for the customer that is  specified in the **Customer**'s profile  is displayed in this field. You can enter another card number as required.


{:.note}
If  the customer's card is swiped, the card number, its expiry  date and the cardholder's name appear by default in the **Card 
 Verification** dialog box. If the card is not swiped you must enter  the data manually.
: When you process a credit card payment through a  sales order or sales invoice document, **Everest**  keeps a history of the credit cards used and related information making  it easier for accessing the cards during repeat orders. When you select  the credit card number from the drop-down list in the card number field,  the information pertaining to the expiry  date, the cardholder's name, address and zip code are automatically displayed.
: You can view the cards used by a particular customer  from the **Customer** profile (path:  **Invoicing &gt; Customers &gt; Options 
 &gt; Edit &gt; In New Window** > **Payment 
 Information** tab) by clicking the look up button beside the **Default Credit Card Number** field.


**Card Holder**
: The cardholder's name is displayed in this field  when the card is swiped or if an existing card number is selected. If  you enter the credit card number manually, you have to enter this information  manually.


**[]()CVV2**
: This field allows you to enter the card verification  value that in combination with the credit card number, makes a credit  card unique. The card verification value refers to the last three or four  digits of you card number that appears on the reverse side of your credit  card.
: When you process a credit card payment through a  sales order or sales invoice document, **Everest**  provides additional security by checking for this number.
: This system seeks to ensure the following:

- The customer  possesses a credit card and has it in hand when placing a phone, mail  order, or Internet order.
- The card account  is legitimate. The number is not contained in the magnetic stripe information.

: ![]({{site.sp_baseurl}}/img/lens.gif) [Security  Code Verification Details]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/pmts-refunds/cc-pmts/cc-verify/security_code_verification_details_sales.html)


**Address and Zip**
: These fields display the address and zip for the  credit card. When you process a credit card payment for a customer and  a new card number is entered or the credit card is swiped, the address  of the customer is displayed in this field by default.
: The credit card address is the address specified  in the **Credit Card** profile (path:  **Customer** profile > **Payment 
 Information** tab) or in the **Default 
 Address for AVS**field of the **Documents**  dialog box (path: **File** > **Setup** > **Preferences**  > **Flow Control** > **Documents**  > **Miscellaneous** > **Others** > **Others 
 2** tab). You may modify this address.
: When the payment is processed, the card details  (other than the card verification value) are saved and updated for the  customer.


{:.see_also}
See also
: [Card Verification  Details]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/pmts-refunds/cc-pmts/cc-verify/card_verification_details.html)
