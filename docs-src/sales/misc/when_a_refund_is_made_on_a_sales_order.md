---
title: When a Refund is made on a Sales Order
---

# When a Refund is made on a Sales Order


The following accounting entry is created when a refund is made on a  sales order.


| Entry Type | Account | Path | Debit/<br/><br/><br/>Credit | Amount |
| Payment by cash/check credit card/others | Bank Account | The account defined in the **Account**  field of the **Payment** **Method**  profile (path: **File** > **Setup** > **Accounting**  > **Payment** **Methods**  > **Options** > **Edit**  > **In New Window**) | Credit | Amount of the deposit applied to the exchange rate used  when the refund is made |
| Apply/refund deposit | Customer Deposits Account | The account selected for **Customer****Deposit** in the **Accounting**  dialog box (path: **File** > **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **Posting Group** tab) of Customer  Posting Group type.<br/><br/><br/>![]({{site.sp_baseurl}}/img/lens.gif)**Posting <br/> Group** profile<br/><br/><br/>[Hierarchical  Order for Customer Posting Group]({{site.bp_chm}}/misc/hierarchical_order_for_customer_posting_group_doc_flow_control_misc_other2_tab.html) | Debit | Amount of the deposit applied to the exchange rate used  when the deposit was originally made |
| Gain/Loss<br/><br/><br/>Use the debit or credit cell to offset the gain or loss |  |  | Loss is posted here | Gain is posted here |



{:.see_also}
See also
: [Accounting  Entries - Refunds to Customers]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/pmts-refunds/refunds-on-so/accounting_entries_refunds_to_customers.html)
