---
title: Illustration 1
---

# Illustration 1


Illustration 1 pertains to the year 2009 wherein the upper limit of  the social security wages is $106,800.


| Transaction 1 - January 2009 | Display in Payroll Transaction profile |
| Employee | A |
| Social Security Tips (in transaction profile)\* | $80,000 |
| Social Security Wages -Taxable Amount field in Employee tab (includes  tips of 80000) | $138,065 |
| Social Security tax withheld<br/><br/><br/>($106,800\*6.2%) | $6,621.60 |



\*Social Security Tips is denoted in the **Payroll 
 Transaction** profile as Third Party Payments (path: **US 
 Payroll &gt; Processing &gt; Payroll Transactions &gt; Edit &gt; In New 
 Window &gt; Payroll Transaction** profile **&gt; General** tab **&gt; Totals**  section).


| Box | Display in Form W2 |
| Box 3 | $26,800 (106,800 – 80,000) |
| Box 4 | $6,621.60<br/><br/><br/>(Limit of 2007 $106,800\*6.2%) |
| Box 7 | $80,000 |



{:.steps}
The procedure for calculating values for  Form W2 is as follows:

- Calculate the value  for Box 7 first and store it in memory.
- Box 3 is calculated  in either of the two ways, whichever is lower:
- The difference  between Upper Limit and Box 7, that is, $26,800 (106,800-80,000)
- Actual Social  Security wages portion, that is, $58,065 (138,065-80,000)



![]({{site.prl_baseurl}}/img/hint.gif)To calculate  the Actual Social Security Wages portion of a transaction, deduct the  Social Security Tips from the taxable amount of Social Security for the  employee (path: **US Payroll &gt; Processing 
 &gt; Payroll Transactions &gt; Edit &gt; In New Window &gt; Payroll Transaction** profile **&gt; Employee Taxes** tab **&gt; Taxable Amount** section).


| Transaction 2 - February 2009 | Display in Payroll Transaction profile |
| Employee | A |
| Social Security Tips (in transaction profile) | $80,000 |
| Social Security Wages -Taxable Amount field in Employee tab (includes  tips of 80000) | $138,065 |
| Social Security tax withheld (106,800\*6.2%) | $0<br/><br/><br/>![]({{site.prl_baseurl}}/img/note.gif) Since the social security tax can never exceed $6,621.60  in this year, it should be displayed as 0 once this limit is reached. |



| Box | Display in Form W2 |
| Box 3 | $26,800 ($106,800 – $80,000)<br/><br/><br/>![]({{site.prl_baseurl}}/img/note.gif) Since the sum of box 3 and 7 has already reached its  upper limit of $106,800 in the previous transaction, Box 3 cannot display  a value other than $26,800. |
| Box 4 | $6,621.60<br/><br/><br/>![]({{site.prl_baseurl}}/img/note.gif) Once it has reached this value in the previous transaction,  no further transactions will affect this amount. |
| Box 7 | $80,000<br/><br/><br/>![]({{site.prl_baseurl}}/img/note.gif) Since the sum of box 3 and 7 has already reached its  upper limit of $106,800 in the previous transaction, no extra value can  be included from this transaction. |



| Transaction 3 - March 2009 | Display in Payroll Transaction profile |
| Employee | B |
| Social Security Tips (in transaction profile)\* | $40,000 |
| Social Security Wages -Taxable Amount field in Employee tab (includes  tips of 80000) | $106,800 |
| Social Security tax withheld<br/><br/><br/>(106,800\*6.2%) | $6,621.60 |



| Form W2 | Display for Employee A | Display for Employee B |
| Box 3 | $26,800 ($106,800 – $80,000) | $66,800 ($106,800 – $40,000) |
| Box 4 | $6,621.60 | $6,621.60 |
| Box 7 | $80,000 | $40,000 |



In the illustration given above, it is assumed that Box 7 is tracked  to only one payroll item that is taxable to social security.


{:.see_also}
See also
: [Validations  for Upper Limit (Social Security Wage Base)]({{site.prl_baseurl}}/misc/validations_for_yearly_upper_limit_(social_security_wage_base)_form_w2.html)
