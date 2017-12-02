---
title: The Variance Analysis Dialog Box
---

# The Variance Analysis Dialog Box


The **Variance Analysis** dialog  box displays details of the cost, rate and quantity variance of each item  on the selected work order. This dialog box comprises the following columns:


| **Column** | **Displays:** |
| Item Code | The item code of the assembly item component. |
| Substitute Of | The item code of the substitute item if any. |
| Std. Input | The standard input of the item required to produce the (required) output  of the assembly item as displayed in the **Std. <br/> Input** column of the item details grid. |
| Normal Loss% | The normal loss percent as defined in the Bill of Material in the **Input** tab of the **Item**  profile (path: **Inventory** >  **Items** > **Options** > **Edit** > **In <br/> New Window** > **Assembly**  > **Input** tab). |
| Normal Loss Qty | The normal loss quantity as defined in the Bill of Material. |
| Std. Input  (Incl. Loss) | The standard input before accounting for loss per unit of the assembly  item as defined in the Bill of Material. |
| Std. Input  (Excl. Loss) | The standard input after accounting for normal loss quantity for each  unit of the assembly as defined in the Bill of Material. |
| Actual Input | The actual quantity of the item used on the work order. |
| Std. Rate | The standard rate per unit of the component item as specified in the  Bill Of Material when the item was originally retrieved into the work  order. |
| Actual Rate | The actual rate per unit of the component item and is calculated based  on the item type.<br/><br/><br/>![]({{site.ba_baseurl}}/img/lens.gif) [Cost  of Inventoried Items]({{site.ba_baseurl}}/prod-asm/building-wo/entering-qty-built/val-fnshd-goods/cost_of_inventoried_items_work_order_assembly_contents.html) |
| Actual Amount | The actual amount (Actual Rate \* Actual Quantity) per line item. |
| Standard Amount | The standard amount (Standard Rate \* Standard Quantity) per line item. |
| Rate Variance | The difference between standard or estimated rate for the item in the  Bill Of Material (defined in the (Assembly) **Item**  profile) and the actual rate for the work order.<br/><br/><br/>Rate/Price Variance = (Standard Rate – Actual Rate) \* Actual Quantity |
| Quantity Variance | The difference between estimated quantity required for the actual output  and the actual quantity used.<br/><br/><br/>Quantity/Usage Variance = (Standard Input Quantity (Incl. loss) – Actual  Input Quantity) \* Standard Rate |
| Cost Variance | The difference between the standard/estimated cost and the actual cost.<br/><br/><br/>Cost Variance = Estimated Standard Costs – Actual Costs |



{:.see_also}
See also
: [Variance  Analysis]({{site.ba_baseurl}}/prod-asm/variance-analysis/variance_analysis_work_order_profile_browser_option_assembly.html)
