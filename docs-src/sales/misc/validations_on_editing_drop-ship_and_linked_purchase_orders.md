---
title: Validations on Editing Drop-ship and Linked Purchase Orders
---

# Validations on Editing Drop-ship and Linked Purchase Orders


On a sales order, if you change the quantity of a line item  that has a Purchase Order reference number associated with it or delete  such a line item, **Everest** displays  a **Modification of Linked PO** dialog  box.


![]({{site.sp_baseurl}}/img/modification_of_linked_po_sal.gif)


**Figure: Modification of Linked PO Dialog Box**


The message informs you that some or all of the line items  are linked to purchase orders and provides three options:


**Delete/Modify the item on the SO and change the  quantity on the purchase order**
: If you select this option and click **OK**,  the item quantity can be modified or the line item can be deleted on both  the sales order and the linked purchase order. After the sales order is  saved, the purchase order is updated and the **PO**  quantity for the line items in the **Items**  browser is recalculated. An additional security right is required to make  this selection (Sales Order: Delete/Modify the item and change the quantity  on the purchase order).


**Delete/Modify the item on the SO and do not change  the quantity on the purchase order**
: If you select this option and click **OK**,  the item quantity can be modified or the line item can be deleted on the  sales order but NOT on the linked purchase order. The purchase order link  will be broken to the sales order. An additional security right is required  to make this selection (Sales Order: Delete/Modify the item and do not  change the quantity on the purchase order).


**Do not delete/modify the item on the SO and do  not change the quantity on the purchase order**
: This is the default selection. If you select this  option and click **OK**, the linked  purchase order will not be updated and the item remains unchanged on the  sales order.  Additional  security rights are NOT required to make this selection.


{:.see_also}
See also
: [The  Generate Purchase Orders Utility]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/gen-po-util/the_generate_drop_ship_order_utility_sales_contents.html)
