---
title: Journal in which Abnormal Loss/Gain Entries are Recorded
---

# Journal in which Abnormal Loss/Gain Entries are Recorded


The accounting entries for abnormal loss/gain are recorded in an **open** general journal that fulfills the  following conditions:

- The journal  should belong to the same accounting period as the login date.
- It should have  the same journal group as the journal group selected in **Workstation 
 Settings** dialog box (path: **File**  > **Setup** > **Preferences**  > **Workstation** **Settings 
 &gt; Company Settings** tab) of the user building the work order.
- It should have  the same location as the logged in location or sub-location of the user  building the work order.
- It should have  the description "Work order completed".



If no such **open** journal exists,  a new general journal is created. The number for the new journal is taken  from the sequence number specified for general journals in the logged  in location or sub-location.


![]({{site.ba_baseurl}}/img/lens.gif) [Location  Profile - Accounting Tab]({{site.sc_chm}}/options/locations-and-sub-locations/set-up-locations/location_profile_accounting.html)


If the location does not have sequence numbers assigned, the sequence  numbers specified for the default location in the **Accounting**  dialog box (path: **File** > **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **Miscellaneous** tab > **Default Location** field) are used.


![]({{site.ba_baseurl}}/img/lens.gif) [Default  Location]({{site.sc_chm}}/misc/default_location.html)


{:.see_also}
See also
: [Accounting  Entries - Abnormal Loss/Gain]({{site.ba_baseurl}}/prod-asm/building-wo/entering-qty-built/val-fnshd-goods/accounting_entries_for_abnormal_loss_gain.html)
: [Treatment  of Abnormal Loss or Gain in Production]({{site.ba_baseurl}}/prod-asm/building-wo/entering-qty-built/val-fnshd-goods/treatment_of_abnormal_loss_gain_in_production.html)
