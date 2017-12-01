---
title: Vendor Aging Information
---
<script type="text/javascript" language="JavaScript1.2" x-save-method="compute-relative" src="{{site.pp_baseurl}}/misc/ehlpdhtm.js"></script><script type="text/javascript" language="JavaScript1.2">
<!-- 
if( typeof( kadovFilePopupInit ) != 'function' ) kadovFilePopupInit = new Function();if( typeof( kadovTextPopupInit ) != 'function' ) kadovTextPopupInit = new Function();
 //-->
</script>
This option opens the selected document.

This option brings up the [**Custom Tracking** browser]({{site.ct_chm}}/document-tracking/tracking-purchase-documents/the_custom_tracking_document_browser.html) **** for the selected document.

Select a document and then choose the **Document 
 Payment Information** option. This option allows you to view the  history of payments made on a particular document (from the list of outstanding  documents). You will see the [Payment  History browser]({{site.pp_baseurl}}/purc-proc/pos/po-processes/payments/payment-history/payment_history_pur.html). All payments made against this document including  amounts applied from or to other documents are listed.


{:.example}
If a part of the deposit made on a purchase  order has been applied to a purchase receipt, then the payment history  for the purchase receipt will display the amount applied from the purchase  order. The payment history for the purchase order will display the amount  applied towards the purchase receipt.

The **Aging** option allows you  to define different time frames for the aging analysis. The default time  blocks for an aging analysis are 1-30 days, 31-60 days, 61-90 days and  greater than 90 days.


{:.note}
You can edit only the **To**  fields.

The **Aging Chart** option allows  you to view a chart of the aging analysis.


![]({{site.pp_baseurl}}/img/lens.gif) [Browser  Options - Chart Setup]({{site.wwe_chm}}/everest-client/ui/browsers/options/chart/browser_options_chart_setup.html)

The **Print Preview** option allows  you to preview and print the documents listed in the browser. You will  see the [**Print Setup** dialog box]({{site.wwe_chm}}/everest-client/ui/browsers/options/print/the_print_setup_dialog_box.html).

# Vendor Aging Information


The **Aging** tab displays aging  information for purchase return documents that have outstanding payments  or deposits. All outstanding documents are grouped by their document type.


{:.example}
Outstanding debit memos and their aliases  are grouped under debit memos.


Amounts outstanding on debit memos are shown as negative amounts. An  aging analysis is displayed for the amounts outstanding based on the total  days outstanding. The number of days for which a document is outstanding  is calculated from the document's due date.


The available credit limit is calculated by deducting the net outstanding  amount from the credit limit. Both posted and unposted amounts are considered  while calculating available credit.


{:.example}
Your available credit with the vendor increases  by the amount on a debit memo even if the document is not posted.


Foreign Currency Vendors


In case of foreign currency vendors, all amounts are displayed in the  vendor's currency.


Browser Column Filters


You can filter for documents that match specified criteria for each  of the columns listed in the tab. Click the down arrow on the column title.  You will see a list of all the options and a list of data for the column.


{:.example}
Click on the **Document 
 #** and you will see a list of document number for all the documents  in the browser.


Click on **Custom** to set custom  filters for the browser.


![]({{site.pp_baseurl}}/img/lens.gif) [Filtering  Records Using the Column Filter]({{site.wwe_chm}}/everest-client/ui/browsers/options/filter/column-filter/filtering_records_using_the_column_filter.html)


Right-click Menu Options


The following are the right-click menu options available in the **Aging** tab:
: [Document](javascript:kadovTextPopup(this)){:id="a1"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a1');
//--></script>
: [Document Tracking](javascript:kadovTextPopup(this)){:id="a2"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a2');
//--></script>
: [Document Payment Information](javascript:kadovTextPopup(this)){:id="a3"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a3');
//--></script>
: [Aging Options](javascript:kadovTextPopup(this)){:id="a4"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a4');
//--></script>
: [Aging Chart](javascript:kadovTextPopup(this)){:id="a5"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a5');
//--></script>
: [Print Preview](javascript:kadovTextPopup(this)){:id="a6"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a6');
//--></script>


{:.see_also}
See also


[Document  Tab View Details]({{site.pp_baseurl}}/return-proc/doc-prof/contents/tabs/document_view_details_purchase_return_profile.html)
