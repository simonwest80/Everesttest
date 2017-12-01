---
title: Transaction Entries
---

# Transaction Entries


**Short/Over**
: This field indicates the amount by which the transaction  is out of balance. If the amount displayed is positive, the total debits  exceed total credits; if the amount is negative, the total credits exceed  total debits. Negative amounts are  displayed in red color with a negative symbol preceding it.
: An unbalanced journal cannot be posted.


**Account**
: The first line automatically displays the account  specified in the **Accounts payable** field  of the **Accounting** dialog box (path:  **File &gt; Setup &gt; Preferences &gt; 
 Defaults &gt; Accounting**).
: ![]({{site.acc_baseurl}}/img/lens.gif) [Accounting  defaults]({{site.acc_baseurl}}/accounting-flow-control-and-defaults/accounting-defaults/accounting_defaults.html)
: This account cannot be changed. The account to be  debited or credited can be selected for further entries. Only detailed  accounts of the same currency as the vendor's currency can be selected.
: ![]({{site.acc_baseurl}}/img/lens.gif) [Types  of Accounts]({{site.sc_chm}}/options/acc-info/coa/chart-of-accounts-details/type_of_account.html)


**Description**
: The name of the selected account is displayed in  this field.


**Loc/Sub-Loc**
: The location or sub-location to which the amount  must be allocated is displayed. This field identifies the cost centers  or profit centers for an expense or revenue account. Locations/Sub-Locations  cannot be assigned to asset and liability accounts.


**Notes**
: A note is a brief description of the transaction.  You may enter a note for each transaction entry.


**Job Code**
: The job code identifies the job to which the purchase  or purchase return has to be allocated.


**Allocate**
: Select the **Allocate**  check box for the transaction entries that you would like to distribute  among accounts based on a percentage. The total percentage of these accounts  should equal 100%.


{:.steps}
To allocate transactions based on a percentage,  do the following:

- Select the **Allocate** check box for each transaction  entry that you would like to distribute based on a percentage.
- Indicate the percentage  for each transaction selected in the **% 
 Allocation** field. The Debit/Credit amounts automatically calculate  based on the percentages entered. This feature can increase the efficiency  of your Accounting staff and save valuable time, especially at month end,  since they do not have to calculate the transaction amounts manually.



![]({{site.acc_baseurl}}/img/purchase_journal_transaction_entries_section_allocation acc.gif)


**Figure: Purchase Journal Transaction Entries  showing Allocated Transactions**


**% Allocation**
: For the accounts that you have selected to allocate  by marking the check box in the **Allocation**  field, you must enter a percentage in the **% 
 Allocation** field. The total percentage of these accounts should  equal 100%. The Debit/Credit amounts automatically calculate based on  the percentages entered.
: ![]({{site.acc_baseurl}}/img/lens.gif)[Memorized  Transactions]({{site.acc_baseurl}}/memorized-transactions/memorized_transactions_acc.html)


{:.note}
Under some circumstances, particularly for  foreign currency vendors/customers, manual rounding adjustments, such  as $0.01, for the Short/Over amount may be required for purchase/sales  journal allocations made using a memorized transaction template.


**Debit and Credit**
: The amount to be debited is entered in the Debit  column while the amount that has to be credited is entered in the Credit  column. One account cannot be debited and credited in the same transaction  entry.
: The debit and credit amounts for foreign currency  documents may be entered in foreign or base currency depending on the  view. The amounts are automatically translated using the exchange rate  specified in the **Exchange** **Rate** profile (path: **File**  > **Setup** > **Accounting**  > **Multi - Currency** > **Exchange Rates** > **Options** > **Edit** > **In 
 New Window**) and displayed in the foreign or base currency. To view  the transaction in the base currency, select **Options 
 &gt; Base Currency** from the **Purchase 
 Journal** profile.
: ![]({{site.acc_baseurl}}/img/lens.gif) [Foreign  Currency Documents]({{site.pp_chm}}/purc-proc/doc-profile/contents/tabs/details/for-cur-info/foreign_currency_document.html)
: If a default expense account has been specified  for the vendor in the **Vendor** profile  (path: **Purchasing** > **Vendors**  > **Options** > **Edit** > **In New Window** >  **Accounting** tab > **Expense 
 Account** field), then the account will be automatically displayed  in the second transaction entry.
: ![]({{site.acc_baseurl}}/img/lens.gif) [Vendor  - Miscellaneous Information]({{site.mv_chm}}/creating/the-vendor-profile-accounting/the_vendor_profile_accounting_tab.html)
: ![]({{site.acc_baseurl}}/img/note.gif)  If  a document alias for Purchase Invoices is selected and an amount is entered  in the debit column, **Everest** changes  the type to **Debit Memo** after getting  your confirmation.


If a document alias for debit memos is selected,  you cannot enter an amount in the credit column against Accounts Payable  Control Account.


{:.steps}
To select an account/loc/sub-loc/job code,  do the following:

- Click in the  **Account/Loc/Sub-Loc/Job Code** column  for the respective transaction entry. You will see the drop-down button  ![]({{site.acc_baseurl}}/img/act_drop_down_button.gif).
- Click the drop-down  button and select the required account/loc/sub-loc/job code from the drop-down  list.



{:.see_also}
See also
: [Transaction  Entries]({{site.acc_baseurl}}/misc/transaction_entries_manpurjrnl.html)
: [Purchase  Journal Profile - General]({{site.acc_baseurl}}/purchasing/manual-purchases/creating-a-manual-purchase-journal/purchase_journal_profile_general.html)
: [Memorized  Transactions]({{site.acc_baseurl}}/memorized-transactions/memorized_transactions_acc.html)
