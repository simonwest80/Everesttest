---
title: Collection Dialog Box - Apply Deposits/Refunds
---

# Collection Dialog Box - Apply Deposits/Refunds


The amount of the debit memo that can be applied as deposit on a purchase  order or as payment against a purchase invoice is displayed in this tab.


The **Apply** **Deposits**/**Refunds** tab consist of two sections:

- **Advance 
 Document Available** - This column displays open purchase orders  and all purchase invoices.
- **Advance 
 Document Applied -** The documents that are applied to the current  document are displayed in this section.



![]({{site.pp_baseurl}}/img/steps.gif)To apply a document, do the following:

- In the **General** tab of the **Collection** dialog box, enter 0 in the **Amount**  field.
- In the **Apply** **Deposits**/**Refunds** tab of the **Collection** dialog box, highlight the required document in the **Advance****Documents** **Available**  section.
- Click the **&gt;** icon to move it to the **Advance****Documents** **Applied**  section.
- After moving  a document to the **Advance** **Documents** **Applied**  section, you can change the amount to be applied in the **Amount**  column.



The amount applied cannot be greater than the amount available. The  total of amounts applied is displayed in the **Advance****Applied** field (path: **Collection**  dialog **** box > **General**  tab).


{:.note}
If you apply one document to another, a transaction  is automatically created in a payment journal (for the amount applied).  The **Payment Type** field in the  payment journal defaults to the payment method selected in the **Workstation 
 Settings** dialog box > **Default 
 Payment Method for Applied Payments** field (path: **File 
 &gt; Setup &gt; Preferences &gt; Workstation Settings**). If a payment  method is not defined in the Workstation Settings dialog box, the payment  method selected in the **Default Payment 
 Method for Applied Payments** field (path: **File 
 &gt; Setup &gt; Preferences &gt; Defaults &gt; Accounting &gt; Miscellaneous**  tab) is used.


{:.see_also}
See also
: [The  Collection Dialog Box]({{site.pp_baseurl}}/return-proc/dms/dm-processes/acpt-ref/the_payment_dialog_box_pur_returns.html)
