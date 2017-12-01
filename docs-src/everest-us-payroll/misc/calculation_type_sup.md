---
title: Calculation Type
---

# <font style="font-family: Verdana;" face="verdana">Calculation Type</font>


The calculation type identifies how the payroll item's amount is calculated.


{:.example}
Sales commission may be calculated as a percentage  of sales. Mileage reimbursement may be calculated as a rate multiplied  by the kilometers traveled. Bonus may be paid as a flat amount.


If the calculation type is percentage or rate, then the amount of payroll  item is calculated for the base amount every payroll period. The calculation  type for the same item may differ from employee to employee in the same  organization.


{:.example}
A sales person may be paid an incentive based  on percentage whereas a factory worker may be paid a flat amount of incentive  every payroll period.


**Amount, Rate  and Percentage**
: Depending on the calculation type, the amount, rate  or percentage of payment has to be specified.


{:.example}
If the calculation type is rate, then you  need to enter the rate of payment in the **Amount**  field. If it is percentage, then you need to enter the percentage in the  **Amount** field.


{:.note}
In case of items in salary type, regular pay,  overtime pay, sick pay, vacation pay, sick accrual or vacation accrual,  the amount or rate must be specified in the **General**  tab of the **Employee Template**.


You cannot specify the calculation type for standard earnings in the  **Employee Template**. For standard  earnings, the amounts are calculated based on the details specified in  the **Payroll Transactions** dialog  box, while processing the transaction.


You can specify the calculation type as rate or percentage for the following  types of payroll items:

- Additions
- Deductions
- Company contributions



**Minimum Limit**
: If the calculation type is a rate or percentage,  the Minimum limit is the minimum amount that must be paid, deducted, contributed  or accrued even if the calculated amount is lesser than the specified  minimum amount.


**Maximum Limit**
: If the calculation type is a rate or percentage,  the Maximum limit is the maximum amount that can be paid, deducted, contributed  or accrued even if the calculated amount is greater than the specified  maximum amount.


{:.example}
Sales commission may be paid at the rate of  10% on sales subject to a minimum of $200 and a maximum of $1000. An employee's  contribution to a benefit plan may be calculated as a percentage of his  salary subject to a minimum of $50 and a maximum of $100.


**Basis of Payment**
: This field is used to enter the description for  the basis of payment. This field is enabled only if the calculation type  selected is **Rate** or **Percentage**.
: The amount for the type of payroll item (additions,  deductions and company contributions) should be specified in the **Additional earnings and deductions** grid  of the **Payroll Transactions** dialog  box. (path: **Payroll &gt; Processing &gt;**  from the **Payroll Transactions** browser **&gt;** double-click the required record).


{:.example}
Enter ‘sales commission’,  if it is the basis of payment. Sales commission may be calculated as a  percentage of gross margin, net margin or sales value.


{:.see_also}
See also


[Employee  Template - Pay Details]({{site.prl_baseurl}}/misc/pay_details.html)
