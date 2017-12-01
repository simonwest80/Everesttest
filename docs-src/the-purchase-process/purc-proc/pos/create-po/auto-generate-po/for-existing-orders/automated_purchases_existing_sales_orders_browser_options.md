---
title: Automated Purchases - Existing Sales Orders Browser Options
---

# Automated Purchases - Existing Sales Orders Browser Options


This browser has the following options:


**Dates**
: Select a date or period from the drop-down list.  The items are filtered based on the date specified in this field.
: This is the due date for delivery of the item specified  at the line-item level in the sales order. If the due date field of the  item is blank, the delivery date of the sales order is taken into account.  If the sales order does not have a delivery date, **Everest**  assumes that delivery must be made on the login date. The options available  in the **Dates** field and their functions  are listed below.


{:.note}
All date options (such as Today and This Week)  are with respect to the login date.


| **Option** | Displays a list of |
| All | All items (irrespective of the due date  for delivery) |
| Today | Items due for delivery on the login date |
| This Week | Items due for delivery during the week  in which you have logged in |
| This Week to Date | Items due for delivery between the beginning  of the week and the login date |
| This Month | Items due for delivery during the month  in which you have logged in |
| This Month to Date | Items due for delivery between the beginning  of the month and the login date |
| This Year | Items due for delivery during the year  in which you have logged in |
| This Year to Date | Items due for delivery between the beginning  of the year and the login date |
| Yesterday | Items due for delivery on the day prior  to the login date |
| Last Week | Items due for delivery during the week  prior to the one in which you have logged in |
| Last Week to date | Items due for delivery between the beginning  of the week prior to the week in which you have logged in and the login  date |
| Last Month | Items due for delivery during the month  prior to the one in which you have logged in |
| Last Month to Date | Items due for delivery between the beginning  of the month prior to the one in which you have logged in and the login  date |
| Custom | Items due for delivery between the dates  you specify in the **From** and **To** fields in the browser |



**Deselect All Items**
: Select this option to deselect all the items in  the **Automated Purchases - Existing Orders**  browser. All items are selected by default when you open the browser,  provided you have specified default vendors for these items.


**Generate Linked POs**
: Select this option to create purchase orders for  the selected items in the browser with a **l**ink to the relevant sales order from which the items were taken.  The **** **Customer 
 PO No.** field in the sales order is copied to the **Customer 
 PO No.** column of the **Item Details 
 Grid** of the purchase order. It also creates a purchase  order reference in the **PO #** column  for the corresponding line item of the sales order.
: The purchase order has one entry for every line  item selected. The due date for each line item is the same as that specified  in the sales order. The delivery method taken is the default set for the  vendor.


{:.note}
The item quantities for line items with same  item code and vendor, are clubbed even if the line item delivery/due dates  are different. However, if the cost of the line items are different, separate  line items are created within the same purchase order.
: ![]({{site.pp_baseurl}}/img/lens.gif)  [Receiving  Items on Linked POs]({{site.pp_baseurl}}/purc-proc/pos/create-po/auto-generate-po/for-existing-orders/receiving_items_on_linked_purchase_orders.html)


**Generate PO without Links**
: Select this option to create purchase orders for  the selected items in the browser without entering a reference in the  corresponding sales order. It does not create a reference to the sales  order in the purchase order either. Further, the delivery date and line  item due date are not populated in the purchase order.


{:.note}
A single purchase order is created for each vendor with line items from  different sales orders (as line items in purchase order).


For line items with the same **Item**  code and **Vendor**, the quantities  are clubbed. But If the cost of the line items are different, separate  line items are created.


| ![]({{site.pp_baseurl}}/img/lens.gif) | [Create  automated purchase orders for items on existing sales orders]({{site.pp_baseurl}}/purc-proc/pos/create-po/auto-generate-po/for-existing-orders/create_purchase_orders_for_items_on_existing_sales_orders.html) |



**Edit Line Items**
: Select this option to view the [Profile  - Line Items]({{site.pp_baseurl}}/misc/line_items_profile.html), which allows you to define a vendor for the highlighted  item(s). To create a purchase order, you have to define a vendor for the  item.


Options common to all browsers are also available in this browser.
: [Standard  Browser Options]({{site.wwe_chm}}/everest-client/ui/browsers/standard_browser_options.html)


{:.see_also}
See also
: [Automated  Purchases for Existing Sales Orders]({{site.pp_baseurl}}/purc-proc/pos/create-po/auto-generate-po/for-existing-orders/automated_purchases_for_existing_sales_orders.html)
