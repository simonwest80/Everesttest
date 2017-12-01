---
title: Cost Column Logic for Items Browser
---

# Cost Column Logic for Items Browser


The costs displayed in the **Items** browser  depends on whether the Extended Mode is enabled or not.


Extended Mode Enabled


If the **Extended Mode** (path:  **File &gt; Setup &gt; Preferences &gt; 
 Work Station Settings** dialog box > **Company 
 Settings** tab **&gt;** check  **Enable extended mode**) is enabled,  the **Items** browser displays both  average and last cost of items without factoring.


Extended Mode Disabled


If the **Extended Mode** (path:  **File &gt; Setup &gt; Preferences &gt; 
 Work Station Settings** dialog box > **Company 
 Settings** tab **&gt;** uncheck**Enable extended mode**) is disabled, **** the costs displayed in the **Items**  browser depend on the flow control settings. These settings are defined  in the **Other Flow Control** dialog  box (path: **File &gt; Set up &gt; Preferences 
 &gt; Flow Control &gt; Other Flow Control** > **Item 
 Cost/Sales Summary** tab > **Type 
 of cost to be displayed in Inventory Browsers and Pricing Analysis**  field).


The table below details the costs that are displayed, based on the flow  control settings


| Cost Type Selected in Flow Control Settings | Cost Displayed in Items Browser | Status of Other Cost Columns in Items Browser |
| Average Cost | Average Cost | Last Cost column displays \*\*\*\* |
| Last Cost | Last Cost | Average Cost column displays \*\*\*\* |
| User Defined Costs | --- | Average & Last Cost columns display \*\*\*\* |
| None | --- | Average & Last Cost columns display \*\*\*\* |
| All | Average & Last Cost | --- |



{:.note}
When you disable extended mode, all costs  displayed are factored, if you have selected the **Factor 
 cost** check box (path: **File &gt; 
 Set up &gt; Preferences &gt; Flow Control &gt; Other Flow Control &gt; 
 Item Cost/Sales Summary**), and the item has factored cost percentages  defined.


![]({{site.mi_baseurl}}/img/lens.gif)[Calculations  for Viewing Stock in the Items Browser]({{site.mi_baseurl}}/misc/calculations_for_viewing_stock_in_the_items_browser_mi.html)


{:.see_also}
See also
: [Items Browser]({{site.mi_baseurl}}/the-items-browser/the_items_explorer.html)
