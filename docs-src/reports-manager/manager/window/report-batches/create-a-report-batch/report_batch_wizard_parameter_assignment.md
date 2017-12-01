---
title: Report Batch Wizard - Parameter Assignment
---

# Report Batch Wizard - Parameter Assignment


This section displays the list of reports added to the batch.


This section of the wizard contains three columns:


**Description**
: This column displays the report name that is chosen  for batch processing.


**Parameters**
: Set default parameter values for the batch reports  in this column. When you run the batch, the reports are executed based  on these parameter values. By default, this column displays 'No Parameters'.


{:.steps}
To define report parameters, do the following:

- When you double-click  the report, the respective **Report Parameter**  dialog box is displayed.
- Specify the  values and click **OK**. The entry  in this column changes to "Parameters".



{:.note}
The parameter values entered here are saved  by default along with the batch reports, and they are selected every time  you run the batch.
: ![]({{site.rmgr_baseurl}}/img/example.gif) If Balance Sheet report is added to the batch and you specify  the default parameter value for the year 2001, every time you execute  the batch, this report provides information pertaining to the year 2001.


Batches are user-specific and for each report included in the **Report Batch** the default parameters  are taken from the user. This means that two users could create the same  batch using the same reports with same parameters. However, they could  specify different parameter values as default values and the reports generated  would be different for each.


![]({{site.rmgr_baseurl}}/img/example.gif) The  above batch of reports could be created by users A and B. If A gives the  year 2001 as the parameter value and B gives the year 2000 as the parameter  value, the financial reports for the year 2001 will be generated for user  A, and the financial reports for the year 2000 will be generated for user  B.


**Print Action**
: Click the report to display a drop-down button with  **Preview** and **Print**  options. Select the default action to be performed when the batch is run.
: Select **Preview**  to display a preview of all the reports consecutively. You can print reports  from each preview.
: Select **Print**  to print the reports without a preview.
: Click **Finish** to  complete creating the report batch.


{:.note}
At any time during the creation of batch reports,  you can click **Cancel** (to cancel  the process) or **Previous** to go  to the previous section.


{:.see_also}
See also
: [Report Batch  Wizard]({{site.rmgr_baseurl}}/misc/the_report_batch_wizard.html)
