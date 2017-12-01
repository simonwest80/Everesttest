---
title: The Tax Components Profile - Sales Tab
---

# The Tax Component Profile - Sales Tab


Use this tab to specify tax component information with regard to sales.


**Calculation Method**
: Specify a method to calculate the sales tax collected  on this component. Base your calculation on the **Percentage 
 of Cost**, **Percentage of Sales Price**  or **Amount per unit quantity**.


**Tax Rate Type**
: Specify whether you want to tax items as a flat  rate or based on item price slabs.


**Sales Tax Rates Grid**
: Use this section to enter the tax rate for a range  of item prices.


**Sales  Measure**
: Specify the sales measure from the drop-down list.


**Tax  Limit Base**
: Specify the tax limit if any, and the base on which  the limit will be determined.


**Maximum  Tax Amount**
: Enter the maximum amount of tax for the tax component.  The maximum amount of tax that can be charged is specified in this field.


**Maximum Line Item Amount**
: Specify the maximum line item amount, exceeding  which the same tax will be charged irrespective of the sales price of  the item if you select **Line Item Amount**  in the **Tax Limit Base** field.


{:.example}
For a tax component, the calculation method  is Percentage of Sales Price, the tax rate type is Flat Rate, the tax  rate is 10% and the maximum line item amount is set at $5.


If the tax limit base is **Line 
 Item Amount**, the tax charged will be 10% of the sales price that  is less than or equal to $5. If the sales price exceeds $5, the tax charged  will remain constant at $0.5.
: Specify the maximum line item amount exceeding which  the item will be exempt from tax if you select **Exempt 
 if line item amount exceeds specified value** in the **Tax 
 Limit Base** field.


{:.example}
For a tax component, the calculation method  is Percentage of Sales Price, the tax rate type is Flat Rate, the tax  rate is 10% and the maximum line item amount is set at $5.


If the tax limit base is **Exempt 
 if line item amount exceeds specified value**, the tax charged will  be 10% of the sales price that is less than or equal to $5. If the sales  price exceeds $5, the tax charged will be nil.


**Tax Account Code**
: Specify the General Ledger (GL)  account code for the tax component. This is a mandatory field. Once saved,  this field cannot be modified.
: ![]({{site.sc_baseurl}}/img/lens.gif) [Sales  Information]({{site.sc_baseurl}}/misc/tax_component_sales_information.html)


**Exclude Payment Discount for Sales Tax Calculation**
: You may see this disabled field on the Sales tab.  This only appears if it had been selected during the previous add/edit  of the tax component. The field is disabled because the option is no longer  available within Everest.
: Documents created using an existing tax component  with the exclusion selected will continue to calculate the tax rate based  on the discounted amount.


{:.see_also}
See also
: [VAT on Sales]({{site.sc_baseurl}}/options/sales-tax/value-added-taxes/vat_on_sales.html)
: [The **Tax 
 Component** Profile]({{site.sc_baseurl}}/options/sales-tax/set-up-tax-codes-and-components/tax-component/tax_components_profile.html)
: [Tax  Component Details]({{site.sc_baseurl}}/options/sales-tax/set-up-tax-codes-and-components/tax-component/tax_component_profile_information.html)
: [Creating  a Tax Component]({{site.sc_baseurl}}/options/sales-tax/set-up-tax-codes-and-components/tax-component/creating_a_tax_component.html)
