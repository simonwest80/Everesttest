---
title: Freight Rates Import File Format
---

# Freight Rates Import File Format


Before a freight rates file can be imported into **Everest**,  it must be adjusted to an acceptable format. Freight zones must be imported  before freight rates can be imported.


Freight Rates import files must be imported based on document weight.  The freight rate import file must contain weight and zone columns. Type  and zone columns can optionally be included.


**Weight Column**
: The freight rates import file must include a weight  column for the document weights specified by the carrier.


**Type Column (Optional)**
: The **Type**  column is an optional column for freight rate type. You can include a  **Type** column corresponding to a  flat rate, a per unit rate, or a per hundred unit weight. Valid values  are integers 1-3:
: **1** - Rate  Per Unit
: **2** - Flat  Rate
: **3** - Per  Hundred Weight
: If this column is not included, the default **Type** will be **2**  - Flat Rate.


**Measure Column (Optional)**
: You can also include a **Measure**  column for the weight. If this column is not included, the default **Measure** will be pounds (LB).


**Zone(s) Column(s)**
: The freight rates import file must include a column  for each zone that you want to populate with rates. Not all zones for  the carrier have to be included.


**Other File Information**
: Files may include column header information at the  top but no additional information can be included at the top or bottom  of the file. A sample of an acceptable file format is shown below.
: ![]({{site.utl_baseurl}}/img/acceptable_freight_rates_import_file_sample_ut.gif)


**Acceptable Freight Rates Import File Sample**


{:.see_also}
See also
: [Importing  Freight Rates]({{site.utl_baseurl}}/db-utils/data-import/wizard/importing-freight-info/importing_freight_rates_data_import_wizard_ut.html)
