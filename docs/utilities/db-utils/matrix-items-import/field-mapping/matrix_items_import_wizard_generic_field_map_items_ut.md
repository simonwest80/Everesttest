---
title: Matrix Items Import Wizard - Generic - Field map (ITEMS)
---

# Matrix Items Import Wizard - Generic - Field map (ITEMS)


The **Generic - Field map 
 (ITEMS)** section maps the fields to be imported (in the source table)  with the fields in the destination table. Fields that are not mapped in  the destination table can have a default value or auto incremented. Map  each field in the Source Table to the appropriate field in the Destination  Table. This is essentially mapping the details of your matrix items to  the fields of the matrix group to be created in this screen.


![]({{site.utl_baseurl}}/img/importmatrix_field_map_items_ut.gif)


**Figure: Matrix Items Import Wizard - Generic  Field Map (ITEMS)**


The Generic - Field map (ITEMS) screen of the Wizard contains  two panels:

- **Destination**  - The Destination panel displays the Column Name, Description, Type and  Size of the **Everest** data. The  Mandatory column indicates if a field is mandatory.
- **Source**  - The Source panel displays the data in the Source field. You will map  the fields of your matrix items in this column.



Destination Panel


The **Destination** panel  consists of the following columns:


**Column Name**
: The **Column Name**  lists the different specifications of the matrix group as in image above.


**Description**
: The **Description**  column details the exact description of each field of the Column. For  example, the first attribute Color is described in the Description column  as Elements of Color.


**Type**
: The **Type**  column denotes the type of the data you can enter for this field. For  example, Decimal for Purchase Value.


**Size**
: The **Size**  column denotes the size of the data for the field. For example, 40 in  the Color field denotes that this field can take a maximum of 40 characters.


**Mandatory**
: The **Mandatory**  column indicates if a field is mandatory.

- **Yes**  - The value Yes indicates that you have to map this field.
- **No**  - The value No indicates that this field is optional.



Source Panel


The **Source** panel  displays a sample view of the data in the source file.  All  mandatory fields (except Custom fields) in the destination file must be  mapped to the relevant fields in the source file.


The Source column consists of two columns:


**Column Name**
: In the **Column Name**,  you have to map the field from your Excel spreadsheet with the corresponding  field in the Description column.


**Sample View**
: The **Sample View**  column displays the field that you have just mapped. For example, Color  is displayed as Red or R, the exact specification you have given in your  spreadsheet.


{:.steps}
To map the fields from your Spreadsheet to  the Everest Matrix Items Import Wizard, do the following:

- Click the first  row of **Column Name**. The drop-down  menu displays a Pop-up window with two columns: Source Field and Sample  Data.



**Source Field** - denotes  the value in each column of your Excel spreadsheet. For example, ELEMENT  denotes the **Element Separator**  and **Prefix** denotes the prefix  for the matrix group.


**Sample Data** - displays  the value from the corresponding cell in your Excel spreadsheet.

- Select the appropriate  value for each field in the **Source Field**.  For example, select Color in the Source field and you will see that the  Sample data is populated with R denoting Red. Check if this is the correct  value.
- Select the appropriate  values in a similar manner for all the mandatory fields.

: ![]({{site.utl_baseurl}}/img/lens.gif)[Mapping  Default and Auto Increment Values - Matrix Items]({{site.utl_baseurl}}/db-utils/matrix-items-import/field-mapping/mapping_default_and_auto_increment_values_matrix_items_ut.html)

- Click **Next**.  You will see the **Matrix 
 Items Import Wizard - Generic - Import** screen of the Wizard.



**Settings Button**


Save Map Settings


{:.steps}
To save your mapping settings, do the following:

- Map all the fields  from your excel file.
- Click the **Settings** button.
- Select **Save 
 Field Map Settings As** button to save the mapped settings along  with the file settings to a .Map file for later use. The file path, file  format, and file setup information is saved along with the Field Mapping  settings.



Load Map Settings


{:.steps}
To load the mapping settings automatically,  do the following:

- Click the **Settings** button.
- Click the **Load Field Map Settings** button.
- Select the saved  \*.map file. The fields will be mapped automatically.



**Advanced Button**
: You can change the format of the source data characters  by converting into upper case, lower case, proper case or smart case.  Click the **Advanced** button at the  bottom of the screen to access the **Filters**  dialog box.


{:.see_also}
See also
: [Everest  Matrix Items Import Wizard]({{site.utl_baseurl}}/db-utils/matrix-items-import/everest_matrix_items_import_wizard_ut.html)
