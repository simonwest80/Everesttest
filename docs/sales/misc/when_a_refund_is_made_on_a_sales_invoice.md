---
title: When a Refund is made on a Sales Invoice
---

# When a Refund is made on a Sales Invoice


The following accounting entry is created when a refund is made on a  sales invoice.


| Entry Type | Account | Path | Debit/<br/><br/><br/>Credit | Amount |
| Payment by cash/check/credit card/others | Bank Account | The account selected for **Accounts**  in the **Payment** **Method**  dialog box (path: **File** > **Setup** > **Accounting**  > **Payment** **Methods**  > **Options** > **Edit**  > **In New Window** > **General** tab) | Credit | (If amount is paid) |
| Refund of invoice | A/R Control Account | The account selected for **Accounts****Receivable** in the **Accounting**  dialog box (path: **File** > **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **Posting Group** tab)of Customer  Posting Group type.<br/><br/><br/>![]({{site.sp_baseurl}}/img/lens.gif)**Posting <br/> Group** profile<br/><br/><br/>[Hierarchical  Order for Customer Posting Group]({{site.bp_chm}}/misc/hierarchical_order_for_customer_posting_group_doc_flow_control_misc_other2_tab.html) | Debit | The amount of refund |
| Payment Discount | Payment Discount on Sales Account | The account defined for **Payment****Discount for Sales** in the **Accounting** dialog box (path: **File <br/> &gt; Setup &gt; Preferences &gt; Defaults &gt; Accounting &gt; Posting <br/> Group** tab) of Vendor Posting Group type.<br/><br/><br/>![]({{site.sp_baseurl}}/img/lens.gif)[Hierarchical  Order for Vendor Posting Group]({{site.bp_chm}}/misc/hierarchical_order_for_vendor_posting_group_misc_tab.html) | Credit | Discount call back value |



{:.see_also}
See also
: [Receipts Journal]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/pmts-refunds/pmts-on-so/rcpt-dlg/receipt_journal.html)
: [Accounting  Entries - Refunds to Customers]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/pmts-refunds/refunds-on-so/accounting_entries_refunds_to_customers.html)
