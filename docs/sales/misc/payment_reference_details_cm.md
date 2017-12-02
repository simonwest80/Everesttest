---
title: Payment Reference Details
---

# Payment Reference Details


Payment Details


**Batch Processing**
: This option allows you to process credit card refunds  in batches. When the check box is selected, the authorization of the transactions  and capturing of funds takes place later. The refund is marked for batch  processing and is transferred to [**Batch Payment Process** browser]({{site.acc_chm}}/customer-receipts-and-refunds/batch-payment-processing/batch_credit_card_process_browsers.html). These  refunds can be processed at a later stage.
: ![]({{site.sp_baseurl}}/img/example.gif) Refunds  are made through credit card on orders placed with your company. Using  this option, you can process all of them at the end of the day in a batch  instead of processing them one by one.
: This check box is displayed/hidden depending on  the preference set for documents while processing payments (path: **File &gt; Setup &gt; Preferences &gt; Flow 
 Control &gt; Documents &gt; Miscellaneous** tab **&gt; Document payments** tab **&gt; 
 Batch 
 Payments** section).


**Payment Method**
: All the payment methods set up for customers in  the **Payment Method** profile (path:  **File &gt; Setup &gt; Accounting &gt; 
 Payment Methods** > **Options &gt; 
 Edit &gt; In New Window**) are available for selection in this field.  The default payment method for customers specified in the **Default****payment method for collections**  field of the **Accounting** dialog  box (path: **File &gt; Setup &gt; Preferences 
 &gt; Defaults &gt; Accounting &gt; Miscellaneous** tab) is displayed  by default in this field.
: The bank account associated with the payment method  is credited with the payment made to the customer.
: ![]({{site.sp_baseurl}}/img/lens.gif) [Payment  Methods]({{site.sc_chm}}/options/payment-information/payment-methods/payment_methods.html)


**Cash Register**
: This field allows you to track the refund of payments  on a sales return document. Sometimes, there may be instances where you  may have to refund payments to customers in parts on a credit order or  memo. Using this field you can store the record for each refund you make  on different cash registers for a single document.


{:.example}
You want to make the first refund through  one cash register and subsequent refunds through other cash registers,  thus, storing the record of each refund on different cash registers.
: Specify the cash register where you want to store  the record of each refund  to  the customer. By default, this field displays the value specified in the  **Default Cash Register** field in  the [Flow  Control Preferences]({{site.bp_chm}}/misc/registers_misc_tab_document_payments_tab_flow_control_setup.html) (path: **File &gt; 
 Setup &gt; Preferences &gt; Flow Control &gt; Documents &gt; Miscellaneous 
 &gt; Document Payments** tab). It should also be noted that this  field displays only the active cash registers (registers with status as  'Available') in the drop-down list.


**Reference/Check No**
: Use this option to specify a reference for the payment.  When you write the refund check manually, enter the check number in this  field.
: To issue a computerized check, leave the check number  blank. Where the payment method is any other type of payment, enter the  reference number for the payment.
: ![]({{site.sp_baseurl}}/img/example.gif) In  case of cash payments, you can enter the cash voucher number, or for wire  transfers, the transfer reference.


**Date**
: By default, the date of the payment displays the  login date. You can specify any other date if required. This date appears  on the receipt journal. If the check date is left blank, and you are issuing  a computerized check, then the payment date considered is the date entered  in the [**Check 
 Printing** dialog box]({{site.acc_chm}}/misc/check_printing_dialog.html).


**Approval Code**
: Use this field to enter the approval code received  from the credit card company for the credit card payment. This information  must be specified in case the credit card payments are manually processed.  This field is disabled when the credit card payment is processed online.  This field is disabled when the credit card payment is processed online,  i.e., when the **Use** **Payment 
 Processor** option is selected in the **Payment 
 Method** profile (path: **File &gt; 
 Setup &gt; Accounting &gt; Payment Methods** > **Options 
 &gt; Edit &gt; In New Window &gt;** **Credit 
 Card Processing** tab).


**Narration**
: Click this ![]({{site.sp_baseurl}}/img/sales_notes_button.gif) icon, you will see the  **Payment Comments** dialog box. You  can enter a note on the transaction. Select **Options 
 &gt; Save** to save and close the **Payment 
 Comments** dialog box. The narration can also be viewed from the  **Receipt** **Journal**  in which this transaction is recorded.


{:.see_also}
See also
: [Refund  Dialog Box - General]({{site.sp_baseurl}}/sales-ret-docs/cms/cm-proc/refunds-on-cm/refund-dlg/the_payment_dialog_box_general_refund_cm.html)
