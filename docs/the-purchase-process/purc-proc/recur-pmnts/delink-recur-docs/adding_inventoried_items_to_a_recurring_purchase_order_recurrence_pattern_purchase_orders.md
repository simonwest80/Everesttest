---
title: Add Inventoried Items to a Recurring Purchase Order
---

# Add Inventoried Items to a Recurring Purchase Order


If you add an inventoried item to a recurring purchase order and save  it, the recurrence link is lost.


‘Recurrence link’  is the connection that ties up all purchase orders forming the recurring  series. When the recurrence link is broken for a purchase order, it is  no longer displayed when **Options**  > **Recurring** **Documents**  is selected from the **Purchase****Orders** browser.


{:.example}
You create recurring purchase orders for a  printer maintenance contract. If the vendor replaces the printer’s toner  as part of the maintenance and charges you for it, you can add the item  to the recurring purchase order, and break its link to the remaining purchase  orders in the series.


When you add an inventoried item to a recurring purchase order:

- **Everest**  warns you that the document being modified will be de-linked from the  series.
- Click **Yes** to proceed. The document’s recurrence  ID is deleted and the order is not visible in the **Purchase****Orders** browser's recurring documents  view (path: **Purchase** **Orders**  browser > **Options** > **Recurring** **Documents**).  However, de-linked orders are visible in the regular view (path: **Purchasing** > **Purchase****Orders**).
- Click **Cancel** to abort the process.



{:.see_also}
See also
: [Modifying  Recurring Purchase Order Information]({{site.pp_baseurl}}/purc-proc/recur-pmnts/upd-rec-po/modifying_recurring_purchase_order_information_recurrence_pattern_dialog_box_purhcase_orders.html)
