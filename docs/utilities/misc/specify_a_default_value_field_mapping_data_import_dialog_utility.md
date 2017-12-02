---
title: Specify a Default Value
---

# Specify a Default Value


When you import data from files, instead of mapping the source field  you can choose to populate the destination table fields with default values.


![]({{site.utl_baseurl}}/img/example.gif) When  you import items, you can specify the **Main**  stock area as the default stock area for all the inventoried items in  the destination table. In such instances, all the inventoried items in  the source file will be transferred to the **Main**  stock area in **Everest** when data  is imported.


**Default Value**
: Click the description in the **Source**  panel and select <**Default Value**>  in the **Source Field** column from  the pop-up window to enable the **Default****Value** field. This field defines  the default value for the mapped field in the database. When you input  the default value in this field, the **Sample 
 View** column in the **Source**  panel is automatically populated with this value.
: ![]({{site.utl_baseurl}}/img/example.gif) If all inventoried items are to be transferred to the **Main** stock area, select **Default 
 Value** in the **Source** panel.  Enter the value "**Main**" in this  field. The sample view column corresponding to the **Stock 
 Area** field of the destination table displays the value **Main**.


{:.see_also}
See also
: [Field  Mapping]({{site.utl_baseurl}}/db-utils/data-import/wizard/field-mapping/field_mapping_data_import_wizard_utility_content.html)
