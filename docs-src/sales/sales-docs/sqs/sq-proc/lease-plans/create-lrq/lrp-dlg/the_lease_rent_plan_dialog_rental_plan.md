---
title: Lease/Rent Plan Dialog Box - Rental Plan
---

# Lease Rent Plan Dialog Box - Rental Plan


The **Rental Plan** tab allows you  to define the rental plan that should be associated with the current document.  Lease plans can be used as rental plans. When a lease plan is attached  to a document as a rental plan the document becomes a rental quote/order.


**Rental ID**
: The rental ID is the ID of the plan that is attached  to the document. Specify the lease plan to be attached to the quote or  order as a rental plan.
: ![]({{site.sp_baseurl}}/img/lens.gif) [The  Lease Plan Profile]({{site.sp_baseurl}}/sales-docs/sqs/sq-proc/lease-plans/setting-up-lease-plans/the_lease_plan_profile.html)


**Rental Factor**
: The lease factor defined for the selected lease  plan is displayed by default in this field. The **Rental 
 Factor** cannot be modified.


**Rental Period**
: The tenure defined for the selected lease plan is  displayed by default in this field. The period of rent cannot be modified.


**Rental Frequency**
: This field displays the fixed time intervals at  which the rental payments must be paid as defined in the selected lease  plan. The frequency of payments cannot be modified.


**Rent**
: The amount to be paid as rent as per the rental  frequency is displayed in this field. The rent is computed by multiplying  the document total by the rental factor specified in the **Lease 
 Plan Profile**. The document total is the sum of the taxable amount,  exempt amount and sales tax amount.
: ![]({{site.sp_baseurl}}/img/example.gif) If  the rent factor is 0.035, and the document amount is $10,000, and frequency  is monthly, the rent to be paid per month is $350 (0.035\*10,000).


**Include Tax**
: Select this check box to include the sales tax amount  displayed in the **Tax** field of  the document in computing the rent.
: ![]({{site.sp_baseurl}}/img/example.gif) If  the **Taxable** amount in the document  is $1000, the **Exempt** amount is  $500 and the **Tax** amount is $50,  the document total will be computed as $1550 when the **Include 
 Tax** check box is selected. If you clear this check box, the document  total will be $1500.


{:.see_also}
See also
: [The Lease/Rent  Plan Dialog]({{site.sp_baseurl}}/sales-docs/sqs/sq-proc/lease-plans/create-lrq/lrp-dlg/the_lease_rent_plan_dialog.html)
: [The  Lease/Rent Plan Dialog - Lease Plan]({{site.sp_baseurl}}/sales-docs/sqs/sq-proc/lease-plans/create-lrq/lrp-dlg/the_lease_rent_plan_dialog_lease_plan.html)
