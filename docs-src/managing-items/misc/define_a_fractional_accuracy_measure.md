---
title: Define a Fractional Accuracy Measure
---

# Define a Fractional Accuracy Measure


{:.steps}
To define a measure using Fractional accuracy,  do the following:


• On the **Measure** profile **General** tab, in the **Measure 
 Code** field, enter a unique code for your measure.


• Enter a description for the measure in the **Description**  field.


• In the **Quantity Entry Method**  field, select **Fractional**.


• In the **Sub-Measure** field,  enter the code of the sub-measure if you would like to define a sub-measure.  If a **Measure** code does not exist  for the sub-measure, right click this field to create a new measure.


• On the **Measure** profile **Conversion Factor** tab, in the **Measure** field, enter the measure allowed  for the conversion of this measure or select it from the drop-down list.  If you are defining a sub-measure, a conversion factor should exist between  this measure and the sub-measure.


• In the **Conversion** field, enter  the conversion factor for the measure listed.


• Right click and select **Insert**  to enter additional conversion factors allowed for this measure. Right  click and select **Delete** to remove  any unneeded conversion factors.


• Click the **Save** button to save  your defined measure.


{:.example}
You define a measure for Hour (HR). You define  the sub-measure of HR as Minutes (MIN). On the **Conversion 
 Factor** tab, you selected MIN in the **Measure**  field and entered 60 as the conversion factor.


![]({{site.mi_baseurl}}/img/measure profile conversion factor fractional.gif)


**The Measure Profile – Conversion Factor Tab –  HR Main Measure**


In the Minutes (MIN) measure, the conversion factor is automatically  calculated for you.


![]({{site.mi_baseurl}}/img/measure profile conversion factor fractional min.gif)


**The Measure Profile – Conversion Factor Tab –  MIN Sub-Measure**


{:.see_also}
See also
: [The  Measure Profile - Conversion Factor Tab]({{site.mi_baseurl}}/misc/the_measure_profile_conversion_factor_tab.html)
: [The Measure  Profile]({{site.mi_baseurl}}/item-profile-details/measure/measure_profile_general_tab.html)
