---
title: The Matrix Items View Dialog Box
---

# The Matrix Items View Dialog Box


The **Matrix Items View** dialog  box displays the combinations of the matrix attributes in a grid. This  grid is constructed from the attributes selected for the vertical and  horizontal axis.


![]({{site.mi_baseurl}}/img/itemmatrix - matrix items view dialog box2_mi.gif)


**Figure: Matrix Items View Dialog Box**


**Horizontal Selection**
: Select the attribute that must be displayed in the  horizontal axis. This must be the primary attribute that you want to view  the matrix for.


{:.example}
If you want to view the details of an item  matrix for T-shirts of different sizes and patterns for each color you  will select color as the horizontal attribute.
: ![]({{site.mi_baseurl}}/img/lens.gif)[Item  Profile for the Matrix Group]({{site.mi_baseurl}}/creating-matrix-group-and-matrix-items/the-item-matrix-wizard/item_profile_for_the_matrix_group_mi.html)


**Display of Discontinued Matrix Items**

- Discontinued matrix  items are displayed in red in the grid.
- Matrix combinations  that were not selected are displayed in gray in the grid.
- Row and columns  will only be displayed in the matrix view if all items belonging to that  element combination are active.



{:.note}
When a row/column does not contain any active  items, the row/column can be hidden with a Preference Setting (path: **File** > **Setup**  > **Preferences** > **Flow 
 Control** > **Other Flow Control**  > **General** tab).


**View**
: The following options are available in the View  drop-down menu:

- **Item 
 Code** - Select this option to display the item code for all the  matrix items.
- **Available 
 Stock** - Select this option to display the available stock for each  matrix item.
- **Total 
 Stock** - Select this option to display the total stock for each  matrix item.
- **Free 
 Stock** - Select this option to display the free stock for each matrix  item. Free stock refers to the stock that is free for sale or use after  all items committed on sales and debit orders are accounted for.
- **Net 
 Free Stock** - Select this option to display the net free stock for  each matrix item. Net free stock is the stock on hand that is not committed  for shipment against sales orders and debit orders less non-saleable stock.

: These options allow you to display the respective  selection in the **Matrix Items View**  dialog box.
: The above options are displayed in the Purchase  and Sales documents when you select the matrix group. To enable the display  of Item code/Available Stock/Total Stock in the documents, open the matrix  group in **Edit** mode in the **Item** profile and select **Matrix**  from the **Matrix Group display preference 
 type** drop-down menu.


**Stock Status**
: Click the **Stock 
 Status** button to view the stock status for all the matrix items.


**Customize**
: Use this option when you do not want certain columns/elements  to be displayed in the **Matrix Items View**  dialog box. Click the **Customize**  button to view the **Customize** window.  To hide the columns drag and drop them onto the **Customize**  window.


{:.example}
The item matrix contains an attribute called  size that has the elements Small, Medium, Large and Extra Large. If you  want to view only the "Extra Large" items, you can drag and  drop the remaining columns into the Customize window.


**Print**
: Click the **Print**  button to print the matrix items grid.


{:.note}
The elements of the Horizontal and Vertical  Attributes are displayed in the same order in which they are ranked in  the Matrix Elements browser.


{:.see_also}
See also
: [View  Matrix]({{site.mi_baseurl}}/misc/view_matrix_item_matrix_groups_browser_option.html)
