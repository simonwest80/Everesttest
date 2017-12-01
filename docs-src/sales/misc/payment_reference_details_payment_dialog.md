---
title: Payment Reference Details
---

# Payment Reference Details


Payment Details


**Batch Processing**
: Select this check box to process credit card receipts  in a batch. Address and CVV2 verification is also carried out when you  process credit card transactions using this option. If you select this  option, the credit card transactions are added to, and subsequently processed  from the [**Batch Payment Process** browser]({{site.acc_chm}}/customer-receipts-and-refunds/batch-payment-processing/batch_credit_card_process_browsers.html).
: This check box is displayed/hidden depending on  the preference set for documents while processing payments (path: **File &gt; Setup &gt; Preferences &gt; Flow 
 Control &gt; Documents &gt; Miscellaneous** tab **&gt; Document payments** tab **&gt; 
 Batch 
 Payments** section).


**Payment Method**
: All the payment methods set up for customers are  available for selection in this field. The default payment method for  customers specified in the **Default payment 
 method for collections** field of the **Accounting**  dialog box (path: **File &gt; Setup &gt; 
 Preferences &gt; Defaults &gt; Accounting &gt; Miscellaneous** tab)  is displayed by default in this field.


{:.note}
A modification made to the default **Payment 
 Method** profile (path: **File &gt; 
 Setup &gt; Accounting &gt; Payment Methods** browser **&gt; Edit &gt; In New Window**) overrides the setting in the default  preferences.


![]({{site.sp_baseurl}}/img/example.gif) You have set Cash as the  default payment method for collections in the **Accounting**  dialog box. In the **Payment Method**  profile for cash, you change the **Used 
 For** field from Collections to Payments. When you create a sales  document and invoke the **Receipt**  dialog box to accept payment, the drop-down from the **Payment 
 Method** field does not display Cash. In other words, you are not  allowed to use the default payment method.
: The bank account associated with the payment method  is debited with the deposit/payment received from the customer. If you  are applying an existing credit memo to the sales order or an invoice,  or an existing deposit to a sales invoice, select an appropriate payment  method for applying the credit memo or deposit.
: ![]({{site.sp_baseurl}}/img/lens.gif) [Payment  Methods]({{site.sc_chm}}/options/payment-information/payment-methods/payment_methods.html)


**Cash Register**
: This field allows you to track the receipt of payments  on a sales document. There may be instances where you receive payments  in parts on a sales order or invoice. Using this field, you can store  the record for each payment received on different cash registers for a  single document.


{:.example}
You want to receive the first payment through  one cash register and subsequent payments through other cash registers,  thus, storing the record of each payment receipt on different cash registers.
: Specify the cash register where you want to store  the record of each payment received from the customer. By default, this  field displays the value specified in the **Default 
 Cash Register** field in the [Flow  Control Preferences]({{site.bp_chm}}/misc/registers_misc_tab_document_payments_tab_flow_control_setup.html) (path: **File &gt; 
 Setup &gt; Preferences &gt; Flow Control &gt; Documents &gt; Miscellaneous 
 &gt; Document Payments** tab). Note that this field displays only  the active cash registers (registers with status as 'Available') in the  drop-down list.


**Reference/Check No**
: Use this option to specify a reference for the payment.  When you receive a check from the customer you can enter the check number  here. This number appears in the receipt journal.
: Where the payment method is any other type of payment,  enter a suitable reference.
: ![]({{site.sp_baseurl}}/img/example.gif) In  case of cash payments, enter the cash voucher number; for wire transfers,  enter the transfer reference.


**Date**
: This field displays the login date by default. You  can specify any other date of payment. This date appears on the receipt  journal.
: ![]({{site.sp_baseurl}}/img/example.gif) If  you receive a post-dated check, enter the check date.


**Approval Code**
: Enter the approval code received from the credit  card company. This information must be specified in case the credit card  payments are manually processed. This field is disabled when the credit  card payment is processed online.


**Narration**
: Enter a note for the transaction. The narration  can also be viewed from the **Receipt****Journal** in which this transaction  is recorded.


{:.see_also}
See also
: [Payment  Dialog Box - General]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/pmts-refunds/pmts-on-so/rcpt-dlg/the_payment_dialog_box_general.html)
