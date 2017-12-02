---
title: Void and Recreate Payment Transactions
---

# Void and Recreate Payment Transactions


“Voiding and recreating transactions” refer to voiding the original  payment (receipt/refund) transaction and recreating it. Payment entries  may not only have to be voided but recreated for the following reasons:

- A check did  not print correctly, and you want to recreate the transaction for printing  it again.
- A check that  was returned due to insufficient funds has to be presented again. Voiding  and recreating ensures that the original transaction is recreated with  the same or updated details such as source type, bank account, payment  method, and date.



When a transaction is voided, the balance of the transaction is changed  to $0.00 and the customer or vendor associated with the transaction is  removed. When a transaction is voided and recreated, the bank account  of the recreated transaction is the bank associated with the payment method.  You can view the voided transaction in the **Voided 
 Transactions** browser and the **Payment 
 Register** browser. You can view the recreated transaction in the  **Payment Register** browser. The  transaction status of a voided transaction is **Void**  and the transaction status of a recreated transaction is **Normal**.  The following table shows where the voided and recreated transactions  display:


| Screen | Voided Transaction will display? | Recreated transactions will display? |
| Document Payment History screen | No | Yes |
| Transaction History screen | Yes | Yes |
| Payment/Receipt journal browser | No | Yes |
| Payment/Receipt journal transaction browser | No | Yes |
| Voided Transactions browser | Yes | No |
| Payment Register browser | Yes | Yes |



{:.note}
Recreated entries appear in the bank reconciliation  process after they are printed and posted, but voided transactions do  not appear in the bank reconciliation process.


The **Void** option is available  for all UNPOSTED transactions irrespective of whether checks have been  printed or not.


The **Void** option is not available  for the following transactions:

- Reversed
- Reversal
- Already Voided
- Cleared/Reconciled



{:.see_also}
See also
: [Void  Payment/Refund Transactions - Payment Register]({{site.acc_baseurl}}/payment-register/wizard/browser/voiding-transactions-payment-register/voiding_transactions_from_the_payment_register.html)
: [Accounting  Entries - Voiding and Recreating]({{site.acc_baseurl}}/payment-register/wizard/browser/voiding-and-recreating-transactions/acc_entries_void_and_recreate.html)
: [Back  End Processes - Voiding and Recreating]({{site.acc_baseurl}}/payment-register/wizard/browser/voiding-and-recreating-transactions/back_end_processes_for_voiding_and_recreating.html)
