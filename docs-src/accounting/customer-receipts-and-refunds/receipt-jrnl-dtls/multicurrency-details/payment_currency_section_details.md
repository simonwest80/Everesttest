---
title: Payment Currency Section - Details
---

# Payment Currency Section - Details


**Payment Currency**
: This field is used to specify the currency in which  you are receiving the payment or making the refund. The customer currency  is displayed by default in this field. You can select another currency  from the drop-down list.
: ![]({{site.acc_baseurl}}/img/example.gif)  Based  on the example given in the [**Example - Cross Currencies Calculations**]({{site.acc_baseurl}}/misc/example_cross_currency_calculations_receipts.html)  section, EUR (Euro) will be the payment currency.


**Source currency**
: The source currency depends on the **Quote 
 type** specified in the **Currency**  profile (path: **File &gt; Setup &gt; Accounting 
 &gt; Multi - Currency &gt; Currency**). If the rate is expressed  from **foreign to base**, then the  source currency displayed is the payment currency. If the rate is expressed  from **base to foreign**, the base  currency is displayed in this field.
: ![]({{site.acc_baseurl}}/img/example.gif)  Based  on the example given in the [**Example - Cross Currencies Calculations**]({{site.acc_baseurl}}/misc/example_cross_currency_calculations_receipts.html)  section if EUR is expressed in terms of USD (i.e. the quote type is foreign  to base), EUR is displayed as the source currency.
: If USD is expressed in terms of EUR (i.e.  the quote type is base to foreign), USD is displayed as the source currency.


**Exchange Rate**
: The current rate of exchange defined in the **Exchange Rates** profile (path: **File &gt; Setup &gt; Accounting &gt; Multi 
 - Currency &gt; Exchange Rates &gt; Options &gt; Edit &gt; In New Window**),  between payment currency and the base currency is displayed.
: You can change this rate if required. Correspondingly  the foreign amount of the payment currency, bank currency and customer  currency sections also change. The transaction amounts for the journal  entry in the **General** tab of the  **Receipt Journal** profile also change.


**Destination currency**
: The destination currency depends on the **Quote 
 type** specified in the **Currency** profile. If the rate is expressed from **foreign 
 to base**, then the destination currency displayed is the base currency.  If the rate is expressed from **base to 
 foreign**, the payment currency is displayed in this field.
: ![]({{site.acc_baseurl}}/img/example.gif)  Based  on the example given in the [**Example - Cross Currencies Calculations**]({{site.acc_baseurl}}/misc/example_cross_currency_calculations_receipts.html)  section, if EUR is expressed in terms of USD (i.e. the quote type is foreign  to base), EUR is displayed as the destination currency.
: If USD is expressed in terms of EUR (i.e.  the quote type is base to foreign), USD is displayed as the destination  currency.


**Foreign Amount**
: The amount in customer's currency displayed in the  **General** tab of the **Receipt 
 Journal** profile is automatically displayed in this field. When  you change the payment currency, the exchange rate defined in **Exchange 
 Rate** profile is used to arrive at this amount.
: The foreign amount in the 'Payment Currency'  section can be edited as required. When you edit this amount, the foreign  amount fields of the bank currency and customer currency sections get  updated automatically, using the existing exchange rates. The amounts  in the **General** tab also get updated  automatically.


{:.see_also}
See also
: [Payment  Currency Section]({{site.acc_baseurl}}/misc/payment_currency_section_step_by_step_receipts_journal.html)
