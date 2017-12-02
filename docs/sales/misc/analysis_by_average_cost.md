---
title: Analysis by Average Cost
---

# Analysis by Average Cost


When the analysis is by average cost, the current mark-up percentage  and the current margin is calculated using the selling price for the item  on the document and the average cost for the item.


{:.note}
The average cost is computed per sales measure of the  item.


The average cost analysis further analyses by 3 types of average cost.

- **Average 
 Cost** - In this case, the average cost used for analysis is the  current average cost. Where the item is serialized, the current average  cost is the average of the actual cost of units in stock. This is the  average cost that is displayed on the **Item**'s  profile.
- **Last 
 saved average cost** - Each time a sales document is saved, **Everest** also saves the average cost  of the item. The analysis provided is based on the last saved actual average  cost.
- **Actual 
 average cost** - When the analysis is by actual cost, the current  mark-up percentage and the current margin is calculated using the selling  price for the item on the document. Cost used is the actual cost for serialized  items and the current average cost for non-serialized items.



If the document is a sales order, the actual cost for the item is computed  thus:


1. Total of the actual cost of items committed on the sales order.


2. Product of the item's current average cost and quantity of items  not committed.


3. Sum of 1 and 2.


4. Divide 3 by total quantity on order.


{:.note}
If the option **Factor 
 Cost (enable cost inflation)** is selected in the **Other 
 Flow Control** dialog box (path: **File 
 &gt; Setup &gt; Preferences &gt; Flow Control &gt; Other Flow Control 
 &gt; Item Cost/Sales Summary** tab), the costs are inflated by the  factor percentage for the item. However, if the user has logged into extended  mode, the costs displayed will not include cost inflation.


![]({{site.sp_baseurl}}/img/lens.gif) [Factor  Cost (enable cost inflation)]({{site.bp_chm}}/other-flow-control/the-other-flow-control-dialog-box/other_flow_control_item_cost_sales_summary_tab.html)


{:.see_also}
See also
: [Costs  Used in Pricing Analysis]({{site.sp_baseurl}}/sales-docs/sqs/sq-proc/pricing-analysis/costs_used_in_pricing_analysis.html)
