---
title: Payment Status
---

# Payment Status


The various types of payment statuses are:


**To Be Printed**


This status appears in **Payment Status**  field only if:

- The check number  has not been assigned to  a  transaction, which had used Checks as payment method.
- Where the transaction  with payment method check has a **Outstanding**  Payment Status and you blank out the check number.
- Where the check  has not been printed for a transaction that uses computer check as the  payment method.
- Select the  menu option **Change Payment Status**  > **To be Printed** for a transaction  that had **Outstanding** status.



**Outstanding**


This status appears in **Payment Status**  field only if:

- Normal transactions  use **Cash**, **Credit 
 card**  or  **Others** payment method.
- A transaction  that use checks as payment method has a check number assigned to it or  check printed for it.
- You manually  key in  the  check # in the Reference#/Check # column of a transaction with Payment  Status **To be Printed**.
- You print a  computer check  for  a transaction with Payment Status **To 
 be Printed**.
- You select  the menu option **Change Payment Status**  > **Outstanding** for a transaction  that had **To be Printed** Payment  Status and is Unposted.
- You select  the menu option **Change Payment Status**  > **Outstanding** status for a  transaction that had **Cleared** Payment  Status and is posted.



**Cleared**


This status appears in **Payment Status**  field only if:

- The transaction  uses **Check** as the payment method  and this check is marked as Cleared in Bank Reconciliation.
- You select  the menu option **Change Payment Status**  > **Cleared** for a transaction  that had **Outstanding** status and  is Posted.



**Reconciled**


This status appears in **Payment Status**  field only if the check is marked as Reconciled in the Bank Reconciliation  statement. These transactions will appear in the Bank Reconciliation statement  provided the **Include Reconciled transactions**  checkbox is ticked.


**Blank**


The **Payment Status** field for  the following type of transactions will be blank.

- Voided Transactions
- Reversed transactions
- Reversal transaction
- Quick Voided  transactions



{:.see_also}
See also
: [Void  a Transaction from the Payment Register]({{site.acc_baseurl}}/payment-register/wizard/browser/voiding-transactions-payment-register/void_a_transaction_payment_register.html)
