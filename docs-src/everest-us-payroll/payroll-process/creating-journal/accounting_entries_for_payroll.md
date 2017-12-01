---
title: Accounting Entries for Payroll
---

# Accounting Entries for Payroll


When a payroll journal is created, the following accounting entries  are made:

- Accounting  entry for take home pay
- Accounting  entry for crediting vendors for deductions made, taxes withheld and company  contributions



**Accounting entry for take home pay**  - An accounting entry is made for crediting the vendor selected in the  **Employee** profile with the take  home pay for the transaction. A purchase receipt is created for the take  home pay. The document number assigned to the receipt is the payroll transaction  number prefixed by **MPAY**.


The purchase receipt created is like a manual purchase receipt; it will  have no line items. The purchase receipt created can be viewed by selecting  the option **Manual documents** in  the **Purchase Receipts** browser  (path: **Purchasing &gt; Purchase Receipts**  > from the **Purchase Receipts**  browser, select **Options &gt; Search By 
 Vendor &gt; Manual documents** or select **View**  > **US Payroll**).


The accounting entries created are:


| Accounts | Credit/Debit |
| A/P Control Account (for the amount of take home pay) | Credit |
| Expense Account for Payroll Item of type Salary, Regular Pay, Overtime  Pay, Sick Pay, Vacation Pay, Additions of type paycheck, Accruals and  Company Contribution | Debit |
| Expense Account for taxes payable by employer | Debit |
| Liability Account for Payroll Items of type Accruals,  Deduction and Company Contribution | Credit |
| Liability Account for taxes withheld | Credit |
| Liability account for taxes payable by employer | Credit |



{:.note}
**An accounting entry is created for each transaction  even though transactions are for the same employee.**


**Accounting entries are not created if the  take home pay is zero.**


**Accounting entry for crediting vendors 
 for deductions made, taxes withheld and company contributions**:


The total amount payable to the vendors associated with deductions,  taxes and company contributions are cumulated and an entry is created  for crediting the vendor.


{:.example}
If there are 3 payroll transactions on which  Federal Income Tax withheld is $125, $500 and $750; the liability account  associated with the Federal Income Tax would be credited in the accounting  entry for crediting the take home pay. An additional entry is created  for crediting the vendor associated with the Federal Income Tax payable  (the IRS) and debiting the liability account for the same. With this entry,  the liability accounts are zeroed out and the vendors associated with  them are credited.


A purchase receipt is created for the liability. The document number  assigned to the receipt is prefixed with **MPAYL**.


The purchase receipt created is like a manual purchase receipt, it will  have no line items in it. The purchase receipt created can be viewed by  selecting the option **Manual documents**  in the **Purchase Receipts** browser  (path: **Purchasing &gt; Purchase Receipts**  > from the **Purchase Receipts**  browser, select **Options &gt; Search By 
 Vendor &gt; Manual documents** or Select **View** > **US Payroll**).


The accounting entries created are:


| Accounts | Credit/Debit |
| A/P Control Account (for the amount of take home pay) | Credit |
| Liability Account for Payroll Items of type accruals,  deductions and company contributions | Debit |
| Liability Account for taxes withheld | Debit |
| Liability account for taxes payable by employer | Debit |



Payroll entries are accounted in a purchase journal that fulfills the  following conditions:

- The Journal  should have the status ‘open’.
- The date of  the transaction corresponds with the accounting period of the Journal.
- Journal with  the same journal group as the journal group selected in the Workstation  Settings dialog box (path: **File &gt; 
 Setup &gt; Preferences &gt; Work Station Settings**) of the user  who makes the Payroll entries.
- Journal with  the location as the login  location/sub-location of the user creating the payroll journal.
- Journal should  have the same account for Account Payable Control. If the A/P Control  Account is different, all subsequent entries are created in a new journal  although there are open system journals available for the same login  location/sub-location, accounting period and journal group.
- Description  of the Journal should be ‘Payroll Journal’.



If no such open journal exists, a new payroll journal is created. The  payroll journal number for the new journal is taken from the sequence  number for purchase journals for the location of the login  location/sub-location. If the login  location or sub-location does not have sequence numbers assigned, it will  use the sequence number of the default location.


{:.see_also}
See also
: [Locations  and Sub-Locations]({{site.sc_chm}}/options/locations-and-sub-locations/locations_and_departments.html)
: [Accounts  for Accounting Entries in Payroll]({{site.prl_baseurl}}/misc/accounts_for_accounting_entries_in_payroll.html)
