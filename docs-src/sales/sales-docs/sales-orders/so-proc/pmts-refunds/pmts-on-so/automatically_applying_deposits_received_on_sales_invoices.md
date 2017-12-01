---
title: Applying Deposits Received on Sales Orders
---

# Applying Deposits Received on Sales Orders


Set a preference in the **Method for 
 applying deposit collected on a sales order when converting it to a sales 
 invoice** field (path: **File**  > **Setup** > **Preferences**  > **Flow Control** > **Documents**  > **Prompts** > **Sales 
 Document** > **Sales Document 2**  tab).


**Method for applying deposits received on Sales  Orders**

- If you select **Automatically create a new transaction to apply 
 deposit to sales invoice**, the deposit received on the sales order  is automatically applied on the invoice when the invoice is saved and  the amount/deposit is reflected in the Paid field of the invoice.
- If you select **Automatically move deposit to Sales Invoice, 
 if possible. Otherwise, auto create transaction to apply deposit**,  the system applies the deposit made on the sales order on the invoice  if the sales order and sales invoice are created on the same day and there  is only one payment made on the order. If these conditions are not met,  a new transaction is created showing the applied amount on the invoice  when you save the invoice.
- If you select **Prompt user to allow them to select how they 
 would like to treat the deposit**, the system displays a prompt for  you to select how you would like to treat the deposit received on the  sales order.
- If you select **Keep deposit on sales order**, the system  retains the deposit on the sales order and you can apply the deposit to  any sales document for the same customer or apply the deposit on a different  day on the invoice.



When you select the **Prompt 
 user to allow them to select how they would like to treat the deposit**  option, the **Everest Prompt** displays  giving you further options.


The **Everest Prompt**  provides you three options:

- Move deposit from  Sales Order to Sales Invoice
- Create a new transaction  to apply deposit to Sales Invoice
- Keep deposit on  this Sales Order



The deposit applied as per the option selected by you.


{:.see_also}
See also
: [Flow  Control Preferences for Applying Deposits on Sales Documents]({{site.bp_chm}}/misc/method_of_applying_deposit_collected_on_a_sales_order_at_the_time_of_converting_it_to_a_sales_invoice.html)
: [Payments  on Sales Orders]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/pmts-refunds/pmts-on-so/payments_on_sales_orders.html)
