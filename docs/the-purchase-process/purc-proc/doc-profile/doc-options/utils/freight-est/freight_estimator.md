---
title: Everest Freight Estimator
---

# Everest Freight Estimator


**Everest** allows you to compute  freight using the **Everest Freight Estimator**.


Freight is computed on an item only if the **Include 
 in Freight Calculation** option is selected on the **Item**  profile (path: **Inventory &gt; Items &gt; 
 Options &gt; Edit &gt; In New Window &gt; Purchase** tab).


{:.note}
Freight may be included in a final document  (purchase invoice/credit memo) even after it has been created and saved.  However a final document whose journal has been posted cannot be modified.


**The **Everest 
 Freight Estimator** option allows you to compute freight based on  destination zones for all countries. This basically allows you to evaluate  the freight charged by vendors.**


**To enable the **Everest 
 Freight Estimator** option to compute freight, the name of the carrier  and the equivalent delivery service has to be identified in the [**Delivery Method** profile]({{site.sc_chm}}/options/everest-freight-estimator/delivery-methods/set-up-a-delivery-method/creating_a_new_delivery_method.html).**


**Freight is calculated based  on the:**

- Originating  zip code (of the document’s location or the location of the document’s  location/sub-location).
- Destination  zip code (of the ship to address in the document).
- Ship-via agent  (the delivery method selected).
- Rate Definition.



The freight charges include transportation cost, COD fee, residential  charges and insurance cost wherever applicable.


{:.see_also}
See also
: [Compute  Freight Using Everest Freight Estimator]({{site.pp_baseurl}}/purc-proc/doc-profile/doc-options/utils/freight-est/compute_freight_using_the_everest_freight_estimator_purchases.html)
