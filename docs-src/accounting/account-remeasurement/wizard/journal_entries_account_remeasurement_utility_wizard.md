---
title: Accounting Entries on Account Remeasurement
---

# Accounting Entries on Account Remeasurement


A journal entry is made in a general journal for the net impact on all  the account types selected.


![]({{site.acc_baseurl}}/img/example.gif)  If  there is a gain on remeasurement  of assets and a loss on remeasurement  of liabilities, the amounts are added up to find out the net gain or net  loss.


The Journal entries are listed below:


| Account | Path | Debit/Credit |
| G/L  account for gain on remeasurement  of foreign currency assets and liabilities | The account selected in the **Accounting**  dialog box (path: **File** > **Setup** > **Preferences**>  **Defaults** > **Accounting**  > **Multi**-**currency**  tab) | Credit (in case of net gain) |
| G/L  account for loss on remeasurement  of foreign currency assets and liabilities | The account selected in the **Accounting**  dialog box (path: **File** > **Setup** > **Preferences**>  **Defaults** > **Accounting**  > **Multi**-**currency**  tab) | Debit (in case of net loss) |
| Contra account for remeasurement  gain/loss | The account selected in the **Accounting**  dialog box (path: **File** > **Setup** > **Preferences**>  **Defaults** > **Accounting**  > **Multi**-**currency**  tab) | Credit (in case of net loss)<br/><br/><br/>Debit (in case of net gain) |



{:.note}
- Remeasurement  will only create an entry for the effect of remeasurement;  it never re-states the account balances.
- If a remeasurement  journal entry exists for a date subsequent to the login date, Everest  does not create back-dated remeasurement journals.


Reversal Entry for remeasurement


When the remeasurement  wizard is invoked, **Everest** checks  if remeasurement  was performed previously. If remeasurement  has been performed previously, it creates a journal with reverse entries.


It then proceeds to create a new remeasurement  journal entry as per the current exchange rates.


{:.see_also}
See also
: [Account  Remeasurement]({{site.acc_baseurl}}/account-remeasurement/account_remeasurement_accounting.html)
