---
title: Query Details Section - Field Settings Tab
---

# Query Details Section - Field Settings Tab


The **Field Settings** tab displays  the field names and their captions that have been selected in the tables.


![]({{site.utl_baseurl}}/img/aqb_field_settings_tab_ut.gif)


**Figure: Advanced Query Builder – Field Settings  Tab**


If you check the boxes in the **Searchable**  column, the respective fields will appear as sort tabs in the output browser.  This activates the fields and allows you to perform a local search on  these fields which is typically faster than a search on the server.


{:.note}
For the **Sort**  tabs to display, enable them in the browser properties. Right-click the  title bar and select **Browser Properties**.  On the Browser Property Editor **General**  tab, in the **Show Index Tabs** section,  select **Bottom**. Click **Apply**  and then click **OK**.


You can  select  a predefined action or activity for a field in the **Action**  column that will occur when you select that field in the output browser.  For additional drill-down capabilities, you can also select your predefined  Advanced Query Builder filters as actions.


{:.example}
If you select "Open Customer Profile" for  the ADDRESS.NAME field, you must also select an Action Parameter 1, such  as "CUST\_CODE". This is necessary since there could be multiple customer  codes with the same name.


The **Action Parameter 1** and **Action Parameter 2** columns activate  based upon your Action selection. If parameters are required to uniquely  identify what should happen, you must select the relevant action parameters.


{:.example}
If you select to open a Document Profile,  you must also identify the document type and document number. Refer to  the Advanced Query Builder Supported Actions section for more information.
: ![]({{site.utl_baseurl}}/img/lens.gif)[Advanced  Query Builder Supported Actions]({{site.utl_baseurl}}/other-utilities/the-advanced-query-builder/advanced_query_builder_supported_actions_ut.html)


{:.see_also}
See also
: [Query  Details Section]({{site.utl_baseurl}}/misc/query_builder_query_details_section.html)
