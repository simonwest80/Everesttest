---
title: Sales/Purchase Document
---

# Sales/Purchase Document


Use the fields in the **Location**  profile - **Invoicing** and **Purchasing** tabs to specify the next  sequence numbers for the documents. Document numbers can also start in  the middle of a series. You can use this feature to continue a series  from your old accounting system. You can modify sequence numbers whenever  necessary.


We recommend that you start the sequence numbers for each  location with a different number, such as 10000 for the first location  and 20000 for the next location.


If your sequence numbers overlap in different locations,  a confirmation message displays when saving sales documents.


![]({{site.sc_baseurl}}/img/confirmation_message_with_duplicate_sequence_no_at_diff_locations_sc.gif)


**Figure: Sequence Number Confirmation Message**


If you select **Yes**,  the system uses the next available sequence number. If you select **No**, you will have the opportunity to  adjust your sequence number ranges in the Location profiles before continuing.


{:.example}
Suppose the last sales order created in the  MAIN location is numbered 200451 and the next sequence number in the CA  Location profile is 200452. Create a sales order in the MAIN location  and then create a sales order in the CA location. You will receive this  confirmation message when you create the sales order in the CA location.


Sub-Locations cannot have sequence numbers different from  those of the location.


{:.hint}
The sequence number of one location should  not overlap with that of another, if each document has to have a unique  number.


The sequence numbers specified for the location of the login  location/sub-location are used. If no sequence numbers are not specified  in the **Location** profile, the sequence  numbers specified in the default location are used.


{:.see_also}
See also
: [Sequence  Numbers]({{site.sc_baseurl}}/misc/sequence_numbers_departments.html)
: [**Location** profile - Purchase tab]({{site.sc_baseurl}}/options/locations-and-sub-locations/set-up-locations/location_profile_purchasing.html)
: [**Location**  profile - Invoicing tab]({{site.sc_baseurl}}/options/locations-and-sub-locations/set-up-locations/location_profile_invoicing.html)<font style="color: #008000;" color="#008000"> </font>
