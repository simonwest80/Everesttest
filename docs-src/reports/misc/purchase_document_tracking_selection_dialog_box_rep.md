---
title: Purchase Document Tracking (Selection) Dialog Box
---

# Purchase Document Tracking (Selection) Dialog Box


Select the following parameters to view the **Purchase Doc****ument Tracking (Selection)**  report.


**Group**
: Specify the tracking group code for purchase documents,  to be generated in this report.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Drop-Down  List - Right-Click Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html)


**Tracking Selection**
: Specify the Tracking Selection to be included in  the report.


{:.note}
The drop-down list does NOT display any tracking  selection records if you do not select a tracking group in the **Group** field. The report is therefore generated for purchase documents  that are tagged to this tracking selection.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Drop-Down  List - Right-Click Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html)


**Document Type**
: Specify the document type to be included in the  report.

- Purchase Quote
- Purchase Order
- Purchase Receipt
- Purchase Invoice
- Debit Quote
- Debit Order
- Debit Memo



**Document Status**
: Specify the document status of the debit orders  to be included in the report.

- **All**  - includes all debit orders in the report
- **Back 
 order** - includes only debit orders with a back order status
- **Open**  - includes only open debit orders
- **Closed**  - includes only closed debit orders

: This field is enabled only when you select Debit  Order in the **Document Type** field.


**Received Status**
: Specify the received status of the documents to  be included in the report.

- **Not 
 received** –displays purchase orders that have no items received
- **Partially 
 received** – displays purchase orders that have some items received
- **Not 
 fully received** – displays purchase orders that have no items received  and those with some items received
- **Fully 
 received** – displays purchase orders that have all items fully received
- **All 
 orders** – displays all purchase orders regardless of received status

: This field is enabled only when you select Purchase  Order in the **Document Type** field.


**Invoiced Status**
: Specify the invoiced status of the documents to  be included in the report.

- **Not 
 invoiced** – displays purchase orders that have no items invoiced
- **Partially 
 invoiced** – displays purchase orders that have some items invoiced
- **Not 
 fully invoiced** – displays purchase orders that have no items invoiced  and those with some items invoiced
- **Fully 
 invoiced** – displays purchase orders that have all items fully invoiced
- **All 
 orders** – displays all purchase orders regardless of invoiced status

: This field is enabled only when you select Purchase  Order in the **Document Type** field.


{:.note}
The **Document 
 Status**, **Received Status**,  and **Invoiced Status** fields are  enabled only when you select Purchase Order or Debit Order in the **Document Type** field.


**Location/Sub-Location**
: Specify the location/sub-location name to be included  in the report. If this field is not selected, the purchase document tracking  details for all locations/sub-locations are included in the report.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Drop-Down  List - Right-Click Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html)


**Document Date From**
: Specify the start date for documents to be included  in the report. The date indicates the date of creation of the document.


**Document Date To**
: Specify the end date for documents to be included  in the report. The date indicates the date of creation of the document.


{:.note}
If the **Document 
 Date From** and the **Document Date 
 To** fields are left blank, the current system date appears in these  fields by default.


**Tag Date From**
: Specify the start tag date in this field. The tag  date indicates the date of assigning the documents to a tracking selection.


**Tag Date To**
: Specify the end tag date in this field. The tag  date indicates the date of assigning the documents to a tracking selection.


{:.note}
If the **Tag 
 Date From** and the **Tag Date To**  fields are left blank, the current system date appears in these fields  by default.


{:.see_also}
See also
: [Purchase  Document Tracking (Selection)]({{site.rpt_baseurl}}/everest-reports/purchasing/purchase_doc_tracking_selection_.html)
: [Purchasing]({{site.rpt_baseurl}}/everest-reports/purchasing/purchasing_reports.html)
