---
title: Calculations for Viewing Stock in the Items Browser
---

# Calculations for Viewing Stock in the Items Browser


| Field | View Stock in: |
| Stock Measure | Default Purchase Measure | Default Sales Measure |
| Average Cost | Shown in Stock Measure (Cost Decimal Accuracy) | Calculated using the conversion factor from the stock measure (Cost  Decimal Accuracy) | Calculated using the conversion factor from the stock measure (Sales  Price Decimal Accuracy) |
| Last Cost | Shown in Stock Measure (Cost Decimal Accuracy) | Shown in the default purchase measure (Cost Decimal Accuracy) | Shown in matching purchase measure or converted from last cost in stock  measure (Sales Price Decimal Accuracy) |
| Last Add-on Cost | Shown in Stock Measure (Cost Decimal Accuracy) | Shown in the default purchase measure (Cost Decimal Accuracy) | Shown in matching purchase measure or converted from last add-on cost  in stock measure (Sales Price Decimal Accuracy) |
| Last Landed Cost | Shown in Stock Measure (Cost Decimal Accuracy) | Shown in the default purchase measure (Cost Decimal Accuracy) | Shown in matching purchase measure or converted from last landed cost  in stock measure (Sales Price Decimal Accuracy) |
| Sell Price and Markup Price | Shown in default sales measure (Sales Price Decimal Accuracy) | Shown in default sales measure (Sales Price Decimal Accuracy) | Shown in default sales measure (Sales Price Decimal Accuracy) |
| Average Price\*<br/><br/><br/>[Field Chooser] | Shown in the item’s Stock Measure (Sales Price Decimal Accuracy) | Shown in the item’s Stock Measure (Sales Price Decimal Accuracy) | Shown in the item’s Stock Measure (Sales Price Decimal Accuracy) |
| Cost (High) and Cost (Low)<br/><br/><br/>[Field Chooser] | Shown in matching purchase measure or converts from default purchase  measure (Cost Decimal Accuracy) | Shown in default purchase measure (Cost Decimal Accuracy) | Shown in matching purchase measure or converts from the default purchase  measure to the stock measure and then to the default sales measure (Sales  Price Decimal Accuracy) |



\*The **Average Price** is the same  as the **Sell** field under the **Average Amounts** group in the Item Summary  for the item (path: **Items** browser  > **Options** > **Summary**  or press **Ctrl + T**). The system  calculates it as **Sales (amount)**  / **Sales (qty in item stock measure)**  under the **Sales** **Activities**  group. See [The Item Summary  Dialog Box]({{site.mi_baseurl}}/misc/the_item_summary_dialog_box.html) for detailed information.


{:.note}
- The **Stock 
 Measure** field shows the inventory unit of measure. You can also  locate the stock measure on the **Inventory**  tab of the **Item** profile. The **Stock** **Measure**  field is shown regardless of which **View**  menu option is selected for viewing stock.
- The **Total 
 Stock** and **Available Stock**  fields are stored in the stock measure up to 6 decimal places and converted,  using a conversion factor, to the default purchase or default sales measure.


{:.see_also}
See also
: [The Items Browser]({{site.mi_baseurl}}/the-items-browser/the_items_explorer.html)
