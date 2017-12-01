---
title: Document Number
---

# Document Number


The **Document #** field displays  the number assigned to a sales document when it is created. Sequence numbers  for sales documents are set in the **Location/Sub-Location**  profile (path: **File** > **Setup** > **Accounting**  > **Location**/**Sub-Location**  > **Options** > **Edit**  > **In** **New****Window**<font color="#800000" class="hcp2"> </font>>  **Invoicing** tab), of the logged  in location/sub-location from which you create the sales document.


![]({{site.sp_baseurl}}/img/lens.gif) [Location  and Sub-Location]({{site.sc_chm}}/options/locations-and-sub-locations/locations_and_departments.html)


If  sequence  numbers are not defined for the login location or sub-location,  the  sequence number specified in the **Default 
 Location** field (path: **File &gt; 
 Setup &gt; Preferences &gt; Defaults &gt; Accounting &gt; Miscellaneous** tab) is assigned to the document.


![]({{site.sp_baseurl}}/img/lens.gif) [Default  Location]({{site.sc_chm}}/misc/default_location.html)


**Everest** automatically assigns  the consecutive number to the sales document created subsequently.


{:.note}
If you change the location sequence number, you cannot  assign a number that is already used. The system prompts you to set a  proper range of sequence numbers.


![]({{site.sp_baseurl}}/img/example.gif) If  a quote is converted to an order or an order to an invoice, and the login  <font color="#000000" class="hcp9">location</font> is changed before saving the document,  the sequence number set for the logged in <font color="#000000" class="hcp9">location</font>  at the time of creating the order or invoice (although this is different  from the location for the original quote or order) is used.


Numbering for Document Aliases


Sequence numbers are assigned continuously. Documents using a different  alias are not assigned a different sequence.


![]({{site.sp_baseurl}}/img/example.gif) If  you create a sales quote with the number 1000 and the next sales quote  with an alias 'Service Quote',  the document number assigned to the 'Service Quote'  would be 1001.


**Manual 
 Numbering**


You cannot number the documents manually in **Everest**.  You can however, change the sequence number by altering it from the **Location** profile (path: **File**  > **Setup** > **Accounting**  > **Location**/ **Sub-Location**  > **Options** > **Edit**  > **In** **New****Window**<font color="#800000" class="hcp2"> </font>>  **Invoicing** tab). Every time you  change a sequence number, **Everest**  allots the next number in sequence to the documents, thereafter.


{:.note}
Sequence numbers once assigned are not re-assigned by  **Everest** even if the document is  discontinued or purged.


{:.see_also}
See also
: [Document  Information]({{site.sp_baseurl}}/sales-docs/docs-profile/contents/doc-info/document_information_sales_content.html)
