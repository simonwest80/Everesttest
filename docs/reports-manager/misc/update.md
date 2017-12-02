---
title: update
---

# Update


Use this option to reflect the modifications made to the .rpt file in  the .czr file.


{:.note}
Alternatively, you can drag and drop the modified .rpt file into the  .czr file.


{:.steps}
To update the report, do the following:

- From the main  menu bar, select **Reports** >  **Reports** **Manager**.  You will see the **Reports Manager** window.
- From the **Reports Manager** window, select a .czr  file and select **File** > **Update Report**. You will see the **Open** dialog box. Select the .rpt file  and click **Open**.



{:.hint}
For user-created reports if there are any differences in the number  of parameters, you need to take the following actions. For existing reports  in the main **Everest** Reports menu,  you cannot add/delete/modify the parameters, but you can change the layout  of the report.

- If the type of  parameter is changed, you are prompted to delete the control associated  with that parameter. If you delete the control, the report is updated.
- If the number of  new parameters is less than the number of parameters already existing  in the .czr file, you are prompted to delete the controls associated with  the parameters that do not exist in the report. If you delete the controls,  the report is updated.
- If the number of  parameters is more than the number of parameters already existing in the  report, you are warned that there are no controls associated with the  new parameters. In such a case, you have to associate controls to the  new parameters and then update the .czr file.


{:.note}
For extracting and updating reports, the user must have adequate security  rights.


{:.see_also}
See also
: [Extracting  and updating reports]({{site.rmgr_baseurl}}/manager/window/modifying-reports/extracting_and_updating_reports.html)
: [Security  Rights]({{site.sc_chm}}/options/security/security-rights/security_rights.html)
