---
title: Add-on Amount
---

# Add-on Amount


Displays the add-on amount calculated by the system, based on the distribution  method selected for the add-on cost element highlighted in the top grid.


The cost distributes across all inventoried items which specify a value  for that distribution method. If none of the items have a value for that  distribution method, the entire cost displays in the Difference column  in the top grid and the system will not continue with the distribution.  You must adjust the costs before you can save the cost distributions.


{:.example}
You highlight an add-on cost element which uses the distribution method  of weight. Your document has four line items. If all four of the line  items have a value for weight, the cost distributes proportionally among  all of them. If only two of the line items have a value for weight, the  cost distributions proportionally among those two.


If only one line item has a value for weight, the system assigns the  entire add-on cost to that one item.


On a purchase invoice, the add-on amount is shown under both the Received  on Invoice and Invoiced headings.


The Add-on Amount distributes automatically for each inventoried line  item when you specify all the add-on cost details in the top grid and  anytime you edit the Amount or Distribution Method of an add-on cost element  in the top grid.


If the add-on cost element uses the User Specified distribution method,  this column is blank and you must manually enter the amount for each line  item.


If you edit any add-on cost amount, the system automatically recalculates  the distributed amounts and changes the distribution method in the top  grid to User Specified. The Amount column in the top grid does not change,  so any difference between the Amount column and the total add-on amounts  in the bottom grid displays in the top grid’s Difference column. You must  manually adjust the Amount in the top grid and/or the add-on amounts in  the bottom grid to eliminate the difference.


The total Add-on Amount of all the line items displays at the bottom  of the Add-on Cost Distribution dialog box.


{:.see_also}
See also
: [The  Add-on Costs Distribution Dialog Box]({{site.pp_baseurl}}/purc-proc/doc-profile/doc-options/utils/addon-costs-distr/the_freight_distribution_dialog_box.html)
