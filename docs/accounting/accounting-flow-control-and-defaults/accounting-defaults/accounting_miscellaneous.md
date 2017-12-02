---
title: Accounting Dialog Box - Miscellaneous
---

# Accounting Dialog Box - Miscellaneous


The **Miscellaneous** tab allows  you to specify the default payment method for customers and vendors and  the default location.


{:.note}
You must ensure that the users who use these  payment methods are assigned the appropriate security rights related to  the payment methods, for the default settings to work correctly.


**Default Location**
: This option is used to specify the default location.  The default location is used for assigning sequence numbers if the location  of the login location or the parent location of the sub-location does  not have sequence numbers assigned.
: You may choose to use the same sequence numbers  for all your locations by specifying the sequence numbers only for the  default location and leaving it blank for the other locations.
: This field is mandatory.


**Default payment method for collections**
: Specify the default payment method to be displayed  when a new receipt journal is created. The payment method on the receipt  journal can be changed as required.


**Default payment method for payments**
: Specify the default payment method to be displayed  when a new payment journal is created. The payment method on the payment  journal can be changed as required.


**Default payment method for change due**
: When you receive an excess amount of money from  a customer on account of a Point of Sale transaction, you will have to  refund the change due to the customer. This option allows you to specify  the default payment method for refunding change.
: Specify the default payment method to be used while  refunding change due to customers. The change due to a customer can only  be made through cash type of payments.


**Default payment method for applied payments**
: You can apply documents to set off the amount:

- **Due 
 from the customer against any dues by you to the customer** - Dues  from a customer are the balance to be paid on a sales invoice and the  amount to be paid as a deposit on a sales order. Dues to a customer are  the amount to be paid as deposit on a credit order and the amount to be  refunded on a credit memo.
- **Due 
 by you to a vendor against any dues from the vendor** - Dues to a  vendor are the balance to be paid on a purchase invoice and the amount  to be paid as a deposit on a purchase order. Dues from a vendor are the  amount to be paid as deposit on a debit order and the amount to be refunded  on a debit memo.

: Specify the payment method to be used when amounts  are applied using the document payment/refund options from the document  profiles. It is not used in journals.


**Default adjustment account for payment type 'Cash'**
: Specify the default adjustment account for payment  by cash.


{:.example}
A cashier gave an employee a $50 bill from  the cash drawer to buy pizza for the staff. At the end of the day, the  pizza bill was only $ 43.50 and so the balance of $6.50 was placed back  into the drawer. In the Bank Deposit Wizard, when the cash deposit was  being prepared, an adjustment of ($43.50) was expensed to an entertainment  account.


**Default adjustment account for payment type 'Check'**
: Specify the default adjustment account for check  payments.


**Default adjustment account for payment type 'Others'**
: Specify the default adjustment account for payment  by other methods, excluding cash and check.


{:.example}
A merchant needs to pay 15 cents for each  transaction using a VISA card. The merchant calculates the VISA receipts  on a particular day to be 10 transactions amounting to $1000. The transaction  fee that will be deducted from the bank account is $1.50. The merchant  selects an expense account (VISA transaction fee account) and enters this  amount as ($1.50).


{:.see_also}
See also
: [Accounting Defaults]({{site.acc_baseurl}}/accounting-flow-control-and-defaults/accounting-defaults/accounting_defaults.html)
