---
title: Document Details
---

# Document Details


**Include Serial Numbers**
: Check this option to print the serial numbers attached  to the inventoried line items on documents. This option is not applicable  if “Display in matrix format” is selected.


**Include Contact Address**
: Check this option to print the contact address on  the document.


**Include Tax details**
: Check this option to print the breakup of the total  tax for each tax component.


**Print Tax Component Details**
: Check this option to print the tax-component-wise  details (tax component description and value of tax) for each tax code  contained in a purchase/sale document.
: If you select this option, the **Print 
 tax component details** check box on the **Document 
 Printing Preferences** dialog box while printing documents, is selected  by default.
: The tax breakup is displayed above the “document  totals” section on the document report. If there are two or more tax components  in the document, only one tax component is displayed and printed separately.  This tax component is determined based on the sort order of the tax component  codes. The remaining tax components are grouped together and displayed  under the heading “Others”.


{:.example}
The tax charged on a sales document comprises the following tax components:


California: .25% county sales tax (CA025); California: 1% local sales  tax (CA 100); and California: 6% sales tax (CA600).


Only tax component “California: .25% county sales tax” and the respective  tax amount is displayed.


**Include Payment Details**
: Check this option to print the details of amounts  paid on the selected document.


**Exclude Hidden Items**
: Select this option to exclude hidden items from  those included on the document.


**Use Unit Prices**
: Select this option to print only the price per unit,  and exclude the measure in which the item is sold. The **Measure**  column in the printed sales/purchase document will appear blank.


**Print Everest Software copyright message as footer**
: Select this option to display the Everest Software  copyright message in the document footer.


**Currency**
: Select the currency type in which documents are  printed. The options are:

- **Print 
 in Base Currency**: Select this option to print amounts only in base  currency.
- **Print 
 in Document Currency**: Select this option to print amounts only  in document currency.
- **Print 
 in Both Base &amp; Document Currency**: Select this option to print  amounts in base and document currencies.



**Include ship to/return address**
: Check this option to print the shipping address  on the document. If this option is checked, the Include Ship/Return Address  option is checked by default in the purchase documents.


{:.note}
When the shipping address is not defined for  a purchase or purchase return document, the system prints the document’s  location address in place of the shipping address.


**Print Bar Code**
: Check this option to print the document number as  a barcode. This barcode is printed on the top right corner of the document.


**Packing Slip Format**
: Check this option to print the document in a packing  slip format. In this case, the amounts are not printed.


**Include Shipment tracking #**
: Check this option to include the Shipment Tracking#  while printing the Sales document. The shipment tracking numbers will  be printed at the end of the document, when this option is checked.  This  will allow shoppers to track packages without calling your service staff  or visiting your website.
: When you select this option, the **Shipment 
 Tracking#** check box is checked by default in the **Document 
 Printing Preferences** and **Document 
 E-mail Preferences** dialog boxes.


**Display in Matrix Format**
: Check this option to display the printed documents  in matrix format for matrix items. The line items that are part of a matrix  group will be printed in a matrix format. Printing in matrix format can  greatly reduce the amount of space/paper it takes to print out a document  with a large number of matrix items. Vendor part numbers and serial numbers  will not display if you select this option.
: When you select this option, the **Display 
 in matrix format** check box is checked by default in the **Document 
 Printing Preferences** and **Document 
 E-mail Preferences** dialog boxes.


**[]()Blind Ship**
: Blind ship is the process of shipping to your customer's  customer without providing details of the person actually shipping the  goods (i.e. you).


{:.example}
If your customer ABC wishes that you directly  ship the items to XYZ (who is ABC’s customer) without letting XYZ know  that you shipped the items, you can do so using the **Blind 
 Ship** feature.
: Use this option to enable the **Blind 
 Ship Format** option by default in the [**Document Printing Preferences** dialog  box]({{site.sp_chm}}/sales-docs/docs-profile/options/print/document_printing_preferences_dialog_box.html) for sales documents.
: Selecting this option replaces your company/location  logo and address with the customer's address and logo (ABC in the above  example) while printing the packing slip. On the packing slip, the customer’s  bill to address (ABC in the above example) is replaced by the ship to  address of the customer’s customer (XYZ in the above example).
: ![]({{site.bp_baseurl}}/img/lens.gif) [Blind  Ship]({{site.sp_chm}}/sales-docs/sales-orders/so-proc/blind-shipment/blind_shipment_sales.html)
: [Customer  Profile - Logo Tab]({{site.mc_chm}}/creating-a-customer/the-customer-profile-logo/the_customer_profile_logo_tab.html)
: You would ideally select this check box along with  the **Packing Slip Format** check  box. Otherwise the item prices would be at the price which you charge  your customer, who could be re-selling items to the end customer at a  higher value.


**Print Line Notes**
: Select this option to include inline notes when  printing documents.


**Print Vendor Part Number**
: This option allows you to print the vendor’s part  number in the purchase documents reports. It will be checked by default.  This option is not applicable if “Display in matrix format” is selected.


{:.note}
If there is no vendor part # for the item,  the label Part# will not appear in document reports.


**Print**
: Select the type of details you would like the printed  Purchase Invoice to include:

- **Invoice 
 Details** – all quantity information refers to the Invoiced quantity.
- **Receipt 
 Details** – all quantity information refers to the Received on Invoice  quantity, and the Payment Discount, Paid, and Balance fields do not display.



{:.see_also}
See also
: [Document  Print Setting Details]({{site.bp_baseurl}}/rpt-prt/prt/docs/printing_preferences_details_bp_content.html)
