---
title: How to add a Query from SQL to Advanced Query Builder
---

# How to add a Query from SQL to Advanced Query Builder


The **Advanced Query Builder**  utility in **Everest** allows you  to build your own queries for retrieving data. It helps you to directly  interact with the database using SQL commands to create your own reports.  You do not have to know SQL to use the Advanced Query Builder. However,  if you know SQL, you can quickly add your SQL queries to the Advanced  Query Builder without going through the regular steps to create a query.


{:.steps}
To add a query from SQL, do the following:

- From the main menu,  select **Utility** > **Advanced 
 Query Builder** to open the Advanced Query Builder.
- In the **Filter 
 Name** field, enter a name for your query. (Skip this step and do  not save your changes if you do not want to save your query in **Everest**.)
- Click the **SQL Statement** tab.
- Before pasting  the query, make sure the **Update Designer**  option is checked.
- After pasting the  query, click the **Update SQL** button.  This should populate the primary key fields. Also make sure your fields  aren't just "\*".  You  can use table.\*; you just can't use only \*.
- Now you can select  the primary key on the **Browser Settings**  tab, save your changes, and then click **Find**  to run your query.



![]({{site.utl_baseurl}}/img/aqb_add_sql_query_ut.gif)


**Figure: Advanced Query Builder - SQL Statement  Tab Settings**


{:.see_also}
See also
: [Steps to Create  a Query]({{site.utl_baseurl}}/other-utilities/the-advanced-query-builder/steps_to_create_a_query.html)
