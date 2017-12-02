---
title: Document Alias
---

# Document Alias


The document alias distinguishes a sales return document from other  sales return documents of the same type.


![]({{site.sp_baseurl}}/img/example.gif)<font color="#000000" class="hcp2"> 
 </font>You could create two aliases Customer RMA  - Quotes (for items returned) and customer return quotes - service (for  unsatisfactory service) for the document type 'Credit Quote'.


![]({{site.sp_baseurl}}/img/lens.gif)<font color="#000000" class="hcp2"> </font>[Document  Aliases]({{site.bp_chm}}/doc-aliases/document_aliases_businesss_process_in_everest_content.html)


When you create a new sales return document from the Credit Quote, Order  or Memo browser, the default alias specified for each type of document  in the default preferences (path: **F****ile &gt; Setup &gt; Preferences &gt; Defaults 
 &gt; Document Alias**) is displayed in the document. A different  alias can be selected for a document, if required.


![]({{site.sp_baseurl}}/img/note.gif)<font color="#000000" class="hcp2"> You can also create a new document with a specific alias 
 from the browser (path: </font>**Invoicing**<font color="#000000" class="hcp2"> &gt; </font>**Other Documents**<font color="#000000" class="hcp2">).</font>


When you convert a credit quote or a credit order with a specified document  alias, the alias specified for the order or the memo in the profile of  the quote or order (which is converted) is used. If the alias for the  order is blank, then the default alias for the order or memo is used.


![]({{site.sp_baseurl}}/img/lens.gif) [Document  Aliases Defaults]({{site.bp_chm}}/flow-ctrl/defs/alias-defs/document_aliases_defaults.html)


![]({{site.sp_baseurl}}/img/example.gif)<font color="#000000" class="hcp2"> You convert a credit quote with the alias customer RMA 
 quote to an order. The alias for credit orders in the customer RMA 
 quote's profile is RMA 
 order. RMA 
 order will be the alias used for the converted order.</font>


<font color="#000000" class="hcp2">If 
 the alias for the order is blank, and the default credit order alias defined 
 in the </font>**Document 
 Alias**<font color="#000000" class="hcp2"> dialog box (path: </font>**File**<font color="#000000" class="hcp2"> &gt; </font>**Setup**<font color="#000000" class="hcp2"> &gt; </font>**Preferences**<font color="#000000" class="hcp2"> &gt; </font>**Defaults**<font color="#000000" class="hcp2"> &gt; </font>**Document Alias**<font color="#000000" class="hcp2">)</font> is credit order, then the customer RMA  quote is converted to a credit order.


{:.see_also}
See also
: [Select  a Different Document Alias]({{site.sp_baseurl}}/sales-ret-docs/sales-ret-doc/contents/doc-info/select_a_different_document_alias.html)
: [Document  Information]({{site.sp_baseurl}}/sales-ret-docs/sales-ret-doc/contents/doc-info/document_information_sales_return_document_content.html)
