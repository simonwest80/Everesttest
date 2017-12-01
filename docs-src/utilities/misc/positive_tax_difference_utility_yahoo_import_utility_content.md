---
title: Positive Tax Difference
---

# Positive Tax Difference


Positive Tax Difference implies that the tax calculated in **Everest**  is less than the tax calculated on the online store.


In such cases, the non-inventoried item specified in the **Item 
 to be used for adjusting Positive Tax Difference** field (**Sales Order Import Preferences** profile  > **General** tab) is used to adjust  the positive tax difference and is included as a line item in the sales  document. A negative quantity is populated in the '**Quantity**'  column and the amount of difference is populated in the '**Price**'  column of the sales document.


The non-inventoried item specified here is not taxable and therefore,  you must create a special tax rule exempting the selected item and jurisdiction.  If a special tax rule does not exist for the item and jurisdiction (of  the sales order), **Everest** creates  a new special tax rule to account for the tax difference.


{:.see_also}
See also
: [Tax  Codes]({{site.sc_chm}}/options/sales-tax/set-up-tax-codes-and-components/tax-code/tax_codes.html)
: [Special  Tax Rules]({{site.sc_chm}}/options/sales-tax/special-tax-rules/special_tax_rules.html)
: [Sales  Orders]({{site.sp_chm}}/sales-docs/sales-orders/sales_orders.html)
: [Tax  Calculations and Adjustments]({{site.utl_baseurl}}/db-utils/so-import/prefs/details/tax_calculations_and_adjustments_order_import_preferences_utility_main_content.html)
