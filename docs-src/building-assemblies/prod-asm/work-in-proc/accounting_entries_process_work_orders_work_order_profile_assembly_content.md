---
title: Accounting Entries - Work In Process
---

# Accounting Entries - Work In Process


When a work order’s status changes to "In Process", an accounting  entry is created in a general journal transferring the value of inventoried  items issued to production from Inventory Control account to Work-in-Process  Control account. The accounting entry created is:


| **Account Name** | **Path** | **Debit/**<br/><br/><br/>**Credit** | **Amount** |
| Work in Progress Account | Work in Progress account used  will be from the inventory posting group of the stock area’s location  to which the Work in Progress quantity is assigned to. | Debit | Value of the inventoried items on the work order. |
| Inventory Control Account | Inventory Control account will be based on [Rule  1a/b]({{site.sp_chm}}/misc/determining_inventory_control_account_for_sales_documents.html) or if unavailable then based on inventory account assigned to  the stock area selected in **Location** profile  (path: **File** > **Setup**  > **Accounting** > **Location/Sublocation**  > **New** > **Location**  > **Stock Transfer** > **Assembly 1** tab > **Select <br/> stock bin to transfer inventoried components of assembly items in process**) | Credit | Value of the inventoried items on the work order. |



{:.see_also}
See also
: [Journal  in which entries are recorded]({{site.ba_baseurl}}/misc/journal_in_which_work_in_process_entries_are_recorded.html)
: [Back  End Processes - Work in Process]({{site.ba_baseurl}}/prod-asm/work-in-proc/back_end_process_work_orders_in_process_assembly_content.html)
: [Work  In Process]({{site.ba_baseurl}}/prod-asm/work-in-proc/process_work_orders_work_order_profile_assembly_content.html)
