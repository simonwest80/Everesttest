---
title: If the Item has an Expense Account Defined
---

# If the Item has an Expense Account Defined


<font face="Verdana" class="hcp1">The following accounting 
 entry is created when an item with an expense account defined is </font><font face="Verdana" class="hcp1">returned<span style="font-family: Verdana;">.</span></font>


| Entry type | Account | Path | Debit/<br/><br/><br/>Credit | Amount |
| None | Accounts Receivable Control Account | The account selected for **Accounts <br/> Receivable** in the **Accounting**  dialog box (path: **File** > **Setup** > **Preferences**  > **Defaults** > **Accounting** > **Posting Group** tab) | Credit | Total value of the returned items less the discount |
| Exempt Commissionable  Revenue or<br/><br/><br/>Exempt Non-commissionable Revenue or<br/><br/><br/>Taxable Commissionable  Revenue or<br/><br/><br/>Taxable Non-commissionable Revenue | Sales Discount (Products/Services) | The account selected for **Sales <br/> Discounts** in the **Accounting**  dialog box (path: **File** > **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **Posting Group** tab) | Credit | The value of discount provided to the customer when the items were sold |
| Exempt Commissionable  Revenue or<br/><br/><br/>Exempt Non-commissionable Revenue or<br/><br/><br/>Taxable Commissionable  Revenue or<br/><br/><br/>Taxable Non-commissionable Revenue | Sales Returns (Products/Services) | The account selected for **Sales****Returns** in the **Accounting**  dialog box (path: **File** > **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **Posting Group** tab) | Debit | Total value of the returns |
| Sales Tax | Sales Tax Payable | The account selected for **Tax****Account** **Code**  in the **Tax** **Components**  profile (path: **File** > **Setup** > **Accounting**  > **Taxes** > **Tax****Components** > **Options**  > **Edit** > **In <br/> New Window** > **Sales** tab) | Debit | The value of tax paid on the items |



{:.note}
All accounts other than the asset account default to  the accounts selected in the **Accounting** dialog box (path: **File &gt; Setup 
 &gt; Preferences &gt; Defaults &gt; Accounting**).


![]({{site.sp_baseurl}}/img/lens.gif) [Accounting  Dialog Box]({{site.acc_chm}}/accounting-flow-control-and-defaults/accounting-defaults/accounting_defaults.html)


{:.see_also}
See also
: [Accounting  Information - Items]({{site.mi_chm}}/item-profile-details/accounting-information/accounting_information_items.html)
: [Accounting  Entry - Non-inventoried Items]({{site.sp_baseurl}}/sales-ret-docs/cms/create-cm/create-new-cm/accnt-entries/accounting_entry_for_non_inventoried_items_cm.html)
: [Default  Accounts for Sales Transactions]({{site.sp_baseurl}}/misc/default_accounts_for_sales_transactions.html)
