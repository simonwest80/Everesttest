---
title: Create the Data Warehouse
---

# Create the Data Warehouse


{:.steps}
To create the data warehouse, do the following:

- From the main menu  bar, select **Utility &gt; Data Warehouse 
 &gt; Setup**.  The  **Setup Data Warehouse** dialog box  is displayed.
- In the **Database 
 Server Name** field, enter or browse to the name of your database  server. This is the target server.
- If you are connecting  using SQL Authentication, enter your SQL database System Administrator  user name and password.  In  the **Connect Using** section, select  **SQL Authentication**.
- If you are connecting  using Windows Authentication, in the **Connect 
 Using** section, select **Windows 
 Authentication**. Most users will connect using Windows Authentication.  The **Create** button is enabled if  the data warehouse does not currently exist.
- Click the **Create** button. The system verifies that  the target server has the necessary components to support the data warehouse.   After validation,  the system creates the database on the target server, runs the ETL for  the first time to populate the database from **Everest**,  and builds and processes the cubes.
- When completed,  the **Setup Data Warehouse** dialog  box is displayed which shows the status and history of the initial run.
- Close the **Setup Data Warehouse** dialog box.
- From the main menu  bar, select **Utility &gt; Data Warehouse 
 &gt; ETL History** to view the results.



{:.see_also}
See also
: [ETL History  Browser]({{site.db_baseurl}}/create-and-set-up-the-database-and-dashboard/etl_history_browser_ead.html)
: [Set Up the  Database]({{site.db_baseurl}}/create-and-set-up-the-database-and-dashboard/set_up_the_database_ead.html)
: [ETL Job Scheduling]({{site.db_baseurl}}/create-and-set-up-the-database-and-dashboard/etl_scheduling_ead.html)
