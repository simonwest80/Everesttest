---
title: "Example: Associate Actions with the Query"
---

# Example: Associate Actions with the Query


Follow the procedure below to select an action to occur when  a field is clicked in the **Advanced****Query** browser. This allows you  to drill down into your advanced query filter results. In this example,  the customer profile will open when the **Name**  field is clicked in the **Advanced Query**  browser filter results.


{:.steps}
To associate actions with the query, do the  following:

- Open the **Advanced Query Builder** (path: **Utility** > **Advanced 
 Query Builder**).
- In the **Filter 
 Name** field, select the "Active Customers" filter that you created  in the "Create a Query to retrieve all Active Customer Addresses" example.



![]({{site.utl_baseurl}}/img/lens.gif)[Example:  Create a Query to retrieve all Active Customer Addresses]({{site.utl_baseurl}}/other-utilities/the-advanced-query-builder/example_create_query_to_retrieve_all_active_customer_addresses_ut.html)


![]({{site.utl_baseurl}}/img/aqb_field_settings_tab_ut.gif)


**Figure: Advanced Query Builder Field Settings  Tab Showing Actions**

- In the **Action**  column for the **ADDRESS.NAME** field,  select **Open Customer profile** from  the drop-down list. This sets the Customer profile to open if the Name  field is double-clicked in the query results browser.
- In the **Action 
 Parameter 1** column for the **ADDRESS.NAME**  field, select **CUST_CODE**. If you  select a name in the query results browser, the Customer profile of the  customer code for the name selected will open. This action parameter is  necessary because there can be identical names with different customer  codes.
- Click **Save**  to save the "Active Customers" filter.
- Click **Find**  to view the filter output in the **Advanced 
 Query** browser.



![]({{site.utl_baseurl}}/img/aqb_advanced_query_browser_showing_action_only_with_caption_ut.gif)


**Figure: Advanced Query Browser Showing Selected  Action**


In the above figure, the "Open Customer Profile Action" was  selected for the ADDRESS.NAME field on the **Field 
 Settings** tab. In the **Action Parameter 
 1** field, "CUST\_CODE" was selected. In this situation, if you click  the **Name** field, the system opens  the Customer profile for the customer code of the selected row.


![]({{site.utl_baseurl}}/img/lens.gif)[Advanced  Query Builder Supported Actions]({{site.utl_baseurl}}/other-utilities/the-advanced-query-builder/advanced_query_builder_supported_actions_ut.html)


{:.see_also}
See also
: [Example:  Create a Query to retrieve all Active Customer Addresses]({{site.utl_baseurl}}/other-utilities/the-advanced-query-builder/example_create_query_to_retrieve_all_active_customer_addresses_ut.html)
: [Example:  Create an Interactive Filter with Drill-down Documents and Profiles]({{site.utl_baseurl}}/other-utilities/the-advanced-query-builder/example_create_an_interactive_filter_ut.html)
