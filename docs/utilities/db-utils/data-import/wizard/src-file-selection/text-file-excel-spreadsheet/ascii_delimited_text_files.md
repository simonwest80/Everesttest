---
title: ASCII Delimited File Import
---

# ASCII Delimited File Import


The **ASCII Delimited File Import**  section allows you to select the delimiter for the fields. They may be  separated by commas, tabs, semicolons, spaces or other delimiters.


**Field Separator**
: When you import data into **Everest**  using Text files, you can specify a delimiter, which is a character used  to signal the end of each field in the source file. The delimiter separates  the fields in the source file and arranges the data in columnar format  into the imported file.
: The field delimiters are listed below:


| : **Tab** | : Identifies a single tab between each field in the  import data file. |
| : **Comma** | : Identifies a single comma between each field in  the export data file. |
| : **Space** | : Identifies a single space between each field in  the import data file. |
| : **Semicolon** | : Identifies a single semicolon between each field  in the export data file. |
| : **Others** | : Use the option to specify a new field delimiter. |



**Text Qualifier**
: Specify the field qualifier, to distinguish the  data from the field, where the file contains the delimiter as a part of  the data.


{:.example}
In comma-separated files, a comma may have been inserted within the  existing text of the source data file. The **Text 
 Qualifier** Double Quotes (" ") is used to identify an  already existing comma in the source data file.


The address data in the source file can be formatted as given below:


House No., Street, City, State


In such an instance, double quotes are used to identify the fields that  are already using comma in the source file.


**First row of import file contains header information**
: Check this box if the file you are importing contains  header information in the first line.


Formatted File View Tab


Displays the formatted view of the file based on the values set by the  user in the Field Separator.


Text File View Tab


Displays the text view of the file to be imported.

- Click **OK**.  You will see the **Field 
 Mapping** section.

