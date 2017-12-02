---
title: Collection Dialog Box - Exchange Rate Details
---

# Collection Dialog Box - Exchange Rate Details


This section allows you to specify the exchange rates for foreign currency  receipts.


{:.note}
**Everest** determines whether the  Buy Rate/Sell Rate should be used depending on the setting in the **Rate for Payments** field (path: **File &gt; Setup &gt; Preferences &gt; Defaults 
 &gt; Accounting &gt; Multicurrency &gt; Exchange Rates**).


**Doc Currency**
: The currency in which the document is created is  displayed in this field. This is generally the vendor currency. You cannot  edit this field.


**Exchange Rate**
: The current rate of exchange between document currency  and the base currency defined in the **Exchange 
 Rate** profile (path: **File**  > **Setup** > **Accounting** > **Multi-Currency 
 &gt; Exchange Rates** > **Options 
 &gt; Edit &gt; In New Window**), is displayed.
: You can change this rate if required. Correspondingly  the **Amount** fields of the Payment  currency, Bank currency and Base currency sections also change.


**Amount**
: The balance receivable on the document is displayed,  by default, in this field. If you edit this amount, the **Amount**  fields of the Bank currency, Payment currency and Base currency sections  get updated automatically, using the existing exchange rates.


**Bank Currency**
: The currency of the bank account selected in the  **Payment Method** field is displayed.  You cannot edit this field.


**Exchange Rate**
: The current rate of exchange between the bank currency  and the base currency defined in the **Exchange 
 Rate** profile (path: **File &gt; 
 Setup &gt; Accounting &gt; Multi-Currency &gt; Exchange Rates** > **Options &gt; Edit &gt; In New Window**)  is displayed. If you change the rate, the **Amount**  field of the Bank currency section also correspondingly changes.


**Amount**
: The balance amount receivable on the document in  terms of the bank currency is displayed in this field, by default. If  you change the **Amount** field in  the Payment currency or Document currency sections, this field gets updated  automatically when you click **OK**.


**Pay in**
: This field is used to specify the currency in which  you are accepting the payment. The vendor currency is displayed, by default,  in this field.


**Exchange Rate**
: The current rate of exchange between payment currency  and the base currency defined in the **Exchange 
 Rate** profile (path: **File** > **Setup** > **Accounting** > **Multi-Currency** > **Exchange Rates &gt; Options 
 &gt; Edit &gt; In New Window**), is displayed.
: You can change this rate if required. Correspondingly,  the **Amount** field of the Payment  currency section also changes.


**Amount**
: The amount in vendor’s or document currency displayed  in the **Amount** field of the **Document Currency** section is automatically  displayed in this field. When you change the payment currency, the exchange  rate defined in **Exchange Rate**  profile is used to arrive at this amount.
: If you edit this amount, the **Amount** fields of the bank currency, Base currency and Document currency  sections get updated automatically, using the existing exchange rates.


**Base Currency**
: The currency in which your accounting records are  maintained is displayed in this field. You cannot edit this field.


**Exchange Gain/Loss**
: The field displays **N/A**  because the system does not calculate an exchange gain or loss for deposits  received against an order.


**Amount**
: The amount of payment in the base currency is displayed  in this field. If the **Amount** field  in the Payment currency or Document currency sections is changed, this  field gets updated automatically. You cannot edit this field.


{:.see_also}
See also
: [The  Collection Dialog Box]({{site.pp_baseurl}}/return-proc/dos/do-processes/collection-payment/the_collection_dialog_box_pur_ret.html)
