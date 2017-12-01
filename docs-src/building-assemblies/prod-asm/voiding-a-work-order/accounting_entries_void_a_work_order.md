---
title: Accounting Entries - Void a Work Order
---

# Accounting Entries - Void a Work Order


An accounting entry generated reversing the initial entry for **In-process** work order:


| **Account Name** | **Path** | **Debit/**<br/><br/><br/>**Credit** | **Amount** |
| Work In Progress Account\* |  | Credit | Value of the inventoried items on the work order. |
| Inventory Control Account | Inventory Control account will be based on [Rule  1a/b]({{site.sp_chm}}/misc/determining_inventory_control_account_for_sales_documents.html) or if unavailable then based on inventory account assigned to  the stock area selected in **Location**  profile (path: **File** > **Setup** > **Accounting**  > **Location/Sub location &gt; New &gt; <br/> Location** profile > **Stock Transfer**  > **Assembly 1** tab > **Select stock area to receive back inventoried <br/> components of assembly previously issued on a WO**) | Debit | Value of the inventoried items on the work order. |



\* The WIP account debited in the 'In Process’ stage will be credited  now.


An accounting entry generated reversing the initial entry for **Not Started** work order:


| **Account Name** | **Path** | **Debit/**<br/><br/><br/>**Credit** | **Amount** |
| Inventory Control Account | This Inventory Control account  will be based on [Rule  1a/b]({{site.sp_chm}}/misc/determining_inventory_control_account_for_sales_documents.html) and if unavailable there, then based on inventory account assigned  from the stock area’s location defined in **Location**  profile (**File** > **Setup**  > **Accounting** > **Location/Sub <br/> location** > **New** >  **Location** profile > **Stock <br/> Transfer** > **Assembly 1**  tab > **Select stock area to issue inventoried <br/> components of assembly on a work order**) | Credit | Value of the inventoried items on the work order. |
| Inventory Control Account | Inventory Control account will be based on [Rule  1a/b]({{site.sp_chm}}/misc/determining_inventory_control_account_for_sales_documents.html) or if unavailable then based on inventory account assigned to  the stock area selected in **Location**  profile (path: **File** > **Setup** > **Accounting**  > **Location/Sub location &gt; New &gt; <br/> Location** profile > **Stock Transfer**  > **Assembly 1** tab > **Select stock area to receive back inventoried <br/> components of assembly previously issued on a WO**) | Debit | Value of the inventoried items on the work order. |



{:.see_also}
See also
: [Void a Work Order]({{site.ba_baseurl}}/prod-asm/voiding-a-work-order/void_a_work_order.html)
