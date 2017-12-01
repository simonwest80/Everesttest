---
title: Exchange Rate
---

# Exchange Rate


The **Exchange** **Rate**  field allows you to specify the exchange rate between your base currency  and the vendor currency. This field will be enabled only for a foreign  currency vendor.


![]({{site.pp_baseurl}}/img/lens.gif) [Foreign Currency  Documents]({{site.pp_baseurl}}/return-proc/doc-prof/contents/tabs/details/for-cur-info/foreign_currency_documents_pr.html)


By default this field displays the latest exchange rate defined for  the vendor currency in the **Exchange Rate**  profile (path: **File** > **Setup** > **Accounting**  > **Multi-currency** > **Exchange** **Rates** > **Options** > **Edit** > **In 
 New Window**). **Everest** determines  whether the Buy Rate/Sell Rate should be used depending on the setting  in the **Rate for Purchase Documents**  field (path: **File &gt; Setup &gt; Preferences 
 &gt; Defaults &gt; Accounting &gt; Multicurrency &gt; Exchange Rates**).  Exchange rates can be entered with up to six decimals.


If the exchange rate for the document is different from the current  rate, you can change the rate.


You must ensure that the exchange rate for return document is the same  as that in the purchase document for the inventory control account or  expense account to be credited correctly in your base currency.


{:.example}
If your base currency is US Dollars, the vendor’s  currency is Great British Pounds, and you buy 100 units of an item for  GBP 10 each. The exchange rate on the purchase receipt is 1 GBP = 1.42  USD. The Inventory Control Account is debited with USD 1420. If you return  50 units and create a debit memo with the rate 1.50, the Inventory Control  Account is credited with USD 750 (i.e. 50x10x1.50) when it should be credited  with USD 710 (i.e. 50x10x1.42). Hence you must ensure that rate is the  same as in the purchase receipt.


Exchange Rate for Purchase Return Document Conversion


If there is a time lag between the creation of an intermediate document  and the final document, the exchange rate could fluctuate. **Everest**  allows you to take care of such situations by setting a preference in  the **Exchange rate used when converting 
 quotes and orders** field in the [Documents  dialog box]({{site.bp_chm}}/misc/miscellaneous_others_others_2_steps.html) (path: **File &gt; Setup 
 &gt; Preferences &gt; Flow Control &gt; Documents &gt; Miscellaneous &gt; 
 Others &gt; Others 2** tab). The option selected in the **Exchange 
 rate used when converting quotes and orders** field takes effect  when you convert a debit quote to a debit order or a debit order to a  debit memo.


The options available in this field are:

- **Prompt 
 user with the exchange rate available as on date logged in** - If  you select this option, **Everest** prompts  you with the latest exchange rate available on the login date (for the  document currency). Click **Yes**  to replace the exchange rate on the document with the latest exchange  rate. Click **No** to retain the existing  exchange rate on the document.
- **Use 
 the exchange rate on the document being converted** - If you select  this option, the **Exchange Rate** field  defaults to the exchange rate available on the document being processed.
- **Use 
 the exchange rate available as on date logged in** - If you select  this field, the **Exchange Rate**  field defaults to the latest exchange rate available on the login date.



{:.see_also}
See also
: [Exchange  Rate Profile]({{site.sc_chm}}/options/multicurrency/exchange-rates/set-up-exchange-rates/exchange_rates_profile.html)
: [Currency  Profile]({{site.sc_chm}}/misc/currency_details.html)
: [Other Information]({{site.pp_baseurl}}/return-proc/doc-prof/contents/tabs/details/other-information/other_information_pr.html)
