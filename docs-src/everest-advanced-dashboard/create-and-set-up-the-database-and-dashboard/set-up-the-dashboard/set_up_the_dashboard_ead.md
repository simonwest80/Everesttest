---
title: Set Up the Dashboard
---

# Set Up the Dashboard


After entering a valid license key, if the dashboard does not exist,  the **Dashboard Setup** profile (Path:  **Utility** > **Dashboard**)  is displayed for you to create the dashboard.  The  **Dashboard Setup** profile contains  the following tabs:

- [Dashboard  Setup]({{site.db_baseurl}}/create-and-set-up-the-database-and-dashboard/set-up-the-dashboard/dashboard_setup_tab_dashboard_setup_profile_ead.html)
- [Cache  Settings]({{site.db_baseurl}}/create-and-set-up-the-database-and-dashboard/set-up-the-dashboard/cache_settings_tab_dashboard_setup_profile_ead.html)



{:.steps}
To setup the Everest Advanced Dashboard,  do the following:

- If the **Dashboard 
 Setup** profile does not open for you, select **Utility**  > **Dashboard**. The **Dashboard 
 Setup** profile displays the **Dashboard 
 Setup** tab.



![]({{site.db_baseurl}}/img/lens.gif) [Dashboard  Setup Tab]({{site.db_baseurl}}/create-and-set-up-the-database-and-dashboard/set-up-the-dashboard/dashboard_setup_tab_dashboard_setup_profile_ead.html)

- In the **Dashboard 
 Server Name** field, enter the name of the Dashboard server that  will be used to deploy the dashboard.
- In the **Port**  field, enter the port number to be used for your dashboard site.
- In the **Site 
 Name** field, enter a name for your dashboard site.
- Click the **Cache Settings** tab. To maximize performance,  select **Cache Result Sets** to cache  cube result sets into memory. You can also configure your web part cache  settings. Refer to the **Cache 
 Management** and **Cache 
 Settings Tab** sections before adjusting your cache settings.  If you run your ETL every 5 minutes or less, deselect **Cache 
 Result Sets** to turn caching off. We recommend that you use caching  where possible due to the dramatic performance benefits. You can retrieve  result sets much faster from the cache than from the data source.



![]({{site.db_baseurl}}/img/lens.gif) [Cache  Management]({{site.db_baseurl}}/create-and-set-up-the-database-and-dashboard/set-up-the-dashboard/cache_management_set_up_the_dashboard_ead.html)


![]({{site.db_baseurl}}/img/lens.gif) [Cache  Settings Tab]({{site.db_baseurl}}/create-and-set-up-the-database-and-dashboard/set-up-the-dashboard/cache_settings_tab_dashboard_setup_profile_ead.html)

- Click the **Save** button. After the dashboard is  saved, the **Everest Advanced Dashboard**  can be viewed on the home page. You can also click the link in the **Dashboard URL** field on the **Dashboard 
 Setup** tab to display the dashboard.



{:.warn}
The **Everest**  URL points to the default site. Use care when managing the site content  since it can be viewed by all **Everest**  users who are set up in Windows SharePoint Services.


{:.see_also}
See also
: [Configure  the Default Dashboard for Users]({{site.db_baseurl}}/create-and-set-up-the-database-and-dashboard/configure_the_default_dashboard_for_users_ead.html)
: [Dashboard  User Interface]({{site.db_baseurl}}/dashboard-user-interface/dashboard_user_interface_ead.html)
