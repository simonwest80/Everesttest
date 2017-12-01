---
title: Calculation of Foreign Exchange Gains and Losses
---

# Calculation of Foreign Exchange Gains and Losses


If you enter into a contract (an order) with a customer or vendor whose  currency differs from your own, there can be an increase or decrease in  the anticipated amount due based on fluctuations in the exchange rate.


Therefore, as the exchange rate between the base currency and document  currency fluctuates, you may be paid (or are required to pay) more or  less than what you expected when the document currency is converted to  the base currency. This difference is the gain or loss on the transaction.


To adhere to Generally Accepted Accounting Principles (GAAP), the system  does not use multi-currency order documents to create accounting entries  for an exchange gain or loss, nor does the system calculate a gain or  loss for each deposit.


The system accounts for an exchange gain or loss in the following two  scenarios if the exchange rate when you accepted the deposit(s) differs  from the exchange rate of the final document or the refund:

- When you apply  the deposit that is received on a multi-currency order document to a final  document
- When you refund  the deposit on a multi-currency order



However, you may want to know what the projected gain or loss would  be on the outstanding balance. Therefore, to help you determine the projected  gain or loss on the remaining balance, the order (when viewed in base  currency) contains several fields that you can use to determine the projected  gain or loss on the remaining balance due to the difference between the  current exchange rate and the exchange rate used when the deposit was  accepted.


Although we use sales orders as our example, this section is applicable  to sales orders, purchase orders, debit orders, and credit orders.


The fields are as follows:


**Deposit**
: This field displays the total deposit amount (in  base currency) available for the order. If there are multiple deposits  against the order, the system combines all of the deposits after it converts  each to the base currency using the applicable exchange rate that was  used when the deposits were accepted. The system does not calculate a  gain or loss for each deposit, and instead calculates the gain or loss  of the remaining balance after all deposits have been subtracted.
: Below is an example of multiple deposits made against  the sales order.


| Date | Transaction | Amount in Doc. Curr. | Exchange Rate | Amount in Base Curr. |
| 11/15/2006 | 1st Deposit  on  SO | 22500 INR | 1 USD = 45 INR | 500.00 USD |
| 11/17/2006 | 2nd Deposit on SO | 10000 INR | 1 USD = 50 INR | 200.00 USD |
| 11/20/2006 | 3rd Deposit on SO | 12000 INR | 1 USD = 60 INR | 200.00 USD |

: Given the deposits above, the Deposit field would  display 900.00 USD, which is the total of the three deposits using the  applicable exchange rate for each.


**Balance**
: This field displays the difference between the order  total and the deposits. If the order total was 1000.00 USD (45000 INR)  , the Balance field would display 100.00 USD, which is the order total  minus the total deposits. Of course, in the document currency the field  would display 500 INR, which is the 45000 INR total minus the 44500 INR  in deposits.
: You can think of this value as the amount of money  that is still owed in whichever currency you choose to view. In our example,  the base currency view shows the amount owed in USD and the document currency  view shows the amount owed in INR. When viewed in the base currency (USD),  this value is calculated using the applicable exchange rates of the deposits.  However, this balance may not be the exact amount that you would expect  to receive from the customer because there could be an increase or decrease  in the exchange rate. For a more accurate estimate, refer to the Balance  @ Ex. Rate field.


{:.note}
Even if the total balance of the document  currency has been collected, the Sales Order browser may still display  a balance in the base currency due to the difference in exchange rate.


**Balance @ Ex. Rate**
: This field displays the remaining balance in the  base currency that you would expect to receive if the balance in document  currency was converted to the base currency using the most current exchange  rate. In our example, the system uses the most current sell exchange rate.  For purchase orders, the system uses the most current buy exchange rate.  You specify buy and sell exchange rates in the Exchange Rate profile.
: If you wand over the field, the system displays  the exchange rate used to calculate this field. Each time the applicable  current exchange rate is updated in the Exchange Rate profile, the value  in this field changes when you close and reopen the order. If a current  exchange rate is not defined for the currency combination, the field remains  blank.
: If we use our example above, the system would take  the 500 INR balance and apply it against the current sell exchange rate.  Let's assume the current sell exchange rate is 1 USD = 65 INR. In this  case, the field displays 7.69 USD, which is 500/65.
: It is important to note that the 7.69 value is a  figure that you use for informational purposes only and is not used to  request additional funds from the customer. The customer is not responsible  for changes in the base currency totals due to changes in the exchange  rate.


**Ex. Difference**
: This field displays the difference between the Balance  field and the Balance @ Ex. Rate field. In other words, the field displays  the gain or loss on the outstanding balance of the multi-currency order  document due to the difference between the current exchange rate and the  exchange rate used when the deposit was accepted.
: In our example, the field displays 92.31 USD, which  is the 100.00 USD balance minus the 7.69 USD current exchange rate balance.  Therefore, there is a loss of 92.31 USD on the transaction due to the  changes in the exchange rate.
: Keep in mind that as the applicable current exchange  rate changes, the Ex. Difference value changes as well to reflect the  adjustment to the remaining balance in the base currency. Therefore, the  92.31 USD value could increase or decrease as the sell exchange rate changes.  You use this value only to estimate what the gain or loss will be. The  actual accounting entries are made only after you complete the final document.
: Another way to view the gain or loss is to assess  the strength of the base currency against the document currency. In our  example, the USD strengthened against the INR. Therefore, using the current  exchange rate the remaining 100 USD balance is worth 6500 INR (65 x 100).  However, because the customer is required to pay only the 500 INR balance,  you lose the equivalent of 6000 INR (6500 - 500), which is roughly 92.31  USD (6000/65).
: Use the table below to determine whether the exchange  rate creates a gain or loss on the balance due for a multi-currency order  document.


| Document | Equation | Gain/Loss |
| Sales order or debit order | Balance < Exc. Rate Balance | Gain |
| Sales order or debit order | Balance > Exc. Rate Balance | Loss |
| Purchase order or credit order | Balance > Exc. Rate Balance | Gain |
| Purchase order or credit order | Balance < Exc. Rate Balance | Loss |

: After you complete the final document, the system  creates an accounting entry for the gain or loss in the applicable accounting  journal. Refer to the links below for information on the Gain/Loss accounting  entries.


{:.see_also}
See also
: [Receipts  in Foreign Currency]({{site.acc_baseurl}}/customer-receipts-and-refunds/foreign-currency-receipts/receipts_in_foreign_currency.html)
: [Payments  In Foreign Currency]({{site.acc_baseurl}}/vendor-payments-and-refunds/foreign-currency-payments/payments_in_foreign_currency.html)
