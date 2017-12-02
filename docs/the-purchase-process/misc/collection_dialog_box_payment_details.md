---
title: Collection Dialog Box - Payment Details
---

# Collection Dialog Box - Payment Details


The payment details available in the **Collection**  dialog box are given below:


**Batch Processing**
: This option allows you to process pending collections  in a batch, instead of processing the payments for each document individually.  When this check box is selected, the transactions are transferred to the  **Batch Payment Processing - Others**  browser (path: **Accounting &gt; Accounts 
 Payable &gt; Batch Payment Processing**). Accounting entries recording  the payment/refund are created only when these transactions are processed  from the **Batch Payment Processing - Others**  browser.


{:.example}
Refunds are made through credit card on orders  you place with your vendor. Using this option, you can process all refunds  at the end of the day in a batch instead of processing them one by one.
: This check box is displayed/hidden depending on  the preference you set for processing payments (path: **File 
 &gt; Setup &gt; Preferences &gt; Flow Control &gt; Documents &gt; Miscellaneous**  tab > **Document payments** tab  > **Batch Payments** section).  You must possess adequate security rights to select this box.
: ![]({{site.pp_baseurl}}/img/lens.gif)  [Document  Payments tab- Batch Payments]({{site.bp_chm}}/misc/batch_payments_document_payments_misc_tab_flow_control_setup.html)


**Payment Method**
: All the payment methods set up for vendors in the  **Payment Method** profile (path:  **File &gt; Setup &gt; Accounting &gt; 
 Payment Methods** > **Options &gt; 
 Edit &gt; In New Window**) are available for selection in this field.  The default payment method for vendors specified in the **Default 
 payment method for Payment** field (path: **File**  > **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **Miscellaneous** tab) is displayed  by default.
: The bank account associated with the payment method  is debited with the payment made by the vendor.
: ![]({{site.pp_baseurl}}/img/lens.gif) [Payment  Methods]({{site.sc_chm}}/options/payment-information/payment-methods/payment_methods.html)


**Reference/Check No**
: Use this option to specify a reference for the collection.  For check collections, enter the vendor's check number. For any other  payment method, enter a reference number.


{:.example}
For cash payments, enter the cash voucher  number, and for wire transfers, the transfer reference.


**Date**
: This field displays the login date, by default.  Enter any other date if required. This date appears on the payment journal.


{:.example}
If the collection check is post-dated, enter  the check date.


**Approval Code**
: Enter the approval code received from the credit  card company for the credit card payment. This information must be specified  in case the credit card payments are manually processed.


**Narration**
: Click the ![]({{site.pp_baseurl}}/img/pur_document_notes.gif) icon to view the **Payment Comments** dialog box. You can  enter a note on the transaction. Select **Options 
 &gt; Save** to save and close this dialog box. You can also view  this narration from the payment journal where the transaction is recorded.


{:.see_also}
See also
: [The  Collection Dialog Box]({{site.pp_baseurl}}/return-proc/dos/do-processes/collection-payment/the_collection_dialog_box_pur_ret.html)
