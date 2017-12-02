---
title: Journal in which Accounting Entries are Recorded
---

# Journal in which Accounting Entries are Recorded


The accounting entries for assembled items, defectives and scrap are  recorded in an **open** general journal  that fulfills the following conditions:

- The journal  should belong to the same accounting period as the login date.
- It should have  the same journal group as the one selected in **Workstation 
 Settings** dialog box (path: **File**  > **Setup** > **Preferences**  > **Workstation** **Settings 
 &gt; Company Settings** tab) of the user building the work order.
- It should have  the same location as the logged in location or sub-location of the user  building the work order.
- It should have  the description "Work order completed".



If no such **open** journal exists,  a new general journal is created. The number for the new journal is taken  from the sequence number specified for general journals in the logged  in location or sub-location.


![]({{site.ba_baseurl}}/img/lens.gif) [Location  profile - Accounting Tab]({{site.sc_chm}}/options/locations-and-sub-locations/set-up-locations/location_profile_accounting.html)


If the location does not have sequence numbers assigned, the sequence  numbers specified for the default location in the **Accounting**  dialog box (path: **File** > **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **Miscellaneous** tab > **Default Location** field) are used.


![]({{site.ba_baseurl}}/img/lens.gif) [Default  Location]({{site.sc_chm}}/misc/default_location.html)


{:.see_also}
See also
: [Accounting  Entries when Items are Built]({{site.ba_baseurl}}/prod-asm/building-wo/entering-qty-built/accounting-entries/accounting_entries_when_items_are_built.html)
