---
title: Copying Events
---

# Copying Events


Once you have created the new application, copy the required events  from the sample events.


{:.steps}
To copy the events from the sample events  pack into the new application, do the following:

- Open the **Everest CRM 
 Studio Architect** window and select **Application 
 Events**.
- Select the  sample company application and click on **Events**.  You will see the list of existing sample events.
- Select the  event in the right panel and choose **Edit 
 &gt; Copy** from the menu.
- Now select  **Events** under the new application  you have created. Choose **Edit &gt; Paste**.  The event gets copied into the new application.
- Similarly,  copy the required events one by one from the reference pack and paste  them into the new application.



It is not enough to copy the event from the reference pack into another  application. Copy the related query definitions, report definitions, scheduled  reports and basic scripts (if any) associated with the event in a similar  way as said above.


{:.note}
All the associated queries, reports, etc.  should refer to the new application that you created and not the sample  company application. Hence, if a query is copied it has to be removed  and again added using the new application.


For example, you have created a new application APP1. You copy an event  X and a query Y  (associated with event X) from the sample events into APP1. Now double-click  on the event X in APP1. Note that the query selected for content in the  **Queries** tab refers to the APP1  application. If not, select and remove the query (use **Remove 
 Query**) and add the query again (use **Add 
 Query**) ensuring that you are adding it from the application APP1.


{:.see_also}
See also
: [Upgrading Events]({{site.crm_baseurl}}/misc/upgrading_events.html)
