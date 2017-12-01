---
title: Card Details
---

# Card Details


**Card Number and Expiration**
: The default card number specified in the **Customer**'s  profile is displayed in this field.


{:.note}
If the customer's card is swiped, the card number, its  expiry date and the cardholder's name appear by default in the **Card 
 Verification** dialog box. If the card is not swiped using a swipe  machine, you must enter these details manually in the [**Payment Details** dialog box]({{site.pos_baseurl}}/pos-trans/create-pos-doc/pos-receipts/payment-dlg/the_payment_details_dialog_box_pos_receipts.html).


When you process a credit card payment through a Point  of Sale (credit memo) document, **Everest**  keeps a history of the credit cards used and related information making  it easier for accessing the cards during repeated refunds.


The cards used by a particular customer can be viewed  from the **Customer** profile (path:  **Invoicing &gt; Customers &gt; Options 
 &gt; Edit &gt; In New Window**) by clicking the lookup button beside  the **Default Credit Card Number**  field.


**Card Holder**
: The cardholder's name is automatically displayed  when the card is swiped using a swipe machine or if an existing card number  is selected. If you enter the credit card number manually in the **Payment Details** dialog box, you have  to enter this information manually.


**Address and Zip**
: These fields display the billing address for the  credit card. When you process a credit card refund to a customer and a  new card number is entered or the credit card is swiped, then the billing  address of the customer will be displayed in this field by default.
: If a credit card number which already exists is  entered, the address specified in the **Credit 
 Card** profile (path: **Customer**  profile > **Payment Information**  tab) is displayed by default in these fields. If no address is specified  in the **Credit Card** profile, the  billing address of the customer is displayed. This address may be modified.
: When the refund is processed, the card details are  saved and updated for that credit card in **Everest**.


{:.see_also}
See also
: [Card  Verification Details]({{site.pos_baseurl}}/pos-trans/create-pos-doc/pos-refunds/processing/verify-dtls/card_verification_details_pos_refunds.html)
