---
title: Sequence Numbers
---

# Sequence Numbers


Sequence numbers are the numbers assigned by **Everest**  to all the documents (purchasing, sales and returns), vendors, customers  and serialized inventory items. The first sequence number for each of  the documents is set in the **Location**  profile (path: **File &gt; Setup &gt; Accounting 
 &gt; Location/Sub-Location &gt; Options &gt; New &gt; Location &gt; In 
 New Window**). **Everest** assigns  the number automatically.


You can specify a different range of sequence numbers for each location.  Sequence numbers can be specified for items, customers, vendors, each  type of sales and purchase document and each type of journal.


When a new customer or vendor is created and the customer/vendor code  is left blank, the sequence number for customers/vendors specified for  the login location or the location of the login sub-location is assigned.  If sequence numbers are not mentioned for the login location or the location  of the login sub-location, the sequence numbers for the default location  are used.


When a sales or purchase document is created, the sequence number of  the location for that document type is used.


When a journal is created,  the  sequence number for the login location/sub-location for that journal type  is used.


{:.note}
**Serial numbers are assigned continuously.  Documents using alias are not assigned a different sequence. To start  a new sequence, you can change the sequence numbers manually in the **Location** profile. Sequence numbers of  purged documents are not available for use when creating documents.**


{:.see_also}
See also
: [How  location classification works]({{site.sc_baseurl}}/options/locations-and-sub-locations/how_departmentalization_works.html)
