---
title: Document Policy
---

# Document Policy


Document policies are custom messages/notes/information/conditions attached  to the system documents (and their alias) that print along with the document  (usually printed at the bottom of the document).


You can edit this policy from the Point of Sale documents.


You cannot attach a policy for a default Point of Sale customer (POS\_CUST).  However, if you select a customer that has a customer code and is not  a default Point of Sale customer (POS\_CUST),  the document policy applicable to a document is determined using the following  rules:


The document policy applicable to a document is determined using the  following rules:

- If the customer/  Point of Sale default customer (POS\_CUST)  has a specific document policy for that document type (Point of Sale invoice/sales  credit), it is automatically selected.



<font color="#800080" class="hcp1"><img src="{{site.pos_baseurl}}/img/lens.gif" x-maintain-ratio="TRUE" style="width:26px; height:27px;" width="26" height="27" border="0" class="hcp2"> </font>[Customers  - Document Policy]({{site.mc_chm}}/customer-details/document-policy/document_policy_content.html)

- If the customer/  Point of Sale default customer (POS\_CUST)  does not have a policy associated with that document type, the policy  associated with the document alias is displayed.



<font color="#800080" class="hcp1"><img src="{{site.pos_baseurl}}/img/lens.gif" x-maintain-ratio="TRUE" style="width:26px; height:27px;" width="26" height="27" border="0" class="hcp2"> </font>[Document  Alias - Document Policy]({{site.bp_chm}}/doc-policies/document_policies_business_process_content.html)

- If both the customer/  Point of Sale default customer (POS\_CUST)  and the document alias do not have a policy associated, the company's  default policy for that document type is used.



<font color="#800080" class="hcp1"><img src="{{site.pos_baseurl}}/img/lens.gif" x-maintain-ratio="TRUE" style="width:26px; height:27px;" width="26" height="27" border="0" class="hcp2"> </font>[Documents  Defaults]({{site.bp_chm}}/flow-ctrl/defs/document-policies-defaults/document_policies_defaults.html)


{:.see_also}
See also
: [View  and Edit Document Policy]({{site.pos_baseurl}}/misc/view_and_edit_document_policy.html)
: [Document  Policy]({{site.bp_chm}}/doc-policies/document_policies_business_process_content.html)
: [Document  Information]({{site.sp_chm}}/sales-docs/docs-profile/contents/doc-info/document_information_sales_content.html)
