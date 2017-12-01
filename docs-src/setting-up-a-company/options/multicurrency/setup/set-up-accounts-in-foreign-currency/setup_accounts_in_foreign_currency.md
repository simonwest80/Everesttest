---
title: Set Up Accounts in Foreign Currency
---

# <font style="color: #000000;" color="#000000">Set Up Accounts in Foreign Currency</font>


Accounts that are maintained in a foreign currency, such as accounts  in banks outside the country need to be maintained in your records as  foreign currency. **Everest** provides  you with these account balances in the base currency.


You cannot change the currency code for level 1 and level 2 accounts,  which must be in the base currency. However, level 3 accounts can be in  any currency.


{:.note}
You can change the currency code of a level  3 account provided the detail account in its tree is NOT used in any transaction.


If an account or account group is created below level 3, its currency  code should match that of the immediate parent. Whenever you choose to  edit the currency code of a level 3 account, Everest prompts you to confirm  if you wish to proceed as the account groups and detail accounts below  it would be updated with the new currency code. In other words, you cannot  modify the currency code of a detail account.


| ![]({{site.sc_baseurl}}/img/example.gif) | Assume that your base currency is USD  and you create the following accounts below it.<br/><br/><br/>| Asset Account | Level 1 | General | USD |<br/>| Current Asset | Level 2` | General | USD |<br/>| Bank | Level 3 | General | CAD |<br/>| Nations Bank | Level 4 | Detail | CAD (The currency code of the detail account matches the code of the  parent account.) |<br/>| Dominion Bank | Level 4 | Detail | CAD (The currency code of the detail account matches the code of the  parent account.) |<br/>| Singapore Bank | Level 4 | Detail | SINGD (Not  possible because the currency code, SINDGD  is not the same as the code of the parent account, CAD.) | |



{:.note}
All control accounts - Accounts Receivable,  Accounts Payable and Inventory - can be stated only in the base currency.


**Setting up an account in a foreign currency  requires you to do the following:**

- Indicate the  [foreign currency code]({{site.sc_baseurl}}/options/multicurrency/setup/set-up-accounts-in-foreign-currency/account_foreign_currency_code.html)  for the account
- Indicate if  [remeasurement]({{site.sc_baseurl}}/options/multicurrency/setup/set-up-accounts-in-foreign-currency/re_measurement.html)  is required



{:.see_also}
See also
: [Accounts  in foreign currency - Implications]({{site.sc_baseurl}}/options/multicurrency/setup/set-up-accounts-in-foreign-currency/foreign_currency_accounts.html)
: [Setting  up Multicurrency]({{site.sc_baseurl}}/options/multicurrency/setup/setting_up_multi_currency.html)
