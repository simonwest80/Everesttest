---
title: Distribution Method
---

# Distribution Method


The add-on costs can be distributed on any of the following basis:


| Option | Select this option to: |
| Weight | Distribute add-on costs automatically, in proportion to the weight of  the items. The **Weight** column displays  the total weight of each line item. The total weight is computed using  the item quantity entered in the purchase document and the weight per  unit of measure as defined in the **Item** profile (path: **Inventory**  > **Item** > **Options <br/> &gt; Edit &gt; In New Window** > **Purchases**  tab - Double-click the **Freight** field  to open the **Item Freight** dialog  box). It is converted to the weight measure defined for the logged in  country and displayed. |
| Value | Distribute add-on costs in proportion to the value of the items as displayed  on the document profile. |
| Volume | Distribute add-on costs automatically in proportion to the volume of  the items. The **Volume** column displays  the total volume of the items. The total volume is computed using the  quantity of the line items entered in the purchase/purchase return document  and the volume per unit of measure defined in the **Item**  profile (path:**Inventory &gt; Items &gt; <br/> Options &gt; Edit &gt; In New Window &gt; &nbsp;Purchases**  tab - **Freight** column). It is converted  to the volume measure for the logged in country and displayed.<br/><br/><br/>![]({{site.pp_baseurl}}/img/note.gif)  Volumes  can be expressed either as a liquid measure or a solid measure. This option  can be selected only if the volume of all items on the document is expressed  as the same type of measure. If one item is a liquid and the other is  a solid, this option is disabled. |
| User Specified | Enter the add-on costs manually for each item. |



**Items Considered for Add-On Cost Distribution**


For distributing add-on costs, you must first specify the item’s weight,  dimensions, or volume in liquid/weight measure in the **Item**  profile (path: **Inventory &gt; Items &gt; 
 Options &gt; Edit &gt; In New Window &gt; Freight - Purchase** tab).  If you do not define the freight information for an item, it is not displayed  in the **Add-On Costs Distribution**  dialog box. Thus, you can distribute add-on costs only for those items  that have freight information defined.


**Items with Different Weight/Volume Measures**


If items in the document have different weight/volume measures, **Everest** converts them into the following  common measures in order to have a common base for distributing add-on  costs:


| Type of Measure | Measurement Unit |
| Weight | Kilogram |
| Liquid Volume | Liter |
| Solid Volume | Cubic Centimeter |
| Dimension | Meter |



| ![]({{site.pp_baseurl}}/img/example.gif) | You include items A and B in a purchase order  with the following details:<br/><br/><br/>| Item | Qty. | Wt. | Purchase Measure | Vol. | Amount |<br/>| A | 2 | 5 kg | Each | 10 CC | $40 |<br/>| B | 100 | 50 grams | 12 Pack | 0.005 cu. ft. | $50 |<br/><br/><br/><br/>If the total add-on cost is $10, the add-on costs are distributed as  follows:<br/><br/><br/>**WEIGHT**<br/><br/><br/>All item weights are converted to Kilograms. A = 10kg (5x2) and B =  .4167 kg {(50/1000) x (100/12)}<br/><br/><br/>Item A = $9.60 (10/(10+0.4167) x $10)<br/><br/><br/>Item B = $ 0.40 (0.4167/(10+0.4167) x $10)<br/><br/><br/>**VALUE**<br/><br/><br/>Item A = $4.44 ({40/(40+50)} x $10)<br/><br/><br/>Item B = $5.56 ({50/(40+50)} x $10)<br/><br/><br/>**VOLUME**<br/><br/><br/>All (solid) volumes are converted to Cubic Centimeters (CC). A = 20  CC (2 x 10) and B = 1180 CC {141.6 x (100/12 )}<br/><br/><br/>Item A = 0.167 (20/(1180+20) x $10)<br/><br/><br/>Item B = 9.833 (1180/(1180+20) x $10) |



{:.see_also}
See also
: [Add-on  Costs Distribution Dialog Box]({{site.pp_baseurl}}/purc-proc/doc-profile/doc-options/utils/addon-costs-distr/the_freight_distribution_dialog_box.html)
