---
title: Tax Component - Sales Information
---
<script type="text/javascript" language="JavaScript1.2" x-save-method="compute-relative" src="{{site.sc_baseurl}}/misc/ehlpdhtm.js"></script><script type="text/javascript" language="JavaScript1.2">
<!-- 
if( typeof( kadovFilePopupInit ) != 'function' ) kadovFilePopupInit = new Function();if( typeof( kadovTextPopupInit ) != 'function' ) kadovTextPopupInit = new Function();
 //-->
</script>
This field allows you to select a method to calculate the sales tax  collected on this component. The following options are available:

- **Percentage 
 of Cost** - This option allows you to specify the calculation method  in terms of percentage, based on the actual cost in case of serialized  items and average cost in case of non-serialized and non-inventoried items.  The **Tax Rate Type** field  is  disabled and defaults to Flat Rate. Specify the percentage in the **Tax Rate** column in the **Sales 
 Tax Rates** grid.
- **Amount 
 Per Unit Quantity -** This option allows you to specify the calculation  method based on the amount specified per unit quantity of the item. The  **Tax Rate Type** field is disabled  and defaults to Flat Rate.
- **Percentage 
 of Sales Price** - allows you to specify the calculation method in  terms of percentage, based on the selling price of the item. The percentage  can be a flat rate or based on item price tiers.

Specify whether you want to tax items as a flat rate or based on item  price slabs. The following options are available:

- **Flat 
 Rate** - Select this option if you want to calculate tax on the items  based on the percentage of the sales price. Enter the percentage in the  Tax Rate field of the Sales Tax Rates grid. Items will be charged at the  specified rate irrespective of the selling price of the item.
- **Item 
 Price Tiers** - In certain states items are taxed at rates varying  with the sell price of the item.



{:.example}
Item price is US$  4000.00.


First US$1,600 is taxed at 5%.


Price range from 1600.01 to US$3200 is taxed at 7%


Price range above US$  3200.01 is taxed at 0 % (Exempt).


Selecting the item price tiers option allows you to specify different  tax rates based on different selling prices of the item in the **Sales 
 Tax Rates** grid.

This section allows you to enter the tax rate for a range of item prices.  The first tier’s starting value displays zero (base currency). Enter the  ending range for the item price for the first tier in the **Item 
 Price To** field. The price tier value cannot be negative and the  **Item Price To** value cannot be  less than the corresponding **Item Price 
 From** value. The **Item Price From**  value for the subsequent tier displays the previous tier’s **Item 
 Price To** value + 1 subunit of the base currency.

This field allows you to specify the sales measure to be considered  while calculating the tax collected for the component.


Sales measures identify the quantity of items sold, which could either  be in a single unit or multiple units.


{:.example}
Hour, inch, foot, yard, pint, quart, gallon, bushel, ounce, pound, each,  six-pack, case, dozen, hundred.


{:.warn}
If the sales measure specified here is different  from the sales measure specified in the **Item**  profile for a particular item (X), then the tax calculated might be incorrect  when the item (X) is selected in the sales document.

This option allows you to specify a limit if any, on the amount of tax  on a tax component as well as the base on which the limit will be determined.  The following options are available:

- **None**  - If you do not want to specify a limit on the amount of tax, select this  option.
- **Line 
 Item Amount** - This option allows you to specify a limit on the  amount of tax, based on a line item value.
- **Current 
 Component Tax** - This option allows you to specify a limit on the  amount of tax, based on the current tax component.
- **Exempt 
 if line item amount exceeds specified value** - Select this option  if tax is not to be charged if the line item amount exceeds the value  specified in the Maximum Line Item Amount field.



{:.example}
If you have specified the maximum line item amount in the **Tax 
 Component** profile as  $1000  and a line item exceeds $1000, the tax component is not applicable on  the said item if you select the option **Exempt 
 if line item amount exceeds specified value**.

If a tax inclusive item is associated with  a tax code that has one or more tax components with a tax limit base specified,  and that item is included in a sales document, **Everest**  informs you that tax cannot be computed properly for the item and another  tax code must be selected. **Everest**  does not allow the use of that tax code with the tax inclusive item.


Where the tax component has a base limit,  items should be set with tax exclusive price wherever possible. In case  a tax component with a tax limit base is associated with a tax inclusive  priced item, you may manually select an alternative valid tax code for  such items if desired.


Items must preferably be set up with tax exclusive  prices. In case this is not feasible for any reason, in states with tax  components that have tax base limits, separate item codes must be set  up for the same items with tax exclusive prices.


When saving a sales document (SO or SI),  if one or more line items’ tax code field is blank, **Everest**  warns you of the same.

# Tax Component - Sales Information


**[**Calculation 
 Method**](javascript:kadovTextPopup(this)){:id="a1"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a1');
//--></script>**


**[**Tax 
 Rate Type**](javascript:kadovTextPopup(this)){:id="a2"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a2');
//--></script>**


**[Sales  Tax Rates Grid](javascript:kadovTextPopup(this)){:id="a3"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a3');
//--></script>**


**[Sales  Measure](javascript:kadovTextPopup(this)){:id="a4"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a4');
//--></script>**


**[Tax Limit  Base](javascript:kadovTextPopup(this)){:id="a6"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a6');
//--></script>**


**[Maximum  Line Item Amount](javascript:kadovTextPopup(this)){:id="a7"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a7');
//--></script>**


{:.see_also}
See also
: [Tax  Component Details]({{site.sc_baseurl}}/options/sales-tax/set-up-tax-codes-and-components/tax-component/tax_component_profile_information.html)
