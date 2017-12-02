---
title: Apply a Credit Memo to a Sales Order
---

# Apply a Credit Memo to a Sales Order


The following accounting entries are created when a credit memo is applied  to a sales order:


| Entry type | Account | Path | Debit/<br/><br/><br/>Credit | Amount |
| Payment by others | Bank Account | The account selected for **Accounts** in the **Payment Method** dialog  box (path: **File** > **Setup**  > **Accounting** > **Payment <br/> Methods**) | - | 0.00 |
| Deposit on Sales Order | Customer Deposits Account | The account selected for **Customer <br/> Deposits** in the **Accounting**  dialog box (path: **File** > **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **Posting Group** tab) of Customer  Posting Group type. | Credit | Amount of original credit memo in document currency  applied to the exchange rate specified in the Exchange Info tab of the  payment dialog box at the time you apply the CM to the SO. |
| Apply/refund credit memo | Accounts Receivable Control Account | The account selected for **Accounts****Receivable** in the **Accounting**  dialog box (path: **File** > **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **Posting Group** tab) of Customer  Posting Group type. | Debit | Amount of original credit memo in document currency  applied to the exchange rate used when the credit memo was created |
| Gain/Loss | Gain or Loss on Forex Transactions | The accounts selected in the **Accounting**  dialog box (path: **File** > **Setup** > **Preferences** > **Defaults** > **Accounting** > **Multicurrency** tab)<br/><br/>- G/L Account for  gain on settlement of foreign currency documents<br/>- G/L Account for  loss on settlement of foreign currency documents | Credit (for gain)<br/><br/><br/>Debit (for loss) | Difference between the original CM amount and the exchange  amount used when the CM is applied. |



If the amount outstanding on a CM document is applied in a SO, the system  always uses the exchange rate recorded in the Exchange Info tab of the  payment dialog box and records the difference between the CM exchange  rate and the payment exchange rate as Gain or loss on Foreign Exchange.  Therefore, the customer deposit will get recorded with the amount calculated  using the payment exchange rate.


The same logic applies when the amount on a DM is applied to a PO.


{:.see_also}
See also
: [Accounting  Entries - Refund a Credit Memo]({{site.sp_baseurl}}/sales-ret-docs/cms/cm-proc/refunds-on-cm/refund-dlg/accounting_entries_refund_credit_memo.html)
: [Default  Accounts for Sales Transactions]({{site.sp_baseurl}}/misc/default_accounts_for_sales_transactions.html)
