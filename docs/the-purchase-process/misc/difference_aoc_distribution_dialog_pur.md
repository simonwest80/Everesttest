---
title: Difference
---

# Difference


If the system detects a difference between the Amount column for an  add-on cost in the top grid and the sum of the Add-on Cost column in the  bottom grid, the system displays that difference here. The following situations  can cause a difference:

- rounding differences
- the distribution  method is set to User Specified and the amounts entered in the bottom  grid do not add up to the Amount in the top grid
- the add-on  cost did not allocate to any line item because the line items do not contain  values relevant to the distribution method (e.g., the distribution method  is Weight but none of the line items have a value for Weight)



In the case of rounding differences, the system will automatically increase  or decrease the last item’s add-on amount to eliminate the difference.  However the add-on amount will not decrease beyond $0.00 because a negative  add-on amount does not make sense. If the add-on amount for the last item  decreases to $0.00 but there is still a difference, it remains in the  Difference column.


You must resolve any differences before the system allows you to save  and close the Add-on Costs Distribution dialog box.


On a purchase invoice with FOB type Destination, the Difference displays  for both the Received on Invoice and Invoiced columns. provided the received  and invoiced quantities are different.


{:.see_also}
See also
: [The  Add-on Costs Distribution Dialog Box]({{site.pp_baseurl}}/purc-proc/doc-profile/doc-options/utils/addon-costs-distr/the_freight_distribution_dialog_box.html)
