---
title: ETL History Browser
---

# ETL History Browser


Use the **ETL History** browser  to view status information on the most recent or current ETL job. You  can determine when the last run occurred, if the run was successful, and  how many records were processed. If the ETL job had errors, you can locate  the details for them in the **ETL History 
 Details** browser. Historical information may also display if you  have migrated from a previous version of **Everest**.


{:.note}
If the ETL job is still running, the history  will have a start time but no stop time.


{:.steps}
To access the ETL History browser, do the  following:

- From  the main menu bar, select **Utility &gt; 
 Data Warehouse &gt; ETL History**.



The following table shows information on the **ETL 
 History** browser columns:


| Column Heading | Description |
| Start Time | The is the date and time the ETL run started. |
| Stop Time | If the run finished, this is the date and time the ETL  run finished. |
| Duration | The duration displays the stop time minus the start  time in hh/mm/ss. In the **ETL History <br/> Details** browser, you can view metrics for the currently running  ETL process. |
| Status | This is the status of the ETL run.  It  shows as “IN PROCESS” when the ETL job starts and as either “SUCCESS”  or “FAILURE” when complete.<br/><br/><br/>**• IN PROCESS** –  The job is still running.<br/><br/><br/>**• SUCCESS** –  The job finished successfully.<br/><br/><br/>**• FAILURE** –  The job did not finish successfully or timed out. |



Options - Stop ETL Processing
: Select the **Stop 
 ETL Processing** option to end the ETL run in process. You can stop  an ETL run after it has been processing for more than 10 minutes.


Options - View History Detail
: Use the **View History 
 Detail** option to open the **ETL 
 History Details** browser for the selected ETL run. Alternatively,  you can select an ETL run in the **ETL 
 History** browser and press the **Enter**  key.


{:.see_also}
See also
: [ETL  History Details Browser]({{site.db_baseurl}}/create-and-set-up-the-database-and-dashboard/etl_history_details_dialog_box_ead.html)
