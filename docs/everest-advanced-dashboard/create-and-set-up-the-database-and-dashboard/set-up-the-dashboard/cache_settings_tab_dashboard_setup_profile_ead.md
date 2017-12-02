---
title: Dashboard Setup Profile - Cache Settings Tab
---

# Dashboard Setup Profile - Cache Settings Tab


Use the **Dashboard Setup** profile **– Cache Settings** tab (Path: **Utility**  > **Dashboard**) to configure cache  settings for your web parts to improve your dashboard performance.  Web  part contents are cached to minimize disk reads and queries against the  cubes in the data warehouse. For more information before adjusting these  settings, see the **Cache 
 Management** section.


![]({{site.db_baseurl}}/img/lens.gif) [Cache  Management]({{site.db_baseurl}}/create-and-set-up-the-database-and-dashboard/set-up-the-dashboard/cache_management_set_up_the_dashboard_ead.html)


{:.note}
: You should also optimize your cubes periodically  to improve query performance. Refer to the **Cube 
 Usage-Based Optimization** section.


**Cache Result Sets**
: To maximize performance, select **Cache 
 Results Sets** to turn caching on. If you run your ETL every 5 minutes  or less, deselect **Cache Result Sets**  to turn caching off. We recommend that you use caching where possible  due to the dramatic performance benefits. You can retrieve result sets  much faster from the cache than from the data source.


**Check cube for updates every \_\_\_\_ minutes**
: Enter the number of minutes to wait to check if  the cube has been refreshed. If the cube has been updated, the cache expires.  When a request is made to refresh the dashboard web page and the cube  has been updated, the web part queries the cube for a new result set since  the cache is expired. Set this option to a low number, especially if you  run your ETL frequently.


**Rebuild result set cache every \_\_\_\_\_ minutes**
: Enter the number of minutes to wait until the cached  result set expires. Lowering this setting decreases the age of the data  in your web parts but it also increases the queries to the cube which  can lower performance. If your business does not require frequent updates  to your dashboard web parts, it is better to increase the time between  rebuilding the results set cache.  The  default setting to rebuild the result set cache is every 120 minutes.


**Cache result set per User**
: Select this option to cache results sets for each  user. This prevents the result sets of one user being viewed by another  user. This setting is optional but you MUST select this option if you  have defined multiple roles in the cube.


{:.see_also}
See also
: [Set Up the  Dashboard]({{site.db_baseurl}}/create-and-set-up-the-database-and-dashboard/set-up-the-dashboard/set_up_the_dashboard_ead.html)
