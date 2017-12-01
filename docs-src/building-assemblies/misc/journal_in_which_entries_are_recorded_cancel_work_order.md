---
title: Journal in Which Entries are Recorded
---

# Journal in Which Entries are Recorded


The accounting entries when an ‘In Process’  work order is cancelled are recorded in an **open**  general journal that fulfills the following conditions:

- The journal  should belong to the same accounting period as the login date.
- The journal  should have the same journal group as the one selected in **Workstation 
 Settings** dialog box (path: **File**  > **Setup** > **Preferences**  > **Workstation** **Settings 
 &gt; Company Settings** tab) of the user canceling the work order.
- The journal  should have the same location as the logged in location or sub-location  of the user canceling the work order.
- The journal  should have the description "Cancelled Work Order".



If no such **open** journal exists,  a new general journal is created. The number for the new journal is taken  from the sequence number specified for general journals in the logged  in location or sub-location.


![]({{site.ba_baseurl}}/img/lens.gif) [Location  Profile - Accounting Tab]({{site.sc_chm}}/options/locations-and-sub-locations/set-up-locations/location_profile_accounting.html)


If the location does not have sequence numbers assigned, the sequence  numbers specified for the default location in the **Accounting**  dialog box (path: **File** > **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **Miscellaneous** tab > **Default Location** field) is used.


![]({{site.ba_baseurl}}/img/lens.gif) [Default  Location]({{site.sc_chm}}/misc/default_location.html)


{:.see_also}
See also
: [Accounting  Entry - Cancel Work Order]({{site.ba_baseurl}}/prod-asm/cancelling-wo/accounting_entries_cancel_a_work_order_work_order_profile_options_process_assembly_content.html)
: [Cancel  a Work Order]({{site.ba_baseurl}}/prod-asm/cancelling-wo/cancel_a_work_order_work_order_profile_options_process_cancel_assembly.html)
