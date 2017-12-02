---
title: Impact of Reversing on Unposted Payment Journals
---

# Impact of Reversing on Unposted Payment Journals


After a transaction is reversed, the following changes occur in the  unposted payment journals:

- The original  payroll transaction appears in the **Journal 
 Transactions** browser with a status of **Reversed**.
- The journal  with the description of “Reversal Transaction” contains an entry with  a Transaction Status of **Reversal**  and the same state of posting as the Reversed transaction. This gets created  as a new journal. The Payment status will be blank for a reversal transaction.
- A journal with  the description of “Replacement of Reversed Journals” contains the newly  recreated payroll transaction along with all of the newly recreated payroll  transactions for reversed journals that have the same payment method and  fall within the same period. The recreated payroll transaction has a Transaction  Status of **Normal** and the same  state of posting as the Reversed transaction. This gets created as a new  journal. The Payment status will be blank for a reversed transaction.



{:.see_also}
See also
: [Reverse  Dialog Box]({{site.acc_baseurl}}/misc/reverse_dialog_box_payment_history_screen.html)
