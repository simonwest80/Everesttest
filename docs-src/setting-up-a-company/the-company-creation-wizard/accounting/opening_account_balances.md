---
title: Opening Account Balances
---

# Opening Account Balances


In case you are switching to **Everest**  from another accounting software or a manual accounting system, all accounts  with a balance have to be entered into **Everest**.  The account balances are entered in the [Accounting  COA Balances]({{site.sc_baseurl}}/the-company-creation-wizard/accounting/accounting_coa_balances.html) section.


Balances of accounts receivable and accounts payable, and inventory  are automatically initialized when the inventory value, open customer  invoices and open vendor invoices are entered.


Since you do not enter the balances for the above mentioned three accounts,  there will be a difference between the total debits and total credits  which is automatically assigned to the **Unreconciled 
 Difference** account (specified in **Unreconciled 
 Difference** field in the **File &gt; 
 Setup &gt; Preferences &gt; Defaults &gt; Accounting &gt; Accounts &gt; 
 Other Accounts** tab). <font color="#000000" class="hcp2">The Unreconciled Difference 
 Account is automatically narrowed down when the value of items, accounts 
 receivable and accounts payable balances are entered into <span class="hcp1">Everest</span>.</font>


The following accounting entry is created:


| **Account <br/> type** | **Debit/Credit** |
| <font color="#000000" class="hcp2">Expenses accounts</font> | <font color="#000000" class="hcp2">Debit</font> |
| <font color="#000000" class="hcp2">Assets accounts (excluding Accounts <br/> Receivable and Inventory Control accounts)</font> | <font color="#000000" class="hcp2">Debit</font> |
| <font color="#000000" class="hcp2">Liabilities accounts (excluding Accounts <br/> Payable Control accounts)</font> | <font color="#000000" class="hcp2">Credit</font> |
| <font color="#000000" class="hcp2">Unreconciled accounts (if the value <br/> of assets is greater than the liabilities)</font> | <font color="#000000" class="hcp2">Credit</font> |



{:.note}
The accounting entry that is generated for  the opening balance bears the date of the first day in the fiscal year.


When you switch to **Everest**,  designate a switch-over date. All transactions between the opening balance  date (i.e., the date when you draw up your trial balance) and the date  of switch-over will have to be re-entered in **Everest**.


{:.see_also}
See also
: [Inventory information]({{site.sc_baseurl}}/the-company-creation-wizard/inventory/inventory1.html)
: [Accounting  information]({{site.sc_baseurl}}/the-company-creation-wizard/accounting/accounting_information_setupco.html)
