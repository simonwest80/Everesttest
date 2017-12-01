---
title: Receive Payments on Sales Invoices
---

# Receive Payments on Sales Invoices


Payments may be received against a sales invoice in any of the following  ways:

- By applying  deposits or advance documents available.



**![]({{site.sp_baseurl}}/img/lens.gif) [The Receipt  Dialog Box - Apply Deposits /Refunds]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/pmts-refunds/pmts-on-so/rcpt-dlg/the_payment_dialog_box_apply_deposits_refunds_tab.html)**
: **OR**

- By receiving  a new payment.



{:.steps}
To receive a new payment on a sales invoice,  do the following:

- From the **Sales Invoice** profile, select **Options &gt; Payment &gt; Receive**. You  will see the [**Receipt**  dialog box]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/pmts-refunds/pmts-on-so/rcpt-dlg/the_payment_dialog_box.html).



{:.note}
When a payment is received, all discounts offered on  early payments on sales are recorded in a GL account. You can define this  default account in the **Payment Discount**  on **Sales** field (path: **File 
 &gt; Setup &gt; Preferences &gt; Defaults &gt; Accounting &gt; Revenue 
 Accounts**).


If the field is blank, the system uses the default GL  account for Sales Discount. If the default GL account for sales discount  is blank, the system uses the default GL account for Revenue.


When you click the **Receive** option,  **Everest** checks if there are pending  transactions in the **Batch Payment Process**  browser (sale, authorization, pre-authorization and others) for that document.  If pending transactions are found, **Everest**  prompts you whether you want to process existing batch payment(s) or receive  new payment.


Selecting **Process existing batch payments**  option opens the **Batch Payment Process**  browser for processing the document.


To receive new payments, you should have appropriate security right.


{:.note}
The amount that you see in the message is the sum of  the value of all pending batch payments (sale, authorization, pre-authorization  and others) for the document.


{:.see_also}
See also
: [Back  End Processes - Receipt on a Sales Invoice]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/pmts-refunds/pmts-on-so/rcpt-dlg/back_end_processes_receipt_on_a_sales_invoice.html)
: [Accounting  Entries - Receipt on a Sales Invoice]({{site.sp_baseurl}}/misc/when_payment_is_received_on_a_sales_invoice.html)
