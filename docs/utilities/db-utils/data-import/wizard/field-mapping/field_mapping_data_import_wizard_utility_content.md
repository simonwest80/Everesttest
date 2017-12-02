---
title: Field Mapping
---

# Field Mapping


The **Field Mapping** section maps  the fields to be imported (in the source table) with the fields in the  destination table. Fields that are not mapped in the destination table  can have a default value or can be auto incremented.


The **Field Mapping** section consists  of the **Destination** and **Source**  panels.


**Destination Panel**
: The **Destination** panel displays the column name, description, type and size of the  **Everest** data. The **Mandatory**  column indicates if a field is  mandatory.


**Source Panel**
: The **Source**  panel displays a sample view of the data in the source file.


{:.note}
- **Everest**  allows you to update details for items that already exist in your database.  You can update existing item information by checking the option **Update information for existing items** check box in the **Source 
 File Selection** section. The **Update 
 column in the Field Mapping** section is displayed. Select the required  fields.
- All mandatory fields  (except Custom fields) in the destination file must be mapped to the relevant  fields in the source file.
- If mandatory Custom  fields in the source data are not mapped to a destination table in the  **Everest** database, you can still  import the other data. The imported records will not contain any information  in their respective mandatory Custom fields.
- Specify the default  purchase measure to import in the **Purchase 
 Measure** field. Specify the default sales measure to import in the  **Sales Measure** field.  The  **Last Cost** is in the default purchase  measure and the **Sell Price** is  in the default sales measure. The **Average 
 Cost** is in the stock measure.


After making a mapping selection in the Source panel, one of the following  dialog boxes may display depending upon your selection:


| Selection | Displays After Selection |
| Any appropriate selection in the Column Name column  in the Source panel with a **Fixed Choices**  Destination data Type | **Enumerated Values**  dialog box - Enter source values corresponding to the Enumerated Values  in the **Everest** database.<br/><br/><br/>![]({{site.utl_baseurl}}/img/lens.gif)[Enumerated  Values Dialog Box]({{site.utl_baseurl}}/misc/enumerated_values_dialog_box.html) |
| **&lt;Default Value&gt;**  in the Column Name column in the Source panel | **Value** dialog  box - Enter a default value.<br/><br/><br/>![]({{site.utl_baseurl}}/img/lens.gif)[Specify  a Default Value]({{site.utl_baseurl}}/misc/specify_a_default_value_field_mapping_data_import_dialog_utility.html) |
| **&lt;Auto Increment&gt;**  in the Column Name column in the Source panel | **Value** dialog  box - Enter auto incremental values.<br/><br/><br/>![]({{site.utl_baseurl}}/img/lens.gif)[Auto  Incremental Values]({{site.utl_baseurl}}/misc/auto_incremental_values_field_mapping_data_import_dialog_utility.html) |



**Fixed Choices**
: If the destination data type has fixed values, you  can map this to the source data by specifying these values in [**Enumerated Values**]({{site.utl_baseurl}}/misc/enumerated_values_dialog_box.html) dialog box that  appears while a mapping is assigned.


Other information for field mapping has been grouped under the following  sections:

- [Specify  a Default Value]({{site.utl_baseurl}}/misc/specify_a_default_value_field_mapping_data_import_dialog_utility.html)
- [Auto  Incremental Values]({{site.utl_baseurl}}/misc/auto_incremental_values_field_mapping_data_import_dialog_utility.html)
- [Field  Mapping Buttons]({{site.utl_baseurl}}/db-utils/data-import/wizard/field-mapping/field_mapping_buttons_field_mapping_screen_diw_ut.html)


- Click **Next**.  You will see the **Import 
 Data** section.

