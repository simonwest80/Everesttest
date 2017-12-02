---
title: Purchase Journal in which price protection entries are made
---

# Purchase Journal in which price protection entries are made


Accounting entries are created in a Purchase Journal with the description  ‘Price Protection’.  Such purchase journals cannot be modified or voided.


Entries are made in an open Purchase Journal that fulfils  the following conditions:

- The login  date corresponds with the accounting period of the journal.
- A journal’s  group is same as the journal group selected in **Workstation 
 Settings** of the user creating the price protection document.
- A journal’s  location/sub-location is same as the login  location/sub-location of the user creating the price protection document.
- A system journal  has the description ‘Price Protection’.



If no such open journal exists, a new purchase journal is created. The  purchase journal number for the new journal is taken from the sequence  number for purchase journals for the login location or the sub-location's  parent location.


If sequence numbers are not defined for the login  location or sub-location, then the document uses the sequence number assigned  to the default location. The default location is specified in the **Accounting** dialog box (path: **File 
 &gt; Setup &gt; Preferences &gt; Defaults &gt; Accounting &gt; Miscellaneous** tab **&gt; Default Location**  field).


| ![]({{site.wm_baseurl}}/img/lens.gif) | [Default  Location]({{site.sc_chm}}/misc/default_location.html)<br/><br/><br/>[Locations  and Sub-Location]({{site.sc_chm}}/options/locations-and-sub-locations/locations_and_departments.html) |



The Purchase Journal number and transaction number for the entry are  displayed in the inventory adjustment document.
