---
title: Tax Amount
---

# Tax Amount


The **Tax Amount** column displays  the total amount of tax applied to each line item. The system bases the  tax calculation on the following factors:

- FOB Type
- Apply Tax Rate  to Add-On Costs option
- Tax Inclusive/Exclusive



**FOB Type and Apply Tax Rate to Add-on Costs**


The tax calculation depends on whether the document is set to FOB Origin  or FOB Destination.

- **FOB 
 Origin** - the system never includes add-on costs in calculating  the tax. The amount of tax is simply the cost minus any discount multiplied  by the tax rate:
Tax = (Cost – Discount) \* Tax Rate


- **FOB 
 Destination** - tax calculations depend on whether you checked the  **Apply tax rate to Add-on Costs**  option in the Tax Component profile.
- If the option  is checked, the tax calculates as follows:
Tax = ((Cost – Discount) + Add-on Costs) \* Tax Rate


- If the option  is unchecked, the tax calculates as follows:
Tax = (Cost – Discount) \* Tax Rate



**Tax Inclusive/Exclusive**


For items set as Tax Inclusive in the Items profile (path: Inventory  > Items > Options > Edit > In New Window > Purchases tab),  the system first deducts the tax from the item cost before subtracting  the Discount Value. Tax Exclusive items do not require any adjustments.


{:.example}
You have a purchase receipt set to FOB Destination  with two line items. The first line item has a tax component with the  **Apply tax rate to Add-on costs**  option checked, so the system includes the add-on costs in the calculation  for that item. The second line item has a tax component with the **Apply tax rate to Add-on Costs** option  unchecked, so the system omits the add-on costs for that item. In the  same scenario but with the purchase receipt set to FOB Origin, the system  does not include the add-on costs for either item.


If you enter the tax code after entering discount information, the system  recalculates the discount percent, discount value, and the cost after  discount.


By default, the tax is displayed in the currency defined for the selected  vendor. If the currency defined for the vendor is different from the base  currency, select **Options** >  **View** **in****Document** **Currency**  from the purchase document profile to view the tax amount in the base  currency.


Select the **View** **in****Document** **Currency**  option again to view the tax amount in foreign currency.


![]({{site.pp_baseurl}}/img/lens.gif) [Foreign Currency  Documents]({{site.pp_baseurl}}/purc-proc/doc-profile/contents/tabs/details/for-cur-info/foreign_currency_document.html)


Select the option **Tax** **Breakdown** (path: **Options**  > **Payment** > **Tax 
 Breakdown**) to view the tax component-wise breakup of taxes paid  on the document.


{:.see_also}
See also
: [Item Information]({{site.pp_baseurl}}/purc-proc/doc-profile/contents/item-info/item_information_pp.html)
: [Tax  Components]({{site.sc_chm}}/options/sales-tax/set-up-tax-codes-and-components/tax-component/tax_components.html)
: [Modify  Tax/Recoverable Tax Amounts]({{site.pp_baseurl}}/misc/modify_tax_recoverable_tax_amounts_purchase_process.html)
