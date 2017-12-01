---
title: Payment Reference Details
---

# Payment Reference Details


**Batch Processing**
: This option allows you to process credit card payments  in batches. When you select this check box, the authorization of the transactions  and capturing of funds can take place later. The payment is marked for  batch processing and is transferred to [**Batch Payment Process** browser]({{site.acc_chm}}/customer-receipts-and-refunds/batch-payment-processing/batch_credit_card_process_browsers.html). These  payments can be processed at a later stage.


![]({{site.sp_baseurl}}/img/example.gif) Payments  are received through credit card for orders placed with your company.  Using this option, you can process all of them in a batch at the end of  the day instead of processing them one by one.
: This check box is displayed/hidden depending on  the preference set for documents while processing payments (path: **File &gt; Setup &gt; Preferences &gt; Flow 
 Control &gt; Documents &gt; Miscellaneous** tab **&gt; Document payments** tab **&gt; 
 Batch 
 Payments** section).


**Payment Method**
: All the payment methods set up for collections in  the **Payment Method** profile (path:  **File &gt; Setup &gt; Accounting &gt; 
 Payment Methods** > **Options**  > **Edit** > **In 
 New Window**) are available for selection in this field. The default  payment method for collections specified in the **Default****payment method for collections**  field of the **Accounting** dialog  box (path: **File &gt; Setup &gt; Preferences 
 &gt; Defaults &gt; Accounting &gt; Miscellaneous** tab) is displayed  by default in this field.
: The bank account associated with the payment method  is debited with the collection from the customer.
: ![]({{site.sp_baseurl}}/img/lens.gif) [Payment  Methods]({{site.sc_chm}}/options/payment-information/payment-methods/payment_methods.html)


**Cash Register**
: This field allows you to track the collection of  payments on a sales return document. You may receive payments (from customers)  in parts, on a credit order or memo. Using this field, you can record  each payment received on different cash registers for a single document.


{:.example}
You want to receive the first payment through  one cash register and subsequent payments through other cash registers,  thus, storing the record of each payment receipt on different cash registers.
: Specify the cash register where you want to store  the record of each payment received from the customer. By default, this  field displays the value specified in the **Default 
 Cash Register** field in the [Flow  Control Preferences]({{site.bp_chm}}/misc/registers_misc_tab_document_payments_tab_flow_control_setup.html) (path: **File &gt; 
 Setup &gt; Preferences &gt; Flow Control &gt; Documents &gt; Miscellaneous 
 &gt; Document Payments** tab). Note that this field displays only  the active cash registers (registers with status 'Available') in the drop-down  list.


**Reference/Check No**
: Use this option to specify a reference for the collection.  When the check for collection is written manually, enter the check number  in this field.
: If the payment method is of any other type, enter  the reference number for the collection.
: ![]({{site.sp_baseurl}}/img/example.gif) In  case of cash collections, enter the cash voucher number; for wire transfers,  enter the transfer reference.


**Date**
: By default, the date of the collection displays  the login date. You can specify any other date if required. This date  appears on the receipt journal.


**Approval Code**
: Enter the approval code received from the credit  card company for the credit card payment. This information must be specified  in case the credit card payments are manually processed. This field is  disabled when the credit card payment is processed online, i.e., when  the **Use** **Payment 
 Processor** option is selected in the **Payment 
 Method** dialog box (path: **File 
 &gt; Setup &gt; Accounting &gt; Payment Methods &gt; Options** >  **Edit** > **In 
 New Window** > **Credit Card Processing** tab).


**Narration**
: Click the  ![]({{site.sp_baseurl}}/img/sales_notes_button.gif) icon; you will see the **Refund 
 Comments** dialog box. You can enter a note on the transaction in  this dialog box. Select **Options &gt; 
 Save** to save and close the **Refund 
 Comments** dialog box. You can also view the narration from the **Receipt Journal** in which this transaction  is recorded.


{:.see_also}
See also
: [The  Collection Dialog Box - General]({{site.sp_baseurl}}/sales-ret-docs/cos/co-proc/collections/dlg/the_collection_dialog_box_general_tab_sales.html)
