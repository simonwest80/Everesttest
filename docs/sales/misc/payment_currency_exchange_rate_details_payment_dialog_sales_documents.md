---
title: Payment Currency
---

# Payment Currency


The currency in which the payment is made is called the payment currency.


**[]()Pay in**
: This field is used to specify the currency in which  the customer makes the payment. The customer currency is displayed by  default in this field.
: If the payment is made through a credit card, and  is to be processed in real time using a processor, the currency is compared  to the currencies supported by the processor as specified in the **Processors** profile (path: **File 
 &gt; Setup &gt; Accounting &gt; Processors &gt; Options &gt; Edit &gt; 
 In New Window &gt; Currencies** tab).
: ![]({{site.sp_baseurl}}/img/lens.gif)<font style="color: #000000;" color="#000000"> </font>[Processor  profile - Currencies tab]({{site.sc_chm}}/options/payment-information/credit-card-processing/create-a-processor/the_processors_profile_currencies.html)
: If the payment processor does not support the payment  currency, you are prompted to select a different payment method. Click  **OK** to return to the **Receipt**  dialog box.


**Exchange Rate**
: The current rate of exchange defined in the **Exchange Rate** profile (path: **File 
 &gt; Setup &gt; Accounting &gt; Multicurrency &gt; Exchange Rates &gt; 
 Options** > **Edit** >  **In New Window**), between payment  currency and the base currency is displayed.
: You can change this rate; correspondingly, the **Amount** fields of the payment currency  section also changes.


**Amount**
: This field displays the amount in the payment currency.  When you change the payment currency, the exchange rate defined in **Exchange Rate** profile is used to arrive  at this amount.


{:.see_also}
See also
: [Exchange  Rate Details - Payment Dialog Box]({{site.sp_baseurl}}/misc/exchange_rate_details_payment_dialog_box.html)
