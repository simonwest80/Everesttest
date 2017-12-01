---
title: Defragment Indexes
---

# Defragment Indexes


The **Defragment Indexes** utility  works on files whose data is scattered in different locations on the hard  drive.


Table fragmentation occurs when data modifications are made to the table.  This utility uses table indices, which is a list of values in a table,  with the storage locations of rows in the table that contain each value.  Indices speed up the selection, updation and deletion process of data.  They can be created on either a single column or a combination of columns  in a table, and are implemented in the form of B-trees. An index contains  an entry with one or more columns (the search key) from each row in a  table. Index entries are stored as rows on index pages, in a format similar  to the one used for data rows on data pages.


The database server automatically tries to read existing suitable indices  to improve performance. Indices can have multiple levels:

- [Leaf  level]({{site.utl_baseurl}}/misc/leaf_level_defrag_indexes.html)
- [Intermediate  level]({{site.utl_baseurl}}/misc/intermediate_level_defrag_indexes.html)
- [Root  level]({{site.utl_baseurl}}/misc/root_level_defrag_indexes.html)



The **Defragment Indexes** utility  defragments  the leaf level of an index so that the physical order of the pages matches  the left-to-right logical order of the leaf nodes, thus improving index-scanning  performance.


{:.steps}
To defragment database indices, do the following:

- From the main  menu, select **Utility &gt; Database Maintenance 
 &gt; Defragment Indexes**. You will see the [**Defragmenting 
 Indexes**]({{site.utl_baseurl}}/db-utils/database-maintenance/defrag-indexes/defragmenting_indexes_dialog_box.html) dialog box.

