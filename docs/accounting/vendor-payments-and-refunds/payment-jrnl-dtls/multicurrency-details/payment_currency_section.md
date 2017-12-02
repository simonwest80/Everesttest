---
title: Payment Currency Section - Details
---

# Payment Currency Section - Details


**Payment Currency**
: This field is used to specify the currency in which  you are making the payment. The vendor currency is displayed by default  in this field. You can select another currency from the drop-down list.
: ![]({{site.acc_baseurl}}/img/example.gif)  Based  on the example given in the [**Example - Cross Currencies Calculations**]({{site.acc_baseurl}}/misc/example_cross_currency_calculations.html)  section, EUR (Euro) will be the payment currency.


**Source currency**
: The source currency depends on the **Quote 
 type** specified in the **Currency**  profile (path: **File &gt; Setup &gt; Accounting 
 &gt; Multi - Currency &gt; Currency**). If the rate is expressed  from **foreign to base**, then the  source currency displayed is the payment currency. If the rate is expressed  from **base to foreign**, the base  currency is displayed in this field.
: ![]({{site.acc_baseurl}}/img/example.gif)  Based  on the example given in the [**Example - Cross Currencies Calculations**]({{site.acc_baseurl}}/misc/example_cross_currency_calculations.html)  section if EUR is expressed in terms of USD (i.e. the quote type is foreign  to base), EUR is displayed as the source currency.
: If USD is expressed in terms of EUR (i.e.  the quote type is base to foreign), USD is displayed as the source currency.


**Exchange Rate**
: The current rate of exchange defined, in the **Exchange Rate** profile (path: **File 
 &gt; Setup &gt; Accounting &gt; Multi - Currency &gt; Exchange Rates**),  between payment currency and the base currency, is displayed in this field.
: You can change this rate if required. Correspondingly  the foreign amount of the payment currency, bank currency and vendor currency  sections also change. The transaction amounts for the journal entry in  the **General** tab of the **Payment 
 Journal** profile also change.


**Destination currency**
: The destination currency depends on the **Quote 
 type** specified in the **Currency** profile. If the rate is expressed from **foreign 
 to base**, then the destination currency displayed is the base currency.  If the rate is expressed from **base to 
 foreign**, the payment currency is displayed in this field.
: ![]({{site.acc_baseurl}}/img/example.gif)  Based  on the example given in the [**Example - Cross Currencies Calculations**]({{site.acc_baseurl}}/misc/example_cross_currency_calculations.html)  section, if EUR is expressed in terms of USD (i.e. the quote type is foreign  to base), EUR is displayed as the destination currency.
: If USD is expressed in terms of EUR (i.e.  the quote type is base to foreign), USD is displayed as the destination  currency.


**Foreign Amount**
: The amount in vendor's currency, displayed in the  **General** tab of the **Payment 
 Journal** profile, is automatically displayed in this field. When  you change the payment currency, the exchange rate defined in **Exchange 
 Rate** profile is used to arrive at this amount.
: The foreign amount in the 'Payment Currency'  section can be edited as required. When you edit this amount, the foreign  amount fields of the 'Bank Currency'  and 'Vendor Currency'  sections get updated automatically, using the existing exchange rates.  The amounts in the **General** tab  also get updated.


{:.see_also}
See also
: [Payment  Currency Section]({{site.acc_baseurl}}/misc/payment_currency_section_step_by_step_payment_journal.html)
