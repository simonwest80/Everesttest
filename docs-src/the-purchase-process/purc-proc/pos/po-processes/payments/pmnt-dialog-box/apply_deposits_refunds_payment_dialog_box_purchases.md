---
title: Apply Deposits/Refunds
---

# Apply Deposits/Refunds


The **Apply** **Deposits**/**Refunds** tab allows you to specify the  document payments applied to the current document. Applying documents  is setting off the amount due to the vendor against any amount(s) due  by the vendor to you.


{:.note}
The **Apply 
 Deposits/Refunds** tab is only visible in purchase invoices and debit  memos.


The following documents can be applied against purchase invoices:

- Debit memos
- Deposit(s) made  on purchase orders



The **Apply** **Deposits**/**Refunds** tab is displayed only if there  are deposits/debit memos available to be applied to the vendor. This tab  comprises two sections:

- **Advance 
 Document Available** - The **Advance****Documents** **Available**  column displays all debit memos with a balance and all deposits available  with the vendor.
- **Advance 
 Document Applied** - All advance documents that you apply to the  current document are displayed in this column. Use the **&gt;**  and **&gt;&gt;** buttons to move the  available documents from the **Advance 
 Documents Available** column to this column. You can change the amount  being applied to the purchase invoice by editing the **Amount**  column.



![]({{site.pp_baseurl}}/img/steps.gif)To apply a document, do the following:

- In the **General** tab of the **Payment**  dialog box, enter 0 in the **Amount**  field.
- In the **Apply** **Deposits**/**Refunds** tab of the **Payment****dialog** box, highlight the required  document in the **Advance** **Documents** **Available**  section.
- Click the **&gt;** icon to move it to the **Advance****Documents** **Applied**  section.
- After moving  a document to the **Advance** **Documents** **Applied**  section, you can change the amount to be applied in the **Amount**  column.



{:.note}
The amount applied cannot be greater than  the amount available. The total of amounts applied is displayed in the  **Advance** **Applied**  field (path: **Payment for** dialog **** box > **General**  tab).


If you apply one document to another, a transaction  is automatically created in a payment journal (for the amount applied).  The **Payment Type** field in the  payment journal defaults to the payment method selected in the **Workstation 
 Settings** dialog box > **Default 
 Payment Method for Applied Payments** field (path: **File 
 &gt; Setup &gt; Preferences &gt; Workstation Settings**). If a payment  method is not defined in the **Workstation 
 Settings** dialog box, the payment method selected in the **Default 
 Payment Method for Applied Payments** field (path: **File 
 &gt; Setup &gt; Preferences &gt; Defaults &gt; Accounting &gt; Miscellaneous**  tab) will be used.


{:.see_also}
See also
: [Payment  Dialog Box]({{site.pp_baseurl}}/purc-proc/pos/po-processes/payments/pmnt-dialog-box/the_payment_dialog.html)
