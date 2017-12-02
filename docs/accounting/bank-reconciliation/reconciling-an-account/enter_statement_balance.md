---
title: Enter Statement Balance
---

# Enter Statement Balance


This section allows you to specify the balance information as contained  in the bank statement.


**Opening Balance**
: When performing the bank reconciliation process  for the first time, the opening balance will be for the period as shown  in your bank statement. After reconciling the account, the statement balance  mentioned in the previous reconciliation process is displayed automatically  as the opening balance. This field can be edited if required.
: If you have attempted to reconcile the account previously  without completion (i.e. saved the reconciliation details without completing  the reconciliation), the statement balance mentioned during the previous  reconciliation process is displayed automatically in this field.
: You can enter a maximum of 15 integers and 4 decimals  in the **Opening Balance** field.  When the account as per your bank statement has a debit balance enter  the balance as a negative figure in this field.


{:.note}
The number of decimals displayed in this field  depends on the number of decimal digits specified in the settings for  the bank currency in the **Currency** profile  (Path: **File &gt; Setup &gt; Accounting 
 &gt; Multi-Currency &gt; Currency**). The number of decimals displayed  in this field depends on what you have set up in the **Currency** profile. If the number of decimals is NOT specified in the **Currency** profile, then the number of  decimals specified in the locale selected for the currency is displayed.


![]({{site.acc_baseurl}}/img/lens.gif) [Locale]({{site.sc_chm}}/options/multicurrency/setup/defining/details/format-specification/locale.html)


**Bank Statement Balance**
: The statement balance is the closing balance as  displayed in the bank statement. This is the balance that you are trying  to reconcile.
: Use this field to enter the closing balance shown  in the bank statement. You can enter a maximum of 15 integers and 4 decimals  in the **Bank** **Statement 
 Balance** field.


**Statement Date**
: Use this field to specify the date of the closing  balance in the bank statement. This date cannot be after the login date.
: When you specify this date, transactions of the  account upto  this date are displayed in the **Bank Reconciliation** browser.
: ![]({{site.acc_baseurl}}/img/example.gif)  If  you receive the bank statement for the period July 2001, on 15th August  2001, specify the date in this field as July 31, 2001. Transactions that  have been accounted after this date will not be displayed in the Bank  Reconciliation browser. This simplifies the reconciliation process.


**Posted Balance**
: The current balance posted to the selected bank  account is displayed in this field. You cannot edit this field.


Click **Finish**. You will see the  [**Bank 
 Reconciliation** browser]({{site.acc_baseurl}}/bank-reconciliation/reconciling-an-account/bank_reconciliation_browser.html).
