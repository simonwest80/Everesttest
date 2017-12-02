---
title: Login Time and Date
---

# Login Time and Date


**Time Zone**
: Select the time zone that you are located in. Specifying  the time zone is useful when scheduling tasks for users located in other  time zones. Tasks created in a particular time zone can be viewed in other  time zones as the time settings are automatically converted to the relative  time zone of the logged-in user. This time zone setting does not affect  your Time Clock schedules since the **Everest**  Time Clock module uses the time from the client workstation's operating  system settings and not the **Everest**  settings.


**Adjust clock for daylight saving changes**
: Select this option if you want your **Everest**  clock settings to be adjusted to reflect daylight saving time. You must  select this option during daylight savings time and clear this option  when it is not daylight savings time. For most of the United States, this  entails moving the clock forward by one hour on the second Sunday in March  and moving it back by an hour on the first Sunday of November. This change  affects your Contact Manager. It does not affect your Time Clock schedules  since the **Everest** Time Clock module  uses the time from the client workstation's operating system settings  and not the **Everest** settings.


{:.note}
This field defaults to the selection at your  last log in so it does not have to be changed every time you log in to  **Everest**.
: ![]({{site.wwe_baseurl}}/img/lens.gif)  [Setting  Reminders]({{site.cm_chm}}/reminders-tasks-appointments/setting_reminders.html)


**Date**
: Specify the date in which transactions made during  the current session must be recorded. This field defaults to the current  system date.


{:.note}
You can change the date after logging in,  by selecting the required date in the status bar. Click [here]({{site.wwe_baseurl}}/everest-client/main-window/status_bar.html)  for details. All transactions created after the date is changed will bear  the new date.


**Same as database server date**
: Select this option to ensure that all entries are  created with the database server date. When this option is selected, you  are not allowed to specify a date in the field beside this option. The  database server date is displayed by default in this field.
: If you clear this check box, you can change the  login date in the adjacent date field. Users from different time zones  may then log in using different dates. When you click OK, **Everest**  prompts you with a message that the login date differs from the database  server date. It informs you that such a change could lead to a mismatch  between the inventory and accounting reports at the time of creating transactions  and asks you if you want to continue. Clicking 'Yes' records an event  pertaining to the change of date.


{:.note}
If you do not log out of **Everest**  on a certain day, a similar message appears on your **Everest**  screen the next day. Clicking 'No' records an event for the same.
: Thereafter, if you create a document, another event  is recorded with reference to the number of the corresponding document.
: This is applicable to the following documents:

- Purchase invoice
- Debit memo
- Sales invoice
- Credit memo
- Work order
- Inventory adjustment  documents

: The following fields are updated when the event  is recorded in the **Transaction History**  browser:

- Document #
- Transaction  date - This is the database server date at the time of saving the document.
- Event
- Amount
- Reference date  - This is the date with which you have logged in to **Everest**.
- User

