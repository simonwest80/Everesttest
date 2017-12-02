---
title: Bank Currency Section - Details
---

# Bank Currency Section - Details


**Bank currency**
: The currency of the bank account selected in the  **General** tab of the **Receipts 
 Journal** profile is displayed.
: ![]({{site.acc_baseurl}}/img/example.gif)  Based  on the example given in the [**Example - Cross Currencies Calculations**]({{site.acc_baseurl}}/misc/example_cross_currency_calculations_receipts.html)  section, JPY is the bank currency.


**Source currency**
: The source currency depends on the **Quote 
 type** specified in the **Currency**  profile (path: **File &gt; Setup &gt; Accounting 
 &gt; Multi - Currency &gt; Currency**). If the rate is expressed  from **foreign to base**, then the  source currency displayed is the bank currency. If the rate is expressed  from **base to foreign**, the base  currency is displayed in this field.
: ![]({{site.acc_baseurl}}/img/example.gif)  Based  on the example given in the [**Example - Cross Currencies Calculations**]({{site.acc_baseurl}}/misc/example_cross_currency_calculations_receipts.html)  section, if JPY is expressed in terms of USD (i.e. the quote type is foreign  to base), JPY is displayed as the source currency.
: If USD is expressed in terms of JPY (i.e.  the quote type is **base to foreign**),  USD is displayed as the source currency.


**Exchange Rate**
: The current rate of exchange between the bank currency  and the base currency defined in the **Exchange 
 Rates** profile (path: **File &gt; 
 Setup &gt; Accounting &gt; Multi - Currency &gt; Exchange Rates &gt; Options 
 &gt; Edit &gt; In New Window**) is displayed. You can change this  rate if required. When you change the rate, the foreign amount of the  bank currency section also correspondingly changes. The transaction amount  for the bank account in the **General**  tab of the **Receipt Journal** profile  also changes.


**Destination currency**
: The destination currency depends on the **Quote 
 type** specified in the **Currency**  profile. If the rate is expressed from **foreign 
 to base**, then the destination currency displayed is the base currency.  If the rate is expressed from **base to 
 foreign**, the bank currency is displayed in this field.
: ![]({{site.acc_baseurl}}/img/example.gif)  Based  on the example given in the [**Example - Cross Currencies Calculations**]({{site.acc_baseurl}}/misc/example_cross_currency_calculations_receipts.html)  section, if JPY is expressed in terms of USD (i.e. the quote type is foreign  to base), JPY is displayed as the destination currency.
: If USD is expressed in terms of JPY (i.e.  the quote type is base to foreign), USD is displayed as the destination  currency.


**Foreign/Base Amount**
: The amount specified in the **General** tab of the **Receipt Journal** profile  in terms of the bank currency is displayed in this field by default. If  the foreign amount in the payment currency or customer currency fields  is changed, this field gets updated automatically.
: You may also see the equivalent of this transaction  in terms of the base currency by clicking on the arrow ![]({{site.acc_baseurl}}/img/act_drop_down_button.gif) beside  the **Foreign Amount** field.


{:.see_also}
See also
: [Bank  Currency Section]({{site.acc_baseurl}}/misc/bank_currency_section_step_by_step_receipt_journal.html)
