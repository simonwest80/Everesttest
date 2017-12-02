---
title: Payment History Browser Option
---

# Payment History Browser Option


The browser options available in **Payment 
 History** screen are mentioned below:


**Purge**
: Purging deletes the transaction permanently from  the database and it will not appear anywhere in **Everest**  . A transaction can be purged only if it is an unposted transaction irrespective  of whether it is a:

- Check printed  transactions
- Reversal transactions
- Transactions  for which checks have not yet been printed



{:.note}
- Adequate security  right is needed to purge a transaction.
- The customer/ vendor  balances will change and revert  back  to the  balance  amount that was there  before  the transaction took place.
- You cannot purge  a transaction if it results in document balance becoming negative or if  the balance becomes double.


{:.example}
In a sales document, if a receipt is purged  the customer balances will be the same amount as it was before recording  the receipt. If the refund is purged the customer balances will display  the same amount as it was before recording the refund.


**Void**
: Changes the amount in the transaction to $0.00 (zero),  and the customer/vendor associated with this transaction will be removed.  A transaction can be voided only if it is an UNPOSTED transaction irrespective  of the following types:

- Check Printed  Transactions
- Transaction  for which checks have not yet been printed



![]({{site.pp_baseurl}}/img/lens.gif)[Void  dialog box]({{site.acc_chm}}/payment-register/wizard/browser/voiding-transactions-payment-register/void_dialog_box_payment_register_brow.html)


**Reverse**
: Creates a new transaction with exactly opposite  data. An unposted or posted transaction for which the Payment Status  is  **Outstanding** can be reversed.  This  means transactions which use the payment method **Check**  can be reversed only if a check has been printed for it. Transactions  that use payment methods of the type: **Cash**,  **Credit Card**, **Others**  always have the Payment Status as **Outstanding**  and can be reversed.
: Reverse is not possible on the following types of  transactions:

- Already Reversed  Transactions
- Reversal Transactions
- Cleared/ Reconciled  Transactions
- Voided Transactions



{:.note}
Adequate security right is needed to view  the **Reverse** dialog box.


**![]({{site.pp_baseurl}}/img/lens.gif)[Reverse  dialog box]({{site.acc_chm}}/misc/reverse_dialog_box_payment_history_screen.html)**


{:.see_also}
See also
: [Void  Payment/Refund Transactions - Payment Register]({{site.acc_chm}}/payment-register/wizard/browser/voiding-transactions-payment-register/voiding_transactions_from_the_payment_register.html)
