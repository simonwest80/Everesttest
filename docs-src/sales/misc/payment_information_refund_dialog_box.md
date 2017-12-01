---
title: Payment Details
---

# Payment Details


**Batch Processing**
: This option allows you to process credit card refunds  in batches. When the check box is selected, the authorization of the transactions  and capturing of funds takes place later. The refund is marked for batch  processing and is transferred to [**Batch Payment Process** browser]({{site.acc_chm}}/customer-receipts-and-refunds/batch-payment-processing/batch_credit_card_process_browsers.html). These  refunds can be processed at a later stage.
: Refunds are made through credit card on orders placed  with your company. Using this option, you can process all of them at the  end of the day in a batch instead of processing them one by one.
: This check box is displayed/hidden depending on  the preference set for documents while processing payments (path: **File &gt; Setup &gt; Preferences &gt; Flow 
 Control &gt; Documents &gt; Miscellaneous** tab **&gt; Document payments** tab **&gt; 
 Batch 
 Payments** section).


**Payment Method**
: All the payment methods set up for customers are  available for selection in this field. The default payment method for  customers specified in the **Default payment 
 method for collections**<font style="font-family: Verdana;" face="Verdana"> </font>field of the **Accounting** dialog box (path: **File &gt; Setup 
 &gt; Preferences &gt; Defaults &gt; Accounting &gt; Miscellaneous** tab)  is displayed by default in this field. You can select a different payment  method.
: The bank account associated with the payment method  is credited with the payment made to the customer.
: ![]({{site.sp_baseurl}}/img/lens.gif) [Payment  methods]({{site.sc_chm}}/options/payment-information/payment-methods/payment_methods.html)


**Cash Register**
: This field allows you to track the refund of payments  on a sales document. Sometimes, there may be instances where you may have  to refund payments to customers in parts on a sales order or invoice.  Using this field, you can store the record for each refund you make on  different cash registers for a single document.


{:.example}
You want to make the first refund through  one cash register and subsequent refunds through other cash registers,  thus, storing the record of each refund on different cash registers.
: Specify the cash register where you want to store  the record of each refund to the customer. By default, this field displays  the value specified in the **Default Cash 
 Register** field in the [Flow  Control Preferences]({{site.bp_chm}}/misc/registers_misc_tab_document_payments_tab_flow_control_setup.html) (path: **File &gt; 
 Setup &gt; Preferences &gt; Flow Control &gt; Documents &gt; Miscellaneous 
 &gt; Document Payments** tab). It should also be noted that this  field displays only the active cash registers (registers with status as  'Available') in the drop-down list.


**Reference/Check No.**
: Use this option to specify a reference for the refund.  When the payment method is a check type of payment, and you refund the  amount using a manual check, enter the check number here. This number  appears in the receipt journal.
: Where the payment method is of any other type of  payment, enter a suitable reference.
: ![]({{site.sp_baseurl}}/img/example.gif) In  case of cash payments, you can enter the cash voucher number, or for wire  transfers, the transfer reference.


**Date**
: The date of the payment displays the login date  by default. You can specify any other date if required. This date appears  on the receipt journal.
: ![]({{site.sp_baseurl}}/img/example.gif) If  you make the payment using a post-dated check, enter the date of the check  in this field.


**Approval Code**
: Enter the approval code received from the credit  card company for the credit card payment in this field. This information  must be specified in case the credit card payments are manually processed.  This field is disabled when the credit card payment is processed online.


**Narration**
: Use this option to enter a note for the transaction.  Click on the ![]({{site.sp_baseurl}}/img/sales_notes_button.gif) icon, you will see **Refunds 
 Comments** dialog box. The narration can also be viewed from the  **Receipt Journal** in which this  transaction is recorded.


**Amount**
: This is the amount of payment that you are making  to the customer. You cannot make a payment for an amount that is greater  than the amount received from a customer.
: ![]({{site.sp_baseurl}}/img/example.gif) If  the value of an order is $1000 and you have received $600 from the customer,  then the maximum amount that can be refunded is $600.
: If you make a refund to a foreign currency customer,  you cannot enter an amount in this field. In this case, use the **Prior Payments** tab to specify the amount  of refund.


{:.see_also}
See also
: [The  Refund Dialog Box - General]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/pmts-refunds/refunds-on-so/the_refund_dialog_box_general_sales.html)
