---
title: Sales Analysis with More than One Unit of Measure
---

# Sales Analysis with More than One Unit of Measure


The following example shows a Sales Analysis where more than one unit  of measure is used:


{:.example}
You have the following measures defined for  the Cream Soda item:


Stock Measure: Each


Purchase Measure: Crate and Each


Sales Measure: Crate and Each


1 Crate = 10 Each


You sell one crate of Cream Soda for $10.


• The **Last 
 Cost** of one crate of Cream Soda is $5. Since the last cost in Crate  is available, the last cost based on the conversion factor ($4.5) is not  used.


• The **Average 
 Cost** of each Cream Soda is $0.4.


• The **Average 
 Cost** of each crate based on the conversion factor is $4.


• The **Cost**  entered in the sales document is $4.5.


The Sales Analysis shows the following information  for the Cream Soda item:


| Pricing By: | UM | Margin % | Mark Up % | Profit | Cost | Selling Price |
| Average Cost | Crate | 60 | 150 | 6 | 4 | 10 |
| Last Cost | Crate | 50 | 100 | 5 | 5 | 10 |
| User Defined Cost | Crate | 55 | 122.22 | 5.5 | 4.5 | 10 |
| Actual/<br/><br/><br/>Average Cost | Crate | 60 | 150 | 6 | 4 | 10 |



{:.see_also}
See also
: [Pricing  Analysis Dialog Box]({{site.sp_baseurl}}/sales-docs/sqs/sq-proc/pricing-analysis/pricing-analysis-defaults/pricing_analysis_dialog_box.html)
