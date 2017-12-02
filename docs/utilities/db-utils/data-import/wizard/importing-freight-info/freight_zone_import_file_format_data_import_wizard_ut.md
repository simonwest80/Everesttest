---
title: Freight Zone Import File Format
---

# Freight Zone Import File Format


Before a freight zone file can be imported into **Everest**,  it must be adjusted to an acceptable format. Freight Zone import files  must include one or two zip code columns and a zone column. An optional  column may also be included for country.


**One Zip Code Column**
: If only one zip code column is included, then it  must show a zip code range delimited by a dash (-).  This  column can then be mapped to both the starting and ending zip code columns.  Everest automatically separates the zip codes by the dash and stores them  in the starting and ending zip code.


**Two Zip Code Columns**
: If two zip code columns are included then one should  be a starting zip code column and one an ending zip code column. Zip codes  can be provided with the exact number of digits to store (5 for US) or  with 3 digits.  If  a 3 digit code is given and the country is the US, the starting zips will  all be appended with "00" and the ending zips will all be appended with  "99".


**Zone Column**
: Freight zone import files must also contain a zone  column that provides the zone code of the zone corresponding to the zip  code range.


**Country Column (Optional)**
: The freight zone import file may include a column  for country. If no column is given the default will be set to the United  States.


**Other File Information**
: The import file may include column header information  at the top but no additional information can be included at the top or  bottom of the file.  There  may be extra columns in the file that will not be mapped. Samples of acceptable  file formats are shown below.
: ![]({{site.utl_baseurl}}/img/acceptable_freight_zone_import_file_sample_two_zip_columns_ut.gif)


**Acceptable Freight Zone Import File Sample with  Two Zip Code Columns**
: ![]({{site.utl_baseurl}}/img/acceptable_freight_zone_import_file_sample_one_zip_column_ut.gif)


**Acceptable Freight Zone Import File Sample with  One Zip Code Column**


{:.see_also}
See also
: [Import  Freight Zones]({{site.utl_baseurl}}/db-utils/data-import/wizard/importing-freight-info/import_freight_zones_data_import_wizard_ut.html)
