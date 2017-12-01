---
title: Cross-Currency Calculations
---

# Cross-Currency Calculations


When more than one currency is involved in a payment, **Everest**  uses cross-currency calculations.


{:.example}
Assume that your base currency is United States Dollar  (USD) and you have created a sales invoice for a customer whose currency  is Great Britain Pound (GBP). You receive payment from the customer in  Euros (EUR) and deposit into your bank account maintained in Japanese  Yen (JPY). **Everest** uses cross-currency  calculations so that your bank account balance increases by the JPY amount  that equals the value of the EUR check issued.


In this case, **Everest**  first uses the exchange rate available for EUR to USD to calculate the  equivalent USD amount for the received amount. **Everest**  then translates this USD amount to the JPY amount using the exchange rate  available from USD to JPY.


This is called **cross-currency 
 calculations**. The result thus derived is the same as directly translating  EUR to JPY since the exchange rate from EUR to JPY can be obtained by  equating the USD/EUR rate to the JPY/USD rate.


Thus, the accounts must be updated not only in terms of the base currency  but also in their respective currencies.


The presumption while performing cross-currency calculations is that  the exchange rates entered for the payment currency, the bank currency  and the document currency against the base are all from the same foreign  exchange market.


{:.example}
Base Currency = USD


Amount of payment = 1000 EUR


Exchange rate for EUR to USD: 1 EUR = 1.10 USD


Bank currency = JPY


Exchange rate for USD to JPY: 1 USD = 123.247 JPY


Hence, 1 EUR = 123.247 \* 1.10 = 135.5717 JPY


1000 EUR in terms of JPY = 135571.7 JPY


Document currency = GBP


Exchange rate for GBP to USD: 1 GBP = 1.41218 USD


Hence, 1 EUR = 1.10/1.41218 = 0.778938 GBP


1000 EUR in terms of GBP = 778.938


{:.see_also}
See also
: [Exchange  Rate Details]({{site.sp_baseurl}}/misc/exchange_rate_details_payment_dialog_box.html)
