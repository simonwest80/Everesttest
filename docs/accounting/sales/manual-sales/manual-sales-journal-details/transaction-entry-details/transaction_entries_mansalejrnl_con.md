---
title: Transaction Entries
---

# Transaction Entries


**Short/Over**
: This field indicates the amount by which the transaction  is out of balance. If the amount displayed is positive, total debits exceed  total credits; if the amount is negative, total credits exceed total debits.
: Negative amounts display in red color with a negative  symbol preceding it. An unbalanced journal cannot be posted.


**Account**
: Specify the account to debit or credit in this column.  The first line automatically displays the account specified as the default  in the **Accounts Receivable** field  of the **Accounting** preference (path:  **File &gt; Setup &gt; Preferences &gt; 
 Defaults &gt; Accounting**).
: ![]({{site.acc_baseurl}}/img/lens.gif) [Accounting  defaults]({{site.acc_baseurl}}/accounting-flow-control-and-defaults/accounting-defaults/accounting_defaults.html)
: This account cannot be changed. The account to be  debited or credited can be selected for further entries. Only detailed  accounts of the same currency as the customer's currency can be selected.
: In the case of an automatically generated row for  a tax component this defaults to the account selected for the tax component  in the **Tax Component** profile;  you may change the account.


**Description**
: The name of the selected account displays in this  field.


**Loc/Sub-Loc**
: Specify the location/sub-location to which you want  to allocate the amount. This field identifies the cost centers or profit  centers for an expense or revenue account. Locations/Sub-Locations cannot  be assigned to asset and liability accounts.
: In the case of an automatically generated row for  a tax component this column remains blank; you may not edit the location.


**Entry Type**
: Specify the type of entry being created.
: In the case of an automatically generated row for  a tax component this defaults to “Sales Tax;” you may not change the entry  type.
: ![]({{site.acc_baseurl}}/img/lens.gif) [Entry  Types]({{site.acc_baseurl}}/sales/manual-sales/manual-sales-journal-details/transaction-entry-details/entry_types_manual_sales_journals_content.html)


**Tax Code**
: Select the appropriate tax code. The drop down box  displays the active tax codes for the following entry types:

- Taxable Commissionable  Revenue
- Taxable Non-commissionable  Revenue
- Exempt Commissionable  Revenue
- Exempt Non-commissionable  Revenue

: The tax codes available for each line item depend  on the entry type (taxable or non-taxable).


{:.note}
The tax code drop down box will not display  tax codes where one or more of the tax components have the “Calculation  Method,” such as “Percentage of Cost” and “Amount per Unit of Quantity.”
: When you select a tax code for a taxable entry,  you must enter the tax exclusive amount (the value of the items or services  sold) in either the Debit (for a credit memo) or Credit (for a sales invoice)  column. The system will automatically insert a row with the entry type  “Sales Tax” and calculate the tax amount for each tax component based  on the tax exclusive amount you entered.


{:.example}
If you choose a tax code with five tax components,  the system will add five rows with the entry type “Sales Tax” beneath  the original line.


{:.note}
The system does not insert a row for the contra  entry of the sales tax. You may add it to the Accounts Receivable entry  or add a new row to balance out the sales tax.


If you edit the taxable amount after the sales  tax entries are automatically inserted, the tax component amounts will  recalculate. However you must manually change the Accounts Receivable  entry if the journal is not balanced.
: The automatically entered Sales Tax rows will contain  the following information:

- **Account**  - this defaults to the account selected for the tax component in the Tax  Component Profile. You may change the account.
- **Description**  - this displays the description of the account. You may not change the  description.
- **Location/Sub-location**  - this remains blank. You may not change the location.
- **Entry 
 Type** - this defaults to “Sales Tax.” You may not change the entry  type.
- **Notes**  - this remains blank. You may add and edit notes.
- **Job 
 Code** - this remains blank. You may not change the job code.
- **Debit**  - this displays the sales tax amount if the corresponding taxable amount  is in the Debit column. If the tax code has only one tax component, you  may change the amount or delete the entry and add it to the Credit column.
- **Credit**  - this column displays the sales tax amount if the corresponding taxable  amount is in the Credit column. If the tax code has only one tax component,  you may change the amount or delete the entry and add it to the Debit  column.

: Entering a tax code for both taxable and non-taxable  entries is optional; you may leave it blank. You may also modify the tax  codes and tax amounts (where the tax code has only one tax component)  in Unposted Sales Journals with the proper security rights.
: You may use the tax codes to automatically insert  rows of the Sales Tax entry type, or you may manually add entries with  the Sales Tax entry type. However, you cannot use both of these systems  in one manual sales journal. If you specify a tax code and manually insert  a Sales Tax entry, on saving the journal you get an error message.


**Notes**
: Press the **Enter**  key or click in this column to activate a drop-down ![]({{site.acc_baseurl}}/img/act_drop_down_button.gif) button.  Click the drop-down button to view a dialog box where you can enter additional  details about the transaction. After specifying the details, click the  save ![]({{site.acc_baseurl}}/img/act_save.gif) button to save the details and return to the journal  profile.


**Job Code**
: Specify the job code, if any, applicable to the  sales invoice or credit memo being created.
: In the case of an automatically generated row for  a tax component this column remains blank; you may not change the job  code.


**Debit and Credit**
: Enter the amount to debit in the **Debit**  column or to credit in the **Credit**  column. An account cannot be debited and credited in the same transaction  entry.


{:.note}
If a document alias for sales invoices is selected and an amount is  entered in the credit column, **Everest**  will change the type to **Credit Memo** once  you confirm this.


If a document alias for credit memos is selected, you cannot enter an  amount in the debit column against Accounts Receivable Control Account.
: The debit and credit amounts for foreign currency  documents may be entered in foreign or base currency depending on the  view. The amounts are automatically translated using the exchange rate  specified in the **Exchange** **Rate** profile (path: **File**  > **Setup** > **Accounting**  > **Multi - Currency** > **Exchange Rates** > **Options** > **Edit** > **In 
 New Window**) and displayed in the foreign or base currency. To view  the transaction in the base currency, select **Options 
 &gt; Base Currency**.
: ![]({{site.acc_baseurl}}/img/lens.gif) [Foreign  Currency Documents]({{site.sp_chm}}/sales-docs/docs-profile/contents/tab-details/details/frgn-cur/foreign_currency_documents_sales_document_content.html)
: The number of decimals that can be entered depends  on the settings made in the **Currency**  profile (path: **File** > **Setup** > **Accounting**  > **Multi**-**currency**  > **Currency** > **Options** > **Edit** > **In 
 New Window** > **Decimals to display**  field).
: In the case of an automatically generated row for  a tax component, the **Debit** column  displays the sales tax amount if the corresponding taxable amount is in  the **Debit** column and the **Credit** column displays the sales tax  amount if the corresponding taxable amount is in the **Credit**  column. If the tax code has only one tax component, you may change the  amount or delete the entry and add it to the opposite column.


{:.steps}
To select an account/loc/sub-loc/job code,  do the following:

- Click in the  **Account/Loc/Sub-Loc/Job Code** column  for the respective transaction entry. You will see the drop-down button  ![]({{site.acc_baseurl}}/img/act_drop_down_button.gif).
- Select the  required account/loc/sub-loc/job code from the drop-down list.



{:.see_also}
See also
: [Sales  Journal Profile - General]({{site.acc_baseurl}}/sales/manual-sales/creating-a-manual-sales-journal/sales_journal_profile_general.html)
