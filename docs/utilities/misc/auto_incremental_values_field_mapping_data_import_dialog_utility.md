---
title: Auto Incremental Values
---

# Auto Incremental Values


When you import data that has sequential numbering you use the **Auto Incremental values** section to automatically  create the sequence numbers.


![]({{site.utl_baseurl}}/img/example.gif) When  you import serialized items, you can use Auto incremental values. You  can define the first serial number and auto increment it by 1 to generate  the subsequent serial numbers. You can also give a prefix and a suffix  of your choice to the serial numbers.


**Start Value**
: Define the start value to generate sequential numbers  for your data.


{:.note}
The start value has to be numeric.
: ![]({{site.utl_baseurl}}/img/example.gif) You want to generate serial numbers for 1000 serialized items,  you can give the start value as 1 (or a number of your choice) and define  the auto increment as 1. When the data is imported, the serial numbers  for all the imported items are generated automatically and assigned the  numbers 1 to 1000.


**Increment Value**
: Specify the incremental value.


![]({{site.utl_baseurl}}/img/example.gif) If 1000 items are to be serially  numbered and the first serial number is A0001, give 1 as the increment  value to generate serial numbers as A0002, A0003 and so on.


{:.note}
If the **Prefix**  and **Suffix** fields are numeric  characters, only the start value is incremented.


**Prefix**
: Define a prefix for sequence numbers to be generated  using alphanumeric characters.


**Suffix**
: Define a suffix for sequence numbers to be generated  using alphanumeric characters.


{:.see_also}
See also
: [Field  Mapping]({{site.utl_baseurl}}/db-utils/data-import/wizard/field-mapping/field_mapping_data_import_wizard_utility_content.html)
