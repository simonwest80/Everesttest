---
title: The Payment Details Dialog Box - Apply Credits
---

# The Payment Details Dialog Box - Apply Credits


Click the **Credits**  label  to view the **Apply Credits** tab.  This tab displays all the credit memos created for the selected customer  that have not been applied to any other document. You can specify the  credit memos that are being applied to the current document in the **Apply Credits** tab.


{:.note}
This tab is not available for Point of Sale  customers (POS\_CUST) as it is mandatory to receive full payment from them.


For regular customers, this tab is displayed  only when credits are available against the respective customer.


If you apply one document to another, a transaction is automatically  created in a receipt journal (for the amount applied). The **Payment 
 Type** field in the receipt journal defaults to the payment method  selected in the **Default payment method 
 for applied payments** field of the [**Workstation Settings** dialog box]({{site.sc_chm}}/misc/workstation_settings_stock_areas_others.html)<font style="color: #ff0000;" color="#FF0000"> </font>(path: **File 
 &gt; Setup &gt; Preferences &gt; Workstation Settings &gt; General &gt; 
 Others** tab). If a payment method is not defined in the **Workstation 
 Settings** dialog box, the payment method selected in the **Default 
 payment method for applied payments** field in the [**Accounting** dialog box]({{site.acc_chm}}/accounting-flow-control-and-defaults/accounting-defaults/accounting_miscellaneous.html) (path: **File &gt; Setup &gt; Preferences &gt; Defaults 
 &gt; Accounting &gt; Miscellaneous** tab) will be used.


The **Apply Credits** tab consist  of two sections:

- **Credit 
 Documents Available** - This panel displays all credit documents  that can be applied to the current document.
- **Credit 
 Documents Applied** - This panel displays all credit documents that  are applied to the current document.



{:.steps}
To apply a document, do the following:

- Highlight the  required document in the **Credit Documents 
 Available** section.
- Click the ![]({{site.pos_baseurl}}/img/sales_include_button.gif) icon to move the document to the **Credit 
 Documents Applied** section.
- After moving  a document, to the **Credit Documents Applied** section, you can change the amount to be applied in the **Amount**  column.



{:.note}
The amount specified to be applied is reflected  in the **Credits** field in the **General** tab of the **Payment 
 Details** dialog box.


{:.see_also}
See also
: [The  Payment Details Dialog Box]({{site.pos_baseurl}}/pos-trans/create-pos-doc/pos-receipts/payment-dlg/the_payment_details_dialog_box_pos_receipts.html)
