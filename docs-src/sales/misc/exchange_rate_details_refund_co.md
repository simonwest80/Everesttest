---
title: Exchange Rate Details
---

# Exchange Rate Details


This section allows you to specify the exchange rates for foreign currency  refunds. **Everest** determines whether  the Buy Rate/Sell Rate should be used depending on the setting in the  **Rate for Receipts** field (path:  **File &gt; Setup &gt; Preferences &gt; 
 Defaults &gt; Accounting &gt; Multicurrency &gt; Exchange Rates**).


**Doc Currency**
: The currency in which the document is created is  displayed in this field. This is generally the customer currency. You  cannot edit this field.


**Exchange Rate**
: The current rate of exchange defined in the **Exchange Rate** profile (path: **File 
 &gt; Setup &gt; Accounting &gt; Multicurrency &gt; Exchange Rates &gt; 
 Options** > **New** > **In New Window**), between document currency  and the base currency is displayed.
: You can change this rate; correspondingly, the **Amount** fields of the document currency,  payment currency, bank currency, and base currency sections also change.


**Amount**
: The amount payable on the document is displayed  by default in this field. This amount can be edited as required. When  you edit this amount, the **Amount**  fields of the bank currency, payment currency and base currency sections  get updated automatically, using the existing exchange rates.


**Bank Currency**
: The currency of the bank account selected in the  **Payment Method** field is displayed.  You cannot edit this field.


**Exchange Rate**
: The current rate of exchange between the bank currency  and the base currency defined in the **Exchange 
 Rate** profile (path: **File &gt; 
 Setup &gt; Accounting &gt; Multi - Currency &gt; Exchange Rates &gt; Options 
 &gt; New &gt; In New Window**) is displayed. You can change this  rate if required. When you change the rate, the **Amount**  field of the bank currency section also correspondingly changes.


**Amount**
: The amount payable on the document is displayed  by default in this field. If the **Amount**  in the payment currency or document currency sections is changed, this  field gets updated automatically when you click **OK**.


**Pay in**
: This field is used to specify the currency in which  the customer receives the refund. The customer currency is displayed by  default in this field.


**Exchange Rate**
: The current rate of exchange defined in the **Exchange Rate** profile (path: **File 
 &gt; Setup &gt; Accounting &gt; Multi - Currency &gt; Exchange Rates &gt;** **Options** > **New**  > **In New Window**), between payment  currency and the base currency is displayed.
: You can change this rate; correspondingly, the **Amount** field of the payment currency  section also changes.


**Amount**
: The amount in customer's or document currency displayed  in the **Amount** field of the **Document Currency** section is automatically  displayed in this field. When you change the payment currency, the exchange  rate defined in **Exchange Rate**  profile is used to arrive at this amount.
: This amount can be edited as required. When you  edit this amount, the **Amount** fields  of the bank currency, base currency and document currency sections get  updated automatically when you click **OK**,  using the existing exchange rates.


**Base Currency**
: The currency in which your accounting records are  maintained is displayed in this field. You cannot edit this field.


**Exchange Gain/Loss**
: The field displays **N/A**  because the system does not calculate an exchange rate gain or loss on  order documents.


**Amount**
: The amount of payment in the base currency is displayed  in this field. If the **Amount** in  the payment currency or document currency sections is changed, this field  gets updated automatically when you click **OK**.  You cannot edit this field.


{:.see_also}
See also
: [The Refund Dialog  Box]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/pmts-refunds/refunds-on-so/the_refund_dialog_box.html)
