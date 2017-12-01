---
title: Document Details
---

# Document Details


The **Document** **Details**  section allows you to set the following options:


| **Option** | **<font style="font-family: Verdana;" face="Verdana">Select this option <br/> to:</font>** |
| Include serial numbers | Print the serial numbers of items attached to the document. The serial  numbers are printed below each item. This option is not applicable if  “Display in matrix format” is selected. |
| Include contact address | Print the contact address. |
| Include ship/return address | Print the shipping address.<br/><br/><br/>{:.note}<br/>When the shipping address is not defined for  a purchase or purchase return document, the system prints the document's  location address in place of the shipping address. |
| Exclude hidden items | Exclude hidden lines when the document is printed. |
| Packing slip format | Print the document for packing slip purposes. In this case, the amounts  are not printed. |
| Blind ship | This option is disabled for purchase and purchase return documents. |
| Include tax details | Print the breakup of the total tax (print the tax amounts for each tax  component).<br/><br/><br/>For purchase receipts, only the non-recoverable tax displays. |
| Print tax component details | Print the description of the tax component as entered in the **Description**  field of the **Tax Component** profile  (path: **File &gt; Setup &gt; Accounting <br/> &gt; Taxes &gt; Tax Components &gt; Options &gt; Edit &gt; In New Window**).  This is printed separately in the right hand corner at the bottom, along  with the other document total details.<br/><br/><br/>If there are more than two tax components, only the first tax component  is printed separately. The remaining tax components are grouped and displayed  under the heading **Others**.<br/><br/><br/>If you do not select this option, only the total tax amount is printed  against the heading **Total Tax**. |
| Include payment details | Print the details of amounts paid, amounts received, refunds made or  refunds received. |
| Include shipment tracking# | This option is disabled for purchase and purchase return documents. |
| Display in matrix format | Check this option to display the printed documents in matrix format  for matrix items. When this option is checked, line items that are part  of a matrix group will be printed in a matrix format. Printing in matrix  format can greatly reduce the amount of space/paper it takes to print  out a document with a large number of matrix items. Vendor part numbers  and serial numbers will not display if you select this option. |
| Print bar code | Print the document number as a bar code. |
| Print line notes | Print the extended purchase description, if any, associated with the  line item, below the item description. You can specify line notes in the  **Extended purchase description**  field (path: **Inventory &gt; Items &gt; <br/> Item** profile **&gt; Notes**  tab). |
| Print vendor part number | This option allows you to print the vendor’s part number in the purchase  document reports. It will be checked by default. This option is not applicable  if “Display in matrix format” is selected.<br/><br/><br/>{:.note}<br/>If there is no vendor part # for the item,  the label **Part#** will not appear  in document reports. |
| Currency | This field allows you to specify the currency in which to print the  purchase document. It has the following options:<br/><br/>- **Print <br/> in Base Currency** - Prints the document in the base currency, irrespective  of the currency defined for the vendor.<br/>- **Print <br/> in Document Currency** - Prints the document in the currency defined  for the selected vendor.<br/>- **Print <br/> in both Base and Document Currency** - Prints the document in the  currency defined for the selected vendor. However, the document and the  tax totals are displayed additionally in the base currency at the bottom  right hand side of the document. |
| Print | Specify the details to print for Purchase Invoices. This option only  applies to Purchase Invoices.<br/><br/><br/>If **Invoice Details** is selected  (default), the system prints an Invoiced column and the fields taxable,  tax, exempt, and total relate to the invoiced quantity. If **Receipt <br/> Details** is selected, the system replaces the Invoiced column with  a Received column, and the fields relate to the received on invoice quantity. |
| Sort by | Specify the sort order of line items in the document. You can sort either  by the **Item Code** or **Item <br/> Description**. Based on your selection, the line items are sorted  and printed in the ascending order.<br/><br/><br/>Choose the option **None** to print  the items in the order in which they are displayed in the document. **None** is also the default option. |



{:.see_also}
See also
: [Printing  Purchase Documents]({{site.pp_baseurl}}/purc-proc/doc-profile/doc-options/prnt-purc-docs/printing_purchase_documents.html)
: [The  Document Printing Preferences Dialog]({{site.pp_baseurl}}/purc-proc/doc-profile/doc-options/prnt-purc-docs/the_document_printing_preferences_dialog_details.html)
