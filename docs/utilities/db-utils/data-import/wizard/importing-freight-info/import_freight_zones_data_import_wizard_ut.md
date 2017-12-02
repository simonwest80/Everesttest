---
title: Import Freight Zones
---

# Import Freight Zones


Use the **Data Import Wizard** (path:  **Utility** > **Import**  > **Data**) to import zone information,  defined by the carriers, for calculating freight charges in **Everest**.


![]({{site.utl_baseurl}}/img/lens.gif) [Data  Import Wizard]({{site.utl_baseurl}}/db-utils/data-import/wizard/import_data_wizard_data_import_wizard_utility_content.html)


A zone can be a single state, a country, or a region, depending on how  you want to charge freight on shipments. These zones help to estimate  the freight charge for a smaller region (such as a city or zip code).  When computing freight, Everest calculates the charges based on the zone  in which the shipping address is defined.


{:.steps}
To import freight zone information into Everest,  do the following:

- Create the freight  zone import file for **Everest**.  Download rate and zone files from your freight carrier's website.  If  you do not see them published there, contact your Account Manager for  the carrier (i.e. UPS or FedEx) to request the files in .CSV or Excel  format. See the **Freight 
 Zone Import File Format** section for this information.


- Review the Freight  Zone import template in the following directory:
..\Icode\Everest\Client\Utilities\ImportTemplates
- From the main menu  bar, select **Utility** > **Import** > **Data**.  You will see the **Data Import Wizard**.
- Select **Next**.  You will see the **Select Data to Import**  screen.
- In the **Import 
 Data Description** column, select **Freight 
 Zones**.
- Click **Next**.  The **Source File Selection** screen  is displayed.



**Import File Type**
: Select the type of file to be imported, such as  Excel or Text.


![]({{site.utl_baseurl}}/img/lens.gif)[ASCII  Fixed Text Files]({{site.utl_baseurl}}/db-utils/data-import/wizard/src-file-selection/text-file-excel-spreadsheet/ascii_fixed_text_files.html)


![]({{site.utl_baseurl}}/img/lens.gif)[ASCII  Delimited File Import]({{site.utl_baseurl}}/db-utils/data-import/wizard/src-file-selection/text-file-excel-spreadsheet/ascii_delimited_text_files.html)


**ASCII Delimited File Import**
: Specify the name and path of the file containing  zone import information.


Options


**Carrier**
: Select the name of your carrier from the drop-down  list. This is the carrier that provided the information for your freight  zone import file.


**Starting Origin Zip Code**
: Enter the starting zip/postal code of your origin  zip code range found in your freight zone import file.


**Ending Origin Zip Code**
: Enter the ending zip/postal code of your origin  zip code range found in your freight zone import file.

- Click **Next**.  You will see the **Field Mapping**  screen.
- Map the fields  in your source file to the destination. See the [Field  Mapping]({{site.utl_baseurl}}/db-utils/data-import/wizard/field-mapping/field_mapping_data_import_wizard_utility_content.html) section for more information.
- (Optional) Click  **Verify File** to check your file  before importing it and correct any errors found. This is a best practice  step, but you can skip it to save time.
- Click **Save 
 Settings** to save your mapped settings along with the file settings.
- Click **Next**  to view the details of the file to be imported.
- Click **Start**  to import the freight zone data into the **Everest**  database.
- Click **Close**  to close the **Data Import Wizard**.



{:.see_also}
See also
: [Freight  Zone Import File Format]({{site.utl_baseurl}}/db-utils/data-import/wizard/importing-freight-info/freight_zone_import_file_format_data_import_wizard_ut.html)
: [Importing  Freight Rates]({{site.utl_baseurl}}/db-utils/data-import/wizard/importing-freight-info/importing_freight_rates_data_import_wizard_ut.html)
