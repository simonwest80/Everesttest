---
title: How do I Show Landed Costs in Everest?
---

# How do I Show Landed Costs in Everest?


Problem


If I purchase 2 items for $40 each and shipping is $10, my  landed cost per item is $45 (40+40+10 / 2 = 45). I would like to have  add-on costs / landed cost to reflect this in **Everest**.


Solution


{:.steps}
To show landed costs in Everest, do the following:

- Create “Freight”  as an add-on cost in the **Add-on Costs**  browser (path: **Inventory** >  **Add-On Costs**).



![]({{site.pp_baseurl}}/img/add_on_cost_db_freight_pur.gif)


**Figure: Add-On Cost Profile -  Freight**

- Create a purchase  document for 2 items, each costing $40.



![]({{site.pp_baseurl}}/img/add_on_cost_pi_step1_pur.gif)


**Figure: Purchase Invoice Showing 2 Items Costing  $40**

- Select **Options**  > **Utility** > **Add-on 
 Costs Distribution** or press **Ctrl 
 + D**.



![]({{site.pp_baseurl}}/img/add_on_cost_pi_step2_pur.gif)


**Figure: Add-on Costs Distribution Utility**

- Since the “Automatically  display on the Add-on Costs Distribution screen” option was selected when  creating the “Freight” Add-on Cost, it comes up by default on this screen.  You can delete this row and add another row to add another add-on cost.



{:.note}
If there is more than one line item, you can  select the “Distribution Method” to allocate the add-on cost to each individual  inventoried line item.

- Add the shipping  cost ($10 in this example) to the **Amount**  field for the Freight Add-on Cost in the top grid and to the **Add-on 
 Amount** field for the item code in the bottom grid.
- Click **OK**  to update the purchase document.



![]({{site.pp_baseurl}}/img/add_on_cost_pi_step3_pur.gif)


**Figure: Purchase Document updated with Landed  Cost and Add-on Costs**

- In the document,  scroll to the “Add-on Amount”, “Add-on Cost”, “Landed Cost”, and “Landed  Cost Amount” columns. Notice that the **Landed 
 Cost** is $45 in this example.



{:.note}
This example does not take tax into consideration.


The following table shows the differences between the Add-on  Cost and Landed Cost amounts:


| Column | Description | Amount in this Example |
| Add-on Amount | The add-on cost allocated to all units of the item | $10 |
| Add-on Cost | The add-on cost allocated to each unit of the item | $ 5 ($10 / 2 items) |
| Landed Cost | (Cost After Discount + Add-on Cost) – It indicates per  unit landed cost | $45 ($40 + $5) |
| Landed Cost Amount | For documents with **FOB <br/> Destination**, it is the same as the “Amount” column for documents  or (Landed Costs \* Qty).<br/><br/><br/>For documents with **FOB <br/> Origin**, it is (Amount + Add-on Amount). | $90 ($45 \* 2 items) |



{:.see_also}
See also
: [Add-on  Costs Distribution Utility]({{site.pp_baseurl}}/purc-proc/doc-profile/doc-options/utils/addon-costs-distr/the_freight_distribution_utility.html)
