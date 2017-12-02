---
title: Document Alias
---

# Document Alias


The document alias distinguishes a document from others of the same  type.


{:.example}
You could create the aliases ‘Request for  Quote’ and  ‘Service Quote’  for the document type ‘Purchase Quote’.


![]({{site.pp_baseurl}}/img/lens.gif) [Document  Aliases]({{site.bp_chm}}/flow-ctrl/defs/alias-defs/document_aliases_defaults.html)


When you create a purchase document, the default alias assigned to the  document type is displayed. This default alias is selected in the **Document** **Alias**  dialog box (path: **File** > **Setup** > **Preferences**  > **Defaults** > **Document****Alias**). You can change the document's  alias.


You can also create a new purchase document with a specific alias using  the **Purchasing** > **Other Documents** option.


Processed Documents


When you convert a quote to an order or an order to a receipt or invoice,  the system uses the alias specified for the order, receipt, or invoice  in the relevant **Document Alias**  profile (path: **File** > **Setup** > **Miscellaneous**  > **Document** **Aliases**  > **Options** > **Edit**  > **In New Window**). If you have  not specified an alias, the system assigns the default document alias  specified in the **Document** **Alias** dialog box (path: **File**  > **Setup** > **Preferences**  > **Defaults** > **Document 
 Alias**).


{:.example}
A purchase quote with alias 'service quote'  is converted to a purchase order. The purchase order has been defined  an alias 'service order'. When the purchase quote is converted to a purchase  order, a 'service order' (alias for the purchase order) will be created.


Document Policy


When you change a document alias, **Everest**  asks you if you want to replace the document policy. Click ‘Yes’ to change  the policy and ‘No’ to retain the policy associated with the document.


{:.see_also}
See also
: [Selecting  a Document Alias]({{site.pp_baseurl}}/misc/selecting_a_document_alias.html)
