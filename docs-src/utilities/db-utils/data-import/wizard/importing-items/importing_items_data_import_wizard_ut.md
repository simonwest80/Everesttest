---
title: Importing Items
---

# Importing Items


Use the **Data Import Wizard** (path:  **Utility** > **Import**  > **Data**) to import item information  into **Everest**.


![]({{site.utl_baseurl}}/img/lens.gif)[Data  Import]({{site.utl_baseurl}}/db-utils/data-import/data_import_wizard_utility_content.html)


Review the item related templates in the following directory:


..\Icode\Everest\Client\Utilities\ImportTemplates


A list of Item related templates is shown below:

- **Items**  – Use this template to import information related to individual items.  You can also use this template to import or update default vendor related  information. If information on the default vendor already exists in Everest,  the default vendor information is updated.
- **Item 
 Measure Details** – Use this template to import measure details for  the items. For imported items, the "Cost Decimal Accuracy" is based on  "Last Cost" decimal accuracy.
- **Item 
 Replenishment Location Information** – Use this template to import  replenishment details for items. The default location of the company is  used for any details imported. If you have multiple locations in your  company, you can use this template to import location related information
- **Item 
 Replenishment Vendor Information** – Use this template to import  vendor related information if there are multiple vendors for an item.



{:.note}
- These templates  and the information contained in them can change. Be sure to check the  ImportTemplates directory for the latest templates and information.
- For item imports,  only the company defaults are used for Inventory Adjustment and Inventory  accounts.


**Import Matrix Items**


**Everest** allows you to import  a large number of items as matrix items and create a matrix group with  the **Everest 
 Matrix Item Import Wizard**. This feature is especially useful  to import a large number of  items  at a time by importing an Excel (.xls/.csv) file that lists all the matrix  items.


Import  items  as matrix items when:

- You are implementing  **Everest** and have a large number  of items that must be configured as Matrix Groups in **Everest**.



{:.example}
You are an apparel company selling over 1000  styles of clothing. Each style must be configured as a matrix group and  includes over 5 different variations such as Size and Color.


**Import Related Items**


**Everest** allows you  to import related items by importing an excel (.xls/.csv) file with all  the related items using the **Everest Related 
 Items Import Wizard** (path: **Utility**  > **Import** > **Related 
 Items**).


![]({{site.utl_baseurl}}/img/lens.gif)[Related  Items Import]({{site.utl_baseurl}}/db-utils/related-items-import/related_items_import_ut.html)


**Import Add-on Items**


**Everest** allows you  to import add-on items by importing an excel (.xls/.csv) file with all  the add-on items using the **Everest Add-on 
 Items Import Wizard** (path: **Utility**  > **Import** > **Add-on 
 Items**).


![]({{site.utl_baseurl}}/img/lens.gif)[Add-on  Items Import]({{site.utl_baseurl}}/db-utils/add-on-items-import/add-on_items_import_ut.html)


**Import Custom Tracking**


**Everest** allows you  to import custom tracking details by importing an ecel (.xls/.csv) file  with all the custom tracking details using the **Everest 
 Custom Tracking Import Wizard** (path: **Utility**  > **Import** > **Custom 
 Tracking**).


![]({{site.utl_baseurl}}/img/lens.gif)[Custom  Tracking Import]({{site.utl_baseurl}}/db-utils/custom-tracking-import/custom_tracking_import_ut.html)


{:.see_also}
See also
: [Data  Import]({{site.utl_baseurl}}/db-utils/data-import/data_import_wizard_utility_content.html)
: [Items]({{site.utl_baseurl}}/db-utils/data-import/wizard/accounting-entries/items/items_accounting_entries_utility_content.html)
: [Matrix Items  Import]({{site.utl_baseurl}}/db-utils/matrix-items-import/matrix_items_import_ut.html)
: [Accounting  Entries]({{site.utl_baseurl}}/db-utils/data-import/wizard/accounting-entries/items/accounting_entries_items_accounting_entries_utility_content.html)
: [Back  End Processes]({{site.utl_baseurl}}/db-utils/data-import/wizard/accounting-entries/items/backend_processes_for_items_accounting_entries_utility_content.html)
