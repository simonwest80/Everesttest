---
title: Document Number
---

# Document Number


The **Document** # field displays  the number assigned to a purchase return document when it is created.  **Everest** automatically assigns  the next sequence number generated in the **Location**  profile to the next purchase return document created. Sequence numbers  are assigned continuously.


Sequence numbers for purchase return documents are set in the **Location** profile (path: **File**  > **Setup** > **Accounting**  > **Location**/**Sub-Location**  > **Location** profile > **Purchasing** tab), of the logged in location/sub-location  from which you create the purchase return document.


If a sequence number is not defined for the login location or sub-location,  the sequence number assigned to the **Default 
 Location** (path:<font color="#0000FF" face="Verdana" class="hcp2"> </font>**File**  > **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **Miscellaneous** tab)<font color="#0000FF" face="Verdana" class="hcp2"> </font>is assigned to the document.


| ![]({{site.pp_baseurl}}/img/lens.gif) | [Location/Sub-Location]({{site.sc_chm}}/options/locations-and-sub-locations/locations_and_departments.html)<br/><br/><br/>[Sequence  Numbers]({{site.sc_chm}}/misc/sequence_numbers_departments.html) |



Numbering Document Aliases


Documents created with a different alias  are not assigned a different sequence. The next number in the sequence  is used for all documents of a particular type, irrespective of the document  alias.


{:.example}
If you create a debit quote with the number  1000 and the next debit quote created has an alias 'Return of Spares',  the document number for the 'Return of Spares' would be 1001.


Manual Numbering


You cannot number the documents manually in **Everest**.  You can however, change the sequence number by changing it from the **Location** profile (path: **File**  > **Setup** > **Accounting**  > **Location**/**Sub-Location**  > **Location** profile> **Purchasing** tab). Every time you change  a sequence number, **Everest** allots  the next number in sequence to the documents, thereafter.


**Processed Documents**


If a quote is converted to an order, or an order is converted to a memo,  and the login location is changed before saving it, the system uses the  sequence number set for the logged-in location even though it is different  from the location on the original quote or order.


{:.note}
Sequence numbers once used cannot be re-used  even if the document has been discontinued or purged.


{:.see_also}
See also
: [Document Information]({{site.pp_baseurl}}/return-proc/doc-prof/contents/document-information/document_information_pr.html)
