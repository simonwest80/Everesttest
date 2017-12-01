---
title: The Attach Quantity Dialog Box
---

# The Attach Quantity Dialog Box


The **Attach Quantity** dialog box **** enables you to commit or detach inventoried  items on a sales order/invoice or credit order/memo. You can also specify  the quantity to be shipped in this dialog box. The dialog box comprises  two sections:

- Item Information  section
- Stock Bins  section



Item Information Section
: The Item Information section displays the following  information:


**Item**
: This field displays the item code and description  as defined in the **Item** profile  (path: **Inventory** > **Items**  > **Options** > **Edit**  > **In New Window**). You cannot  edit this field.


**Ordered Quantity**
: This field displays the standard input quantity  of the selected item needed to assemble the required output.


**UM**
: This field displays the purchase measure as specified  in the **Item** (Assembly) profile  (path: **Inventory** > **Items**  > **Options** > **Edit**  > **In New Window** > **Purchase tab** > **Measure**  field).


**View**
: Displays **Specific 
 Location** by default if **Logged 
 in Location** option has been selected in **Allow 
 users to select stock bin of** (path: **File**  > **Setup** > **Preferences**  > **Flow Control** > **Other 
 Flow Control**) drop down field. Otherwise it displays **All 
 Locations** if **All Locations**  option has been selected in **Allow users 
 to select stock bin of** drop down field.


{:.note}
If the preference option is set to **Allow 
 users to access stock bins of – Logged in location**, changing the  **Location** lookup to a non-logged  in location will require existing security right. Also changing the view  option from **Specific location**  to **All location** will require the  existing security right.


If you have the rights to change the view and  you  have attached the quantity in **Attach 
 Quantity** dialog box before changing the view from **Specific 
 location** to **All locations**  you will still be able to view the quantity attached.


You have attached the quantity in **Attach 
 Quantity** dialog box before changing the view from **All 
 Locations** to **Specific Location**  or from one specific location to another specific location.  Later  when you change the view a warning message will appear. Click **Yes**  to clear the quantity attached or click **No**  to retain the location.


**Location**
: Select a location to view bins pertaining to that  location.


{:.note}
This field will not appear if **All Locations**  option is selected in **View** drop  down field.


Stock Bins Section


This section displays a list of stock bins in which the selected item  is available, the quantities available in each stock bin and the quantities  that are already been attached to the documents.


Only items from stock bins that belong to the logged in location are  available for selection, if the option **Allow 
 users to access stock bins of - Logged in Location** (path: **File** > **Setup**  > **Preferences** > **Flow 
 Control** > **Other Flow Control**  > **General** tab) is selected.  You will need adequate security rights to attach items from stock bins  belonging to any other location.


**Location Column**
: Displays location that the stock bin belongs to.


{:.note}
This field will appear only if **All 
 Locations** option is selected in **View**  drop down field.


You can specify the location a stock area belongs to in the **Location****Code** field of the **Stock 
 Area** profile (path: **Inventory 
 &gt; Stock Areas &gt; Options &gt; Edit &gt; In New Window**).


![]({{site.sp_baseurl}}/img/lens.gif)[Stock Bin Types]({{site.sc_chm}}/options/miscellaneous-set-up/stock-areas/stock_area_types.html)


The grid in **Stock Bins** section  consists of columns such as **Stock Bin**,  **Description**, **Lot 
 Number**, **Lot** **Expiration**,  **Expired**, **Available 
 Stock**, and **Quantity** **Attached**. The expired lots will have  check box selected  ![]({{site.sp_baseurl}}/img/tick_mark_sal.gif) under **Expired** column  . This will help you to identify the expired lots.


**Avail Stock Column**
: This column appears on a quantity adjustment and  shows the available stock for the item. The available stock is the difference  between the total quantity and the committed quantity. The **Avail 
 Stock** quantity is shown in the measure selected for the item in  the document.


**Qty Attach Column**
: In the **Qty****Attach** column, enter the quantity  to be committed from each stock bin to the sales order/credit order or  shipped on the sales invoice or returned on the credit memo. Enter the  attached quantity in the decimal accuracy allowed for the item in the  document.


{:.example}
To attach 10 numbers of the item from 'Stock  Area 1' and 15 from 'Stock Area 2', enter 10 in the **Qty****Attach** column for Stock Area 1  and 15 for Stock Area 2.


You can search and sort the columns of the **Stock 
 Bins** section of this dialog box. To sort the columns, you can either  click on the header of the respective column or press Ctrl+K.


{:.see_also}
See also
: [Non-serialized  Items - Committing Quantity on a Sales Order]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/cmt-items/enter-cmt-qty/non-ser/non_serialized_items_entering_committed_quantity.html)
: [Entering  Shipped Quantities]({{site.sp_baseurl}}/sales-docs/sis/sales-invoice-processes/shipped-quantities/entering_shipped_quantities.html)
