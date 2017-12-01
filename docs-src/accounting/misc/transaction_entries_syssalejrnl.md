---
title: Transaction Entries
---

# Transaction Entries


This section displays details of the accounting entries created.


**Short/Over**
: This field displays the amount by which the transaction  is not balanced (i.e. the amount of difference between the debits and  credits), and is automatically computed. This field will always display  "zero" for entries created in a system journal.


**Account**
: The account that has been debited or credited is  displayed in this column.


**Description**
: The name of the account is displayed in this field.


**Loc/Sub-Loc**
: The location or sub-location to which the amount  has been allocated is displayed in this column. The location/sub-location  identifies the cost centers or profit centers for an expense or revenue  account. Locations/Sub-Locations can be assigned only to income and expense  accounts. The location/sub-location pertaining to the line item in the  sales document is displayed in this column.


**Entry Type**
: This column provides the reason that the account  is debited or credited. By default, the first line entry which debits  or credits the Accounts Receivable account has no entry type.
: ![]({{site.acc_baseurl}}/img/example.gif)  When  sales tax is charged on a document, the entry type is Sales Tax.
: The system entry types are:

- Taxable commissionable  revenue
- Exempt commissionable  revenue
- Taxable non-commissionable  revenue
- Exempt non-commissionable  revenue
- Cost of Goods  Sold (non-commissionable)
- Cost of Goods  Sold (commissionable)
- Cost of goods  (non-commissionable - other)
- Sales Tax Payable



**Notes**
: This column displays additional details about the  accounting entry. Notes are not defined automatically for system generated  entries.


**Job Code**
: The job code to which the amount of sales or sales  returns is allocated is displayed in this column. The job code specified  for the line item in the sales document profile is displayed.
: ![]({{site.acc_baseurl}}/img/lens.gif) [Job  Code - Sales Documents]({{site.sp_chm}}/sales-docs/docs-profile/contents/item-info/other/job_code_item_details_grid_sales_content.html)


**Debit and Credit**
: The amount that has been debited is displayed in  the Debit column while the amount that has been credited is displayed  in the Credit column. The same account cannot be debited and credited  in the same transaction entry. The debit and credit amounts for foreign  currency documents are displayed in foreign currency. To view the transactions  in base currency,<font style="color: #ff0000;" color="#FF0000"> </font>select **Options 
 &gt; View in Base Currency** from the journal profile.


{:.see_also}
See also
: [System  Sales Journal profile - General]({{site.acc_baseurl}}/sales/sales-through-documents/system-sales-journals/system_sales_journal_profile_general.html)
