---
title: Impact of Reversing on Journals
---

# Impact of Reversing on Journals


After a transaction is reversed, the following changes occur in the  journals:

- The original  transaction appears in the **Journal Transactions**  browser with a status of **Reversed**.
- The journal  with the description of “Reversal Transaction” contains an entry with  a Transaction Status of **Reversal**  and the same state of posting as the Reversed transaction. This gets created  as a new journal. The Payment status will be blank for a reversal transaction.
- A journal with  the description of “Replacement of Reversed Journals” contains the newly  recreated transaction along with all of the newly recreated transactions  for reversed journals that have the same payment method and fall within  the same period. The recreated transaction has a Transaction Status of  **Normal** and the same state of posting  as the Reversed transaction. This gets created as a new journal. The Payment  status will be blank for a reversed transaction.



{:.see_also}
See also
: [Reverse  a General Journal]({{site.acc_baseurl}}/general-journals/processes/common-jrnl-proc/reverse_a_general_journal_acc.html)
