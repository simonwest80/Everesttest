---
title: Document Alias
---

# Document Alias


The document alias distinguishes the document from other documents of  the same type.


{:.example}
You could create two aliases 'Request for  Vendor RMA - Products' and 'Request for Vendor RMA - Service' for the  document type 'debit quote'.


![]({{site.pp_baseurl}}/img/lens.gif) [Document  Aliases]({{site.bp_chm}}/doc-aliases/document_aliases_businesss_process_in_everest_content.html)


When you create a purchase return document, the default alias for the  purchase return document is displayed. The default alias for a document  type is selected in the **Document Alias**  dialog (path: **File** > **Setup** > **Preferences** >  **Defaults** > **Document 
 Aliases**).


You can also create a new purchase return document with a specific alias  using the **Purchasing** > **Other** **Documents**  option.


![]({{site.pp_baseurl}}/img/lens.gif) [Defaults  - Document Aliases]({{site.bp_chm}}/flow-ctrl/defs/alias-defs/document_aliases_defaults.html)


Processed Documents


When you convert a quote to an order or an order to a memo, the system  uses the alias specified for the order or memo in the relevant **Document 
 Alias** profile (path: **File**  > **Setup** > **Miscellaneous**  > **Document** **Aliases**  > **Options** > **Edit**  > **In New Window**). If you have  not specified an alias, the system assigns the default document alias  specified in the **Document** **Alias** dialog box (path: **File**  > **Setup** > **Preferences**  > **Defaults** > **Document 
 Alias**).


{:.example}
A debit quote with alias 'service quote' is converted  to a debit order. The debit order has been assigned an alias 'service  order'. When the debit quote is converted to a debit order, a 'service  order' (alias for the debit order) will be created.


If the alias for the order is blank, and the default  debit order alias specified in the **Document****Alias** dialog box is 'debit order',  then the 'Service Quote' is converted to 'debit order'.


**Document Policy**


When you change a document's alias, **Everest**  will prompt you that the document policy associated with the document  alias is different from that of the document. Click 'Yes' to change the  policy and 'No' to retain the policy associated with the document.


{:.see_also}
See also
: [Select  a Document Alias]({{site.pp_baseurl}}/misc/selecting_a_document_alias.html)
: [Document Information]({{site.pp_baseurl}}/return-proc/doc-prof/contents/document-information/document_information_pr.html)
