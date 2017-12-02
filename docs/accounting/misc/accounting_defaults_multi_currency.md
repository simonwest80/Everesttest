---
title: Accounting Defaults - Multicurrency
---

# Accounting Defaults - Multicurrency


The base currency and the accounts to be affected when there is a gain  or loss due to change in the exchange rates for currencies are set up  in the **Multi Currency - Accounting**  tab.


{:.note}
You can only select accounts that have been  set up in the base currency in the **Accounting**  dialog box.


**Base Currency**
: Specify the code of the currency in which all your  accounting should take place. This field is mandatory.
: This field is automatically updated with the value  specified in the **Base Currency**  field of the **Accounting - Currency Information**  section of the **Company Creation Wizard**.
: ![]({{site.acc_baseurl}}/img/lens.gif) [Multicurrency]({{site.sc_chm}}/options/multicurrency/multi_currency.html)


**G/L  account for gain on settlement of foreign currency documents**
: Gains or losses made on payments in foreign currency  for purchase and sale transactions are automatically computed. An exchange  gain or loss occurs when the exchange rate (between the base and foreign  currency) on the document date is different from that on the payment date.
: Specify the account used to record exchange gains.  You may select an expense or revenue account in this field.


**G/L  account for loss on settlement of foreign currency documents**
: Specify the account used to record exchange losses.  You may select an expense or revenue account in this field.


{:.note}
Depending on the statutory accounting regulations and business practices  in your country, you may choose to:

- Account for  losses on foreign exchange transactions in an expense account and gains  in a revenue account OR
- Account both  abnormal losses and gains in the same account.


**G/L  account for gain on re-measurement of foreign currency assets and liabilities**
: The **Account Re-measurement**  utility automatically measures the value of assets and liabilities on  the balance sheet date.
: Specify the account used to record re-measurement  gains. You may select an expense or revenue account in this field.


**G/L  account for loss on re-measurement of foreign currency assets and liabilities**
: Specify the account used to record re-measurement  losses. You may select an expense or revenue account in this field.


{:.note}
Depending on the statutory accounting regulations and business practices  in your country, you may choose to:

- Account for  losses on re-measurement in an expense account and gains in a revenue  account OR
- Account both  abnormal losses and gains in the same account.
: ![]({{site.acc_baseurl}}/img/lens.gif) [Re-measurement  of Foreign Currency Assets and Liabilities]({{site.sc_chm}}/options/multicurrency/re_measurement_of_foreign_currency_assets_and_liabilities.html)


**Contra account for re-measurement gain or loss**
: When assets and liabilities are re-measured, the  profit or loss made is notional and is therefore not directly taken as  an income or expense to the Profit and Loss account. They appear in the  balance sheet as a reserve. Use this option to specify the account used  to record re-measurement gain/loss. You may select an asset or liability  account in this field.


{:.see_also}
See also
: [Accounting  - Multicurrency]({{site.acc_baseurl}}/accounting-flow-control-and-defaults/accounting-defaults/accounting_multi_currency.html)
