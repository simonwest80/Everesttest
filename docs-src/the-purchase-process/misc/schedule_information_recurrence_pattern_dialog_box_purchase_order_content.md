---
title: Schedule Information
---

# Schedule Information


The schedule information is specified in the Occurs and Duration sections.


Occurs


This section allows you to specify if the purchase orders have to be  generated on a daily, weekly or monthly basis.


The required number of purchase orders are created once you define the  schedule. The creation date of each purchase order is as per the defined  schedule.


**Daily**
: Select the **Daily**  option to create a purchase order:

- On every day  of the selected period.



{:.example}
Enter 1 in this field to create a purchase  order every day during the specified period.

- On every ‘nth’  day of the selected period.



{:.example}
Specify 3 in this field to create purchase  orders every third day during the specified period.
: When you select the **Daily**  option, the **Every** <**number****of** > **Day**(**s**) field  is enabled. Specify the frequency of the schedule in this field.


{:.note}
The maximum number of days that can be specified  is 100.


**Weekly**
: Select the **Weekly**  option to set a weekly schedule for creating purchase orders. The **Every** <**number****of**> **Week**(**s**) **on** field and the **week****day** check boxes are enabled. Select  the required fields based on your schedule.


{:.example}
To create purchase orders every alternate  Friday, enter 2 in the **Every** <**number** **of**>  **Week**(s)  on field and select the **Friday**  check box.


{:.note}
The maximum number of weeks that can be specified is  100.


**Monthly**
: Select the **Monthly**  option to set a monthly schedule for creating purchase orders. You can  set the monthly schedule in two ways:

- Based on the  day of the month.



{:.example}
Purchase orders can be created on the 30th  day of every third month. Set this up by specifying ‘30’ in **Day**  <**number** **of**>  days and '3’ in **every** <**number** **of**>  **Month**(s)  field.

- Based on the  week day.



{:.example}
Purchase orders can be created on the last  Friday of every month. Set up this schedule by specifying ‘Last Friday’  and 3 in **The** <**number**>  **of** **every**  <**number**> **month**(s)  field.


{:.note}
The maximum number of weeks that can be specified is  100.


Duration
: Specify the time period during which the parameters  defined in the **Occurs** section  apply.


****From****


Specify the starting date from which the  parameters defined in the **Occurs**  section apply. By default this field displays the login date.


**To**
: Specify the end date till which the parameters defined  in the **Occurs** section apply.


{:.see_also}
See also
: [The  Recurrence Pattern Dialog Box]({{site.pp_baseurl}}/purc-proc/recur-pmnts/define-recurrence-pattern/the_recurrence_pattern_dialog_box_purchase_orders_contents.html)
