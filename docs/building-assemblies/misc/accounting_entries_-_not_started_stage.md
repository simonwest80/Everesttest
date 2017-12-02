---
title: Accounting Entries - Not Started Stage
---

# Accounting Entries - Not Started Stage


Create a GJ to account for the transfer the inventory control account  from the component’s to the assembly area.


| **Account Name** | **Path** | **Debit/**<br/><br/><br/>**Credit** | **Amount** |
| Inventory Control Account | This Inventory Control account  will be based on [Rule  1a/b]({{site.sp_chm}}/misc/determining_inventory_control_account_for_sales_documents.html) and if undefined there, then from the stock area’s location defined  in **Location** profile (path: **File** > **Setup**  > **Accounting** > **Location/Sub <br/> location** > **New** >  **Location** profile > **Stock <br/> Transfer** > **Assembly 1**  tab > **Select stock bin to issue inventoried <br/> components of assembly on a work order**) | Debit | Value of the inventoried items on the work order. |
| Inventory Control Account<br/><br/><br/>(Of Components) | Inventory Control account (of components) will be defaulted based on  [Rule  1a/b]({{site.sp_chm}}/misc/determining_inventory_control_account_for_sales_documents.html) and user can override them in the document. | Credit | Value of the inventoried items on the work order. |



You can edit the quantities and stock areas in a Not Started Work in  Process document and a new General Journal should be created every time  for only the change in Stock.


In case where the stock of components is reduced , then the entry will  be as follows:


| **Account Name** | **Path** | **Debit/**<br/><br/><br/>**Credit** | **Amount** |
| Inventory Control Account | This Inventory Control account  will be based on [Rule  1a/b]({{site.sp_chm}}/misc/determining_inventory_control_account_for_sales_documents.html) and if undefined there, then based on inventory account assigned  to the  stock  area’s location defined in **Location**  profile (path: **File** > **Setup** > **Accounting**  > **Location/Sub location** >  **New** > **Location**  profile > **Stock Transfer** >  **Assembly 1** tab > **Select <br/> stock bin to issue inventoried components of assembly on a work order**) | Debit | Value of the inventoried items on the work order. |
| Inventory Control Account<br/><br/><br/>(Of Components) | Inventory Control account (of components) will be based on [Rule  1a/b]({{site.sp_chm}}/misc/determining_inventory_control_account_for_sales_documents.html) and if unavailable there, then from the stock area’s location  defined in **Location** profile  (path:  **File** > **Setup**  > **Accounting** > **Location/Sub <br/> location** > **New** >  **Location** profile > **Stock <br/> Transfer** > **Assembly 1**  tab > **Select stock bin to issue inventoried <br/> components of assembly on a work order**). | Credit | Value of the inventoried items on the work order. |



{:.see_also}
See also
: [Journal  in Which Accounting Entries are Recorded]({{site.ba_baseurl}}/prod-asm/building-wo/entering-qty-built/accounting-entries/jrn_in_which_acc_entries_are_recorded.html)
