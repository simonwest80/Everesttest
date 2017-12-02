---
title: Purge a Payroll Transaction
---

# Purge a Payroll Transaction


You can purge a payroll transaction for which a payroll journal has  not been created.


When you purge a transaction, it is permanently deleted from the database;  also, the original transaction is purged from the **Payroll 
 Transactions** browser. However, you can create another transaction  for the same payroll period.


Payroll transactions may have to be purged, if the errors in the transaction  cannot be rectified through a modification.


Transactions with the following errors can be purged:

- Wrong payroll  period.
- Where the **Employee** profile has been modified to  change the filing status and the other tax details and the taxes have  to be recalculated.
- Where the tax  rates have been changed and the tax particulars with the transactions  have to be recalculated with the latest rates and tables.
- Where the salary  of the employee has been modified and the transaction has to consider  the new salary.



{:.steps}
To purge a payroll transaction, do the following:

- From the main  menu bar, select **Payroll &gt; Processing 
 &gt; Payroll Transactions**. You will see the **Payroll 
 Transactions** browser.
- Highlight the  record you want to purge and select **Options 
 &gt; Purge**. You will see the **Confirm**  window.
- Click **OK** to purge the record.



{:.note}
All changes to leave balances are reversed,  when you purge a transaction.


If you try to purge an intermediary payroll transaction for an employee  during a calendar year, **Everest**  warns you that since subsequent transactions for this employee exist in  the same calendar year, tax calculations for subsequent transactions would  be erroneous. The reason for this is that taxes are often calculated for  a transaction after considering the year-to-date amounts of prior transactions.  If you purge the intermediary transaction, the taxes in the subsequent  transactions will not get recalculated since they are based on the earlier  year-to-date amount (including the purged transaction).


{:.see_also}
See also
: [Payroll  Transactions Browser]({{site.prl_baseurl}}/payroll-process/purge/browser/the_payroll_transactions_browser.html)
