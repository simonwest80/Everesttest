---
title: Transaction Type
---


**Sale**


Select this option where items are delivered immediately after payment  during sale. When a new payment is processed, the processed amount is  charged against the cardholder's account, and the amount is captured.  The transaction is marked through the financial network for immediate  settlement.


**Authorization**


Select this option if you want to verify the authenticity of the card  and the credit limit on the card without processing the payment. Instead,  the amount is put on hold and the payment from the customer is credited  to your account on a later date after fulfillment of the order. The Authorize  section facilitates pre-authorization of a customer's credit card. For  settling the payment you have to send a prior authorization request with  the approval code from the merchant bank.


**Use Prior Authorization**


Select this option for processing payments on cards which have been  pre-authorized. Upon fulfillment of the order, when the payment becomes  due, the amount for which prior authorization has been obtained must be  processed to capture funds.


When the payment service is IC Verify, select Force Sale to capture  funds on an existing voice authorization or other authorization.


Select Ship (Prior Booking) to capture amounts that have been booked  through prior authorization in case of MO/TO sales.


**Verify AVS/CVV2  only**


Select this option if you only want to verify the address and the card  verification value of the card holder. The payment amount is not processed  when this option is selected.


This option overrides the action of the options **Process 
 payment and store AVS response** and **Process 
 payment and store CVV2 response** selected in the **Payment 
 Method** dialog box (path: **File 
 &gt; Setup &gt; Accounting &gt; Payment Methods &gt; Payment Methods** browser **&gt; Edit &gt; In New Window &gt; Payment 
 Method** profile **&gt; Credit Card 
 Processing** tab **&gt; Fraud Prevention**  section).
