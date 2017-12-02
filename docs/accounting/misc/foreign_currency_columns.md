---
title: Foreign Currency Columns
---

# Foreign Currency Columns


The transaction entries for foreign currency payments can be viewed  in terms of the foreign as well as the base currency. The default view  is in terms of base currency.


Select **Options &gt; View in Foreign 
 Currency** to view the entries in foreign currency. The following  additional columns are displayed in the "Transaction Entries"  section when you select the **View in Foreign 
 Currency** option:


**Currency Code**
: This column displays the currency code depending  on the type of transaction.


| ### Transaction Type | **Column Displays** |
| Miscellaneous Payment | Currency code of the selected account. |
| Apply payments to a foreign currency document | Currency code for the document. |
| Transaction related to the bank account | Currency code of the bank account. |



The currency code cannot be edited.


**Exchange Rate**
: The current exchange rate defined for the currency  (in the **Currency Code** column)  is displayed by default in this column. The exchange rate is defined in  the **Exchange** **Rate**  profile (path: **File** > **Setup** > **Accounting**  > **Multi** - **currency**  > **Exchange** **Rates**  > **Options** > **Edit** > **In New Window** >  **Buy Rate**/**Sell 
 Rate** field). The buy rate or sell rate is displayed in the **Exchange Rate** column based on the setting  made in the **Rate for payments** field  of the **Accounting** dialog box (path:  **File** > **Setup**  > **Preferences** > **Defaults**  > **Accounting** > **Multi****Currency** > **Exchange****rates** tab). If the exchange rate  is changed in the **Multi Currency**  tab of the **Payment Journal** profile,  this column is automatically updated. You cannot edit this column.


**Debit/Credit**
: The **Debit** and  **Credit** columns are renamed to  **Forex 
 Debit** and **Forex 
 Credit**. These columns display the amounts debited and credited  in foreign currency.


{:.note}
The debits and credits will not tally in the  foreign currency view as the amounts are expressed in different currencies.


{:.see_also}
See also
: [Calculation  of Foreign Currency Gains and Losses]({{site.acc_baseurl}}/vendor-payments-and-refunds/foreign-currency-payments/calculation_of_foreign_exchange_gains_and_losses.html)
