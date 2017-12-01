---
title: Pricing Analysis Dialog Box
---

# Pricing Analysis Dialog Box


The critical or minimum mark up/margin is specified in the **Pricing 
 Analysis** dialog box (path: **File 
 &gt; Setup &gt; Preferences &gt; Defaults &gt; Pricing Analysis**).  This feature allows you to ensure that the selling price of the item does  not fall below the critical or minimum margins or mark up.


Analysis By
: This option allows you to specify whether the pricing  analysis is to be based on [markup]({{site.sp_baseurl}}/misc/mark_up_on_cost_pricing_analysis.html)  or [margin]({{site.sp_baseurl}}/misc/preferred_margin_on_sales_pricing_analysis.html).


**Markup**
: Select **Markup**  and specify **Minimum markup** and  **Critical** **markup**  percentages.


**Margin**
: Select **Margin** to  specify **Minimum margin** and **Critical margin** percentages.


**Start Rate**
: Enter the rate at which the pricing analysis should  begin.


**Step Rate**
: Enter the step up value at which the subsequent  rates should be increased.


**Minimum Markup/Margin**
: Minimum margin/markup is set up to ensure that the  gross margin covers selling, distribution and operation costs. Enter the  minimum mark-up or margin that a sales representative can sell at. A user  with appropriate security rights can bypass this setting.


**Critical Mark-up/Margin**
: Critical margin/markup is set up to ensure that  the gross margins cover at least operational costs. Enter the absolute  minimal (critical) mark-up or margin for a sale in this field. A user  with appropriate security rights can bypass this setting. Typically, a  sales manager can be given rights to change this value.


{:.note}
The **Critical Markup/Margin**  must be less than the **Minimum Markup/Margin**.   The minimum  markup/margin and critical markup/margin is based on all items in the  document, if the user is in extended mode. When not in extended mode,  it is based only on commissionable items. If there are any non-commissionable  items in the document, they are not considered for checking the validations  of minimum markup/margin and critical markup/margin.


The critical and minimum margin/mark-ups are based on  the [cost  type]({{site.sp_baseurl}}/sales-docs/sqs/sq-proc/pricing-analysis/maintaining_critical_and_minimum_markup_margin_on_sales.html#costtype) selected for commission calculations in the flow control preferences.


**Apply Critical and Minimum Mark-up/Margins to  POS Invoices**
: Check this option to ensure that the minimum and  critical margin/markup is applied to POS invoices. This check box is selected  by default.
: To disregard this setting, you must have adequate  security rights.
: If this option is selected and a user with the necessary  rights saves an invoice with a document value below the minimum and critical  margin/markup, an event is triggered to record this occurrence.
: If you clear this check box, you can save a POS  invoice even if its total value is below the critical and minimum margin/markup.


{:.see_also}
See also
: [Pricing Analysis]({{site.sp_baseurl}}/sales-docs/sqs/sq-proc/pricing-analysis/pricing_analysis.html)
: [The Pricing  Analysis Browser]({{site.sp_baseurl}}/sales-docs/sqs/sq-proc/pricing-analysis/the_pricing_analysis_browser.html)
: [Maintaining  Critical and Minimum Markup/Margin on Sales]({{site.sp_baseurl}}/sales-docs/sqs/sq-proc/pricing-analysis/maintaining_critical_and_minimum_markup_margin_on_sales.html)
