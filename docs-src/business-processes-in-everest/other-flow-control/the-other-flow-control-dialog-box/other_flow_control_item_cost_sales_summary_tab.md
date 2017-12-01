---
title: Other Flow Control - Item Cost/Sales Summary
---

# Other Flow Control - Item Cost/Sales Summary


Item Cost


**Type of cost to be displayed in inventory browsers,  stock transfers and pricing analysis**
: Set the default item cost type to be displayed in  the **Items** browser, on stock transfer  documents and browsers, and the **Pricing****Analysis** dialog box.
: The prices displayed in these browsers depend on  whether you are in extended mode or not. All the costs of the item are  displayed as such when you are in extended mode. On clearing the **Enable Extended Mode** check box in the  **Workstation Settings** dialog box  (path: **File &gt; Setup &gt; Preferences 
 &gt; Workstation Settings**), the display of the different costs  varies, which is elucidated in the table below.


| Type of Cost | Type of Display | Applicable to Browser/Dialog Box |
| **Average Cost** | Displays only the average cost. All other costs are displayed in encrypted  form | **Items** browser<br/><br/><br/>**Pricing Analysis** dialog box<br/><br/><br/>**Stock Transfer** browser |
| **Last Cost/Last Landed Cost** | Displays only the last cost/last landed cost. All other costs are displayed  in encrypted form | **Items** browser<br/><br/><br/>**Pricing Analysis** dialog box |
| **Actual Cost** | Displays all costs in encrypted form | **Pricing Analysis**  dialog box |
| **User Defined** | Displays all costs in encrypted form | **Pricing Analysis** dialog box |
| **All&nbsp;&nbsp;** | Displays all costs | **Items** browser<br/><br/><br/>**Pricing Analysis**  dialog box |
| **None&nbsp;&nbsp;** | Displays all costs in encrypted form | **Items** browser<br/><br/><br/>**Pricing Analysis** dialog box<br/><br/><br/>**Stock Transfer** browser |



**Type of cost used for commission calculation**
: Set the default cost to be used while computing  commissions.


| **Average Cost** | Computes commission based on the average cost of the item. The average  cost of the item in the stock measure is converted to the sales measure  based on the conversion factor. |
| **Last Landed Cost** | Computes commission based on the last landed cost of the item. The last  landed cost of the item in the stock measure converts to the sales measure  based on the conversion factor if there is no available non-zero cost  defined for the purchase measure matching the sales measure. If a non-zero  cost defined for the purchase measure matching the sales measure is available,  the system uses the last landed cost from the **Purchases**  tab of the item. |
| **Actual Cost** | Computes commission based on the actual cost of the item. For serialized  items in the stock measure, actual cost is converted to the sales measure.  For inventoried items, the actual cost is the average cost converted to  the sales measure. |
| **User Defined** | Computes commission based on the user defined cost of the item. The  user defined cost for inventoried and serialized items, is the cost entered  in the sales documents for the measure. The user defined cost for the  selected measure is not converted. |



{:.note}
- If the type of  cost selected in the **Type of cost to 
 be displayed in inventory browsers, stock transfers and pricing analysis**  field differs from the cost type selected in the **Type 
 of cost used for commission calculation** field, **Everest**  prompts you to confirm whether you want to continue using these differing  cost types.
- Costs shown in  the Commission report are shown in the sales measure.


**Default value for the user defined cost column  in a document**
: Set a default value for the user defined cost column  in a document.


| Average Cost | Displays the average cost. |
| Last Landed Cost | Displays the last landed cost. |
| None | Does not display cost. |



**Factor Cost (enable cost inflation)**
: Select this check box if the costs considered for  calculating commissions based on profit use factored costs. By default,  this will be selected.
: ![]({{site.bp_baseurl}}/img/lens.gif) [Factored  Costs]({{site.mi_chm}}/item-profile-details/item-costing/factored_cost_item_costing.html) ****


**Commission based on**
: Specify the basis for commission. This option specifies  whether commission reports are calculated based on the item profit (i.e.  selling price less the cost) or its sales price.


| **Profit** | Computes commission based on the profit. |
| **Sale** | Computes commission based on the sales. |



{:.see_also}
See also
: [Other  Flow Control]({{site.bp_baseurl}}/misc/other_flow_control_introduction.html)
