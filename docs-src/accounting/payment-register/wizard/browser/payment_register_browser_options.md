---
title: Payment Register Browser Options
---

# Payment Register Browser Options


The browser options available in **Payment 
 Register** browser are mentioned below:


**Purge**
: Purging deletes the transaction permanently from  the database and it will not appear anywhere in **Everest**  . A transaction can be purged only if it is an unposted transaction irrespective  of whether it is a:

- Check printed  transaction
- Reversal transaction
- Transaction  for which checks have not yet been printed



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



| ![]({{site.acc_baseurl}}/img/lens.gif) | [Void  dialog box]({{site.acc_baseurl}}/payment-register/wizard/browser/voiding-transactions-payment-register/void_dialog_box_payment_register_brow.html) |



**Reverse**
: Creates a new transaction with exactly opposite  data. An unposted or posted transaction for which the Payment Status  is  **Outstanding** can be reversed.  This  means transactions which use the payment method **Check**  or has check # assigned to it can be reversed only if a check has been  printed for it. Transactions that use payment methods of the type: **Cash**, **Credit 
 Card**, **Others** always have  the Payment Status as **Outstanding**  and can be reversed.
: Reverse is not possible on the following types of  transactions:

- Already Reversed  Transactions
- Reversal Transactions
- Cleared/ Reconciled  Transactions
- Voided Transactions



{:.note}
Adequate security right is needed to view the **Reverse**  dialog box.


| ![]({{site.acc_baseurl}}/img/lens.gif) | [Reverse  dialog box]({{site.acc_baseurl}}/misc/reverse_dialog_box_payment_history_screen.html) |



**Quick Void**
: You can sort the **Payment 
 Register** browser by the Ref# /Check# column and then sometimes  you notice that there is a break in the sequence number of checks. Few  check#'s  do  not appear in **Payment Register**  browser because those checks were accidentally spoiled in the process  and never got accounted for. Without re-creating the payment/receipt transaction,  you can use **Quick Void** option  to account for these spoiled check.


| ![]({{site.acc_baseurl}}/img/lens.gif) | [Quick  Void]({{site.acc_baseurl}}/misc/quick_void_payment_register_browser_options.html) |



**Change Payment Status**
: This option comprises the following sub-options:

- To be printed
- Outstanding
- Cleared



| ![]({{site.acc_baseurl}}/img/lens.gif) | [Payment  Status]({{site.acc_baseurl}}/payment-register/wizard/browser/payment_status_payment_register_column.html) |

: If you select more than one record and click on  any one option the effect on all the records will be based on the record  where the cursor is focused.


{:.example}
If you select 10 records where records 1 to  7 has the Payment Status as **Outstanding**  and records 8 to 10 has the Payment Status as **Cleared**  and clicks the option **Change Payment 
 Status** > **Outstanding**,  **Everest** checks for the cursor  position. If the cursor is on record 6 which has Payment Status as **Outstanding** then records 1 to 8 will  have the Payment Status changed from **Outstanding**  to **Cleared**.


{:.note}
Changing the payment status here will also affect the Payment status  displayed in the payment/receipts journal and the **Voided 
 Transactions** browser.


**Change Deposit Status**
: This option has the following two sub-options:

- Mark Deposit
- Clear Deposit

: Use this option to correct a deposit status to show  whether or not the payment was deposited.
: ![]({{site.acc_baseurl}}/img/lens.gif)[Deposit  Status]({{site.acc_baseurl}}/misc/deposit_status_payment_register_browser_column_acc.html)


**Print Check**
: You can use this option to print the transaction  from the **Payment Register** browser.  This option is enabled only for the **Normal**  Transactions which are Unposted and if the payment status is **To 
 be Printed.**


{:.note}
This option is disabled if multiple records are selected.


{:.note}
For payroll journals none of the options mentioned  above will be enabled in the **Payment 
 Register** browser.


{:.see_also}
See also
: [Payment Register  Browser]({{site.acc_baseurl}}/payment-register/wizard/browser/payment_register_browser.html)
