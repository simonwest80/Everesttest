---
title: Reduce document value below paid amount
---

# Reduce Document Value Below Paid Amount


If you reduce the value of a sales order or invoice after payment of  the full amount, say by reducing the price or changing the tax code, **Everest** informs you that the document  is overpaid and provides you three options to proceed:

- **Refund 
 the Overpayment** - Difference between the amount received and the  reduced document value is referred to as 'overpayment'. Select this option  to return the excess amount received to the customer.
- **Apply 
 Overpayment as Customer Deposit** – Select this option to retain  the overpayment as a deposit that you can apply to any other sales document.  A manual sales order is created to account for this deposit.
- **Save 
 the Document with a Negative Balance** - If you decide to save the  document with a negative balance, the amount remains overpaid and can  be applied to another sales order or invoice created for the same customer.



If you select **Refund the Overpayment**  or **Apply Overpayment as Customer Deposit**  options, the **Refund Payment to Customers**  dialog box is displayed. The **Amount**  field is disabled, which implies that only the exact amount overpaid can  be refunded or applied as customer deposit. You can use any payment method  to make the refund.


Multicurrency  Documents


In case of multicurrency  documents, enter the amount to be refunded or applied as customer deposit.


If the amount refunded or applied as a deposit is less than the overpayment,  **Everest** informs you of the same  and does not allow you to proceed.


For multicurrency  documents, the following changes are additionally effected:

- **Refund 
 the Overpayment** - The difference between the exchange rate at the  time of receipt and refund is treated as the exchange gain or loss for  the transaction.
- **Apply 
 Overpayment as Customer Deposit** – The manual sales order uses the  exchange rate at which the amount is originally received.



{:.see_also}
See also
: [Sales Order  Processes]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/sales_order_processes.html)
: [Accounting  Entries - Refund the Overpayment]({{site.sp_baseurl}}/misc/accounting_entries_-_refund_the_overpayment.html)
: [Accounting  Entries - Apply Overpayment on a Sales Order as Customer Deposit]({{site.sp_baseurl}}/misc/accounting_entries_-_apply_overpayment_on_a_sales_order_as_customer_deposit_.html)
: [Accounting  Entries - Apply Overpayment on a Sales Invoice as Customer Deposit]({{site.sp_baseurl}}/misc/accounting_entries_-_apply_overpayment_on_a_sales_invoice_as_customer_deposit.html)
