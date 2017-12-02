---
title: Accounting entries - Apply Overpayment on a Sales Invoice as Customer Deposit
---

# Accounting Entries - Apply Overpayment on a Sales Invoice as Customer  Deposit


Sometimes a customer will make a payment or deposit against a sales  invoice that is more than the document total. If you use the overpayment  as a customer deposit, the system creates the following journal entries:


| Entry Type | Account | Path | Debit/<br/><br/><br/>Credit | Amount | Document Reference |
| Payment by cash/check/credit card/others | Bank Account | The account selected for Accounts in the **Payment <br/> Method** dialog box (path: **File <br/> &gt; Setup &gt; Accounting &gt; Payment Methods &gt; Options &gt; Edit <br/> &gt; In New Window &gt; General** tab). | Nil | Nil | Nil |
| Refund of invoice | Accounts Receivable Control Account | The account selected for Accounts Receivable in the **Accounting**  dialog box (path: **File &gt; Setup &gt; <br/> Preferences &gt; Defaults &gt; Accounting &gt; Posting Group** tab)  of Customer Posting Group type.<br/><br/><br/>![]({{site.sp_baseurl}}/img/lens.gif) [Hierarchical  Order for Customer Posting Group]({{site.bp_chm}}/misc/hierarchical_order_for_customer_posting_group_doc_flow_control_misc_other2_tab.html) | Debit | The amount of overpayment | Sales invoice no. |
| Payment Discount | Payment Discount on Sales Account | The account defined for Payment Discount for Sales in the **Accounting**  dialog box (path: **File &gt; Setup &gt; <br/> Preferences &gt; Defaults &gt; Accounting &gt; Posting Group** tab)  of Vendor Posting Group type.<br/><br/><br/>![]({{site.sp_baseurl}}/img/lens.gif)[Hierarchical  Order for Vendor Posting Group]({{site.bp_chm}}/misc/hierarchical_order_for_vendor_posting_group_misc_tab.html) | Credit | Discount call back value |  |
| Deposit on sales order | Customer deposit | The account selected for Customer Deposit in the **Accounting**  dialog box (path: **File &gt; Setup &gt; <br/> Preferences &gt; Defaults &gt; Accounting &gt; Posting Group** tab)  of Customer Posting Group type.<br/><br/><br/>![]({{site.sp_baseurl}}/img/lens.gif) [Hierarchical  Order for Customer Posting Group]({{site.bp_chm}}/misc/hierarchical_order_for_customer_posting_group_doc_flow_control_misc_other2_tab.html) | Credit | The amount of overpayment at the rate identified in the **Prior <br/> Payments** tab | Manual sales order no. |



Exchange Rate Information


For foreign currency documents, the system takes into consideration  the exchange rate difference. Because the exchange rate that was available  when the overpayment was made may be different from the exchange rate  that is used when the overpayment is applied to a sales order, the system  creates a miscellaneous deposit entry to compensate for the difference.


Below is an example.


|  | Document | Base | Exchange Rate |
| Currency | GBP | USD |  |
| Amount | GBP 1200 | USD 600 | $1=2.0 GBP |
| Deposit | GBP 1500 | USD 500 | $1=3.0 GBP |



In the scenario above, the customer paid an extra 300 GBP. The system  creates the following accounting entries when the overpayment is treated  as a customer deposit:


| Entry Type | Debit | Credit |
| Payment By cash | $500 |  |
| Deposit on Sales Order |  | $400 |
| Miscellaneous  Deposit |  | $100 |



Payment by Cash= GBP 1500/3= $500


Deposit on SO = GBP 1200/3 = $400.00


Miscellaneous Deposit = GBP 300/3 = $100.00


{:.see_also}
See also
: [Reduce  Document Value Below Paid Amount]({{site.sp_baseurl}}/misc/reduce_document_value_below_paid_amount.html)
: [Default  Accounts for Sales Transactions]({{site.sp_baseurl}}/misc/default_accounts_for_sales_transactions.html)
