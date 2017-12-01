---
title: Map the Source Fields Screen - Everest Related Items Import Wizard
---

# Map the Source Fields Screen - Everest Related Items Import Wizard


The **Map the Source Fields**  screen contains two panels:

- Destination Panel
- Source Panel



You have to map the fields in the source file to the fields  in the destination table.


**Destination Panel**


The following table details the columns in the Destination  panel:


| Column | Description |
| Column Name | Lists the specifications of the field. |
| Description | Details the exact description of the field in Column  Name. For example, ITEM\_CODE is Parent Item Code. |
| Type | Denoted the type of the data you can enter in this field. |
| Size | Denotes the size of the data. For example, 15 in the  Size field denotes that the field can take a maximum of 15 characters. |
| Mandatory | Indicates if the field is Mandatory or not. |



**Source Panel**


The Source panel contains the following columns:


| Column | Description |
| Column Name | Map the field from your Excel field with the corresponding field in  the Destination panel. |
| Sample View | Displays the value of the field you have just mapped. For example, the  Related Item Code is described as d1. |



Map each field in the **Source**  panel to the appropriate field in the **Destination**  panel.


{:.steps}
To map the fields from your excel file to  the fields in the Wizard, do the following:

- Click the first  row of **Column Name**. The drop-down  displays a pop-up window with two columns: Source field and Sample data.

: **Source Field**  - Denotes the value in each column of your excel spreadsheet. For example,  Price Differential denotes the price differential value you have specified  for the Related item in the excel file.
: **Sample Data**  - Displays the value from the corresponding cell in your excel spreadsheet.

- Select the appropriate  value for each field in the **Source**  field. For example, if you select Price Differential in the Source field,  the Sample View lists 10.
- Select the appropriate  values in a similar manner for all the mandatory fields.

: ![]({{site.utl_baseurl}}/img/lens.gif)[Mapping  Default and Auto Increment Values]({{site.utl_baseurl}}/db-utils/related-items-import/map-the-source-fields-screen/mapping_default_and_auto_increment_values_ut.html)
: ![]({{site.utl_baseurl}}/img/lens.gif)[Map  the Source Fields - Save and Load Settings]({{site.utl_baseurl}}/db-utils/related-items-import/map-the-source-fields-screen/save_and_load_settings_ut.html)

- Click the **Next** button. You will see the **Import 
 Data** screen of the wizard.



{:.see_also}
See also
: [Import Data]({{site.utl_baseurl}}/db-utils/related-items-import/import-data-screen/import_data_screen_ut.html)
