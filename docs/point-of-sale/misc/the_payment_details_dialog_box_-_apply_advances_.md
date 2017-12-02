---
title: The Payment Details Dialog box - Apply Advances
---

# The Payment Details Dialog box - Apply Advances 


Click the **Advance Applied**  label  to view the **Apply Advances** tab.  This tab displays all the deposits that have been received from the selected  customer that have not been applied to any other document. You can specify  the deposits that are being applied to the current document in the **Apply Advances** tab.


{:.note}
This tab is not available for Point of Sale  customers (POS\_CUST) as it is mandatory to receive full payment from them.


For regular customers, this tab is displayed  only when deposits are available against the respective customer.


If you apply one document to another, a transaction is automatically  created in a receipt journal (for the amount applied). The **Payment 
 Type** field in the receipt journal defaults to the payment method  selected in the **Default payment method 
 for applied payments** field of the [**Workstation Settings** dialog box]({{site.sc_chm}}/misc/workstation_settings_stock_areas_others.html)  (path: **File &gt; Setup &gt; Preferences 
 &gt; Workstation Settings &gt; General &gt; Others** tab). If it  is not defined in the **Workstation Settings** dialog box, the payment method selected in the **Default 
 payment method for applied payments** field in the [**Accounting** dialog box]({{site.acc_chm}}/accounting-flow-control-and-defaults/accounting-defaults/accounting_miscellaneous.html) (path: **File &gt; Setup &gt; Preferences &gt; Defaults 
 &gt; Accounting &gt; Miscellaneous** tab) will be used.


The **Apply 
 Deposits/Refunds** tab is displayed only when there are advance documents  that can be applied to the document. This tab comprises two sections:

- **Advance 
 Documents Available** - This panel displays all the advance documents  that can be applied to the current document.
- **Advance 
 Documents Applied** - This panel displays the advances applied to  the current document.



{:.steps}
To apply a document, do the following:

- Highlight the  required document in the **Advance Documents 
 Available** section.
- Click the ![]({{site.pos_baseurl}}/img/sales_include_button.gif) icon to move it to the **Advance 
 Documents Applied** section.
- After moving  a document to the **Advance Documents Applied** section, you can change the amount to be applied in the **Amount**  column.



{:.note}
The amount specified to be applied is reflected  in the **Advance Applied** field in  the **General** tab of the **Payment 
 Details** dialog box.


{:.see_also}
See also
: [The  Payment Details Dialog Box]({{site.pos_baseurl}}/pos-trans/create-pos-doc/pos-receipts/payment-dlg/the_payment_details_dialog_box_pos_receipts.html)
