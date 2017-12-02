---
title: Mapping Default and Auto Increment Values - Matrix Items
---

# Mapping Default and Auto Increment Values - Matrix Items Import


Fields that are not mapped in the destination table can have  a default value or auto incremented.


![]({{site.utl_baseurl}}/img/importmatrix_field_map_ut.gif)


**Figure: Matrix Import Wizard - Field Mapping  Dialog Box**


Default Value


When you are unable to map an appropriate value, select **Default** in the Source Field.  Enter  the value of your choice in the **Specify 
 a default value** field that is enabled in the bottom left. For example,  enter Clothing in Specify a default value box for Category.


Auto Incremental Values


When you import data that has sequential numbering, use the  Auto Incremental Values section to automatically create the sequence numbers.


**Start Value**
: Define the start value to generate sequential numbers  for your data.


**Increment Value**
: Specify the incremental value for sequence numbers  to be generated.


{:.example}
To generate serial numbers for 1000 serialized  items, give the start value as 1(or a number of your choice) and define  the auto increment as 1. When the data is imported, serial numbers for  all the imported items are generated automatically and assigned the numbers  1 to 1000.


{:.example}
If 100 items must be serially numbered and  the first serial number is A001, give 1 as the increment value to generate  serial numbers as A002, A003 and so on.


![]({{site.utl_baseurl}}/img/importmatrix_autoincrement_values_ut.gif)


**Figure: Matrix Import Wizard - Field Mapping  - Auto Incremental Values**


If the **Prefix** and  **Suffix** fields are numeric characters,  only the start value is incremented.


**Prefix**
: Define a prefix for sequence numbers to be generated  using alphanumeric characters.


**Suffix**
: Define a suffix for sequence numbers to be generated  using alphanumeric characters.


{:.see_also}
See also
: [Matrix  Items Import Wizard - Generic - Field map (ITEMS)]({{site.utl_baseurl}}/db-utils/matrix-items-import/field-mapping/matrix_items_import_wizard_generic_field_map_items_ut.html)
