---
title: Exchange Rate
---

# Exchange Rate


The **Exchange Rate** field allows  you to specify the exchange rate between your base currency and the vendor  currency. This field is enabled only in case of foreign currency vendors.


![]({{site.pp_baseurl}}/img/lens.gif) [Foreign Currency  Documents]({{site.pp_baseurl}}/purc-proc/doc-profile/contents/tabs/details/for-cur-info/foreign_currency_document.html)


By default, this field displays the latest exchange rate defined in  the **Exchange Rate** profile (path:  **File &gt; Setup &gt; Accounting &gt; 
 Multi-currency &gt; Exchange Rates &gt; Options &gt; Edit &gt; In New 
 Window &gt; Exchange Rates** profile). **Everest**  determines whether the Buy Rate/Sell Rate should be used depending on  the setting in the **Rate for Purchase 
 Documents** field (path: **File &gt; 
 Setup &gt; Preferences &gt; Defaults &gt; Accounting &gt; Multicurrency 
 &gt; Exchange Rates**). Exchange rates have up to six decimals.


If the exchange rate for the document is different from the current  rate, you can change the rate.


{:.example}
If your purchases from a foreign vendor are  covered by a fixed rate contract (where you contract to buy the foreign  exchange at a specified rate) the exchange rate for the document will  be the same as that defined in the contract.


Exchange Rate for Purchase Document Conversion


If there is a time lag between the creation of an intermediate document  and the final document, the exchange rate could fluctuate. **Everest**  allows you to take care of such situations by setting a preference in  the **Exchange rate used when converting 
 quotes, orders, and receipts** field in the [Documents  dialog box]({{site.bp_chm}}/misc/miscellaneous_others_others_2_steps.html) (path: **File &gt; Setup 
 &gt; Preferences &gt; Flow Control &gt; Documents &gt; Miscellaneous &gt; 
 Others &gt; Others 2** tab). The selected option takes effect when  you convert a purchase quote to an order, an order to a receipt, and a  receipt or order to an invoice.


The options available in this field are:

- **Prompt 
 user with the exchange rate available as on date logged in** - If  you select this option, **Everest** prompts  you with the latest exchange rate available on the login date (for the  document currency). Click **Yes**  to replace the existing exchange rate with the latest exchange rate.
- **Use 
 the exchange rate on the document being converted** - If you select  this option, the **Exchange Rate** field  defaults to the exchange rate available on the document being processed.
- **Use 
 the exchange rate available as on date logged in** - If you select  this field, the **Exchange Rate**  field defaults to the latest exchange rate available on the login date.



{:.see_also}
See also
: [Exchange Rates]({{site.pp_baseurl}}/purc-proc/doc-profile/contents/tabs/details/for-cur-info/exchange_rate.html)
: [Currency]({{site.pp_baseurl}}/purc-proc/doc-profile/contents/tabs/details/for-cur-info/currency.html)
