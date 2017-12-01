---
title: Accounting Entries - Cancel a Work Order
---

# Accounting Entries - Cancel a Work Order


The accounting entries are reversed when you cancel a work order having  the status as “In Process“. You can create an accounting entry either  by committing or by uncommitting the stock


By committing the stock:


| **Account Name** | **Path** | **Debit/**<br/><br/><br/>**Credit** | **Amount** |
| Inventory Control Account | Inventory Control account will be be based on [Rule  1a/b]({{site.sp_chm}}/misc/determining_inventory_control_account_for_sales_documents.html) or if unavailable then based on inventory account assigned  from  the stock area’s location defined in **Location**  profile (path: **File** > **Setup** > **Accounting**  > **Location/Sublocation** >  **New** > **Location**  > **Stock Transfer** > **Assembly 1** tab > **Select <br/> stock area to issue inventoried components of assembly on a work order)** | Debit | Value of the inventoried items on the work order. |
| Work in Progress Account | The WIP account debited in the 'In Process’ stage will be credited now. | Credit | Value of the inventoried items on the work order. |



By uncommitting the stock:


| **Account Name** | **Path** | **Debit/**<br/><br/><br/>**Credit** | **Amount** |
| Work In Progress Account (Of Document Location) |  | Credit | Value of the inventoried items on the work order. |
| Inventory Control Account | Inventory Control account will be based on [Rule  1a/b]({{site.sp_chm}}/misc/determining_inventory_control_account_for_sales_documents.html) or if unavailable then based on inventory account assigned to  the stock area selected in **Location**  profile (path: **File** > **Setup** > **Accounting**  > **Location/Sublocation** >  **New** > **Location**  > **Stock Transfer** > **Assembly 1** tab > **Select <br/> stock bin to receive back inventoried components of assembly previously <br/> issued on a WO**). | Debit | Value of the inventoried items on the work order. |



{:.see_also}
See also
: [Journal  in Which Entries are Recorded]({{site.ba_baseurl}}/misc/journal_in_which_entries_are_recorded_cancel_work_order.html)
: [Cancel  a Work Order]({{site.ba_baseurl}}/prod-asm/cancelling-wo/cancel_a_work_order_work_order_profile_options_process_cancel_assembly.html)
