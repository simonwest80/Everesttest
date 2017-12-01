---
title: General Journal in which entries for Write off Quantity documents are made
---

# General Journal in which entries for Write off Quantity documents are  made


Accounting entries are created in a General Journal with the description  ‘Quantity Adjustment’.  These general journals cannot be modified or voided.


Entries are made in an open general journal that fulfils  the following conditions:

- The login  date corresponds with the accounting period of the journal.
- A journal’s  group is same as the journal group selected in **Workstation 
 Settings** of the user creating the inventory adjustment document.
- A journal’s  location/sub-location is same as the login  location/sub-location of the user creating the quantity adjustment document.
- A system journal  has the description ‘Quantity Adjustment’.



If no such open journal exists,  a new general journal is created. The general journal number for the new  journal is taken from the sequence number for general journals for the  login location  or the sub-location's parent  location.


If sequence numbers are not defined for the login  location or sub-location, then the document uses the sequence number assigned  to the default location. The default location is specified in the **Accounting** dialog box (path: **File 
 &gt; Setup &gt; Preferences &gt; Defaults &gt; Accounting &gt; Miscellaneous** tab **&gt; Default Location**  field).


| ![]({{site.wm_baseurl}}/img/lens.gif) | [Default  Location]({{site.sc_chm}}/misc/default_location.html)<br/><br/><br/>[Locations  and Sub-Locations]({{site.sc_chm}}/options/locations-and-sub-locations/locations_and_departments.html) |



The **General Journal** number and  transaction number for the entry are displayed in the **Inventory 
 Adjustment** document.


{:.see_also}
See also
: [Accounting  Entries for a Write off Quantity Document]({{site.wm_baseurl}}/misc/accounting_entries_for_a_write_off_quantity_document.html)
