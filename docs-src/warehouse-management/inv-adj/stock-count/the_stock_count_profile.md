---
title: The Stock Count Profile
---
<script type="text/javascript" language="JavaScript1.2" x-save-method="compute-relative" src="{{site.wm_baseurl}}/misc/ehlpdhtm.js"></script><script type="text/javascript" language="JavaScript1.2">
<!-- 
if( typeof( kadovFilePopupInit ) != 'function' ) kadovFilePopupInit = new Function();if( typeof( kadovTextPopupInit ) != 'function' ) kadovTextPopupInit = new Function();
 //-->
</script>
**[]()Line Number**
: This column displays the line number of  the Item Details Grid.


**Item Code**
: Specify the code of the item for which you  want to count the stock. This is a mandatory field.


**Stock Bin**
: The bin that contains the line item is displayed  in this column.


{:.note}
In case you are retrieving an item directly  in the Item Details Grid, without using any of the **Retrieve****Items** options, you are required  to select a bin in this column. Double click in this column to display  the drop-down arrow. Click the arrow and select the bin for which you  want to conduct the stock count from the browser that is displayed.


**Stock Area**
: This column displays the stock area to which  the line item belongs.


**Stock Measure**
: The unit of measure specified in the **Stock Measure** field of the Item profile  (path: **Inventory** > **Items**  > **Items** **browser**  > **Edit** > **In 
 New Window** > **Inventory**  tab) is displayed in this column.


**System Cost**
: In case of inventoried items, this column  displays the average cost; for serialized items, it displays the weighted  average of the actual cost of the system serial numbers.


{:.note}
If you are using the Take Snapshot to Count  method, average cost, at the time of creation of the **Stock 
 Count** profile, may differ from the average cost when the document  is marked as Counted. The **System Cost**  column in the Item Details Grid is automatically updated with the new  cost. This change is also conveyed through a message.


**System Value**
: This is calculated as follows:


 - Inventoried  items: System Stock \* Average Cost
 - Serialized/Auto-serialized  items: Sum of actual cost of serial numbers




**Physical Cost**
: In case of inventoried items, this column  displays the average cost and for serialized and auto-serialized items,  it displays the weighted average of the actual cost of the physical serial  numbers.


**Physical Value**
: This is calculated as follows:


 - Inventoried  items: Physical Stock \* Average Cost
 - Serialized/Auto-serialized  items: Sum of actual cost of serial numbers




**Adjustment Quantity**
: This column displays the quantity of variance  by default. The quantity is negative if physical stock is less than the  system stock and positive if the physical stock is more than the system  stock. You can edit the quantity in the following cases:


 - The item  is either inventoried or auto-serialized
 - The adjusted  quantity is being added


: The adjusted quantity should not exceed  the variance quantity of the inventoried item.
: For serialized and auto-serialized items,  this column is updated to the quantity of the serial numbers written off  when an inventory adjustment document is created.


**Adjustment Cost**
: By default, this column displays the average  cost of the items used to adjust the quantity of variance. You can edit  this cost in the following cases:


 - The item  is either inventoried or auto-serialized.
 - The adjusted  quantity is being added.


: You cannot edit this column if you are writing  off a quantity.
: For serialized and auto-serialized items,  this column is updated with the weighted average of the actual cost of  the serial numbers written off when an inventory adjustment document is  created.


**Adjustment Value**
: This is calculated as the adjustment quantity  multiplied by the adjustment cost.


**Variance Quantity**
: This column displays the difference between  the physical and system stocks.


**Variance Value**
: This column displays the difference between  the physical and system values.


**Serial # Difference**


**System Quantity**
: This column displays the total stock of  the line item in the system when the Stock Count document is created.  The stock measure of the line item as specified in the profile of that  item is used to calculate the system stock. You cannot edit this column.


{:.note}
Double click in this column to view details  of the system quantity of serialized items in the **System 
 Serial Numbers for All Items** browser.


**Physical Quantity**
: Enter the actual quantity of the item determined  by the physical count.


{:.note}
Double click in this column to view details  of the physical quantity of serialized items in the **Physical 
 Serial Numbers for All Items** browser.


{:.note}
By default only **Line 
 number**, **Item Code**, **Stock Bin**, **Stock 
 Area**, **Stock Measure**, **System Cost**, **System 
 Quantity**, and **Physical Quantity**  columns will appear. To view other columns, click **Field 
 Chooser** icon from the tool bar.

**Location/Sub-location**
: The logged in location is displayed in this  field by default. You can select another location, if required.
: Changing the location after retrieval of  items into the document deletes the entries in the Item Details Grid.  A message warns you of the impact of selecting another location. You may  choose to retain the items in the default location by clicking **No**.  If you click **Yes**, all the items  are deleted. Thereafter, you can retrieve items pertaining to the new  location.


**Status**
: This field displays the stock count status,  which can be one of the following:
: Uncounted – The process of counting has  yet to begin.


 - **Counting 
 in Process** – The counting is in progress.
 - **Counted**  – The stock is counted and the variance is reported, but the stock is  not yet reconciled.
 - **Complete**  – The inventory adjustment and stock transfer documents are created.




**Created By**
: Select the person who is creating the stock  count document. By default the logged-in user is displayed in this field.


**Count Started**
: The date and time of the **Everest**  server is displayed here when you commence the process of counting.


**Date Finalized**
: When you mark the Stock Count document **Complete**, the date and time of the **Everest** server is displayed here. This  denotes that the counting process is over.
: To mark the document as complete, select  the option **Finalize and Adjust Quantity**  (path: **Stock Count** profile >  **Options** > **Process**  > **Finalize and Adjust Quantity**).

**Stock Areas**
: Select the stock area for which you want  to carry out the stock count. All the stock areas that belong to the logged-in  location are available for selection. You can select multiple stock areas  in this field. The stock area of the logged-in location is displayed by  default.


**Bins**
: Select the bins within the selected stock  areas to further narrow down the region for which you want to carry out  the stock count. All the bins belonging to the stock areas specified in  the **Stock Areas** field are available  for selection. You can select multiple bins in this field.


**Do not retrieve bins with zero quantity**
: Select this check box if you do not want  to include bins where system stock is zero.


**Do not retrieve bins with zero value**
: Select this check box if you do not want  to include bins for which the value is nil.
: You can enter physical stock for items that  have zero quantity or zero value.


{:.note}
If you modify any of the fields in the **Item Retrieval** **Limits**  section, **Everest** informs you that  all the existing line items in the Item Details Grid would be refreshed  based on the selection of the stock areas or bins. You may choose to continue  with the operation which refreshes all the line items. If you decide otherwise,  the existing items are retained and the field in the **Item 
 Retrieval Limits** section reverts to its original value.

**Adjustment Document**
: This field displays the Quantity Adjustment  document that is used to reconcile the discrepancy between the system  stock and physical stock. Click in this field to view the Quantity Adjustment  document. The Quantity Adjustment document displays the quantity and value  of the adjusted item. The **Stock Count**  field in this document displays the number of the corresponding Stock  Count document.


**Stock Transfer Document**
: This field displays the Stock Transfer document  created to transfer serial numbers from the bin in which they are available  in the system to the bin where they are physically available. Click in  this field to view the Stock Transfer document.

# Stock Count Profile


**Document Notes**
: Click to attach notes to the document. You will  see the **Notes** dialog box where  you can enter the relevant information.


**Document #**
: When you save a document, the system automatically  generates the document number.


**Document Date**
: The login date is automatically displayed in this  field when you create the document. You cannot change this date.


The various sections available in **Stock 
 Count** profile are as follows:

- [**Item 
 Grid Information**](javascript:kadovTextPopup(this)){:id="a1"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a1');
//--></script>
- [**Details**](javascript:kadovTextPopup(this)){:id="a2"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a2');
//--></script>
- [**Item 
 Retrieval Limits**](javascript:kadovTextPopup(this)){:id="a3"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a3');
//--></script>
- [Related  Documents](javascript:kadovTextPopup(this)){:id="a4"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a4');
//--></script>



{:.see_also}
See also
: [The Stock  Count Browser]({{site.wm_baseurl}}/inv-adj/stock-count/the_stock_count_browser.html)
: [The Stock  Count Profile Options]({{site.wm_baseurl}}/inv-adj/stock-count/stock-count-profile-options/stock_count_profile_options.html)
