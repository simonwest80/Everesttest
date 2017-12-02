---
title: Document Details
---

# Document Details


By default, the fields in this section display the preferences set in  the **Reporting 
 Preferences** dialog box (path: **File 
 &gt; Setup &gt; Preferences &gt; Defaults &gt; Reporting Preferences**).


**Include Serial Numbers**
: Select this check box if you want the serial numbers  of items attached to the document to be displayed. This option is not  applicable if “Display in matrix format” is selected.


**Include Contact Address**
: Select this check box if you want the contact address  to appear on the document<font style="font-family: Verdana;" face="Verdana">.</font>


**Include Ship/Return Address**
: Select this check box if you want the return address  to appear on the document.


{:.note}
When the shipping address is not defined for  a purchase or purchase return document, the system prints the document's  location address in place of the shipping address.


**Exclude Hidden Items**
: Select this check box to exclude hidden lines on  the document.


**Packing Slip Format**
: Select this check box if you want the document to  be in the packing slip format. In this case, the amounts are not printed.


**Include Tax Details**
: Select this check box to display the tax component-wise  breakup of the total tax.


**Print Tax Component Details**
: Select this check box to display the description  of the tax components on the document, as entered in the **Description**  field of the **Tax** **Components**  profile (path: **File &gt; Setup &gt; Accounting 
 &gt; Taxes &gt; Tax Components &gt; Options &gt; Edit &gt; In New Window**).
: Up to two tax component details are displayed along  with the other document total details. If there are more than two tax  components on the document, the first tax component is displayed separately  while the remaining tax components are grouped and displayed under the  heading **Others**.
: If you do not select the **Print****Tax** **Component****Details** check box, the total tax  amount is displayed against the heading **Total 
 Tax**.


**Include Payment Details**
: Select this check box to display the details of  amounts paid on the selected document.


**Display in Matrix Format**
: Check this option to display the printed documents  in matrix format for matrix items. When this option is checked, line items  that are part of a matrix group will be printed in a matrix format. Printing  in matrix format can greatly reduce the amount of space/paper it takes  to print out a document with a large number of matrix items. Vendor part  numbers and serial numbers will not display if you select this option.


**Print Barcode**
: Select this check box to display the document number  as a barcode.  This bar code is printed on the top right corner of the document.


**Print Line Notes**
: Check this box to display the extended purchase  description, if any, associated with the line item, below the item description.  You can specify line notes in the **Extended 
 purchase description** field (path: **Inventory 
 &gt; Items &gt; Item** profile > **Notes**  tab).


**Print Vendor Part Number**
: This option allows you to print the vendor’s part  number in the purchase document reports. It will be checked by default.  This option is not applicable if “Display in matrix format” is selected.


{:.note}
If there is no vendor part# for the item,  the label **Part#** will not appear  in document reports.


**Currency**
: Specify the currency in which document amounts must  be displayed. It has the following options:

- **Print 
 in Base Currency** - Displays document amounts in the base currency,  irrespective of the currency defined for the vendor.
- **Print 
 in Document Currency** - Displays document amounts in the vendor  currency.
- **Print 
 in both Base and Document Currency** - In addition to displaying  document amounts in the vendor currency, the document and the tax totals  are also displayed in the base currency (at the bottom right hand side  of the document).



**Sort By**
: Specify the sort order of line items in the document.  You can sort either by the **Item Code**  or **Item Description**. Based on  your selection, the line items are sorted and printed in the ascending  order.


{:.see_also}
See also
: [Document  E-mail Preferences Dialog Box]({{site.pp_baseurl}}/purc-proc/doc-profile/doc-options/email-purc-docs/document_e_mail_preferences_dialog_box_email_common_pur_doc_options.html)
