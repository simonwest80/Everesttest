---
title: Customer Currency Section - Details
---

# Customer Currency Section - Details


**Customer currency**
: The currency of the customer (which is also the  document currency) as defined in the **Customer** profile (path: **Invoicing &gt; 
 Customers** > **Options**  > **Edit** > **In 
 New Window** > **Multicurrency**tab) is displayed.


**Source currency**
: The source currency depends on the **Quote 
 type** specified in the **Currency**  profile (path: **File &gt; Setup &gt; Accounting 
 &gt; Multi - Currency &gt; Currency**). If the rate is expressed  from **foreign to base**, then the  source currency displayed is the customer currency. If the rate is expressed  from **base to foreign**, the base  currency is displayed in this field.


{:.example}
**Based on 
 the example given in the** [**Example - Cross Currencies Calculations**]({{site.acc_baseurl}}/misc/example_cross_currency_calculations_receipts.html) **section, if GBP 
 is expressed in terms of USD (i.e. the quote type is foreign to base), 
 GBP is displayed 
 as the source currency.**


If USD is expressed in terms of GBP  (i.e. the quote type is base to foreign), USD is displayed as the source  currency.


**Exchange rate**
: The current exchange rate defined in **Exchange 
 Rates** profile (path: **File &gt; 
 Setup &gt; Accounting &gt; Multi - Currency &gt; Exchange Rates &gt; Options 
 &gt; Edit &gt; In New Window**) between the customer currency and  the base is displayed.
: You can change this rate if required. Correspondingly  the foreign amount of the customer currency section also changes. The  transaction amount for the journal entry in the **General**  tab of the **Receipt Journal** profile  also changes.


**Destination currency**
: The destination currency depends on the **Quote 
 type** specified in the **Currency** profile. If the rate is expressed from **foreign 
 to base**, then the destination currency displayed is the base currency.  If the rate is expressed from **base to 
 foreign**, the customer currency is displayed in this field.


{:.example}
**B**ased  on the example given in the [**Example - Cross Currencies Calculations**]({{site.acc_baseurl}}/misc/example_cross_currency_calculations_receipts.html)  section, if GBP  is expressed in terms of USD (i.e. the quote type is foreign to base),  GBP is displayed  as the destination currency.


If USD is expressed in terms of GBP  (i.e. the quote type is base to foreign), USD is displayed as the destination  currency.


**Foreign amount**
: The amount in customer's currency appearing in the  **General** tab of the **Receipt 
 Journal** profile is automatically displayed in this field.
: This amount can be edited as required. When you  edit this amount, the **Foreign Amount**  fields of the bank currency and payment currency sections get updated  automatically, using the existing exchange rates. The amounts in the **General** tab of the **Receipt 
 Journal** profile also get updated.


{:.see_also}
See also
: [Customer  Currency Section]({{site.acc_baseurl}}/misc/customer_currency_section_step_by_step_receipt_journal_profile.html)
