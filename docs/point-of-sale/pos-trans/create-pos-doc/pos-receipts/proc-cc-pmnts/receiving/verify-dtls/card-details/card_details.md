---
title: Card Details
---

# Card Details


**Card Number and Expiration**
: The default card number for the customer that is  specified in the **Customer**'s profile  is displayed in this field.


{:.note}
If the customer's card is swiped, the card number, its  expiry date and the cardholder's name appear by default in the **Card 
 Verification** dialog box. If the card is not swiped using a swipe  machine, all these details must be entered manually.
: When you process a credit card payment through a  Point of Sale (sales invoice) document, **Everest**  keeps a history of the credit cards used and related information making  it easier for accessing the cards during repeat orders. When you enter  the card number in the **Payment Details**  dialog box, the information pertaining to the expiry date, the cardholder  name, address and zip code are automatically displayed.
: The cards used by a particular customer can be viewed  from the **Customer** profile (path:  **Invoicing &gt; Customers &gt; Options 
 &gt; Edit &gt; In New Window**) by clicking the look up button beside  the **Default Credit Card Number**  field.


**Card Holder**
: The cardholder's name is automatically displayed  when the card is swiped using a swipe machine or if an existing card number  is selected. If you enter the credit card number manually, you have to  enter this information manually.


**CVV2**
: This field allows you to enter the card verification  value which in combination with the credit card number, makes a credit  card unique. The card verification value refers to the last three or four  numbers that appear on the reverse side of your credit card, right after  your card number.


{:.note}
Verification of the card verification value (CVV2) is  useful only for transactions where the cardholder is not present. In Point  of Sale transactions, the cardholder is physically present; therefore,  it is not necessary to check for the card verification value.


**Address and Zip**
: When you process a credit card payment for a customer  and a new card number is entered or the credit card is swiped, the customer's  default address of AVS is displayed in this field by default.
: The credit card address that appears depends on  the type of address specified in the **Credit 
 Card** profile (path: **Customer**  profile > **Payment Information**  tab) or the type of address specified in the **Default 
 Address for AVS**field of the **Documents**  dialog box (path: **File** > **Setup** > **Preferences**  > **Flow Control** > **Documents**  > **Miscellaneous** > **Others** > **Others 
 2** tab). This address may be modified.
: When the payment is processed, the card details  (other than the card verification value) are saved and updated for the  customer for that credit card in **Everest**.


{:.see_also}
See also
: [Card  Verification Details]({{site.pos_baseurl}}/pos-trans/create-pos-doc/pos-receipts/proc-cc-pmnts/receiving/verify-dtls/card_verification_details_pos.html)
