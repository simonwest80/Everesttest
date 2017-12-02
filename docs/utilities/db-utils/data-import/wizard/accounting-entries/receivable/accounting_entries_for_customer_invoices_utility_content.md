---
title: Accounting Entries
---

# Accounting Entries


For each import row in the Accounts Receivable import table, an accounting  entry is made in the Sales Journal for the value of the Accounts Receivable.  The following accounts are updated:


Document Type - Sales Invoice


| Account | Path | Debit /Credit | Amount |
| Accounts Receivable Control | If you populate the **A/R <br/> Control Account** field during the A/R import, the A/R Control Account  used is the account specified.<br/><br/><br/>If you leave the **A/R <br/> Control Account** field blank during the A/R import, the A/R Control  Account of the appropriate Posting Group is used:<br/><br/><br/>Account specified in the Accounts Receivable field (path:  **File** > **Setup**  > **Accounting** > **Posting <br/> Group** profile > **Accounts**  tab) of the Customer Posting Group type.<br/><br/><br/>![]({{site.utl_baseurl}}/img/lens.gif)**Posting <br/> Group** Profile<br/><br/><br/>![]({{site.utl_baseurl}}/img/lens.gif)[Hierarchical  Order for Customer Posting Group]({{site.bp_chm}}/misc/hierarchical_order_for_customer_posting_group_doc_flow_control_misc_other2_tab.html) | Debit | The total value of sales invoices being imported. |
| Crossing Entry Account (1-4) | Account specified at the time of import. Different accounts  may be used for different invoices. | Credit | The total value of sales invoices being imported. |



Document Type - Credit Memo


| Account | Path | Debit /Credit | Amount |
| Crossing Entry Account (1-4) | Account specified at the time of import. Different accounts may be used  for different credit memos. | Debit | The total value of credit memos being imported. |
| Accounts Receivable Control | If you populate the **A/R Control Account**  field during the A/R import, the A/R Control Account used is the account  specified.<br/><br/><br/>If you leave the **A/R Control Account**  field blank during the A/R import, the A/R Control Account of the appropriate  Posting Group is used:<br/><br/><br/>Account specified in the **Accounts Receivable**  field (path: **File** > **Setup**  > **Accounting** > **Posting <br/> Group** profile > **Accounts**  tab) of the Customer Posting Group type.<br/><br/><br/>![]({{site.utl_baseurl}}/img/lens.gif)**Posting <br/> Group** Profile<br/><br/><br/>![]({{site.utl_baseurl}}/img/lens.gif)[Hierarchical  Order for Customer Posting Group]({{site.bp_chm}}/misc/hierarchical_order_for_customer_posting_group_doc_flow_control_misc_other2_tab.html) | Credit | The total value of credit memos being imported. |



{:.see_also}
See also
: [Accounts  Receivable]({{site.utl_baseurl}}/db-utils/data-import/wizard/accounting-entries/receivable/customer_invoices_accounting_entries_utility_content.html)
