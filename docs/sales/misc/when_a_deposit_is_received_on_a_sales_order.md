---
title: When a Deposit is Received on a Sales Order
---

# When a Deposit is Received on a Sales Order


The following accounting entry is created when a new deposit is received  on a sales order in the receipt journal.


| Entry Type | Account | Path | Debit/<br/><br/><br/>Credit | Amount |
| Payment by cash/check/credit card/others | Bank Account | The account defined in the **Account**  field of the **Payment Method** profile  (path: **File** > **Setup**  > **Accounting** > **Payment****Methods** > **Options**  > **Edit** > **In <br/> New Window**) | Debit | The amount of deposit received at the payment rate |
| Deposit on Sales Order | Customer Deposit Account | The account selected for **Customer****Deposits** in the **Accounting**  dialog box (path: **File** > **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **Posting Grouop** tab)of Customer  Posting Group type.<br/><br/><br/>![]({{site.sp_baseurl}}/img/lens.gif)[Hierarchical  Order for Customer Posting Group]({{site.bp_chm}}/misc/hierarchical_order_for_customer_posting_group_doc_flow_control_misc_other2_tab.html) | <font color="#000000" class="hcp8">Credit</font> | <font color="#000000" class="hcp8">The amount of deposit received at the document rate</font> |



{:.see_also}
See also
: [Accounting Entries  - Payments from Customers]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/pmts-refunds/pmts-on-so/rcpt-dlg/accounting_entries.html)
: [Back  End Processes - Deposit on a Sales Order]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/pmts-refunds/pmts-on-so/rcpt-dlg/back_end_processes_deposit_received_on_a_sales_order.html)
