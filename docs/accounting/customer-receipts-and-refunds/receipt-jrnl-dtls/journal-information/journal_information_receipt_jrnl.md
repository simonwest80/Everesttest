---
title: Journal Information
---

# Journal Information


Journal information relates to the number, description and fiscal period  for the transaction. This information is common to all transactions in  the journal.


**Journal #**
: This is the unique number used to identify the journal,  and is automatically generated when the details for the first transaction  are saved. You can view other journals by selecting a journal number from  the drop-down list.
: When a new receipt journal is created, the number  assigned is the next sequence number specified for receipt journals in  the **Location** profile (path: **File** > **Setup**  > **Accounting** > **Location**/**Sub-Location** > **Options** > **Edit** > **In 
 New Window** > **Accounting**  tab > **Receipt journal #** field)  of the login location or the parent location of the login sub-location.
: ![]({{site.acc_baseurl}}/img/lens.gif) [Locations  and Sub-Location]({{site.sc_chm}}/options/locations-and-sub-locations/locations_and_departments.html)
: If sequence numbers are not defined for the login  location or the parent location of the login sub-location, the sequence  number for the default location is assigned to the document. The default  location is specified in the **Accounting**  dialog box (path: **File &gt; Setup &gt; 
 Preferences &gt; Defaults &gt; Accounting &gt; Miscellaneous** tab **&gt; Default Location** field).
: ![]({{site.acc_baseurl}}/img/lens.gif) [Journals]({{site.acc_baseurl}}/accounting-structure-in-everest/journals/journals.html)
: [Default  Location]({{site.sc_chm}}/misc/default_location.html)


**Fiscal Year and Period**
: The fiscal year and period for the journal are displayed  in these fields. The transaction date of all accounting entries in the  journal must fall in this period. These fields cannot be modified once  the journal is saved. If you change the period or the fiscal year, the  transaction date and the check date will default to the first date of  the selected period.


![]({{site.acc_baseurl}}/img/lens.gif) [Fiscal  Year and Periods]({{site.sc_chm}}/options/acc-info/fiscal-year-and-periods/fiscal_year_and_periods_1.html)


**Journal Group**
: This field identifies the group to which the journal  belongs. You can specify only one journal group for all the transactions  in a journal.


![]({{site.acc_baseurl}}/img/lens.gif) [Journal  Groups]({{site.sc_chm}}/options/acc-info/journal-groups/journal_groups.html)


**Description**
: The journal description helps the user identify  the nature of transactions in the journal. This description is printed  on all applicable reports.
: **System Entries**
: The description of receipt journals in which system  entries for document payments are made is 'Receipts Journal'.
: **Manual Entries**
: For manual entries, this field defaults to 'Receipt  Journal'. You  can modify this description as required.
: ![]({{site.acc_baseurl}}/img/example.gif)  When  miscellaneous receipts are received, you can create a journal with the  description 'Miscellaneous Receipts'.


**Bank**
: The bank account code identifies the bank account  for which the receipt journal is created. Generally, this would be your  payment clearing account. The drop-down menu displays accounts that have  been set up as a bank account in the **Chart 
 of Accounts** profile.
: ![]({{site.acc_baseurl}}/img/lens.gif) [Bank  Account - Chart of Account Profile]({{site.sc_chm}}/options/acc-info/coa/chart-of-accounts-details/bank_account.html)
: All payment methods used for transactions in this  journal must be associated with the bank account selected in this field.
: When a payment is received on a document, the accounting  entry is created in a receipt journal that has the same bank account as  the account that is associated with the payment method.
: ![]({{site.acc_baseurl}}/img/lens.gif) [General  Information - Payment Method Profile]({{site.sc_chm}}/options/payment-information/payment-methods/payment-method-details/general_information_payment_method.html)


**Additional Information**
: Use the **Narration** tab to append notes on the journal such as the reason for creating  the journal or the nature of transactions recorded. Notes are not added  automatically to system created journals.


{:.see_also}
See also
: [Journals]({{site.acc_baseurl}}/misc/journals_manrptjrnl.html)
: [Editing  accounts in journals]({{site.acc_baseurl}}/misc/editing_accounts_in_journals_accounting.html)
