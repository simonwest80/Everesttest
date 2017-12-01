---
title: Calculation of Sales Tax
---

# <font color="#000000" class="hcp1">Calculation of Sales Tax</font>


Sales tax is applied to sales documents automatically. This section  describes how **Everest** determines  which sales tax must be applied to a sales document.


Sales tax is charged based on the delivery method, login  country, login  state, the jurisdiction and the special tax rules.


**Tax is computed in a two-step process:**

- The jurisdiction  is first **** determined.
- The tax code  to be applied is then determined.



**Step 1**
: **Everest**  determines the jurisdiction based on the following:

- The delivery  method in the sales document.
- The country  of the login  jurisdiction.
- The customer's  country contained in the <font face="Verdana" class="hcp3">'</font>Ship to Address<font face="Verdana" class="hcp3">'</font>.
- The customer's  state/province contained in the <font face="Verdana" class="hcp3">'</font>Ship to Address<font face="Verdana" class="hcp3">'</font>.



<font color="#000000" class="hcp1">For a graphical representation 
 of how the tax jurisdiction is determined, click </font>[here]({{site.sc_baseurl}}/options/sales-tax/determination_of_jurisdiction_flowchart.html)<font color="#000000" class="hcp1">. </font>


**Step 2**
: In this step, **Everest**  checks whether any Special Tax Rule is defined for that jurisdiction/state  for the particular item, category, customer or customer class. If a special  tax rule is defined, the associated tax code is applied to the line item.  Otherwise, the tax code of the jurisdiction determined in Step 1 is applied.


{:.note}
The <font face="Verdana" class="hcp3">'</font>Ship to Address<font face="Verdana" class="hcp3">'</font> is only considered if the delivery method is  of the type 'Common Carrier'. If the shipping address is left blank on  a sales order or invoice, but the delivery method is of the type <font face="Verdana" class="hcp3">'</font>Common Carrier<font face="Verdana" class="hcp3">'</font>, **Everest** assumes that the 'billing address'  of the customer is also the 'shipping address', and sales tax is calculated  based on this address. If the delivery method is not of the type "Common  Carrier", **Everest** calculates  sales tax based on the login  jurisdiction.


{:.see_also}
See also
: [Detailed  Summary of Tax Calculation and Reporting in Everest]({{site.sc_baseurl}}/options/sales-tax/detailed_summary_of_tax_calculation_and_reporting_in_everest_sc.html)
: [Sales Taxes]({{site.sc_baseurl}}/options/sales-tax/sales_taxes.html)
