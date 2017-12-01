---
title: The Measure Profile - General Tab
---

# The Measure Profile - General Tab


**Measure Code\***
: Enter a unique code for the measure being defined,  using 1 to 15 characters of the specified type.  Once  the measure is used in any document, this field cannot be edited.


**Description\***
: Enter a suitable description for the measure being  defined, using 1 to 40 characters. This field can be updated at any time.


**Quantity Entry Method**
: Select **Decimal**  or **Fractional** as the **Quantity 
 Entry Method** option. Use **Decimal**  if you want your quantity defined with decimal accuracy or use **Fractional**  if you want your quantity defined in fractions.


**Quantity Decimal Accuracy**
: Select the necessary decimal accuracy of your measure  between 0-6 decimals. This field only displays if the **Decimal**  quantity entry method is selected. You can increase or decrease the decimal  accuracy of a measure even if it is used in a document. If you change  the decimal accuracy, future transactions can be entered in the new decimal  accuracy of the measure.


**Sub Measure**
: Select the measure to be defined as the **Sub-Measure**  of this measure. The **Sub Measure**  field is not mandatory but it is shown if the **Fractional**  quantity entry method is selected.
: The sub-measure selected should have an existing  conversion factor with the main measure and must also be defined with  a quantity entry method of **Fractional**.  A measure must exist or be created before it can be selected as a Sub-Measure.  You should not select a measure as a sub-measure if the measure is already  a sub-measure of another measure. Also, a sub-measure should not be a  main measure of the measure for which the sub-measure is defined.


{:.example}
You define a measure for Hour (HR). You define  the sub-measure of HR as Minutes (MIN). The Minutes (MIN) measure has  a sub-measure of Seconds (SEC). The Seconds (SEC) measure does not have  a sub-measure. This is shown in the following table:


| Measure | Sub-Measure |
| HR | MIN |
| MIN | SEC |
| SEC |  |

: In this example, HR and MIN cannot be defined as  sub-measures of SEC.


{:.note}
If you leave the **Sub 
 Measure** field blank, the quantity will only be in the main measure.


{:.example}
You define a measure for Hour (HR) and leave  the **Sub Measure** field blank. The  quantity will only be in the main measure and cannot be stored or entered  in the sub-measure. In this example, only hours and not minutes or seconds  will be shown.
: {:.see_also}
See also
: [The Measure  Profile]({{site.mi_baseurl}}/item-profile-details/measure/measure_profile_general_tab.html)
: [The  Measure Profile - Conversion Factor Tab]({{site.mi_baseurl}}/misc/the_measure_profile_conversion_factor_tab.html)
