---
title: Back End Processes - Manual Sales Journal
---

# Back End Processes - Manual Sales Journal


The following processes occur in the back end when a manual sales invoice/credit  memo is created:

- When a transaction  is created in a manual sales journal, debiting the customer, **Everest**  creates a manual sales invoice by prefixing M  to the document number you specify. Manual sales invoices may be viewed  in the **Sales Invoices** browser  by selecting **View &gt; Summary** from  the browser menu.
- When a transaction  is created in a manual sales journal, crediting the customer, **Everest**  creates a manual credit memo by prefixing M  to the document number you specify. Manual credit memos may be viewed  in the **Credit Memos** browser by  selecting **View &gt; Summary** from  the browser menu.
- When the customer  is credited in the manual sales journal, the customer's unposted  amount viewed in the **Customer**  profile decreases by the amount credited and the net balance decreases.

: ![]({{site.acc_baseurl}}/img/lens.gif) [Customer  Profile - Accounting Tab]({{site.mc_chm}}/creating-a-customer/the-customer-profile-accounting/the_customer_profile_accounting.html)

- When the customer  is debited, the customer's unposted  amount viewed in the **Customer**  profile increases by the amount debited and net balance increases.



{:.see_also}
See also


[Creating  a Manual Sales Journal]({{site.acc_baseurl}}/sales/manual-sales/creating-a-manual-sales-journal/creating_a_manual_sales_journal.html)
