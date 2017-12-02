---
title: Vendor Currency Section - Details
---

# Vendor Currency Section - Details


**Vendor currency**
: The currency of the vendor (which is also the document  currency) as defined in the **Vendor**  profile (path: **Purchasing &gt; Vendors**  > **Options** > **Edit** > **In New Window** >  **Multicurrency**tab) is displayed.


**Source currency**
: The source currency depends on the **Quote 
 type** specified in the **Currency**  profile (path: **File &gt; Setup &gt; Accounting 
 &gt; Multi - Currency &gt; Currency**). If the rate is expressed  from **foreign to base**, then the  source currency displayed is the vendor currency. If the rate is expressed  from **base to foreign**, the base  currency is displayed in this field.
: ![]({{site.acc_baseurl}}/img/example.gif)  Based  on the example given in the [**Example - Cross Currencies Calculations**]({{site.acc_baseurl}}/misc/example_cross_currency_calculations.html)  section, if GBP is expressed in terms of USD (i.e. the quote type is foreign  to base), GBP is displayed as the source currency.
: If USD is expressed in terms of GBP (i.e.  the quote type is base to foreign), USD is displayed as the source currency.


**Exchange rate**
: The current exchange rate defined in **Exchange 
 Rate** profile (path: **File &gt; 
 Setup &gt; Accounting &gt; Multi - Currency &gt; Exchange Rates**)  between the vendor currency and the base is displayed in this field.
: You can change this rate if required. Correspondingly  the foreign amount of the vendor currency section also changes. The transaction  amount for the journal entry in the **General**  tab of the **Payment Journal** profile  also changes.


**Destination currency**
: The destination currency depends on the **Quote 
 type** specified in the **Currency** profile. If the rate is expressed from **foreign 
 to base**, then the destination currency displayed is the base currency.  If the rate is expressed from **base to 
 foreign**, the vendor currency is displayed in this field.
: ![]({{site.acc_baseurl}}/img/example.gif)  Based  on the example given in the [**Example - Cross Currencies Calculations**]({{site.acc_baseurl}}/misc/example_cross_currency_calculations.html)  section, if GBP is expressed in terms of USD (i.e. the quote type is foreign  to base), GBP is displayed as the destination currency.
: If USD is expressed in terms of GBP (i.e.  the quote type is base to foreign), USD is displayed as the destination  currency.


**Foreign amount**
: The amount in vendor's currency appearing in the  **General** tab of the **Payment 
 Journal** profile is automatically displayed in this field.
: This amount can be edited as required. When you  edit this amount, the **Foreign Amount**  fields of the bank currency and payment currency sections get updated  automatically, using the existing exchange rates. The amounts in the **General** tab of the **Payment 
 Journal** profile also get updated.


{:.see_also}
See also
: [Vendor  Currency Section]({{site.acc_baseurl}}/misc/vendor_currency_section_step_by_step_payment_journal.html)
