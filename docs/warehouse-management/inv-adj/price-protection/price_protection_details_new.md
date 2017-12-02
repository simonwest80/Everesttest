---
title: Price Protection Details
---

# Price Protection Details


The following information relates specifically to the **Price 
 Protection** profile (path: **Inventory 
 &gt; Inventory Adjustment &gt; Price Protection &gt; Options &gt; New 
 &gt; In New Window &gt; Price Protection** profile).


Vendor Information


**Vendor Code/Vendor Name**
: The vendor code identifies the vendor who has to  be debited or credited with the inventory adjustment amount. When you  enter the vendor code, the corresponding name is displayed in the **Vendor Name** field.


**Document #**
: Price protection results in an increase or decrease  in Accounts Payable. A manual purchase document is created with the document  number prefixed by ‘M’  for the inventory adjustment amount.
: If the vendor has to be credited for the increase  in purchase cost, then a manual purchase invoice is created. If the vendor  has to be debited for the decrease in purchase cost, then a manual debit  memo is created.


**Current Stock**
: The total quantity of the selected item available  from all the stock areas is displayed in this column.


**Quantity**
: The quantity for price protection is the quantity  of the item for which you make price protection


Currency Information


**Vendor currency**
: The currency of the vendor (which is also the document  currency) as defined in the **Vendor**  profile (path: **Purchasing &gt; Vendors**  > **Options** > **Edit** > **In New Window** >  **Multicurrency**tab) is displayed.


**Source Currency**
: The source currency depends on the **Quote 
 Type** specified in the **Currency**  profile (path: **File &gt; Setup &gt; Accounting 
 &gt; Multi currency &gt; Currency**). If the rate is expressed from  **foreign to base**, then the source  currency displayed is the vendor currency. If the rate is expressed from  **base to foreign**, the base currency  is displayed in this field.


![example.gif]({{site.wm_baseurl}}/img/example.gif) Based  on the example given in the [Cross  Currency Calculations]({{site.acc_chm}}/vendor-payments-and-refunds/foreign-currency-payments/cross_currency_calculations.html) section, if GBP  is expressed in terms of USD  (i.e. the quote type is foreign to base), GBP  is displayed as the source currency.
: If USD  is expressed in terms of GBP  (i.e. the quote type is base to foreign), USD  is displayed as the source currency.


**Exchange Rate**
: The current exchange rate defined in **Exchange 
 Rate** profile (path: **File &gt; 
 Setup &gt; Accounting &gt; Multicurrency &gt; Exchange Rates**) between  the vendor currency and the base is displayed.
: You can change this rate if required. Correspondingly,  the foreign amount of the vendor currency section changes. The transaction  amount for the journal entry in the **General**  tab also changes. **Everest** determines  whether the Buy Rate/Sell Rate should be used depending on the setting  in the **Rate for Purchase Documents**  field (path: **File &gt; Setup &gt; Preferences 
 &gt; Defaults &gt; Accounting &gt; Multicurrency &gt; Exchange Rates**).


**Destination Currency**
: The destination currency depends on the **Quote 
 Type** specified in the **Currency** profile. If the rate is expressed from **foreign 
 to base**, then the destination currency displayed is the base currency.  If the rate is expressed from **base to 
 foreign**, the vendor currency is displayed in this field.


{:.see_also}
See also
: [The Price  Protection Profile]({{site.wm_baseurl}}/inv-adj/price-protection/create-a-price-protection-document/the_price_protection_profile.html)
