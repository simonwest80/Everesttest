---
title: Sales Journal for Sales Invoices
---

# Sales Journal for Sales Invoices


The accounting entries for sales are entered in an 'open' system **Sales Journal** that fulfills the following  conditions:

- The journal  should belong to the same accounting period as the login date.
- The journal  should have the same journal group as the journal group selected in **Workstation Settings** dialog box (path: **File &gt; Setup &gt; Preferences &gt; Workstation 
 Settings**) **** of the user entering  the sales/sales return.
- The journal  should have the same location/sub-location as the login location/sub-location  of the user creating the sales invoice.



If no such **open** journal exists,  a new sales journal is created. The sales journal number for the new journal  is taken from the sequence number specified for sales journals in the  logged in location or sub-location.


![]({{site.sp_baseurl}}/img/lens.gif) [Locations  and Sub-Location]({{site.sc_chm}}/options/locations-and-sub-locations/locations_and_departments.html)


If the location does not have sequence numbers assigned, the sequence  numbers specified for the default location is used.


![]({{site.sp_baseurl}}/img/lens.gif) [Default  location]({{site.sc_chm}}/misc/default_location.html)


{:.see_also}
See also
: [System  Journals]({{site.acc_chm}}/accounting-structure-in-everest/journals/system_journals.html)
