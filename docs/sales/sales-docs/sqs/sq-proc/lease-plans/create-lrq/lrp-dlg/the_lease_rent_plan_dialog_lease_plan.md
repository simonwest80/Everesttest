---
title: Lease/Rent Plan Dialog Box - Lease Plan
---

# Lease Rent Plan Dialog Box - Lease Plan


The **Lease Plan** tab allows you  to define the lease plan that should be associated with the current document.


**Lease Plan**
: The lease plan is the lease ID of the plan attached.  Specify the lease plan to be attached to the quote or order.
: ![]({{site.sp_baseurl}}/img/lens.gif) [The  Lease Plan Profile]({{site.sp_baseurl}}/sales-docs/sqs/sq-proc/lease-plans/setting-up-lease-plans/the_lease_plan_profile.html)


**Lease Factor**
: The lease factor defined for the selected lease  plan is displayed by default in this field. The **Lease 
 Factor** cannot be modified.


**Lease Period**
: The tenure defined for the selected lease plan is  displayed by default in this field. The period of the lease cannot be  modified.


**Lease Frequency**
: This field displays the fixed time intervals at  which the lease payments must be paid as defined in the selected lease  plan. The frequency of payments cannot be modified.


**Lease Rent**
: The amount to be paid as lease rent as per the lease  frequency is displayed in this field. The lease rent is computed by multiplying  the document total by the lease factor specified in the **Lease****Plan** profile. The document total  is the sum of the taxable amount, exempt amount and sales tax amount.
: ![]({{site.sp_baseurl}}/img/example.gif) If  the lease factor is 0.035, and the document amount is $10,000, and frequency  is monthly, the lease rent to be paid per month is $350 (0.035\*10,000).


**Include Tax**
: Select this check box to include the sales tax amount  displayed in the **Tax** field of  the document in computing the lease rent.
: ![]({{site.sp_baseurl}}/img/example.gif) If  the **Taxable** amount in the document  is $1000, the **Exempt** amount is  $500 and the **Tax** amount is $50,  the document total will be computed as $1550 when the **Include 
 Tax** check box is selected. If you clear this check box, the document  total will be $1500.


{:.see_also}
See also
: [The Lease/Rent  Plan Dialog]({{site.sp_baseurl}}/sales-docs/sqs/sq-proc/lease-plans/create-lrq/lrp-dlg/the_lease_rent_plan_dialog.html)
: [The  Lease/Rent Plan Dialog - Rental Plan]({{site.sp_baseurl}}/sales-docs/sqs/sq-proc/lease-plans/create-lrq/lrp-dlg/the_lease_rent_plan_dialog_rental_plan.html)
