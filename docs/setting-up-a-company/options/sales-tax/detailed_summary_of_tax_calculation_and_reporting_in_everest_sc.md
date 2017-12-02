---
title: Detailed Summary of Tax Calculation and Reporting in Everest
---

# Detailed Summary of Tax Calculation and Reporting in Everest


Taxes rates assigned to sales documents are calculated based  on the “Ship to Address” where the items are delivered. For Point of Sale  transactions, the customer picks up items from your store and the tax  rate applicable to the logged in jurisdiction is applied.


“Jurisdictions” must be created in **Everest**  to define the delivery areas (typically counties and/or cities) that must  have tax reported.  Jurisdictions  are setup based on FIPS codes which are provided by the USPS. Once the  correct Jurisdiction is identified for a sales transaction, the tax rate  applicable to the locale will be applied to all line items in the document.


Tax rates are defined as “tax components” in **Everest**.  Exceptions to the tax rate assigned can be made based on product or customer  class. Using an **Everest** special  tax rule, the system can automatically apply alternative tax codes to  items of a specific category. Customers that have provided a tax ID number  can be setup as exempt of all sales tax.


The **Sales Tax Report**  under the **Reports** > **Accounting**  menu will report sales tax details on all transactions that occur within  a specific date range. Taxes are reported based on the date a product  is shipped, not the date it was ordered. Totals for each jurisdiction  are reported separately.


Taxable and Exempt revenue are displayed in separate columns,  along with the calculated tax value for the transaction. Similarly, taxable  and exempt returns are also reported separately.
: ![]({{site.sc_baseurl}}/img/lens.gif)[Sales  Tax Report]({{site.rpt_chm}}/everest-reports/accounting/sales_tax.html)


{:.see_also}
See also
: [Sales Taxes]({{site.sc_baseurl}}/options/sales-tax/sales_taxes.html)
: [Calculation  of Sales Tax]({{site.sc_baseurl}}/options/sales-tax/calculation_of_sales_tax.html)
