---
title: Document Details
---
<script type="text/javascript" language="JavaScript1.2" x-save-method="compute-relative" src="{{site.sp_baseurl}}/misc/ehlpdhtm.js"></script><script type="text/javascript" language="JavaScript1.2">
<!-- 
if( typeof( kadovFilePopupInit ) != 'function' ) kadovFilePopupInit = new Function();if( typeof( kadovTextPopupInit ) != 'function' ) kadovTextPopupInit = new Function();
 //-->
</script>
![]({{site.sp_baseurl}}/img/doc_printing_blindship_ship_addr_available.gif)

![]({{site.sp_baseurl}}/img/doc_printing_blindship_ship_addr_blank.gif)

![]({{site.sp_baseurl}}/img/doc_printing_blindship_cust_logoblank.gif)

# Document Details


**Include serial numbers**
: Select this check box if you want the serial numbers  of items attached to the document to appear in the e-mail  you send. This option is not applicable if “Display in matrix format”  is selected.


**Include contact address**
: Select this check box if you want the contact address  to appear on the document you send as an e-mail.


**Include ship/return address**
: Select this check box if you want the shipping address  to appear on the document you send as an e-mail.


**Exclude hidden items**
: Select this check box if you want to exclude hidden  lines on the document you send as an e-mail.


**Packing slip format**
: Select this check box if you want the document to  be in a packing slip format. In this case, the amounts are not printed.  When you select the **Blind Ship Format**  check box, this field is disabled.


**Blind Ship Format**
: Select this check box if you want to replace the  company/location logo and address with the customer's address and logo  on the sales document. When you check this option, the output document  is displayed based on the following criteria:

- If shipping  address (path: Document **** profile  > **Ship To** field) is available,  both **Customer** and **Ship 
 To** fields display the same shipping address. The customer's logo  is displayed in place of company/location logo.

: [See image](javascript:kadovTextPopup(this)){:id="a1"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a1');
//--></script>

- If shipping  address (path: Document **** profile  > **Ship To** field) is blank,  both **Customer** and **Ship 
 To** fields will be blank. The customer's logo is displayed in place  of company/location logo.

: [See image](javascript:kadovTextPopup(this)){:id="a2"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a2');
//--></script>

- If the customer  logo (path: **Customer** profile >  **Logo** tab) is blank, the customer's  billing address is displayed in place of company/location logo.

: [See image](javascript:kadovTextPopup(this)){:id="a3"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a3');
//--></script>
: ![]({{site.sp_baseurl}}/img/lens.gif) [Blind  Shipment]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/blind-shipment/blind_shipment_sales.html)


**Currency**


You can choose the currency the sales document has to appear in, while  sending the document by e-mail  to the customer. It has the following options:

- **Print 
 in Base Currency** - Select this option if you want the document  that you send by e-mail,  to be in the base currency, irrespective of the currency defined for the  customer. The **Currency** field defaults  to this option.
- **Print 
 in Document Currency** - Select this option if you want the document  that you send by e-mail,  to be in the currency defined for the customer selected in the document.
- **Print 
 in both Base and Document Currency** - Select this option if you  want the document that you send by e-mail,  to be in the currency defined for the customer selected in the document.  However, the document and the tax totals are displayed additionally in  the base currency at the bottom right hand side of the document.



**Include tax details**
: Select this check box if you want to display the  break up of the total tax into the amounts for each tax component, in  the sales document.


**Print tax component details**
: Some countries require tax components to be displayed  individually on the sales document.
: Select this check box if you want to display the  description of the tax components on the document, as entered in the **Description** field of the **Tax****Components** profile (path: **File &gt; Setup &gt; Accounting &gt; Taxes 
 &gt; Tax Components &gt; Options &gt; Edit &gt; In New Window**).
: If there are one or two tax components on the document,  they will be displayed separately in the right hand corner at the bottom,  along with the other document total details. If there are more than two  tax components on the document, the first tax component will be displayed  separately while the remaining tax components will be grouped and displayed  under the heading **Others**.
: If you do not select the **Print****Tax** **Component****Details** check box, the break up  of the tax components on the document will not be displayed. The total  tax amount will be displayed against the heading **Total 
 Tax**.
: This option is selected/deselected  by default based on the preference you set in the **Reporting 
 Preferences** dialog box (path: **File 
 &gt; Setup &gt; Preferences &gt; Defaults &gt; Reporting Preferences**).  You can select/deselect  this option as required.


**Include payment details**
: Select this check box to display the details of  amounts paid on the selected document.


**Shipment Tracking #**
: Check this option to include the **Shipment 
 Tracking**# while printing the Sales document. When this option is  checked, shipment tracking numbers will be printed at the end of the document.   This will  allow shoppers to track packages without calling your service staff or  visiting your website.


**Display in Matrix Format**
: Check this option to display the printed documents  in matrix format for matrix items. When this option is checked, line items  that are part of a matrix group will be printed in a matrix format. Printing  in matrix format can greatly reduce the amount of space/paper it takes  to print out a document with a large number of matrix items. Vendor part  numbers and serial numbers will not display if you select this option.


**Print Barcode**
: Select this check box to display the document number  as a barcode.  This barcode  is printed on the top right corner of the document.


**Print line notes**
: Select this check box to attach any line notes associated  with the line item. This will appear in the document attached with the  e-mail. You can specify line notes:

- Directly in  the **Description/Note** column of  the document.
- In the **Extended sales description** field (path:  **Inventory &gt; Items &gt; Item** profile **&gt; Notes** tab).
- Using the **Inline Notes** option (path: document  profile > **Options**).



**Print Vendor Part Number**
: This option is not applicable for a sales document.


{:.see_also}
See also
: [Document  E-mail Preferences  - General]({{site.sp_baseurl}}/sales-docs/docs-profile/options/email/document_e_mail_preferences_dialog_box_general_sales_docs.html)
