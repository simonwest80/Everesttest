---
title: Report Batch Scheduling Dialog Box
---

# Report Batch Scheduling Dialog Box


Occurs


**Daily**
: Select the **Daily**  option to set a daily schedule for running the report batch. The **Every &lt;number of &gt; Day(s)** field  is enabled. Specify the frequency of the schedule in this field.
: ![]({{site.rmgr_baseurl}}/img/example.gif) To execute report batch once in every 5 days, enter 5 in  this field.
: The maximum number of days that can be specified  is 100.


**Weekly**
: Select the **Weekly**  option to set a weekly schedule for running report batches. The **Every &lt;number of&gt; Week(s)** field  and the **Week day** check boxes are  enabled. Select the required fields based on your schedule.
: ![]({{site.rmgr_baseurl}}/img/example.gif) To execute report batch every alternate Friday, enter 2 in  the **Every &lt;number of&gt; Week(s)**  field and select the **Friday** check  box.
: The maximum number of weeks that can be specified  is 100.


**Monthly**
: Select the **Monthly**  option to set a monthly schedule for running report batches. The maximum  number of months that can be specified is 100.
: You can set the monthly schedule in two ways:

- Based on the  day of the month

: ![]({{site.rmgr_baseurl}}/img/example.gif) Report batches can be  run on the 30th day of every third month.

- Based on the  week day

: ![]({{site.rmgr_baseurl}}/img/example.gif) Report batches can be  run on the last Friday of every month.


Frequency


This section allows you to define when the report batches have to be  executed. The following options are available:

- The report  batches can be run at a specified time.
- The report  batches can be run at specified hourly intervals.



{:.note}
These options are used in combination with the daily, weekly or monthly  schedule.


**Occurs once at**
: Select this option to run report batches at a specified  time.
: ![]({{site.rmgr_baseurl}}/img/example.gif) You can schedule to run report batch  every alternate day at 12:00 p.m.


**Occurs every**
: Select this option to schedule report batches to  be executed at specified hourly intervals.
: ![]({{site.rmgr_baseurl}}/img/example.gif) If you set a frequency of 4 hours along with the daily option  of 3 days, the report batches will be executed once in 4 hours on every  third day.


**Starting at**
: Specify the time when the report batch should start  execution. This option is enabled only if you select the **Occurs 
 every** option.
: ![]({{site.rmgr_baseurl}}/img/example.gif) In the above instance, if you select the starting time as  10:00 a.m. and ending time as 6:00 p.m., the report batch will run once  in 4 hours on every third day, i.e., once at 2:00 p.m. and again at 6:00  p.m.


**Ending at**
: Enter the time when the report batch should stop  execution.


Duration


You can set the time period during which the schedule must be functional.


**Type**
: This field allows you to specify the duration for  which the report batch job scheduling will be functional. The drop-down  menu offers the following options:

- **Date 
 Range** - Specify the starting date and ending date for which the  parameters selected in the **Occurs**  and **Frequency** sections apply.  Execution of report batches will start and stop on the dates specified  here.



![]({{site.rmgr_baseurl}}/img/example.gif)  If  you want to execute a report batch for the month of March, you must specify  3/1/2003 in the **Start** **Date**  field and specify 3/31/2003 in the **End****Date** field.

- **Indefinitely 
 from Start Date** - Specify the starting date for which the parameters  selected in the Occurs and Frequency sections apply. The report batches  will be executed for an indefinite time period, and will start from the  date specified in the **Start** **Date** field.



**Start Date**
: Specify the date from which the report batch should  be executed.


**End Date**
: Specify the date up to which the report batch should  execute.


{:.note}
The **End Date** fields appears  only if you select **Date** **Range** in the **Type**  field.


**Execute Now**
: The report batches must be executed periodically  to reflect the changes in the database. Click this button to execute the  report batch immediately.


**Save Schedule**
: Click this button to save the changes made and close  the dialog box.


{:.note}
To schedule a report batch, the SQL Agent  must be constantly running in the background on your computer.


{:.see_also}
See also
: [Scheduling Batches]({{site.rmgr_baseurl}}/manager/window/report-batches/schedule-a-report-batch/scheduling_batches.html)
