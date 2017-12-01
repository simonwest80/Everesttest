---
title: Importing Historical Documents
---

# Importing Historical Documents


Historical documents are those documents that were created before you  migrated to **Everest**.


In order to import historical documents, you need to first map the header  details and then the line item details of historical sales or purchase  documents. For this reason, two files are required for importing documents.


![]({{site.utl_baseurl}}/img/example.gif) For  importing Historical Customer documents, the first file must contain header  details, which are mapped with the INVOICES table in **Everest**  database. Then the second file that contains the line item details is  mapped with the X\_INVOIC  table. After the fields in the source tables are mapped with the fields  in the destination tables, the import process can be started.


After the header details are mapped with the destination table (INVOICES  table or PO table), **Everest** displays  the **Source File Selection** section  for line item details.


Source File Select for Line Item Details


**Import File Type**
: Data can be imported into **Everest**  from [Text  File/Excel Spreadsheet]({{site.utl_baseurl}}/db-utils/data-import/wizard/src-file-selection/text-file-excel-spreadsheet/ascii_fixed_text_files.html)  file  types.


Options


**Default item to use when item code match is not  found**
: Specify a non-inventoried item, which will be used  when an item code available in the source file is not defined in **Everest**. The drop-down list displays  only items of "Non-Inventoried" type available in the **Everest** database.


**Line item custom field to use for storing invalid  item codes**
: Specify the document line item custom field, which  will be used to store the data, in case an invalid item code such as "ABC\_#"  is found in the source file. The drop-down list displays the "Line  item custom fields" of sales or purchase documents.


{:.note}
Historical documents of the types Sales Invoice, Credit Memo, Purchase  Invoice and Debit Memo can be imported and viewed in the respective browsers  in **Everest**.


All imported historical documents are prefixed with "H".


{:.see_also}
See also
: [Data  Import]({{site.utl_baseurl}}/db-utils/data-import/data_import_wizard_utility_content.html)
