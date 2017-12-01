---
title: Reverse Dialog Box
---

# Reverse Dialog Box


This dialog box appears for payroll transactions.


Reversal Transaction Information


**Source Type**
: The Source Type field defaults to the appropriate  system source type for reversals. The system source type is mentioned  below:

- RPP – Reversal  of Payroll Payment Transaction

: If a payroll payment transaction is reversed, the  Source Type defaults to RPP. However, you can select a different source  type from the drop-down list or create a new one. If no source type is  selected the system will select the default source type when you save  the dialog box. The description of Source Type displays in the untitled  field to the right.


**Date of Reversal**
: Select the date of reversal. By default, this field  displays the date of the original transaction. However, you can change  it.


{:.note}
The original or selected date must fall within  an open period. If using a selected date, it must fall on or after the  date of the original transaction.


**Narration**
: Enter the specific reason for reversing this transaction.  This is an optional field. The reason for the reversal entered in this  field is updated in both the Reversed and Reversal Journals.


**Replace the reversed transaction with a new transaction**
: Select this check box to create a new transaction  to replace the reversed transaction. This check box is unselected by default.


New Transaction Information


The fields in this section are available only if you have selected the  **Replace the reversed transaction with 
 a new transaction** check box.


**Source Type**
: Displays the source type of the original transaction.  However, you can select a different source type from the drop-down list  or create a new one. The description of Source Type displays in the untitled  field to the right. This field is mandatory.


**Bank Account**
: The bank account for this re-created transaction  will be the bank associated to the payment method.


**Payment Method**
: Displays the payment method of the original transaction.  However, you can select a different payment method from the drop-down  list or create a new one. The description of Payment Method displays in  the untitled field to the right. If no payment method is selected, the  payment method used in the original transaction will be selected when  you save this dialog box. This field is mandatory.


**Date**
: Displays date of the original transaction, however,  you can select another date as needed.


{:.note}
The original or selected date must fall within  an open period. If using a selected date, it must fall on or after the  date of the original transaction or date of reversal.  This  field is mandatory.


{:.note}
You will not be able to reverse a transaction  if the document balance shows up negative figures.


{:.see_also}
See also
: [Impact  of Reversing on Unposted Payment Journals]({{site.acc_baseurl}}/misc/impact_of_reversing_on_unposted_payment_journals.html)
