---
title: The Pending Sales Orders Browser
---

# The Pending Sales Orders Browser


Double click the **On Reserve** column  in the **Items** browser to view the  **Pending Sales Orders** browser.  Purchase Orders are displayed with respect to each location that is added  to the **Items** browser. This browser  displays a list of sales orders that contain the selected item.


The details of items that you expect to ship to customers are thus provided.


Other sales order details such as the order date, cost of the item,  delivery method, terms, and due date are also displayed in the **Pending 
 Sales Orders** browser.


The following quantity columns are also displayed:

- **Total 
 On Reserve** - The quantity that has been ordered by the customer  (irrespective of whether it has been partly shipped or not) is displayed.  This column shows the quantity being transferred if the stock is in In-transit  state.


- **Pending 
 On Reserve** - The quantity that has NOT yet been shipped on the  order is displayed. Pending (Quantity)  = On Reserve (Quantity) - Shipped (Quantity)


- **Shipped** - The quantity that has already been shipped on the sales order  is displayed. This column displays a value if the document is on back  order.



{:.note}
All quantity fields are shown in the unit  of measure of the respective document.


**Document UM**


This column displays the unit of measure selected in the document.


**Document Type**


This column displays the type of document and the stock transfer when  the stock is in In-transit stage or being transferred from one location  to another. (Transfer stock using the **Stock 
 Transfer** browser (**Inventory**  > **Inventory Adjustment** >  **Stock Transfer**).


**Status**


This column displays the status of the item/stock. The status of the  item is shown as In-Transit when the stock is being transferred / held  in an In-transit bin. (Specify In-transit bin in the **Locations**  profile > **Stock Transfer** >  **Inventory Adjustment** tab).


You can view the **Sales Order** profile  from this browser by selecting **Options** > **Edit** > **In 
 New Window**. If you commit items on a sales order and eventually  ship them on a sales invoice, the **Pending 
 On Reserve** and the **Shipped**  columns in the **Pending Sales Orders**  browser are updated accordingly.


Double click the **On Reserve**  column in the **Items** browser to  view the **Pending Sales Orders**  browser.


Options common to all browsers are also available in this browser.


![]({{site.mi_baseurl}}/img/lens.gif) [Standard  Browser Options]({{site.wwe_chm}}/everest-client/ui/browsers/standard_browser_options.html)


{:.see_also}
See also
: [Quantity  Columns in the Items Browser]({{site.mi_baseurl}}/misc/quantity_columns_in_the_items_browser.html)
