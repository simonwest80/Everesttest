---
title: Accounting Entries - Apply Overpayment on a Sales Order as Customer Deposit
---

# Accounting Entries - Apply Overpayment on a Sales Order as Customer  Deposit 


The following accounting entries occur when you apply an overpayment  as a customer deposit to a sales order.


| Entry Type | Account | Path | Debit/<br/><br/><br/>Credit | Amount | Document reference |
| Apply deposit on sales order | Customer Deposit | The account selected for Customer Deposit in the **Accounting**  dialog box (path: **File &gt; Setup &gt; <br/> Preferences &gt; Defaults &gt; Accounting &gt; Posting Group** tab)  of Customer Posting Group type.<br/><br/><br/>![]({{site.sp_baseurl}}/img/lens.gif)[Posting  Group profile]({{site.sc_chm}}/options/acc-info/posting-group/posting_group_profile_accounting_setup.html)<br/><br/><br/>[Hierarchical  Order for Customer Posting Group]({{site.bp_chm}}/misc/hierarchical_order_for_customer_posting_group_doc_flow_control_misc_other2_tab.html) | Debit | Amount overpaid | Original sales order no. |
| Deposit on sales order | Customer Deposit | The account selected for Customer Deposit in the **Accounting**  dialog box (path: **File &gt; Setup &gt; <br/> Preferences &gt; Defaults &gt; Accounting &gt; Posting Group** tab)  of Customer Posting Group type. | Credit | Amount overpaid | Manual sales order |
| Gain/Loss on deposit | Customer Deposit Account | The account selected for Customer Deposits in the **Accounting**  dialog box (path: **File &gt; Setup &gt; <br/> Preferences &gt; Defaults &gt; Accounting &gt; Posting Group** tab)  of Customer Posting Group type. | Debit (if there is a loss)<br/><br/><br/>Credit (if there is a gain) | Difference between the exchange rate on the document date and the deposit  date | Nil |
| Gain/Loss | Gain on Forex Transactions or Loss on Forex Transactions | The accounts selected in the **Accounting**  dialog box (path: **File &gt; Setup &gt; <br/> Preferences &gt; Defaults &gt; Accounting &gt; Multicurrency** tab)<br/><br/><br/>• G/L Account for gain on settlement of foreign currency documents<br/><br/><br/>G/L Account for loss on settlement of foreign currency documents | Credit (for gain)<br/><br/><br/>Debit (for loss) | Difference between the exchange rate at the time of receiving deposit  and applying the overpayment. | Nil |



{:.see_also}
See also
: [Reduce  Document Value Below Paid Amount]({{site.sp_baseurl}}/misc/reduce_document_value_below_paid_amount.html)
: [Default  Accounts for Sales Transactions]({{site.sp_baseurl}}/misc/default_accounts_for_sales_transactions.html)
