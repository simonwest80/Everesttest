---
title: Events Log Browser - Options
---

# Events History Browser - Options


The fields available in the **Events 
 History** browser are listed below:


**Dates**
: Specify the period for which the records are to  be displayed.


{:.note}
All date options (such as today and this week) are with respect to the  login date.


**![]({{site.utl_baseurl}}/img/lens.gif) [Date  Filter]({{site.wwe_chm}}/misc/date_filter.html)**


**From and To**
: Specify the date range for which the records must  be displayed.


{:.note}
These fields are automatically updated for all options other than the  **Custom** option.


**Apply**
: Click this button to filter the records for display  in the browser, based on the input in the **From**  and **To** fields.


{:.note}
The **Apply** button is enabled  only if the **Custom** option is selected  in the **Dates** field.


**Purge**
: Use this option to delete event transaction records  permanently from the database.
: ![]({{site.utl_baseurl}}/img/lens.gif) [Purge  Event Log]({{site.utl_baseurl}}/db-utils/purge/purge_event_log_utility_content.html)


The **Events 
 History** browser displays the following information:


| **Field** | **Description** |
| Date | Displays the date on which the Purchase  Receipt/Invoice was modified. |
| Time | Displays the time at which the Purchase  Receipt/Invoice was modified. |
| User | Displays the name of the user who modified  the Purchase Receipt/Invoice. |
| Event | Purchase Receipt/Invoice Cost Modified. |
| Description | Purchase Receipt/Invoice Cost Modified. |
| Action | Modify |
| Amount | Displays the New Document Amount. |
| Payment | Displays the payment amount (where the  event pertains to a payment transaction). |
| Document | Displays the document type. |
| Reference | Displays the corresponding Cost Adjustment Document # and General Journal  #. |
| Reference Date | Displays the Original Purchase Receipt/Invoice  created date. |
| Category | Displays the event category. |
| Product Type | Displays whether **Everest**  or an external application initiated the event. If an **Everest**  client initiates the event, Desktop appears in this field. If an external  application initiates the event, the name of that application is displayed,  such as E-Commerce, Web Access, Mail Bridge, Everest API, or Other. |



Options common to all browsers are also available in this browser.


{:.see_also}
See also
: [Event  History]({{site.utl_baseurl}}/audit-trail/event-history/event_history_utility_content.html)
: [Standard  Browser Options]({{site.wwe_chm}}/everest-client/ui/browsers/standard_browser_options.html)
