---
title: Accounting Entries
---

# Accounting Entries


For each import row in the Accounts Payable import table, an accounting  entry is made in the Purchase Journal for the value of the Accounts Payable  amounts that are imported.


The following accounting entries are created when you import vendor  amounts:


Document Type - Purchase Invoice


| Account | Path | Debit /Credit | Amount |
| Accounts Payable Control | If you populate the **A/P** **Control Account** field during the A/P  import, the A/P Control Account used is the account specified.<br/><br/><br/>If you leave the **A/P Control Account**  field blank during the A/P import, the A/P Control Account of the appropriate  Posting Group is used:<br/><br/><br/>Account specified in the **Accounts Payable**  field (path: **File** > **Setup**  > **Accounting** > **Posting <br/> Group** profile > **Accounts**  tab) of the Vendor Posting Group type.<br/><br/><br/>![]({{site.utl_baseurl}}/img/lens.gif)**Posting <br/> Group** Profile<br/><br/><br/>![]({{site.utl_baseurl}}/img/lens.gif)[Hierarchical  Order for Vendor Posting Group]({{site.bp_chm}}/misc/hierarchical_order_for_vendor_posting_group_misc_tab.html) | Credit | The total value of the purchase invoices being imported. |
| Crossing Entry Account (1-4) | Account specified at the time of import. Different accounts may be used  for different invoices. | Debit | The total value of the purchase invoices being imported. |



Document Type - Debit Memo


| Account | Path | Debit /Credit | Amount |
| Crossing Entry Account (1-4) | Account specified at the time of import. Different accounts may be used  for different debit memos. | Credit | The total value of the debit memos being imported. |
| Accounts Payable Control | If you populate the **A/P Control Account**  field during the A/P import, the A/P Control Account used is the account  specified.<br/><br/><br/>If you leave the **A/P Control Account**  field blank during the A/P import, the A/P Control Account of the appropriate  Posting Group is used:<br/><br/><br/>Account specified in the **Accounts Payable**  field (path: **File** > **Setup**  > **Accounting** > **Posting <br/> Group** profile > **Accounts**  tab) of the Vendor Posting Group type.<br/><br/><br/>![]({{site.utl_baseurl}}/img/lens.gif)**Posting <br/> Group** Profile<br/><br/><br/>![]({{site.utl_baseurl}}/img/lens.gif)[Hierarchical  Order for Vendor Posting Group]({{site.bp_chm}}/misc/hierarchical_order_for_vendor_posting_group_misc_tab.html) | Debit | The total value of the debit memos being imported. |



{:.see_also}
See also
: [Accounts  Payable]({{site.utl_baseurl}}/db-utils/data-import/wizard/accounting-entries/payable/vendor_invoices_accounting_entries_utility_content.html)
: [Back  End Processes]({{site.utl_baseurl}}/db-utils/data-import/wizard/accounting-entries/payable/backend_processes_for_vendor_invoices_utility_content.html)
