---
title: Schedule Information
---

# Schedule Information


The schedule information is specified in the **Occurs**  and **Duration** sections.


Occurs


This option allows you to specify whether the sales orders have to be  generated on a daily, weekly or monthly basis.


The required number of sales orders are created as soon as the schedule  is defined. The creation date of each sales order will, however, be as  per the defined schedule.


![]({{site.sp_baseurl}}/img/example.gif) If  you have specified that sales orders should be created on the first of  every month for the period January to December 2009, 12 sales orders are  created as soon as you click **OK** in  the **Recurrence pattern** dialog  box. The creation dates of the sales orders will be the 1st of every month.


**Daily**
: Select the **Daily** option to create a sales order:

- On each day  of the selected period.

: ![]({{site.sp_baseurl}}/img/example.gif) Enter 1 in this field to create a sales order every day during  the period specified in the **Duration**  section.

- On every 'nth'  day of the selected period.

: ![]({{site.sp_baseurl}}/img/example.gif) Specify  3 in this field to create sales orders every third day during the period  specified in the **Duration** section.
: When **Daily** is  selected, the **Every &lt;number of &gt; 
 Day(s)** field  is enabled. Specify the frequency of the schedule in this field.


{:.note}
The maximum number of days that can be specified is  100.


**Weekly**
: Select the **Weekly** option to set a weekly schedule for creating sales orders. The  **Every &lt;number of&gt; Week(s) 
 on** field and the week day check boxes are enabled. Select the required  fields based on your schedule.
: ![]({{site.sp_baseurl}}/img/example.gif) To create sales orders every alternate Friday, enter 2 in  the **Every &lt;number of&gt; Week(s) 
 on** field and select the **Friday** check box.


{:.note}
The maximum number of weeks that can be specified is  100.


**Monthly**
: Select the **Monthly** option to set a monthly schedule for creating sales orders.
: You can set the monthly schedule in two ways:

- Based on the  day of the month.

: ![]({{site.sp_baseurl}}/img/example.gif) To  create sales orders on the 30th day of every third month specify '30'  in **Day &lt;number of&gt; days**  and '3' in **every &lt;number of&gt; Month(s)**.

- Based on the  week day.

: ![]({{site.sp_baseurl}}/img/example.gif) To  create sales orders on the last Friday of every third month specify 'Last  Friday' and  3 in **The &lt;number&gt; of every &lt;number&gt; 
 month(s)** field.


{:.note}
The maximum number of weeks that can be specified is  100


Duration


This section allows you to specify the time period during which the  sales orders must be created.


**From**
: Specify the start date from which the parameters  defined in the **Occurs** section  apply. This field defaults to the login date.


**To**
: Specify the end date till which the parameters defined  in the **Occurs** section apply.


{:.see_also}
See also
: [The  Recurrence Pattern Dialog Box]({{site.sp_baseurl}}/sales-docs/recur-billing/define-recurrence-pattern/the_recurrence_pattern_dialog_box.html)
