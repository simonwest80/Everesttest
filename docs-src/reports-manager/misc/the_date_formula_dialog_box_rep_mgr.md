---
title: The Date Formula Dialog Box
---

# The Date Formula Dialog Box 


**Current Date**
: This refers to the login  date of the system. You must set up either the From or To date as the  current date. If you have set up a schedule to generate a report, the  current date represents the scheduled date.


**Expression Date**
: Use this option to arrive at the computed date for  the generation of reports.
: It enables the **Parameter**,  **Operator**, and **Number 
 of Days** fields. If you set up the **Current 
 Date** as the Date From, Date To must be set up as the **Expression 
 Date**.


**Parameter**
: Select the parameter from the drop-down list to  specify whether the report to be generated should be based on number of  days from the **Date From** or **Date To** field.


**Operator**
: Select the ‘**+**’  or ‘-’ symbol from the drop-down menu depending on whether you wish to  compute the date prior to or later than the current date.


**Number of Days**
: In accordance with the symbol selected in the **Operator** field, specify the number of  days prior to or later than the current date.


**Use Formula**
: Select this check box to use the date formula specified.  The **Formula** button in the **Report Parameter** dialog box appears  in boldface.


{:.example}
- Assume that today  is 12 March 2004, Friday. To generate a weekly report on every Friday,  select the Current Date option for the Date From field and check the Use  Formula option. For the Date To field, select the Expression Date option.  Select the dtDate  From in the Parameter field, the ‘+’ symbol in the Operator field and  7 in the Number of Days field and check the Use Formula option. Specify  a schedule for the report to be generated on every Friday. **Everest**  displays a reminder to run the report batch on the specified date. The  next report as per these entries is generated on 19 March 2004 (Friday),  seven days from the current date.
- To generate the  Activity Report for the 1st to the 15th of every month, select the Current  Date option for the Date To field and check the Use Formula option. For  the Date From field, select the Expression Date option. Select the dtDate  To in the Parameter field, the ‘-’ symbol in the Operator field and 15  in the Number of Days field and check the Use Formula option. Specify  a schedule for the report to be generated on the 16th day of every month  indefinitely from the start date. **Everest**  displays a reminder to run the report batch on the 16th day of every month.


{:.see_also}
See also


[Date Parameters in Report  Batches]({{site.rmgr_baseurl}}/manager/window/report-batches/create-a-report-batch/date_parameters_in_report_batches.html)
