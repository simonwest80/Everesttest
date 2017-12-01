---
title: Query Details Section - Parameter Information Tab
---

# Query Details Section - Parameter Information Tab


The **Parameter Information**  tab is used to further refine an interactive query.


![]({{site.utl_baseurl}}/img/aqb_parameter_information_tab_ut.gif)


**Figure: Advanced Query Builder – Parameter Information  Tab**


The **Name** column shows  the parameters in your filter. In order for the parameters to appear on  this tab, you must enter a colon (:) followed by the parameter name as  a part of a condition on the Filters tab or as part of your SQL Statement  on the SQL Statement tab.


{:.example}
Using the INVOICES table, **:Amount**  is a parameter for INV\_AMOUNT and **:TERMS**  is a parameter for TERMS.


The **Caption** field  displays on the intermediate window that prompts for values when you run  an interactive query.


The **Data Type** field  indicates whether the parameter value data is Date, Numeric, or String.


In the **Type** field,  you must select "Static".


To make your query interactive, leave the **Default 
 Value** field blank. An intermediate window will display when running  the query which allows you to add any value for the specified parameters.


![]({{site.utl_baseurl}}/img/aqb_interactive_filter_prompt.gif)


**Figure: Advanced Query Builder – Interactive  Filter prompt**


To view the query results, you must enter the parameter values  and then click **OK**.


![]({{site.utl_baseurl}}/img/lens.gif) [Example:  Create an Interactive Filter with Drill-down Documents and Profiles]({{site.utl_baseurl}}/other-utilities/the-advanced-query-builder/example_create_an_interactive_filter_ut.html)


{:.see_also}
See also
: [Query  Details Section]({{site.utl_baseurl}}/misc/query_builder_query_details_section.html)
