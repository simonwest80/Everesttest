---
title: The Pricing Analysis Browser
---

# The Pricing Analysis Browser 


The **Pricing Analysis** browser  displays profits for all the items contained in the document at the current  selling price based on different cost computations. Choose the best selling  price suitable to you and your customer and choose **Apply** to change the selling price of the item.


The following options are displayed in the **Pricing 
 Analysis** browser based on your flow control preferences:


| Option | Flow Control Setting |
| By Average Cost/By Average Cost (previous document save) | Average Cost or All |
| By Last Cost/By Last Cost (previous document save) | Last Cost or All |
| By User-defined Cost | User-defined Cost or All |
| By Actual/Average Cost | Actual Cost or All |
| By Actual/Average Cost (previous document save) | Actual Cost or All |



{:.note}
- If the **Actual/Average Cost** option is selected  in the flow control settings, serialized items displays actual cost and  non-serialized/non-inventoried items displays the average cost in the  browser. If the **Factor Cost (enable cost 
 inflation)** check box is selected, all costs are inflated with the  factor percentage specified in the **Item**  profile except the user-defined cost which is displayed at the actual  value entered in the sales document.
- If a non-inventoried  item does not have a liability or asset account defined, all costs – last,  average, and actual – except user-defined cost are displayed as zero in  the **Pricing Analysis** browser.
- If an asset  account is defined for a non-inventoried item, its cost should not be  considered in this browser.
- When a sales  document is created, **Pricing Analysis**  browser does not display details pertaining to previous document save.  Only after you save the document, previous document save details are displayed.  The previous document save details helps in comparing the profitability  at the time of creation of the original document and the current profitability  based on the updated cost. **Markup %**,  **Margin %**, **Profit**  and **Selling Price** columns cannot  be edited under Average Cost (previous document save), Last Cost (previous  document save), and Actual/Average Cost (previous document save). If the  markup, margin, profit, and selling price details are changed for a cost  type, the same is reflected for all other cost types too (but not for  the previous document saved ones).
- If a new line  item is added to an already saved document, it is not displayed under  the previous document save cost headers. The line item will be displayed  only under Average Cost, Last Cost, User-defined Cost, and Actual/Average  Cost headers.


You can select the pricing analysis for the entire document or for one  particular item as below:

- **Profit 
 Break Up - Document** **-** Displays  the pricing analysis statistics and calculations for the entire document.
- **Profit 
 Break Up - Item**– Displays the pricing analysis statistics and calculations  for the selected item.

: ![]({{site.sp_baseurl}}/img/lens.gif)[Profit  Breakup Document/Profit Breakup Current Item]({{site.sp_baseurl}}/misc/profit_break_up_document.html)


When you select either, the **Profit 
 Breakup** grid displays the pricing analysis and you can choose to  use the **Markup** or **Margin** settings to display the profits. You can also change the markup  or margin setting and choose **Apply**  to change the pricing analysis.


{:.note}
- The **UM**  field shows the measure selected for the item in the sales document.
- Cost is calculated  using the sales measure defined for the item.
- Last Cost and Average  Cost are converted from the stock measure to the selected measure. If  there is a purchase measure matching the sales measure, Last Cost in the  Purchase tab of the Item profile is used.
- The Selling Price,  Cost, and Profit are in the sales price decimal accuracy.


The following example shows a Sales Analysis where more than one unit  of measure is used:


![]({{site.sp_baseurl}}/img/lens.gif)[Sales  Analysis with More than One Unit of Measure]({{site.sp_baseurl}}/misc/sales_analysis_with_more_than_one_unit_of_measure_sales_process.html)


{:.see_also}
See also
: [Pricing Analysis]({{site.sp_baseurl}}/sales-docs/sqs/sq-proc/pricing-analysis/pricing_analysis.html)
: [Cost  Used in Pricing Analysis]({{site.sp_baseurl}}/sales-docs/sqs/sq-proc/pricing-analysis/costs_used_in_pricing_analysis.html)
: [Cost  Determination of Serialized Items in case of Sales Orders]({{site.sp_baseurl}}/misc/cost_determination_of_serialized_items_in_case_of_sales_orders.html)
