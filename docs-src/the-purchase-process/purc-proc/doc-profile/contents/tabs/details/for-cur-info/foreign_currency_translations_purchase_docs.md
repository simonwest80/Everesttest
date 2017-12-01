---
title: Foreign Currency Translations
---

# Foreign Currency Translations


When the document is in foreign currency, amounts are translated into  the base currency using the exchange rate for the document. The translation  formula applied depends on the quote type set in the **Currency**  profile (path: **File** > **Setup** > **Accounting** > **Multi-Currency** > **Currency** > **Options** > **Edit** > **In New Window**).


**If quote type is Foreign to Base, the translation  formula is:**


Foreign Currency Amount x (Exchange Rate/Quote Amount)


**If quote type is Base to Foreign, the translation  formula is:**


Foreign Currency Amount x (Quote Amount /Exchange Rate)


{:.example}
If your base currency is the US Dollar, and the document  currency is Great Britain Pounds (GBP), and the rate is expressed as 1  GBP = 1.42064; then 1000 GBP is translated using the formula for quote  type **foreign to base** as 1000 x  (1.42064/1) = 1420.64.


If the rate is expressed as 1 USD = 0.703973 GBP, then  1000 GBP is translated using the formula for quote type **base 
 to foreign** as 1000 x (1/0.703973) = 1420.64.


{:.note}
‘Quote type’ refers to whether the exchange rate is expressed from foreign  to base currency or from base to foreign currency.


{:.see_also}
See also
: [Currency]({{site.pp_baseurl}}/purc-proc/doc-profile/contents/tabs/details/for-cur-info/currency.html)
