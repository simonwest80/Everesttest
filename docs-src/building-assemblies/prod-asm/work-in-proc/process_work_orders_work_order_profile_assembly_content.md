---
title: Work-in-Process
---

# Work in Process


A work order is said to be **In Process** when all the materials required for the order are drawn from material  stocks and are moved to the shop floor. You can reserve or commit materials  before the work order goes into process by attaching serial numbers or  committing stocks of non-serialized items.


![]({{site.ba_baseurl}}/img/lens.gif) [Attach/Commit  Items on a Work Order]({{site.ba_baseurl}}/prod-asm/att-cmt-items-to-wo/attach_commit_items_to_a_work_order_profile_assembly_content.html)


{:.note}
The **In****Process** option is enabled only  if quantities are attached/committed in the **Actual****Input** column.


Inventoried items cannot be added to or deleted from the work order  once the status is set to **In** **Process**. Non-inventoried items can be  added to or deleted from the work order until the status is set to **Build**.


Work In Process and the related accounts like Abnormal Loss/Abnormal  Gain will be available only at the company and location level. Even if  the user selects a Posting Group for an item or a category, for which  the WIP/Abnormal Loss/Abnormal Gain has been specified, the Posting Group  will be assigned for the item/category and the WIP/Abnormal Loss/Abnormal  Gain account will be used from the document’s location Posting Group.


{:.note}
Work in Process and the related accounts (Abnormal loss/gain) used for  this item in the transaction will be the accounts specified in the Inventory  Posting Group assigned to the document’s location and not the accounts  in the Posting Group assigned to the item/category.


Hence in the WIP Documents, where WIP/Abnormal Gain/Loss account needs  to be used, always look into the WIP document’s location.


{:.steps}
To mark a work order as in process, do the  following:

- From the **Work** **Order**  profile, select **Options** > **Process** > **In****Process**.



The status of the document is changed to **In****Process**.


{:.note}
You are also allowed to automatically change  the work order’s status to ‘In Process’  while saving a work order on which items have been committed. You will  see the **Confirmation** window. Click  **Yes** to change the status. Click  **No** to retain the work order status  as ‘Not Started’.


{:.hint}
If you also sell the components directly, without assembling them, it  is recommended that a stock area for work-in-process be identified and  set as 'In Process' stock type (path: **Inventory** > **Stock** **Areas**  > **Options** > **New** > **In** **New****Window** > **Stock****Type** field).


![]({{site.ba_baseurl}}/img/lens.gif) [Stock  Area Profile]({{site.sc_chm}}/options/miscellaneous-set-up/stock-areas/stock-areas/stock_area_profile_general_tab.html)


Set the preference to exclude stock type in 'In Process' areas for the  calculation of net free stock (path: **File**  > **Setup** > **Preferences**  > **Flow** **Control**  > **Items** > **Net****Free** **Stock**  tab > Check the **In** **Process**  option).


{:.see_also}
See also
: [Cost  of Work in Process]({{site.ba_baseurl}}/prod-asm/work-in-proc/cost_of_work_in_process_in_process_work_order_assembly_contents.html)
: [Accounting  Entries - Work in Process]({{site.ba_baseurl}}/prod-asm/work-in-proc/accounting_entries_process_work_orders_work_order_profile_assembly_content.html)
: [Accounting  Entires - Not Started Stage]({{site.ba_baseurl}}/misc/accounting_entries_-_not_started_stage.html)
: [Accounting  Entries - Canceling Work Order]({{site.ba_baseurl}}/prod-asm/cancelling-wo/accounting_entries_cancel_a_work_order_work_order_profile_options_process_assembly_content.html)
: [Accounting  Entries - Voiding Work Order]({{site.ba_baseurl}}/prod-asm/voiding-a-work-order/accounting_entries_void_a_work_order.html)
: [Accounting  Entries - Built Stage]({{site.ba_baseurl}}/prod-asm/building-wo/entering-qty-built/accounting-entries/accounting_entries_-_built_stage.html)
: [Accounting  Entries - Scrap]({{site.ba_baseurl}}/prod-asm/building-wo/entering-qty-built/accounting-entries/accounting_entry_scrap.html)
: [Accounting  Entries - Defectives]({{site.ba_baseurl}}/prod-asm/building-wo/entering-qty-built/accounting-entries/accounting_entries_defectives.html)
: [Set  Stock Area Preferences]({{site.ba_baseurl}}/prod-asm/work-in-proc/stock_status_of_items_attached_in_process_option_work_order_profile_assembly_content.html)
: [Back  End Processes]({{site.ba_baseurl}}/prod-asm/work-in-proc/back_end_process_work_orders_in_process_assembly_content.html)
