---
title: Void a Payroll Journal
---

# Void a Payroll Journal


A payroll transaction for which a payroll journal is created may be  voided. The transaction can be voided irrespective of whether the journal  has been posted or not. When you void a payroll transaction, reversal  entries are created to nullify the effect of the original entry.


Once a payroll transaction is voided, the original transaction is also  removed  from  the **Payroll Transactions** browser;  hence, you can create a new transaction for the employee for the same  period.


You can void an employee's latest payroll transaction for which a payroll  journal has been created. Payroll transactions preceding the latest transaction  cannot be voided unless the latest transaction is first voided. The term  "latest" in this context refers to the Transaction Number, which  is generated according to the date of creation of the transaction.


| ![]({{site.prl_baseurl}}/img/example.gif) | You have created the following payroll transactions  for an employee:<br/><br/><br/>| Payroll Period | Transaction Number |<br/>| 1/1/2000 to 1/31/2000 | 10 |<br/>| 2/1/2000 to 2/28/2000 | 11 |<br/>| 3/1/2000 to 3/31/2000 | 12 |<br/>| 4/1/2000 to 4/30/2000 | 13 |<br/><br/><br/><br/>The **Transactions <br/> Grid** of the **Void Payroll Journal**  dialog box displays the transaction for April 2000 which is the most recent.  You need to void this transaction first. Thereafter, you can void the  transaction for March 2000 and so forth. |



The reason is that taxes are often calculated for a transaction after  considering the year-to-date amounts of prior transactions.


If a prior transaction is voided without voiding the subsequent transaction,  the tax calculations for the subsequent transaction may be erroneous.


| ![]({{site.prl_baseurl}}/img/example.gif) | You have created the following payroll transactions  for an employee:<br/><br/><br/>| Payroll Period | Transaction Number |<br/>| 1/1/2000 to 1/31/2000 | 10 |<br/>| 2/1/2000 to 2/28/2000 | 13 |<br/>| 3/1/2000 to 3/31/2000 | 11 |<br/>| 4/1/2000 to 4/30/2000 | 12 |<br/><br/><br/><br/>Notice that the transaction created for the  month of February is the most recent one (Transaction Number 13). This  is because the transaction for February was created after the transactions  for March and April were created. **Everest**  would have warned you that the tax calculations for the subsequent transactions  would become erroneous; however, you opted to proceed and created the  transaction for February. In this case, the **Transactions <br/> Grid** of the **Void Payroll Journal**  dialog box displays the transaction pertaining to February. You need to  void this before voiding the transactions for April (Transaction Number  12) and March (Transaction Number 11), in that order. |



When a payroll journal transaction is voided, a debit memo is created.  Once the debit memo is created, **Everest**  automatically creates a payment journal entry to apply the debit memo  to the purchase receipt that is voided. The payment journal created acquires  a closed status when the debit memo is applied to the voided purchase  receipt


{:.steps}
To void a payroll journal, do the following:

- From the main  menu bar, select **Payroll &gt; Payroll 
 Journal &gt; Void Payroll Journal**. You will see the **Void 
 Payroll Journal** dialog box.
- From the **Void Payroll Journal** dialog box, highlight  the record you want to void. Then, select **Options 
 &gt; Void Payroll Journal**.



{:.see_also}
See also
: [Void  Payroll Journal Dialog Box]({{site.prl_baseurl}}/payroll-process/creating-journal/voiding-journal/void-dlg/void_payroll_journal_dialog_box_ptp.html)
: [Back  End Processes for a Payroll Journal]({{site.prl_baseurl}}/payroll-process/creating-journal/voiding-journal/void-dlg/back_end_process_-_payroll_journal.html)
