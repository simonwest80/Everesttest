---
title: When Payment is Received on a Sales Invoice
---

# When Payment is Received on a Sales Invoice


The following accounting entry is created when a new payment is received  on a sales invoice.


| Entry Type | Account | Path | Debit/<br/><br/><br/>Credit | Amount |
| Payment by cash/check credit card/others | Bank Account | The account selected for **Accounts**  in the **Payment** **Method**  dialog box (path: **File** > **Setup** > **Accounting**  > **Payment** **Methods**  > **Options** > **Edit**  > **In New Window** > **General** tab) | Debit | Net amount after payment discount |
| Payment Discount | Payment Discount on Sales Account | The account defined for **Payment****Discount for Sales** in the **Accounting** dialog box (path: **File**  > **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **Posting Group** tab) of Vendor  Posting Group type.<br/><br/><br/>**![]({{site.sp_baseurl}}/img/lens.gif)[Hierarchical  Order for Vendor Posting Group]({{site.bp_chm}}/misc/hierarchical_order_for_vendor_posting_group_misc_tab.html)** | Debit | Discount value |
| Payment on invoice | Accounts Receivable Control Account | The account selected for **Accounts****Receivable** in the **Accounting**  dialog box (path: **File** > **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **Posting Group** tab)of Customer  Posting Group type.<br/><br/><br/>![]({{site.sp_baseurl}}/img/lens.gif)<font style="color: #800080;" color="#800080"> </font>[Hierarchical  Order for Customer Posting Group]({{site.bp_chm}}/misc/hierarchical_order_for_customer_posting_group_doc_flow_control_misc_other2_tab.html) | Credit | Amount on invoice |



{:.see_also}
See also
: [Accounting Entries  - Payments from Customers]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/pmts-refunds/pmts-on-so/rcpt-dlg/accounting_entries.html)
: [Back  end Processes - Receipt on a Sales Invoice]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/pmts-refunds/pmts-on-so/rcpt-dlg/back_end_processes_receipt_on_a_sales_invoice.html)
