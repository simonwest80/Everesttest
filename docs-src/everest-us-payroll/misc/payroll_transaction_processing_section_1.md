---
title: The Payroll Transaction Processing Section - Employees
---

# The Payroll Transaction Processing Section – Select Employees


This section lists the employees for whom you need to process payroll  transactions. Details of the employees include employee code, first name  and last name. These details are derived from the **Employee** profile (path: **Payroll &gt; Employees 
 &gt; Employee Data** > from the **Employees**  browser, double-click the required record).


![example.gif]({{site.prl_baseurl}}/img/example.gif) If  you create a regular payroll transaction for an employee for the period  April 1, 2001 - April 15, 2001, you cannot create a new regular transaction  for the same employee for the period April 15, 2001 - April 30, 2001.  However, you can create a supplemental transaction, if no other supplemental  transaction exists for the same period.


{:.note}
When you click **Finish**  in the next section of the wizard, **Everest**  warns you if the following conditions are met:

- A payroll transaction  with a pay date subsequent to the current one exists
- If the pay date  of the subsequent transaction is in the same calendar year
- If the payroll  transaction is for the selected employee


You can choose whether or not to create this transaction by clicking  **Yes** or **No**.


**Everest** also logs an event if  you choose to create such payroll transactions.


![]({{site.prl_baseurl}}/img/lens.gif)[Pay  Date]({{site.prl_baseurl}}/misc/payroll_transaction_processing_section.html#pay_date)


If you select the transaction type **Process 
 without Preview**, transactions are created for the selected employees  with the pay details specified in the respective employee profiles.


If you select the transaction type **Process 
 with Preview**, the **Payroll Transactions**  profile for the first employee selected is displayed.


**Select All**
: This button allows you to choose all employees.


**De-select All**
: This button allows you to deselect all employees.


**Cancel**
: This button allows you to cancel the payroll transaction  process.


Click **Finish** to create a transaction  record. You will see the [**Payroll Transactions**]({{site.prl_baseurl}}/payroll-process/transaction-details/create-regular-transaction/the_payroll_transactions_profile_2.html) profile.


{:.note}
If you have selected the option **Process 
 without Preview** in the **Payroll 
 Transaction Processing** section of the wizard,click **Next**.  You will see [**Payroll Transaction Processing - Error Log**]({{site.prl_baseurl}}/misc/payroll_transaction_processing_error_log_file_ptp.html)  section of the wizard prior to the **Payroll 
 Transactions** profile.


{:.see_also}
See also
: [Payroll  Transaction Processing Wizard]({{site.prl_baseurl}}/payroll-process/transaction-details/payroll/wizard/payroll_transaction_processing_wizard_ptp.html)
