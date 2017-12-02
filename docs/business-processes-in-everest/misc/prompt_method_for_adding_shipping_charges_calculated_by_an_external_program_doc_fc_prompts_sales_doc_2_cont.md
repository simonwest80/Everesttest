---
title: Prompt method for adding shipping charges calculated by an external program
---

# Prompt method for adding shipping charges calculated by an external  program


You may use an external utility to compute shipping charges on your  sales documents. You have to map the external utility to the required  table and field in **Everest** in  order that the sales orders or invoices are updated with the computed  freight charges. Use this field to define whether or not the freight charges  computed in such a manner have to be automatically updated on the documents.


| **Option** | **Description** |
| <font color="#000000" class="hcp4">Prompt</font> | <font color="#000000" class="hcp4">Prompts you to confirm <br/> that the freight amount has to be updated when a sales order/invoice for <br/> which freight was computed is opened. </font> |
| <font color="#000000" class="hcp4">Automatic</font> | <font color="#000000" class="hcp4">The freight amount is <br/> automatically updated on the document when the sales order/invoice is <br/> opened.</font> |
| Do not update | Does not update freight charges. |



![]({{site.bp_baseurl}}/img/note.gif)  The  item code specified in the **Default item 
 used for shipping charges** field (path: **File** > **Setup** > **Preferences**  > **Defaults** > **Items**)  is used to account for the freight charges on the sales order/invoice.


{:.see_also}
See also
: [Prompts  - Sales Document - Sales Document 2]({{site.bp_baseurl}}/flow-ctrl/ctrl/doc-frm/prompts/sales-prompts/prompts_sales_document_sales_document_2.html)
