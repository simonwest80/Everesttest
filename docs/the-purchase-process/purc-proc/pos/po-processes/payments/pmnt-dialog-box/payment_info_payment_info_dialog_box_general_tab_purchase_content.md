---
title: Payment Info
---

# Payment Info


Click the **Payment Info** button  to view the following information:


**Batch Processing**
: Select this check box if you want to process payments  in a batch, instead of processing the payments for each document individually.  If you select this option, the transactions will be added to, and can  subsequently be processed from the **Batch 
 Payment Processing - Others** browser.
: This check box is displayed/hidden depending on  the preference you set for processing payments (path: **File 
 &gt; Setup &gt; Preferences &gt; Flow Control &gt; Documents &gt; Miscellaneous**  tab > **Document payments** tab  > **Batch Payments** section).  You must possess adequate security rights to select this box.
: ![]({{site.pp_baseurl}}/img/lens.gif)  [Document  Payments tab- Batch Payments]({{site.bp_chm}}/misc/batch_payments_document_payments_misc_tab_flow_control_setup.html)


**Payment Method**
: This field by default displays the payment method  specified for vendors in the **Default 
 payment method for Payments** field **** (path: **File** > **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **Miscellaneous** tab). You can  select a different payment method. All the other payment methods set up  for vendors are available for selection.
: ![]({{site.pp_baseurl}}/img/lens.gif) [Payment  Terms]({{site.sc_chm}}/options/payment-information/payment-terms/payment_terms.html)
: The bank account associated with the payment method  is credited with the payment made to the vendor. If you apply an existing  debit memo to an invoice, or an existing deposit on order to a purchase  invoice, select an appropriate payment method for applying the debit memo  or deposit.
: ![]({{site.pp_baseurl}}/img/lens.gif) [Payment  Methods]({{site.sc_chm}}/options/payment-information/payment-methods/payment_methods.html)
: [Defaults  - Accounting]({{site.sc_chm}}/the-company-creation-wizard/accounting/accounting_defaults_setupco.html)


**Reference/Check No**
: Enter the reference number for the payment. In case  of a manual check, enter the check number. You will be prompted if a duplicate  check number exists for that bank. If this field is left blank, **Everest** treats it as a computerized  check.


{:.example}
For cash payments, enter the Cash Voucher  Number, for credit cards, the approval number and for wire transfers,  the transfer reference.
: ![]({{site.pp_baseurl}}/img/lens.gif) [Printing  Checks]({{site.acc_chm}}/vendor-payments-and-refunds/payment-jrnl-proc/printing-checks/printing_checks.html)


**Date**
: This field by default displays the login date. If  required, you can enter any other date or leave this field blank. If left  blank, the date entered while printing, is printed on the check. This  date cannot be earlier than the document date.


{:.example}
To issue a post-dated check, enter the check  date. In case of computerized checks, the check is printed with this date.


**Narration**
: Enter a note on the transaction. You can also view  the narration from the Payment Journal in which this transaction is recorded.


**Approval Code**
: Enter the approval code for payments made/received  through credit cards.


{:.see_also}
See also
: [Payment  Reference Details]({{site.pp_baseurl}}/purc-proc/pos/po-processes/payments/pmnt-dialog-box/payment_reference_details.html)
