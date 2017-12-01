---
title: Item Details
---

# Item Details


The Item details section comprises the following information:


**Item**
: This field displays the item code and description.  You cannot edit this field.


**Ordered Quantity**
: This field displays the quantity ‘on order’.  For a purchase receipt that you create directly, this field displays ‘zero’.  You cannot edit this field.


**UM**
: This field displays the purchase unit of measure  as defined in the **Item** profile  (path: **Inventory** > **Items**  > **Options** > **Edit**  > **In New Window** > **Purchases** tab > **Measure**  field). You cannot edit this field.


**View**
: Displays **Specific 
 Location** by default if **Logged 
 in Location** option has been selected in **Allow 
 users to access stock bin of** (path: **File**  > **Setup** > **Preferences**  > **Flow Control** > **Other 
 Flow Control**) drop down field. Otherwise, it displays **All 
 Locations** if **All Locations**  option has been selected in **Allow users 
 to access stock bin of** drop down field.


{:.note}
If the preference option is set to **Allow 
 users to access stock bins of – Logged in location**, changing the  **Location** lookup to a non-logged  in location will require existing security right. Also changing the view  option from **Specific location**  to **All location** will require the  existing security right.


If you have the rights to change the view and  you  have attached the quantity in **Attach 
 Quantity** dialog box before changing the view from **Specific 
 location** to **All locations**  you will still be able to view the quantity attached.


You have attached the quantity in **Attach 
 Quantity** dialog box before changing the view from **All 
 Locations** to **Specific Location**  or from one specific location to another specific location.  Later  when you change the view a warning message will appear. Click **Yes**  to clear the quantity attached or click **No**  to retain the location.


If the assigned quantity belongs to a non-logged in location a message  will pop up asking you to change the view to **All 
 Locations** to view the quantity assigned


**Location**
: Select a location to view bins pertaining to that  location.


{:.note}
This field will not appear if **All Locations**  option is selected in **View** drop  down field.


{:.see_also}
See also
: [The  Assign Quantity Dialog Box - Non-Serialized Items]({{site.pp_baseurl}}/misc/the_assign_quantity_dialog_box_non_serialized_items.html)
