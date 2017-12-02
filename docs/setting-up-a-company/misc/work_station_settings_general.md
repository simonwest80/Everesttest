---
title: Workstation Settings - General - Report Settings
---

# Workstation Settings - General - Report Settings


Use the **Report Settings**  tab to specify your workstation report settings. These settings override  any global reports settings specified in the Reporting Preferences (Path:  **File** > **Setup**  > **Preferences** > **Defaults**  > **Reporting Preferences** >  **Export Settings** tab).


![]({{site.sc_baseurl}}/img/lens.gif) [The\_Reporting\_Preferences\_Dialog\_Box  - Export\_Settings]({{site.bp_chm}}/rpt-prt/report-settings/the_reporting_preferences_dialog_box_export_settings_tab_bp.html)


**Low speed connection**
: Select this check box if you are accessing a report  server to generate reports on your workstation, using a WAN (Wide Area  Network) or remote connection, and when your workstation is outside the  Local Area Network of your application server. The report is generated  at the reports server and sent back to the workstation, one page at a  time.


{:.warn}
You need not select this option if you are not accessing a reports server  for generating reports. There might be formatting differences and limitations  in reports generated when the ‘Low Speed Connection' is selected.


{:.note}
If this option is selected:

- The **Export** option for **Everest Reports**  will not be available.
- Only your default  printer will be available for printing.


{:.example}
If your main office is in the United States  and a subsidiary is in Singapore, to run reports in the Singapore office,  you must select the **Low** **Speed** **Connection**  check box.
: The **Low Speed Connection**  check box is disabled if both the **Everest**  Client and the reports server are on the same Microsoft Windows ® Vista  machine.


**Reports Repository**
: Specify the location of your workstation reports  repository. **Everest Reports** reside  in, and are accessed from this location.


{:.note}
• Locations that you enter in this field override the global reports  repository path in the Reporting Preferences (Path: **File**  > **Setup** > **Preferences**  > **Defaults** > **Reporting 
 Preferences** > **Export Settings**  tab).


• All repository paths in **Everest**  are stored in UNC (Universal Naming Convention) paths. On a network, the  UNC is a method by which you can identify a shared file in a computer,  without having to specify the storage device it is on. For Windows, the  UNC name format is \\servername\sharename\path\filename.


• You can specify the reports repository of the local workstation, or  another server/workstation on your network, as your workstation reports  repository.


**Export File Path**
: Specify the location where you want **Everest 
 Reports** to be exported and stored for retrieval at a later date.  If a global or workstation setting is not selected for this field, it  defaults to **My Documents**. On Microsoft  Windows ® Vista systems, the Export File Path defaults to “C:\programdata\everest\temp”.


{:.note}
The path that you enter in this field overrides  the path in the **Export File Path (High 
 Speed)** field in the Reporting Preferences (Path: **File**  > **Setup** > **Preferences**  > **Defaults** > **Reporting 
 Preferences** > **Export****Settings** tab).


**Export File Format**
: Select the file format for **Everest 
 Reports** to be exported, for retrieval at a later date.


{:.note}
The format that you enter in this field overrides  the format in the global **Export File 
 Format** field in the Reporting Preferences (Path: **File**  > **Setup** > **Preferences**  > **Defaults** > **Reporting 
 Preferences** > **Export****Settings** tab).


**Prompt User for Export Options**
: Select this option to display the **Export**  dialog box, containing additional options, when exporting reports in **Everest**.


{:.note}
If this option is selected, **Everest**  overrides the path specified in the **Export 
 File Path** field, and the format specified in the **Export 
 File Format** field, allowing you to choose alternate formats and  destinations from the **Export** dialog  box.


{:.see_also}
See also
: [Workstation  Settings - General]({{site.sc_baseurl}}/options/miscellaneous-set-up/workstation-settings/workstation_settings_general_introduction.html)
