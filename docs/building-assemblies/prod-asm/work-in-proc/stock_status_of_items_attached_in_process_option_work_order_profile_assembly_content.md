---
title: Stock Status of Items - Work Order in Process
---

# Stock Status of Items - Work Order in Process


You can set a preference to move the items to another stock area when  a work order’s stage changes to "In Process". This stock area  is decided using the following logic:

- Use the stock  area specified in the **Select Stock Area 
 to issue inventoried components of assembly on a work order** field  of the **Location** profile (path:  **File &gt; Setup &gt; Accounting &gt; 
 Location/ Sub-Location &gt; Options &gt; Edit &gt; In New Window &gt; 
 Stock Transfer &gt; Assembly1** tab) for the login location.



![]({{site.ba_baseurl}}/img/lens.gif) [Location  Profile - Stock Transfer - Assembly1 Tab]({{site.sc_chm}}/misc/stock_transfer_assembly_1.html)

- If a stock  area is not defined for the logged in location, the stock area assigned  for the default location specified in the **Accounting**  dialog box (path: **File** > **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **Miscellaneous** tab > **Default Location** field) is used.



![]({{site.ba_baseurl}}/img/lens.gif) [Default  Location]({{site.sc_chm}}/misc/default_location.html)

- If this stock  area is not defined for the default location also, the stock area specified  in the **Purchase Receipt/Invoice**  option (path: **File** > **Setup** > **Accounting**  > **Location**/**Sub-Location**  > **Options** > **Edit**  > **In New Window** > **Stock** **Transfer**  > **Purchase** **Document** tab > **Select Stock Area to 
 Transfer inventoried items into when creating** section) for the  login location is used.
- If the stock  area is not specified for the login location, the stock area specified  for purchase receipts/invoices in the default location is used.



When the work order status is changed to "in process", the  stock status of the item (as displayed in the **Item 
 Stock Status** dialog box) displays the following changes:

- **Stock 
 Status in the transferred (in process) stock area** - There is an  increase in the quantity of **Stock**  and **On Reserve** stock (by the quantity  committed) in the stock area to which the item is transferred.
- **Stock 
 Status in the committed stock area** - There is a decrease in the  **Stock** and **On 
 Reserve** stock (by the quantity committed) in the stock area from  which the item is committed.



{:.note}
To view the item  stock status, select **Options** >  **Item** > **Stock****Status** from the **Work****Order** profile.


There is no change of stock at the item level.


{:.see_also}
See also
: [Work  In Process]({{site.ba_baseurl}}/prod-asm/work-in-proc/process_work_orders_work_order_profile_assembly_content.html)
: [Back  End Process - Work in Process]({{site.ba_baseurl}}/prod-asm/work-in-proc/back_end_process_work_orders_in_process_assembly_content.html)
