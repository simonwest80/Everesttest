---
title: Accounting Entries - Scrap
---

# Accounting Entries - Scrap


Accounting entries created to account for scrap are different based  on the inventory type:


**For Inventoried Scrap**


| **Account** | **Path** | **Debit/**<br/><br/><br/>**Credit** | **Amount** |
| Inventory Control account (Of Scrap Item) |  | Debit | The value of scrap |
| Inventory Control account | Inventory Control account will be based on [Rule  1 a/b]({{site.sp_chm}}/misc/determining_inventory_control_account_for_sales_documents.html) of the assembly item and if unavailable, then based on inventory  account assigned to the stock area selected in **Location**  profile (path: **File** > **Setup** > **Accounting**  > **Location/Sub location** >  **New** > **Location**  profile > **Stock Transfer** >  **Assembly 1** tab > **Select stock area to receive completed assembly items**) | Credit |  |



{:.note}
**Inventory Control account (of Scrap Item)  will be based on inventory account assigned in scrap item’s profile /or  scrap item’s category or if unavailable then based on inventory account  assigned to the stock area selected in **Location**  profile (path: **File** > **Setup** > **Accounting**  > **Location/Sub location** >  **New** > **Location**  profile > **Stock Transfer** >  **Assembly 1** tab > **Select 
 stock area to receive scrap items**)**


**For Non-inventoried Scrap**


| **Account** | **Path** | **Debit/**<br/><br/><br/>**Credit** | **Amount** |
| Asset or Expense account (Of Scrap Item) |  | Debit | The value of defectives |
| Inventory Control account | Inventory Control account - will be based on Rule 1 a/b and if unavailable,  then based on inventory account assigned to the stock area selected in  **Location** profile (path: **File** > **Setup**  > **Accounting** > **Location/Sub <br/> location** > **New** >  **Location** profile > **Stock <br/> Transfer** > **Assembly 1**  tab > **Select stock area to receive <br/> completed assembly items**) | Credit |  |



{:.note}
**Asset or Expense account (of Scrap Item) will  be based on [Rule  3]({{site.pp_chm}}/misc/determining_inventory_control_account_for_purchase_documents.html).**


{:.see_also}
See also
: [Journal  in Which Entries are Recorded]({{site.ba_baseurl}}/prod-asm/building-wo/entering-qty-built/accounting-entries/jrn_in_which_acc_entries_are_recorded.html)
: [Accounting  Entry when Items are Built]({{site.ba_baseurl}}/prod-asm/building-wo/entering-qty-built/accounting-entries/accounting_entries_when_items_are_built.html)
