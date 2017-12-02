---
title: Transaction Entries
---

# Transaction Entries


**Short/over**
: This field indicates the amount by which the transaction  is out of balance. If the amount displayed is positive, the total of debits  exceeds the total credits; if the amount is negative, then total credits  exceeds the total debits.
: An unbalanced journal however, cannot be posted.


**Account**
: This field identifies the account that is debited  or credited in transaction line. Only detailed accounts can be selected.


**Description**
: The name of the account is displayed in this field.  The description cannot be edited.


**Loc/Sub-Loc**
: The location or sub-location to which the amount  must be allocated is displayed. The location/sub-location identifies the  cost centers or profit centers for an expense or revenue account. Locations/Sub-Locations  cannot be assigned to asset and liability accounts.


**Currency Code**
: The currency code of the account (selected in the  **Account** column) is displayed in  this field. This column is displayed when **Options 
 &gt; View in Foreign Currency** is selected.


**Exchange Rate**
: The exchange rate for the account's currency is  displayed in this column. The exchange rate is the conversion rate of  the foreign currency to your base currency.
: This rate can be changed as required.
: ![]({{site.acc_baseurl}}/img/lens.gif) [Accounts  in Foreign Currency]({{site.acc_baseurl}}/general-journals/manual-general-journals/manual-general-journal-details/accounts_in_foreign_currencies_manual_gj.html)


**Notes**
: Notes provide a brief description of the transaction.  You may enter a note for each transaction entry.


**Job code**
: The job code identifies the job to which the expense  or revenue on this transaction must be allocated.


**Allocate**
: Select the **Allocate**  check box for the transaction entries that you would like to distribute  or “allocate” among accounts based on a percentage. The total percentage  of these accounts should equal 100%.


{:.steps}
To allocate transactions based on a percentage,  do the following:

- Select the **Allocate** check box for each transaction  entry that you would like to distribute based on a percentage.
- Indicate the percentage  for each transaction selected in the **% 
 Allocation** field. The Debit/Credit amounts automatically calculate  based on the percentages entered. This feature can increase the efficiency  of your Accounting staff and save valuable time, especially at month end,  since they do not have to calculate the transaction amounts manually.



{:.example}
An Accountant would like to allocate petty  cash between Bank Account A and Bank Account B. 40% should go to Bank  Account A and 60% should go to Bank Account B. For Bank Account A, they  select the Allocate check box and enter 40 in the % Allocation field.  For Bank Account B, they select the Allocate check box and enter 60 in  the % Allocation field. Since the Debit amount to Petty Cash is $100,  this amount automatically allocates as a $40.00 credit to Bank Account  A and a $60.00 credit to Bank Account B.


![]({{site.acc_baseurl}}/img/general_journal_transaction_entries_section_allocation_acc.gif)


**Figure: General Journal Transaction Entries section  showing Allocated Transactions**


**% Allocation**
: For the accounts that you have selected to allocate  by marking the check box in the **Allocation**  field, you must enter a percentage in the **% 
 Allocation** field. The total percentage of these accounts should  equal 100%. The Debit/Credit amounts automatically calculate based on  the percentages entered.
: ![]({{site.acc_baseurl}}/img/lens.gif)[Memorized  Transactions]({{site.acc_baseurl}}/memorized-transactions/memorized_transactions_acc.html)


**Debit and credit**
: The amount to be debited is entered in the **Debit** column while the amount that has  to be credited is entered in the **Credit**  column. One account cannot be debited and credited in the same transaction  entry.
: The debit and credit amounts for foreign currency  accounts may be entered in foreign or base currency depending on the view.  The amounts are automatically translated using the exchange rate specified  in the **Exchange Rate** profile (path:  **File** > **Setup**  > **Accounting** > **Multi**  -**Currency** > **Exchange****Rates** > **Options** > **Edit** > **In 
 New Window**). To view transactions in the base currency, select  **Options &gt; View in Base Currency**.
: ![]({{site.acc_baseurl}}/img/lens.gif) [Accounts  in Foreign Currency]({{site.acc_baseurl}}/general-journals/manual-general-journals/manual-general-journal-details/accounts_in_foreign_currencies_manual_gj.html)


{:.steps}
To select an account/loc/sub-loc/job code,  do the following:

- Click in the  **Account/Loc/Sub-Loc/Job Code** column  for the respective transaction entry. You will see the drop-down button  ![]({{site.acc_baseurl}}/img/act_drop_down_button.gif).
- Select the  required account/loc/sub-loc/job code.



{:.see_also}
See also
: [Transaction  Entries]({{site.acc_baseurl}}/misc/transaction_entries_manual_gj.html)
: [Memorized  Transactions]({{site.acc_baseurl}}/memorized-transactions/memorized_transactions_acc.html)
