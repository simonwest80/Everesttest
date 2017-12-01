---
title: Employee Form W2
---
<script type="text/javascript" language="JavaScript1.2" x-save-method="compute-relative" src="{{site.prl_baseurl}}/misc/ehlpdhtm.js"></script><script type="text/javascript" language="JavaScript1.2">
<!-- 
if( typeof( kadovFilePopupInit ) != 'function' ) kadovFilePopupInit = new Function();if( typeof( kadovTextPopupInit ) != 'function' ) kadovTextPopupInit = new Function();
 //-->
</script>
: The total taxable wages, tips, and other compensation  paid to the employees during the year is displayed. This amount is calculated  before any taxable payroll deductions are made.
: It may include back pay, bonuses, commissions, severance  or dismissal pay, and vacation pay. You should enter this amount as your  earned income
: Since Form W2 is based on the calendar year and  not the fiscal year, the annual salary of an employee may be different  from what is displayed in Box 1 of form W2.


{:.note}
Many employees have deductions, which are  exempt from federal and/or state income tax. The amount of these tax-exempt  deductions is subtracted from the calendar year earnings appearing in  Box 1.
: Wages, tips and other compensation constructively  received during the calendar year include the following:

- Prizes and  length-of-service or safety awards that are not considered de minimis
- Non-cash payments  (including reportable fringe benefits)
- Non-substantiated  business expense reimbursements
- Cost of accident  and health premiums paid on behalf of 2%-shareholder-employees by an S  corp. Exclude from Boxes 1, 3 and 5 if for non-shareholder employees.
- Distributions  from a §457 or nonqualified deferred compensation plan to statutory employees
- Taxes paid  for the employee by the employer
- Employee contributions  to a medical savings account
- Employer contributions  to a medical savings account that can be included in the employee's income
- Payments for  nonqualified moving expenses
- Taxable benefits,  such as cash taken under a cafeteria plan, scholarships or fellowship  grants
- Total reported  tips (not allocated tips)

: This field displays the amount of federal income  tax withheld from the employee’s pay for the year.

: This field displays the taxable amount of social  security wages for the employee, paid or incurred by the employer.
: Wages not subject to social security tax, such as,  some retirement plan contributions, are not included in this number
: The amount in this box does not include the tips  that are taxed to social security.
: From the taxable amount of social security wages  only those deductions that are exempt from social security tax (pre-tax  deductions) are reduced.
: The amount in this box (including adjustments) should  not exceed the upper limit of social security wage base as specified by  IRS.


{:.note}
For the year 2008, the social security wage  base was $102,000 and for the year 2009, it is $106,800. Once the Social  Security wage base limit is reached no more Social Security tax is due,  so the amount is $0.00 in the Social Security Wages box.
: The amount calculated by **Everest**  in Box 3 is the lower of the following:

- Sum of only  the Actual Social Security Wages portion of all transactions

: To calculate the Actual Social Security Wages portion  of a transaction, deduct the Social Security Tips from the taxable amount  of Social Security for the employee (path: **US 
 Payroll &gt; Processing &gt; Payroll Transactions &gt; Edit &gt; In New 
 Window &gt; Payroll Transaction** profile **&gt; Employee Taxes** tab **&gt; Taxable 
 Amount** section).
: (Social security tips generally appear as a payroll  item of type ‘Addition’ with pay type ‘Third party payments’)

- The difference  between Upper Limit (social security wage base) and Box 7

: This box includes the following:

- Applicable  items in Box 12 (Codes D, E, F, G, S)
- Elective and  non-elective deferrals to Section 457 plans
- MSA employee's  and non-excludable employer’s contributions
- Employee's  contributions to a SIMPLE retirement account
- Adoption benefits
- Former employee  group term-life over $50,000



{:.note}
This amount does not include tips – actual  and allocated.
: The sum of the Box 3 for all employees in a calendar  year should match with the total of Line 5a of Form 941 for all the four  quarters.
: The taxable amount displayed in the **Social 
 Security** field of the **Payroll 
 Transaction** profile (path: **Accounting 
 &gt; US Payroll &gt; Processing &gt; Payroll Transactions &gt; Edit &gt; 
 In New Window &gt; Payroll Transaction** profile **&gt; Employee Taxes** tab **&gt; Taxable 
 Amount** section) is the sum of social security wages and social  security tips. All the payroll items that are checked for social security  are included in this field. Deductions that have not been checked for  social security are subtracted from this amount.
: In view of the above mentioned facts, the value  displayed in the **Social Security**  field of the **Payroll Transaction**  profile is not comparable to the Social Security Wages entered in Box  3 of Form W2.


**![]({{site.prl_baseurl}}/img/lens.gif)[Validations  for Upper Limit (Social Security Wage Base)]({{site.prl_baseurl}}/misc/validations_for_yearly_upper_limit_(social_security_wage_base)_form_w2.html)**

This field displays the total amount of social security tax withheld,  including social security tax on tips, from the employee’s pay. Hence  this box is calculated as the sum of the total social security tax withheld  from the employee’s paycheck throughout the year.


The maximum value that can be displayed in this field is obtained by  applying the following formula:


Social security wage base limit for the year \* Tax rate for the year


{:.example}
**The Social security wage base limit for 2009  is $106,800 and the tax rate for the year is 6.2%; hence, the maximum  value this box can display is $ 106,800 \* 6.2% = $ 6,021.60**


The amount displayed in the **Social 
 Security** field of the **Taxes Deducted**  section of the **Payroll Transaction**  profile (path: **US Payroll &gt; Processing 
 &gt; Payroll Transactions &gt; Edit &gt; In New Window &gt; Payroll Transaction** profile **&gt; Employee Taxes** tab **&gt; Taxes Deducted** section) is calculated  as below:


(Social security tax rate \*  Social  security taxable amount)


{:.example}
**Social Security Taxable Amount for 2009 =  $106,800**


**Social Security Tax Deducted for 2009 = $6,021.60  ($106,800\*6.2%)**

: The taxable amount of medicare wages is displayed.  The wages and tips subject to Medicare tax are generally the same as those  subject to Social Security tax (boxes 3 and 7) except that there is no  wage base limit for Medicare tax.
: Enter the total Medicare wages and tips in box 5.  Be sure to enter tips that the employee reported even if you did not have  enough employee funds to collect the Medicare tax for those tips. See  Box 3 above for payments to report in this box, if you paid your employee's  share of taxes.


{:.example}
****Example of 
 how to report social security and Medicare wages**:**


**You paid your employee $140,000 in wages.  Enter 106,800.00 in box 3 (social security wages), but enter 140,000.00  in box 5 (Medicare wages and tips). There is no limit on the amount reported  in box 5.**


**If the amount of wages paid was $106,800.00  or less, the amounts entered in boxes 3 and 5 would be the same.**

: This field displays the amount of medicare tax withheld  from the employee’s pay. It is the sum of the Medicare taxes deducted  through all the payroll transactions pertaining to an employee (path:  **Accounting &gt; US Payroll &gt; Processing 
 &gt; Payroll Transactions &gt; Edit &gt; In New Window &gt; Payroll Transaction** profile **&gt; Employee Taxes** tab **&gt; Taxes Deducted** section **&gt; Medicare** field).
: A payroll item subject to social security tax is  also subject to Medicare tax; hence, this amount can be cross verified  as
: (Box 3 + Box 7) \* Medicare Tax rate
: The employee and employer's share of the Medicare  tax rate for the year 2009 is 1.45% each.


{:.note}
The Medicare tax rate is 2.9% for the employee  and the employer. You will withhold 1.45% of an employee’s wages and pay  a matching amount for Medicare tax. There is no wage base for the Medicare  portion of the FICA tax. Both the employer and the employee continue to  pay Medicare tax, no matter how much is earned.

: The taxable amount of social security tips is displayed  in this field. This box displays the employee's reported tips for the  calendar year, even if the employee's funds are insufficient to collect  the Social Security tax.
: You need to track the payroll item Tips (which is  generally created as a payroll item of the type ‘Additions’ and the Pay  type” Third Party payments’) to this field. You can also track any other  type of payroll item to this field; there is no restriction on that. However  the Social security tax withheld (Box 4) is calculated on the sum of the  Social security wages (Box 3) and only the taxable portion of the Social  security Tips in Box (Box 7).


{:.note}
Report all tips in box 1 along with wages  and other compensation.
: ![]({{site.prl_baseurl}}/img/lens.gif)[Excerpts  from Publication 15, Circular E: Employers Tax Guide]({{site.prl_baseurl}}/misc/excerpts_from_pub15_circular_e_employers_tax_guide_w2_usp.html)


**![]({{site.prl_baseurl}}/img/lens.gif)[Validations  for Upper Limit (Social Security Wage Base)]({{site.prl_baseurl}}/misc/validations_for_yearly_upper_limit_(social_security_wage_base)_form_w2.html)**

: The taxable amount of allocated tips is displayed  in this field, if you have associated payroll items while setting up W2  tracking for allocated tips.
: This is the amount received by the employer as tips  from a third party. This amount is distributed to all employees.


{:.warn}
Do not include this amount in boxes 1,3,5,7.


Additional information:


Certain employers must allocate tips if the percentage of tips reported  by employees falls below a required minimum percentage of gross sales.  To "allocate tips" means to assign an additional amount as tips  to each employee whose reported tips are below the required percentage.  For additional information on how the rules for tip allocation work, refer  to Chapter 7 of Publication 17, Your Federal Income Tax. All tips you  receive are taxable. You should keep a record of actual tips received.  You can order Publication 1244, Employee's Daily Record of Tips and Report  to Employer, for this purpose. If you do not have adequate records for  your actual tips, you must include the allocated tips shown on your Form  W-2 as additional tip income on your return. You must also complete and  attach Form 4137, Social Security and Medicare Tax on Unreported Tips.  For more information on the requirements, refer to Tip Allocation in Publication  531, Reporting Tip Income. Refer to Tax Topic 402, Tips, for other important  information.


****Question:**  If the reported tips from employees are more than 8% of sales, must an  employer still allocate tips to the employees?**


No. Employers who operate "large food or beverage establishments"  must allocate tips among the employees who receive tips only if the reported  tips are less than 8% of the gross receipts from sales for that establishment  for a given period.


****Question:**  My employer included allocated tips on my W-2 in box 1. The allocated  tips included were higher than the tips I actually received. Do I have  to pay taxes on money I never received?**


Allocated tips are reported in box 8 of Form W-2 and should **not 
 be** included in the amount in box 1. If they have been included  in box 1, you need to get a corrected Form W-2 from your employer.


By including the tip amount in box 1, the employer has indicated that  this is the tip amount you reported monthly and that Social Security tax  and Medicare taxes have been withheld (unless an amount indicating otherwise  appears in box 12). Your copies of your monthly tip reports and your daily  tip log will enable you to document that you reported a different tip  amount if the Form W-2 income continues to be disputed. If you do not  receive a corrected Form W-2, enter the amount of wages and tips you believe  to be correct on line 7 of Form 1040. Keep your tip records to support  the amount you reported.


You normally must report allocated tips (box 8, Form W-2) as income  on line 7 of your Form 1040 unless you have a daily tip record documenting  that you actually received less tips than the amount allocated to you.  If you have adequate documentation of your actual tip amount, include  only the amount of tips that were actually received and reported to your  employer. This additional amount of tip income, whether it is allocated  tips or unreported tips, has not had income tax, social security tax or  Medicare taxes withheld. To correct this, the tips should also be entered  on Form 4137, Social Security and Medicare  Tax on Unreported Tips. Enter the tax from Form 4137 on line 56  of Form 1040 and attach Form 4137 to your return.

: This field displays the EIC payment made in advance  to the employee.

: The taxable amount of dependent care benefits is  displayed in this field, if you have associated payroll items while setting  up W2 tracking for dependent care benefits.
: This field may include any of the following:

- The FMV of  benefits provided in kind by the employer
- An amount paid  directly to a day-care facility by the employer or reimbursed to employee  to subsidize the benefit
- Benefits from  the pre-tax contributions made by the employee to a section 125 dependent  care flexible spending account. Include any amounts over $5,000 in boxes  1, 3, and 5.

: The taxable amount of non-qualified plans is displayed  in this field, if you have associated payroll items while setting up W2  tracking for non-qualified plans.
: Generally, Box 11 shows distributions to the employee  from a nonqualified deferred compensation or Section 457 plan. This amount  is also entered in Box 1. If no distributions were made, enter the deferral  amount in Boxes 3 and 5. Do not report in Box 11 either deferrals relating  to the year for which you are submitting Form W-2, or distributions if  the employee had taxable deferrals during the year. (Report the latter  on Form SSA-13.)

: This section contains a list of codes for your W2  Form as detailed below.


{:.note}
You can enter only four items in box 12 of  Copy A. If you wish to report additional items, use multiple Form W2s,  but do not enter more than four items on each Copy A. On all other copies  of Form W2 (Copy B, C,  E,etc.), you  can enter any number of items in box 12.


Use the IRS code designated for the items  that you are entering. Enter the codes in the boxes 12a, 12b, 12c and  12d, and specify the amount for each of these items in the adjacent column.  Enter the code using a capital letter. Leave at least one space blank  after the code and enter the dollar amount on the same line. Use decimal  points but not dollar signs or commas.


{:.example}
**If you are reporting $ 5,300.00 in elective  deferrals to a section 401k plan, enter D 5300.00 and not A 5300.00 even  though it is the first or only entry in this box.**


{:.note}
You must read the detailed instructions for  this Box to determine the amounts that need to be entered under each of  these boxes.

- **A**  - Displays uncollected social security or RRTA  tax on tips.
- **B**  - Displays uncollected Medicare tax on tips.
- **C**  - Displays taxable cost of group-term life insurance over $50,000 (included  in boxes 1, 3, and 5).
- **D**  - Displays elective deferrals to a section 401(k) cash or deferred arrangement.
- **E** - Displays  elective deferrals under a section 403(b) salary reduction agreement.
- **F** - Displays  elective deferrals under a section 408(k)(6) salary reduction.
- **G** - Displays  elective deferrals and employer contributions (including nonelective deferrals)  to a section 457(b) deferred compensation plan.
- **H**  - Displays elective deferrals to a section 501(c)(18)(D) tax-exempt organization  plan.
- **J** - Displays  nontaxable sick pay (not included in boxes 1, 3, or 5)
- **K** - Displays  20% excise tax on excess golden parachute payments.
- **L** - Displays  substantiated employee business expense reimbursements (nontaxable)
- **M** - Displays  uncollected social security or RRTA  tax on taxable cost of group-term life insurance over $50,000 for former  employees.
- **N** - Displays  uncollected Medicare tax on taxable cost of group-term life insurance  over $50,000 for former employees.
- **P**  - Displays excludable moving expense reimbursements paid directly to employee  (not included in boxes 1, 3, or 5).
- **Q**  - Displays non-taxable combat pay. This code needs to be filled up only  by military employers.
- **R**  - Displays employer contributions to your Archer (MSA).
- **S**  - Displays employee salary reduction contributions under a section 408(p)  SIMPLE (not included in box 1)
- **T** - Displays  adoption benefits (not included in box 1).
- **V**  - Displays income from exercise of nonstatutory  stock options) (included in boxes 1, 3, and 5)
- **W** - Displays  the employer’s contributions to an employee's Health Savings Account (HSA).  This amount is not subject to income tax withholding, or social security,  Medicare, or railroad retirement taxes (or FUTA tax) if it is reasonable  to believe at the time of the payment that the contribution will be excludable  from the employee's income. However, if it is not reasonable to believe  that the contribution will be excludable from the employee's income, the  employer’s contributions are subject to the above taxes and must be reported  in boxes 1, 3, and 5 (and on Form 940).
- **Y**  - Include current year deferrals under a section 409A non-qualified deferred  compensation plan. Any earnings during the year on current year and prior  year deferrals must also be reported here.
- **Z**  - Displays any income under section 409A non-qualified deferred compensation  plan that was included in box 1. This income was also subject to an additional  tax reported on the employee’s Form 1040.
- **AA**  – Displays the designated Roth contributions to 401 (k) plans (included  in boxes 1, 3 and 5).
- BB –  **Displays the designated Roth contributions 
 to 403 (b) salary reduction agreement (included in boxes 1, 3 and 5).**
- **Non-qualified 
 deferred compensation plans** - New section 409A, added by the American  Jobs Creation Act of 2004, provides that all amounts deferred under a  non-qualified deferred compensation (NQDC) plan for all taxable years  are currently includible in gross income unless certain requirements are  satisfied. See Non-qualified deferred compensation plans on page 6. If  section 409A requires an amount to be included in gross income, the section  imposes a substantial additional tax. Section 409A, generally, is effective  with respect to amounts deferred in tax year beginning after December  31, 2004, but deferrals made prior to that year may be subject to section  409A under some circumstances. The Act requires reporting of the yearly  deferrals (plus earnings) under a section 409A non-qualified deferred  compensation plan, using Code Y in box 12. All 2005 deferrals (plus earnings)  must be reported on a Form W-2 (Box 12, Code Y) or Form 1099-MISC (Box  15a), even if the amounts are not yet taxable. Amounts that become taxable  because of noncompliance with 409A also must be reported. Income included  under section 409A from a non-qualified deferred compensation plan will  be reported in box 1, and in box 12 using Code Z. This income is also  subject to an additional tax reported on Form 1040. For more information,  see section 5 of Pub. 15-A.



{:.note}
You must report all employer contributions  to an HSA in  box 12 of Form W2 with code W.  Employer contributions to an HSA  that are not excludable from the income of the employee must also be reported  in box 1.

: Select the category of the employee for whom the  Form W2 is to be issued.

: This field displays any other information for the  employee, such as union dues, health insurance premiums, and educational  assistance payments.
: The following amounts should be reported in this  field:

- 414 (H) All  non-taxable Tier 3 and Tier 4 contributions made to New York State or  City Retirement Systems or to TIAA/CREF for State and Local taxes. If  this amount is prefixed with a minus sign (-), it can be disregarded for  State and Local taxes since the taxes have already been paid.
- UTA Uniform/Tool  allowance
- EXP Taxable  expense – This code is used for payments of “lieu of expenses,” non-overnight  meal allowances, excess per diem reimbursements or personal car mileage.
- FRB Taxable  fringe benefit – The lease value of the vehicle provided by the employer.
- EDA Educational  assistance payments
- TXP Taxable  transportation fringe benefits (parking) in excess of IRS excludable amounts.
- PPL Pre-paid  legal expense.
- IMP Imputed  income – The value of the employer's contributions for employees with  Domestic Partner Health Insurance.
- WCX Workers'  Compensation excluded amount. This is the amount awarded by NYS Workers'  Compensation Board, which is excluded from the gross pay for the current  year for a work-related injury.
- IRC125 City  University of New York (CUNY) employees only. This amount includes Dependent  Care, Flexible Spending Account, and Non-Taxable Health Insurance and  is excludable for Federal income tax only and is not included in Box 1.  This amount must be reported for State and Local taxes.
- TPS- the amount  of sick pay paid by a third party.

: The taxable amount of the local wages is displayed  in this field.
: This amount is calculated prior to making any payroll  deductions. However, the tax-exempt deductions are reduced from the taxable  wages.

: The amount deducted for the local income tax is  displayed.


{:.note}
You can report the local tax wage information  for up to two localities. If you wish to report the local tax wage information  for more than two localities, prepare a second Form W2.

: Description of the local tax as specified in the  **Employee** profile is displayed  in this field.

# Employee Form W2


Use this form to create a Form W2 report for the selected employee.  This section provides only a general information on Form W2 report.


![]({{site.prl_baseurl}}/img/refer.gif) See the instructions given by the Federal Government  for preparation of a Form W2.


**a) Employee’s Social Security Number**
: Enter  the number shown on the employee’s social security card. If the  employee does not have a card, he or she should apply for one by completing  Form SS-5, Application for a Social Security Card. Refer to [www.irs.gov](http://www.irs.gov)  for further help.


**Void**
: Check this box to void the Form W2 in case of an  error. You can fill out a complete new Form W2.


{:.note}
You need to check the **Void**  box only on Copy A of Form W2.


{:.warn}
Be careful not to include any amounts from  voided forms in the totals that you enter on Form W3.
: A copy of the voided form (Copy A) must also be  furnished with the SSA along with the new copy of the form (Copy B).


**b) Employer Identification Number**
: This field displays the **Federal 
 ID** number entered in the **Payroll 
 Company Setup** profile. This is the 9-digit EIN number assigned  in the format: 00-0000000.


**c) Employer’s Name, Address, and ZIP Code**
: The company name, its address and the ZIP code specified  in the **Payroll Company Setup** profile  are displayed. This should be the same as entered in Form 941.


**d) Control Number**
: You may use this box to identify individual forms  W-2. You do not have to use this box.


**e) Employee’s first name and initial**
: The first name and initial of the employee specified  in the **User** profile is displayed.


**Last name**
: The last name of the employee specified in the **User** profile is displayed.


**Suff.**
: The suffix name of the employee specified in the  **Title** field of the **User** profile is displayed. Any data entered in this field will  be printed in the Form W2.


{:.note}
- Only English alphabets  and special characters such as `,’ (periods) are allowed in this field.
- Do not enter “Jr.,”  “Sr.,” unless the suffix appears on the Social Security Card.
- Do not show titles  or academic degrees, such as “Dr.,” “RN,” etc.


**f) Employee’s Address and ZIP Code**
: The address of the employee specified in the **User** profile is displayed in the field  below the **Employee’s name**.


{:.note}
The employee’s name and address should be  the same as specified in the employee’s SSN card.


**[1 Wages, Tips, Other Compensation](javascript:kadovTextPopup(this)){:id="a1"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a1');
//--></script>**


**[2 Federal Income Tax Withheld](javascript:kadovTextPopup(this)){:id="a2"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a2');
//--></script>**


**[]()[3 Social Security Wages](javascript:kadovTextPopup(this)){:id="a3"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a3');
//--></script>**


**[4 Social Security Tax Withheld](javascript:kadovTextPopup(this)){:id="a4"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a4');
//--></script>**


**[5 Medicare Wages and Tips](javascript:kadovTextPopup(this)){:id="a5"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a5');
//--></script>**


**[6 Medicare Tax Withheld](javascript:kadovTextPopup(this)){:id="a6"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a6');
//--></script>**


**[]()[7 Social Security Tips](javascript:kadovTextPopup(this)){:id="a7"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a7');
//--></script>**


**[8 Allocated Tips](javascript:kadovTextPopup(this)){:id="a8"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a8');
//--></script>**


**[9 Advance EIC Payment](javascript:kadovTextPopup(this)){:id="a9"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a9');
//--></script>**


**[10 Dependent Care Benefits](javascript:kadovTextPopup(this)){:id="a10"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a10');
//--></script>**


**[11 Nonqualified  Plans](javascript:kadovTextPopup(this)){:id="a11"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a11');
//--></script>**


**[]()[12 Box 12](javascript:kadovTextPopup(this)){:id="a12"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a12');
//--></script>**


**[13 Statutory Employee/Retirement Plan/Third-party  Sick Pay](javascript:kadovTextPopup(this)){:id="a13"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a13');
//--></script>**


**[14 Other](javascript:kadovTextPopup(this)){:id="a14"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a14');
//--></script>**


**State**
: Filing state of the employee specified in the **Employee** profile is displayed by default.


**Employer’s State ID No.**
: The **State ID**  number specified in the **State Setup**  profile is displayed by default.


**State wages, tips etc.**
: This box indicates the  amount  of wages, tips and other compensation paid to the employees during the  year that are taxable to SITA. This figure is calculated prior to making  any payroll deductions. However, the tax-exempt deductions are reduced  from the taxable wages.


**State Income Tax**
: The amount withheld towards the state income tax  is displayed in this field.


{:.note}
You can report the state wage information  for up to two states in the State Wages box. If you wish to report the  state wage information for more than two states, prepare a second Form  W2.


**[18 Local wages, tips, etc.](javascript:kadovTextPopup(this)){:id="a15"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a15');
//--></script>**


**[19 Local Income Tax](javascript:kadovTextPopup(this)){:id="a16"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a16');
//--></script>**


**[20 Locality Name](javascript:kadovTextPopup(this)){:id="a17"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a17');
//--></script>**


{:.see_also}
See also
: [Adjustments  to the Values in Form W2]({{site.prl_baseurl}}/statutory-forms-and-reports/form-w2/creating-a-form-w2-report/adjustments_to_the_values_in_form_w2_sfr.html)
: [Create  a Form W2 Report]({{site.prl_baseurl}}/statutory-forms-and-reports/form-w2/creating-a-form-w2-report/create_a_form_w2_report_sfr.html)
