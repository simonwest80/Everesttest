---
title: Exchange Rate
---

# Exchange Rate


The **Exchange** **Rate**  field displays the exchange rate for a foreign currency against your base  currency when a foreign currency sales return document, is created.


**Everest** determines whether the  Buy Rate/Sell Rate should be used depending on the setting in the **Rate for Sales Documents** field (path:  **File &gt; Setup &gt; Preferences &gt; 
 Defaults &gt; Accounting &gt; Multicurrency &gt; Exchange Rates**).


If the exchange rate for the document is different from the current  rate, you can change the rate. (Exchange rates can be entered with up  to six decimals).

1. When you convert a quote to an order or an order  to an invoice, the exchange rate displayed is the rate as per the quote/order.  If the rate has changed on invoice date, you must apply the change.
- You must ensure that the exchange rate for return  document is the same as specified in the sales document. This is to ensure  that the inventory control account or expense account are credited correctly  in the base currency.



![]({{site.sp_baseurl}}/img/example.gif) Your  base currency is US Dollars, the customer's currency is Great Britain  Pounds. You sell 100 units of an item for GBP  10. The exchange rate on the Sales Invoice is 1 GBP  = 1.42 USD.  The Inventory Control Account will be credited with USD  142. If the customer returns 50 units and you create a credit memo with  the rate 1.50, then Inventory Control Account will be debited with USD  75 when it should be debited with USD  71. Hence you must ensure that rate is the same as the rate in the sales  invoice.


If there is a time lag between the creation of an intermediate document  and the final document, the exchange rate could fluctuate. **Everest**  allows you to take care of such situations by setting a preference in  the **Exchange rate used when converting 
 quotes and orders** field in the **Documents**  dialog box (path: **File &gt; Setup 
 &gt; Preferences &gt; Flow Control &gt; Documents &gt; Miscellaneous &gt; 
 Others &gt; Others 2** tab).


The following options are available in this field:

- **Prompt 
 user with the exchange rate available as on date logged in** -If  you select this option, **Everest** prompts  you with the latest exchange rate available on the login date (for the  document currency). Click **Yes**  to replace the exchange rate on the document with the latest exchange  rate. Click **No** to retain the existing  exchange rate on the document.
- **Use 
 the exchange rate on the document being converted** - If you select  this option, the **Exchange Rate** field  defaults to the exchange rate available on the document being processed.
- **Use 
 the exchange rate available as on date logged in** - If you select  this field, the **Exchange Rate**  field defaults to the latest exchange rate available on the login date.



{:.see_also}
See also
: [Exchange  Rates]({{site.sc_chm}}/options/multicurrency/exchange-rates/set-up-exchange-rates/exchange_rates_profile.html)
: [Currency]({{site.sc_chm}}/misc/currency_details.html)
: [Determining  Inventory Control Account for Sales Documents]({{site.sp_baseurl}}/misc/determining_inventory_control_account_for_sales_documents.html)
