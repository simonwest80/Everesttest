---
title: Payment Currency
---

# Payment Currency


The currency in which the payment is made is called the payment currency.


**Pay in**
: This field is used to specify the currency in which you are making the payment. The customer currency is displayed by default in this field.
: If the refund is made through a credit card, and is to be processed in real time using a processor, then the currency is compared to the currencies supported by the processor as specified in the **Processors** profile (path: **File &gt; Setup &gt; Accounting &gt; Processors &gt; Options &gt; Edit &gt; In New Window &gt; Currencies** tab).
: ![]({{site.sp_baseurl}}/img/lens.gif)<font color='black'>  </font>[Processors Profile - Currencies Tab]({{site.sc_chm}}/options/payment-information/credit-card-processing/create-a-processor/the_processors_profile_currencies.html)<font color='black'> </font>
: If the payment processor does not support the payment currency, a message will be displayed stating that currency is not supported by the processor. You will be prompted to select a different payment method. Click **OK** to return to the **Refund** dialog box.


**Exchange Rate**
: The current rate of exchange defined in the **Exchange Rate** profile (path: **File &gt; Setup &gt; Accounting &gt; Multi - Currency &gt; Exchange Rates &gt; Options** > **Edit** > **In New Window**), between payment currency and the base currency is displayed.
: You can change this rate if required. Correspondingly the **Amount** field of the payment currency section also changes.


**Amount**
: The amount in customer's or document currency displayed in the **Amount** field of the **Document Currency** section is automatically displayed. When you change the payment currency, the exchange rate defined in **Exchange Rate** profile is used to arrive at this amount.
: This amount can be edited as required. When you edit this amount, the **Amount** fields of the bank currency, base currency and document currency sections get updated automatically, using the existing exchange rates.


{:.see_also}
See also
: [Exchange Rate Details - Refund Dialog Box]({{site.sp_baseurl}}/misc/exchange_rate_information_refund_dialog_box.html)
