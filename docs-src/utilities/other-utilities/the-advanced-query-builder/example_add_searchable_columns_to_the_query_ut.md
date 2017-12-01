---
title: "Example: Add Searchable Columns to the Query"
---

# Example: Add Searchable Columns to the Query


Follow the procedure below to enable local searching on fields  in your query. You may want to do this since local searches are typically  faster than searches on the server.  The  selected fields will appear as sort tabs in the output browser.


{:.note}
For the **Sort**  tabs to display, enable them in the browser properties. Right-click the  title bar and select **Browser Properties**.  On the Browser Property Editor **General**  tab, in the **Show** **Index 
 Tabs** section, select **Bottom**.  Click **Apply** and then click **OK**.


{:.steps}
To add searchable columns to the query, do  the following:

- Open the **Advanced Query Builder** (path: **Utility** > **Advanced 
 Query Builder**).
- In the **Filter 
 Name** field, select the "Active Customers" filter that you created  in the "Create a Query to retrieve all Active Customer Addresses" example.



![]({{site.utl_baseurl}}/img/lens.gif)[Example:  Create a Query to retrieve all Active Customer Addresses]({{site.utl_baseurl}}/other-utilities/the-advanced-query-builder/example_create_query_to_retrieve_all_active_customer_addresses_ut.html)

- On the **Field 
 Settings** tab, click the check box in the **Searchable**  column for the following fields to enable search tabs on these fields:
- CUST.CREAT\_DATE
- ADDRESS.CUST.CODE
- ADDRESS.NAME
- ADDRESS.ZIP



![]({{site.utl_baseurl}}/img/aqb_field_settings_tab_add_searchable_items_ut.gif)


**Figure: Advanced Query Builder – Field Settings  Tab with Searchable Columns Selected**

- Click **Save**  to save the "Active Customers" filter.
- Click **Find**  to view the filter output in the **Advanced 
 Query** browser.



![]({{site.utl_baseurl}}/img/aqb_advanced_query_browser_showing_action_tabs_only_with_captions_ut.gif)


**Figure: Advanced Query Browser Showing Sort Tabs**


In the above figure, the Create Date, Name, Zip, and Customer  Code sort tabs display because the respective fields were selected as  Searchable columns on the **Field Settings**  tab. In this example, if you select the **Zip**  tab, you can perform a local search on zip code. Use the sort tabs to  perform local searches which are typically faster than a search on the  server.


{:.note}
For the **Sort**  tabs to display, enable them in the browser properties. Right-click the  title bar and select **Browser Properties**.  On the Browser Property Editor **General**  tab, in the **Show** **Index 
 Tabs** section, select **Bottom**.  Click **Apply** and then click **OK**.


{:.see_also}
See also
: [Example:  Associate Actions with the Query]({{site.utl_baseurl}}/other-utilities/the-advanced-query-builder/example_associate_actions_with_the_query_ut.html)
: [Example:  Create a Query to retrieve all Active Customer Addresses]({{site.utl_baseurl}}/other-utilities/the-advanced-query-builder/example_create_query_to_retrieve_all_active_customer_addresses_ut.html)
