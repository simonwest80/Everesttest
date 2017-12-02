---
title: Payment Dialog Box - Payment Details
---

# Payment Dialog Box - Payment Details


This section allows you to specify the payment details for the debit  order.


**Batch Processing**
: This option allows you to process payments in a  batch. When you select this check box, the transactions are transferred  to the **Batch Payment Processing - Others**  browser (path: **Accounting &gt; Accounts 
 Payable &gt; Batch Payment Processing**). Accounting entries recording  the payment/refund are created only when these transactions are processed  from the **Batch Payment Processing - Others**  browser.
: This check box is displayed/hidden depending on  the preference you set for processing payments (path: **File 
 &gt; Setup &gt; Preferences &gt; Flow Control &gt; Documents &gt; Miscellaneous**  tab > **Document payments** tab  > **Batch Payments** section).  You must possess adequate security rights to select this box.
: ![]({{site.pp_baseurl}}/img/lens.gif)  [Document  Payments tab- Batch Payments]({{site.bp_chm}}/misc/batch_payments_document_payments_misc_tab_flow_control_setup.html)


**Payment Method**
: All the payment methods set up for vendors in the  **Payment Method** profile (path:  **File &gt; Setup &gt; Accounting &gt; 
 Payment Methods** > **Options &gt; 
 Edit &gt; In New Window**) are available for selection in this field.  The method specified in the **Default payment 
 method for Payment** field (path: **File**  > **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **Miscellaneous** tab) is displayed,  by default.
: The bank account associated with the payment method  is credited with the payment made to the vendor.
: ![]({{site.pp_baseurl}}/img/lens.gif) [Payment  Methods]({{site.sc_chm}}/options/payment-information/payment-methods/payment_methods.html)


**Reference/Check No**
: Specify a reference for the payment. For check payments,  enter the check number. To issue a computerized check, leave the check  number blank. For any other payment method, enter the reference number  for the payment.


{:.example}
For cash payments, enter the cash voucher  number, and for wire transfers, the transfer reference.


**Date**
: This field displays the login date by default. Enter  any other date if required. This date appears on the payment journal.  If the check date is left blank, and you are issuing a computerized check,  the payment date considered is the date entered in the **Check 
 Printing** dialog box.


{:.example}
If the check is post-dated, enter the check  date.


**Approval Code**
: Use this field to enter the approval code received  from the credit card company for the credit card payment. You must specify  this information in case the credit card payments are manually processed.


**Narration**
: Click the ![]({{site.pp_baseurl}}/img/pur_document_notes.gif) icon to view the **Refund Comments** dialog box. You can  enter additional details on the transaction. Select **Options 
 &gt; Save** to save and close the dialog box. You can also view the  narration in the payment journal where this transaction is recorded.


{:.see_also}
See also
: [The  Payment Dialog Box]({{site.pp_baseurl}}/return-proc/dos/do-processes/collection-payment/the_payment_dialog_box_debit_order.html)
