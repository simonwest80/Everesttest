---
title: ETL Job Scheduling
---

# ETL Job Scheduling


Use **ETL Job Scheduling** to configure  how often the **Extract, Transform, and 
 Load (ETL)** function will run and update your data warehouse.


{:.steps}
To configure the ETL scheduling, do the following:

- From the main menu  bar, select **Utility &gt; Data Warehouse 
 &gt; ETL Schedule**.  The  **ETL Job Scheduling** dialog box  is displayed.
- To set up a schedule  for the ETL activity, specify the schedule. The ETL job must run once  per day. Click **Save Schedule** to  execute the processing according to your specified schedule.



{:.note}
The ETL will run once every day at 4 a.m.  local server time by default. The default schedule will display in the  ETL Job Scheduling dialog box until a new schedule is configured.

- To  process the ETL immediately, click **Execute 
 Now**. The **Execute Now** dialog  box is displayed.



{:.note}
If the ETL process is currently running, the  **Execute Now** button is disabled.


Extract From


**Last Successful Run**
: Use the **Last Successful 
 Run** option to extract records back to the last successfully loaded  record in **Everest**. If necessary,  use this option to rerun the ETL subsequent to a failure. This option  can be selected at any time to capture production changes since the last  successful run. The time of the last successful run displays to the right  of this option.


**Choose Date**
: Use the **Choose 
 Date** option to choose an arbitrary date and **Everest**  will extract records back to the chosen date. If you choose a date that  is before the date of the last successfully loaded record, the previously  collected data in the data mart will be overwritten. This option may take  longer than a normal ETL run.


**Start Over**
: Use the **Start Over**  option to delete and rebuild the data mart. This completely refreshes  the data mart and retrieves data from the oldest **Everest**  data available. The data mart cubes will also be reprocessed.


{:.warn}
The **Start 
 Over** option overwrites all records in the data mart and may take  a very long time to execute.


Cubes


Use the **Cubes** section to indicate  if the cubes should be updated or rebuilt.


**Update Cubes**
: Use the **Update 
 Cubes** option to update all cubes with the ETL run.


**Delete and Recreate All Cubes**
: Use the **Delete 
 and Recreate All Cubes** option to delete and recreate the cubes  as a part of your ETL run. Select this option if changes were made to  your data source. We recommend that you back up your cubes with different  names before choosing this option.

- If you chose **Execute Now**, select a method of processing  the ETL activity and indicate what should be done to the cubes during  the ETL run.


- Click **OK**.  You do not have to wait for the ETL task to complete before moving to  other tasks.



{:.see_also}
See also
: [ETL History  Browser]({{site.db_baseurl}}/create-and-set-up-the-database-and-dashboard/etl_history_browser_ead.html)
