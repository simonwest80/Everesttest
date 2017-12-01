---
title: Cost Column Logic for Serial Numbers Browser
---

# Cost Column Logic for Serial Numbers Browser


The costs displayed in the **Serial Numbers** browser depends on whether the Extended Mode is enabled or not.


Extended Mode Enabled


If the **Extended Mode** (path:  **File &gt; Setup &gt; Preferences &gt; 
 Work Station Settings** dialog box > **Company 
 Settings** tab **&gt;** check  **Enable extended mode**) is enabled,  the **Serial Numbers** browser displays  both average and last cost of items without factoring.


Extended Mode Disabled


If the **Extended Mode** (path:  **File &gt; Setup &gt; Preferences &gt; 
 Work Station Settings** dialog box > **Company 
 Settings** tab **&gt;** uncheck**Enable Extended Mode**) is disabled, **** the costs displayed in the **Serial 
 Numbers** browser depend on the flow control settings. These settings  are defined in the **Other Flow Control**  dialog box (path: **File &gt; Set up &gt; 
 Preferences &gt; Flow Control &gt; Other Flow Control** dialog box  > **Item Cost/Sales Summary** tab  > **Type of cost to be displayed in 
 Inventory Browsers and Pricing Analysis** field).


The table below details the costs that are displayed, based on the flow  control settings


| **Cost Type Selected <br/> in Flow Control Settings** | **Cost Displayed in Serial <br/> Numbers Browser** |
| Average Cost | -- |
| Last Cost | -- |
| Actual Cost | Actual Cost |
| User Defined Costs | --- |
| None | -- |
| All | Actual Cost |



{:.note}
If  you disable extended mode, all costs displayed are factored, if cost factoring  is enabled in **Factor cost** check  box (path: **File &gt; Set up &gt; Preferences 
 &gt; Flow Control &gt; Other Flow Control** dialog box > **Item Cost/Sales Summary** tab), and the  item has factored cost percentages defined.


{:.see_also}
See also
: [Serial  Numbers Browser Options]({{site.wm_baseurl}}/serial-num-trk/serial-number-details/browser/serial_numbers_browser_options.html)
