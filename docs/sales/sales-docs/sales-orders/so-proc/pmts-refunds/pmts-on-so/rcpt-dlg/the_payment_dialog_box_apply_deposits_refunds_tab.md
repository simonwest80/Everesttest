---
title: The Receipt Dialog Box - Apply Deposits/Refunds
---

# The Receipt Dialog Box - Apply Deposits/Refunds


This tab is automatically displayed when advance documents or payments  are available for application against the document.


**The **Apply 
 Deposits/Refunds** tab allows you to specify the document payments  that are being applied to the current document. Applying documents is  setting off the amount due from the customer against any amount(s)  due by you to the customer.**


{:.note}
The **Apply 
 Deposits/Refunds** tab is only visible in sales invoices and credit  memos.


You can apply deposit to a sales invoice only  from the sales order from which it is converted and NOT any other sales  order. To apply deposit from another sales order, you require adequate  security rights; however, no security right is necessary to apply deposit  on a sales order to a receipt journal.


**The following documents/payments can be  applied against sales invoices:**

- Credit memos
- Deposit(s)  received on sales orders



If you apply one document to another, a transaction is automatically  created in a receipt journal (for the amount applied). The **Payment 
 Type** field in the receipt journal defaults to the payment method  selected in the **Default payment method 
 for applied payments** field of the [**Workstation Settings** dialog box]({{site.sc_chm}}/misc/workstation_settings_stock_areas_others.html)  (path: **File &gt; Setup &gt; Preferences 
 &gt; Workstation Settings &gt; General &gt; Others** tab). If it  is not defined in the **Workstation Settings** dialog box, the payment method selected in the **Default 
 payment method for applied payments** field in the [**Accounting** dialog box]({{site.acc_chm}}/accounting-flow-control-and-defaults/accounting-defaults/accounting_miscellaneous.html) (path: **File &gt; Setup &gt; Preferences &gt; Defaults 
 &gt; Accounting &gt; Miscellaneous** tab) will be used.


**The **Apply 
 Deposits/Refunds** tab is displayed only when there are advance documents  that can be applied to the document. This tab comprises two sections:**

- **Advance 
 Documents Available** - All documents that can be applied to the  current document are displayed in this section.
- **Advance 
 Documents Applied** - The documents that are applied to the current  document are displayed in this section.



{:.steps}
To apply a document, do the following:

- In the **General** tab of the **Receipt** dialog box, enter 0 in the **Amount**  field.
- In the **Apply Deposits/Refunds** tab of the **Receipt** dialog box, highlight the required  document in the **Advance Documents Available**  section.
- Click the ![]({{site.sp_baseurl}}/img/sales_include_button.gif) icon to move it to the **Advance 
 Documents Applied** section.
- After moving  a document to the **Advance Documents Applied** section, you can change the amount to be applied in the **Amount**  column.



{:.see_also}
See also
: [The Receipt  Dialog Box]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/pmts-refunds/pmts-on-so/rcpt-dlg/the_payment_dialog_box.html)
