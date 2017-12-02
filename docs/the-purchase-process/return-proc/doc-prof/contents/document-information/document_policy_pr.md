---
title: Document Policy
---

# Document Policy


Document policies are custom messages/notes/information/conditions attached  to the system documents (and their aliases) that print along with the  document (usually printed at the bottom of the document). This policy  can be edited from the purchase return document profile.


The document policy applicable to a document is determined using the  following rules:

1. If the vendor has  a specific document policy for that document type (path: **Purchasing**  > **Vendors** > select vendor  to view the **Vendor** profile >  **Document Policy** tab), then this  policy for the vendor is assigned to the document.



{:.example}
If a **Vendor**  profile has a policy associated for debit quotes, that policy will be  used in debit quotes when the vendor is selected.


**![]({{site.pp_baseurl}}/img/lens.gif) [Vendors  - Document Policy]({{site.mv_chm}}/vendor-details/document-policy/document_policy_vendors_content.html)**

1. If the **Vendor**  profile does not have a policy associated with that document type, then  the policy associated with the **Document****Alias** profile (path: **File** > **Setup** > **Miscellaneous** > **Document Aliases** >  **Document Alias** profile) is assigned  to the document.



**![]({{site.pp_baseurl}}/img/lens.gif) [Document  Policy]({{site.bp_chm}}/doc-policies/document_policies_business_process_content.html)**

1. If policies have  not been associated with both the **Vendor**  profile and the **Document** **Alias** profile, then the company's default  policy (path: **File** > **Setup** > **Preferences** >  **Defaults** > **Documents** > **Purchase Policy** tab)  for that document type is assigned to the document.



**![]({{site.pp_baseurl}}/img/lens.gif) [Defaults  - Documents]({{site.bp_chm}}/flow-ctrl/defs/document_defaults.html)**


When a quote is converted to an order or an order is converted to a  memo, you can either carry over the existing policy to the new document  or replace the policy with that of the new document type.


{:.see_also}
See also
: [Document Information]({{site.pp_baseurl}}/return-proc/doc-prof/contents/document-information/document_information_pr.html)
: [View  and Edit a Document Policy]({{site.pp_baseurl}}/misc/view_and_edit_a_document_policy_docuemnt_policy_purchase_return_doc_content.html)
