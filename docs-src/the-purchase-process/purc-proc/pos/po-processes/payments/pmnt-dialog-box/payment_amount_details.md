---
title: Payment Amount Details
---

# Payment Amount Details


**Document Amount**
: This field displays the total value of the document.  You cannot edit this field.


**Already Paid**
: This field displays the amount that is already paid  on the document. In case of orders, it displays the amount of deposit  that is not applied to any other document. For purchase invoices, it displays  the amount paid on the invoice and deposits applied to it. The amount  paid includes both posted payments and un-posted payments. You cannot  edit this field.
: Click the **Already 
 Paid** label to view the **Payment 
 History**.


**Amount**
: Enter the amount being paid to the vendor. By default  the **Amount** field displays the  balance amount payable on the document. You cannot pay an amount that  is greater than the value of the purchase order or purchase invoice.


{:.example}
If the value of an order is $1000 and you  have already paid $600, the maximum amount you can pay is $400.


**Advance Applied**
: This field displays the amount of deposits and debit  memos applied to a purchase invoice during the current payment process.  You cannot edit this field.
: Click the **Advance 
 Applied** label to view the [**Apply Deposit/Refunds** tab]({{site.pp_baseurl}}/purc-proc/pos/po-processes/payments/pmnt-dialog-box/apply_deposits_refunds_payment_dialog_box_purchases.html).


**Discount Available**
: Discounts may be available for prompt payment based  on the payment terms for the purchase invoice. This field displays discount  calculated for the current payment. Discounts are calculated only on purchase  invoices.
: Number of days for computing discount is calculated  from the check date to due date. If the date is blank, the database server  date is used. You cannot edit this field.
: ![]({{site.pp_baseurl}}/img/lens.gif)<font style="color: #008000;" color="#008000"> </font>[Payment  Terms - Discount Information]({{site.sc_chm}}/options/payment-information/payment-terms/payment-term-details/discount_information.html)


{:.note}
This field is not enabled for refund on a debit memo.


**Discounts Applied**
: Enter the amount of available discount that is claimed  for this document. You can set a flow control preference to automatically  apply discounts by selecting the **Automatically****apply** **payment****terms** **discount****for** **vendor****document** option (path: **File**  > **Setup** > **Preferences**  > **Flow** **Control**  > **Documents** > **Miscellaneous**  > **Document** **Payments**  tab).
: The **Payment Discount 
 for Purchases** account is credited with this payment discount.
: ![]({{site.pp_baseurl}}/img/lens.gif)  [Accounting  Entries - New Payment on a Purchase Invoice]({{site.pp_baseurl}}/purc-proc/pis/pi-processes/payments/accounting-entries/accounting_entries_new_pr.html)
: The total discount applied is displayed in the **Payment** **Discounts**  field of the **Purchase Invoice** profile.


{:.note}
Discounts are calculated and displayed only if the payment  is made from a document. If you make a payment from a payment journal,  then the available discounts are not displayed.


If the payment entry, having a payment discount, is  deleted, the amount of discount is reduced from the total payment discount  on the purchase invoice.


![]({{site.pp_baseurl}}/img/lens.gif) [Flow  Control - Document Payments]({{site.bp_chm}}/flow-ctrl/ctrl/doc-frm/misc/document_payments_business_process_contents.html)


**Total Paid**
: This field displays the total amount paid on the  document. This is the sum of the amount already paid, the amount currently  being paid and the advance applied less the discount applied. This amount  cannot be greater than the document value. You cannot edit this field.


**Balance**
: This field displays the balance remaining to be  paid on the purchase order/invoice. You cannot edit this field.


{:.see_also}
See also
: [Payment  Dialog Box - General]({{site.pp_baseurl}}/purc-proc/pos/po-processes/payments/pmnt-dialog-box/the_payment_for_dialog_box_general_tab_purhcase.html)
