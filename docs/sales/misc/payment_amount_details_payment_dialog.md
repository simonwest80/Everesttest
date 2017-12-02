---
title: Payment Amount Details
---

# Payment Amount Details


**Document Amount**
: The document amount is the total value of the document.  This is a display field.


**Already Paid**
: This is the amount that has already been paid. In  case of orders, this amount is the deposit received against the order;  for sales invoices, the amount already paid on the document is displayed  in this field. The already paid amount also includes deposits that have  been applied to the sales invoice. Receipts whose journal have or have  not been posted are included. This is a display field.
: Click the **Already 
 Paid** label to view the **Payment 
 History**.
: ![]({{site.sp_baseurl}}/img/lens.gif) [Payment  History]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/pmts-refunds/payment-history/payment_history.html)


**Amount**
: Enter the amount that you receive from the customer.  By default, the balance amount receivable on the document displays.
: You can receive on a sales order or sales invoice  an amount greater than the value of the sales order or invoice. In this  case, the **Overpayment 
 Dialog Box** appears. It also appears when you convert a sales  order with a negative balance to a sales invoice because the sales invoice,  as a final document, cannot have a negative balance.
: The Overpayment dialog box offers several options  for the overpaid amount. You may return it to the customer, apply the  overpayment as a deposit towards future sales to this customer, or leave  the amount as a negative balance on the sales order.
: If you choose to return/refund it to the customer,  the system creates a refund entry in the Receipt Journal.
: If you apply the overpayment as a customer deposit,  the system credits the amount of overpayment to the Customer Deposit Account  specified in the Customer Deposit field (path: **File**  > **Setup** > **Accounting**  > **Posting Group** profile) of  the Customer Posting Group and generates a manual document for the customer.
: If you choose to leave the negative balance on the  sales order, the sales order retains the negative balance. When making  an overpayment on a sales invoice, the negative balance applies to the  sales order you converted into the sales invoice. In the case of a sales  invoice created directly, the sales invoice itself will retain the negative  balance. This is the only case which allows a sales invoice to carry a  negative balance.


{:.note}
You may not make an overpayment for batch  processing.


**Advance Applied**
: For sales orders, the advance applied displays the  total amount of credit memos applied to the sales order. For sales invoices,  the advance applied displays the total amount of deposits and credit memos  applied to a Sales Invoice. This is a display field.
: Click the **Advance 
 Applied** label to view the [**Apply Deposit/Refunds** tab]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/pmts-refunds/pmts-on-so/rcpt-dlg/the_payment_dialog_box_apply_deposits_refunds_tab.html).


**Discount Available**
: [Discounts]({{site.sc_chm}}/options/payment-information/payment-terms/payment-term-details/discount_information.html)  may be available for prompt payment based on the payment terms. Whether  a payment is eligible for discount depends on the discount type and login  date when recording the payment. The discount available for the current  payment is calculated and displayed in this field. Discounts are calculated  only on sales invoices.


{:.example}
A document's payment terms indicates that a payment  receipt is due 60 days after the invoice date, and a discount of 2% is  allowed for payments made within 30 days. The settings in the **Payment 
 Terms** profile are as follows:


1. **Due Date Type**  is "Specified days from invoice" (for 60 days)


2. **Discount Type**  is "Specified days from invoice" (for 30 days)


You create the sales invoice on 15th September and you  receive payment from the customer on 15th October. Since payment is made  on the 30th day from the date of invoice creation, two percent of the  document amount is displayed as the amount of discount available.
: The discount applied is not accounted for at the  time of capture in either of the following cases:

- You select  the batch payment processing check box.
- You receive  payment through credit card and select the transaction type as "Pre  authorization" or "Use prior authorization".

: You have to account for this discount manually.


**[]()Discount Applied**
: Discounts applied refer to the amount of the available  discount that is to be claimed for this document. The total discount applied  is displayed in the **Trade Discount** field  on the document profile.
: You can set the following flow control preference  in the **Documents** dialog box: **Automatically apply payment terms discounts 
 for customer document** option<font style="font-family: Verdana;" face="Verdana"> </font>(path: **File 
 &gt; Setup &gt; Preferences &gt; Flow Control &gt; Documents &gt; Miscellaneous 
 &gt; Document Payments**).


{:.note}
Discounts are calculated and displayed only if the receipt  is accounted from a document. If you create a receipt from a receipt journal,  the available discounts are not displayed.
: ![]({{site.sp_baseurl}}/img/lens.gif) [Document  Payments - Flow Control Settings]({{site.bp_chm}}/flow-ctrl/ctrl/opt/misc/miscellaneous_document_payments_step_by_step_business_process_in_everest.html)


**Total Paid**
: The total amount paid on the document is the sum  of the following:

- Amount already  paid.
- The amount  yet to be paid by your customer.
- The advance  applied less the discount applied.

: This amount cannot be greater than the document  value. This is a display field.


**Balance**
: The balance amount remaining to be received on the  sales order / invoice is displayed in this field. This is a display field.  If overpayment is done, this field changes to 'Overpaid', which displays  the excess payment made.


{:.see_also}
See also
: [Payment  Dialog Box - General]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/pmts-refunds/pmts-on-so/rcpt-dlg/the_payment_dialog_box_general.html)
