---
title: Document Policy
---

# Document Policy


Document policies are custom messages/notes/information/conditions attached  to the system documents (and their alias) that print along with the document  (usually printed at the bottom of the document).


The policy that is applicable to the document is displayed in the document  policy section of the status bar. This policy can be edited from the sales  return documents.


The document policy applicable to a document is determined using the  following rules:

1. **If the customer has  a specific document policy for that document type, then the document policy  for the customer is selected.**



![]({{site.sp_baseurl}}/img/example.gif) If  a document policy for credit quotes is associated in the **Customer**'s  profile, that policy is displayed.


![]({{site.sp_baseurl}}/img/lens.gif) [Customers  - Document Policy]({{site.mc_chm}}/customer-details/document-policy/document_policy_content.html)

1. **If the customer does  not have a policy associated with that document type, then the policy  associated with the document alias is displayed.**
- **If both the customer  and the document alias do not have a policy associated, then the company's  default policy for that document type is used (path: **File 
 &gt; Setup &gt; Preferences &gt; Defaults &gt; Documents &gt; Purchase 
 Policy** tab**/Sales Policy** tab).**



![]({{site.sp_baseurl}}/img/lens.gif) [Documents Defaults]({{site.bp_chm}}/flow-ctrl/defs/document_defaults.html)


When a credit quote is converted to a credit order, or when a credit  order is converted to a credit memo, the document policy applicable to  the order or memo is determined and applied to the converted document.


{:.see_also}
See also
: [View  or Edit the Document Policy]({{site.sp_baseurl}}/sales-ret-docs/sales-ret-doc/contents/doc-info/view_or_edit_the_document_policy.html)
: [Document  Information]({{site.sp_baseurl}}/sales-ret-docs/sales-ret-doc/contents/doc-info/document_information_sales_return_document_content.html)
