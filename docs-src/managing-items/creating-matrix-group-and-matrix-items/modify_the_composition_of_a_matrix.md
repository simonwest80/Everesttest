---
title: Modify the Composition of an existing Matrix Group
---

# Modify the Composition of an Existing Matrix Group


Use the **Item Matrix Wizard**  to modify the composition of an existing matrix group by adding or deleting  a matrix element. If the element was previously deleted, follow the “Add  Back a Previously Deleted Element to a Matrix Group” procedure.


Add an Element to a Matrix Group


{:.steps}
To add an element to an existing matrix group,  do the following:

- From the main menu,  click **Inventory** > **Item 
 Matrix** > **Matrix Groups**.  You will see the **Matrix Groups**  browser.
- Highlight a matrix  group and click **Edit**. You will  open the matrix group in the **Item Matrix 
 Wizard**.
- Click the **Add** button in the **Elements**  section to add an element. Select an element that belongs to an existing  Attribute the drop-down.
- Click **Next**.  The **Matrix Items** browser displays  the new matrix items.
- Select the checkboxes  to add the required matrix items to the matrix group.



![]({{site.mi_baseurl}}/img/lens.gif) [Matrix  Attributes Browser]({{site.mi_baseurl}}/creating-matrix-group-and-matrix-items/attributes/matrix_attributes_browser_mi.html)


![]({{site.mi_baseurl}}/img/lens.gif) [Matrix  Elements Browser]({{site.mi_baseurl}}/creating-matrix-group-and-matrix-items/elements/matrix_elements_browser_mi.html)


Delete an Element from a Matrix Group


{:.steps}
To delete an element from an existing matrix  group, do the following:

- From the **Item Matrix Groups** browser (path: **Inventory** > **Item****Matrix** > **Matrix 
 Groups**), select a matrix group and click **Options**  > **Edit**. The **Item 
 Matrix Wizard** displays.
- Select the attribute  to which the element belongs in the **Attributes**  section.
- Select the element  and click the ![]({{site.mi_baseurl}}/img/delete_button_mi.gif)  **Delete**  button. A Confirmation dialog box displays.
- Click **Yes**.  The matrix element is deleted. All matrix items formed with this element  will also be discontinued.



{:.example}
A matrix group is made of the attributes Size  (L, M and S) and Color (Red, Maroon and Burgundy). When matrix element  Maroon is discontinued, matrix items Maroon Large, Medium and Small are  also discontinued.


{:.note}
The **Events 
 History** browser (path: **Utility**  > **Event History**) lists both  newly created and discontinued matrix items.


Add Back a Previously Deleted Element to a Matrix Group
: When an element is removed from the matrix group,  all of the matrix items formed with the element are discontinued. When  you add back a previously deleted element, you have the opportunity to  reactivate these matrix items.


{:.steps}
To add back a previously deleted element  to a matrix group, do the following:

- From the **Item Matrix Groups** browser (path: **Inventory** > **Item 
 Matrix** > **Matrix Groups**),  select a matrix group and click **Options**  > **Edit**. The **Item 
 Matrix Wizard** displays.
- Select the attribute  to which the element belongs in the **Attributes**  section.
- In the **Elements**  section, click the![]({{site.mi_baseurl}}/img/matrix_group_element_new_button_mi.gif) **Add**  button.
- Select the element  that was previously deleted from the **Code**  drop-down list.
- Click **Next**.
- Click **Yes**  to proceed. You will see the **Matrix Items 
 to be Generated** screen.
- Do not select any  items since they already exist. Click **Next**.  You will see the **Item Matrix Groups**  browser.
- Select **Options**  > **View Items** to view matrix  items.
- For each item to  be added back to the matrix group, select the item in the browser and  then select **Options** > **Select Item** from the menu.



![]({{site.mi_baseurl}}/img/item_matrix_wizard_previously_removed_element_added4_mi.gif)


**Figure: Matrix Items Browser - Select Item Option**
: You will be prompted with the message “Item Already  exists. Do you want to associate it to this matrix group?”.

- Click **Yes**  to add the item to the matrix group.



{:.see_also}
See also
: [Modify an Item  Matrix]({{site.mi_baseurl}}/creating-matrix-group-and-matrix-items/modifying_item_matrix.html)
: [Item Matrix]({{site.mi_baseurl}}/item-profile-details/item-types/item-matrix/item_matrix.html)
