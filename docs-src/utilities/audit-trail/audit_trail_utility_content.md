---
title: Audit Trail
---

# Audit Trail Utility Programs


An audit trail is a track of all events and activities that have taken  place in the company's database, the date and time of the event and the  user responsible for it. It helps to fix responsibility and identify when  an event took place.


![]({{site.utl_baseurl}}/img/example.gif) If  the sales representative was changed on a sales document, the audit trail  for the document would allow you to see who made the change.


Audit trail in **Everest** is maintained  using the [All Events]({{site.utl_baseurl}}/audit-trail/event-history/event_history_utility_content.html) and  the<font style="color: #ff0000;" color="#FF0000"> </font>[Missing  Sequence Numbers]({{site.utl_baseurl}}/misc/missing_sequence_numbers_utility_content.html)<font style="color: #000000;" color="#000000"> </font>utility.


The **Event History** utility allows  you to view the events by function, by user, and to identify and trace  any event that occurs.


The **Missing Sequence Number**  utility allows you to maintain a trail of missing sequence numbers of  documents.


{:.note}
Since different users might log in with different  dates, events generated at the same time could be recorded with different  dates, leading to incorrect audit trail information. In order to prevent  this, **Everest** records events based  only on the database server time.
