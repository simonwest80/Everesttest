---
title: Sales Journal for Credit Memos
---

# Sales Journal for Credit Memos


The accounting entries for returns are entered in a **Sales 
 Journal** that fulfills the following conditions:

- The journal  should belong to the same accounting period as the login date.
- The journal  should have the same journal group as the journal group selected in **Workstation Settings** of the user entering  the sales return.
- The journal  should have the same location as the logged in location or sub-location  of the user creating the credit memo.
- The journal  should have the same account for Accounts Receivable Control as the current  Accounts Receivable Control account selected in the **Accounting** dialog box (path: **File &gt; Setup 
 &gt; Preferences &gt; Defaults &gt; Accounting &gt; Control Accounts** tab).



If no such **open** journal exists,  a new sales journal is created. The sales journal number for the new journal  is taken from the sequence number specified for sales journals in the  logged in location or sub-location.


![]({{site.sp_baseurl}}/img/lens.gif) [Locations  and Sub-Location]({{site.sc_chm}}/options/locations-and-sub-locations/locations_and_departments.html)


If the location of the login sub-location does not have sequence numbers  assigned, the sequence number specified for the default location is used.


![]({{site.sp_baseurl}}/img/lens.gif) [Default  Location]({{site.sc_chm}}/misc/default_location.html)


{:.see_also}
See also
: [System  Journals]({{site.acc_chm}}/accounting-structure-in-everest/journals/system_journals.html)
