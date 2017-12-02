---
title: Back End Processes - Processing Finance Charges
---

# Back End Processes - Processing Finance Charges


The back end processes that occur when finance charges are processed  are:

- A sales invoice  is created to account for the finance charges - one for each customer.  The document created is a manual document and bears the prefix **MFIN**.  You can view the document in the sales invoices browser.
- The sequence  number for the document is taken from the sequence number specified for  **Finance Charges #** in the logged  in location or sub-location (path: **File 
 &gt; Setup &gt; Accounting &gt; Location/Sub-Location&gt;** From  the **Location/Sub-Location** browser,  highlight the required location and select **Options**  > **Edit** > **In 
 New Window/In Current Window** > **Location**  profile **&gt; Invoicing** tab).



**![]({{site.sp_baseurl}}/img/lens.gif) [Locations  and Sub-Location]({{site.sc_chm}}/options/locations-and-sub-locations/locations_and_departments.html)**


**If no sequence number is specified for  the location, the sequence number specified for the default **** location is considered.**


**![]({{site.sp_baseurl}}/img/lens.gif) [Default  Location]({{site.sc_chm}}/misc/default_location.html)**


{:.see_also}
See also
: [Accounting  Entries - Processing Finance Charges]({{site.sp_baseurl}}/sales-docs/finance-charges/processing-finance-charges/accounting_entries_processing_finance_charges.html)
