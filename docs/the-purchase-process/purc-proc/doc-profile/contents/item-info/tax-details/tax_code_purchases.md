---
title: Tax Code
---

# Tax Code


The **Tax** **Code**  column allows you to select the appropriate tax code. You can specify  a tax code in the **Vendor** profile  (path: **Purchasing &gt; Vendors &gt; Options 
 &gt; Edit &gt; In New Window &gt; Accounting tab &gt; Default Tax Code**  field) to automate the determination of tax codes for line items in purchase/purchase  return documents. You can modify the tax code even after saving the purchase  document.


**Everest** checks for the existence  of any special tax rules **** defined  for the vendor and item or category combination. If special tax rules  are not defined, the **Default Tax Code**  as specified for the vendor is used. You can modify this tax code.


![]({{site.pp_baseurl}}/img/lens.gif)  [Special  Tax Rules]({{site.sc_chm}}/options/sales-tax/special-tax-rules/special_tax_rules.html)


<font style="color: #000000;" color="#000000">However, if a tax code or special tax rule is NOT 
 associated with the vendor, you must manually select a tax code.</font>


If the tax code selected has a VAT/GST  tax component, then the amount of tax recoverable is treated as an asset.  The amount of tax that is not recoverable adds to the value of the item.  Tax recoverable is shown in the **Recoverable****Tax** column, and the total tax  amount is shown in the **Tax** **Amount** column.


The amount of tax recoverable is treated as an asset when the item is  purchased. If the item is returned, this amount is credited to the Asset  account associated with the tax component.


![]({{site.pp_baseurl}}/img/steps.gif)To modify the tax code column, do the following:

- Place your  cursor in the **Tax Code** column  and click **Enter**.
- Click the drop-down  button and select a tax code. The selected tax code is displayed in the  **Tax Code** column ****



{:.see_also}
See also
: [Item Information]({{site.pp_baseurl}}/purc-proc/doc-profile/contents/item-info/item_information_pp.html)
: [Tax  Codes]({{site.sc_chm}}/options/sales-tax/set-up-tax-codes-and-components/tax-code/tax_codes.html)
: [VAT  - Purchase]({{site.sc_chm}}/options/sales-tax/value-added-taxes/vat_on_purchases.html)
