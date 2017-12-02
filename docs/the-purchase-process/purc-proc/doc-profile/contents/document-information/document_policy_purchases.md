---
title: Document Policy
---

# Document Policy


Document policies are custom messages/notes/conditions or any other  information attached to system documents (and their aliases) that print  along with the document (usually printed at the bottom of the document).


It is displayed in the **Document Policy**  dialog box. You can edit this policy from the purchase document profile.


The policy applicable to a document is determined using the following  rules:

- If the vendor  has a specific document policy defined for that document type in the **Vendor** profile (path: **Purchasing**  > **Vendors** > **Options**  > **Edit** > **In 
 New Window** > **Document****Policy** tab), then this policy  is assigned to the document.



{:.example}
If a vendor profile has a policy associated  for purchase quotes, that policy will be used in purchase quotes when  the vendor is selected.


**![]({{site.pp_baseurl}}/img/lens.gif) [Document  Policy]({{site.mv_chm}}/vendor-details/document-policy/document_policy_vendors_content.html)**

- If the **Vendor** profile does not have a policy  associated with that document type, the policy associated with the **Document Alias** profile (path: **File** > **Setup** > **Miscellaneous** >  **Document Aliases** > **Options**  > **Edit** > **In 
 New Window**) is assigned.



**![]({{site.pp_baseurl}}/img/lens.gif) [Document  Alias - Document Policy]({{site.bp_chm}}/doc-aliases/info/document_type_document_alias_document_policy_web_enabled_fields_doc_alias_content_businesss_process_in_everest_content.html)**

1. If a policy  is not associated in either profile, the company's default policy (path:  **File** > **Setup**  > **Preferences** > **Defaults**  > **Documents** > **Purchase Policy** tab) for that document type is assigned.



**![]({{site.pp_baseurl}}/img/lens.gif) [Defaults  - Documents]({{site.bp_chm}}/flow-ctrl/defs/document_defaults.html)**


When a quote is converted to an order, or an order is converted to a  receipt or invoice, you can either carry over the existing policy to the  new document or replace the policy with that of the new document type.


{:.see_also}
See also
: [Document  Information]({{site.pp_baseurl}}/purc-proc/doc-profile/contents/document-information/document_information_purchasing.html)
: [View  and Edit a Document Policy]({{site.pp_baseurl}}/misc/view_and_edit_document_policy_purchase_document.html)
