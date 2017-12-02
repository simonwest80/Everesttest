---
title: The Add-on Costs Profile
---

# The Add-on Costs Profile


Use the add-on cost profile to create and edit add-on costs elements  for use in distributing add-on costs across inventoried items.


**Add-on Cost ID**
: Specify the Add-on Cost ID for the add-on cost element.  This field is mandatory.


**Description**
: Specify the description for the Add-on Cost ID.  This field is mandatory.


**GL Account**
: Select the account you want to credit when you incur  add-on costs. Only accounts under the category Liability or Expense display.  The GL Account is not mandatory here; however, you must select an account  within the Add-on Costs Distribution dialog box when working with purchase  documents whose FOB Type is set to Origin.


**Distribution Method**
: You can allocate costs using any of the following  methods:

- Weight - Distribute  add-on costs in proportion to the weight of the items (i.e., items weighing  more take on more of the add-on cost). The weight of the item quantities  converts to kilograms based on the weight defined in the Item profile  (path: Inventory > Items > Options > Edit > In New Window  > Freight > Purchase tab).
- Amount – Distribute  add-on costs in proportion to the monetary value of the items (i.e., items  which cost more take on more of the add-on costs).
- Volume - Distribute  add-on costs in proportion to the volume of the items (i.e., items in  larger volume take on more of the add-on cost). The volume of the item  quantities converts to liters (for liquid volume) or cubic centimeters  (for solid volume) based on the volume defined in the Item profile (path:  Inventory > Items > Options > Edit > In New Window > Freight  > Purchase tab). Volumes can be expressed either as a liquid measure  or a solid measure. You can select this option only if the volume of all  items on the document use the same type of measure. If one item is a liquid  and the other is a solid, this option is disabled.
- Quantity –  Distribute add-on costs in proportion to the quantity of each item (i.e.,  items purchased in greater quantities take on more of the add-on cost).  The system considers the Ordered quantity for a purchase order, the Received  quantity for a purchase receipt, and the Invoiced quantity for a purchase  invoice. In a purchase receipt, if the purchase measure differs across  the inventoried line items the system alerts you and then simply uses  the quantity provided without regarding the purchase measure or converting  to the same unit of measure.
- User specified  - Enter the add-on costs manually for each item.

: The system distributes the add-on costs across all  of the inventoried items on a purchase document based on the method you  choose. This field is mandatory.


**Automatically display on the Add-on Costs Distribution  screen**
: Select this checkbox if you want this add-on cost  to appear in the Add-on Costs Distribution dialog box for each purchase  document.
: You may delete this row even if the system added  it automatically.
: If you do not check this, you may still add it as  a new row and choosing it from the drop-down box.


You need adequate security rights to create, modify, discontinue, or  reactive a discontinued Add-on Cost.


When you migrate from a 3.x version of Everest to Version 4.x, the system  creates an add-on cost ID called “Miscellaneous Add-on Costs” and  places  add-on costs on existing purchase documents in this default add-on cost  element. After the migration, the default account deactivates but remains  available for reactivation in [The  Discontinued Add-on Costs Browser]({{site.pp_baseurl}}/misc/discontinued_add_on_costs_browser_pur.html). Documents using this default add-on  cost process as usual, but new documents do not display it as an option.
