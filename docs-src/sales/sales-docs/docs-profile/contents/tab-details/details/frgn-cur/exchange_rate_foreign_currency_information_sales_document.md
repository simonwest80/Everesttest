---
title: Exchange Rate
---

# Exchange Rate


The **Exchange Rate** field displays  the exchange rate for a foreign currency when a new foreign currency sales  document is created. The exchange rate displayed is the exchange rate  against your base currency.


**Everest** determines whether the  Buy Rate/Sell Rate should be used depending on the setting in the **Rate for Sales Documents** field (path:  **File &gt; Setup &gt; Preferences &gt; 
 Defaults &gt; Accounting &gt; Multicurrency &gt; Exchange Rates**).  Exchange rates can be entered with up to six decimals.


If the exchange rate for the document is different from the current  rate, then you can change the rate.


![]({{site.sp_baseurl}}/img/example.gif) If  a sale from a foreign customer is covered by a fixed rate contract (where  you contract to buy the foreign exchange at a specified rate) the exchange  rate for the document will be the exchange rate defined in the contract.


{:.note}
When you convert a quote to an order or an order to  an invoice, the exchange rate displayed is the rate as per the quote/order.  If the rate has changed as on the invoice date, you must change the rate.


If there is a time lag between the creation of an intermediate document  and the final document, the exchange rate could fluctuate. **Everest**  allows you to take care of such situations by setting a preference in  the **Exchange rate used when converting 
 quotes and orders** field in the **Documents** dialog box (path: **File &gt; 
 Setup &gt; Preferences &gt; Flow Control &gt; Documents &gt; Miscellaneous 
 &gt; Others &gt; Others 2** tab). The option selected in the **Exchange rate used when converting quotes and 
 orders** field takes effect when you convert a sales quote to a sales  order or a sales order to a sales invoice.


The options available in this field are:

- **Prompt 
 user with the exchange rate available as on date logged in** - If  you select this option, **Everest** prompts  you with the latest exchange rate available on the login date (for the  document currency). Click **Yes**  to replace the exchange rate on the document with the latest exchange  rate. Click **No** to retain the existing  exchange rate on the document.
- **Use 
 the exchange rate on the document being converted** - If you select  this option, the **Exchange Rate** field  defaults to the exchange rate available on the document being processed.
- **Use 
 the exchange rate available as on date logged in** - If you select  this field, the **Exchange Rate**  field defaults to the latest exchange rate available on the login date.



{:.see_also}
See also
: [Foreign  Currency Information]({{site.sp_baseurl}}/sales-docs/docs-profile/contents/tab-details/details/frgn-cur/foreign_currency_information_sales_document_content.html)
: [Exchange  Rates]({{site.sc_chm}}/options/multicurrency/exchange-rates/set-up-exchange-rates/defining_exchange_rates.html)
: [Currency]({{site.sc_chm}}/misc/currency_details.html)
: [Determining  Inventory Control Account for Sales Documents]({{site.sp_baseurl}}/misc/determining_inventory_control_account_for_sales_documents.html)
