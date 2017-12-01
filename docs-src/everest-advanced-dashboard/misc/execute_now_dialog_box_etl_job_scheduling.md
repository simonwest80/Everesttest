---
title: Execute Now Dialog Box
---

# Execute Now Dialog Box


Use the **Execute Now** dialog box  to run the **Extract, Transform, and Load 
 (ETL)** function now and update your data warehouse.


Extract From


**Last Run**
: Use the **Last Run**  option to extract records back to the last successfully loaded record  in **Everest**. If necessary, use  this option to rerun the ETL subsequent to a failure. This option can  be selected at any time to capture production changes since the last successful  run.


**Choose Date**
: Use the **Choose 
 Date** option to choose an arbitrary date and **Everest**  will extract records back to the chosen date. If you choose a date that  is before the date of the last successfully loaded record, the previously  collected data in the data mart will be overwritten. This option may take  longer than a normal ETL run.


**Start Over**
: Use the **Start Over**  option to delete and rebuild the data mart. This completely refreshes  the data mart and retrieves data from the oldest **Everest**  data available. The data mart cubes will also be reprocessed.


{:.warn}
The **Start 
 Over** option overwrites all records in the data mart and may take  a very long time to execute.


{:.steps}
To Execute the ETL run now, do the following:

- From the **Execute Now** dialog box (Path: **Utility &gt; Data Warehouse &gt; ETL Schedule 
 &gt;** From the **ETL Job Scheduling**  dialog box click **Execute Now**),  select a method of processing the ETL activity.


- : Last  Run
- : Choose  Date
- : Start  Over


- Click **OK**.  You do not have to wait for the ETL task to complete before moving to  other tasks.



{:.see_also}
See also
: [ETL Job Scheduling]({{site.db_baseurl}}/create-and-set-up-the-database-and-dashboard/etl_scheduling_ead.html)
