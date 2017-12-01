---
title: Purchase Document Tracking (Group) Dialog Box
---

# Purchase Document Tracking (Group) Dialog Box


Select the following parameters to view the **Purchase Doc****ument Tracking (Group)**  report.


**Group**
: Specify the tracking group code. The report displays  a list of purchase documents tagged to any tracking choice defined for  the selected group.


**Document Type**
: Specify the type of documents to be included in  the report.

- Purchase Quote
- Purchase Order
- Purchase Receipt
- Purchase Invoice
- Debit Quote
- Debit Order
- Debit Memo



**Sort By**
: Select this option to sort the information in the  report by the **Document number** or  the **Tracking Group**.


{:.note}
By default this report is sorted by the **Document**. ****


**Document Date From**
: Specify the start date for the documents to be included  in the report. The document date indicates the date of creation.


**Document Date To**
: Specify the end date for the documents to be included  in the report. The document date indicates the date of creation.


{:.note}
If **Document 
 Date From** and **Document Date To** fields are left blank, by default the current system date appears  in these fields.


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


**Location/Sub-location**
: Select the location or sub-location for which you  want the report to be generated. If this field is left blank, the purchase  documents for all locations or sub-locations are included in the report.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Drop-Down  List - Right-Click Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html)


**Tag Date From**
: Specify the start tag date in this field. The tag  date indicates the date of assigning the documents to a tracking selection.


**Tag Date To**
: Specify the end tag date in this field. The tag  date indicates the date of assigning the documents to a tracking selection.


**Schedule Date From**
: Select the start schedule in this field. The schedule  date is the date when the purchase document was initial tagged. Subsequently,  when the document was processed, the tag was transferred across documents.


**Schedule Date To**
: Select the end date for which you want to generate  the report when a document was initially tagged and further processed.


{:.note}
If the **Schedule 
 Date From** and **Schedule Date To**  fields are left blank, the current system date will be included in the  report.


**Sales Representative**
: Specify the name of the user (purchase representative)  assigned to the documents, to generate a report of purchase documents  by purchase representative.


{:.note}
If the **Sales 
 Representative** field is left blank, the selected documents for  all sales representatives are included in the report.


**Show Memos**
: Select this check box to include the notes attached  to the tracking choice in the report.


{:.see_also}
See also
: [Purchase  Document Tracking (Group Report)]({{site.rpt_baseurl}}/everest-reports/purchasing/purchase_doc_tracking_group_report_.html)
: [Purchasing]({{site.rpt_baseurl}}/everest-reports/purchasing/purchasing_reports.html)
