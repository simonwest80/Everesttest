---
title: Back End Processes - Depreciation Journals
---

# Back End Processes - Depreciation Journals


The back end processes when a depreciation entry is created are:

- The asset's  current book value is reduced by the depreciation amount.
- The last generation  date and number of generations fields on the **Fixed 
 Asset** profile are updated.
- If the asset  is fully depreciated, then the status of the asset changes to inactive.



{:.note}
Salvage value for the asset will continue  to exist as a balance in the asset account even when it is fully depreciated.


{:.see_also}
See also
: [Creating  a Depreciation Entry]({{site.acc_baseurl}}/fixed-assets/depreciating-an-asset/creating_a_depreciation_entry.html)
