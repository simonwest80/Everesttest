---
title: How Old is the Data in My Web Parts?
---

# How Old is the Data in My Web Parts?


The following example illustrates the factors that determine the age  of data in your web parts.


{:.example}
A business wants to know approximately how  old the data is in their web parts.  They  use the following information:


| Factor Determining Age of Data | Frequency |
| ETL Run | Twice a day - at 4:00am and at 12:00pm |
| Cache Result Sets – Check cube for updates every \_\_\_\_\_  minutes | Every 10 minutes |
| Cache Result Sets – Rebuild result set cache every \_\_\_\_\_  minutes | Every 120 minutes |



A user logs in to **Everest** and  the dashboard is displayed within **Everest**  at 9:00am. A request is made at that time to query the cube to refresh  the dashboard web page. The information displayed is the data received  from the ETL run at 4:00am. At 10:00am the user changes the filter. Another  request is made at that time to query the cube to refresh the dashboard  web page. Again, the information displayed is the data received from the  ETL run at 4:00am.


At 12:15, the user views the information from the Sales Web Part. In  this example, the cubes are checked for updates every ten minutes and  the results sets expire every two hours. In this situation, the cache  expired since the cube is checked for updates every ten minutes. The user  sees the information from cache which contains data from the 4:00am ETL  run. If the user changes the filer resulting in a new query or presses  F5 to refresh the dashboard web page, the web part queries the cube for  a new data set since the cached data set expired.


{:.see_also}
See also
: [Cache  Management]({{site.db_baseurl}}/create-and-set-up-the-database-and-dashboard/set-up-the-dashboard/cache_management_set_up_the_dashboard_ead.html)
: [Set Up the  Dashboard]({{site.db_baseurl}}/create-and-set-up-the-database-and-dashboard/set-up-the-dashboard/set_up_the_dashboard_ead.html)
