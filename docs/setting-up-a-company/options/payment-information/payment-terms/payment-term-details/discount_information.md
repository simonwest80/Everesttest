---
title: Discount Information
---

# Discount Information


**Everest** can automatically apply  discounts for prompt payments on documents. You may define various kinds  of discounts like N60 2% and N30 1%.


To automatically apply payment discounts on documents, select the option  **Automatically apply payment terms discounts 
 for customer/vendor document** (path: **File 
 &gt; Setup &gt; Preferences &gt; Flow Control &gt; Documents &gt; Miscellaneous 
 &gt; Document Payments** tab). When payments are made or received  on sales or purchase documents, discounts applicable are automatically  calculated and displayed in the **Discount 
 Available** and **Discount Applied**  fields of the **Receipt** dialog box  for sales invoices and the **Payment for**  dialog box for purchase invoices. You can edit the discount applied if  required.


![]({{site.sc_baseurl}}/img/lens.gif) [Payment  dialog box (for purchase)]({{site.pp_chm}}/purc-proc/pos/po-processes/payments/pmnt-dialog-box/the_payment_dialog.html)
: [Receipt  dialog box (for sales)]({{site.sp_chm}}/sales-docs/sales-orders/so-proc/pmts-refunds/pmts-on-so/rcpt-dlg/the_payment_dialog_box.html)


If you do not select the option to automatically apply discounts, the  amount of discount is merely displayed in the **Discount 
 Available** field. You must enter the amount of discount manually  in the **Discount Applied** field.


{:.note}
Discount is calculated on the document amount  and not on the payment amount.


Discounts are calculated automatically only when a payment is made/received  from a document and not from the payment or receipt journal. Discounts  are also calculated when deposits on documents, debit or credit memos  are applied to the payment.


{:.note}
Discounts are available based on the payment  terms in a Purchase Invoice and are based on the Due Date. If the vendor's  invoice number and date are entered, and the **Terms 
 from purchase invoice date** option is NOT checked, the due date  is calculated based on the vendor's invoice date and not on the purchase  invoice date. However, if the option is checked, the purchase invoice  date takes precedence over the specified vendor invoice date. If both  the fields **Vendor's Invoice Date**  and **Terms from purchase invoice date**  are cleared, the due date is based on the terms defined in the **Payment 
 Terms** profile > **Due Date Information**  section.


**Discount (%)**
: Use this option to specify the percentage of discount  for early payments.


{:.see_also}
See also
: [Discount Types]({{site.sc_baseurl}}/misc/discount_types.html)
: [**Payment Terms** profile - General tab]({{site.sc_baseurl}}/options/payment-information/payment-terms/set-up-a-payment-term/payment_terms_profile_general_tab.html)
