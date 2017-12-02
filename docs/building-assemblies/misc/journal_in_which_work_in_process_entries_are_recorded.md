---
title: Journal in Which Work In Process Entries are Recorded
---

# Journal in Which Work In Process Entries are Recorded


The accounting entries when a work order’s status changes to ‘In Process’  are recorded in an **open** general  journal that fulfills the following conditions:

- The journal  should belong to the same accounting period as the login date.
- The journal  should have the same journal group as the journal group selected in **Workstation Settings** dialog box (path:  **File** > **Setup**  > **Preferences** > **Workstation****Settings &gt; Company Settings** tab)  of the user changing the work order’s status to "In Process".
- The journal  should have the same location as the logged in location or sub-location  of the user changing the work order status to ‘In Process’.
- The journal  should have the description "Work In Process".



If no such **open** journal exists,  a new general journal is created. The general journal number for the new  journal is taken from the sequence number specified for general journals  in the logged in location or sub-location.


![]({{site.ba_baseurl}}/img/lens.gif) [Location  Profile - Accounting Tab]({{site.sc_chm}}/options/locations-and-sub-locations/set-up-locations/location_profile_accounting.html)


If the location does not have sequence numbers assigned, the sequence  numbers specified for the default location is used. The default location  is mentioned in the **Accounting**  dialog box (path: **File** > **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **Miscellaneous** tab > **Default Location** field).


![]({{site.ba_baseurl}}/img/lens.gif) [Default  Location]({{site.sc_chm}}/misc/default_location.html)


{:.see_also}
See also
: [Accounting  Entries - Work in Process]({{site.ba_baseurl}}/prod-asm/work-in-proc/accounting_entries_process_work_orders_work_order_profile_assembly_content.html)
