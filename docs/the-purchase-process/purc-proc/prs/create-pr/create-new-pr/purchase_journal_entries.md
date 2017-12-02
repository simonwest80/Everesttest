---
title: Purchase Journal Entries
---

# Purchase Journal Entries


Purchase receipts are recorded in an 'open' system purchase journal  that fulfills the following conditions:

- A journal whose  accounting period corresponds to the login date.
- A journal with  the same journal group as the one selected in the Workstation Settings  of the user creating the purchase receipt.
- A journal with  the same location/sub-location as the login location/sub-location of the  user creating the purchase receipt.
- A journal with  the same account for Accrued Purchases Control as the Accrued Purchases  Control account selected in the Accrued Purchases field (path: File >  Setup > Accounting > Posting Group profile) of Vendor Posting Group.



If no such 'open' journal exists, a new purchase journal is created.  The purchase journal number for the new journal is taken from the sequence  number for purchase journals for the logged in location/sub-location.


![]({{site.pp_baseurl}}/img/lens.gif) [Location]({{site.sc_chm}}/options/locations-and-sub-locations/locations_and_departments.html)


If this number is not assigned, the sequence number assigned to the  **Default Location** (path: **File &gt; Setup &gt; Preferences &gt; Defaults 
 &gt; Accounting &gt; Miscellaneous** tab) is used.


{:.see_also}
See also
: [Default  location/sub-location]({{site.sc_chm}}/misc/default_location.html)
