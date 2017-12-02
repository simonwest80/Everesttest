---
title: ETL History Details Browser
---

# ETL History Details Browser


Use the **ETL History Details**  browser (Path: **ETL History Browser**  > **Options** > **View 
 History Detail**) to view the details of each step of the selected  ETL run. You can see the progress of a currently running ETL.


The **ETL History** browser shows  values based on the last SQL transaction performed during the ETL run.  Each row in the **ETL History Details**  browser contains information about a step in the ETL run.


The following table shows information on the **ETL 
 History Details** browser columns:


| Column Heading | Description |
| Step Name | This is the name of the ETL step in the ETL run. |
| Start Time | This is the beginning time of the ETL step. |
| End Time | This is the ending time of the ETL step. |
| Duration | This is the time it took to finish the ETL step. |
| Status | This is the status of the ETL step. Possible values are:<br/><br/><br/>• Waiting<br/><br/><br/>• In Progress<br/><br/><br/>• Inactive<br/><br/><br/>• Completed<br/><br/><br/>• Failed<br/><br/><br/>• Not known |
| Result | This is the completion status of the ETL step. Possible values are:<br/><br/><br/>• Success<br/><br/><br/>• Failure<br/><br/><br/>• Not known |
| Progress Count | This is a positive number that indicates the relative progress of the  ETL Step. |
| Failure Code | If the ETL step failed, a failure code is displayed. |
| Failure Description | If the ETL step failed, the failure code description is displayed. |



{:.see_also}
See also
: [ETL History  Browser]({{site.db_baseurl}}/create-and-set-up-the-database-and-dashboard/etl_history_browser_ead.html)
