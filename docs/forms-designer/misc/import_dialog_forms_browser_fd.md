---
title: Import Dialog - Forms Browser
---
<script type="text/javascript" language="JavaScript1.2" x-save-method="compute-relative" src="{{site.fd_baseurl}}/misc/ehlpdhtm.js"></script><script type="text/javascript" language="JavaScript1.2">
<!-- 
if( typeof( kadovFilePopupInit ) != 'function' ) kadovFilePopupInit = new Function();if( typeof( kadovTextPopupInit ) != 'function' ) kadovTextPopupInit = new Function();
 //-->
</script>
The boxes are checked if the conditions are OK with the form versions  being imported and the boxes are unchecked if there is name conflict in  the form version.


{:.note}
: Checking the box on a row with a name conflict will  cause the imported form version to overwrite the existing version with  the same name.  This  provides the ability to use the import to do updates.

This describes the class of the imported custom form version. ****

This shows the name of the imported form version and you may edit the  name in this column.

This describes the type of the custom form version being imported.

**This 
 describes the status of the custom form versions being imported. &nbsp;This 
 column shows the following descriptions;**

- **OK**  - Displays for the Custom forms are OK to import.
- **Existing 
 Name** - Displays if the name of the form being imported already  exists.

# Import Dialog – Forms Browser


Use the **Import Dialog-Forms browser**  to select and edit the custom form versions that you import. The **Import Dialog-Forms Browser** also provides  the following functionality:

- Lists the form  versions being imported
- Highlights Name  conflicts
- Enables version  name editing
- Validates the imported  form versions
- Saves the imported  form versions.



You will see five columns in the **Import 
 Dialog – Forms Browser**.

- [Check  box](javascript:kadovTextPopup(this)){:id="a1"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a1');
//--></script>  - Allows to check/Uncheck  all form versions.
- [Form  Class](javascript:kadovTextPopup(this)){:id="a2"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a2');
//--></script>  - Shows the class of the imported form version.
- [Form  name](javascript:kadovTextPopup(this)){:id="a3"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a3');
//--></script>  - Shows the name of the imported form version.
- [Type](javascript:kadovTextPopup(this)){:id="a4"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a4');
//--></script>  - Shows the type of the imported form version.
- [Condition](javascript:kadovTextPopup(this)){:id="a5"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a5');
//--></script>  - **Shows the status of the custom form 
 versions being imported.**



{:.note}
: It is necessary to check the boxes for the selected  form versions. Use left corner check box to check/uncheck  all the form versions.


If there is name conflict for the selected form version, you will see  **Existing Name** in the condition  column. To update an existing form version with an imported version of  the same name, check the checkbox on the version row in the **Import 
 browser**.  Then,  Click **Import**. You will see the  confirmation screen. On the confirmation screen;

- Click **Yes**  to update the existing form versions. If you selected multiple form versions  for update, automatically moves to next selected form version and confirms  one by one.
- Click **No**,  if you do not want to update. The form version will not be imported.
- Click **Yes 
 to All** to clear all of the form update warning messages.  All  of the versions sharing a name with an existing form version will be updated.
- Click **No 
 to All** to clear all of the form update warning messages.  The  versions sharing a name with an existing version will not be imported.



![]({{site.fd_baseurl}}/img/see_also.gif)


[Updating  Existing Forms]({{site.fd_baseurl}}/misc/updating_existing_forms.html)


[Importing  a Form Version]({{site.fd_baseurl}}/forms-browser/importing_a_form_version.html)
