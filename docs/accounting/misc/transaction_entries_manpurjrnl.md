---
title: Transaction Entries
---

# Transaction Entries


**Short/Over**
: This field displays the amount by which the transaction  is out of balance (i.e. the amount of difference between the debits and  credits). This amount is automatically computed.


**Account**
: Specify the account to be debited or credited in  this column. The Accounts Payable Control account displayed by default,  as the first entry in this column cannot however be edited or deleted.  Only detailed accounts that have the same currency as the vendor's currency  are available for selection.


**Description**
: The name of the account is displayed in this field.


**Entry Type**
: Select the type of the purchase entry:

- None – this  is the default.
- Taxable Purchase  – the purchase entry is liable to purchase tax.
- Exempt Purchase  – the purchase entry is exempt from taxes.



{:.note}
The automatic Accounts Payable entry defaults  to the entry type “None” and you cannot edit this.


**Tax Code**
: This optional field enables only if you select “Taxable  Purchase” or “Exempt Purchase” in the Entry Type column. If you select  “Taxable Purchase” it displays all active tax codes except those with  the Non-taxable box checked in the tax code profile (path: **File**  > **Setup** > **Accounting**  > **Taxes** > **Tax 
 Codes** > **New/Edit**). If  you select “Exempt Purchase” it displays all active tax codes marked Non-taxable  in the tax code profile.


{:.note}
Tax codes containing a tax component with  the “Amount Recoverable” choice of the “Recoverable” option selected (path:  **File** > **Setup**  > **Accounting** > **Taxes**  > **Tax Components** > **New/Edit**) do not appear in the drop  down box. The “Amount Recoverable” option is based on a unit of measure,  and manual purchase documents do not include measures.
: For each taxable entry with a tax code selected,  the system automatically inserts a row beneath the entry for each tax  component of the tax code. If you chose “% Recoverable” in the tax component's  “Recoverable” option with less than 100%, the system creates a row for  both the recoverable and non-recoverable portions of tax. If you left  the option at 100% only a row for recoverable tax displays; if you did  not select the option only a row for non-recoverable tax displays.
: You may manually add entries for the Recoverable  Tax account. If you choose the “Taxable Purchase” entry type, the system  will add the automatic rows and calculate the recoverable and non-recoverable  tax as with any other entry.


{:.note}
If the selected tax code contains only one  tax component, you may edit the tax in the automatically generated Recoverable  and Non-recoverable tax rows or even delete the purchase entry itself  (with adequate security rights). If you edit the tax, the related tax  rows recalculate. If you delete the entry, the system deletes the automatically  added rows. In both cases, however, you must manually change the Accounts  Payable entry if the journal is no longer balanced.
: The system-generated Non-recoverable Purchase Tax  rows affect the column information as follows:

- Account - defaults  to the account selected as the Taxable Purchase. You may change the account.
- Description  - displays the description of the account. You may not change the description.
- Location/Sub-location  - displays the location/sub-location of the taxable purchase entry. You  may not change the location.
- Entry Type  - defaults to “Non-recoverable Purchase Tax.” You may not change the entry  type.
- Tax Code –  disables. You may not edit the tax code.
- Notes - remains  blank. You may add and edit notes.
- Job Code -  remains blank. You may not change the job code.
- Debit - displays  the purchase tax amount if the corresponding taxable amount is in the  Debit column. If the tax code has only one tax component, you may change  the amount or delete the entry and add it to the Credit column.
- Credit - column  displays the purchase tax amount if the corresponding taxable amount is  in the Credit column. If the tax code has only one tax component, you  may change the amount or delete the entry and add it to the Debit column.

: The system-generated Recoverable Purchase Tax rows  affect the column information as follows:

- Account - defaults  to the account selected for the tax component in the Tax Component Profile.  You may change the account.
- Description  - displays the description of the account. You may not change the description.
- Location/Sub-location  - remains blank. You may not change the location.
- Entry Type  - defaults to “Recoverable Purchase Tax.” You may not change the entry  type.
- Tax Code –  disables. You may not edit the tax code.
- Notes - remains  blank. You may add and edit notes.
- Job Code -  remains blank. You may not change the job code.
- Debit - displays  the purchase tax amount if the corresponding taxable amount is in the  Debit column. If the tax code has only one tax component, you may change  the amount or delete the entry and add it to the Credit column.
- Credit - displays  the purchase tax amount if the corresponding taxable amount is in the  Credit column. If the tax code has only one tax component, you may change  the amount or delete the entry and add it to the Debit column.

: You need adequate security rights to edit or delete  the tax code of an unposted manual purchase journal.


{:.note}
If you modify the tax code and save the purchase  journal, the system will update the manual purchase invoice.


**Loc/Sub-Loc**
: Specify the location or sub-location to which the  journal pertains.


**Notes**
: Press the **Enter**  key or click in this column to activate a drop-down ![]({{site.acc_baseurl}}/img/act_drop_down_button.gif) button.  Click the drop-down button to view a dialog box where you can enter additional  details of the transaction. After specifying the details, click the save  ![]({{site.acc_baseurl}}/img/act_save.gif) button to save the details and return to the journal  profile.
: You may enter a different note for each transaction  entry.


**Job Code**
: Specify the job code applicable to the purchase  or purchase return.


**Allocate**
: Select the **Allocate**  check box for the transaction entries that you would like to distribute  among accounts based on a percentage. The total percentage of these accounts  should equal 100%.


**% Allocation**
: For the accounts that you have selected to allocate  by marking the check box in the **Allocation**  field, you must enter a percentage in the **% 
 Allocation** field. The total percentage of these accounts should  equal 100%. The Debit/Credit amounts automatically calculate based on  the percentages entered.


**Debit and Credit**
: Enter the amount being debited in the **Debit**  column while the amount being credited is entered in the **Credit**  column. An account cannot be debited and credited in the same transaction  entry. For Taxable Purchase entry types, the amount you enter must excludes  any taxes.
: In the case of foreign currency vendors, the amount  can be entered in foreign currency or the base currency. By default, you  must enter the amounts in foreign currency. To enter the amount in base  currency, select **Options &gt; View in 
 Foreign Currency** from the **Purchase 
 Journal** profile.
: The number of decimals that can be entered depends  on the settings made in the **Currency**  profile (path: **File** > **Setup** > **Accounting**  > **Multi**-**currency**  > **Currency** > **Options** > **Edit** > **In 
 New Window** > **Decimals to display**  field).


{:.see_also}
See also
: [Transaction  Entries - Details]({{site.acc_baseurl}}/purchasing/manual-purchases/manual-purchase-jrnl-dtls/transaction-entries/transaction_entries_manpurjrnl_con.html)
: [Purchase  Journal Profile - General]({{site.acc_baseurl}}/purchasing/manual-purchases/creating-a-manual-purchase-journal/purchase_journal_profile_general.html)
