---
title: Generating Reports
---

# Generating Reports


To help you understand and generate reports, we shall follow a standard  format to describe the report. Each report has the following sections:

- Name
- Description
- Steps on how to  generate the report (options to select from the menus).
- Image of the parameter  dialog box
- Explanation of  the parameters
- Image of the report



| ![]({{site.rpt_baseurl}}/img/example.gif) | **Task List <br/> Report**<br/><br/><br/>The **Task List** report prints  a list of tasks that were created during a specified date range.<br/><br/><br/>Steps to generate Tasks List report<br/><br/>- From the main  menu bar, select **Reports** >  **Miscellaneous** > **Task <br/> List**. You will see the **Task List**  dialog box.<br/>- Specify the  report parameters and click:<br/><br/><br/>- **Preview**,  to preview the report in the **Report Preview** dialog box, before printing<br/>- **Print**,  to print the report<br/>- **Export**,  to save the report in text, Excel, HTML or Crystal Report file formats<br/><br/><br/><br/>{:.note}<br/>The **Export**  option is not available, if you select **Low <br/> Speed** connection in the **Workstation <br/> Settings** dialog box (path: **File <br/> &gt; Setup &gt; Preferences &gt; Workstation Settings &gt; General &gt; <br/> General Settings** tab).<br/><br/><br/>Task List Dialog Box<br/><br/><br/>**Create Date From**<br/>: Specify the start date for the range of creation  dates of the task, to be included in the report.<br/><br/><br/>**Create Date To**<br/>: Specify the end date for the range of creation dates  of the task, to be included in the report.<br/><br/><br/>{:.note}<br/>If the **Create <br/> Date From** and **Create Date To**  fields are left blank, by default the current system date will be included  in the report. |



{:.note}
**Everest** has  international date/time handling capabilities for reports. You can format  date/time, by changing the regional settings of the server where **Everest** reports reside. You can modify  the regional settings for your system by selecting **Start 
 &gt; Settings &gt; Control Panel &gt; Regional Options**.


{:.example}
If the default date format displayed in **Everest** is YY/DD/MM,  and you change it to DD/MM/YY  in the regional settings, **Everest** will  display dates in the latter format.


{:.see_also}
See also
: [Everest Reports]({{site.rpt_baseurl}}/everest-reports/everest_reports.html)
: [Task List]({{site.rpt_baseurl}}/everest-reports/miscellaneous/task_list.html)
