---
title: The Attach Quantity Dialog Box
---

# The Attach Quantity Dialog Box


The **Attach** **Quantity**  dialog box enables you to commit or detach non-serialized inventoried  items on a debit order or debit memo. This dialog box comprises two sections:

- Item Information  Section
- Stock Bins  Section



Item Information Section


**Item**
: This field displays the item code and description.  You cannot edit this field.


Ordered Quantity
: This field displays the quantity entered in the  **Requested** column in the debit  order. If you create a debit memo directly, this field displays ‘zero’.


**UM**
: This field displays the purchase unit of measure  as specified in the **Item** profile  (path: **Inventory** > **Items**  > **Options &gt; Edit &gt; In New Window**  > **Purchases** tab > **Measure** field).


**View**
: Displays Specific Location by default if Logged  in Location option has been selected in **Allow 
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


This section displays a list of stock bins in which the selected item  is available, the lot numbers, the quantities available in each stock  bin and the quantities that are already attached to the debit order/memo.


The grid in **Stock Bins** section  consists of columns such as **Stock Bin**,  **Description**, **Lot 
 Number**, **Lot Expiration**,  **Expired**, **Available 
 Stock**, and **Quantity** **Attached**. All the expired lots will  appear under **Expired** column with  a “Tick Mark” ![]({{site.pp_baseurl}}/img/tick_mark_pur.gif). This will help you to identify the expired  lots. **Available** quantity is shown  in the measure selected for the item in the document.


**Avail Stock Column**
: This column appears on a quantity adjustment and  shows the available stock for the item. The available stock is the difference  between the total quantity and the committed quantity.


**Qty Attach Column**
: Enter the quantity to be committed from each stock  area. Enter the attached quantity in the decimal accuracy allowed for  the item in the document.


**Location**
: Displays location that the stock bin belongs to.


{:.note}
This column will appear only when you select **All 
 Locations** option from the **View**  drop down field.


You can search and sort the columns of the **Stock 
 Bins** Section of this dialog box. To sort the columns, you can either  click on the header of the respective columns or press **Ctrl+K.**


{:.see_also}
See also
: [Commit  Non-Serialized Items on Debit Order/Memo]({{site.pp_baseurl}}/return-proc/dos/do-processes/attaching-items-do/non-ser-items/attaching_quantities_committed_on_debit_order_non_serialized_items.html)
