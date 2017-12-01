---
title: The Purchase Receipts Browser
---

# The Purchase Receipts Browser


The **Purchase** **Receipts**  browser (path: **Purchasing** >  **Purchase** **Receipts**)  lists all the purchase receipts that have been created.


This browser contains the options common to all purchase document browsers.
: ![]({{site.pp_baseurl}}/img/lens.gif)[Standard  Browser Options]({{site.wwe_chm}}/everest-client/ui/browsers/standard_browser_options.html)


Filter records based on date


The **Dates** field in the **Purchase** **Receipts** browser enables you to filter purchase receipts based on their  creation date. By default, the browser displays all documents created  during the period specified in the **Select 
 the default date option based on which the records will be displayed in 
 the purchase browser** option (path: **File 
 &gt; Setup &gt; Preferences &gt; Flow Control &gt; Documents &gt; Prompts 
 &gt; Purchase Document** tab).


![]({{site.pp_baseurl}}/img/lens.gif) [Filter  Purchase Receipts Based on Dates]({{site.pp_baseurl}}/purc-proc/purchase-document-browser/filter_purchase_documents_based_on_dates_common_browser_options_purchase_browser.html)


In addition, the browser has the following options:

- Process  > Uninvoiced Orders

: Use this option to convert multiple purchase receipts  into a single purchase invoice. From the list of open purchase receipts,  select the orders of interest then process them from the Options menu.  A new purchase invoice opens with the chosen receipts that processes only  line items/orders that are fully received.


{:.note}
Lines items that are linked to sales documents  are included only if they have been fully received.
: All of the receipts must use the same Accrued Purchases  account. If your selection includes different accounts, the system gives  you an error message and does not incorporate any receipts into the purchase  invoice. You must select again making sure to choose orders using the  same Accrued Purchases account. (The Accrued Purchases Account column  is available in the field chooser of the browser.)
: All of the receipts must also use the same FOB type.  If they do not, the system prompts that only receipts with FOB type matching  the FOB type of the first selected record will get converted.
: When you convert multiple purchase receipts into  a single purchase invoice, the system indicates that the add-on costs  do not carry into the invoice. You must manually enter the add-on cost  details into the **Add-on Costs Distribution**  Screen of the new purchase invoice if you continue with the conversion.  You may close the new invoice without saving if you do not want to continue  the conversion.
: When you convert multiple receipts into one purchase  invoice, information does not copy into the following tabs of the **Purchase Invoice** profile:

- History
- Multimedia
- Custom Fields
- Document Tasks
- Document Tracking


- [Serial  Number History]({{site.pp_baseurl}}/misc/serial_number_history_pur_rec_browser_options.html)
- [Print  Options]({{site.pp_baseurl}}/misc/print_options_pur_rec_browser_options.html)


- [Print  Serial Numbers]({{site.pp_baseurl}}/misc/print_serial_numbers_pur_browser_options_pur_con.html)
- [Print  Put Away Report]({{site.pp_baseurl}}/misc/print_put_away_report_pr_pi_browser_option_pur.html)
- Print Document


- [Payment  Information]({{site.pp_baseurl}}/misc/payment_information_pur_rec_browser_options.html)
- [Journal  Transactions]({{site.pp_baseurl}}/misc/the_journal_transactions_browser_common_purchase_profile_docs_info.html)
- [Purchase  Document Browser Options]({{site.pp_baseurl}}/purc-proc/purchase-document-browser/purchase_document_browser_options.html)
- [View  Options]({{site.pp_baseurl}}/misc/view_options_purchase_reciept_browser.html)

