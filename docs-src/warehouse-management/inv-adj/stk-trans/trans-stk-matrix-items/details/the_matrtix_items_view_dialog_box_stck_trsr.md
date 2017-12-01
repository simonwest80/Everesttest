---
title: The Matrix Items View dialog box
---

# The Matrix Items View dialog box - Stock Transfers


The **Matrix Items View** dialog  box displays a matrix of all combinations for the item matrix. This dialog  box allows you to select and configure the information for the matrix  items that has to be transferred from one stock bin to another.


**Change**
: The **Change**  and **To** fields allow you to enter  a single value for all combinations in the matrix group. To populate the  cells in a matrix with the same data, select the parameter in the Change  field and enter the value in the To field. All cells will be populated  with the same value.
: This field consists of the following options:


| Options | Select this option to specify: |
| : Quantity for Transfer | : The quantity to be transferred |
| : Total Quantity | : The total quantity of each item |
| : Available Quantity | : The available quantity for each item |



**To**
: Enter a value in this field.


**Set**
: Click this button to apply the value entered in  the **To** field for all the combinations  in the matrix group.


{:.example}
If you select 1 in the **To**  field and click **Set**, **** this value gets populated in all the fields where matrix items  are available, in the matrix grid.


{:.note}
You can change the value specified for a field. Click  the field to modify and enter a new value.


Matrix Grid


**Attributes**
: The attributes you have defined in the **Item 
 Matrix Wizard** are displayed here.


{:.example}
If you define two attributes **Model**  and **Color** for the item matrix  Shoes, they appear as columns under **Attributes**.


![Lens.gif]({{site.wm_baseurl}}/img/lens.gif) [The  Item Matrix Wizard]({{site.mi_chm}}/creating-matrix-group-and-matrix-items/the-item-matrix-wizard/the_item_matrix_wizard.html)


**Type**
: The elements for each attribute you have defined  in the **Item Matrix Wizard** are  displayed here.


![Lens.gif]({{site.wm_baseurl}}/img/lens.gif) [The  Item Matrix Wizard]({{site.mi_chm}}/creating-matrix-group-and-matrix-items/the-item-matrix-wizard/the_item_matrix_wizard.html)


**Horizontal Selection**
: Select the attribute that you want to display as  a **Horizontal Attribute** in the  **Matrix** **Grid**.  All the elements you have defined for the attribute will be displayed  in the drop-down list.


**Stock Status**
: Click this field to see the **Item 
 Stock Status** browser that displays the stock status of the matrix  items. Based on the stock status, you can select matrix items for stock  transfer.


![Lens.gif]({{site.wm_baseurl}}/img/lens.gif) [Item  Stock Status]({{site.mi_chm}}/the-items-browser/information-available/item_stock_status_item_browser_option.html)


{:.note}
In the **Horizontal Attributes**  section of the **Matrix Items View**  dialog box, the fields that are grey are not activated in the **Item 
 Matrix Wizard** (path: **Inventory 
 &gt; Item Matrix**). The fields that are white, are activated. A  discontinued matrix item is displayed in a red cell. Place your cursor  on an activated field to display the item code and


stock available in the stock bin specified in the **Bin From** field.


**Customize**
: Use this option when you do not want certain columns  and elements to be displayed in the **Matrix 
 Items View** dialog box. Click the **Customize**  button to view the **Customize** window.  To hide the columns, drag and drop the remaining columns onto the **Customize** window.


{:.example}
The item matrix contains the attribute Size  that has the elements S, M, L and XL. If you want to view only the XL  items, you can drag and drop the S, M and L columns onto the **Customize**  window.


**Print**
: Click the **Print**  button to print the matrix items grid.


{:.see_also}
See also
: [Stock  Transfer of Matrix Items]({{site.wm_baseurl}}/inv-adj/stk-trans/trans-stk-matrix-items/stock_transfer_of_matrix_items.html)
