---
title: Employee Taxes
---

# Employee Taxes


The **Employee Taxes** tab displays  the federal, state and local taxes to be withheld from the employee's  paycheck for the specified payroll period.


Taxable Amount


This section displays the amount that is taxable to federal, state and  local taxes.


{:.note}
These fields will be disabled, if you have  not set up any of these taxes for the employee in the **Taxes**  tab of the **Employee** profile (path: **Payroll &gt; Employees &gt; Employee Data**  and from the **Employees** browser,  double-click the required record).


For each employee transaction, **Everest**  calculates the year-to-date ‘Social Security taxable amount’. This year-to-date  amount is calculated by summing up the social security taxable amount  of all the previous transactions for the same calendar year, irrespective  of whether checks have are been  printed  or not for those transactions. This year-to-date amount is compared to  the Social Security Wage Base and tax is calculated based on the lower  of the following amounts:

- Sum of only the  Actual Social Security Wages portion of the transaction.
- The difference  between Upper Limit (social security wage base) and the year-to-date social  security taxable amount.



Taxes Deducted


This section displays the federal, state and local tax amounts withheld  from the employee's paycheck. All the fields can be edited. But once you  save the **Payroll Transaction** profile  you cannot edit the fields.


{:.note}
If you change the regular, overtime, vacation  or sick hours or the amount in the **Additional 
 earnings and deductions** grid, then **Everest**  recalculates these taxes and you will lose all modifications made to these  fields.


The amount displayed in the **Social 
 Security** field of the **Taxes Deducted**  section of the **Payroll Transaction**  profile (path: **US Payroll &gt; Processing 
 &gt; Payroll Transactions &gt; Edit &gt; In New Window &gt; Payroll Transaction** profile **&gt; Employee Taxes** tab **&gt; Taxes Deducted** section) is calculated  as below:


(Social security tax rate \*  Social  security taxable amount)


Though the social security taxable amount is not restricted by the wage  base, the social security tax deducted considers the wage base.


{:.example}
Social Security Taxable Amount for 2005 =  $ 100,000


Social Security Tax Deducted for 2005 = $5,580  ($90,000 \*  6.2%)


{:.see_also}
See also
: [Payroll  Transaction Details]({{site.prl_baseurl}}/payroll-process/transaction-details/the_payroll_transactions_profile.html)
: [Validations  for Upper Limit (Social Security Wage Base)]({{site.prl_baseurl}}/misc/validations_for_yearly_upper_limit_(social_security_wage_base)_form_w2.html)
