---
title: Company Setup Profile - General Tab
---

# Company Setup Profile - General Tab


Use this tab to change the company code, description and postal details  of the company.


{:.note}
By default, the **Company****Setup** profile is automatically  populated with the details specified in the **Company****Creation Wizard**.


**Code**
: This field displays the code of the company. You  cannot modify this field.


**Web enabled**
: Select this check box to make this company available  on your **Everest eStorefront** store.


**Description**
: Enter the name of the company using 1 to 50 characters  of the supported type. By default, this field is populated with the legal  name specified in the **Company Creation 
 Wizard**.


**Address**
: Enter the address of the company using characters  of any type.


**City**
: Enter the name of the city where the company is  located. This field is automatically updated with the name of the city  if the country selected is United States and the zip code is also specified.


**State**
: Enter the state in which the company is located.  This field is automatically updated with the name of the state if the  country selected is United States and the zip code is also specified.


**Zip**
: Enter a zip code for the city in which the company  is located.


{:.note}
The zip code must be specified if the country selected is United States.


**Country**
: Specify the country in which the company is located.  If the country selected is United States, **Everest**  automatically populates the **City**  and **State** fields when a zip code  is specified.


**Telephone**
: Enter the telephone number in this field.


**Fax**
: Enter the fax number in this field.


You can change the details specified in this profile.


**Online Server**
: The **Online Server**  check box and the Location drop-down list box below it, pertain to the  **Everest POS Sync Utility** which  allows retail store locations to conduct POS activities without an internet  connection. Select the **Online Server**  checkbox to indicate that this is an **Everest 
 Online Server** (the Main Everest location) and select the exact  location in the field below it. The Administrator will copy the database  from the Online Server location to the Offline Server locations.
: Clear the checkbox to indicate that this is a remote  offline POS server location.
: You can only modify the **Online 
 Server** and location fields if there are no transactions or if the  transactions are completely processed (synchronized completely). If transactions  exist that are not yet synchronized, you will not be able to change these  fields. Changes will only impact future synchronizations.


**(Location)**
: The location selected from this drop-down list indicates  the location of the **Everest Online Server**.  If “Online Server” is selected, this field is mandatory. If “Online Server”  is not selected because the server is offline, the location of the Online  Server associated with the Offline Server is indicated in this field.
: You can only modify the **Online 
 Server** and location fields if there are no transactions or if the  transactions are completely processed (synchronized completely). If transactions  exist that are not yet synchronized, you will not be able to change these  fields. Changes will only impact future synchronizations.


{:.note}
It is the Administrator’s responsibility to  ensure that the correct online location is defined. We do not recommend  changing it often. If your business requires a change, such as shifting  the headquarters from VA to CA, then it can be done. This will only impact  future synchronizations.


{:.see_also}
See also
: [Company Setup  - Activation]({{site.sc_baseurl}}/company-set-up/company_setup_activation.html)
: [The **Company Setup** Profile]({{site.sc_baseurl}}/company-set-up/the_company_setup_profile.html)
