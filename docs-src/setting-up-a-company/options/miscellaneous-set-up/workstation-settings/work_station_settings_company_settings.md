---
title: Workstation Settings - Company Settings
---

# Workstation Settings - Company Settings


Use the **Company Settings** tab  to change the logged in location/sub-location, jurisdiction and time zone.  You can also specify the journal group and the multimedia repository.


**Database Server**
: The database server to which the workstation is  connected is displayed in this field.


**Application Server**
: The application server to which the workstation  is connected is displayed in this field.


**Company**
: The logged in company is displayed in this field.


**User**
: The logged in user is displayed in this field.


{:.note}
All the above mentioned fields are display  fields only and cannot be edited.


**Select  current settings**


**Location/Sub-Location**
: You can change the login location/sub-location displayed  in this field if required.
: ![]({{site.sc_baseurl}}/img/lens.gif) [Locations  and Sub-Locations]({{site.sc_baseurl}}/options/locations-and-sub-locations/locations_and_departments.html)


{:.note}
A security right is required to change the  Location/Sub-location in the Workstation Settings to any other Location/Sub-location.


**Jurisdiction**
: You can change the logged in jurisdiction displayed  in this field if required.
: ![]({{site.sc_baseurl}}/img/lens.gif) [Jurisdictions]({{site.sc_baseurl}}/options/sales-tax/tax-jurisdictions/setting_up_jurisdictions.html)


**Journal Group**
: Use this option to specify a journal group to which  all the journals generated from the current workstation must belong.
: ![]({{site.sc_baseurl}}/img/lens.gif) [Journal  Group]({{site.sc_baseurl}}/options/acc-info/journal-groups/journal_groups.html)


**Time Zone**
: You can change the logged in time zone displayed  in this field as required. This change does not affect your Time Clock  schedules since the **Everest** Time  Clock module uses the time from the client workstation’s operating system  settings and not the **Everest** settings.


**Adjust clock for daylight saving changes**
: Select this option if you want your **Everest**  clock settings to be adjusted to reflect daylight saving time. You must  select this option during daylight savings time and clear this option  when it is not daylight savings time. For most of the United States, this  entails moving the clock forward by one hour on the second Sunday in March  and moving it back by an hour on the first Sunday of November. This change  affects your Contact Manager. It does not affect your Time Clock schedules  since the **Everest** Time Clock module  uses the time from the client workstation’s operating system settings  and not the **Everest** settings.


**Multimedia Repository**
: Specify the directory in which the multimedia files  will be saved when they are attached to any profile in **Everest**  from the multimedia setup browser.
: ![]({{site.sc_baseurl}}/img/lens.gif) [Multimedia]({{site.sc_baseurl}}/options/miscellaneous-set-up/multimedia/multimedia_setupco.html)
: [Multimedia Repository]({{site.sc_baseurl}}/options/miscellaneous-set-up/multimedia/multimedia_repository.html)


**<font style="color: #000000;" color="#000000">Enable Extended Mode</font>**


Check this box to enable the extended mode functionality, which displays  the following additional features in **Everest:**

- The **Item 
 Stock Status** dialog box displays both average and last cost of  items without factoring.
- The **Serial 
 Numbers** browser displays both average and last cost of items without  factoring.
- The **Items**  browser displays both average and last cost of items without factoring.
- Zip codes can be  added or modified from the **Zip Codes**  browser.



You must have adequate security rights to enable or disable this option.


{:.note}
The costs of only commissionable  items (inventoried and non-inventoried) are listed in the **Pricing 
 Analysis** browser when the user is not in extended mode. If the  user has logged into extended mode, then costs of all items are listed  in the **Pricing Analysis** browser,  except for costs of non-inventoried items without an expense and liability  account. Costs of non-inventoried commissionable  items are listed only if the item has expense and liability accounts defined  in its profile.


If you leave this option unchecked, the credit card numbers are masked  in the following browsers and reports:


Browsers

- Payment History  Browser in documents
- POS Receipts
- Customer Profile
- Credit Card Browser
- Detail Activities  Browser
- Payment Journal  Transaction Browser
- Receipt Journal  Transaction Browser
- Payment Register  Browser
- Posted Payment  Transaction Browser
- Posted Receipt  Transaction Browser
- Batch Payment Browser
- Events History  Browser
- Transaction History  Browser in documents (Sales and Purchase)



Reports

- Collection Report
- Receipts Journal
- Receipts Journal  (Posted)
- Payments Journal
- Payments Journal  (Posted)
- Activity Report
- Payments to Vendor  Report
- Vendor Transactions/Customer  Transactions
- Customer Statements/Vendor  Statements



{:.see_also}
See also
: [Workstation  Settings Dialog Box]({{site.sc_baseurl}}/options/miscellaneous-set-up/workstation-settings/the_work_station_settings_dialog_box.html)
