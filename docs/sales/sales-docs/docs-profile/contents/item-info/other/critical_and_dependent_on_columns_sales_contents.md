---
title: Critical and Dependent On
---

# Critical and Dependent On


The **Critical** and **Dependent 
 on** columns are displayed only in the **Sales 
 Order** profile. Critical items are those items without which other  items on the sales order cannot be sold. Dependant items are items whose  sale depends on another item in the sales order. You can define an item  as critical by selecting the **Critical**  field in the **Item** profile (path:  **Inventory &gt; Items &gt; Item profile 
 &gt; Inventory** tab).<font style="font-family: Verdana;" face="Verdana"> </font>The check box in the **Critical**  column is selected by default if the **Critical**  option is selected on the **Item**  profile. You can select/deselect  this check box on the **Sales Order**  profile by double-clicking in this column for the required line item.


If you mark an item as critical on the **Sales 
 Order** profile, the sales order cannot be saved until you define  another item that is dependent on it. When shipping the items, you cannot  ship dependent items until the critical item is shipped.


![]({{site.sp_baseurl}}/img/example.gif) Critical item - Computer


Dependent items - Keyboard, mouse and speakers.


You can ship the critical item (computer) without the dependent items  (keyboard, mouse and speakers), but you cannot ship the dependent items  without the critical item.


These fields are used when creating pick tickets to determine the orders  that can be fulfilled.


{:.steps}
To specify the critical item for another  item, do the following:

- Place the cursor  in the **Dependent On** column for  the required line item.
- Press the **Enter** key.
- Select the  required item. The required item has to be a critical item.



{:.note}
The critical item that you select should be present  on the sales order.


{:.see_also}
See also
: [Other  Item Information]({{site.sp_baseurl}}/sales-docs/docs-profile/contents/item-info/other/other_item_information_item_details_grid_sales_process_content.html)
