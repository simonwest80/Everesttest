---
title: Selecting Items for Drop Shipment
---

# Selecting Items for Drop Shipment


{:.steps}
To select items for drop shipment, do the  following:

- From the **Generate PO - Drop Ship Items** browser,  select the items for which the drop ship purchase order must be created.



{:.note}
By default, all the items in the sales order document  that are marked for drop shipment and for which no purchase order is created  are selected in this browser. To create a purchase order for items not  marked for drop shipment, select the check box next to the item.


You can change the following in the **Generate 
 PO - Drop Ship Items** browser:

- Vendor
- Quantity Ordered
- Price



Change the Vendor


You can change the vendor by selecting **Options 
 &gt; Edit Line Items** in the **Generate 
 PO - Drop Ship Items** browser, and selecting any other vendor in  the **** [**Profile - Line Item(s)** window]({{site.sp_baseurl}}/misc/the_profile_line_item_s_profile_drop_ship.html).


The items selected for the drop ship order are grouped according to  the [default vendor]({{site.mi_chm}}/item-profile-details/other-items-information/purchase/default_vendor.html)  assigned to the item in the **Item**  profile (path: **Inventory &gt; Items &gt; 
 Options &gt; Edit &gt; In New Window**).


If the item has not been assigned a default vendor you are prompted  of the same.


If more than one item has been selected and one of the items has not  been assigned a default vendor you are prompted that the vendor is not  defined for the particular item**. I**n  such an instance, a drop- ship order is not created for the item.


Modify the Quantity Ordered


You can change the quantity of the items ordered on drop shipment. Click  in the **Qty Needed** column in the  **Generate PO - Drop Ship Items** browser  and enter the quantity. Quantity ordered on drop shipment cannot be more  than the quantity on the sales order. If it is, **Everest**  prompts you with a message.


Modify the Cost


You can modify the cost of the items ordered on drop shipment. Click  in the **Cost** column in the **Generate PO - Drop Ship Items** browser  and enter the revised cost.


{:.see_also}
See also
: [Generate  Drop Ship Purchase Orders]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/gen-po-util/gen-dropship-po/generate_drop_ship_purchase_orders.html)
