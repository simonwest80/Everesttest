---
title: Print Letter/Memo
---
<script type="text/javascript" language="JavaScript1.2" src="{{site.crm_baseurl}}/misc/ehlpdhtm.js" x-save-method="compute-relative"></script><script type="text/javascript" language="JavaScript1.2">
<!-- 
if( typeof( kadovInitEffects ) != 'function' ) kadovInitEffects = new Function();if( typeof( kadovInitTrigger ) != 'function' ) kadovInitTrigger = new Function();if( typeof( kadovFilePopupInit ) != 'function' ) kadovFilePopupInit = new Function();if( typeof( kadovTextPopupInit ) != 'function' ) kadovTextPopupInit = new Function();
 //-->
</script>
# Print Letter/Memo


If you select the **Print Letter/Memo** option in the **Action** field  of the **Activity** profile, the user  specified in the **Notify User** field  (**Print Letter/Memo Setup** dialog  box) is prompted whenever the event associated with the activity occurs.  Depending on the response from the user, the action is executed.


{:.note}
If the user specified in the **Notify 
 User** field is not logged in when the event occurs, he/she is prompted  during the next login.


The **Print Letter/Memo Setup**  dialog box is displayed when you click the edit action icon ![]({{site.crm_baseurl}}/img/crm_lookup_icon.gif) in the **Activity** profile.  Use this dialog box to specify the details of the letter/memo to be printed.


{:.note}
You can also select **Edit 
 Action** option from the right-click menu in the **Process/Activities** browser, to bring up the dialog box.


This dialog box displays the process and the activity to which the action  is associated.


**Template Description**
: Select a template from the drop-down list. The letter/memo  will be printed in the format specified in the template. This field is  dependent on event group and the [type of template](javascript:BSSCPopup('{{site.crm_baseurl}}/misc/template_types.html');){:id="A1"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovFilePopupInit('A1');
//--></script>.  In other words, the drop-down list displays only those templates that  are defined for a particular event group and are of type **Letter**.  Click the **Notes** ![]({{site.crm_baseurl}}/img/crm_notes_icon.gif) icon next to the field to view the body of the template.


**Notify User**
: Select a user code from the drop-down list. When  the activity is executed, the user is notified and based on the response,  the letter/memo is printed.


{:.see_also}
See also
: [The Activity  Profile]({{site.crm_baseurl}}/standard-crm/bam/activity/the_activity_profile.html)
