---
title: Query Details Section - Filters Tab
---

# Query Details Section - Filters Tab


The **Filters** tab allows you to  set conditions based on which the query is executed. You can specify conditions  to filter the data and retrieve records accordingly to suit your needs.


![]({{site.utl_baseurl}}/img/aqb_query_details_section_ut.gif)


**Figure: Advanced Query Builder - Filters Tab**


Specifying conditions to filter data


To specify conditions to filter data, click the ![]({{site.utl_baseurl}}/img/aqb_lookup_button_ut.gif) lookup  button. You will see a menu with the following options:


Add condition


Select this option to add a new condition. Specify the conditional parameters  and values, which are nothing but table names in **Everest**  database, in the condition box that appears ![]({{site.utl_baseurl}}/img/aqb_condition_box_ut.gif). Press **Shift + Enter** to insert field names  in the boxes or right-click here and select the **Insert 
 Field** option. Similarly, to specify the criteria, click the operator  (=) and select from the menu that appears.


![]({{site.utl_baseurl}}/img/example.gif) You can specify a condition that credit limit should  be less than 5000.


Make compose condition


Select this option to add a compose condition inside the existing condition.  Specify the conditional parameters and values, which are nothing but table  names in **Everest** database, in  the condition box that appears ![]({{site.utl_baseurl}}/img/aqb_condition_box_ut.gif). Press **Shift 
 + Enter** to insert field names in the boxes or right-click here  and select the **Insert Field** option.  Similarly, to specify the criteria, click the operator (=) and select  from the menu that appears.


{:.note}
Enter the date only in MM/DD/YYYY format.  However, the system will display the resulting data with the date format  configured in the regional settings of your workstation.


Delete condition


Use this option to delete the highlighted condition. When you select  this option, **Everest** prompts you  for confirmation.


Expand/Collapse condition


Use these options to expand or collapse the composite conditions.


Click **All**, beside the ![]({{site.utl_baseurl}}/img/aqb_lookup_button_ut.gif) icon. You will see the following filter options:

- **All**  - checks if all the conditions are met.
- **Any**  - checks if any of the conditions are met.
- **None**  - checks if none of the conditions are met.
- **Not 
 all** - checks if not all of the conditions are met.



Indicate Parameters


To indicate a parameter to be selected, place a colon (:)  in front of the parameter, such as **:AMOUNT**.  Use the Parameter Information tab to further define the parameter. This  allows you to create an interactive query.


![]({{site.utl_baseurl}}/img/aqb_filters_tab_showing_parameters_ut.gif)


**Figure: Advanced Query Builder – Filters Tab  with Parameters Added**


{:.see_also}
See also
: [Query  Details Section]({{site.utl_baseurl}}/misc/query_builder_query_details_section.html)
