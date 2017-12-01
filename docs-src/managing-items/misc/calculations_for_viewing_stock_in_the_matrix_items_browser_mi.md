---
title: Calculations for Viewing Stock in the Matrix Items Browser
---

# Calculations for Viewing Stock in the Matrix Items Browser


| Field | View Stock in: |
| Stock Measure | Default Purchase Measure | Default Sales Measure |
| Average Cost | Shown in Stock Measure (Cost Decimal Accuracy) | Calculated using the conversion factor from the stock measure (Cost  Decimal Accuracy) | Calculated using the conversion factor from the stock measure (Sales  Price Decimal Accuracy) |
| Last Cost | Shown in Stock Measure (Cost Decimal Accuracy) | Shown in the default purchase measure (Cost Decimal Accuracy) | Shown in matching purchase measure or converted from last cost in stock  measure (Sales Price Decimal Accuracy) |
| Sell Price and Markup Price | Shown in default sales measure (Sales Price Decimal Accuracy) | Shown in default sales measure (Sales Price Decimal Accuracy) | Shown in default sales measure (Sales Price Decimal Accuracy) |
| Cost (High) and<br/><br/><br/>Cost (Low)<br/><br/><br/>[Field Chooser] | Shown in matching purchase measure or converts from default purchase  measure (Cost Decimal Accuracy) | Shown in default purchase measure (Cost Decimal Accuracy) | Shown in matching purchase measure or converts from the default purchase  measure to the stock measure and then to the default sales measure (Sales  Price Decimal Accuracy) |



**Stk Measure**
: This field shows the stock unit of measure. You  can also locate the stock measure on the **Inventory**  tab of the **Item** profile. The **Stk Measure** field is shown regardless  of which **View Menu** option is selected  for viewing stock.


{:.note}
The following fields are stored in the stock measure up to 6 decimal  places and converted, using a conversion factor, to the default purchase  or default sales measure:


• Total Stock


• Available Stock


• Free Stock


• On Credit


• On Order


• On Credit Committed


• On Order Committed


• On Reserve Committed


• On RMA Committed


• On Reserve


• On RMA


{:.see_also}
See also
: [The  Matrix Items Browser]({{site.mi_baseurl}}/creating-matrix-group-and-matrix-items/the_matrix_items_browser.html)
