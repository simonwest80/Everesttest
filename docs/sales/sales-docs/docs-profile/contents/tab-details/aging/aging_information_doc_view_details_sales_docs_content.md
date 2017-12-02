---
title: Customer Aging Information
---
<script type="text/javascript" language="JavaScript1.2" x-save-method="compute-relative" src="{{site.sp_baseurl}}/misc/ehlpdhtm.js"></script><script type="text/javascript" language="JavaScript1.2">
<!-- 
if( typeof( kadovFilePopupInit ) != 'function' ) kadovFilePopupInit = new Function();if( typeof( kadovTextPopupInit ) != 'function' ) kadovTextPopupInit = new Function();
 //-->
</script>
Select a document and then choose the **Document**  option from the right-click menu. This option will open the document you  have selected.

Select a document and then choose the **Document 
 Payment Information** option. This option allows you to view the  history of payments made on a particular document (from the list of outstanding  documents). You will see the [**Payment 
 History** browser]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/pmts-refunds/payment-history/payment_history.html). All payments made against this document including  amounts applied from or to other documents are listed.


**![]({{site.sp_baseurl}}/img/example.gif) If part  of a deposit on a sales order has been applied to a sales invoice, then  the payment history for the sales invoice will display the amount applied  from the sales order and the payment history for the sales order will  display the amount applied towards the sales invoice.**

Select **Aging Options** to define  different time frames for the aging analysis. **You 
 will see the** **Aging 
 Options** **dialog box. The default 
 time-blocks for an aging analysis are 1-30 days, 31-60 days, 61-90 days 
 and greater than 90 days.**


{:.note}
You can edit only the **To**  fields in the **Aging Options** dialog  box.

The **Aging Chart** option allows  you to view a chart of the aging analysis.


![]({{site.sp_baseurl}}/img/lens.gif) [Browser  Options - Chart Setup]({{site.wwe_chm}}/everest-client/ui/browsers/options/chart/browser_options_chart_setup.html)

The **Print Preview** option allows  you to preview and print the documents listed in the browser. You will  see the [**Print Setup** dialog box]({{site.wwe_chm}}/everest-client/ui/browsers/options/print/the_print_setup_dialog_box.html).

# Customer Aging Information


The **Aging** tab displays aging  information for sales documents that have outstanding payments or deposits.  All outstanding documents are grouped by their document type.


**![]({{site.sp_baseurl}}/img/example.gif) Outstanding  sales invoices and its aliases are grouped under sales invoices.**


Deposits outstanding on sales orders or amounts outstanding on credit  memos are displayed as negative amounts. An aging analysis is displayed  for the outstanding amounts based on the total days outstanding. The number  of days for which a document is outstanding is calculated from the document's  due date.


The available credit is checked against the effective balance and the  customer is put on automatic hold, if the effective balance is over the  credit limit.


Effective Balance = Net Balance (in customer currency) + Amount of deposit  available on system sales orders with "Prepay" and "COD"  terms (in customer currency).


Available Credit =  Credit Limit - Effective Balance


In case of foreign currency customers, all amounts are displayed in  the customer's currency even if the deposit on a sales order is received  in a different currency.


Browser Column Filters


You can filter for documents that match specified criteria for each  of the columns listed in the tab. Click the down arrow on the column title.  You will see a list of all the options and a list of data for the column.


![]({{site.sp_baseurl}}/img/example.gif) Click  on the **Document #** and you will  see a list of document number for all the documents in the browser.


Click on **Custom** to set custom  filters for the browser.


![]({{site.sp_baseurl}}/img/lens.gif) [Filtering  Records Using the Column Filter]({{site.wwe_chm}}/everest-client/ui/browsers/options/filter/column-filter/filtering_records_using_the_column_filter.html)


Right-Click Menu Options


The following are the right-click menu options available in the **Aging** tab:

- [Document](javascript:kadovTextPopup(this)){:id="a1"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a1');
//--></script>
- [Document Payment Information](javascript:kadovTextPopup(this)){:id="a2"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a2');
//--></script>
- [Aging Options](javascript:kadovTextPopup(this)){:id="a3"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a3');
//--></script>
- [Aging Chart](javascript:kadovTextPopup(this)){:id="a4"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a4');
//--></script>
- [Print Preview](javascript:kadovTextPopup(this)){:id="a5"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a5');
//--></script>



{:.see_also}
See also
: [Document  Tab View Details]({{site.sp_baseurl}}/sales-docs/docs-profile/contents/tab-details/document_view_details_sales_doc_contents.html)
