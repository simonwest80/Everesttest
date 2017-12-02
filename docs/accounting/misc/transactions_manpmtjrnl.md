---
title: Transactions
---

# Transactions


**Transaction #**
: This is the unique number used to identify the transaction.  The transaction number is created automatically by **Everest**.


**Date**
: Specify the date of the transaction. In case of  system entries made for document payments or refunds, the date displays  the login date when the payment/refund was entered. For manual entries,  you can select any date that falls within the fiscal year and period for  the journal as the date of transaction.
: The default date displayed in this field depends  on whether an active period has been defined.


| **Active Period Defined?** | **Date Displayed:** |
| YES | - If login date  belongs to active period - Login  Date<br/>- If login date  does NOT belong to active period - First date of the active period. |
| NO | : Login  Date |



**Source**
: Specify the source type for this transaction. The  default source type displayed when creating a manual payment journal is  MPA for Manual  Payment. You may select any other manual source type for the transaction.  System source types cannot be selected for a manual journal.


**Payment Type**
: Specify the payment method by which the liability  on the document is to be discharged. This is a mandatory field.
: All payment methods setup for vendors, and associated  with the bank account selected on the journal are available for selection.  If a bank has not been specified, no payment methods are displayed in  this field.


**The check display section**
: The check display section enables you to specify  the payment details such as the vendor name and payee information. Click  [here]({{site.acc_baseurl}}/misc/the_check_display_section_payment_journal_steps.html)  for details.


{:.see_also}
See also
: [Transaction  Information]({{site.acc_baseurl}}/vendor-payments-and-refunds/payment-jrnl-dtls/transaction-entries/other_columns_in_transaction_entries_manpmtjrnl.html)
