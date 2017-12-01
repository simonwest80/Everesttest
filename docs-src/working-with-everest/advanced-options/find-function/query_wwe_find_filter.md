---
title: Query
---

# Query


This tab displays the SQL query created, when you select the search  parameters in the other tabs of the **Find**  dialog box. This query is used to retrieve information from the database.  You cannot edit or add new queries in this panel.


For the parameters chosen in any of the tabs (such as **Quick 
 Find**), an SQL query is automatically constructed and displayed  here. You cannot edit the query. However, it gets automatically updated  if you change any parameters in the other tabs of the **Find**  dialog box.


{:.example}
For the example given in the previous section, the corresponding SQL  Query is:


NOT (A.COUNTRY  LIKE '%United%')  and PURCHASE\_REP  IN ( 'JA' )  and DEP\_CODE  LIKE '%AUS%'


{:.see_also}
See also
: [Find Function  in Everest]({{site.wwe_baseurl}}/advanced-options/find-function/find_function_in_everest.html)
