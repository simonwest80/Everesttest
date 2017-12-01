---
title: Tax Component - Purchase Information
---

# Tax Component - Purchase Information


**Tax Rate**
: Enter the tax rate for purchases.


**Apply Tax Rate to Add-On Costs**
: Select this option to include add-on costs to the  item value and then calculate tax on the total amount during purchases.  This setting is applicable for each tax component only if you have distributed  add-on costs and the document’s FOB Type is set to Destination. Documents  set to FOB Origin never include add-on costs for calculating tax.


**Tax Limit Base**
: Specify the limit if any, on the amount of tax on  a tax component, as well as the base on which the limit will be determined.  The options available are:

- **None**  - If you do not want to specify a limit on the amount of tax, select this  option.
- **Line****Item** **Amount**  - Use this option to specify the limit of tax based on the value of the  line item.
- **Current****Component** **Tax**  - Use this option to specify the limit of tax based on the current tax  component.



**Maximum Line Item Amount/Maximum Tax Amount**
: Use this option to enter the maximum amount of tax  applicable for the component, or for the line item. If the line item amount  exceeds the maximum amount, then the tax is calculated only on the maximum  amount.


{:.note}
If you select the option **Current 
 Component Tax** in the **Tax Limit 
 Base** field, the field name changes to **Maximum 
 Tax Amount**.


[]()Recoverable
: Use this option to specify if a certain portion  of the tax that is recoverable from the government, on purchases. This  tax is treated as an asset. You can specify the percentage or amount that  is recoverable from the government.


**% Recoverable, Recoverable %**
: Use this option to specify the percentage of tax,  that is to be recovered from the government, on purchases.


**Amount Recoverable, Amount**
: Use this option to specify the amount of tax, that  is to be recovered from the government, per purchase measure.


{:.example}
If USD 10 is the tax calculated for purchasing  20 units of an item, and the amount recoverable is 0.25 USD per measure,  then the amount that is to be recovered is 5 USD (i.e., 0.25x20).


**Unit of Measure for Recovery**
: Use this option to specify the unit of measurement  for tax amounts to be recovered from the government.


**Tax Account Code**
: Use this option to specify the account code. The  total tax recoverable for each tax component is debited to this account.


**Exclude Payment Discount for Purchase Tax Calculation**
: You may see this disabled field on the Purchase  tab. This only appears if it had been selected during the previous add/edit  of the tax component. The field is disabled because the option is no longer  available within Everest.
: Documents created using an existing tax component  with the exclusion selected will continue to calculate the tax rate based  on the discounted amount.


{:.see_also}
See also
: [Tax  Component Details]({{site.sc_baseurl}}/options/sales-tax/set-up-tax-codes-and-components/tax-code/tax_code_profile_general_information.html)
