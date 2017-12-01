---
title: Leaf Level
---

# Leaf Level


The lowest level of the index is the leaf level. At the leaf level, the index contains a key value for each row in the table, and the rows are stored in sorted order by the index key. The index is sorted based on the column chosen as the index key. This does not change the data's physical sort order. The data is stored in data pages. Each page is 2,048 bytes in size, with a header of 32 bytes. Hence, each page has 2,016 bytes available for storage.


{:.see_also}
See also
: [Defragment Indexes]({{site.utl_baseurl}}/db-utils/database-maintenance/defrag-indexes/defrag_indexes.html)
