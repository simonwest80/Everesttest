---
title: Importing Freight Rates
---

# Importing Freight Rates


Use the **Data Import Wizard** (path:  **Utility** > **Import**  > **Data**) to import freight rate  information defined by the carrier for calculating freight charges in  **Everest**. Freight rates are calculated  based on the combination of different destination zones and delivery methods.  Freight zones must be imported before freight rates can be imported.


![]({{site.utl_baseurl}}/img/lens.gif) [Data  Import Wizard]({{site.utl_baseurl}}/db-utils/data-import/wizard/import_data_wizard_data_import_wizard_utility_content.html)


{:.steps}
To import freight rate information into Everest,  do the following:

- Create the freight  rate import file for **Everest**.  Download rate and zone files from your freight carrier's website. If you  do not see them published there, contact your Account Manager for the  carrier (i.e. UPS or FedEx) to request the files in .CSV or Excel format.  See the **Freight 
 Rate Import File Format** section for this information.
- Review the Freight  Rate import template in the following directory:
..\Icode\Everest\Client\Utilities\ImportTemplates
- From the main menu  bar, select **Utility** > **Import** > **Data**.  You will see the **Data Import Wizard**.
- Select **Next**.  You will see the **Select Data to Import**  screen.
- In the **Import 
 Data Description** column, select **Freight 
 Rates**.
- Click **Next**.  The **Source File Selection** screen  is displayed.



**Import File Type**
: Select the type of file to be imported, such as  Excel or Text.


![]({{site.utl_baseurl}}/img/lens.gif) [ASCII  Fixed Text Files]({{site.utl_baseurl}}/db-utils/data-import/wizard/src-file-selection/text-file-excel-spreadsheet/ascii_fixed_text_files.html)


![]({{site.utl_baseurl}}/img/lens.gif) [ASCII  Delimited File Import]({{site.utl_baseurl}}/db-utils/data-import/wizard/src-file-selection/text-file-excel-spreadsheet/ascii_delimited_text_files.html)
: Specify the name and path of the file containing  zone import information.


Options


**Delivery Method**
: Specify the delivery method for which the freight  rates are to be imported. The drop-down list contains the delivery methods  you have set up in **Everest** (path:  **File** > **Setup**  > **Freight** > **Delivery 
 Methods**).

- Click **Next**.  You will see the **Field Mapping**  screen.
- Map the fields  in your source file to the destination. See the **Field Mapping**  section for more information.
- (Optional) Click  **Verify File** to check your file  before importing it and correct any errors found. This is a best practice  step, but you can skip it to save time.
- Click **Save 
 Settings** to save your mapped settings along with the file settings.
- Click **Next**  to view the details of the file to be imported.
- Click **Start**  to import the freight rate data into the **Everest**  database.
- Click **Close**  to close the **Data Import Wizard**.



{:.see_also}
See also
: [Freight  Rates Import File Format]({{site.utl_baseurl}}/db-utils/data-import/wizard/importing-freight-info/freight_rates_import_file_format_diw_ut.html)
