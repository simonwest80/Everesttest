---
title: Apply a Credit Memo to a Sales Invoice
---

# Apply a Credit Memo to a Sales Invoice


The following accounting entry is created when a credit memo is applied  to a sales invoice:


| Entry type | Account | Path | Debit/<br/><br/><br/>Credit | Amount |
| Payment by cash/check/ credit card/others | Bank Account | The account selected for **Accounts** in the **Payment Method** dialog  box (path: **File** > **Setup**  > **Accounting** > **Payment <br/> Methods** > **Options** >  **Edit** > **In <br/> New Window** > **General**  tab) | Debit | 0.00 |
| Payment Discount | Payment Discount on Sales | The account selected for **Payment <br/> Discount on Sales** in the **Accounting**  dialog box (path: **File** > **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **Posting Group** tab) of Vendor  Posting Group type.<br/><br/><br/>**![]({{site.sp_baseurl}}/img/lens.gif)[Posting  Group Profile]({{site.sc_chm}}/options/acc-info/posting-group/posting_group_profile_accounting_setup.html)** | Debit | Discount value |
| Payment on invoice | Accounts Receivable Control Account | The account selected for **Accounts****Receivable** in the **Accounting**  dialog box (path: **File** > **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **Posting Group** tab) of Customer  Posting Group type.<font style="color: #800080;" color="#800080"> </font> | Credit | Amount on invoice |
| Apply/refund credit memo | Accounts Receivable Control | The account selected for **Accounts****Receivable** in the **Accounting**  dialog box (path: **File** > **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **Posting Group** tab) of Customer  Posting Group type. | Debit | <font style="color: #000000;" color="#000000">Amount applied</font> |
| Gain/Loss | Gain on Forex Transactions or Loss on Forex Transactions | The accounts selected in the **Accounting**  dialog box (path: **File &gt; Setup &gt; <br/> Preferences &gt; Defaults &gt; Accounting &gt; Multicurrency** tab)<br/><br/>- G/L Account  for gain on settlement of foreign currency documents<br/>- G/L Account  for loss on settlement of foreign currency documents | Credit (for gain)<br/><br/><br/>Debit (for loss) | Difference between the document rate of the credit memo  and the document rate of sales invoice |



{:.note}
When a payment is received, payment discounts offered  to the customer on early settlement of dues are recorded in the following:

- **Payment 
 Discount on Sales** account.
- If the **Payment Discount on Sales** account is  not specified, **Everest** uses the  **Sales Discount** account.
- If the **Sales Discount** account is also not specified,  **Everest** uses the **Revenue**  account.


{:.see_also}
See also
: [Accounting  Entries - Refund a Credit Memo]({{site.sp_baseurl}}/sales-ret-docs/cms/cm-proc/refunds-on-cm/refund-dlg/accounting_entries_refund_credit_memo.html)
: [Default  Accounts for Sales Transactions]({{site.sp_baseurl}}/misc/default_accounts_for_sales_transactions.html)
