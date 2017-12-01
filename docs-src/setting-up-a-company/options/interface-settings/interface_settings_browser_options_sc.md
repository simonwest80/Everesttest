---
title: Interface Settings Browser - Options
---
<script type="text/javascript" language="JavaScript1.2" x-save-method="compute-relative" src="{{site.sc_baseurl}}/misc/ehlpdhtm.js"></script><script type="text/javascript" language="JavaScript1.2">
<!-- 
if( typeof( kadovFilePopupInit ) != 'function' ) kadovFilePopupInit = new Function();if( typeof( kadovTextPopupInit ) != 'function' ) kadovTextPopupInit = new Function();
 //-->
</script>
Select this option to load the factory settings to start a new template.  When you try to save any changes you make, you will see the **Save 
 Settings As Template** window in which you can enter the name of  the new template. Click **OK** to  create the new template.


{:.note}
: No changes can be made to factory default settings.  Changes made while the default settings are loaded must be saved with  a new name.


{:.hint}
: You can use the **Insert**  key as shortcut key to create a new template.


The title bar of the **Customize**  and **Browser Properties** screens  will reflect that the new settings have not been saved yet.  After  they are saved, the new name of the settings will be reflected.

Select this option to load the settings currently selected in the browser  and edit them. These settings will remain loaded until you log out or  load different settings.


{:.note}
: Load Settings option is desensitized when any other  user’s settings are selected in the browser.


The title bar will reflect the currently loaded settings, when the **Customize** or **Browser 
 Properties** screen is selected.


{:.hint}
: Use the **Enter**  key as a shortcut key to load the selected settings.

Select this option to change the name of the customized settings. You  can edit the current name of the settings in the **Rename 
 Interface Settings** window and click **OK**  to apply the name change.


{:.note}
: The **Rename Interface 
 Settings** window will be desensitized when any other user’s settings  are selected.

Select this option to copy and save the selected settings as a template.  The template will retain all customizations in the selected settings.  You can view the newly created template in the **Interface 
 Settings** browser.


{:.note}
: User assignments will not be copied with the settings  when you save the current settings as template.


{:.hint}
: You can use **Ctrl+S**  as the shortcut key to save settings as a template.

Select this option to reset different parts of the template which will  we applied across the entire template. This option has the following menu  options:


**Document Alias Menu**
: Select this option to set the **Document Alias Menu** back to the default settings. On selection  of this option, you will see the confirmation message, ’Are you sure you  want to lose the changes made to these settings and go back to the factory  settings for the Document Alias menu?’.  Click  **Yes** to restore the factory default  settings for the **Document Alias Menu**.


**Reports Menu**
: Select this option to set the **Reports Menu** back to the default settings. On selection of this  option, you will see the confirmation message, ’Are you sure you want  to lose the changes made to these settings and go back to the factory  settings for the Reports menu?’.  Click  **Yes** to restore the factory default  settings for the **Reports Menu**.


**Filters Menu**
: Select this option to set the **Filters Menu** back to the default settings. On selection of this  option, you will see the confirmation message, ’Are you sure you want  to lose the changes made to these settings and go back to the factory  settings for the Filters menu?’.  Click  **Yes** to restore the factory default  settings for the **Filters Menu**.


**All Settings**
: Select this option to set all the settings back  to the factory default settings. On selection of this option, you will  see the confirmation message, ‘Are you sure you want to lose the changes  made to these settings and go back to the factory settings for all screens?’.  Click **Yes** to restore all the selected  settings to the factory default settings.

Select this option to apply the changes made on the **browser 
 properties** screen to all browsers and lookups for the interface  settings selected. The browser view can be changed to suit your requirements.  You can hide the grid lines in the browser, change the font of the column  headers, change the color scheme of the browsers, hide columns, and specify  the number of records to be retrieved by default. All these settings are  specified in the **Browser Property Editor**  dialog box.


{:.hint}
: You can use **Ctrl+P**  as the shortcut key to open the **Browser 
 Property Editor** dialog box.


Browser Property Editor - General


This tab allows you to specify data retrieval options for the browser  and alternative display options for the sort tabs.


Data retrieval


**Retrieve all the records**
: Select this option to retrieve all the records into  the browser at one time. If this option is not selected, records are retrieved  into the browser based on the number of records specified in the **Retrieve records in blocks** field.


**Retrieve records in blocks**
: Select this option to indicate that the records  in the browser must be retrieved in batches i.e. all the records are not  retrieved at the same time. Selecting this option enables faster access  to data.


**Block size (Number of records to be retrieved  per fetch)**
: Enter the number of records to be retrieved at one  time. This field is activated only if the **Retrieve 
 records in blocks** option is selected.


**Show get more record count textbox**
: Select this check box to display an additional box  beside the **Get** **more**  button in the browser where the number of records to be retrieved can  be entered. This field is activated only if the **Retrieve 
 records in blocks** option is selected.


**Refresh browser on activation**
: Select this check box to refresh the browser when  ever you make it active. If this box is not checked, you must manually  refresh the browser.


**Override individual browser settings**
: Select this checkbox to override the individual  browser and lookup settings that have been changed.


Other Options


**Search field display style**
: Use this field to specify the display style of the  [sort tabs](javascript:kadovTextPopup(this)){:id="a6"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a6');
//--></script>.


**Display zero**
: Select this check box to display zero in the browser  column that has a zero value. If this option is not selected, the records  are displayed, but the column containing the zero-number field will be  blank, i.e., no zero is shown.


**Show column filters**
: Filtering is a quick way to find a subset of data  in a browser. Select this check box to display arrow buttons on the column  headers in the browser. The arrow buttons enable you to filter data.


Show Index Tabs
: You can choose to display or hide the index sort  tabs by selecting any of the following options:


| Option | Select this option: |
| None | If you do not want to display the sort tabs for the browser. |
| Top | To display the sort tabs at the top of the browser. |
| Bottom | To display the sort tabs at the bottom of the browser. |



Look and Feel


**The following options allow you to alter  the look and feel of **Everest** browsers:**


| Option | Select this option to: |
| Standard | View the browser in the standard Windows view. |
| Flat | Flatten the appearance of the browser (which appears three-dimensional  in the above option). |
| Ultra Flat | Obtain an even flatter appearance of the browser. |



{:.see_also}
See also


[Browser  Property Editor - Grid]({{site.wwe_chm}}/everest-client/ui/browsers/options/property-editor/browser_property_editor_grid_tab.html)

**Sort Tabs**
: The Sort tabs allows you to sort the data in a browser  based on the field specified in the Sort tab.


{:.example}
To sort the **Items**  browser on 'Category', Click on the 'Category sort tab'.

Select this option to change the template of the selected user settings.  You can select the template to be applied in the **New 
 Template** drop-down box on the **Change 
 Template** window. You will get a confirmation message: ‘Any customizations  made by the user will be lost. Are you sure you want to change the template?’  Click **Yes** to change the template.


{:.note}
: If you change the template, the new template will  be applied to all screens for that user and any customizations made by  the user will be lost.

Use the **Assign Users/Groups**  option to open the **Assign Interface Settings**  window in which you can assign the selected interface settings to individual  users and user groups. Alternatively, You can open the **Assign 
 Interface Settings** window from the main menu, by clicking **File** > **Setup**  > **Assign Interface Settings**.

Select this option to overwrite the existing settings with the latest  changes made to the interface settings for all users and groups assigned  to these settings. The following confirmation message will be shown: ‘This  will overwrite existing settings for all users and groups assigned to  these settings. Any individual customizations made by these users will  be lost. Are you sure you want to apply these settings to their assigned  users and groups?’ Click **Yes** to  apply the latest changes.

Use this option to inactivate the selected records. The discontinued  records can later be activated from the **Discontinued 
 Interface Settings** browser.


{:.note}
- Any template can  be discontinued within the browser, regardless of the users and groups  are assigned to it.
- You cannot discontinue  the User Settings directly.  User  settings will be automatically discontinued only when the associated user  is discontinued.


{:.hint}
: You can use **Delete**  key as shortcut key to discontinue the selected templates.

Use this option to activate or purge the discontinued templates in the  **Discontinued Interface Settings**  browser.  The  user settings cannot be directly activated, but will be automatically  activated when the associated user is activated.


{:.note}
: **Purge** option  will be desensitized, if you select the user’s settings i.e., user  settings cannot be purged manually but will be automatically removed if  a user is removed.


{:.hint}
: You can use the **F4**  key as the shortcut key to view the discontinued templates.

Use this option to export the templates and user settings to an external  file.

- Click **Export 
 Settings** (path: **Interface Settings**  > **Options** > **Export 
 settings**). You will see the **Export 
 Dialog – Interface Settings** window.



{:.see_also}
See also
: [Export  Dialog - Interface Settings]({{site.sc_baseurl}}/misc/zzexport_dialog_interface_settings_sc.html)

Use this option to import the interface settings files.


{:.steps}
To import the interface settings files, do  the following:

- Click **Import 
 Settings**. You will see the **Open**  dialog box.
- Select the name  and type of the file to be imported.



{:.note}
- The file type in  the window will be defaulted to .XML file type.
- All imported files  will be treated as interface settings templates and not as user’s settings.
- You can only import  interface settings templates from one version back of **Everest**.

# Interface Settings Browser - Options


From **Interface Settings** browser  > **Options** menu, you will see  the following menu options:

- [New Template](javascript:kadovTextPopup(this)){:id="a1"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a1');
//--></script>
- [Load  Settings](javascript:kadovTextPopup(this)){:id="a2"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a2');
//--></script>
- [Rename](javascript:kadovTextPopup(this)){:id="a3"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a3');
//--></script>
- [Save  As Template](javascript:kadovTextPopup(this)){:id="a4"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a4');
//--></script>
- [Restore  to Factory Settings](javascript:kadovTextPopup(this)){:id="a5"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a5');
//--></script>
- [Global  Browser Properties](javascript:kadovTextPopup(this)){:id="a7"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a7');
//--></script>
- [Change  Template](javascript:kadovTextPopup(this)){:id="a8"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a8');
//--></script>
- [Assign  Users/Groups](javascript:kadovTextPopup(this)){:id="a9"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a9');
//--></script>
- [Apply  to Assigned Users/Groups](javascript:kadovTextPopup(this)){:id="a10"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a10');
//--></script>
- [Discontinue](javascript:kadovTextPopup(this)){:id="a11"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a11');
//--></script>
- [View  Discontinued](javascript:kadovTextPopup(this)){:id="a12"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a12');
//--></script>
- [Export  Settings](javascript:kadovTextPopup(this)){:id="a13"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a13');
//--></script>
- [Import  Settings](javascript:kadovTextPopup(this)){:id="a14"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a14');
//--></script>



{:.see_also}
See also
: [Interface  Settings Browser]({{site.sc_baseurl}}/options/interface-settings/interface_settings_browser_sc.html)
: [Assign  Interface Settings]({{site.sc_baseurl}}/options/interface-settings/assign-interface-settings/assign_interface_settings_sc.html)
