---
title: Refund Dialog Box - Apply Deposits/Refunds
---

# Refund Dialog Box - Apply Deposits/Refunds


The amount of the credit memo that can be applied as a deposit on a  sales order or as a payment against a sales invoice is displayed in this  tab.


In a Credit Memo, this tab also shows deposits available on credit orders.  The credit memo can be applied to a sales invoice/sales order or the deposit  on credit order can be applied towards the credit memo.


If you apply one document to another, a transaction is automatically  created in a receipt journal (for the amount applied). The **Payment 
 Type** field in the receipt journal defaults to the payment method  selected in the **Default payment method 
 for applied payments** field of the [**Workstation Settings** dialog box]({{site.sc_chm}}/misc/workstation_settings_stock_areas_others.html)<font style="color: #ff0000;" color="#FF0000"> </font>(path: **File 
 &gt; Setup &gt; Preferences &gt; Workstation Settings &gt; General &gt; 
 Others** tab). If a payment method is not defined in the **Workstation 
 Settings** dialog box, the payment method selected in the **Default 
 payment method for applied payments** field in the [**Accounting** dialog box]({{site.acc_chm}}/accounting-flow-control-and-defaults/accounting-defaults/accounting_miscellaneous.html) (path: **File &gt; Setup &gt; Preferences &gt; Defaults 
 &gt; Accounting &gt; Miscellaneous** tab) will be used.


The **Apply Deposits/Refunds** tab  consist of two sections:

- **Advance 
 Documents Available** - All sales invoices where payments are pending  and all credit orders where an advance is paid to the customer.
- **Advance 
 Documents Applied** - The documents that are applied to the current  document are displayed in this section.



{:.steps}
To apply a document, do the following:

- In the **General** tab of the **Refund** dialog box, enter 0 in the **Amount**  field.
- In the **Apply Deposits/Refunds** tab of the **Refund** dialog box, highlight the required  document in the **Advance Documents Available**  section.
- Click the ![]({{site.sp_baseurl}}/img/sales_include_button.gif) icon to move the document to the **Advance 
 Documents Applied** section.
- After moving  a document, to the **Advance Documents 
 Applied** section, you can change the amount to be applied in the  **Amount** column.



{:.note}
- The amount applied  cannot be greater than the amount available. The total of amounts applied  is displayed in the **Advance Applied**  field in the **General** Tab.
- This tab is not enabled  while making payments from a sales order/credit order document.

- Click **OK**.



{:.see_also}
See also
: [The  Refund Dialog Box]({{site.sp_baseurl}}/sales-ret-docs/cos/co-proc/refunds/dlg/the_payment_dialog_box_refund_cm.html)
