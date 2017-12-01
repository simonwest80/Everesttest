---
title: Fractional - Quantity Entry Method
---

# Fractional - Quantity Entry Method


The fractional method of entry can be used where an item’s measure and  parts of the measure are expressed in a measure or its measure and sub-measure.  The quantity of the item is expressed as the total number of base units  of the measure followed by the number of units in the measure.


When retrieving an item with a fractional quantity entry method into  a document, the **Quantity** column  will automatically change to the colon format if the item selected has  a sub-measure and a conversion factor exists between them.


{:.example}
If an item’s measure is HR (Hour) and the  HR measure has a sub-measure of MN (Minutes) and a conversion factor exists  between them (1 HR = 60 MN) then the **Quantity**  column will show the colon format. One hour and 45 minutes displays as  1:45 in the **Quantity** column.


This Fractional Quantity Entry method is not suitable for expressing  measures that may be expressed as a percentage or part of the base unit  of the measure.


{:.example}
This method cannot be used if an item's measure  is a kilogram, the measure comprises 1000 grams and the quantity also  has to be expressed as a part of a gram in milligrams.


Hourly measures can also be used to configure labor item codes.


{:.example}
Define a measure code of HR, with a unit quantity  of 60, and a fractional quantity entry method. If hourly technical services  are sold at $120/hour, and 2 hours and 15 minutes (2:15) are to be billed  to a client, **Everest** can automatically  calculate the extended total of the fractional time ($120/hr \* 2 15/60  hrs = $270.00).


{:.see_also}
See also
: [Quantity Entry  Method]({{site.mi_baseurl}}/item-profile-details/other-items-information/purchase/quantity_entry_method.html)
