---
title: Create Task/Appointment
---
<script type="text/javascript" language="JavaScript1.2" src="{{site.crm_baseurl}}/misc/ehlpdhtm.js" x-save-method="compute-relative"></script><script type="text/javascript" language="JavaScript1.2">
<!-- 
if( typeof( kadovInitEffects ) != 'function' ) kadovInitEffects = new Function();if( typeof( kadovInitTrigger ) != 'function' ) kadovInitTrigger = new Function();if( typeof( kadovFilePopupInit ) != 'function' ) kadovFilePopupInit = new Function();if( typeof( kadovTextPopupInit ) != 'function' ) kadovTextPopupInit = new Function();
 //-->
</script>
# Create Task/Appointment


If the **Create Task/Appointment**  option is selected in the **Action**  field of the **Activity** profile,  a task or an appointment is created whenever the event associated with  the activity occurs. The start date for the task/appointment is calculated  based on the schedule you specify in the [Schedule  Action]({{site.crm_baseurl}}/standard-crm/bam/activity/the_activity_profile.html#schedule_action) field of the **Activity**  profile.


The **Task/Appointment Details**  dialog box is displayed when you click the edit action icon ![]({{site.crm_baseurl}}/img/crm_lookup_icon.gif) in the **Activity** profile.  Use this dialog box to specify the details regarding tasks and appointments.


{:.note}
You can also select **Edit 
 Action** option from the right-click menu in the **Process/Activities** browser, to bring up the dialog box.


This dialog box displays the process and the activity to which the action  is associated.


**Template Description**
: Select a template from the drop-down list. This  field is dependent on event group and the [type of template](javascript:BSSCPopup('{{site.crm_baseurl}}/misc/template_types.html');){:id="A1"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovFilePopupInit('A1');
//--></script>.  In other words, the drop-down list displays only those templates that  are defined for a particular event group and are of type **Task/Appointment**.  Click the **Notes** ![]({{site.crm_baseurl}}/img/crm_notes_icon.gif) icon next to the field to view the body of the template.


**Type**
: In this field, specify if the details is for the  type Task, Appointment, or General Notes.


{:.note}
If you choose the option **Task**,  you have to set a priority for it.


User Selection


In this section, specify the person for whom the task or appointment  should be created. You can select sales representatives, logged in users  or assigned users.


Duration
: Specify the duration in days, hours or minutes for  the task or the appointment. This input is used to calculate the end date  and time for the task/appointment. This section is disabled if you select  **General Notes** in the **Type** field. For an appointment, the reminder pops up at the time specified  before the appointment time.


**Remind**
: Select this check box to set reminders for the tasks,  appointments or general notes. Specify the values in the given fields  as to when you should be reminded about a given task or appointment. The  reminder is different for tasks and appointments.
: For an appointment, the reminder pops up at a specified  time before the appointment schedule. For example, if you specify "15  minutes" in the box provided, then the remind popup  appears 15 minutes before the actual appointment time.
: For task, the reminder pops up at a specified date  and time before or after the start date of the task. For example, if you  specify "2" in the **Days**  field, "Before" in **Occurrence**  and "9:00 AM" in the **At**  field, then the remind popup  for the task appears at 9:00 AM two days before the start date and time  of the task.


{:.see_also}
See also
: [The Activity  Profile]({{site.crm_baseurl}}/standard-crm/bam/activity/the_activity_profile.html)
