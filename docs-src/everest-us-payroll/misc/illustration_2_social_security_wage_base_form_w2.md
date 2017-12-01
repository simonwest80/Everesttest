---
title: Illustration 2
---

# Illustration 2


Illustration 2 pertains to cases where a payroll item, which is not  taxable to social security, is tracked to Box 7, for instance, Social  Security tips.


As a result, when Form W2 is generated, Box 7 shows the data for taxable  and non-taxable tips, while Box 4 displays the social security tax withheld  on the taxable tips and wages only. Box 3 is calculated after considering  the upper limit with the taxable tips only.


In such a scenario, **Everest**  informs you that the figures in Boxes 3 and 7 may not be correct.


The data in Box 3 is displayed after validating the upper limit and  considering only the taxable portion of tips. Once the upper limit is  reached, Box 3 retains its value while Box 7 continues to increase with  subsequent transactions by considering the non-taxable portion of the  tips also. You can either save this form and close it or close it without  saving, so that you can make changes to the **W2 
 Tracking** profile (path: **US Payroll 
 &gt; Setup &gt; W2 Tracking**).


Box 7 is tracked to the following:

- Tips 1, which is  taxable
- Tips 2, which is  non-taxable



|  | Values for Transaction 1, 2 and 3 |
| Tips 1 which is taxable | $30,000 |
| Tips 2 which is not taxable | $20,000 |
| Actual social security wages | $45,000 |



| Box | Display in Form W2<br/><br/><br/>Transaction 1 | Display in Form W2<br/><br/><br/>Transaction 2 | Display in Form W2<br/><br/><br/>Transaction 3 |
| Box 3 | $45,000 | $45,000 | $45,000 |
| Box 4 | 6.2% of (45000 + 30000) | 6.2% of (45000 + 30000 +15000) where only 15,000 can be considered as  taxable tips | 6.2% of (45000 + 30000 +15000) where only 15,000 can be considered as  taxable tips pertaining to 2nd transaction |
| Box 7 | $50,000 (30000 + 20000) | $85,000 (30000 + 20000 + 15000 +20000) where 15000 pertains to taxable  tips and 20,000 pertains to the non taxable tips | $85,000 (30000 + 20000 + 15000 +20000 +20000) where the last 20,000  refers to the non-taxable tips of the 3rd transaction |



In cases where Box 7 is tracked to non-taxable payroll items, you can  make changes to Box 3 and/or Box 7. **Everest**  once again validates the upper limit of the social security wages and  asks you to make the required changes in case you have exceeded the upper  limit.


{:.note}
When **Everest**  calculates the figures for box 3 and Box 7, it considers only the taxable  portion of Box 7. If you make adjustments to either Box 3 or Box 7, it  takes into account both the taxable and non-taxable items for validations.


{:.see_also}
See also
: [Validations  for Upper Limit (Social Security Wage Base)]({{site.prl_baseurl}}/misc/validations_for_yearly_upper_limit_(social_security_wage_base)_form_w2.html)
