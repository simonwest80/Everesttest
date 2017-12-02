---
title: Impact of Reversing on Payment Status and Transaction Status
---

# Impact of Reversing on Payment Status and Transaction Status


When a transaction is reversed the Transaction Status of the original  transaction will be Reversed and the new transaction status will be Reversal.  Every new re-created entry will have Normal status.


The Payment Status for the reversed and reversal transaction will be  blank and Payment status for the re-created transaction will be **To be Printed** for check payment type  and **Outstanding** for cash or credit  card payment type.


{:.note}
Check number for the new transaction can be  same as the original transaction. However, system will prompt a confirmation  message. Click **Yes** to continue  assigning same check number.


| ![]({{site.acc_baseurl}}/img/example.gif) | The following table provides an example of  changes in Event Description for a reversed and recreated transaction  on the **Document Transaction History**  screen:<br/><br/><br/>| Date of Action | Action | Transaction Status | Event Description in the Document Transaction  History |<br/>| 1/1/2005 | Journal 20 Transaction 1 – Original Transaction | Normal | Payment Made/Received |<br/>| 1/5/2005 | Reversed Journal 20 Transaction 1 | Reversed | No Change (Only the status for Journal 20 Transaction 1 changes from  Reversed to Normal.) |<br/>| 1/5/2005 | Journal 28 Transaction 2 – Reversal Transaction | Reversal | Reversal of Journal 20 Transaction 1 |<br/>| 1/10/2005 | Journal 40 Transaction 1 – Recreated Transaction | Normal | Replacement of Reversed Journal 20 Transaction 1 | |



A Reversed or Reversal transaction can be posted but not edited (except  for the **Narration** field). You  can purge an unposted Reversal transaction, but you cannot void or reverse  it further. Additionally, Reversed or Reversal transactions must be in  an open period to be purged.


You can purge or reverse a recreated transaction because it is a Normal  transaction. Recreated entries appear in the bank reconciliation process  after it is posted or printed but Reversed transactions do not.


{:.see_also}
See also
: [Reverse]({{site.acc_baseurl}}/misc/reverse_dialog_box_payment_history_screen.html)
: [Impact  of Reversing on Payment History and Transaction History screens]({{site.acc_baseurl}}/misc/impact_of_reversing_on_payment_history_and_transaction_history_screens.html)
