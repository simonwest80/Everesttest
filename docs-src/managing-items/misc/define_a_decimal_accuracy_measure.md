---
title: Define a Decimal Accuracy Measure
---

# Define a Decimal Accuracy Measure


{:.steps}
To define a measure using Decimal accuracy,  do the following:

- On the **Measure**  profile **General** tab, in the **Measure Code** field, enter a unique code  for your measure.
- Enter a description for the measure in the **Description** field.
- In the **Quantity 
 Entry Method** field, select **Decimal**.
- In the **Quantity 
 Decimal Accuracy** field, select the number of decimal places to  be used for this measure. It should be between 0 and 6.
- On the **Measure**  profile **Conversion Factor** tab,  in the **Measure** field, enter the  measure allowed for the conversion of this measure or select it from the  drop-down list.
- In the **Conversion**  field, enter the conversion factor for the measure listed.
- Right click and select **Insert**  to enter additional conversion factors allowed for this measure. Right  click and select **Delete** to remove  any unneeded conversion factors.
- Click the **Save**  button to save your defined measure.



{:.example}
Your Company buys and sells cigarettes and  you would like to have the following unit of measures:


| Measure | Equivalent |
| Each |  |
| Pack | 20 Cigarettes |
| Box | 10 Packs |



In the **Measure** profile for **BOX**, your System Administrator selects  **Each** and **Pack**  to define the conversion factors. The conversion factors entered are 200  for Each (1 BOX = 200 Cigarettes) and 10 for Pack (1 BOX = 10 PACKS).  Also, the System Administrator enters the number of digits to round off  as 0 (Decimal Accuracy = 0). Conversion factors for Each (EA) and Pack  are added automatically.


| Measure | Equivalent | Conversion Factor Tab shows: |
| Measure | Conversion |
| Box | 10 Packs | EA<br/><br/><br/>PACK | 200<br/><br/><br/>10 |
| Each (EA) | 1 Item | BOX<br/><br/><br/>PACK | 0.005<br/><br/><br/>0.05 |
| Pack | 20 Cigarettes | BOX<br/><br/><br/>EA | 0.1<br/><br/><br/>20 |



![]({{site.mi_baseurl}}/img/measure profile conversion factor decimal box.gif)


**The Measure Profile – Conversion Factor Tab –  BOX**


![]({{site.mi_baseurl}}/img/measure profile conversion factor - ea.gif)


**The Measure Profile – Conversion Factor Tab –  EA**


**![]({{site.mi_baseurl}}/img/measure profile conversion factor decimal pack.gif)**


**The Measure Profile – Conversion Factor Tab –  PACK**


{:.see_also}
See also
: [The  Measure Profile - Conversion Factor Tab]({{site.mi_baseurl}}/misc/the_measure_profile_conversion_factor_tab.html)
: [The Measure  Profile]({{site.mi_baseurl}}/item-profile-details/measure/measure_profile_general_tab.html)
