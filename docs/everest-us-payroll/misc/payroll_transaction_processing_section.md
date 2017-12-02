---
title: Payroll Transaction Processing
---

# Payroll Transaction Processing


Use this section of the **Payroll Transaction 
 Processing** wizard to specify details of the payroll transaction  such as pay period and pay type.


**Pay Period**
: **Pay period**  is the payroll period for which you want to process payroll transaction.  Specify the payroll period you want from the drop-down list. By default,  **Monthly** is displayed in this field.
: Payroll transactions must be created in batches  of employees based on their pay period. Selecting a **Pay 
 period** ensures that employees with different paydays are not paid  by mistake.
: When you create a payroll transaction for an employee  for a certain period, **Everest**  locks that period for that employee and does not allow you to create a  duplicate transaction for the same period or for a duration falling in  between this period.


**[]()Pay Date**
: The **Pay Date**  is the payday for the transactions. Specify the pay date in this field.  By default, the login  date is displayed in this field. Taxes are calculated based on the calendar  year in which the payday falls.
: The pay date should not be less than the end date  of the payroll period.


![example.gif]({{site.prl_baseurl}}/img/example.gif) **** Taxes for payroll transactions processed  for the last week of December 2001 with the payday in 2002 will be calculated  using 2002 tax rates.


{:.note}
When you click **Finish**  in the next section of the wizard, **Everest**  warns you if the following conditions are met:

- A payroll transaction  with a pay date subsequent to the current one exists
- If the pay date  of the subsequent transaction is in the same calendar year
- If the payroll  transaction is for the selected employee


| ![]({{site.prl_baseurl}}/img/example.gif) | **You create the following payroll transactions  for employee ‘ABC’:**<br/><br/><br/>| Payroll Period | Pay Date |<br/>| 1/1/2004-1/31/2004 | 2/1/2004 |<br/>| 2/1/2004-2/29/2004 | 3/1/2004 |<br/>| 3/1/2004-3/31/2004 | 4/1/2004 |<br/>| 5/1/2004-5/31/2004 | 6/1/2004 |<br/><br/><br/><br/>**You subsequently create the transaction for  April in June 2004. Since payroll taxes are calculated based on the YTD  (year-to-date) figures, the taxes calculated for May 2004 would have considered  the taxable amounts for January, February, March and May only. If you  select a pay date before 6/1/2004 for April’s salary, the taxes initially  calculated for May 2004 would be wrong.** |



**Start Date**
: Specify the start date for the transaction to be  processed in this field. The start date cannot be later than the end date.


**End Date**
: The end date will be automatically calculated and  displayed based on the payroll period selected, when you specify the start  date. You can change the end date, if required.
: The start date and end date of the payroll period  is the time period for which the employees are being paid.


The end date may have to be modified in the following cases:

- If an employee  leaves the firm in the middle of a pay period and you want to pay the  employee for the days worked.
- If the pay  period is semi-monthly, **Everest US Payroll**  adds 14 days to the start date. You will have to change end date for February  and the months with 31 days.



When you modify the end date, you are prompted with the message that  the start and end dates do not match the pay period selected and whether  you would like to continue. Click **Yes**  to continue.


Note that the salary and other fixed amounts will not get prorated by  changing the end date.


![Lens.gif]({{site.prl_baseurl}}/img/lens.gif) [Prorating of Salary]({{site.prl_baseurl}}/misc/prorating_of_salary.html)


Pay Type


**Regular**
: A regular payroll is run at the end of a pay period  to pay employees belonging to that payroll period. Select this check box  to create a regular payroll transaction.


**![example.gif]({{site.prl_baseurl}}/img/example.gif) **** The payroll is run every week to pay employees  whose payroll period is a week.**


**Supplemental**
: A supplemental payroll is run in addition to the  regular payroll to make additional payments to the employees irrespective  of which payroll period they belong to. Select this check box to create  a supplemental payroll transaction.


**![example.gif]({{site.prl_baseurl}}/img/example.gif) **** Bonus paid in between two pay periods.**


The Federal Government and several states have different withholding  rates for supplemental earnings.


The payroll details are automatically calculated using the employee's  normal regular hours, salary for the pay period and the predefined additions,  deductions and company contributions.


Transaction Type


**Process with Preview**
: Select **Process 
 with Preview** to view payroll transactions for each selected employee.


This option allows you to:

- Verify the  transaction before saving.
- Specify sick  hours, overtime hours and vacation hours if the employee has any such  hours.
- Specify the  basis of payment, deduction or contribution for payroll items calculated  as a base of something.
- Review and  if required, change taxes to be withheld.



![]({{site.prl_baseurl}}/img/avi.gif)  [Show  Me]({{site.prl_baseurl}}/misc/process payroll transactions by previewing each empolyees transaction.html){:target="_blank" }


**Process without Preview**
: Select this option to process payroll transaction  without viewing transaction details of each selected employee. This option  is enabled only for a regular payroll transaction.


![]({{site.prl_baseurl}}/img/avi.gif)  [Show  Me]({{site.prl_baseurl}}/misc/batch processing payroll transactions.html){:target="_blank" }


Click **Next** to proceed. You will  see the [Payroll  Transaction Processing – Select Employees]({{site.prl_baseurl}}/misc/payroll_transaction_processing_section_1.html) section of the wizard. This  section displays the employees with the selected pay period type and who  do not have an existing transaction of the selected pay type in the specified  payroll period.


{:.note}
: Payroll transaction cannot be processed if no amount  has been specified for any of the payroll items. However it is possible  to create the payroll transaction where the payroll items have a value  but the Net Pay for the transaction results in $0.00. Such payments are  called as ‘Zero Dollar Payment Entries’. When such zero dollar payment  entries are selected for creating a payroll journal, you will see the  warning message, ‘Unable to create a Payroll journal’ when you try to  create a Payroll journal.


{:.see_also}
See also
: [Payroll  Transaction Processing Wizard]({{site.prl_baseurl}}/payroll-process/transaction-details/payroll/wizard/payroll_transaction_processing_wizard_ptp.html)
