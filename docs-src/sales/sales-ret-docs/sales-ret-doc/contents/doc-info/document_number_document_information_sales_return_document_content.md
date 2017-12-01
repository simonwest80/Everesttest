---
title: Document Number
---

# Document Number


The **Document #** field displays  the number assigned to a sales return document when it is created. Sequence  numbers for sales return documents are set in the **Location** profile (path: **File 
 &gt; Setup &gt; Accounting &gt; Location/Sub-Location** > **Options** > **Edit**  > **In New Window &gt; Invoicing**  tab<font color="#000000" class="hcp2">), of t</font>he logged in location/sub-location  from which you create the sales return document.


![]({{site.sp_baseurl}}/img/lens.gif) [Location/Sub-Location]({{site.sc_chm}}/options/locations-and-sub-locations/locations_and_departments.html)


If sequence numbers are not defined for the login location or sub-location,  then the sequence number assigned to the default location specified in  the **Default Location** field (path:  **File &gt; Setup &gt; Preferences &gt; 
 Defaults &gt; Accounting &gt; Miscellaneous**) is assigned to the  document.


![]({{site.sp_baseurl}}/img/lens.gif) [Default  Location]({{site.sc_chm}}/misc/default_location.html)


**Everest** automatically assigns  the next consecutive number to the sales return document created subsequently.


![]({{site.sp_baseurl}}/img/example.gif) If 1200 is the next number  in sequence for credit quotes for the login location/sub-location 'Mail  Order', then  1200 is assigned to a new credit quote created for the location/sub-location  'Mail Order'.


If a credit quote is converted to an order or an order is converted  to a memo, and the login <font color="#000000" class="hcp2">location</font> is changed  before saving the order or memo, then the sequence number set for the  logged in <font color="#000000" class="hcp2">location</font> is used at the time of creating  the order or memo (although this is different from the location for the  original quote or order).


**Numbering 
 for Document Aliases**


Document numbers are assigned continuously. Documents using a different  alias are not assigned a different sequence number.


![]({{site.sp_baseurl}}/img/example.gif) If you create a credit  quote with the number 1000 and the next credit quote created has an alias  'Return of Spares', the document number for the 'Return of Spares' would  be 1001.


Manual Numbering


You cannot number the documents manually  in **Everest**. You can however change  the sequence number by altering it from the **Location**  profile (path: **File &gt; Setup &gt; Accounting 
 &gt; Location/Sub-Location** > **Options**  > **Edit** > **In 
 New Window** > **Invoicing**  tab). Every time you change a sequence number, **Everest**  allots the next number in sequence to the documents, thereafter.


{:.note}
Sequence numbers once assigned will not be re-assigned  by **Everest** even if the document  has been discontinued or purged.


{:.see_also}
See also
: [Document  Information]({{site.sp_baseurl}}/sales-ret-docs/sales-ret-doc/contents/doc-info/document_information_sales_return_document_content.html)
