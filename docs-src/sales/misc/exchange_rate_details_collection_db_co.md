---
title: Exchange Rate Details
---

# Exchange Rate Details


This section allows you to specify the exchange rates for foreign currency  collections. **Everest** determines  whether the Buy Rate/Sell Rate should be used depending on the setting  in the **Rate for Receipts** field  (path: **File &gt; Setup &gt; Preferences 
 &gt; Defaults &gt; Accounting &gt; Multicurrency &gt; Exchange Rates**).


![]({{site.sp_baseurl}}/img/lens.gif) [Cross  Currency Calculations]({{site.sp_baseurl}}/misc/cross_currency_calculations_sales_rpt_pmts.html)


**Doc Currency**
: The currency in which the document is created is  displayed in this field. This is generally the customer currency. You  cannot edit this field.


**Exchange Rate**
: The current rate of exchange defined in the **Exchange Rate** profile (path: **File 
 &gt; Setup &gt; Accounting &gt; Multicurrency &gt; Exchange Rates &gt; 
 Options** > **Edit** >  **In New Window**), between the document  currency and the base currency is displayed.


**Amount**
: The amount to be collected from the customer is  displayed by default in this field.


**Bank Currency**
: The currency of the bank account selected in the  **Payment Method** field is displayed.  You cannot edit this field.


**Exchange Rate**
: The current rate of exchange between the bank currency  and the base currency defined in the **Exchange 
 Rate** profile (path: **File &gt; 
 Setup &gt; Accounting &gt; Multicurrency &gt; Exchange Rates &gt; Options**  > **Edit** > **In 
 New Window**) is displayed.


**Amount**
: The amount to be collected on the document is displayed  by default in this field. If the **Amount**  in the payment currency is changed, this field gets updated automatically  when you click **OK**.


**Pay In**
: Specify the currency in which the customer makes  the payment. The customer currency is displayed by default in this field.
: If the payment is made through a credit card, and  is to be processed in real time using a processor,  the  currency is compared to the currencies supported by the processor as specified  in the **Processors** profile (path:  **File &gt; Setup &gt; Accounting &gt; 
 Processors &gt; Options &gt; Edit &gt; In New Window &gt; Currencies**  tab).
: ![]({{site.sp_baseurl}}/img/lens.gif)<font style="color: #000000;" color="#000000"> </font>[Processors  Profile - Currencies Tab]({{site.sc_chm}}/options/payment-information/credit-card-processing/create-a-processor/the_processors_profile_currencies.html)
: If the payment processor does support the payment  currency, a message is displayed stating that currency is not supported  by the processor. You are prompted to select a different payment method.  Click **OK** to return to the **Collection** dialog box.


**Exchange Rate**
: The current rate of exchange defined in the **Exchange Rate** profile (path: **File 
 &gt; Setup &gt; Accounting &gt; Multi - Currency &gt; Exchange Rates &gt; 
 Options** > **Edit** >  **In New Window**), between the payment  currency and the base currency is displayed.


**Amount**
: The amount in the customer's or document's currency  displayed in the **Amount** field  of the **Document Currency** section  is automatically displayed in this field. When you change the payment  currency, the exchange rate defined in the **Exchange 
 Rate** profile is used to arrive at this amount.


**Base Currency**
: The currency in which your accounting records are  maintained is displayed in this field. You cannot edit this field.


**Exchange Gain/Loss**
: The field displays **N/A**  because the system does not calculate an exchange rate gain or loss on  order documents.


**Amount**
: The amount of payment in the base currency is displayed  in this field. If the **Amount** in  the payment currency is changed, this field gets updated automatically  when you click **OK**. You cannot  edit this field.


{:.see_also}
See also
: [The  Collection Dialog Box - General]({{site.sp_baseurl}}/sales-ret-docs/cos/co-proc/collections/dlg/the_collection_dialog_box_general_tab_sales.html)
