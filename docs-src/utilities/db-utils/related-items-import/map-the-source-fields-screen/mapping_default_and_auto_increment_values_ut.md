---
title: Mapping Default and Auto Increment Values
---

# Mapping Default and Auto Increment Values - Related Items Import


Fields that are not mapped in the destination table can have  a default value or auto incremented.


![]({{site.utl_baseurl}}/img/importrelateditems-field mapping dialog box_import.gif)


**Figure: Related Items Import Wizard - Field Mapping  Dialog Box**


Default Value


When you are unable to map an appropriate value, select **Default** in the Source Field.  Enter  the value of your choice in the **Specify 
 a default value** field that is enabled in the bottom left. For example,  enter computer in Specify a default value box for Parent Item Code.


Auto Incremental Values


When you import data that has sequential numbering, use the  Auto Incremental Values section to automatically create the sequence numbers.


**Start Value**
: Define the start value to generate sequential numbers  for your data.


**Increment Value**
: Specify the incremental value for sequence numbers  to be generated.


{:.example}
To generate serial numbers for 1000 serialized  items, give the start value as 1(or a number of your choice) and define  the auto increment as 1. When the data is imported, serial numbers for  all the imported items are generated automatically and assigned the numbers  1 to 1000.


![]({{site.utl_baseurl}}/img/importmatrix_autoincrement_values_ut.gif)


**Figure: Auto Incremental Values - Related Items  Import Wizard**


If the **Prefix** and  **Suffix** fields are numeric characters,  only the start value is incremented.


**Prefix**
: Define a prefix for sequence numbers to be generated  using alphanumeric characters.


**Suffix**
: Define a suffix for sequence numbers to be generated  using alphanumeric characters.


{:.see_also}
See also
: [Map  the Source Fields Screen]({{site.utl_baseurl}}/db-utils/related-items-import/map-the-source-fields-screen/map_the_source_fields_screen_ut.html)
: [Everest  Related Items Import Wizard]({{site.utl_baseurl}}/db-utils/related-items-import/everest_related_items_import_wizard_ut.html)
