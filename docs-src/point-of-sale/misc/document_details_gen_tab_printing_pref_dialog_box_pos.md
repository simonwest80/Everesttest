---
title: Document Details
---

# Document Details


**Print using quick report**
: Check this option if you want sales and credit documents  to be printed using quick reports. Quick reports enable faster printing  of document reports over a network on a laser printer. Leave this box  unchecked if you want to print documents using Crystal Reports.


{:.note}
If this check box is selected, the **Display 
 in matrix format** check box is automatically disabled.


**Company Information**
: The **Company Information**  field allows you to select the address and logo to be printed. Click [here]({{site.pos_baseurl}}/misc/printing_company_information_doc_details_gen_tab_printing_prefs_pos.html)  for the options.
: The address and logo of the location of the document’s  sub-location (path: **File &gt; Setup &gt; 
 Accounting &gt; Location/ Sub-Location &gt; Options &gt; Edit &gt; In 
 New Window &gt;** **Image** tab)  are printed. If the address/logo is not assigned to the document's sub-location,  the address/logo specified in the **Default 
 Location** field (path: **File &gt; 
 Setup &gt; Preferences &gt; Defaults &gt; Accounting &gt; Miscellaneous** tab) is used.
: ![]({{site.pos_baseurl}}/img/lens.gif) [The  Location Profile - Image]({{site.sc_chm}}/options/locations-and-sub-locations/set-up-locations/location_profile_-_image.html)


**Billing Address**
: This field allows you to indicate how the billing  address must be printed in the document. You can select one of the following  options:

- **Full 
 (with Telephone/Fax numbers)** - Print the customer's billing address  with telephone and fax numbers.
- **Mail/Envelope 
 Purpose** - Print the customer's billing address without telephone  number.



**Printer**
: The **Printer**  option allows you to specify the printer to which the print job is to  be directed. All printers set up on your workstation are listed for selection.


**Copies**
: Specify the number of copies to be printed for the  document.


Document Details


**Include Serial Numbers**
: Select this check box to print the serial numbers  of items attached to the document. This option is not applicable if “Display  in matrix format” is selected.


**Include Contact Address**
: Select this check box to print the contact address  on the document.


**Include Ship/Return Address**
: Select this check box to print the shipping address  on the document.


**Exclude Hidden Items**
: Select this check box to exclude hidden lines when  the document is printed.


**Packing Slip Format**
: Select this check box to print the document in a  packing slip format. In this case, the amounts are not printed. When you  select the **Blind Ship** check box,  this field is disabled.


**Blind Ship**
: Select this check box if you want to replace the  company/location logo and address with the customer's address and logo  while printing the sales document.


**Use Unit Prices**
: If this option is selected, then per unit price  is printed in the **Price** column.  The measure information is not printed.


{:.note}
The **Quantity** column will remain  same irrespective of whether the price printed is a unit price or not.


{:.example}
Suppose you order for a dozen eggs costing $12 ($1 each).  When you select the above option, the **Price**  column will display $1 which is the price/unit. If this option is not  selected, the **Price** column displays  the total price for the dozen.


**Currency**
: This drop-down list allows you to specify the currency  in which to print the Point of Sale (sales invoice) document. It has the  following options:

- **Print 
 in Base Currency** - Select this option to print the document in  the base currency, irrespective of the currency defined for the customer.  The **Currency** field defaults to  this option.
- **Print 
 in Document Currency** - Select this option to print the document  in the currency defined for the customer selected in the document.
- **Print 
 in both Base and Document Currency** - Select this option to print  the document in the currency defined for the customer selected in the  document. However, the document and the tax totals are displayed additionally  in the base currency at the bottom right hand side of the document.



**Include Tax Details**
: Select this check box to print the breakup of the  total tax into the amounts for each tax component.


**Print Tax Component Details**
: Some countries require tax components to be displayed  individually on the sales document.
: Select this check box to print the description of  the tax components, as entered in the **Description**  field of the **Tax** **Components**  profile (path: **File** > **Setup** > **Accounting**  > **Taxes** > **Tax****Components** > **Options**  > **Edit** > **In****New** **Window**).
: If there are one or two tax components on the document,  they are displayed and printed separately in the right hand corner at  the bottom, along with the other document total details. If there are  more than two tax components, the first tax component is displayed and  printed separately while the remaining tax components are grouped and  displayed under the heading **Others**.
: If you do not select the **Print 
 Tax Component Details** check box, the breakup of the tax components  on the document will not be displayed. The total tax amount will be displayed  and printed against the heading **Total 
 Tax**.
: This option is selected/deselected by default based  on the preference you set in the **Reporting 
 Preferences** dialog box (path: **File**  > **Setup** > **Preferences**  > **Defaults** > **Reporting 
 Preferences**). You can select/deselect this option as required.


**Include Payment Details**
: Select this check box to print the details of amounts  paid on the selected document.


**Include Shipment Tracking#**
: Check this option to include the Shipment Tracking#  while printing the Sales document. When this option is checked, shipment  tracking numbers will be printed at the end of the document.  This  will allow shoppers to track packages without calling your service staff  or visiting your website.


**Display in Matrix Format**
: Check this option to display the printed documents  in matrix format for matrix items. When this option is checked, line items  that are part of a matrix group will be printed in a matrix format. Printing  in matrix format can greatly reduce the amount of space/paper it takes  to print out a document with a large number of matrix items. Vendor part  numbers and serial numbers will not display if you select this option.


**Print Barcode**
: Select this check box to print the document number  as a barcode. This barcode is printed on the top right corner of the document.


**Print Line Notes**
: Select this check box to print any line notes associated  with the line item. You can specify line notes in the following ways:

- Directly in  the **Description/Note** column of  the document.
- In the **Extended sales description** field (path:  **Inventory** > **Items**  > **Item** profile > **Notes**  tab)
- Using the **Inline Notes** option (path: Document  profile > **Options**).



**Print Vendor Part Number**
: This option is disabled for point of sales documents.


**Sort by**
: Select the sort option for printing line items in  the document. You can sort either by **Item 
 Code** or **Item Description**.  Based on your selection, the line items will be sorted and printed in  the ascending order.


{:.see_also}
See also
: [The  Document Printing Preferences Dialog Box - Printing Preferences]({{site.pos_baseurl}}/misc/the_document_printing_preferences_dialog_box_general_pos.html)
