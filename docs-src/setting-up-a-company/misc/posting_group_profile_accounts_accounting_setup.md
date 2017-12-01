---
title: Posting group profile Accounts
---
<script type="text/javascript" language="JavaScript1.2" x-save-method="compute-relative" src="{{site.sc_baseurl}}/misc/ehlpdhtm.js"></script><script type="text/javascript" language="JavaScript1.2">
<!-- 
if( typeof( kadovFilePopupInit ) != 'function' ) kadovFilePopupInit = new Function();if( typeof( kadovTextPopupInit ) != 'function' ) kadovTextPopupInit = new Function();
 //-->
</script>
| Posting Groups Types | Account Fields | Account Types |
| Customers | Sales | Revenue |
| Sales Returns | Revenue |
| Sales Line Item Discounts | Revenue, Expenses |
| Sales Payment Discounts | Revenue, Expenses |
| Accounts Receivable | Accounts defined in the COA profile with the Account Type ‘ Accounts  Receivable control’ |
| Customer Advances | Accounts defined in the COA profile with the Account Type ‘ Customer  Advances control’ |
| Finance Charges | Revenue |
| Vendors | Accrued Purchases | Accounts defined in the COA profile with the Account Type 'Accrued Purchases   control' |
| Accounts Payable | Accounts defined in the COA profile with the Account Type ‘ Accounts  Payable control’ |
| Vendor Advances | Accounts defined in the COA profile with the Account Type ‘ Vendor Advances  control’ |
| Purchase Payment Discounts | Revenue, Expenses |
| Gain on Purchase Returns | Revenue, Expenses |
| Loss on Purchase Returns | Revenue, Expenses |
| Expense Account | Expenses |
| Inventory | Inventory Account | Accounts defined in the COA profile with the Account Type ‘ Inventory   control’ |
| Work In Process | Asset category accounts defined in the COA profile with the Account  Type ‘ Inventory  control’ |
| Sales | Revenue |
| Sales Returns | Revenue |
| Sales Line Item Discounts | Revenue, Expenses |
| Cost of Goods (Cost Factor) | Expenses |
| Cost of Goods | Expenses |
| Expense (used for Non Inventoried items) | Expenses |
| Asset (used for Non Inventoried items) | Assets |
| Liability (used for Non Inventoried items) | Liabilities |
| Inventory Adjustment | Revenue, Expenses |
| Work Order Abnormal Gain | Revenue, Expenses |
| Work Order Abnormal Loss | Revenue, Expenses |
| Gain on Purchase Returns | Revenue, Expenses |
| Loss on Purchase Returns | Revenue, Expenses |
| Fixed Assets | Original Asset | Assets |
| Accumulated Depreciation | Assets |
| Depreciation Expense | Expenses |

# Posting Group Profile - Accounts


The **Accounts** tab allows you  to set up appropriate accounts for each Posting Group. The Account fields  displayed in the **Accounts** tab  vary in accordance with the Posting Group Type selected in the **General**  tab of the **Posting Group** profile.  Also, the account type that you can choose for each account is based on  the Account Type selected in the **Chart 
 of Accounts** profile (path: **Accounting**  > **Chart of Accounts** > **Options** > **Edit**  > **In New Window**).


The [table](javascript:kadovTextPopup(this)){:id="a1"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a1');
//--></script>  lists the Account fields and the corresponding recommended account types  for each of the Posting Groups Types. In all the Posting Groups, other  than the Control Accounts, you are not limited to selecting the Account  Types listed. You can select Expense, Liability, Revenue, Capital, and  Asset Accounts which are not control or bank accounts. You can also overwrite  these accounts in the documents, if necessary.


For the accounts pertaining to the Inventory Posting Group, the **Accounts** tab is further split into the  following tabs:


**Accounts 1 – This tab has the following accounts:**

- Inventory Account
- WIP
- Cost of Goods (Cost Factor)
- Cost of Goods
- Expense Account
- Asset Account
- Liability Account
- Inventory Adjustment Account
- Work Order Abnormal Gain
- Work Order Abnormal Loss



**Accounts 2 – This tab has the following accounts:**

- Sales
- Sales Returns
- Sales Line Item Discount
- Gain on Purchase returns
- Loss on Purchase returns



If you select **Vendor** as the  Posting Group Type, the Purchase Price Variance Account field will appear  in the **Accounts** tab.


**Purchase Price Variance Account**
: Select an account in this field to account for the  difference in price when you edit a purchase receipt or invoice. We recommend  that you select only detailed expense and revenue accounts. Although this  field is not mandatory, you cannot proceed with any modification to a  saved purchase receipt or invoice unless this account is specified.


Irrespective of the flow control setting (path: **File**  > **Setup** > **Preferences**  > **Flow Control**), you are  advised  to specify the accounts for the Account 1 tab; the Account 2 tab is needed  only when the Posting Group preference is set to Inventory over customers/vendors.


If you leave one or more accounts blank in the Accounts tab, you are  warned that the Posting Group cannot be selected as the company default.  You can choose to save the profile as is or complete all the account fields  before saving it. Posting Groups for which all accounts have been defined  are indicated in the **Posting Group**  browser as **System Posting Groups**.


{:.note}
You can define an unlimited number of Posting  Groups for each of the Posting Group type.


{:.see_also}
See also
: [Posting  Group Profile]({{site.sc_baseurl}}/options/acc-info/posting-group/posting_group_profile_accounting_setup.html)
: [Posting  Group Profile General]({{site.sc_baseurl}}/misc/posting_group_profile_general_accounting_setup.html)
