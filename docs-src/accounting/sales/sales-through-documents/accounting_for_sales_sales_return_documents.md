---
title: Accounting for Sales/Sales Return Documents
---

# Accounting for Sales/Sales Return Documents


Accounting entries are made for sales and sales returns in a system  sales journal when a sales invoice or credit memo is created.


![]({{site.acc_baseurl}}/img/lens.gif) [Create  a Sales Invoice]({{site.sp_chm}}/sales-docs/sis/create-si/create-new-si/creating_a_new_sales_invoice.html)


[Create  a Credit Memo]({{site.sp_chm}}/sales-ret-docs/cms/create-cm/create-new-cm/creating_a_new_credit_memo.html)


Sales entries are entered in an **open**  system sales journal that fulfill the following conditions:

- The journal  should belong to the same accounting period as the login date.
- The journal  should have the same journal group as the one selected in the **Workstation 
 Settings** dialog box (path: **File** > **Setup** > **Preferences** > **Workstation** **Settings**) of the user creating the sales/sales return document.
- The journal  should have the same location/sub-location as the location/sub-location  to which the sales invoice/credit memo belongs.
- The journal  should have the same Accounts Receivable Control account as the current  **Accounts Receivable Control account** that  is selected in the [**Accounting**  dialog box]({{site.acc_baseurl}}/accounting-flow-control-and-defaults/accounting-defaults/the_accounting_dialog_box.html) (path: **File &gt; Setup 
 &gt; Preferences &gt; Defaults &gt; Accounting**).



If such an open journal does not exist, a new sales journal is created.  The sales journal number for the new journal is assigned from the sequence  number specified for sales journals in the login location or the parent  location of the login sub-location. If the login and document location/sub-location  are different, the location/sub-location of the new journal will be the  same as that of the document, but the sequence number for this journal  will be generated as per the login location/sub-location.


![]({{site.acc_baseurl}}/img/lens.gif) [Locations  and Sub-Locations]({{site.sc_chm}}/options/locations-and-sub-locations/locations_and_departments.html)


If sequence numbers are not defined for the login location or the parent  location of the login sub-location, the sequence number assigned to the  default location is assigned to the document. The default location is  defined in the **Accounting** dialog  box (path: **File &gt; Setup &gt; Preferences 
 &gt; Defaults &gt; Accounting &gt; Miscellaneous** tab **&gt; Default Location** field).


![]({{site.acc_baseurl}}/img/lens.gif) [Default  Location]({{site.sc_chm}}/misc/default_location.html)


{:.see_also}
See also
: [System Sales  Journals]({{site.acc_baseurl}}/sales/sales-through-documents/system-sales-journals/system_sales_journals.html)
