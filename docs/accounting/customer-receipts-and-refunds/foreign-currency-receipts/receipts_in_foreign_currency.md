---
title: Receipts In Foreign Currency
---

# Receipts In Foreign Currency


Below is information on how the system handles accounting entries for  payments received in foreign currency.


The system does not create accounting entries for gains or losses at  the time you accept deposits against order documents. Instead, the system  creates accounting entries for a gain or loss when you apply the deposit  on the final document only. Therefore, you will not see any gain or loss  accounting entries in the receipt or payment journal when you make or  receive deposits.


However, you should expect to see an accounting entry for a gain or  loss on the total transaction when the final document in reconciled. The  Gain/Loss entry offsets the difference in the exchange rate between when  the payment was accepted and when the payment was applied.


Below is a sample Receipt journal viewed in base currency for the final  transaction. Notice the adjustment entry for the gain/loss due to the  exchange rate difference.


Payments on an SO applied to SI


| Entry Type | Debit | Credit |
| Payment on invoice |  | Base currency deposit amount applied to current exchange rate |
| Apply deposit on SO | Original base currency deposit amount |  |
| Gain/Loss | A loss is posted here | A gain is posted here |



Refunds on a SO


| Entry Type | Debit | Credit |
| Payment by cash |  | Base currency deposit amount applied to current exchange rate |
| Deposit on PO | Original deposit amount |  |
| Gain/Loss | A loss is posted here | A gain is posted here |



You must have accounts set up to handle exchange gains or losses. Refer  to the link below for information on how to set up foreign exchange gain/loss  accounts.


{:.see_also}
See also
: [Accounting  Defaults - Multicurrency]({{site.acc_baseurl}}/misc/accounting_defaults_multi_currency.html)
