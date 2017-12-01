---
title: Back End Processes - Manual Purchase Journal
---

# Back End Processes - Manual Purchase Journal


The following processes occur in the back end when a manual purchase  invoice/debit memo is created:

- When a transaction  is created in a manual purchase journal crediting the vendor, **Everest**  creates a manual purchase invoice by prefixing 'M'  to the document number you specify. Manual purchase invoices may be viewed  in the **Purchase Invoices** browser  by selecting **Options &gt; Include manual** from the browser menu.
- When a transaction  is created in a manual purchase journal debiting the vendor, **Everest**  creates a manual debit memo by prefixing 'M'  to the document number you specify. Manual debit memos may be viewed in  the **Debit Memos** browser by selecting  **Options &gt; Include Manual** from  the browser menu.
- When the vendor  is credited in the manual purchase journal, the vendor's unposted  amount viewed in the **Vendor** profile  increases by the amount credited and the net balance increases.



![]({{site.acc_baseurl}}/img/lens.gif) [Vendor  Profile - Accounting Tab]({{site.mv_chm}}/creating/the-vendor-profile-accounting/balance_accounting_tab_vendors_profile.html)

- When the vendor  is debited, the vendor's unposted  amount viewed in the **Vendor** profile  decreases by the amount debited and net balance decreases.



{:.see_also}
See also


[Creating  a Manual Purchase Journal]({{site.acc_baseurl}}/purchasing/manual-purchases/creating-a-manual-purchase-journal/creating_a_manual_purchase_journal.html)
