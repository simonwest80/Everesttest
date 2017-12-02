---
title: Purging a Reversal Transaction
---

# Purging a Reversal Transaction


A transaction can be purged only if it is an unposted transaction. A  Reversal transaction can be purged regardless of whether the Reversed  transaction is posted or unposted.


| ![]({{site.acc_baseurl}}/img/example.gif) | The first example shows an unposted Reversal  transaction that is purged.<br/><br/><br/>| Date | Transaction Description | Transaction Status | Posted/<br/><br/><br/>Unposted | Comment |<br/>| 1/1/2005 | Original Transaction | Normal | Unposted | The Payment Status is **Outstanding**. |<br/>| 1/10/2005 | Reversed the original transaction on 1/10/2005 | Reversed | Unposted | - The Transaction  Status changes from **Normal** to  **Reversed**. The Payment Status will  appear blank.<br/>- Cannot be Edited<br/>- Can be Posted |<br/>| 1/10/2005 | Reversal Transaction | Reversal | Unposted | - Cannot be Edited<br/>- Can Be Posted |<br/>| 1/10/2005 | Original Transaction Reversed on 1/10/2005 | Reversed | Unposted | The Transaction Status changes from **Reversed**  to **Normal** and the Payment Status  changes to **Outstanding**. | |



| ![]({{site.acc_baseurl}}/img/example.gif) | This example shows a Posted Reversal Transaction  that cannot be purged.<br/><br/><br/>| Date | Transaction Description | Transaction Status | Posted/<br/><br/><br/>Unposted | Comment |<br/>| 1/1/2005 | Original Transaction | Normal | Posted | The Payment Status is **Outstanding**. |<br/>| 1/10/2005 | Original Transaction reversed on 1/10/2005 | Reversed | Posted | - The Transaction  Status changes from **Normal** to  **Reversed**. The Payment Status changes  to **None**.<br/>- Cannot be Edited |<br/>| 1/10/2005 | Reversal Transaction | Reversal | Posted | - Cannot be Edited<br/>- Cannot be purged  because it is posted. | |



{:.see_also}
See also
: [Reverse]({{site.acc_baseurl}}/misc/reverse_dialog_box_payment_history_screen.html)
