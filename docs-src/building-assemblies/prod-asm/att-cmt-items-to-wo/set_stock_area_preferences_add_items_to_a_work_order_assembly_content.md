---
title: Stock Areas Assigned - Attach/Commit Items
---

# Stock Areas Assigned - Attach/Commit Items


Items committed on the work order are assigned to ‘Stock’ type of stock  areas.


![]({{site.ba_baseurl}}/img/lens.gif) [Stock  Area Types]({{site.sc_chm}}/options/miscellaneous-set-up/stock-areas/stock_area_types.html)


You can define a setting to move the inventoried item to another stock  area once the item is assigned to a work order. This stock area is decided  using the following logic:

- Use the stock  area specified in the **Select stock area 
 to issue inventoried components of assembly on a work order** field  of the **Location** profile (path:  **File** > **Setup**  > **Accounting** > **Location**/**Sub-Location** > **Options**  > **Edit** > **In 
 New Window** > **Stock** **Transfer** > **Assembly****1** tab) for the login location.



![]({{site.ba_baseurl}}/img/lens.gif) [Location  Profile - Stock Transfer - Assembly 1 Tab]({{site.sc_chm}}/misc/stock_transfer_assembly_1.html)


[Location  Profile - Stock Transfer - Assembly 2 Tab]({{site.sc_chm}}/misc/stock_transfer_assembly_2.html)

- If the stock  area is not defined for the login location, then the stock area for the  default location is specified in the **Accounting** dialog box (path: **File**  > **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **Miscellaneous** tab > **Default Location** field) is used.



![]({{site.ba_baseurl}}/img/lens.gif) [Default  Location]({{site.sc_chm}}/misc/default_location.html)

- If this stock  area is not defined for the default location also, the stock area specified  in the **Purchase Receipt/Invoice**  option (path: **File** > **Setup** > **Accounting**  > **Location**/**Sub-Location**  > **Options** > **Edit**  > **In New Window** > **Stock** **Transfer**  > **Purchase** **Document** tab > **Select stock area to 
 transfer inventoried items when creating** section) for the login  location is used.
- If the stock  area is not specified for the login location, the stock area specified  for purchase receipts/invoices in the default location is used.



{:.see_also}
See also
: [Attach/Commit  Items on a Work Order]({{site.ba_baseurl}}/prod-asm/att-cmt-items-to-wo/attach_commit_items_to_a_work_order_profile_assembly_content.html)
