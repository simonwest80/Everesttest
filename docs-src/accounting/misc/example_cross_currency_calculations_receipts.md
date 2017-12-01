---
title: Example - Cross - Currency Calculations
---

# Example - Cross - Currency Calculations


When more than one currency is involved in a receipt or refund, **Everest** uses cross-currency calculations.


![]({{site.acc_baseurl}}/img/example.gif)  Assume  that your base currency is United States Dollar (USD) and you have created  a sales invoice for a customer whose currency is Great Britain Pound (GBP);  you receive payment from the customer in Euro (EUR), which is deposited  in a bank account maintained in Japanese Yen (JPY). **Everest**  uses cross currency calculations so that your bank account balance will  increase by the JPY amount that equals the value of the EUR check received.


In this case, **Everest**  first uses the exchange rate available for EUR to USD to calculate the  equivalent USD amount for the payment amount. **Everest**  then translates this USD amount to the JPY amount using the exchange rate  available from USD to JPY.


This is called **cross-currency 
 calculations**. The result thus derived is the same as directly translating  EUR to JPY since the exchange rate from EUR to JPY can be obtained by  equating the USD/EUR rate to the JPY/USD rate.


The example given above is illustrated with amounts in the following  example:


![]({{site.acc_baseurl}}/img/example.gif)  Base  Currency = USD


Amount of payment = 1000 EUR


Exchange rate for EUR to USD: 1 EUR =  0.133935 USD


Bank currency = JPY


Exchange rate for USD to JPY: 1 USD =  123.247 JPY


1000 EUR in terms of JPY = 16507.08 JPY


Document currency = GBP


Exchange rate for GBP  to USD: 1 GBP  = 1.41218 USD


1000 EUR in terms of GBP  = 94.84


{:.see_also}
See also
: [Receipts  in Foreign Currency]({{site.acc_baseurl}}/customer-receipts-and-refunds/foreign-currency-receipts/receipts_in_foreign_currency.html)
