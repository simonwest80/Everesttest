---
title: Cache Management
---

# Cache Management


Caching involves copying information into cache memory. This information  can then be accessed from cache memory instead of directly from the data  source. Caching improves performance by minimizing disk reads and queries  against the data source.


The Dashboard uses multiple types of caches. Web part templates are  cached, web pages are cached, and cube result sets are cached. IIS and  IE settings control the web page cache. In the Dashboard Setup, you can  configure the cache settings for your web parts.


Several factors must be taken into consideration before configuring  your web part cache.  The  most important factor is how long you are willing to wait for new information  on your **Everest Advanced Dashboard**.  For example, your business may require dashboard updates only once a day  or you may need updates very frequently.


The ETL Job Scheduling function determines how often the cubes are updated  in your data warehouse. The ETL runs once every day at 4 a.m. local server  time by default until a new schedule is configured. You can run the ETL  more frequently, if necessary.


![]({{site.db_baseurl}}/img/lens.gif) [ETL Job Scheduling]({{site.db_baseurl}}/create-and-set-up-the-database-and-dashboard/etl_scheduling_ead.html)


There are three ways that a request can be made to refresh the dashboard  web page:

1. When the page loads for the first time in a session
- When the User clicks Refresh in the browser (F5)
- When a web part filter is changed (resulting in  a new query)



If any of these events occur, a request is made to the web server for  a new page.


To dramatically improve performance, cube results sets can be cached.  A **Result Set** is data returned  when the web part does a query against a cube. Results sets accessed from  cache memory can be displayed very quickly on the dashboard because it  is not necessary to query the data source, in this case a cube in the  data warehouse.


Another factor to consider when configuring your web part cache is how  often the cube should be checked for updates. If the cube is checked for  updates and the cube has been updated, the result set cache expires. If  a subsequent request is made to refresh the dashboard page by changing  the filter or clicking Refresh (F5), the web part queries the cube for  a new data set. Since the web part only queries the cube for a new data  set if the cube has been updated, checking for updates can be done frequently  without lower performance. This is why the default setting to check the  cube for updates is a low number.


An additional factor to consider when configuring your web part cache  is how often the cached result set should expire. When the result set  expires, the web part queries the cube for a new data set regardless of  whether the cube has been updated or not. When a request is made to refresh  the dashboard web page or the filter is changed resulting in a new query,  the web part queries the cube for a new data set if the cache expired  since the current cached result set was obtained.


Both of the methods for configuring cache mentioned above expire the  cache. One method expires the cache when a cube update is found and the  other method expires the cache at a predetermined time that you can configure.


{:.note}
Cubes are updated with each ETL run, so even  if the result set cache expires, the cube will only return new data if  the ETL has run since the last request.


Results sets can also be cached by user. You should cache results per  user if cube roles are being used. In this situation, the results set  for one user cannot be viewed by another user.


Cube roles are beyond the scope of this documentation.  For  more information, see the Analysis Services Books Online and [www.microsoft.com](http://www.microsoft.com).


{:.see_also}
See also
: [How  Old is the Data in My Web Parts?]({{site.db_baseurl}}/create-and-set-up-the-database-and-dashboard/set-up-the-dashboard/how_old_is_the_data_in_my_web_parts_ead.html)
: [Dashboard  Setup Profile - Cache Settings Tab]({{site.db_baseurl}}/create-and-set-up-the-database-and-dashboard/set-up-the-dashboard/cache_settings_tab_dashboard_setup_profile_ead.html)
: [Set Up the  Dashboard]({{site.db_baseurl}}/create-and-set-up-the-database-and-dashboard/set-up-the-dashboard/set_up_the_dashboard_ead.html)
