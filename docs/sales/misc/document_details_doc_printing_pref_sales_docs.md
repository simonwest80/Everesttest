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


**Include Serial Numbers**
: Select this check box to print the serial numbers  of items attached to the document. This option is not applicable if “Display  in matrix format” is selected.


**Include Contact Address**
: Select this check box to print the customer's contact  address on the document.


**Include Ship to/Return Address**
: Select this check box to print the shipping address  on the document.


**Exclude Hidden Items**
: Select this check box to exclude hidden lines when  the document is printed.


**Packing Slip Format**
: Select this check box to print the document in a  packing slip format. In this case, the amounts are not printed. When you  select the **Blind Ship Format** check  box, this field is disabled.


**Blind Ship**
: Select this check box to replace the company/location  logo and address with the customer's address and logo while printing the  sales document. When you check this option, the output document is printed  based on the following criteria:

- If shipping  address (path: Document **** profile  > **Ship To** field) is available,  both **Customer** and **Ship 
 To** fields display the same shipping address. The customer's logo  is printed in place of the company/location logo.

: [See image](javascript:kadovTextPopup(this)){:id="a1"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a1');
//--></script>

- If shipping  address (path: Document **** profile  > **Ship To** field) is blank,  both **Customer** and **Ship 
 To** fields will be blank. The customer's logo is printed in place  of the company/location logo.

: [See image](javascript:kadovTextPopup(this)){:id="a2"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a2');
//--></script>

- If the customer  logo (path: **Customer** profile >  **Logo** tab) is blank, the customer's  billing address is printed in place of company/location logo.

: [See image](javascript:kadovTextPopup(this)){:id="a3"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a3');
//--></script>
: ![]({{site.sp_baseurl}}/img/lens.gif) [Blind  Shipment]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/blind-shipment/blind_shipment_sales.html)


**Currency**
: This drop-down list allows you to specify the currency  in which to print the document. It has the following options:

- **Print 
 in Base Currency** - Select this option to print the document in  the base currency, irrespective of the currency defined for the customer.  The **Currency** field defaults to  this option.
- **Print 
 in Document Currency** - Select this option to print the document  in the currency defined for the customer selected in the document.
- **Print 
 in both Base and Document Currency** - Select this option to print  the document in the customer's currency. However, the document and the  tax totals are displayed additionally in the base currency at the bottom  right hand side of the document.



**Include Tax Details**
: Select this option to print the breakup of the total  tax into the amounts for each tax component.


**Print Tax Component Details**
: Some countries require tax components to be displayed  individually on the sales document.
: Select this check box to print the description of  the tax components on the document, as entered in the **Description**  field of the **Tax** **Components**  profile (path: **File &gt; Setup &gt; Accounting 
 &gt; Taxes &gt; Tax Components &gt; Options &gt; Edit &gt; In New Window**).
: If there are one or two tax components on the document,  they are displayed and printed separately in the right hand corner at  the bottom, along with the other document total details. If there are  more than two tax components on the document, the first tax component  is displayed and printed separately while the remaining tax components  are grouped and displayed under the heading **Others**.
: If you do not select the **Print****Tax** **Component****Details** check box, the breakup  of the tax components on the document is not displayed. The total tax  amount is displayed and printed against the heading **Total 
 Tax**.
: This option does not apply to manual sales documents;  they display the total tax amount against the **Total 
 Tax** heading but do not display any tax components.
: This option is selected/deselected  by default based on the preference you set in the **Reporting 
 Preferences** dialog box (path: **File 
 &gt; Setup &gt; Preferences &gt; Defaults &gt; Reporting Preferences**).  You can select/deselect  this option as required.


**Include Payment Details**
: Select this check box to print the details of amounts  paid on the selected document.


**Include Shipment tracking #**
: Check this option to include the **Shipment 
 Tracking**# while printing the Sales document. When this option is  checked, shipment tracking numbers will be printed at the end of the document.  This will allow shoppers to track packages without calling your service  staff or visiting your website.


**Display in Matrix Format**
: Check this option to display the printed documents  in matrix format for matrix items. When this option is checked, line items  that are part of a matrix group will be printed in a matrix format. Printing  in matrix format can greatly reduce the amount of space/paper it takes  to print out a document with a large number of matrix items. Vendor part  numbers and serial numbers will not display if you select this option.


**Print Barcode**
: Select this check box to print the document number  as a barcode.  This barcode  is printed on the top right corner of the document.


**Print Line Notes**
: Select this check box to print any line notes associated  with the line item. You can specify line notes in the following ways:

- Directly in  the **Description/Note** column of  the document.
- In the **Extended sales description** field (path:  **Inventory &gt; Items &gt; Item** profile **&gt; Notes** tab).
- Using the **Inline Notes** option (path: document  profile > **Options**).



**Print Vendor Part Number**
: This option is not applicable for a sales document.


{:.see_also}
See also
: [Document  Printing Preferences - General Tab]({{site.sp_baseurl}}/sales-docs/docs-profile/options/print/general_tab_document_printing_preferences_dialog_box_sales_documents.html)
