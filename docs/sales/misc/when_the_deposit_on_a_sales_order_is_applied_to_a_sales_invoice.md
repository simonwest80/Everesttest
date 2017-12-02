---
title: When the Deposit on a Sales Order is Applied to a Sales Invoice
---

# When the Deposit on a Sales Order is Applied to a Sales Invoice


The following accounting entry is created when a sales deposit is applied  to a sales invoice.


| Entry Type | Account | Path | Debit/<br/><br/><br/>Credit | Amount |
| Payment by cash/check credit card/others | Bank Account | The account selected for **Accounts**  in the **Payment** **Method**  dialog box (path: **File** > **Setup** > **Accounting**  > **Payment** **Methods**  > **Options** > **New**  > **In New Window** > **General** tab) | - | 0.00 |
| Payment on invoice | Accounts Receivable Control Account | The account selected for **Accounts****receivable** in the **Accounting**  dialog box (path: **File** > **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **Posting Group** tab)<br/><br/><br/>![]({{site.sp_baseurl}}/img/lens.gif)<font color="#800080" class="hcp8"> </font>**Posting <br/> Group** profile<br/><br/><br/><font color="#800080" class="hcp8">&nbsp;</font>     [Hierarchical  Order for Customer Posting Group]({{site.bp_chm}}/misc/hierarchical_order_for_customer_posting_group_doc_flow_control_misc_other2_tab.html) | Credit | Amount of deposit applied |
| Payment Discount | Payment Discount on Sales Account | The account defined for **Payment****Discount for Sales** in the **Accounting** dialog box (path: **File**  > **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **Posting Group** tab) of Vendor  Posting Group type.<br/><br/><br/>![]({{site.sp_baseurl}}/img/lens.gif) **Posting <br/> Group** profile<br/><br/><br/>[Hierarchical  Order for Vendor Posting Group]({{site.bp_chm}}/misc/hierarchical_order_for_vendor_posting_group_misc_tab.html) | Debit | Discount value |
| Apply deposit on sales order | Customer Deposits Account | The account selected for **Customer****Deposit** in the **Accounting**  dialog box (path: **File** > **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **Posting Group** tab) of Customer  Posting Group type. | Debit | Deposit originally received at document rate on sales order. |
| Gain/Loss | Gain on Forex Transactions or Loss on Forex Transactions | The accounts selected in the **Accounting**  dialog box (path: **File &gt; Setup &gt; <br/> Preferences &gt; Defaults &gt; Accounting &gt; Multicurrency** tab)<br/><br/>- G/L Account  for gain on settlement of foreign currency documents<br/>- G/L Account  for loss on settlement of foreign currency documents | Credit (for gain)<br/><br/><br/>Debit (for loss) | Difference between the payment rate on the sales order and document  rate on sales invoice. |



{:.see_also}
See also
: [Accounting Entries  - Payments from Customers]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/pmts-refunds/pmts-on-so/rcpt-dlg/accounting_entries.html)
: [Default  Accounts for Sales Transactions]({{site.sp_baseurl}}/misc/default_accounts_for_sales_transactions.html)
