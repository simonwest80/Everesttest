---
title: The Attach Quantity Dialog Box
---

# The Attach Quantity Dialog Box


The **Attach Quantity** dialog box  enables you to commit or reserve non-serialized items to a work order.  This dialog box comprises two sections:

- Item Information  Section
- Stock Bins  Section



Item Information Section


The Item Information section displays the following information:


**Item**
: This field displays the item code and description  as defined in the **Item** profile  (path: **Inventory** > **Items**  > **Options** > **Edit** > **In New Window**). You  cannot edit this field.


**Ordered Quantity**
: This field displays the standard input quantity  of the selected item needed to assemble the required output.


**UM**
: This field displays the stock unit of measure as  specified in the **Item** (Assembly)  profile (path: **Inventory** >  **Items** > **Options**  > **Edit** > **In 
 New Window** > **Inventory**  tab > **Stock Measure** field).  You cannot edit this field.


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
This field will disappear from **Item 
 Information** section if **All Locations**  option is selected in **View** drop  down field and will be visible as a column in **Stock 
 Bins** section.


Stock Bins Section


This section displays a list of stock bins in which the selected item  is available, the quantities available in each stock bin and the quantities  that are already been attached to the work order.


Only items from stock bins that belong to the logged in location are  available for selection, if the option **Allow 
 users to access only those stock areas in the logged in location** (path:  **File** > **Setup**  > **Preferences** > **Flow 
 Control** > **Other Flow Control**  > **General** tab) is selected,  you will need adequate security rights to attach items from stock bins  belonging to any other location.


The grid in **Stock Bins** section  consists of columns such as **Stock Bin**,  **Description**, **Lot 
 Number**, **Lot Expiration**,  **Expired**, **Available 
 Stock**, and **Quantity** **Attached**. All the expired lots will  appear under **Expired** column with  a “Tick Mark” ![]({{site.ba_baseurl}}/img/image1.gif). This will help you to identify the expired  lots. The **Available** quantity is  shown in the measure selected for the item in the document.


**Avail Stock Column**
: This column displays on a quantity adjustment and  shows the available stock for the item. The available stock is the difference  between the total quantity and the committed quantity.


**Qty Attach Column**
: Enter the quantity to be committed from each stock  area to the work order in the **Qty****Attach** column. Enter the attached  quantity in the decimal accuracy allowed for the item in the document.


You can search and sort the columns of the **Stock 
 Bins** Section of this dialog box. To sort the columns, you can either  click on the header of the respective column or press Ctrl+K.


{:.see_also}
See also
: [Show/Attach  Quantity]({{site.ba_baseurl}}/prod-asm/att-cmt-items-to-wo/ns-items/retrieve-non-serialized-items.html)
