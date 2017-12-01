---
title: Document Number
---

# Document Number


The **Document** # field displays  the number assigned to a purchase document when it is created. **Everest**  automatically assigns the sequence number generated in the **Location**  profile to the next purchase document created. Sequence numbers for purchase  documents are set in the **Location**  profile (path: **File** > **Setup** > **Accounting**  > **Location**/**Sub-Location**  > **Options** > **Edit**  > **In New Window** > **Purchasing** tab) of the logged in location/sub-location.


If a sequence number is not defined for the login location, the sequence  number for the **Default Location**  (path:<font color="#0000FF" face="Verdana" class="hcp2"> </font>**File**  > **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **Miscellaneous** tab)<font color="#0000FF" face="Verdana" class="hcp2"> </font>is assigned to the document.


| ![]({{site.pp_baseurl}}/img/lens.gif) | [Location/Sub-Location]({{site.sc_chm}}/options/locations-and-sub-locations/locations_and_departments.html)<br/><br/><br/>[Sequence  Numbers]({{site.sc_chm}}/misc/sequence_numbers_departments.html) |



**Numbering Document Aliases**


Documents created with different aliases are not assigned a different  sequence. The next number in the sequence is used for all documents of  a particular type.


{:.example}
If you create a purchase quote with the number  1000 and the next purchase quote has an alias ‘Replacement Parts Quote’,  the document number assigned to the ‘Replacement Parts Quote’  would be 1001.


**Manual Numbering**


You cannot number the documents manually in **Everest**.  You can, however, change the sequence number from the **Location**  profile (path: **File** > **Setup** > **Accounting**  > **Location**/**Sub-Location**  > **Options** > **Edit** > **In New Window**  > **Purchasing** tab). Every time  you change a sequence, **Everest**  allots the next number in the sequence to documents created thereafter.


**Processed Documents**


If a quote is converted to an order, or an order is converted to a receipt  or invoice, and the login location is changed before saving it, the system  uses the sequence number set for the logged-in location even though it  is different from the location on the original quote or order.


{:.note}
Sequence numbers once assigned cannot be reused,  even if the document has been discontinued or purged.


{:.see_also}
See also
: [Locations  and Sub-Location]({{site.sc_chm}}/options/locations-and-sub-locations/locations_and_departments.html)
: [Document  Information]({{site.pp_baseurl}}/purc-proc/doc-profile/contents/document-information/document_information_purchasing.html)
