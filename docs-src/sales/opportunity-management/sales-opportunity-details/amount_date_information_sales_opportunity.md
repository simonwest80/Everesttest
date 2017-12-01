---
title: Amount/Date Information - Sales Opportunity
---

# Amount/Date Information - Sales Opportunity


**Value**
: The value of the sales opportunity:

- Is the gross  sales value that is expected from the sale.
- Is not the  margin or profit expected on the sale.
- Must be entered  in the base currency. If the customer's currency differs from the base  currency:


- The value is  automatically computed when you enter the sales value in foreign currency  in the **Forex 
 value** field of the **Documents** tab  in this profile.
- When you enter  the value in base currency in this field, the **Forex 
 value** field is automatically updated with the value on foreign  currency.

: Where the sales quote, order or invoice is directly  created, this field displays the value in base currency for that document.


**Probability**
: The probability that an opportunity in this stage  would be converted to a sale is entered as a percentage in this field.  Entering this data helps in statistical estimation of future cash inflows.
: This is a numeric field. By default, this field  displays the probability percentage for the selected stage as entered  in the **Sales Stage** profile (path:  **CRM 
 &gt; Opportunity Management &gt; Setup &gt; Sales Stage &gt;** **Options** > **Edit**  > **In New Window**). You can change  the probability percentage if required.
: If you change the stage of the sales opportunity,  **Everest** asks you to confirm whether  the probability must be replaced with the probability defined for the  new stage.


**Probable Value**
: The probable value is calculated by multiplying  the probability of converting the opportunity to a sale with the value.
: Probable Value = Probability x Value
: ![]({{site.sp_baseurl}}/img/example.gif) If the estimated value of the sales opportunity is $10000  and the probability is 50% at stage 4, the probable value will be 10000\*50%  = $5000.
: The probable value  helps to estimate the value of probable sales.


**Estimated Close Date**
: This date helps to evaluate the value of your sales  and future cash inflows.


{:.see_also}
See also
: [Amount/Date  section - Sales Opportunity Profile - General tab]({{site.sp_baseurl}}/misc/amount_date_sales_opp_general_tab.html)
: [Sales  Opportunity Profile Details]({{site.sp_baseurl}}/opportunity-management/sales-opportunity-details/sales_opportunity_profile_details.html)
