---
title: The Overpayment Dialog Box
---

# The Overpayment Dialog Box


The **Overpayment** dialog box appears  when you receive on a sales order or sales invoice an amount greater than  the value of the sales order or invoice. It also appears when you convert  a sales order with a negative balance to a sales invoice because the sales  invoice, as a final document, cannot have a negative balance.


The Overpayment dialog box offers several options for the overpaid amount.  You may return it to the customer, apply the overpayment as a deposit  towards future sales to this customer, or leave the amount as a negative  balance on the sales order.


If you choose to return/refund it to the customer, the system creates  a refund entry in the Receipt Journal.


If you apply the overpayment as a customer deposit, the system credits  the amount of overpayment to the Customer Deposit Account specified in  the Customer Deposit field (path: **File**  > **Setup** > **Accounting**  > **Posting Group** profile) of  the Customer Posting Group and generates a manual document for the customer.


If you choose to leave the negative balance on the sales order, the  sales order retains the negative balance. When making an overpayment on  a sales invoice, the negative balance applies to the sales order you converted  into the sales invoice. In the case of a sales invoice created directly,  the sales invoice itself will retain the negative balance. This is the  only case which allows a sales invoice to carry a negative balance.


{:.note}
You may not make an overpayment for batch  processing.


{:.see_also}
See also
: [The Receipt  Dialog Box]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/pmts-refunds/pmts-on-so/rcpt-dlg/the_payment_dialog_box.html)
