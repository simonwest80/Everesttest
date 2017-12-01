---
title: Segmented Chart of Accounts
---
<script type="text/javascript" language="JavaScript1.2" x-save-method="compute-relative" src="{{site.sc_baseurl}}/misc/ehlpdhtm.js"></script><script type="text/javascript" language="JavaScript1.2">
<!-- 
if( typeof( kadovFilePopupInit ) != 'function' ) kadovFilePopupInit = new Function();if( typeof( kadovTextPopupInit ) != 'function' ) kadovTextPopupInit = new Function();
 //-->
</script>
# Segmented Chart of Accounts - Tree Structure - Assets Sample


![]({{site.sc_baseurl}}/img/segmented coa diagram assets.gif)

# Segmented Chart of Accounts - Tree Structure - Liability and Capital  Sample


![]({{site.sc_baseurl}}/img/segmented coa diagram liability capital.gif)

# Segmented Chart of Accounts - Tree Structure - Liability and Expense  Sample


![]({{site.sc_baseurl}}/img/segmented coa diagram revenue expense.gif)

# Segmented Chart of Accounts


Use the Segmented Chart of Accounts in **Everest**  to design the structure of your chart of accounts based on your industry  requirements. Your chart of accounts can be configured by the creation  of up to 22 segments and a maximum of 45 characters. Individual segments  represent your company's reporting structure as you define it. For example,  segments can be defined for division, department, region, account, and  sub-account. You can perform financial analysis for any of the segments  that you define in your account structure. By segmenting your chart of  accounts, you gain the ability to report on selective segments of your  account. Consult your Accountant before creating your chart of accounts  segment format.


The first step in creating a segmented chart of accounts is to create  your segments. Once you define your segments, you can create accounts  using those segments.


{:.note}
: If you choose not to set up segments, your **Account Code** defaults to one segment  called "**Account**" with  a length of seven characters.


The following table shows a sample segmented chart of accounts for Division  (DIV) 001: (**G** = General, **D** = Detail)


| Account Code | Description | G or D | Parent | Level |
| DIV | DEP | ACCT | SUB |
| A |  |  |  | A(sset) | G |  | 1 |
| 001 |  |  |  | Division 1 | G | A(sset) | 2 |
| 001 | 000 |  |  | Department 000 (Corporate) | G | A(sset) | 2 |
| 001 | 000 | 1100 |  | Cash Accounts | G | A(sset) | 2 |
| 001 | 000 | 1100 | 101 | Fleet Bank - Cash | D | 001-000-1100 | 3 |
| 001 | 000 | 1100 | 102 | Bank of America | D | 001-000-1100 | 3 |
| 001 | 000 | 1200 |  | Accounts Receivable | G | A(sset) | 2 |
| 001 | 000 | 1200 | 101 | AR-Trade | D | 001-000-1200 | 3 |
| L |  |  |  | L(iability) | G |  | 1 |
| 001 | 000 | 2000 |  | Short Term Liabilities | G | L(iability) | 2 |
| 001 | 000 | 2000 | 101 | Accrued Purchases | D | 001-000-2000 | 3 |
| 001 | 000 | 2000 | 101 | Accounts Payable | D | 001-000-2000 | 3 |
| 001 | 000 | 2000 | 102 | Payroll Taxes Payable | D | 001-000-2000 | 3 |
| C |  |  |  | C(aptial) | G |  | 1 |
| 001 | 000 | 3000 |  | Equity | G | C(aptial) | 2 |
| 001 | 000 | 3000 | 101 | Investments | D | 001-000-3000 | 3 |
| 001 | 000 | 3000 | 102 | Retained Earnings | D | 001-000-3000 | 3 |
| R |  |  |  | R(evenue) | G |  | 1 |
| 001 | 000 | 4000 |  | Sales Accounts | G | R(evenue) | 2 |
| 001 | 000 | 4000 | 101 | Products | D | 001-000-4000 | 3 |
| 001 | 000 | 4000 | 102 | Services | D | 001-000-4000 | 3 |
| 001 | 000 | 4000 | 103 | Support | D | 001-000-4000 | 3 |
| E |  |  |  | E(xpense) | G |  | 1 |
| 001 | 000 | 5000 |  | Operating Expenses | G | E(xpense) | 2 |
| 001 | 000 | 5000 | 001 | Rent | D | 001-000-5000 | 3 |
| 001 | 000 | 5000 | 002 | Electric | D | 001-000-5000 | 3 |
| 001 | 000 | 5000 | 003 | Payroll | D | 001-000-5000 | 3 |
| 001 | 000 | 5000 | 004 | Office | D | 001-000-5000 | 3 |



These same accounts can be represented by the following tree structure:
: [Segmented Chart of Accounts - Asset Sample](javascript:kadovTextPopup(this)){:id="a1"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a1');
//--></script>
: [Segmented Chart of Accounts - Liability  and Capital Sample](javascript:kadovTextPopup(this)){:id="a2"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a2');
//--></script>
: [Segmented Chart of Accounts - Revenue  and Expense Sample](javascript:kadovTextPopup(this)){:id="a3"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a3');
//--></script>


![]({{site.sc_baseurl}}/img/see_also.gif)
: [COA Segment  Setup Profile]({{site.sc_baseurl}}/misc/coa_segment_setup_profile.html)
: [Segmented  Accounts]({{site.sc_baseurl}}/misc/segmented_accounts_segmented_coa.html)
: [Add  Segment to Account Profile]({{site.sc_baseurl}}/misc/add_segment_to_account_profile_segmented_coa.html)
