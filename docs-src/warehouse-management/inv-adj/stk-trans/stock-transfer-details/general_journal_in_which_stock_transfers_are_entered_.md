---
title: General Journal in which stock transfers are entered
---

# General Journal in which stock transfers are entered


Accounting entries are created in a General Journal with the description  'Stock Transfers'. You cannot modify or void the General Journals created  for stock transfers. No accounting entries are created for stock transfers  during the Request and In-Transit stages. Accounting entries are created  as defined earlier during the Completed stage.


Entries are made in an Open Stock Transfer journal that fulfils  the following conditions:

- The login  date corresponds with the accounting period of the journal.
- A journal's  group is same as the journal group selected in **Workstation Settings** of the user entering the stock transfer.
- A journal's  location/sub-location is same as the login location/sub-location of the user entering the stock transfer.
- A system journal  has the description 'Stock Transfer'. All stock transfers are created in a journal with the description 'Stock  Transfer'.

If no such open journal exists, a new general journal is created. The  general journal number for the new journal is taken from the sequence  number for general journals for the login location or the sub-location's  parent location.


If sequence numbers are not defined for the login  location or sub-location, then the document uses the sequence number assigned  to the default location (path: **File > Setup > Preferences > Defaults > Accounting > Miscellaneous** tab **Default Location**  field).

{:.lens}
[Locations  and Sub-Locations]({{site.sc_chm}}/options/locations-and-sub-locations/locations_and_departments.html)

The General Journal number and transaction number for the entry are  displayed in the **Stock Transfer** profile,  when you save the document.

Stock Transfer journals cannot be modified or voided.
