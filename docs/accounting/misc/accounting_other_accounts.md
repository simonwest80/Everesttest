---
title: Accounting Dialog Box - Accounts - Other Accounts Tab
---

# Accounting Dialog Box - Accounts - Other Accounts Tab


The other default accounts required pertain to the accounts required  during year end closing, import of inventory, customer and vendor balances,  inventory adjustments and assembly. The **Other 
 Accounts** tab enables you to specify these default accounts.


{:.note}
You can only select accounts that have been  set up in the base currency in this tab.


**Current earnings**
: Specify the account that must be used to display  the excess of income over expenses or vice versa in the **Balance 
 Sheet** report (path: **Reports &gt; 
 Financial &gt; Balance Sheet**) for a year that is not closed. If  multiple years are not yet closed, the earnings for each year are shown  separately in the balance sheet.
: This account is normally an equity account.


**Unreconciled difference**
: Specify the account that should be used as the clearing  account while you set up the company in **Everest** initially. The balance of this account displays the value by which  your initial import of accounts receivable, accounts payable and inventory  is out of balance. The balance in this account is normally zeroed out  when you complete setting up the company. The **Unreconciled 
 Difference** account is an expense account.


**Rounding Differences**
: Specify the account to use for all rounding differences,  including tax rounding differences. In situations where an amount in a  document differs from the rounded-off amount in the appropriate account,  the difference is debited or credited to the account selected in the **Rounding Differences** field. All revenue,  expense, asset and liability accounts, except the control accounts, are  available for selection. This is a mandatory field.


| ![]({{site.acc_baseurl}}/img/example.gif) | Tax Rounding Differences - The line items in a sales document may be  associated with tax codes having varying tax components. The tax components,  in turn, may be associated with different liability accounts. The tax  amounts that are credited to each of the liability accounts are first  summed up and then rounded off to the decimal accuracy of the document  currency. The total tax amount of the document is calculated by summing  up the tax amount pertaining to each of the line items and then rounding  it off to the decimal accuracy of the document currency. This amount displayed  in the **Tax** field of the document  differs from the total of the rounded-off figures of each of the liability  accounts. This discrepancy results from the level at which the rounding-off  takes place.<br/><br/><br/>To overcome this anomaly, select an account, in the **Rounding <br/> Differences** field, to which this difference is debited or credited.<br/><br/><br/>Quantity 1 of item 102 Wheels is sold at an  item price of $39. The table below clarifies the breakup of tax associated  with the item.<br/><br/><br/>| Tax Component | Tax Rate | Tax Liability Account | Tax on Document | Total tax credited to each of the liability accounts<br/><br/><br/>(Rounded off) |<br/>| Component 1 | 5.5 | L1 | 2.145 | 2.15 |<br/>| Component 2 | 1.5 | L2 | 0.585 | 0.59 |<br/>| Total Tax (Rounded off) |  |  | 2.730 | 2.74 |<br/><br/><br/><br/>Accounting Entry<br/><br/><br/>| Account | Debit | Credit |<br/>| Sales Revenue |  | 39.00 |<br/>| Liability Account 1 |  | 02.15 |<br/>| Liability Account 2 |  | 00.59 |<br/>| Tax Round-off | 00.01 |  |<br/>| Bank | 41.73 |  | |



{:.see_also}
See also
: [Accounting  Dialog Box - Accounts]({{site.acc_baseurl}}/accounting-flow-control-and-defaults/accounting-defaults/accounting_dialog_box_-_posting_groups.html)
: [Accounting Defaults]({{site.acc_baseurl}}/accounting-flow-control-and-defaults/accounting-defaults/accounting_defaults.html)
