---
title: Impact of Reversing on Payment History and Transaction History Screens
---

# Impact of Reversing on Payment History and Transaction History Screens


The following table shows new statuses after an original transaction  is reversed and recreated as well as changes on the **Document 
 Payment History** and **Transaction 
 History** screens:


| Transaction | New Transaction Status | New Payment Status | Document Payment History Screen | Transaction History screen |
| Original Transaction | Reversed | Blank |  | No Change in Event Description |
| Offset Entry | Reversal | Blank | New Row (includes narration) | Event Description shows “Reversal of Journal <#>, Transaction  <#>” |
| Recreated Entry | Normal | 'To be Printed' if payment type is check otherwise    'Outstanding' | New Row (includes narration) | Event Description shows “Replacement of Reversed Journal <#>,  Transaction <#>” |



{:.see_also}
See also
: [Reverse]({{site.acc_baseurl}}/misc/reverse_dialog_box_payment_history_screen.html)
: [Impact  of Reversing on Payment Status and Transaction Status]({{site.acc_baseurl}}/misc/impact_of_reversing_on_payment_status_and_transaction_status.html)
