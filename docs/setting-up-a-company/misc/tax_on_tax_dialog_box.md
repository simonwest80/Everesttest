---
title: Tax on Tax Dialog Box
---

# Tax on Tax Dialog Box


Tax components can be individually taxable in some cases. This means  that tax is also calculated on the tax that is computed based on the selected  tax component. Click the ![]({{site.sc_baseurl}}/img/setup_browse_icon.gif) icon in the **Tax 
 Base** column (path: **Tax Code**  profile > **Tax Components Assigned**  grid) and you will see the **Tax on Tax**  dialog box. Choose the base amounts on which tax will be computed for  the selected tax component.


| ![]({{site.sc_baseurl}}/img/example.gif) | Virginia Sales Tax (VST45) of 4.5% includes three components. State  Duty is individually taxable. See table below:<br/><br/><br/><font style="color: #000000;" color="#000000">Item sales price - $50.00</font><br/><br/><br/>| Tax Component Description | Order | Taxable | Rate (%) |<br/>| State Duty (SD05) | 1 | Yes | 0.50 |<br/>| County Sales Tax (CS015) | 2 | No | 1.50 |<br/>| State Sales Tax (SS025) | 3 | No | 2.50 |<br/><br/><br/><br/>Taxes are calculated on an invoice as follows:<br/><br/>- The State Duty is  first calculated on the item price ($50 x 0.5% = $0.25).<br/>- The County Sales  Tax and the State Sales Tax are calculated for the item after adding the  State Duty ($50.25 x 1.5% = $0.75; $50.25 x 2.5% = $1.26).<br/>- The invoice total  is the total of the item price and all the taxes. Invoice total = $52.26  ($50 + $0.25 + $.0.75 + $1.26).<br/><br/><br/><br/>The Tax Component 'State Duty' is defined  as taxable and therefore 'County Sales Tax' and 'State Sales Tax' are  computed for the item after first adding 'State Duty' to the item price.<br/><br/><br/>The taxes applicable to an item of $100 are  State Duty at 10 percent and County Sales Tax at 5 percent. The tax component  ‘State Duty’  is taxable. The tax would therefore be computed as 100\*10% + (100 + (100\*10%))\*5%  = $15.50. |

