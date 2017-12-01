---
title: VAT Process
---

# VAT Process

- Set up tax components  for the purchase aspect of the tax components.



![]({{site.sc_baseurl}}/img/lens.gif) [Tax  Components]({{site.sc_baseurl}}/options/sales-tax/set-up-tax-codes-and-components/tax-component/tax_components.html)

- Create tax codes  and attach the respective tax components to these codes.



![]({{site.sc_baseurl}}/img/lens.gif) [Tax  Codes]({{site.sc_baseurl}}/options/sales-tax/set-up-tax-codes-and-components/tax-code/tax_codes.html)

- Select the tax  code that is applicable for each line item on the purchase document.
- Based on the components  attached to the tax code selected, the Amount Recoverable (mentioned in  the Purchase tab of the **Tax** **Components** profile) is debited to the  GL Account.
- The non-recoverable  portion is debited to the GL  Account mentioned in the **Item**  profile (Asset Account or Inventory Account or Expense Account).
- Sales tax is accumulated  based on the tax jurisdiction selected in the sales document. All tax  components with debit and credit balances are listed. The net amount is  payable/recoverable.
- At the end of each  period, reports are generated based on the tax component to determine  the net amount of tax payable to, or refundable by the government.



{:.see_also}
See also
: [Sales Taxes]({{site.sc_baseurl}}/options/sales-tax/sales_taxes.html)
: [Value Added Taxes]({{site.sc_baseurl}}/options/sales-tax/value-added-taxes/value_added_taxes.html)
: [VAT on Purchases]({{site.sc_baseurl}}/options/sales-tax/value-added-taxes/vat_on_purchases.html)
: [VAT on Sales]({{site.sc_baseurl}}/options/sales-tax/value-added-taxes/vat_on_sales.html)
