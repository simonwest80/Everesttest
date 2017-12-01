---
title: Back End Processes - Create a Work Order
---

# Back End Processes - Create a Work Order


When a new work order is created, the following back end processes occur:

- The next sequence  number for work orders in the login  location or sub-location is assigned to the work order (path: **File**  > **Setup** > **Accounting**  > **Location**/**Sub-Location**>  **Options** > **Edit**  > **In New Window** > **Inventory** tab > **Work 
 Order #** field).



If sequence numbers are not defined for either  of these locations or sub-location, the sequence number for the default  location/sub-location is used.


![]({{site.ba_baseurl}}/img/lens.gif) [Default  Location]({{site.sc_chm}}/misc/default_location.html)

- The "On  Order" stock of the assembly item increases by the quantity entered  in the **Required Output** field of  the **Work Order** profile (path:  **Inventory** > **Bill 
 of Material** > **Work Order** >  **Options** > **Edit** > **In New Window** >  **Work Order** profile).
- The "On  Reserve" stock of items contained in the work order increases by  the standard input quantity as displayed in the **Std. 
 Input** column of the Item Details Grid.
- The "Available  Stock" of items contained in the work order decreases by the standard  input quantity as displayed in the **Std. 
 Input** column of the Item Details Grid.



{:.see_also}
See also
: [Stock  Status of Items on a Work Order]({{site.ba_baseurl}}/prod-asm/creating-wo/create-a-work-order/stock_status_of_items_on_a_work_order_create.html)
: [Create  a Work Order]({{site.ba_baseurl}}/prod-asm/creating-wo/create-a-work-order/create_a_work_order_work_order_profile_assembly_content.html)
