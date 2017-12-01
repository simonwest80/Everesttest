---
title: Quantity Columns in the Items Browser
---

# Quantity Columns in the Items Browser


All quantity columns for kits and matrix groups display zero as the  stocks are maintained at the kit component and matrix item level. These  quantities are stored in the stock measure up to six decimal places. A  conversion factor is used to convert these quantities to default sales  or default purchase measures. The **Items**  browser displays details of stock for the company as well as for a maximum  of three locations within the company. The quantity columns in the **Items** browser are detailed below:


**Total Stock**
: Click the **Total 
 Stock** column for a specific item to view a location–wise breakup  of quantities. This breakup is displayed in the **Item 
 Stock Status &lt;location&gt;** browser.
: You can view a further breakup of the quantities  with respect to the stock areas and the bins belonging to those stock  areas. To achieve this, click the **Total 
 Stock** column for the specific location. The stock area-wise and  bin-wise breakup is displayed in the **Item 
 Stock Status &lt;stock area - bin&gt;** browser.
: The **Item Stock 
 Status &lt;location&gt;** browser
: The **Item Stock 
 Status &lt;location&gt;** browser displays the total stock of an  item in different locations of a company.
: ![Lens.gif]({{site.mi_baseurl}}/img/lens.gif) [Item  Stock Status Dialog Box]({{site.mi_baseurl}}/the-items-browser/information-available/item_stock_status_item_browser_option.html)


**Available Stock**
: The **Available Stock**  column displays the stock available, after all the items ordered by customers  and those returnable to vendors are accounted for.
: Available stock = Total Stock - Stock on reserve  - Stock on debit (order)
: A negative quantity in the **Available 
 Stock** column indicates that more sales orders have been accepted  than can be fulfilled. Hence, stocks need to be replenished.


**Stock Measure**
: This column shows the inventory unit of measure.  You can also locate the stock measure on the **Inventory**  tab of the **Item** profile. The **Stock Measure** field is shown regardless  of which **View** menu option is selected  for viewing stock.


{:.note}
The **Total 
 Stock** and **Available Stock**  fields are stored in the stock measure up to 6 decimal places and converted,  using a conversion factor, to the default purchase or default sales measure.


**PO**
: The **PO** column  displays the total quantity of the selected item on purchase orders and  work orders.
: Double-click this column to view the **Pending 
 Purchase Orders** browser. This browser lists all the purchase orders  that contain the selected item.
: ![Lens.gif]({{site.mi_baseurl}}/img/lens.gif) [Pending  Purchase Orders Browser]({{site.mi_baseurl}}/misc/the_pending_purchase_orders_browser.html)


**CO**
: The **CO** column  displays the total quantity of the selected item on credit orders (items  to be returned by customers).
: Double-click this column to view the **Pending 
 Credit Orders** browser. This browser lists all the credit orders  that contain the selected item.
: ![Lens.gif]({{site.mi_baseurl}}/img/lens.gif) [Pending  Credit Orders Browser]({{site.mi_baseurl}}/misc/the_pending_credit_orders_browser.html)


**SO**
: The **SO** column  displays the quantity of the item on sales orders and work orders. The  stock on reserve includes quantities that are committed on sales orders  and work orders.
: <font style="color: #000000;" color="#000000">Double-click on </font>this column  to view the **Pending Sales Orders** browser.  This browser lists all the sales orders and work orders that contain the  selected item.
: ![Lens.gif]({{site.mi_baseurl}}/img/lens.gif) [Pending  Sales Orders browser]({{site.mi_baseurl}}/misc/the_pending_sales_orders_browser.html)


**DO**
: The **DO** column  displays the quantity of the item on debit orders (to be returned to the  vendor), committed or otherwise.
: Double-click on this column to view the **Pending 
 Debit Orders** browser. This browser lists all the debit orders that  contain the selected item.
: ![Lens.gif]({{site.mi_baseurl}}/img/lens.gif) [Pending  Debit Orders Browser]({{site.mi_baseurl}}/misc/the_pending_debit_orders_browser.html)


**PO Committed**
: The **PO Committed**  column displays the total quantity of the selected item committed on purchase  orders and work orders.
: Double-click this column to view the **Pending 
 Purchase/Work Orders Committed** browser. This browser lists all  the purchase orders that contain the selected item.
: ![]({{site.mi_baseurl}}/img/lens.gif)[Pending  Purchase Order Committed Browser]({{site.mi_baseurl}}/misc/pending_purchase_order_committed_browser.html)
: ![]({{site.mi_baseurl}}/img/lens.gif)[Pending  Work Orders Committed Browser]({{site.mi_baseurl}}/misc/pending_work_orders_committed_browser.html)


**CO Committed**
: The **CO Committed**  column displays the total quantity of the selected item committed on credit  orders (items to be returned by customers).
: Double-click this column to view the **Pending 
 Credit Orders Committed** browser. This browser lists all the credit  orders that contain the selected item.
: ![]({{site.mi_baseurl}}/img/lens.gif)[Pending  Credit Order Committed Browser]({{site.mi_baseurl}}/misc/pending_credit_order_committed_browser.html)


**SO Committed**
: The **SO Committed**  column displays the quantity of the item committed on sales orders and  work orders. Double-click this column to view the **Pending 
 Sales Orders Committed** browser. This browser lists all the sales  orders and work orders that contain the selected item.
: ![]({{site.mi_baseurl}}/img/lens.gif)[Pending  Sales Order Committed Browser]({{site.mi_baseurl}}/misc/pending_sales_order_committed_browser.html)


**DO Committed**
: The **DO Committed**  column displays the quantity of the item committed on debit orders (to  be returned to the vendor).
: Double-click this column to view the **Pending 
 Debit Orders Committed** browser. This browser lists all the debit  orders that contain the selected item.
: ![]({{site.mi_baseurl}}/img/lens.gif)[Pending  Debit Order Committed Browser]({{site.mi_baseurl}}/misc/pending_debit_order_committed_browser.html)


**Stock 1**
: The **Stock 1**  column displays the quantity configured in the **Stock 
 Quantity 1** section of the flow control preferences (path: **File** > **Setup**  > **Preferences** > **Flow 
 Control** > **Items** >  **Stock Quantities**).


{:.note}
The **Stock 
 1** column is displayed in the **Items**  browser provided you have configured Stock Quantity 1 and checked the  Show Stock Quantity 1 in browsers and profiles option in the **Items**  dialog box.


**Stock 2**
: The **Stock 2**  column displays the quantity configured in the Stock Quantity 2 section  of the flow control preferences (path: **File**  > **Setup** > **Preferences**  > **Flow Control** > **Items**  > **Stock Quantities**).


{:.note}
The **Stock 
 2** column  is  displayed in the **Items** browser  provided you have configured Stock Quantity 2 and checked the Show Stock  Quantity 2 in browsers and profiles option in the **Items**  dialog box.


{:.see_also}
See also
: [The Items Browser]({{site.mi_baseurl}}/the-items-browser/the_items_explorer.html)
