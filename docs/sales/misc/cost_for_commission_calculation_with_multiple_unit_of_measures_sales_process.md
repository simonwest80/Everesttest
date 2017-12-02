---
title: Cost for Commission Calculation with Multiple Unit of Measures
---

# Cost for Commission Calculation with Multiple Unit of Measures


![]({{site.sp_baseurl}}/img/lens.gif)[Type  of Cost Used for Commission Calculations]({{site.bp_chm}}/other-flow-control/the-other-flow-control-dialog-box/other_flow_control_item_cost_sales_summary_tab.html)


Even though the costs used for commission calculations are based on  preferences, costs shown in the Commission report are shown in the sales  measure.


{:.example}
You want to retrieve an item with multiple  measures into a sales document. You have the following information for  Item ABC:


| Measure | MT | KG | LBS | GMS |
| Stock Measure | - | KG with a decimal accuracy of 3 | - | - |
| Sales Measure | - | - | LBS (default sales measure) with a decimal accuracy  of 4 | - |
| Sales Measure | - | - | - | GMS with a decimal accuracy of 0 |
| Conversion Factor |  | 1 KG = .001 MT<br/><br/><br/>1 KG = 2.2046226 LBS<br/><br/><br/>1 KG = 1000 GMS | 1 LB = 0.4535924 KG |  |
| Item Price | $2000 | $25 | $11.25 | $.25 |
| Average cost of item |  | $20.25 (Converted from sales measure) | $20.25/2.2046226 = $9.19 |  |
| Total Stock |  | 10.120 KG |  |  |



You retrieve Item ABC into the sales document.  This  information is used for scenarios 1 and 2.


| Item | Item Price | Cost | Quantity | UOM | Amount |
| ABC | $11.25 | $9.19 | 1.5000 | LBS | $16.88 |



**Scenario 1 – Change the Sales Measure**


You change the sales measure to GMS and the quantity changes to 1 since  the decimal accuracy of GMS is 0 and the quantity of 1.5000 cannot be  retained. The price updates to 0.25 for the GMS measure automatically.


1.5000 LBS \* .4535924 KG/LB = .6803886 KG sold


The Total Stock is now 10.120 KG – .6803886 KG sold = 9.4396114 KG


**Scenario 2 – Customer Level Pricing and Special  Pricing**


Assume that customer level pricing and special pricing are defined only  for the LBS measure. The price for Level 1 is $21 and Level 2 is $22.  Special pricing for the LBS measure is $21.50 and is not applicable to  the customer pricing levels.


When you retrieve the item in LBS for a Level 1 customer, the price  is $21. When you retrieve the item in LBS for a Level 2 customer, the  price is $22. If you change the measure to GMS, the price changes to $.25  because customer level and special pricing is not defined for this measure.


{:.example}
**Sales Price Calculation with %Markup when  Last Cost **Is 
 Not** Available in the Sales Measure**


You want to know how the sales price is calculated using %Markup when  the last cost is not available in the sales measure. You have the following  information:


Stock Measure: PCS


Purchase Measure: Box and Carton


Sales Measure: Case with a percent markup over last cost of 20%


1 Box = 10 PCS


Carton = 50 PCS


Case = 100 PCS


You purchased the item in the Box measure at $20 and then purchased  the item in the Carton measure at $90. The **Last 
 Cost** for the stock measure is shown as $20/10 = $2. After you purchased  the item in a Carton, the **Last Cost**  for the stock measure is shown as $90/50 = $1.80.


When the item is retrieved into the sales document with a measure of  Case, the item price is calculated using a conversion from the stock measure  as follows:


Price Converted from the Stock Measure + %Markup Based on Stock Measure  =


($1.80\*100) + [($1.8\*100) \* .20)] = 216


{:.example}
****Sales Price 
 Calculation with %Markup when Last Cost Is 
 Available in the Sales Measure****


You want to know how the sales price is calculated using %Markup when  the last cost is available in the sales measure. You have the following  information:


Stock Measure: Each


Purchase Measures: Box and Each


Sales Measures: Box and Each


1 Box = 10 Each


You purchased 5 units for $1 each and then purchased a box for $5. The  **Last Cost** on the **Inventory**  tab of the **Item** profile shows  $0.50. The **Last Cost** on the **Purchase** tab shows $1 for Each and $5  for Box.


You set the percent markup for Each as 20%. If you sell one unit (1  Each), the price is calculated based on the last cost in the purchase  measure for Each ($1\*1.2).  It  is not calculated on the last cost in the stock measure for Each ($0.5\*1.2).


{:.example}
**Calculate the Average Cost for Debiting to  COGS or Commission Calculation**


You want to know how the average cost of an item sold is calculated.  You have the following information:


Stock Measure: PCS


Purchase Measure: Box


Sales Measure: Carton


1 Box = 20 PCS


1 Carton = 100 PCS


The average cost of each piece (PCS) is $18 and the current stock of  the item is 500 PCS.


If you create a sales invoice for 1 carton, the average cost of the  item sold is calculated by multiplying the average cost of the stock measure  by the conversion factor to the sales measure = $18/PCS \* 100PCS/Carton  = $1,800/Carton.


{:.example}
****Calculate 
 the Last Cost used for Commission Calculation****


You want to know how the last cost of an item sold is calculated for  commission calculation. You have the following information:


Stock Measure: PCS


Purchase Measure: Box


Sales Measure: Carton


1 Box = 20 PCS


1 Carton = 100 PCS


The last cost of each piece (PCS) is $22 and the current stock is 500  PCS.


If you create a sales invoice for 1 carton, the last cost is calculated  by multiplying the last cost in the stock measure by a conversion factor  to obtain the last cost in the sales measure = $22/PCS \* 100PCS/Carton  = $2,200/Carton.


If the last cost is available in the Carton measure, the last cost in  the Carton measure is used and conversion from the stock measure is not  necessary. If Carton is also defined as the purchase measure and the last  cost is $12, the last cost for the commission calculation is $12 instead  of $22.


{:.see_also}
See also
: [Cost]({{site.sp_baseurl}}/sales-docs/docs-profile/contents/item-info/details/cost_item_details_grid_sales_content.html)
